using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System.Diagnostics;
using System;
using System.Linq;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class AuthService : IAuthService
    {
        public LoggedInUserInfo Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null; // Không hợp lệ
            }

            using (var db = new FastFoodDataContext())
            {
                try
                {
                    // Tìm nhân viên theo tài khoản đăng nhập
                    var employeeEntity = db.NhanViens
                                           .FirstOrDefault(nv => nv.tai_khoan_dang_nhap.ToLower() == username.ToLower());

                    // Kiểm tra tồn tại, trạng thái và mật khẩu
                    if (employeeEntity != null && employeeEntity.trang_thai == "dang_lam_viec")
                    {
                        // *** XÁC THỰC MẬT KHẨU ĐÃ HASH ***
                        bool isPasswordValid = false;
                        try
                        {
                            // isPasswordValid = BCrypt.Net.BCrypt.Verify(password, employeeEntity.mat_khau_hash); // Dùng thư viện thật
                            isPasswordValid = (password == employeeEntity.mat_khau_hash); // <<<< PLACEHOLDER - THAY BẰNG HÀM VERIFY THẬT
                        }
                        catch (Exception hashEx)
                        {
                            LogError($"Password verification error for user {username}", hashEx);
                            // Xử lý lỗi hash (vd: hash không đúng định dạng)
                            isPasswordValid = false;
                        }


                        if (isPasswordValid)
                        {
                            // Đăng nhập thành công, lấy thêm tên cửa hàng
                            var storeName = db.CuaHangs
                                              .Where(ch => ch.id_cua_hang == employeeEntity.id_cua_hang_lam_viec)
                                              .Select(ch => ch.ten_cua_hang)
                                              .FirstOrDefault() ?? "N/A";

                            // Tạo đối tượng thông tin người dùng
                            var userInfo = new LoggedInUserInfo
                            {
                                EmployeeId = employeeEntity.id_nhan_vien,
                                MaNV = employeeEntity.ma_nhan_vien,
                                TenNV = employeeEntity.ten_nhan_vien,
                                TaiKhoan = employeeEntity.tai_khoan_dang_nhap,
                                Role = employeeEntity.quyen_han,
                                DefaultStoreId = employeeEntity.id_cua_hang_lam_viec,
                                TenCuaHang = storeName
                            };
                            Log($"Login successful for user: {username}, Role: {userInfo.Role}");
                            return userInfo;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogError($"Login attempt failed for user {username}", ex);
                    // Ném lại lỗi hoặc trả về null tùy cách xử lý
                    // return null;
                    throw; // Ném lại để Form xử lý
                }
            }

            Log($"Login failed for user: {username}");
            return null; // Đăng nhập thất bại (sai tên đăng nhập, mật khẩu, hoặc không active)
        }

        private void Log(string message) { Debug.WriteLine($"[AuthService] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[AuthService ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }
    }
}