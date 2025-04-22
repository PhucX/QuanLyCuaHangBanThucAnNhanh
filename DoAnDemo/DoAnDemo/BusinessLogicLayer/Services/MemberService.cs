// --- BusinessLogicLayer/Services (Placeholder Implementation) ---
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using System.Linq;
using System.Transactions;
using System.Windows;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class MemberService : IMemberService // Implement interface IMemberService
    {
        /// <summary>
        /// Tìm kiếm thành viên theo từ khóa (tên, sđt, mã TV).
        /// Chỉ trả về các thành viên đang hoạt động.
        /// </summary>
        public List<MemberViewModel> SearchMembers(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<MemberViewModel>();

            string searchTerm = keyword.Trim().ToLower();

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var query = from tv in db.ThanhViens
                                where tv.trang_thai == "active" &&
                                      (tv.ma_thanh_vien.ToLower().Contains(searchTerm) ||
                                       tv.ten_thanh_vien.ToLower().Contains(searchTerm) ||
                                       tv.so_dien_thoai.Contains(searchTerm) ||
                                       (tv.email != null && tv.email.ToLower().Contains(searchTerm)))
                                select new MemberViewModel
                                {
                                    Id = tv.id_thanh_vien,
                                    MaThanhVien = tv.ma_thanh_vien,
                                    TenThanhVien = tv.ten_thanh_vien,
                                    SoDienThoai = tv.so_dien_thoai,
                                    Email = tv.email,
                                    NgaySinh = tv.ngay_sinh ?? DateTime.Now,
                                    GioiTinh = tv.gioi_tinh,
                                    ViTien = tv.vi_tien,
                                    DiemTichLuy = tv.diem_tich_luy,
                                    CapDo = tv.cap_do,
                                    GhiChu = tv.ghi_chu,
                                    AvatarUrl = null // Giả định chưa có cột AvatarUrl trong DB
                                };

                    return query.Take(20).ToList(); // Giới hạn kết quả
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in SearchMembers: {ex.ToString()}");
                    // Xem xét việc throw lại lỗi hoặc trả về list rỗng
                    return new List<MemberViewModel>();
                }
            }
        }

        /// <summary>
        /// Lấy thông tin chi tiết của một thành viên theo ID.
        /// </summary>
        public MemberViewModel GetMemberDetails(int memberId)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var tv = db.ThanhViens
                               .Where(m => m.id_thanh_vien == memberId)
                               .Select(m => new MemberViewModel // Map sang ViewModel
                               {
                                   Id = m.id_thanh_vien,
                                   MaThanhVien = m.ma_thanh_vien,
                                   TenThanhVien = m.ten_thanh_vien,
                                   SoDienThoai = m.so_dien_thoai,
                                   Email = m.email,
                                   NgaySinh = m.ngay_sinh ?? DateTime.Now,
                                   GioiTinh = m.gioi_tinh,
                                   ViTien = m.vi_tien,
                                   DiemTichLuy = m.diem_tich_luy,
                                   CapDo = m.cap_do,
                                   GhiChu = m.ghi_chu,
                                   IdCuaHangDangKy = m.id_cua_hang_dang_ky,
                                   TrangThai = m.trang_thai
                               })
                               .FirstOrDefault(); // Lấy chi tiết một thành viên

                    if (tv != null)
                    {
                        //Log($"Found details for Member ID: {memberId}");
                    }
                    else
                    {
                        //Log($"Member ID: {memberId} not found.");
                    }
                    return tv;
                }
                catch (Exception ex)
                {
                    LogError($"GetMemberDetails({memberId})", ex);
                    return null;
                }
            }
        }

        /// <summary>
        /// Lấy danh sách món ăn thành viên hay dùng nhất tại một cửa hàng cụ thể.
        /// </summary>
        /// <param name="memberId">ID Thành viên</param>
        /// <param name="storeId">ID Cửa hàng để lấy giá bán hiện tại</param>
        /// <param name="topN">Số lượng món ăn tối đa cần lấy</param>
        public List<FavoriteFoodViewModel> GetMemberFavoriteFoods(int memberId, int storeId, int topN = 5)
        {
            var result = new List<FavoriteFoodViewModel>();
            try
            {
                using (var db = new FastFoodDataContext())
                {
                    // Bước 1: Lấy top N sản phẩm được đặt nhiều nhất
                    var topProductIdsInfo = (from ctdh in db.ChiTietDonHangs
                                             join dh in db.DonHangs on ctdh.id_don_hang equals dh.id_don_hang
                                             where dh.id_thanh_vien == memberId && dh.trang_thai_don_hang == "hoan_thanh"
                                             group ctdh by ctdh.id_san_pham into g
                                             select new
                                             {
                                                 ProductId = g.Key,
                                                 TotalQuantity = g.Sum(x => x.so_luong)
                                             })
                                            .OrderByDescending(x => x.TotalQuantity)
                                            .Select(x => new { x.ProductId, x.TotalQuantity }) // Chọn lại để tránh lỗi nested query
                                            .Take(topN)
                                            .ToList();

                    if (!topProductIdsInfo.Any()) return result;

                    var productIds = topProductIdsInfo.Select(p => p.ProductId).ToList();

                    // Bước 2: Lấy thông tin chi tiết (tên, ảnh, giá hiện tại) cho các sản phẩm đó tại cửa hàng này
                    var productDetails = (from sp in db.SanPhams
                                          join gv in db.GiaVaTrangThaiSanPhamTaiCuaHangs on sp.id_san_pham equals gv.id_san_pham
                                          where productIds.Contains(sp.id_san_pham) && gv.id_cua_hang == storeId && gv.trang_thai_co_san == true
                                          select new
                                          {
                                              sp.id_san_pham,
                                              sp.ten_san_pham,
                                              sp.hinh_anh_url, // Giả định có cột này trong SanPham
                                              gv.gia_ban
                                          }).ToDictionary(pd => pd.id_san_pham); // Chuyển thành Dictionary để tra cứu nhanh

                    // Bước 3: Kết hợp kết quả
                    foreach (var topProd in topProductIdsInfo)
                    {
                        if (productDetails.TryGetValue(topProd.ProductId, out var detail))
                        {
                            result.Add(new FavoriteFoodViewModel
                            {
                                IdSanPham = detail.id_san_pham,
                                TenSanPham = detail.ten_san_pham,
                                GiaBan = detail.gia_ban,
                                ImageUrl = detail.hinh_anh_url,
                                SoLanGoi = topProd.TotalQuantity
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetMemberFavoriteFoods for member {memberId}, store {storeId}: {ex.ToString()}");
                // Xem xét throw hoặc trả về list rỗng
            }
            // Sắp xếp lại theo số lần gọi trước khi trả về
            return result.OrderByDescending(r => r.SoLanGoi).ToList();
        }

        /// <summary>
        /// Lấy danh sách voucher còn hạn và chưa sử dụng của thành viên.
        /// </summary>
        public List<VoucherViewModel> GetMemberAvailableVouchers(int memberId)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    DateTime now = DateTime.Now;

                    var query = from tvv in db.ThanhVien_Vouchers
                                join v in db.Vouchers on tvv.id_voucher equals v.id_voucher
                                where tvv.id_thanh_vien == memberId &&
                                      tvv.trang_thai_su_dung == "chua_su_dung" &&
                                      v.trang_thai == "active" &&
                                      now >= v.ngay_bat_dau &&
                                      now <= v.ngay_ket_thuc
                                // *** TODO: Bổ sung logic kiểm tra phạm vi áp dụng voucher ***
                                // Ví dụ: Nếu voucher áp dụng theo cửa hàng, cần kiểm tra cửa hàng hiện tại
                                // where ... && (v.pham_vi_ap_dung != "theo_cua_hang" OR EXISTS (SELECT 1 FROM Voucher_ApDung_CuaHang va WHERE va.id_voucher = v.id_voucher AND va.id_cua_hang = currentStoreId))
                                // (Cần truyền currentStoreId vào phương thức này nếu muốn lọc theo cửa hàng)
                                select new VoucherViewModel
                                {
                                    MaVoucher = v.ma_voucher,
                                    TenVoucher = v.ten_voucher,
                                    MoTa = v.mo_ta,
                                    ImageUrl = null, // Giả định chưa có cột ảnh voucher
                                    SoLuong = 1,     // Giả định mỗi dòng tvv là 1 voucher
                                    NgayHetHan = v.ngay_ket_thuc
                                };

                    // Logic group nếu muốn đếm số lượng từng loại voucher
                    // var groupedQuery = query.GroupBy(vvm => vvm.MaVoucher) // Group theo Mã Voucher chẳng hạn
                    //                        .Select(g => new VoucherViewModel {
                    //                             // Lấy thông tin từ g.First() hoặc tương tự
                    //                             MaVoucher = g.Key,
                    //                             TenVoucher = g.First().TenVoucher,
                    //                             // ...
                    //                             SoLuong = g.Count(), // Đếm số lượng
                    //                             NgayHetHan = g.Min(v => v.NgayHetHan) // Lấy ngày hết hạn sớm nhất
                    //                        });
                    // return groupedQuery.ToList();

                    return query.ToList(); // Trả về danh sách trực tiếp (mỗi dòng là 1 voucher)
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in GetMemberAvailableVouchers for member {memberId}: {ex.ToString()}");
                    return new List<VoucherViewModel>();
                }
            }
        }

        /// <summary>
        /// Cập nhật ghi chú cho thành viên.
        /// </summary>
        public bool UpdateMemberNote(int memberId, string note)
        {
            try
            {
                using (var db = new FastFoodDataContext())
                {
                    var member = db.ThanhViens.FirstOrDefault(tv => tv.id_thanh_vien == memberId);
                    if (member != null)
                    {
                        if (member.ghi_chu != note) // Chỉ cập nhật nếu có thay đổi
                        {
                            member.ghi_chu = note;
                            member.ngay_cap_nhat = DateTime.Now;
                            db.SubmitChanges();
                        }
                        return true;
                    }
                    Console.WriteLine($"UpdateMemberNote: Member {memberId} not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating note for member {memberId}: {ex.ToString()}");
                return false;
            }
        }

        /// <summary>
        /// Nạp tiền vào ví thành viên và ghi lại lịch sử giao dịch.
        /// Đảm bảo tính toàn vẹn bằng TransactionScope.
        /// </summary>
        public bool AddFundsToWallet(int memberId, int storeId, decimal amount, int employeeId)
        {
            if (amount <= 0)
            {
                Console.WriteLine("AddFundsToWallet: Amount must be positive.");
                return false;
            }

            using (var scope = new TransactionScope(TransactionScopeOption.Required,
                new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted })) // Đảm bảo đọc dữ liệu đã commit
            {
                try
                {
                    using (var db = new FastFoodDataContext())
                    {
                        var member = db.ThanhViens.FirstOrDefault(tv => tv.id_thanh_vien == memberId);

                        // Kiểm tra thành viên hợp lệ
                        if (member == null) { Console.WriteLine($"AddFundsToWallet: Member {memberId} not found."); return false; }
                        if (member.trang_thai != "active") { Console.WriteLine($"AddFundsToWallet: Member {memberId} is not active."); return false; }

                        // Kiểm tra cửa hàng và nhân viên hợp lệ (Nếu cần)
                        // var storeExists = db.CuaHangs.Any(ch => ch.id_cua_hang == storeId && ch.trang_thai == "dang_hoat_dong");
                        // var employeeExists = db.NhanViens.Any(nv => nv.id_nhan_vien == employeeId && nv.trang_thai == "dang_lam_viec");
                        // if (!storeExists || !employeeExists) { Console.WriteLine("AddFundsToWallet: Invalid store or employee."); return false; }


                        decimal balanceBefore = member.vi_tien;
                        decimal balanceAfter = balanceBefore + amount;

                        // Cập nhật ví thành viên
                        member.vi_tien = balanceAfter;
                        member.ngay_cap_nhat = DateTime.Now;

                        // Tạo lịch sử giao dịch
                        var transaction = new LichSuGiaoDich
                        {
                            id_thanh_vien = memberId,
                            id_cua_hang = storeId,
                            loai_giao_dich = "nap_tien_vi",
                            so_tien_thay_doi = amount,
                            so_diem_thay_doi = 0,
                            so_du_vi_sau_gd = balanceAfter,    // Số dư mới
                            so_diem_sau_gd = member.diem_tich_luy, // Điểm không đổi
                            id_don_hang_lien_quan = null,
                            id_doi_qua_lien_quan = null,
                            id_nhan_vien_thuc_hien = employeeId,
                            thoi_gian_giao_dich = DateTime.Now,
                            ghi_chu = $"Nạp {amount:N0}đ vào ví tại CH {storeId} bởi NV {employeeId}" // Format số tiền
                        };
                        db.LichSuGiaoDiches.InsertOnSubmit(transaction);

                        // Lưu thay đổi vào CSDL
                        db.SubmitChanges();

                        // Hoàn tất transaction nếu không có lỗi
                        scope.Complete();
                        Console.WriteLine($"Successfully added {amount} to wallet for member {memberId}. New balance: {balanceAfter}");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CRITICAL Error in AddFundsToWallet for member {memberId}: {ex.ToString()}");
                    // Transaction sẽ tự động rollback do không gọi scope.Complete()
                    return false; // Báo lỗi
                }
            } // TransactionScope được Dispose tại đây
        }

        // *** IMPLEMENT PHƯƠNG THỨC MỚI ***
        public MemberViewModel RegisterMember(MemberViewModel newMemberInfo)
        {
            if (newMemberInfo == null) return null;

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    // --- BLL Validation ---
                    // 1. Kiểm tra SĐT đã tồn tại chưa?
                    if (db.ThanhViens.Any(tv => tv.so_dien_thoai == newMemberInfo.SoDienThoai))
                    {
                        // Có thể throw lỗi cụ thể hoặc trả về null với thông báo
                        throw new ArgumentException($"Số điện thoại '{newMemberInfo.SoDienThoai}' đã được đăng ký.");
                    }
                    // 2. Kiểm tra Mã TV nếu người dùng nhập (và mã đó phải là duy nhất)
                    if (!string.IsNullOrWhiteSpace(newMemberInfo.MaThanhVien))
                    {
                        if (db.ThanhViens.Any(tv => tv.ma_thanh_vien == newMemberInfo.MaThanhVien))
                        {
                            throw new ArgumentException($"Mã thành viên '{newMemberInfo.MaThanhVien}' đã tồn tại.");
                        }
                    }
                    else
                    {
                        // 3. Tự sinh mã TV nếu để trống (ví dụ đơn giản)
                        newMemberInfo.MaThanhVien = $"TV{DateTime.Now:yyMMddHHmmss}"; // Cần cơ chế sinh mã tốt hơn
                    }
                    // 4. Kiểm tra Email nếu nhập (và phải duy nhất)
                    if (!string.IsNullOrWhiteSpace(newMemberInfo.Email))
                    {
                        if (db.ThanhViens.Any(tv => tv.email == newMemberInfo.Email))
                        {
                            throw new ArgumentException($"Email '{newMemberInfo.Email}' đã được sử dụng.");
                        }
                        // Thêm kiểm tra định dạng email nếu cần ở đây
                    }


                    // Tạo entity mới
                    var entity = new ThanhVien
                    {
                        ma_thanh_vien = newMemberInfo.MaThanhVien,
                        ten_thanh_vien = newMemberInfo.TenThanhVien,
                        so_dien_thoai = newMemberInfo.SoDienThoai,
                        email = newMemberInfo.Email, // Có thể null
                        ngay_sinh = newMemberInfo.NgaySinh, // Có thể null
                        gioi_tinh = newMemberInfo.GioiTinh, // Có thể null, nhưng nên có giá trị hợp lệ nếu nhập
                        ghi_chu = newMemberInfo.GhiChu,
                        id_cua_hang_dang_ky = newMemberInfo.IdCuaHangDangKy, // Lấy từ ViewModel (Cần thêm vào ViewModel)

                        // Giá trị mặc định khi tạo mới
                        vi_tien = 0m,
                        diem_tich_luy = 0,
                        cap_do = "Basic",
                        trang_thai = "active",
                        ngay_tham_gia = DateTime.Now,
                        ngay_cap_nhat = DateTime.Now
                    };

                    db.ThanhViens.InsertOnSubmit(entity);
                    db.SubmitChanges();

                    // Map lại entity vừa tạo (đã có ID) sang ViewModel để trả về
                    newMemberInfo.Id = entity.id_thanh_vien; // Lấy ID tự tăng
                    // Cập nhật các giá trị mặc định vào ViewModel trả về nếu cần
                    newMemberInfo.ViTien = entity.vi_tien;
                    newMemberInfo.DiemTichLuy = entity.diem_tich_luy;
                    newMemberInfo.CapDo = entity.cap_do;
                    // ...

                    return newMemberInfo; // Trả về thông tin thành viên vừa tạo
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error registering member: {ex.ToString()}");
                    // Ném lại lỗi để lớp gọi xử lý hoặc trả về null
                    throw; // Để Form biết chi tiết lỗi
                    // return null;
                }
            }
        }

        // *** IMPLEMENT GetAllMembers ***
        public List<MemberViewModel> GetAllMembers()
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    return db.ThanhViens
                             .OrderBy(tv => tv.ten_thanh_vien)
                             .Select(tv => new MemberViewModel // Map sang ViewModel
                             {
                                 Id = tv.id_thanh_vien,
                                 MaThanhVien = tv.ma_thanh_vien,
                                 TenThanhVien = tv.ten_thanh_vien,
                                 SoDienThoai = tv.so_dien_thoai,
                                 Email = tv.email,
                                 NgaySinh = tv.ngay_sinh ?? DateTime.Now.Date,
                                 GioiTinh = tv.gioi_tinh,
                                 ViTien = tv.vi_tien,
                                 DiemTichLuy = tv.diem_tich_luy,
                                 CapDo = tv.cap_do,
                                 TrangThai = tv.trang_thai
                                 // Thêm các trường khác nếu cần hiển thị trên grid
                             })
                             .ToList();
                }
                catch (Exception ex)
                {
                    LogError("GetAllMembers", ex);
                    return new List<MemberViewModel>();
                }
            }
        }

        // *** IMPLEMENT UpdateMember ***
        public bool UpdateMember(MemberViewModel memberInfo)
        {
            if (memberInfo == null || memberInfo.Id <= 0) throw new ArgumentException("Dữ liệu thành viên không hợp lệ.");

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var entity = db.ThanhViens.FirstOrDefault(m => m.id_thanh_vien == memberInfo.Id);
                    if (entity == null) { LogError($"UpdateMember: Member ID {memberInfo.Id} not found.", null); return false; }

                    // --- Validation ---
                    if (string.IsNullOrWhiteSpace(memberInfo.TenThanhVien)) throw new ArgumentException("Tên thành viên không được để trống.");
                    if (string.IsNullOrWhiteSpace(memberInfo.SoDienThoai)) throw new ArgumentException("Số điện thoại không được để trống.");
                    // Kiểm tra trùng SĐT nếu thay đổi
                    if (entity.so_dien_thoai != memberInfo.SoDienThoai && db.ThanhViens.Any(m => m.id_thanh_vien != memberInfo.Id && m.so_dien_thoai == memberInfo.SoDienThoai))
                        throw new ArgumentException($"Số điện thoại '{memberInfo.SoDienThoai}' đã được sử dụng.");
                    // Kiểm tra trùng Email nếu thay đổi và Email không rỗng
                    if (!string.IsNullOrWhiteSpace(memberInfo.Email) && entity.email != memberInfo.Email && db.ThanhViens.Any(m => m.id_thanh_vien != memberInfo.Id && m.email == memberInfo.Email))
                        throw new ArgumentException($"Email '{memberInfo.Email}' đã được sử dụng.");
                    // Kiểm tra trạng thái hợp lệ
                    var allowedStatuses = new[] { "active", "inactive", "banned" };
                    if (!allowedStatuses.Contains(memberInfo.TrangThai?.ToLower())) throw new ArgumentException("Trạng thái không hợp lệ.");
                    // Không kiểm tra trùng Mã TV vì không cho sửa

                    // --- Cập nhật Entity ---
                    entity.ten_thanh_vien = memberInfo.TenThanhVien.Trim();
                    entity.so_dien_thoai = memberInfo.SoDienThoai.Trim();
                    entity.email = string.IsNullOrWhiteSpace(memberInfo.Email) ? null : memberInfo.Email.Trim();
                    entity.ngay_sinh = memberInfo.NgaySinh;
                    entity.gioi_tinh = memberInfo.GioiTinh; // Giả sử ViewModel đã chuẩn hóa (nam/nu/khac)
                    // entity.cap_do = memberInfo.CapDo; // Cấp độ thường không sửa trực tiếp
                    entity.ghi_chu = memberInfo.GhiChu?.Trim();
                    // entity.id_cua_hang_dang_ky = memberInfo.IdCuaHangDangKy; // CH đăng ký thường không đổi
                    entity.trang_thai = memberInfo.TrangThai; // Cho phép sửa trạng thái ở đây?
                    entity.ngay_cap_nhat = DateTime.Now;
                    // Không cập nhật ViTien, DiemTichLuy ở đây

                    db.SubmitChanges();
                    //Log($"Updated Member: ID={memberInfo.Id}");
                    return true;
                }
                catch (ChangeConflictException ex) { LogError($"UpdateMember Conflict ID {memberInfo.Id}", ex); throw new Exception("Dữ liệu thành viên đã bị thay đổi.", ex); }
                catch (Exception ex) { LogError($"UpdateMember ID {memberInfo.Id}", ex); throw; }
            }
        }

        // *** IMPLEMENT GetMemberStatistics ***
        public MemberStatsViewModel GetMemberStatistics(int memberId)
        {
            var stats = new MemberStatsViewModel { OrderTypeCounts = new Dictionary<string, int>(), StoreVisitCounts = new Dictionary<string, int>() };

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var member = db.ThanhViens.FirstOrDefault(tv => tv.id_thanh_vien == memberId);
                    if (member == null) return stats; // Trả về rỗng nếu không có thành viên

                    stats.JoinDate = member.ngay_tham_gia;

                    // Lấy các đơn hàng đã hoàn thành
                    var completedOrders = db.DonHangs
                                            .Where(dh => dh.id_thanh_vien == memberId && dh.trang_thai_don_hang == "hoan_thanh")
                                            .Select(dh => new { dh.thanh_tien, dh.id_cua_hang, dh.loai_don_hang, CuaHang = dh.CuaHang }) // Lấy thêm thông tin CuaHang
                                            .ToList();

                    if (completedOrders.Any())
                    {
                        stats.TotalSpent = completedOrders.Sum(dh => dh.thanh_tien);

                        // Thống kê cửa hàng đã ghé
                        stats.StoreVisitCounts = completedOrders
                                                 .GroupBy(dh => dh.CuaHang.ten_cua_hang) // Group theo TÊN cửa hàng
                                                 .ToDictionary(g => g.Key, g => g.Count());

                        // Thống kê loại đơn hàng
                        stats.OrderTypeCounts = completedOrders
                                                .GroupBy(dh => dh.loai_don_hang)
                                                .ToDictionary(g => g.Key, g => g.Count());
                    }
                    Log($"Calculated stats for Member ID: {memberId}");
                }
                catch (Exception ex) { LogError($"GetMemberStatistics({memberId})", ex); }
            }
            return stats;
        }

        // *** IMPLEMENT PLACEHOLDERS CHO SEND VOUCHER ***
        public List<int> GetMemberIdsByGroup(string memberGroup)
        {
            // TODO: Truy vấn CSDL để lấy ID các thành viên thuộc nhóm/hạng này (dựa vào cột cap_do)
            Log($"Getting member IDs for group '{memberGroup}' (Placeholder).");
            if (string.IsNullOrWhiteSpace(memberGroup)) return new List<int>();
            // Giả lập trả về danh sách ID
            using (var db = new FastFoodDataContext()) { return db.ThanhViens.Where(tv => tv.cap_do.ToLower() == memberGroup.ToLower() && tv.trang_thai == "active").Select(tv => tv.id_thanh_vien).Take(5).ToList(); } // Lấy tối đa 5 TV để test
            // throw new NotImplementedException();
        }

        public List<int> ValidateMemberIdentifiers(List<string> identifiers)
        {
            // TODO:
            // 1. Duyệt qua danh sách identifiers.
            // 2. Với mỗi identifier, kiểm tra xem nó là SĐT hay Mã TV hợp lệ và có tồn tại trong bảng ThanhVien không.
            // 3. Trả về danh sách các id_thanh_vien hợp lệ tìm được.
            Log($"Validating {identifiers?.Count} member identifiers (Placeholder).");
            if (identifiers == null || !identifiers.Any()) return new List<int>();
            // Giả lập trả về một vài ID hợp lệ
            List<int> validIds = new List<int>();
            using (var db = new FastFoodDataContext())
            {
                foreach (var idStr in identifiers)
                {
                    var member = db.ThanhViens.FirstOrDefault(tv => (tv.ma_thanh_vien == idStr || tv.so_dien_thoai == idStr) && tv.trang_thai == "active");
                    if (member != null && !validIds.Contains(member.id_thanh_vien)) validIds.Add(member.id_thanh_vien);
                }
            }
            Log($"Validated identifiers result count: {validIds.Count}");
            return validIds;
            // throw new NotImplementedException();
        }

        // ... (Helpers, Loggers) ...

        private void Log(string message) { /* ... */ }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[MemberService ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }
    }

    public class GiftService : IGiftService
    {
        public List<GiftViewModel> GetAvailableGiftsForMember(int memberPoints)
        {
            Console.WriteLine($"Getting gifts available for {memberPoints} points");
            // Giả lập quà tặng
            var gifts = new List<GiftViewModel> {
                 new GiftViewModel { Id=201, TenQuaTang="Ly sứ", DiemCanDoi=50, ImageUrl=null },
                 new GiftViewModel { Id=202, TenQuaTang="Voucher 20k", DiemCanDoi=100, ImageUrl=null },
                 new GiftViewModel { Id=203, TenQuaTang="Áo mưa", DiemCanDoi=200, ImageUrl=null }
             };
            // Lọc theo điểm thành viên có
            return gifts.Where(g => g.DiemCanDoi <= memberPoints).ToList();
            // return new List<GiftViewModel>(); // Trả về rỗng
        }
    }
}
