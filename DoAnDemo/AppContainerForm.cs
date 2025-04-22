using System;
using System.Windows.Forms;
using DoAnDemo.HienThiGoc;
using DoAnDemo.Form.FormAdmin;

namespace DoAnDemo
{
    public partial class AppContainerForm : System.Windows.Forms.Form
    {
        private FormHienThi formHienThi;
        private FormTrangChuAdmin formTrangChuAdmin;
        private FormDangNhap formDangNhap;

        public AppContainerForm()
        {
            InitializeComponent();
            this.Load += AppContainerForm_Load;
        }

        private void LoadSubControl(UserControl controlToLoad)
        {
            if (controlToLoad == null) return;

            try
            {
                this.SuspendLayout();
                controlToLoad.SuspendLayout();

                controlToLoad.Dock = DockStyle.Fill;
                controlToLoad.AutoSize = false;

                this.Controls.Clear();
                this.Controls.Add(controlToLoad);
            }
            finally
            {
                controlToLoad.ResumeLayout(true);
                this.ResumeLayout(true);
                
                // Force refresh để đảm bảo hiển thị đúng
                controlToLoad.Invalidate();
                controlToLoad.Update();
                this.Refresh();
            }
        }

        private void AppContainerForm_Load(object sender, EventArgs e)
        {
            formHienThi = new FormHienThi();
            formTrangChuAdmin = new FormTrangChuAdmin();
            formDangNhap = new FormDangNhap();

            if (formDangNhap != null)
            {
                formDangNhap.LoginSuccessful += FormDangNhap_LoginSuccessful;
            }

            // Show login form first
            LoadSubControl(formDangNhap);
        }

        private void ShowLoginForm()
        {
            if (formDangNhap == null)
            {
                formDangNhap = new FormDangNhap();
                formDangNhap.LoginSuccessful += FormDangNhap_LoginSuccessful;
            }
            LoadSubControl(formDangNhap);
        }

        private void FormDangNhap_LoginSuccessful(object sender, LoginSuccessEventArgs e)
        {
            if (e.UserRole == "admin" 
                || e.UserRole == "quan_ly_khu_vuc" 
                || e.UserRole == "quan_ly_cua_hang")
            {
                if (formTrangChuAdmin == null)
                {
                    formTrangChuAdmin = new FormTrangChuAdmin();
                }
                LoadSubControl(formTrangChuAdmin);
            }
            else
            {
                //if (formHienThi == null)
                //{
                //    formHienThi = new FormHienThi();
                //    SetupFormHienThiEvents();
                //}
                //LoadSubControl(formHienThi);
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }
        }

        private void SetupFormHienThiEvents()
        {
            if (formHienThi != null)
            {
                formHienThi.NavigateToPaymentRequested += FormHienThi_NavigateToPaymentRequested;
            }
        }

        private void FormHienThi_NavigateToPaymentRequested(object sender, PaymentEventArgs e)
        {
            var formThanhToan = new FormThanhToan();
            formThanhToan.LoadOrderData(e);
            LoadSubControl(formThanhToan);
        }

        private void FormHienThi_LogoutRequested(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void FormTrangChuAdmin_LogoutRequested(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
    }
}