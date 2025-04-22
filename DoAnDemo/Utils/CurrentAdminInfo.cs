// CurrentAdminInfo.cs
namespace DoAnDemo.Utils
{
    public static class CurrentAdminInfo
    {
        // Giả sử các thông tin này được gán khi Admin đăng nhập thành công
        public static int EmployeeId { get; set; } = 1;
        public static string EmployeeName { get; set; } = "Admin Default";
        public static int DefaultStoreId { get; set; } = 1;
        public static string Role { get; set; } = "admin";
    }
}