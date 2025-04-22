// FormAddMember.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormAddMember
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
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtCHDangKy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCuaHangDK = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMaTV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaTV = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
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
            this.guna2PanelTop.Size = new System.Drawing.Size(835, 50);
            this.guna2PanelTop.TabIndex = 2;
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
            this.lblTitle.Size = new System.Drawing.Size(246, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM MỚI THÀNH VIÊN";
            // 
            // guna2PanelContent
            // 
            this.guna2PanelContent.BackColor = System.Drawing.Color.White;
            this.guna2PanelContent.Controls.Add(this.txtGhiChu);
            this.guna2PanelContent.Controls.Add(this.lblGhiChu);
            this.guna2PanelContent.Controls.Add(this.txtCHDangKy);
            this.guna2PanelContent.Controls.Add(this.lblCuaHangDK);
            this.guna2PanelContent.Controls.Add(this.dtpNgaySinh);
            this.guna2PanelContent.Controls.Add(this.lblNgaySinh);
            this.guna2PanelContent.Controls.Add(this.cboGioiTinh);
            this.guna2PanelContent.Controls.Add(this.lblGioiTinh);
            this.guna2PanelContent.Controls.Add(this.txtEmail);
            this.guna2PanelContent.Controls.Add(this.lblEmail);
            this.guna2PanelContent.Controls.Add(this.txtMaTV);
            this.guna2PanelContent.Controls.Add(this.lblMaTV);
            this.guna2PanelContent.Controls.Add(this.btnLuu);
            this.guna2PanelContent.Controls.Add(this.btnHuy);
            this.guna2PanelContent.Controls.Add(this.txtHoTen);
            this.guna2PanelContent.Controls.Add(this.lblHoTen);
            this.guna2PanelContent.Controls.Add(this.txtSDT);
            this.guna2PanelContent.Controls.Add(this.lblSDT);
            this.guna2PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContent.Location = new System.Drawing.Point(0, 50);
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.Padding = new System.Windows.Forms.Padding(25);
            this.guna2PanelContent.Size = new System.Drawing.Size(835, 490);
            this.guna2PanelContent.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.BorderRadius = 5;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(31, 290);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PlaceholderText = "Nhập ghi chú (nếu có)";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(774, 140);
            this.txtGhiChu.TabIndex = 27;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGhiChu.Location = new System.Drawing.Point(28, 270);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(58, 20);
            this.lblGhiChu.TabIndex = 28;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtCHDangKy
            // 
            this.txtCHDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCHDangKy.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCHDangKy.BorderRadius = 5;
            this.txtCHDangKy.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCHDangKy.DefaultText = "";
            this.txtCHDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCHDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCHDangKy.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCHDangKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCHDangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtCHDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCHDangKy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCHDangKy.Location = new System.Drawing.Point(420, 220);
            this.txtCHDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCHDangKy.Name = "txtCHDangKy";
            this.txtCHDangKy.PlaceholderText = "";
            this.txtCHDangKy.ReadOnly = true;
            this.txtCHDangKy.SelectedText = "";
            this.txtCHDangKy.Size = new System.Drawing.Size(385, 36);
            this.txtCHDangKy.TabIndex = 16;
            // 
            // lblCuaHangDK
            // 
            this.lblCuaHangDK.AutoSize = true;
            this.lblCuaHangDK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuaHangDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCuaHangDK.Location = new System.Drawing.Point(417, 200);
            this.lblCuaHangDK.Name = "lblCuaHangDK";
            this.lblCuaHangDK.Size = new System.Drawing.Size(128, 20);
            this.lblCuaHangDK.TabIndex = 29;
            this.lblCuaHangDK.Text = "Cửa hàng đăng ký";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpNgaySinh.BorderRadius = 5;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(585, 150);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShowCheckBox = true;
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 36);
            this.dtpNgaySinh.TabIndex = 14;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 4, 10, 15, 8, 36, 65);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(582, 130);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(74, 20);
            this.lblNgaySinh.TabIndex = 13;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinh.BorderColor = System.Drawing.Color.Gainsboro;
            this.cboGioiTinh.BorderRadius = 5;
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioiTinh.ItemHeight = 30;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(420, 150);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(150, 36);
            this.cboGioiTinh.TabIndex = 12;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(417, 130);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 20);
            this.lblGioiTinh.TabIndex = 11;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(31, 190);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Nhập email (nếu có)";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(350, 36);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(28, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // txtMaTV
            // 
            this.txtMaTV.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMaTV.BorderRadius = 5;
            this.txtMaTV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTV.DefaultText = "";
            this.txtMaTV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaTV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTV.Location = new System.Drawing.Point(31, 120);
            this.txtMaTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTV.Name = "txtMaTV";
            this.txtMaTV.PlaceholderText = "Để trống tự sinh hoặc nhập mã";
            this.txtMaTV.SelectedText = "";
            this.txtMaTV.Size = new System.Drawing.Size(350, 36);
            this.txtMaTV.TabIndex = 5;
            // 
            // lblMaTV
            // 
            this.lblMaTV.AutoSize = true;
            this.lblMaTV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaTV.Location = new System.Drawing.Point(28, 100);
            this.lblMaTV.Name = "lblMaTV";
            this.lblMaTV.Size = new System.Drawing.Size(102, 20);
            this.lblMaTV.TabIndex = 4;
            this.lblMaTV.Text = "Mã thành viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(697, 447);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 40);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.BorderThickness = 1;
            this.btnHuy.FillColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.Location = new System.Drawing.Point(581, 447);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 40);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtHoTen.BorderRadius = 5;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(31, 50);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Nhập họ và tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(350, 36);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoTen.Location = new System.Drawing.Point(28, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(83, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên *";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSDT.BorderRadius = 5;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(420, 80);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "Nhập SĐT (10 số)";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(385, 36);
            this.txtSDT.TabIndex = 4;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSDT.Location = new System.Drawing.Point(417, 60);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(107, 20);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số điện thoại *";
            // 
            // FormAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PanelContent);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAddMember";
            this.Size = new System.Drawing.Size(835, 540);
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
        private System.Windows.Forms.Label lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label lblMaTV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTV;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label lblGioiTinh;
        private Guna.UI2.WinForms.Guna2ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblCuaHangDK;
        private Guna.UI2.WinForms.Guna2TextBox txtCHDangKy;
        private System.Windows.Forms.Label lblGhiChu;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}