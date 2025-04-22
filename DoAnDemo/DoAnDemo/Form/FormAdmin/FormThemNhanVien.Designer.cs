using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

// Namespace theo yêu cầu
namespace DoAnDemo.Form.FormAdmin
{
    partial class FormThemNhanVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgayVaoLam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.cmbTrangThaiNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTrangThaiNV = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.cmbQuyenHan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblQuyenHan = new System.Windows.Forms.Label();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.cmbChiNhanhLamViec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.guna2PanelTop.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelTop.ShadowDecoration.Enabled = true;
            this.guna2PanelTop.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2PanelTop.Size = new System.Drawing.Size(800, 50);
            this.guna2PanelTop.TabIndex = 0;
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
            this.lblTitle.Size = new System.Drawing.Size(188, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM NHÂN VIÊN";
            // 
            // guna2PanelContent
            // 
            this.guna2PanelContent.Controls.Add(this.cmbChiNhanhLamViec);
            this.guna2PanelContent.Controls.Add(this.lblChiNhanh);
            this.guna2PanelContent.Controls.Add(this.label2);
            this.guna2PanelContent.Controls.Add(this.label1);
            this.guna2PanelContent.Controls.Add(this.btnLuu);
            this.guna2PanelContent.Controls.Add(this.dtpNgayVaoLam);
            this.guna2PanelContent.Controls.Add(this.lblNgayVaoLam);
            this.guna2PanelContent.Controls.Add(this.cmbTrangThaiNV);
            this.guna2PanelContent.Controls.Add(this.lblTrangThaiNV);
            this.guna2PanelContent.Controls.Add(this.txtXacNhanMK);
            this.guna2PanelContent.Controls.Add(this.lblXacNhanMK);
            this.guna2PanelContent.Controls.Add(this.txtMatKhau);
            this.guna2PanelContent.Controls.Add(this.lblMatKhau);
            this.guna2PanelContent.Controls.Add(this.txtTaiKhoan);
            this.guna2PanelContent.Controls.Add(this.lblTaiKhoan);
            this.guna2PanelContent.Controls.Add(this.txtMaNhanVien);
            this.guna2PanelContent.Controls.Add(this.lblMaNhanVien);
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
            this.guna2PanelContent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số điện thoại*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(417, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên nhân viên*";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(592, 438);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 45);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.BorderRadius = 5;
            this.dtpNgayVaoLam.Checked = true;
            this.dtpNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(30, 400);
            this.dtpNgayVaoLam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayVaoLam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(350, 36);
            this.dtpNgayVaoLam.TabIndex = 10;
            this.dtpNgayVaoLam.Value = new System.DateTime(2025, 4, 9, 4, 33, 35, 880);
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayVaoLam.Location = new System.Drawing.Point(27, 380);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(101, 20);
            this.lblNgayVaoLam.TabIndex = 11;
            this.lblNgayVaoLam.Text = "Ngày vào làm";
            // 
            // cmbTrangThaiNV
            // 
            this.cmbTrangThaiNV.BackColor = System.Drawing.Color.Transparent;
            this.cmbTrangThaiNV.BorderRadius = 5;
            this.cmbTrangThaiNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrangThaiNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThaiNV.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTrangThaiNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTrangThaiNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTrangThaiNV.ItemHeight = 30;
            this.cmbTrangThaiNV.Location = new System.Drawing.Point(30, 330);
            this.cmbTrangThaiNV.Name = "cmbTrangThaiNV";
            this.cmbTrangThaiNV.Size = new System.Drawing.Size(350, 36);
            this.cmbTrangThaiNV.TabIndex = 9;
            // 
            // lblTrangThaiNV
            // 
            this.lblTrangThaiNV.AutoSize = true;
            this.lblTrangThaiNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThaiNV.Location = new System.Drawing.Point(27, 310);
            this.lblTrangThaiNV.Name = "lblTrangThaiNV";
            this.lblTrangThaiNV.Size = new System.Drawing.Size(85, 20);
            this.lblTrangThaiNV.TabIndex = 12;
            this.lblTrangThaiNV.Text = "Trạng thái *";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.BorderRadius = 5;
            this.txtXacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMK.DefaultText = "";
            this.txtXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtXacNhanMK.Location = new System.Drawing.Point(420, 330);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PlaceholderText = "Nhập lại mật khẩu";
            this.txtXacNhanMK.SelectedText = "";
            this.txtXacNhanMK.Size = new System.Drawing.Size(350, 36);
            this.txtXacNhanMK.TabIndex = 8;
            this.txtXacNhanMK.UseSystemPasswordChar = true;
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblXacNhanMK.Location = new System.Drawing.Point(417, 310);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(144, 20);
            this.lblXacNhanMK.TabIndex = 13;
            this.lblXacNhanMK.Text = "Xác nhận mật khẩu *";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderRadius = 5;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.Location = new System.Drawing.Point(420, 260);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(350, 36);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMatKhau.Location = new System.Drawing.Point(417, 240);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(80, 20);
            this.lblMatKhau.TabIndex = 14;
            this.lblMatKhau.Text = "Mật khẩu *";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderRadius = 5;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaiKhoan.Location = new System.Drawing.Point(30, 260);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PlaceholderText = "Nhập tài khoản";
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(350, 36);
            this.txtTaiKhoan.TabIndex = 6;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTaiKhoan.Location = new System.Drawing.Point(27, 240);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(156, 20);
            this.lblTaiKhoan.TabIndex = 15;
            this.lblTaiKhoan.Text = "Tài khoản đăng nhập *";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderRadius = 5;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNhanVien.Location = new System.Drawing.Point(30, 190);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PlaceholderText = "Nhập mã NV";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(350, 36);
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaNhanVien.Location = new System.Drawing.Point(27, 170);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(107, 20);
            this.lblMaNhanVien.TabIndex = 17;
            this.lblMaNhanVien.Text = "Mã nhân viên *";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(392, 438);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 45);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien.DefaultText = "";
            this.txtTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNhanVien.Location = new System.Drawing.Point(420, 120);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PlaceholderText = "";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.Size = new System.Drawing.Size(350, 36);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.Location = new System.Drawing.Point(417, 100);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(100, 23);
            this.lblTenNhanVien.TabIndex = 18;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(30, 120);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PlaceholderText = "";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(350, 36);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Location = new System.Drawing.Point(27, 100);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(100, 23);
            this.lblSoDienThoai.TabIndex = 19;
            // 
            // cmbQuyenHan
            // 
            this.cmbQuyenHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQuyenHan.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuyenHan.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbQuyenHan.BorderRadius = 5;
            this.cmbQuyenHan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuyenHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyenHan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuyenHan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuyenHan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbQuyenHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbQuyenHan.ItemHeight = 30;
            this.cmbQuyenHan.Items.AddRange(new object[] {
            "nhan_vien",
            "quan_ly_cua_hang",
            "quan_ly_khu_vuc",
            "admin"});
            this.cmbQuyenHan.Location = new System.Drawing.Point(30, 50);
            this.cmbQuyenHan.Name = "cmbQuyenHan";
            this.cmbQuyenHan.Size = new System.Drawing.Size(740, 36);
            this.cmbQuyenHan.TabIndex = 1;
            // 
            // lblQuyenHan
            // 
            this.lblQuyenHan.AutoSize = true;
            this.lblQuyenHan.BackColor = System.Drawing.Color.Transparent;
            this.lblQuyenHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuyenHan.Location = new System.Drawing.Point(27, 30);
            this.lblQuyenHan.Name = "lblQuyenHan";
            this.lblQuyenHan.Size = new System.Drawing.Size(79, 20);
            this.lblQuyenHan.TabIndex = 0;
            this.lblQuyenHan.Text = "Quyền hạn";
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChiNhanh.Location = new System.Drawing.Point(417, 170);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(80, 20);
            this.lblChiNhanh.TabIndex = 24;
            this.lblChiNhanh.Text = "Chi nhánh*";
            // 
            // cmbChiNhanhLamViec
            // 
            this.cmbChiNhanhLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbChiNhanhLamViec.BackColor = System.Drawing.Color.Transparent;
            this.cmbChiNhanhLamViec.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbChiNhanhLamViec.BorderRadius = 5;
            this.cmbChiNhanhLamViec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChiNhanhLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanhLamViec.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChiNhanhLamViec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChiNhanhLamViec.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbChiNhanhLamViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbChiNhanhLamViec.ItemHeight = 30;
            this.cmbChiNhanhLamViec.Items.AddRange(new object[] {
            "nhan_vien",
            "quan_ly_cua_hang",
            "quan_ly_khu_vuc",
            "admin"});
            this.cmbChiNhanhLamViec.Location = new System.Drawing.Point(419, 190);
            this.cmbChiNhanhLamViec.Name = "cmbChiNhanhLamViec";
            this.cmbChiNhanhLamViec.Size = new System.Drawing.Size(351, 36);
            this.cmbChiNhanhLamViec.TabIndex = 25;
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelContent);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormThemNhanVien";
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
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuyenHan; // Đổi tên từ cboRoleOptions
        private System.Windows.Forms.Label lblQuyenHan;
        private System.Windows.Forms.Label lblMaNhanVien;   // Thêm
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien; // Thêm
        private System.Windows.Forms.Label lblTaiKhoan;     // Thêm
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;     // Thêm
        private System.Windows.Forms.Label lblMatKhau;      // Thêm
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;      // Thêm
        private System.Windows.Forms.Label lblXacNhanMK;    // Thêm
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhanMK;    // Thêm
        private System.Windows.Forms.Label lblTrangThaiNV;  // Thêm
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrangThaiNV;  // Thêm
        private System.Windows.Forms.Label lblNgayVaoLam;   // Thêm
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayVaoLam;   // Thêm
        private Guna2Button btnLuu;
        private Guna2Button btnHuy;
        private Label label2;
        private Label label1;
        private Label lblChiNhanh;
        private Guna2ComboBox cmbChiNhanhLamViec;
    }
}