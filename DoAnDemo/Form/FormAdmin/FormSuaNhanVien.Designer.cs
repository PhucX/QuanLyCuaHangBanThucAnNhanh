// FormSuaNhanVien.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;


namespace DoAnDemo.Form.FormAdmin
{
    partial class FormSuaNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2PanelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgayVaoLam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.cmbTrangThaiNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTrangThaiNV = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.cmbChiNhanhLamViec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.cmbQuyenHan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblQuyenHan = new System.Windows.Forms.Label();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelContent.SuspendLayout();
            this.SuspendLayout();
            //
            // guna2PanelTop
            //
            this.guna2PanelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.guna2PanelTop.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelTop.ShadowDecoration.Enabled = true;
            this.guna2PanelTop.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2PanelTop.Size = new System.Drawing.Size(800, 50);
            this.guna2PanelTop.TabIndex = 1;
            //
            // lblTitle
            //
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CẬP NHẬT NHÂN VIÊN"; // Tiêu đề cho form sửa
            //
            // guna2PanelContent
            //
            this.guna2PanelContent.Controls.Add(this.btnResetPassword); // Thêm nút Reset Password
            this.guna2PanelContent.Controls.Add(this.dtpNgayVaoLam);
            this.guna2PanelContent.Controls.Add(this.lblNgayVaoLam);
            this.guna2PanelContent.Controls.Add(this.cmbTrangThaiNV);
            this.guna2PanelContent.Controls.Add(this.lblTrangThaiNV);
            this.guna2PanelContent.Controls.Add(this.lblMatKhau);      // Chỉ hiển thị label, không có ô nhập
            this.guna2PanelContent.Controls.Add(this.txtTaiKhoan);
            this.guna2PanelContent.Controls.Add(this.lblTaiKhoan);
            this.guna2PanelContent.Controls.Add(this.cmbChiNhanhLamViec);
            this.guna2PanelContent.Controls.Add(this.lblChiNhanh);
            this.guna2PanelContent.Controls.Add(this.txtMaNhanVien);
            this.guna2PanelContent.Controls.Add(this.lblMaNhanVien);
            this.guna2PanelContent.Controls.Add(this.btnLuu);
            this.guna2PanelContent.Controls.Add(this.btnHuy);
            this.guna2PanelContent.Controls.Add(this.txtTenNhanVien);
            this.guna2PanelContent.Controls.Add(this.lblTenNhanVien);
            this.guna2PanelContent.Controls.Add(this.txtSoDienThoai);
            this.guna2PanelContent.Controls.Add(this.lblSoDienThoai);
            this.guna2PanelContent.Controls.Add(this.cmbQuyenHan);
            this.guna2PanelContent.Controls.Add(this.lblQuyenHan);
            this.guna2PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContent.Location = new System.Drawing.Point(0, 50);
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.Padding = new System.Windows.Forms.Padding(25);
            this.guna2PanelContent.Size = new System.Drawing.Size(800, 500);
            this.guna2PanelContent.TabIndex = 2;
            //
            // dtpNgayVaoLam, lblNgayVaoLam
            //
            this.lblNgayVaoLam.AutoSize = true; this.lblNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblNgayVaoLam.Location = new System.Drawing.Point(27, 310); this.lblNgayVaoLam.Name = "lblNgayVaoLam"; this.lblNgayVaoLam.Size = new System.Drawing.Size(103, 20); this.lblNgayVaoLam.Text = "Ngày vào làm";
            this.dtpNgayVaoLam.BorderRadius = 5; /*...*/ this.dtpNgayVaoLam.Checked = true; this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayVaoLam.Location = new System.Drawing.Point(30, 330); this.dtpNgayVaoLam.Size = new System.Drawing.Size(350, 36); this.dtpNgayVaoLam.TabIndex = 9; this.dtpNgayVaoLam.Value = DateTime.Now; // Enabled = true (cho phép sửa)
            //
            // cmbTrangThaiNV, lblTrangThaiNV
            //
            this.lblTrangThaiNV.AutoSize = true; this.lblTrangThaiNV.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblTrangThaiNV.Location = new System.Drawing.Point(417, 310); this.lblTrangThaiNV.Name = "lblTrangThaiNV"; this.lblTrangThaiNV.Size = new System.Drawing.Size(75, 20); this.lblTrangThaiNV.Text = "Trạng thái";
            this.cmbTrangThaiNV.BorderRadius = 5; /*...*/ this.cmbTrangThaiNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbTrangThaiNV.Location = new System.Drawing.Point(420, 330); this.cmbTrangThaiNV.Size = new System.Drawing.Size(350, 36); this.cmbTrangThaiNV.TabIndex = 10; this.cmbTrangThaiNV.Enabled = false; // <<< Vô hiệu hóa khi sửa, dùng nút Toggle Status ở list
            //
            // lblMatKhau
            //
            this.lblMatKhau.AutoSize = true; this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblMatKhau.Location = new System.Drawing.Point(417, 240); this.lblMatKhau.Name = "lblMatKhau"; this.lblMatKhau.Size = new System.Drawing.Size(70, 20); this.lblMatKhau.Text = "Mật khẩu";
            // txtMatKhau, txtXacNhanMK: Đã được thay bằng btnResetPassword
            //
            // txtTaiKhoan, lblTaiKhoan
            //
            this.lblTaiKhoan.AutoSize = true; this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblTaiKhoan.Location = new System.Drawing.Point(27, 240); this.lblTaiKhoan.Name = "lblTaiKhoan"; this.lblTaiKhoan.Size = new System.Drawing.Size(130, 20); this.lblTaiKhoan.Text = "Tài khoản đăng nhập";
            this.txtTaiKhoan.BorderRadius = 5; /*...*/ this.txtTaiKhoan.Location = new System.Drawing.Point(30, 260); this.txtTaiKhoan.Size = new System.Drawing.Size(350, 36); this.txtTaiKhoan.TabIndex = 6; this.txtTaiKhoan.ReadOnly = true; // <<< Không cho sửa tài khoản
            //
            // cmbChiNhanhLamViec, lblChiNhanh
            //
            this.lblChiNhanh.AutoSize = true; this.lblChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblChiNhanh.Location = new System.Drawing.Point(417, 170); this.lblChiNhanh.Name = "lblChiNhanh"; this.lblChiNhanh.Size = new System.Drawing.Size(76, 20); this.lblChiNhanh.Text = "Chi nhánh";
            this.cmbChiNhanhLamViec.BorderRadius = 5; /*...*/ this.cmbChiNhanhLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbChiNhanhLamViec.Location = new System.Drawing.Point(420, 190); this.cmbChiNhanhLamViec.Size = new System.Drawing.Size(350, 36); this.cmbChiNhanhLamViec.TabIndex = 5; // Enabled/Disabled và danh sách sẽ được set trong code-behind
            //
            // txtMaNhanVien, lblMaNhanVien
            //
            this.lblMaNhanVien.AutoSize = true; this.lblMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblMaNhanVien.Location = new System.Drawing.Point(27, 170); this.lblMaNhanVien.Name = "lblMaNhanVien"; this.lblMaNhanVien.Size = new System.Drawing.Size(97, 20); this.lblMaNhanVien.Text = "Mã nhân viên";
            this.txtMaNhanVien.BorderRadius = 5; /*...*/ this.txtMaNhanVien.Location = new System.Drawing.Point(30, 190); this.txtMaNhanVien.Size = new System.Drawing.Size(350, 36); this.txtMaNhanVien.TabIndex = 4; this.txtMaNhanVien.ReadOnly = true; // <<< Không cho sửa Mã NV
            //
            // btnLuu, btnHuy
            //
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))); this.btnLuu.BorderRadius = 5; this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnLuu.ForeColor = System.Drawing.Color.White; this.btnLuu.Location = new System.Drawing.Point(665, 440); this.btnLuu.Name = "btnLuu"; this.btnLuu.Size = new System.Drawing.Size(110, 40); this.btnLuu.TabIndex = 11; this.btnLuu.Text = "Lưu";
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))); this.btnHuy.BorderRadius = 5; this.btnHuy.BorderColor = Color.Gainsboro; this.btnHuy.BorderThickness = 1; this.btnHuy.FillColor = Color.White; this.btnHuy.ForeColor = Color.FromArgb(64, 64, 64); this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnHuy.Location = new System.Drawing.Point(545, 440); this.btnHuy.Name = "btnHuy"; this.btnHuy.Size = new System.Drawing.Size(110, 40); this.btnHuy.TabIndex = 12; this.btnHuy.Text = "Hủy";
            //
            // txtTenNhanVien, lblTenNhanVien
            //
            this.lblTenNhanVien.AutoSize = true; this.lblTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblTenNhanVien.Location = new System.Drawing.Point(417, 30); this.lblTenNhanVien.Name = "lblTenNhanVien"; this.lblTenNhanVien.Size = new System.Drawing.Size(107, 20); this.lblTenNhanVien.Text = "Tên nhân viên *";
            this.txtTenNhanVien.BorderRadius = 5; /*...*/ this.txtTenNhanVien.Location = new System.Drawing.Point(420, 50); this.txtTenNhanVien.Size = new System.Drawing.Size(350, 36); this.txtTenNhanVien.TabIndex = 3; this.txtTenNhanVien.PlaceholderText = "Nhập tên"; // Enabled = true (cho sửa)
            //
            // txtSoDienThoai, lblSoDienThoai
            //
            this.lblSoDienThoai.AutoSize = true; this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblSoDienThoai.Location = new System.Drawing.Point(27, 100); this.lblSoDienThoai.Name = "lblSoDienThoai"; this.lblSoDienThoai.Size = new System.Drawing.Size(97, 20); this.lblSoDienThoai.Text = "Số điện thoại";
            this.txtSoDienThoai.BorderRadius = 5; /*...*/ this.txtSoDienThoai.Location = new System.Drawing.Point(30, 120); this.txtSoDienThoai.Size = new System.Drawing.Size(350, 36); this.txtSoDienThoai.TabIndex = 2; this.txtSoDienThoai.PlaceholderText = "Nhập SĐT"; // Enabled = true (cho sửa)
            //
            // cmbQuyenHan, lblQuyenHan
            //
            this.lblQuyenHan.AutoSize = true; this.lblQuyenHan.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblQuyenHan.Location = new System.Drawing.Point(27, 30); this.lblQuyenHan.Name = "lblQuyenHan"; this.lblQuyenHan.Size = new System.Drawing.Size(89, 20); this.lblQuyenHan.Text = "Quyền hạn *";
            this.cmbQuyenHan.BorderRadius = 5; /*...*/ this.cmbQuyenHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbQuyenHan.Location = new System.Drawing.Point(30, 50); this.cmbQuyenHan.Size = new System.Drawing.Size(350, 36); this.cmbQuyenHan.TabIndex = 1; // Enabled/Disabled và danh sách set trong code-behind
            //
            // btnResetPassword
            //
            this.btnResetPassword.BorderRadius = 5;
            this.btnResetPassword.BorderColor = Color.Silver;
            this.btnResetPassword.BorderThickness = 1;
            this.btnResetPassword.FillColor = Color.WhiteSmoke;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPassword.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResetPassword.Location = new System.Drawing.Point(545, 260); // Ví dụ: đặt cạnh label mật khẩu
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(150, 36);
            this.btnResetPassword.TabIndex = 34;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            //
            // FormSuaNhanVien
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelContent);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FormSuaNhanVien";
            this.Size = new System.Drawing.Size(800, 550);
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelContent.ResumeLayout(false);
            this.guna2PanelContent.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelContent;
        private System.Windows.Forms.Label lblQuyenHan;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuyenHan;
        private System.Windows.Forms.Label lblSoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblChiNhanh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChiNhanhLamViec;
        private System.Windows.Forms.Label lblTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        // Bỏ txtMatKhau, txtXacNhanMK
        private System.Windows.Forms.Label lblTrangThaiNV;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrangThaiNV;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayVaoLam;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnResetPassword; // Thêm nút Reset MK
    }
}