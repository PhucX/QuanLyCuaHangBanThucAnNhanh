using System;
using System.Collections.Generic;
using System.Linq;
using DoAnDemo.Models;
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using System.Diagnostics;
using System.Data.Linq;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class NhanVienService : INhanVienService
    {

        public List<NhanVienViewModel> GetNhanVienList(int? storeId = null, string region = null)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    Log($"Service GetNhanVienList called with storeId: {storeId?.ToString() ?? "NULL"}, region: {region ?? "NULL"}");

                    var query = from nv in db.NhanViens
                                join ch in db.CuaHangs on nv.id_cua_hang_lam_viec equals ch.id_cua_hang
                                // Lọc theo storeId nếu được cung cấp và > 0
                                where (!storeId.HasValue || storeId.Value <= 0 || nv.id_cua_hang_lam_viec == storeId.Value)
                                // Lọc thêm theo region nếu được cung cấp
                                && (string.IsNullOrWhiteSpace(region) || ch.khu_vuc == region)
                                // && nv.trang_thai == "dang_lam_viec" // Chỉ lấy NV đang làm việc?
                                orderby ch.ten_cua_hang, nv.ten_nhan_vien
                                select new NhanVienViewModel
                                {
                                    Id = nv.id_nhan_vien,
                                    MaNV = nv.ma_nhan_vien,
                                    TenNV = nv.ten_nhan_vien,
                                    SDT = nv.so_dien_thoai,
                                    TaiKhoan = nv.tai_khoan_dang_nhap,
                                    TenChiNhanh = ch.ten_cua_hang,
                                    IdCuaHangLamViec = nv.id_cua_hang_lam_viec, // <<< Thêm ID cửa hàng
                                    QuyenHan = nv.quyen_han,
                                    TrangThai = nv.trang_thai,
                                    NgayVaoLam = nv.ngay_vao_lam
                                };

                    var resultList = query.ToList();
                    Log($"Service GetNhanVienList returned {resultList.Count} employees.");
                    return resultList;
                }
                catch (Exception ex) { LogError("GetNhanVienList", ex); return new List<NhanVienViewModel>(); }
            }
        }

        // --- IMPLEMENT AddNhanVien ---
        public NhanVienViewModel AddNhanVien(NhanVienViewModel nvInfo, string plainPassword)
        {
            if (nvInfo == null) throw new ArgumentNullException(nameof(nvInfo));
            if (string.IsNullOrWhiteSpace(plainPassword)) throw new ArgumentException("Mật khẩu không được để trống.");
            // Thêm các validation khác nếu cần (độ dài mật khẩu...)

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    // --- Validation trong BLL ---
                    if (string.IsNullOrWhiteSpace(nvInfo.MaNV) || string.IsNullOrWhiteSpace(nvInfo.TenNV) || string.IsNullOrWhiteSpace(nvInfo.TaiKhoan) || nvInfo.IdCuaHangLamViec <= 0 || string.IsNullOrWhiteSpace(nvInfo.QuyenHan) || string.IsNullOrWhiteSpace(nvInfo.TrangThai))
                        throw new ArgumentException("Các trường bắt buộc (Mã NV, Tên, Tài khoản, Chi nhánh, Quyền hạn, Trạng thái) không được thiếu.");
                    if (db.NhanViens.Any(nv => nv.ma_nhan_vien == nvInfo.MaNV)) throw new ArgumentException($"Mã nhân viên '{nvInfo.MaNV}' đã tồn tại.");
                    if (db.NhanViens.Any(nv => nv.tai_khoan_dang_nhap == nvInfo.TaiKhoan)) throw new ArgumentException($"Tài khoản đăng nhập '{nvInfo.TaiKhoan}' đã tồn tại.");
                    if (!string.IsNullOrWhiteSpace(nvInfo.SDT) && db.NhanViens.Any(nv => nv.so_dien_thoai == nvInfo.SDT)) throw new ArgumentException($"Số điện thoại '{nvInfo.SDT}' đã tồn tại.");
                    // Kiểm tra tính hợp lệ của QuyenHan, TrangThai (có thể dùng Enum thay vì string)
                    var allowedRoles = new[] { "nhan_vien", "quan_ly_cua_hang", "quan_ly_khu_vuc", "admin" };
                    var allowedStatuses = new[] { "dang_lam_viec", "da_nghi_viec" };
                    if (!allowedRoles.Contains(nvInfo.QuyenHan)) throw new ArgumentException("Quyền hạn không hợp lệ.");
                    if (!allowedStatuses.Contains(nvInfo.TrangThai)) throw new ArgumentException("Trạng thái không hợp lệ.");


                    // *** HASH MẬT KHẨU ***
                    // string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword); // Dùng thư viện thực tế
                    string hashedPassword = "hashed_" + plainPassword + "_placeholder"; // <<<< PLACEHOLDER - THAY BẰNG HASH THẬT

                    // Tạo entity NhanVien
                    var entity = new NhanVien
                    {
                        id_cua_hang_lam_viec = nvInfo.IdCuaHangLamViec, // Lấy từ ViewModel
                        ma_nhan_vien = nvInfo.MaNV.Trim(),
                        ten_nhan_vien = nvInfo.TenNV.Trim(),
                        so_dien_thoai = nvInfo.SDT?.Trim(),
                        tai_khoan_dang_nhap = nvInfo.TaiKhoan.Trim(),
                        mat_khau_hash = hashedPassword, // << Lưu mật khẩu đã hash
                        quyen_han = nvInfo.QuyenHan,
                        trang_thai = nvInfo.TrangThai,
                        ngay_vao_lam = nvInfo.NgayVaoLam,
                        ngay_tao = DateTime.Now,
                        ngay_cap_nhat = DateTime.Now
                    };

                    db.NhanViens.InsertOnSubmit(entity);
                    db.SubmitChanges();

                    // Map lại entity vừa tạo sang ViewModel để trả về (có ID mới)
                    nvInfo.Id = entity.id_nhan_vien;
                    Log($"Added Employee: ID={nvInfo.Id}, Code={nvInfo.MaNV}");
                    return nvInfo;
                }
                catch (Exception ex)
                {
                    LogError("AddNhanVien", ex);
                    throw; // Ném lại lỗi để UI xử lý
                }
            }
        }

        // *** IMPLEMENT ChangeNhanVienStatus ***
        public bool ChangeNhanVienStatus(int employeeId, string newStatus)
        {
            var allowedStatuses = new[] { "dang_lam_viec", "da_nghi_viec" };
            if (!allowedStatuses.Contains(newStatus?.ToLower())) throw new ArgumentException("Trạng thái mới không hợp lệ.");

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var entity = db.NhanViens.FirstOrDefault(nv => nv.id_nhan_vien == employeeId);
                    if (entity == null) return false; // Không tìm thấy

                    if (entity.trang_thai == newStatus) return true; // Trạng thái đã đúng

                    entity.trang_thai = newStatus;
                    entity.ngay_cap_nhat = DateTime.Now;
                    db.SubmitChanges();
                    Log($"Changed status for employee {employeeId} to {newStatus}");
                    return true;
                }
                catch (Exception ex)
                {
                    LogError($"ChangeNhanVienStatus({employeeId}, {newStatus})", ex);
                    throw; // Ném lỗi để UI xử lý
                }
            }
        }

        // *** IMPLEMENT UpdateNhanVien ***
        public bool UpdateNhanVien(NhanVienViewModel nvInfo)
        {
            if (nvInfo == null || nvInfo.Id <= 0) throw new ArgumentException("Thông tin nhân viên không hợp lệ để cập nhật.");

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var entity = db.NhanViens.FirstOrDefault(nv => nv.id_nhan_vien == nvInfo.Id);
                    if (entity == null) { LogError($"UpdateNhanVien: Employee ID {nvInfo.Id} not found.", null); return false; }

                    // --- Validation ---
                    if (string.IsNullOrWhiteSpace(nvInfo.TenNV) || nvInfo.IdCuaHangLamViec <= 0 || string.IsNullOrWhiteSpace(nvInfo.QuyenHan) || string.IsNullOrWhiteSpace(nvInfo.TrangThai))
                        throw new ArgumentException("Tên, Chi nhánh, Quyền hạn, Trạng thái không được thiếu.");
                    // Kiểm tra trùng SĐT nếu thay đổi
                    if (!string.IsNullOrWhiteSpace(nvInfo.SDT) && entity.so_dien_thoai != nvInfo.SDT && db.NhanViens.Any(nv => nv.id_nhan_vien != nvInfo.Id && nv.so_dien_thoai == nvInfo.SDT))
                        throw new ArgumentException($"Số điện thoại '{nvInfo.SDT}' đã được sử dụng.");
                    // KHÔNG kiểm tra trùng Mã NV, Tài khoản vì không cho sửa trên form này

                    // --- Cập nhật Entity ---
                    entity.ten_nhan_vien = nvInfo.TenNV.Trim();
                    entity.so_dien_thoai = nvInfo.SDT?.Trim();
                    entity.id_cua_hang_lam_viec = nvInfo.IdCuaHangLamViec;
                    entity.quyen_han = nvInfo.QuyenHan;
                    //entity.trang_thai = nvInfo.TrangThai; // Cho phép sửa trạng thái nếu cần (nhưng nên dùng ChangeNhanVienStatus)
                    entity.ngay_vao_lam = nvInfo.NgayVaoLam;
                    entity.ngay_cap_nhat = DateTime.Now;
                    // KHÔNG CẬP NHẬT MẬT KHẨU Ở ĐÂY

                    db.SubmitChanges();
                    Log($"Updated Employee: ID={nvInfo.Id}");
                    return true;
                }
                catch (ChangeConflictException ex) { LogError($"UpdateNhanVien Conflict ID {nvInfo.Id}", ex); throw new Exception("Dữ liệu nhân viên đã bị thay đổi.", ex); }
                catch (Exception ex) { LogError($"UpdateNhanVien ID {nvInfo.Id}", ex); throw; }
            }
        }

        // --- Placeholders cho các hàm khác ---
        public NhanVienViewModel GetNhanVienDetails(int employeeId) { LogError($"GetNhanVienDetails({employeeId})", new NotImplementedException()); return null; }
        private void Log(string message) { Debug.WriteLine($"[NhanVienService] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[NhanVienService ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }
    }
}
