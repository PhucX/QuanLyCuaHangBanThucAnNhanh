using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

// Namespace theo yêu cầu
namespace DoAnDemo.Form.FormAdmin
{
    partial class FormEditMember
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaTV = new System.Windows.Forms.Label();
            this.txtMaTV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.lblCuaHangDK = new System.Windows.Forms.Label();
            this.cmbCuaHangDK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCapDo = new System.Windows.Forms.Label();
            this.txtCapDo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCHDangKy = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN THÀNH VIÊN";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoTen.Location = new System.Drawing.Point(22, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(83, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên *";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtHoTen.BorderRadius = 5;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.Location = new System.Drawing.Point(25, 80);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Nhập họ và tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(350, 36);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblMaTV
            // 
            this.lblMaTV.AutoSize = true;
            this.lblMaTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaTV.Location = new System.Drawing.Point(22, 130);
            this.lblMaTV.Name = "lblMaTV";
            this.lblMaTV.Size = new System.Drawing.Size(102, 20);
            this.lblMaTV.TabIndex = 5;
            this.lblMaTV.Text = "Mã thành viên";
            // 
            // txtMaTV
            // 
            this.txtMaTV.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMaTV.BorderRadius = 5;
            this.txtMaTV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTV.DefaultText = "";
            this.txtMaTV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtMaTV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtMaTV.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaTV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaTV.Location = new System.Drawing.Point(25, 150);
            this.txtMaTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTV.Name = "txtMaTV";
            this.txtMaTV.PlaceholderText = "Mã tự động / có sẵn";
            this.txtMaTV.ReadOnly = true;
            this.txtMaTV.SelectedText = "";
            this.txtMaTV.Size = new System.Drawing.Size(350, 36);
            this.txtMaTV.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(22, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(25, 220);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Nhập email (nếu có)";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(350, 36);
            this.txtEmail.TabIndex = 8;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSDT.Location = new System.Drawing.Point(417, 60);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(107, 20);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "Số điện thoại *";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSDT.BorderRadius = 5;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.Location = new System.Drawing.Point(420, 80);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "Nhập SĐT";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(350, 36);
            this.txtSDT.TabIndex = 10;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(417, 130);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 20);
            this.lblGioiTinh.TabIndex = 11;
            this.lblGioiTinh.Text = "Giới tính";
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
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(582, 130);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(74, 20);
            this.lblNgaySinh.TabIndex = 13;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
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
            this.dtpNgaySinh.Size = new System.Drawing.Size(185, 36);
            this.dtpNgaySinh.TabIndex = 14;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 4, 10, 9, 8, 58, 791);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiem.Location = new System.Drawing.Point(417, 200);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(45, 20);
            this.lblDiem.TabIndex = 21;
            this.lblDiem.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDiem.BorderRadius = 5;
            this.txtDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiem.DefaultText = "0";
            this.txtDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtDiem.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiem.Location = new System.Drawing.Point(420, 220);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.PlaceholderText = "";
            this.txtDiem.ReadOnly = true;
            this.txtDiem.SelectedText = "";
            this.txtDiem.Size = new System.Drawing.Size(150, 36);
            this.txtDiem.TabIndex = 22;
            this.txtDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTrangThai.Location = new System.Drawing.Point(22, 270);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(85, 20);
            this.lblTrangThai.TabIndex = 25;
            this.lblTrangThai.Text = "Trạng thái *";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderColor = System.Drawing.Color.Gainsboro;
            this.cboTrangThai.BorderRadius = 5;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Location = new System.Drawing.Point(25, 290);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(350, 36);
            this.cboTrangThai.TabIndex = 26;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(665, 440);
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
            this.btnHuy.Location = new System.Drawing.Point(545, 440);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 40);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            // 
            // lblCuaHangDK
            // 
            this.lblCuaHangDK.AutoSize = true;
            this.lblCuaHangDK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuaHangDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCuaHangDK.Location = new System.Drawing.Point(22, 417);
            this.lblCuaHangDK.Name = "lblCuaHangDK";
            this.lblCuaHangDK.Size = new System.Drawing.Size(87, 20);
            this.lblCuaHangDK.TabIndex = 30;
            this.lblCuaHangDK.Text = "CH Đăng ký";
            // 
            // cmbCuaHangDK
            // 
            this.cmbCuaHangDK.BackColor = System.Drawing.Color.Transparent;
            this.cmbCuaHangDK.BorderRadius = 5;
            this.cmbCuaHangDK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCuaHangDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuaHangDK.Enabled = false;
            this.cmbCuaHangDK.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCuaHangDK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCuaHangDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCuaHangDK.ItemHeight = 30;
            this.cmbCuaHangDK.Location = new System.Drawing.Point(420, 290);
            this.cmbCuaHangDK.Name = "cmbCuaHangDK";
            this.cmbCuaHangDK.Size = new System.Drawing.Size(350, 36);
            this.cmbCuaHangDK.TabIndex = 15;
            // 
            // lblCapDo
            // 
            this.lblCapDo.AutoSize = true;
            this.lblCapDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCapDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCapDo.Location = new System.Drawing.Point(22, 340);
            this.lblCapDo.Name = "lblCapDo";
            this.lblCapDo.Size = new System.Drawing.Size(57, 20);
            this.lblCapDo.TabIndex = 29;
            this.lblCapDo.Text = "Cấp độ";
            // 
            // txtCapDo
            // 
            this.txtCapDo.BorderRadius = 5;
            this.txtCapDo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapDo.DefaultText = "";
            this.txtCapDo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCapDo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCapDo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCapDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCapDo.Location = new System.Drawing.Point(25, 360);
            this.txtCapDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCapDo.Name = "txtCapDo";
            this.txtCapDo.PlaceholderText = "";
            this.txtCapDo.ReadOnly = true;
            this.txtCapDo.SelectedText = "";
            this.txtCapDo.Size = new System.Drawing.Size(350, 36);
            this.txtCapDo.TabIndex = 23;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGhiChu.Location = new System.Drawing.Point(417, 270);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(58, 20);
            this.lblGhiChu.TabIndex = 28;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.BorderRadius = 5;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(420, 290);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PlaceholderText = "Nhập ghi chú (nếu có)";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(350, 106);
            this.txtGhiChu.TabIndex = 27;
            // 
            // txtCHDangKy
            // 
            this.txtCHDangKy.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCHDangKy.BorderRadius = 5;
            this.txtCHDangKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCHDangKy.DefaultText = "";
            this.txtCHDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCHDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCHDangKy.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCHDangKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCHDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCHDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCHDangKy.Location = new System.Drawing.Point(25, 444);
            this.txtCHDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCHDangKy.Name = "txtCHDangKy";
            this.txtCHDangKy.PlaceholderText = "Mã tự động / có sẵn";
            this.txtCHDangKy.ReadOnly = true;
            this.txtCHDangKy.SelectedText = "";
            this.txtCHDangKy.Size = new System.Drawing.Size(350, 36);
            this.txtCHDangKy.TabIndex = 31;
            // 
            // FormEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtCHDangKy);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtCapDo);
            this.Controls.Add(this.lblCapDo);
            this.Controls.Add(this.cmbCuaHangDK);
            this.Controls.Add(this.lblCuaHangDK);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMaTV);
            this.Controls.Add(this.lblMaTV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormEditMember";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen; // Đã đổi tên
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen; // Đã đổi tên
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
        private System.Windows.Forms.Label lblDiem;
        private Guna.UI2.WinForms.Guna2TextBox txtDiem;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.Label lblCuaHangDK; // Thêm
        private Guna.UI2.WinForms.Guna2ComboBox cmbCuaHangDK; // Thêm
        private System.Windows.Forms.Label lblCapDo; // Thêm
        private Guna.UI2.WinForms.Guna2TextBox txtCapDo; // Thêm
        private System.Windows.Forms.Label lblGhiChu; // Thêm
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu; // Thêm
        private Guna2TextBox txtCHDangKy;
    }
}