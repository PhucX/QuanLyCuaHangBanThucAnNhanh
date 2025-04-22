using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Transactions;
using System.Data.Linq;
using System.Windows;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class VoucherAdminService : IVoucherAdminService
    {
        private readonly IMemberService _memberService; // Inject MemberService

        // Constructor cho Dependency Injection
        public VoucherAdminService(IMemberService memberService)
        {
            _memberService = memberService ?? throw new ArgumentNullException(nameof(memberService));
        }

        // Constructor mặc định nếu không dùng DI (tạo instance trực tiếp)
        public VoucherAdminService() : this(new MemberService()) // Gọi constructor có tham số
        {
            // Constructor này chỉ để tiện dụng nếu không setup DI
            // Khuyến khích dùng DI để dễ quản lý dependency và testing
        }

        /// <summary>
        /// Lấy danh sách tất cả chương trình voucher để quản lý.
        /// </summary>
        public List<VoucherEditViewModel> GetAllVoucherPrograms()
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    return db.Vouchers
                             .OrderByDescending(v => v.ngay_tao)
                             .Select(v => MapToEditViewModel(v)) // Sử dụng hàm Map helper
                             .ToList();
                }
                catch (Exception ex)
                {
                    LogError("GetAllVoucherPrograms", ex);
                    return new List<VoucherEditViewModel>();
                }
            }
        }

        /// <summary>
        /// Lấy danh sách ID các cửa hàng mà voucher cụ thể được áp dụng.
        /// </summary>
        public List<int> GetAppliedStoreIdsForVoucher(int voucherId)
        {
            using (var db = new FastFoodDataContext())
            {
                try { return db.Voucher_ApDung_CuaHangs.Where(va => va.id_voucher == voucherId).Select(va => va.id_cua_hang).ToList(); }
                catch (Exception ex) { LogError($"GetAppliedStoreIdsForVoucher({voucherId})", ex); return new List<int>(); }
            }
        }

        /// <summary>
        /// Lấy thông tin chi tiết đầy đủ của voucher để sửa (bao gồm cả Store IDs nếu có).
        /// </summary>
        public VoucherEditViewModel GetVoucherDetailsForEdit(int voucherId)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var voucherEntity = db.Vouchers.FirstOrDefault(v => v.id_voucher == voucherId);
                    if (voucherEntity == null) return null;

                    var viewModel = MapToEditViewModel(voucherEntity);
                    if (viewModel.PhamViApDung == "theo_cua_hang")
                    {
                        viewModel.SelectedStoreIds = GetAppliedStoreIdsForVoucher(voucherId); // Load danh sách cửa hàng áp dụng
                    }
                    return viewModel;
                }
                catch (Exception ex) { LogError($"GetVoucherDetailsForEdit({voucherId})", ex); return null; }
            }
        }

        /// <summary>
        /// Thêm voucher mới và các liên kết cửa hàng (nếu có) vào CSDL.
        /// </summary>
        public VoucherEditViewModel AddVoucher(VoucherEditViewModel newVoucherData)
        {
            if (newVoucherData == null) throw new ArgumentNullException(nameof(newVoucherData));

            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted }))
            {
                using (var db = new FastFoodDataContext())
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(newVoucherData.MaVoucher))
                        {
                            newVoucherData.MaVoucher = GenerateUniqueVoucherCode(db);
                        }
                        else if (db.Vouchers.Any(v => v.ma_voucher == newVoucherData.MaVoucher))
                        {
                            throw new ArgumentException($"Mã voucher '{newVoucherData.MaVoucher}' đã tồn tại.");
                        }

                        var entity = MapToEntity(newVoucherData);
                        entity.ngay_tao = DateTime.Now;

                        db.Vouchers.InsertOnSubmit(entity);
                        db.SubmitChanges();

                        newVoucherData.Id = entity.id_voucher;

                        if (newVoucherData.SelectedStoreIds != null && newVoucherData.SelectedStoreIds.Any())
                        {
                            var links = newVoucherData.SelectedStoreIds.Select(storeId => new Voucher_ApDung_CuaHang
                            {
                                id_voucher = newVoucherData.Id,
                                id_cua_hang = storeId
                            });
                            db.Voucher_ApDung_CuaHangs.InsertAllOnSubmit(links);
                            db.SubmitChanges();
                        }

                        scope.Complete();
                        return newVoucherData;
                    }
                    catch (Exception ex)
                    {
                        LogError("AddVoucher", ex);
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Cập nhật thông tin voucher và các liên kết cửa hàng (nếu có).
        /// </summary>
        public bool UpdateVoucher(VoucherEditViewModel voucherData)
        {
            if (voucherData == null || voucherData.Id <= 0) throw new ArgumentException("Thông tin voucher không hợp lệ để cập nhật.");

            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted }))
            {
                using (var db = new FastFoodDataContext())
                {
                    try
                    {
                        var entity = db.Vouchers.FirstOrDefault(v => v.id_voucher == voucherData.Id);
                        if (entity == null) { LogError($"UpdateVoucher: Voucher ID {voucherData.Id} not found.", null); return false; }

                        // Validation
                        ValidateVoucherData(voucherData, db, isAdding: false);
                        // Kiểm tra trùng mã nếu mã bị thay đổi (Giả sử mã không đổi nên bỏ qua)

                        // Cập nhật Entity từ ViewModel
                        MapViewModelToEntity(voucherData, entity);
                        // entity.ngay_cap_nhat = DateTime.Now; // Cập nhật nếu có cột này

                        // Xử lý phạm vi cửa hàng
                        var oldLinks = db.Voucher_ApDung_CuaHangs.Where(va => va.id_voucher == entity.id_voucher);
                        db.Voucher_ApDung_CuaHangs.DeleteAllOnSubmit(oldLinks); // Xóa liên kết cũ

                        var selectedStoreIds = db.Voucher_ApDung_CuaHangs.Where(ch => ch.id_voucher == entity.id_voucher).ToList();

                        // Nếu có thay đổi thì xóa các liên kết cũ
                        db.Voucher_ApDung_CuaHangs.DeleteAllOnSubmit(selectedStoreIds);
                        db.SubmitChanges(); // Lưu tất cả thay đổi

                        if (entity.pham_vi_ap_dung == "theo_cua_hang" && voucherData.SelectedStoreIds != null && voucherData.SelectedStoreIds.Any())
                        {
                            var newLinks = voucherData.SelectedStoreIds.Select(storeId => new Voucher_ApDung_CuaHang { id_voucher = entity.id_voucher, id_cua_hang = storeId });
                            db.Voucher_ApDung_CuaHangs.InsertAllOnSubmit(newLinks); // Thêm liên kết mới
                        }

                        db.SubmitChanges(); // Lưu tất cả thay đổi
                        scope.Complete();
                        Log($"Updated Voucher: ID={voucherData.Id}");
                        return true;
                    }
                    catch (ChangeConflictException ex) { LogError($"UpdateVoucher Conflict ID {voucherData.Id}", ex); throw new Exception("Dữ liệu voucher đã bị thay đổi.", ex); }
                    catch (Exception ex) { LogError($"UpdateVoucher ID {voucherData.Id}", ex); throw; } // Rollback tự động
                }
            }
        }

        /// <summary>
        /// Thay đổi trạng thái voucher (active/inactive).
        /// </summary>
        public bool ChangeVoucherStatus(int voucherId, string newStatus)
        {
            var allowedStatuses = new[] { "active", "inactive" };
            if (!allowedStatuses.Contains(newStatus?.ToLower())) throw new ArgumentException("Trạng thái mới không hợp lệ.");
            using (var db = new FastFoodDataContext()) { try { var entity = db.Vouchers.FirstOrDefault(v => v.id_voucher == voucherId); if (entity == null) return false; if (entity.trang_thai == newStatus) return true; entity.trang_thai = newStatus; /* entity.ngay_cap_nhat = DateTime.Now; */ db.SubmitChanges(); Log($"Changed status for Voucher {voucherId} to {newStatus}"); return true; } catch (Exception ex) { LogError($"ChangeVoucherStatus({voucherId}, {newStatus})", ex); throw; } }
        }

        /// <summary>
        /// Lấy danh sách voucher đang hoạt động và còn hạn để gửi.
        /// </summary>
        public List<VoucherEditViewModel> GetActiveVouchersForSending()
        {
            using (var db = new FastFoodDataContext()) { try { DateTime now = DateTime.Now.Date; return db.Vouchers.Where(v => v.trang_thai == "active" && v.ngay_ket_thuc >= now).OrderBy(v => v.ngay_ket_thuc).ThenBy(v => v.ten_voucher).Select(v => MapToEditViewModel(v)).ToList(); } catch (Exception ex) { LogError("GetActiveVouchersForSending", ex); return new List<VoucherEditViewModel>(); } }
        }

        /// <summary>
        /// Gán danh sách voucher cho một nhóm thành viên.
        /// </summary>
        public bool AssignVouchersToGroup(List<int> voucherIds, string memberGroup)
        {
            if (voucherIds == null || !voucherIds.Any() || string.IsNullOrWhiteSpace(memberGroup))
            {
                Log("AssignVouchersToGroup: Invalid parameters.");
                return false;
            }

            try
            {
                List<int> memberIds;
                using (var db = new FastFoodDataContext())
                {
                    // Nếu là "all" thì lấy tất cả thành viên đang hoạt động
                    if (memberGroup.ToLower() == "all")
                    {
                        memberIds = db.ThanhViens
                            .Where(tv => tv.trang_thai == "active")
                            .Select(tv => tv.id_thanh_vien)
                            .ToList();
                    }
                    else
                    {
                        // Xử lý các nhóm thành viên khác nếu cần
                        memberIds = db.ThanhViens
                            .Where(tv => tv.trang_thai == "active" && tv.cap_do == memberGroup)
                            .Select(tv => tv.id_thanh_vien)
                            .ToList();
                    }
                }

                if (!memberIds.Any())
                {
                    Log($"No active members found in group '{memberGroup}'.");
                    return true; // Trả về true vì không có lỗi, chỉ là không có thành viên
                }

                return AssignVouchersToMembers(voucherIds, memberIds);
            }
            catch (Exception ex)
            {
                LogError($"AssignVouchersToGroup ('{memberGroup}')", ex);
                return false;
            }
        }

        /// <summary>
        /// Gán danh sách voucher cho danh sách thành viên cụ thể.
        /// </summary>
        public bool AssignVouchersToMembers(List<int> voucherIds, List<int> memberIds)
        {
            if (voucherIds == null || !voucherIds.Any() || memberIds == null || !memberIds.Any())
            {
                Log("AssignVouchersToMembers: Invalid parameters.");
                return false;
            }

            using (var scope = new TransactionScope())
            {
                try
                {
                    using (var db = new FastFoodDataContext())
                    {
                        // Kiểm tra xem tất cả các voucher có cửa hàng áp dụng chưa
                        var vouchersWithoutStores = db.Vouchers
                            .Where(v => voucherIds.Contains(v.id_voucher)
                                   && v.pham_vi_ap_dung == "theo_cua_hang")
                            .Where(v => !db.Voucher_ApDung_CuaHangs.Any(va => va.id_voucher == v.id_voucher))
                            .Select(v => v.ma_voucher)
                            .ToList();

                        if (vouchersWithoutStores.Any())
                        {
                            Log($"Cannot assign vouchers without store selection: {string.Join(", ", vouchersWithoutStores)}");
                            return false;
                        }

                        // Lọc voucher hợp lệ (active và chưa hết hạn)
                        var validVouchers = db.Vouchers
                            .Where(v => voucherIds.Contains(v.id_voucher)
                                   && v.trang_thai == "active"
                                   && v.ngay_ket_thuc >= DateTime.Now)
                            .ToList();

                        if (!validVouchers.Any())
                        {
                            Log("No valid vouchers found to assign.");
                            return false;
                        }

                        // Lọc thành viên active
                        var validMembers = db.ThanhViens
                            .Where(m => memberIds.Contains(m.id_thanh_vien)
                                   && m.trang_thai == "active")
                            .ToList();

                        if (!validMembers.Any())
                        {
                            Log("No valid members found to assign vouchers to.");
                            return false;
                        }

                        DateTime now = DateTime.Now;
                        var assignments = new List<ThanhVien_Voucher>();

                        // Tạo các bản ghi gán voucher
                        foreach (var voucher in validVouchers)
                        {
                            foreach (var member in validMembers)
                            {
                                // Kiểm tra xem đã có gán chưa
                                var exists = db.ThanhVien_Vouchers.Any(tv =>
                                    tv.id_voucher == voucher.id_voucher &&
                                    tv.id_thanh_vien == member.id_thanh_vien);

                                if (!exists)
                                {
                                    assignments.Add(new ThanhVien_Voucher
                                    {
                                        id_thanh_vien = member.id_thanh_vien,
                                        id_voucher = voucher.id_voucher,
                                        ngay_nhan = now,
                                        trang_thai_su_dung = "chua_su_dung"
                                    });
                                }
                            }
                        }

                        if (assignments.Any())
                        {
                            db.ThanhVien_Vouchers.InsertAllOnSubmit(assignments);
                            db.SubmitChanges();
                            Log($"Successfully assigned {assignments.Count} vouchers to members.");
                        }

                        scope.Complete();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    LogError("AssignVouchersToMembers", ex);
                    return false;
                }
            }
        }

        // --- Helpers ---
        private static VoucherEditViewModel MapToEditViewModel(DataLayer.Voucher entity)
        {
            if (entity == null)
                return null;

            return new VoucherEditViewModel
            {
                Id = entity.id_voucher,
                MaVoucher = entity.ma_voucher,
                TenVoucher = entity.ten_voucher,
                MoTa = entity.mo_ta,
                LoaiGiamGia = entity.loai_giam_gia,
                GiaTriGiam = entity.gia_tri_giam,
                IdSanPhamMienPhi = entity.id_san_pham_mien_phi,
                GiaTriDonHangToiThieu = entity.gia_tri_don_hang_toi_thieu ?? 0,
                GiamGiaToiDa = entity.giam_gia_toi_da,
                NgayBatDau = entity.ngay_bat_dau.Date,
                NgayKetThuc = entity.ngay_ket_thuc.Date,
                SoLuongPhatHanh = entity.so_luong_phat_hanh,
                SoLuotSuDungToiDaMoiThanhVien = entity.so_luot_su_dung_toi_da_moi_thanh_vien,
                DieuKienSanPham = entity.dieu_kien_san_pham,
                DoiTuongApDung = entity.doi_tuong_ap_dung,
                PhamViApDung = entity.pham_vi_ap_dung,
                TrangThai = entity.trang_thai
            };
        }
        private static DataLayer.Voucher MapToEntity(VoucherEditViewModel viewModel)
        {
            if (viewModel == null)
                return null;

            return new DataLayer.Voucher
            {
                id_voucher = viewModel.Id,
                ma_voucher = viewModel.MaVoucher,
                ten_voucher = viewModel.TenVoucher,
                mo_ta = viewModel.MoTa,
                loai_giam_gia = viewModel.LoaiGiamGia,
                gia_tri_giam = viewModel.GiaTriGiam,
                id_san_pham_mien_phi = viewModel.IdSanPhamMienPhi,
                gia_tri_don_hang_toi_thieu = viewModel.GiaTriDonHangToiThieu,
                giam_gia_toi_da = viewModel.GiamGiaToiDa,
                ngay_bat_dau = viewModel.NgayBatDau,
                ngay_ket_thuc = viewModel.NgayKetThuc,
                so_luong_phat_hanh = viewModel.SoLuongPhatHanh,
                so_luot_su_dung_toi_da_moi_thanh_vien = viewModel.SoLuotSuDungToiDaMoiThanhVien,
                pham_vi_ap_dung = viewModel.PhamViApDung,
                dieu_kien_san_pham = viewModel.DieuKienSanPham,
                doi_tuong_ap_dung = viewModel.DoiTuongApDung,
                trang_thai = viewModel.TrangThai
            };
        }
        private static void MapViewModelToEntity(VoucherEditViewModel viewModel, DataLayer.Voucher entity)
        {
            if (viewModel == null || entity == null)
                return;
            entity.ten_voucher = viewModel.TenVoucher;
            entity.mo_ta = viewModel.MoTa;
            entity.loai_giam_gia = viewModel.LoaiGiamGia;
            entity.gia_tri_giam = viewModel.GiaTriGiam;
            entity.id_san_pham_mien_phi = viewModel.IdSanPhamMienPhi;
            entity.gia_tri_don_hang_toi_thieu = viewModel.GiaTriDonHangToiThieu;
            entity.giam_gia_toi_da = viewModel.GiamGiaToiDa;
            entity.ngay_bat_dau = viewModel.NgayBatDau; entity.ngay_ket_thuc = viewModel.NgayKetThuc;
            entity.so_luong_phat_hanh = viewModel.SoLuongPhatHanh;
            entity.so_luot_su_dung_toi_da_moi_thanh_vien = viewModel.SoLuotSuDungToiDaMoiThanhVien;
            entity.pham_vi_ap_dung = viewModel.PhamViApDung;
            entity.dieu_kien_san_pham = viewModel.DieuKienSanPham;
            entity.doi_tuong_ap_dung = viewModel.DoiTuongApDung;
            entity.trang_thai = viewModel.TrangThai;
        }
        private string GenerateUniqueVoucherCode(FastFoodDataContext dbContext) { const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; var random = new Random(); string code; int attempts = 0; do { code = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray()); attempts++; if (attempts > 10) throw new Exception("Không thể tạo mã voucher duy nhất."); } while (dbContext.Vouchers.Any(v => v.ma_voucher == code)); return code; }
        private void Log(string message) { Debug.WriteLine($"[VoucherAdminService] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[VoucherAdminService ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

        // *** THÊM HÀM VALIDATE HELPER ***
        /// <summary>
        /// Kiểm tra dữ liệu Voucher ViewModel có hợp lệ không.
        /// </summary>
        /// <param name="voucherData">ViewModel cần kiểm tra.</param>
        /// <param name="db">DataContext để kiểm tra trùng lặp.</param>
        /// <param name="isAdding">True nếu đang thêm mới, False nếu đang cập nhật.</param>
        /// <param name="originalEntity">Entity gốc khi cập nhật (để kiểm tra thay đổi Mã).</param>
        private void ValidateVoucherData(VoucherEditViewModel voucherData, FastFoodDataContext db, bool isAdding, DataLayer.Voucher originalEntity = null)
        {
            if (voucherData == null) throw new ArgumentNullException(nameof(voucherData));
            if (db == null) throw new ArgumentNullException(nameof(db));

            if (string.IsNullOrWhiteSpace(voucherData.TenVoucher)) throw new ArgumentException("Tên chương trình không được để trống.");
            if (voucherData.GiaTriGiam < 0) throw new ArgumentException("Giá trị giảm giá không hợp lệ.");
            if (voucherData.LoaiGiamGia == "percentage" && (voucherData.GiaTriGiam <= 0 || voucherData.GiaTriGiam > 100)) throw new ArgumentException("Giá trị giảm % phải > 0 và <= 100.");
            if (voucherData.LoaiGiamGia == "fixed_amount" && voucherData.GiaTriGiam <= 0) throw new ArgumentException("Giá trị giảm VND phải > 0.");
            if (voucherData.GiamGiaToiDa.HasValue && voucherData.GiamGiaToiDa < 0) throw new ArgumentException("Giảm giá tối đa không hợp lệ.");
            if (voucherData.GiaTriDonHangToiThieu < 0) throw new ArgumentException("Giá trị đơn hàng tối thiểu không hợp lệ.");
            if (voucherData.NgayKetThuc.Date < voucherData.NgayBatDau.Date) throw new ArgumentException("Ngày kết thúc phải >= ngày bắt đầu.");
            if (voucherData.PhamViApDung == "theo_cua_hang" && (voucherData.SelectedStoreIds == null || !voucherData.SelectedStoreIds.Any())) throw new ArgumentException("Vui lòng chọn ít nhất một cửa hàng áp dụng cho phạm vi 'Theo cửa hàng'.");

            // Kiểm tra trùng Mã Voucher
            if (!string.IsNullOrWhiteSpace(voucherData.MaVoucher))
            {
                if (isAdding) // Khi thêm mới
                {
                    if (db.Vouchers.Any(v => v.ma_voucher == voucherData.MaVoucher))
                        throw new ArgumentException($"Mã voucher '{voucherData.MaVoucher}' đã tồn tại.");
                }
                else // Khi cập nhật
                {
                    if (originalEntity != null && originalEntity.ma_voucher != voucherData.MaVoucher && db.Vouchers.Any(v => v.id_voucher != voucherData.Id && v.ma_voucher == voucherData.MaVoucher))
                        throw new ArgumentException($"Mã voucher '{voucherData.MaVoucher}' đã tồn tại.");
                }
            }
            else if (isAdding) // Nếu thêm mới mà mã rỗng thì sẽ tự sinh, không cần báo lỗi
            {
                // Mã sẽ được tự sinh trong AddVoucher
            }
            else // Nếu cập nhật mà mã bị xóa trắng (không cho phép nếu mã gốc không rỗng)
            {
                if (originalEntity != null && !string.IsNullOrWhiteSpace(originalEntity.ma_voucher))
                    throw new ArgumentException("Mã voucher không được để trống khi cập nhật.");
            }
        }
    }
} // End Namespace