// --- Models/LoggedInUserInfo.cs ---
namespace DoAnDemo.Models
{
    /// <summary>
    /// Lưu trữ thông tin cơ bản của người dùng sau khi đăng nhập thành công.
    /// </summary>
    public class LoggedInUserInfo
    {
        public int EmployeeId { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string TaiKhoan { get; set; }
        public string Role { get; set; }
        public int DefaultStoreId { get; set; }
        public string TenCuaHang { get; set; }
    }
}
