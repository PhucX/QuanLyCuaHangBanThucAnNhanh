// Utils/CurrentUserContext.cs
using DoAnDemo.Models;

namespace DoAnDemo.Utils
{
    public static class CurrentUserContext
    {
        public static LoggedInUserInfo User { get; private set; }
        public static void SetLoggedInUser(LoggedInUserInfo user) { User = user; }
        public static void Logout() { User = null; }
        public static bool IsLoggedIn => User != null;
        public static bool IsAdmin => IsLoggedIn && User.Role == "admin";
        public static bool IsAreaManager => IsLoggedIn && User.Role == "quan_ly_khu_vuc";
        public static bool IsStoreManager => IsLoggedIn && User.Role == "quan_ly_cua_hang";
        public static bool IsStaff => IsLoggedIn && User.Role == "nhan_vien";
    }
}