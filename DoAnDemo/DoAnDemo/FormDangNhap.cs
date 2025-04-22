using System;
using System.Windows.Forms;
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Utils;

namespace DoAnDemo
{
    public partial class FormDangNhap : UserControl
    {
        private readonly IAuthService _authService;
        public event EventHandler<LoginSuccessEventArgs> LoginSuccessful;

        public FormDangNhap()
        {
            InitializeComponent();
            _authService = new AuthService();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            buttonLogin.Click += BtnDangNhap_Click;
            txtPassword.KeyPress += TxtMatKhau_KeyPress;
        }

        private void TxtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AttemptLogin();
            }
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            AttemptLogin();
        }

        private void AttemptLogin()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var loginResult = _authService.Login(username, password);
                if (loginResult != null)
                {
                    CurrentUserContext.SetLoggedInUser(loginResult); // Lưu thông tin người dùng vào context
                    // Raise event với role phù hợp
                    LoginSuccessful?.Invoke(this, new LoginSuccessEventArgs(loginResult.Role));
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi đăng nhập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class LoginSuccessEventArgs : EventArgs
    {
        public string UserRole { get; }

        public LoginSuccessEventArgs(string role)
        {
            UserRole = role;
        }
    }
}