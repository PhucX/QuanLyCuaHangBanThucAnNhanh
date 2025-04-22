// --- BusinessLogicLayer/Interfaces/IAuthService.cs ---
using DoAnDemo.Models;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IAuthService
    {
        /// <summary>
        /// Xác thực thông tin đăng nhập của nhân viên.
        /// </summary>
        /// <param name="username">Tài khoản đăng nhập.</param>
        /// <param name="password">Mật khẩu dạng thô (plain text).</param>
        /// <returns>Thông tin người dùng nếu đăng nhập thành công, null nếu thất bại.</returns>
        LoggedInUserInfo Login(string username, string password);
    }
}
