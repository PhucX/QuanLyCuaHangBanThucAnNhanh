// FormSuaChiNhanh.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormSuaChiNhanh
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
            this.lblQuocGia = new System.Windows.Forms.Label();
            this.cboQuocGia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblThanhPho = new System.Windows.Forms.Label();
            this.cboThanhPho = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSDT1 = new System.Windows.Forms.Label();
            this.txtSoDienThoai1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT2 = new System.Windows.Forms.Label();
            this.txtSoDienThoai2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenHienThi = new System.Windows.Forms.Label();
            this.txtTenHienThi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblWifi = new System.Windows.Forms.Label();
            this.txtWifiPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChiDatHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkCauHinhGio = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblGioHoatDong = new System.Windows.Forms.Label();
            this.rbApDungTatCaNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbCauHinhTungNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tsTatCaNgay = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.txtGioMoCua = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDen = new System.Windows.Forms.Label();
            this.txtGioDongCua = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.cmbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.txtKhuVuc = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN CHI NHÁNH";
            // 
            // lblQuocGia
            // 
            this.lblQuocGia.AutoSize = true;
            this.lblQuocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuocGia.Location = new System.Drawing.Point(22, 60);
            this.lblQuocGia.Name = "lblQuocGia";
            this.lblQuocGia.Size = new System.Drawing.Size(69, 20);
            this.lblQuocGia.TabIndex = 1;
            this.lblQuocGia.Text = "Quốc gia";
            // 
            // cboQuocGia
            // 
            this.cboQuocGia.BackColor = System.Drawing.Color.Transparent;
            this.cboQuocGia.BorderColor = System.Drawing.Color.Gainsboro;
            this.cboQuocGia.BorderRadius = 5;
            this.cboQuocGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuocGia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuocGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboQuocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboQuocGia.ItemHeight = 30;
            this.cboQuocGia.Items.AddRange(new object[] {
            "VietNam"});
            this.cboQuocGia.Location = new System.Drawing.Point(25, 80);
            this.cboQuocGia.Name = "cboQuocGia";
            this.cboQuocGia.Size = new System.Drawing.Size(250, 36);
            this.cboQuocGia.StartIndex = 0;
            this.cboQuocGia.TabIndex = 2;
            // 
            // lblThanhPho
            // 
            this.lblThanhPho.AutoSize = true;
            this.lblThanhPho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThanhPho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblThanhPho.Location = new System.Drawing.Point(302, 60);
            this.lblThanhPho.Name = "lblThanhPho";
            this.lblThanhPho.Size = new System.Drawing.Size(79, 20);
            this.lblThanhPho.TabIndex = 3;
            this.lblThanhPho.Text = "Thành phố";
            // 
            // cboThanhPho
            // 
            this.cboThanhPho.BackColor = System.Drawing.Color.Transparent;
            this.cboThanhPho.BorderColor = System.Drawing.Color.Gainsboro;
            this.cboThanhPho.BorderRadius = 5;
            this.cboThanhPho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThanhPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThanhPho.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThanhPho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThanhPho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThanhPho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThanhPho.ItemHeight = 30;
            this.cboThanhPho.Items.AddRange(new object[] {
            "Hồ Chí Minh"});
            this.cboThanhPho.Location = new System.Drawing.Point(305, 80);
            this.cboThanhPho.Name = "cboThanhPho";
            this.cboThanhPho.Size = new System.Drawing.Size(250, 36);
            this.cboThanhPho.StartIndex = 0;
            this.cboThanhPho.TabIndex = 4;
            // 
            // lblSDT1
            // 
            this.lblSDT1.AutoSize = true;
            this.lblSDT1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSDT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSDT1.Location = new System.Drawing.Point(582, 60);
            this.lblSDT1.Name = "lblSDT1";
            this.lblSDT1.Size = new System.Drawing.Size(97, 20);
            this.lblSDT1.TabIndex = 5;
            this.lblSDT1.Text = "Số điện thoại";
            // 
            // txtSoDienThoai1
            // 
            this.txtSoDienThoai1.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSoDienThoai1.BorderRadius = 5;
            this.txtSoDienThoai1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai1.DefaultText = "0364209131";
            this.txtSoDienThoai1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDienThoai1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai1.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSoDienThoai1.IconRightSize = new System.Drawing.Size(18, 18);
            this.txtSoDienThoai1.Location = new System.Drawing.Point(585, 80);
            this.txtSoDienThoai1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai1.Name = "txtSoDienThoai1";
            this.txtSoDienThoai1.PlaceholderText = "";
            this.txtSoDienThoai1.SelectedText = "";
            this.txtSoDienThoai1.Size = new System.Drawing.Size(250, 36);
            this.txtSoDienThoai1.TabIndex = 6;
            // 
            // lblSDT2
            // 
            this.lblSDT2.AutoSize = true;
            this.lblSDT2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSDT2.ForeColor = System.Drawing.Color.Gray;
            this.lblSDT2.Location = new System.Drawing.Point(862, 60);
            this.lblSDT2.Name = "lblSDT2";
            this.lblSDT2.Size = new System.Drawing.Size(229, 20);
            this.lblSDT2.TabIndex = 7;
            this.lblSDT2.Text = "Số điện thoại 2 (Không bắt buộc)";
            // 
            // txtSoDienThoai2
            // 
            this.txtSoDienThoai2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDienThoai2.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSoDienThoai2.BorderRadius = 5;
            this.txtSoDienThoai2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai2.DefaultText = "";
            this.txtSoDienThoai2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDienThoai2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai2.Location = new System.Drawing.Point(865, 80);
            this.txtSoDienThoai2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai2.Name = "txtSoDienThoai2";
            this.txtSoDienThoai2.PlaceholderText = "";
            this.txtSoDienThoai2.SelectedText = "";
            this.txtSoDienThoai2.Size = new System.Drawing.Size(239, 36);
            this.txtSoDienThoai2.TabIndex = 8;
            // 
            // lblTenHienThi
            // 
            this.lblTenHienThi.AutoSize = true;
            this.lblTenHienThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenHienThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenHienThi.Location = new System.Drawing.Point(22, 130);
            this.lblTenHienThi.Name = "lblTenHienThi";
            this.lblTenHienThi.Size = new System.Drawing.Size(85, 20);
            this.lblTenHienThi.TabIndex = 9;
            this.lblTenHienThi.Text = "Tên hiển thị";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTenHienThi.BorderRadius = 5;
            this.txtTenHienThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHienThi.DefaultText = "192- Nguyen Trai";
            this.txtTenHienThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHienThi.Location = new System.Drawing.Point(25, 150);
            this.txtTenHienThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.PlaceholderText = "";
            this.txtTenHienThi.SelectedText = "";
            this.txtTenHienThi.Size = new System.Drawing.Size(250, 36);
            this.txtTenHienThi.TabIndex = 10;
            // 
            // lblWifi
            // 
            this.lblWifi.AutoSize = true;
            this.lblWifi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWifi.ForeColor = System.Drawing.Color.Gray;
            this.lblWifi.Location = new System.Drawing.Point(302, 130);
            this.lblWifi.Name = "lblWifi";
            this.lblWifi.Size = new System.Drawing.Size(218, 20);
            this.lblWifi.TabIndex = 11;
            this.lblWifi.Text = "Mật khẩu wifi (Không bắt buộc)";
            // 
            // txtWifiPassword
            // 
            this.txtWifiPassword.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtWifiPassword.BorderRadius = 5;
            this.txtWifiPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWifiPassword.DefaultText = "";
            this.txtWifiPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWifiPassword.Location = new System.Drawing.Point(305, 150);
            this.txtWifiPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWifiPassword.Name = "txtWifiPassword";
            this.txtWifiPassword.PlaceholderText = "";
            this.txtWifiPassword.SelectedText = "";
            this.txtWifiPassword.Size = new System.Drawing.Size(250, 36);
            this.txtWifiPassword.TabIndex = 12;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiaChi.Location = new System.Drawing.Point(22, 200);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(118, 20);
            this.lblDiaChi.TabIndex = 13;
            this.lblDiaChi.Text = "Địa chỉ đặt hàng";
            // 
            // txtDiaChiDatHang
            // 
            this.txtDiaChiDatHang.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDiaChiDatHang.BorderRadius = 5;
            this.txtDiaChiDatHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiDatHang.DefaultText = "160 Khuất Duy Tiến, Thanh Xuan Trung, Thanh Xuân, Hà Noi";
            this.txtDiaChiDatHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChiDatHang.Location = new System.Drawing.Point(25, 220);
            this.txtDiaChiDatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChiDatHang.Multiline = true;
            this.txtDiaChiDatHang.Name = "txtDiaChiDatHang";
            this.txtDiaChiDatHang.PlaceholderText = "";
            this.txtDiaChiDatHang.SelectedText = "";
            this.txtDiaChiDatHang.Size = new System.Drawing.Size(250, 80);
            this.txtDiaChiDatHang.TabIndex = 14;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.Gray;
            this.lblMoTa.Location = new System.Drawing.Point(302, 200);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(168, 20);
            this.lblMoTa.TabIndex = 15;
            this.lblMoTa.Text = "Mô tả (Không bắt buộc)";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMoTa.BorderRadius = 5;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(305, 220);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(250, 80);
            this.txtMoTa.TabIndex = 16;
            // 
            // chkCauHinhGio
            // 
            this.chkCauHinhGio.AutoSize = true;
            this.chkCauHinhGio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCauHinhGio.CheckedState.BorderRadius = 2;
            this.chkCauHinhGio.CheckedState.BorderThickness = 0;
            this.chkCauHinhGio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCauHinhGio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCauHinhGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkCauHinhGio.Location = new System.Drawing.Point(585, 320);
            this.chkCauHinhGio.Name = "chkCauHinhGio";
            this.chkCauHinhGio.Size = new System.Drawing.Size(279, 24);
            this.chkCauHinhGio.TabIndex = 18;
            this.chkCauHinhGio.Text = "Cấu hình giờ hoạt động của cửa hàng";
            this.chkCauHinhGio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkCauHinhGio.UncheckedState.BorderRadius = 0;
            this.chkCauHinhGio.UncheckedState.BorderThickness = 0;
            // 
            // lblGioHoatDong
            // 
            this.lblGioHoatDong.AutoSize = true;
            this.lblGioHoatDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGioHoatDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGioHoatDong.Location = new System.Drawing.Point(582, 355);
            this.lblGioHoatDong.Name = "lblGioHoatDong";
            this.lblGioHoatDong.Size = new System.Drawing.Size(126, 23);
            this.lblGioHoatDong.TabIndex = 19;
            this.lblGioHoatDong.Text = "Giờ hoạt động";
            // 
            // rbApDungTatCaNgay
            // 
            this.rbApDungTatCaNgay.AutoSize = true;
            this.rbApDungTatCaNgay.Checked = true;
            this.rbApDungTatCaNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbApDungTatCaNgay.CheckedState.BorderThickness = 0;
            this.rbApDungTatCaNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbApDungTatCaNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbApDungTatCaNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbApDungTatCaNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbApDungTatCaNgay.Location = new System.Drawing.Point(585, 385);
            this.rbApDungTatCaNgay.Name = "rbApDungTatCaNgay";
            this.rbApDungTatCaNgay.Size = new System.Drawing.Size(190, 24);
            this.rbApDungTatCaNgay.TabIndex = 20;
            this.rbApDungTatCaNgay.TabStop = true;
            this.rbApDungTatCaNgay.Text = "Áp dụng tất cả các ngày";
            this.rbApDungTatCaNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbApDungTatCaNgay.UncheckedState.BorderThickness = 0;
            // 
            // rbCauHinhTungNgay
            // 
            this.rbCauHinhTungNgay.AutoSize = true;
            this.rbCauHinhTungNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCauHinhTungNgay.CheckedState.BorderThickness = 0;
            this.rbCauHinhTungNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCauHinhTungNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbCauHinhTungNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbCauHinhTungNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbCauHinhTungNgay.Location = new System.Drawing.Point(740, 385);
            this.rbCauHinhTungNgay.Name = "rbCauHinhTungNgay";
            this.rbCauHinhTungNgay.Size = new System.Drawing.Size(259, 24);
            this.rbCauHinhTungNgay.TabIndex = 21;
            this.rbCauHinhTungNgay.Text = "Cấu hình cho từng ngày trong tuần";
            this.rbCauHinhTungNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbCauHinhTungNgay.UncheckedState.BorderThickness = 0;
            // 
            // tsTatCaNgay
            // 
            this.tsTatCaNgay.Checked = true;
            this.tsTatCaNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTatCaNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTatCaNgay.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsTatCaNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsTatCaNgay.Location = new System.Drawing.Point(585, 420);
            this.tsTatCaNgay.Name = "tsTatCaNgay";
            this.tsTatCaNgay.Size = new System.Drawing.Size(35, 20);
            this.tsTatCaNgay.TabIndex = 22;
            this.tsTatCaNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(630, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tất cả ngày trong tuần";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTu.Location = new System.Drawing.Point(862, 423);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(26, 20);
            this.lblTu.TabIndex = 24;
            this.lblTu.Text = "Từ";
            // 
            // txtGioMoCua
            // 
            this.txtGioMoCua.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtGioMoCua.BorderRadius = 5;
            this.txtGioMoCua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioMoCua.DefaultText = "00 : 00";
            this.txtGioMoCua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGioMoCua.Location = new System.Drawing.Point(895, 415);
            this.txtGioMoCua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioMoCua.Name = "txtGioMoCua";
            this.txtGioMoCua.PlaceholderText = "";
            this.txtGioMoCua.SelectedText = "";
            this.txtGioMoCua.Size = new System.Drawing.Size(70, 30);
            this.txtGioMoCua.TabIndex = 25;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDen.Location = new System.Drawing.Point(975, 423);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(36, 20);
            this.lblDen.TabIndex = 26;
            this.lblDen.Text = "Đến";
            // 
            // txtGioDongCua
            // 
            this.txtGioDongCua.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtGioDongCua.BorderRadius = 5;
            this.txtGioDongCua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioDongCua.DefaultText = "00 : 01";
            this.txtGioDongCua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGioDongCua.Location = new System.Drawing.Point(1010, 415);
            this.txtGioDongCua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioDongCua.Name = "txtGioDongCua";
            this.txtGioDongCua.PlaceholderText = "";
            this.txtGioDongCua.SelectedText = "";
            this.txtGioDongCua.Size = new System.Drawing.Size(70, 30);
            this.txtGioDongCua.TabIndex = 27;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(994, 575);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 40);
            this.btnLuu.TabIndex = 29;
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
            this.btnHuy.Location = new System.Drawing.Point(874, 575);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 40);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            // 
            // webViewMap
            // 
            this.webViewMap.AllowExternalDrop = true;
            this.webViewMap.CreationProperties = null;
            this.webViewMap.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewMap.Location = new System.Drawing.Point(26, 321);
            this.webViewMap.Name = "webViewMap";
            this.webViewMap.Size = new System.Drawing.Size(529, 284);
            this.webViewMap.TabIndex = 30;
            this.webViewMap.ZoomFactor = 1D;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cmbTrangThai.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbTrangThai.BorderRadius = 5;
            this.cmbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTrangThai.ItemHeight = 30;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "Hồ Chí Minh"});
            this.cmbTrangThai.Location = new System.Drawing.Point(586, 150);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(250, 36);
            this.cmbTrangThai.StartIndex = 0;
            this.cmbTrangThai.TabIndex = 32;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTrangThai.Location = new System.Drawing.Point(583, 130);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(75, 20);
            this.lblTrangThai.TabIndex = 31;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKhuVuc.Location = new System.Drawing.Point(863, 130);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(61, 20);
            this.lblKhuVuc.TabIndex = 35;
            this.lblKhuVuc.Text = "Khu vực";
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhuVuc.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtKhuVuc.BorderRadius = 5;
            this.txtKhuVuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhuVuc.DefaultText = "";
            this.txtKhuVuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKhuVuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKhuVuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuVuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuVuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKhuVuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuVuc.Location = new System.Drawing.Point(865, 150);
            this.txtKhuVuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.PlaceholderText = "";
            this.txtKhuVuc.SelectedText = "";
            this.txtKhuVuc.Size = new System.Drawing.Size(239, 36);
            this.txtKhuVuc.TabIndex = 36;
            // 
            // FormSuaChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtKhuVuc);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.webViewMap);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGioDongCua);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.txtGioMoCua);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tsTatCaNgay);
            this.Controls.Add(this.rbCauHinhTungNgay);
            this.Controls.Add(this.rbApDungTatCaNgay);
            this.Controls.Add(this.lblGioHoatDong);
            this.Controls.Add(this.chkCauHinhGio);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtDiaChiDatHang);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtWifiPassword);
            this.Controls.Add(this.lblWifi);
            this.Controls.Add(this.txtTenHienThi);
            this.Controls.Add(this.lblTenHienThi);
            this.Controls.Add(this.txtSoDienThoai2);
            this.Controls.Add(this.lblSDT2);
            this.Controls.Add(this.txtSoDienThoai1);
            this.Controls.Add(this.lblSDT1);
            this.Controls.Add(this.cboThanhPho);
            this.Controls.Add(this.lblThanhPho);
            this.Controls.Add(this.cboQuocGia);
            this.Controls.Add(this.lblQuocGia);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSuaChiNhanh";
            this.Size = new System.Drawing.Size(1129, 630);
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuocGia;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuocGia;
        private System.Windows.Forms.Label lblThanhPho;
        private Guna.UI2.WinForms.Guna2ComboBox cboThanhPho;
        private System.Windows.Forms.Label lblSDT1;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai1;
        private System.Windows.Forms.Label lblSDT2;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai2;
        private System.Windows.Forms.Label lblTenHienThi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHienThi;
        private System.Windows.Forms.Label lblWifi;
        private Guna.UI2.WinForms.Guna2TextBox txtWifiPassword;
        private System.Windows.Forms.Label lblDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiDatHang;
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2CheckBox chkCauHinhGio;
        private System.Windows.Forms.Label lblGioHoatDong;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungTatCaNgay;
        private Guna.UI2.WinForms.Guna2RadioButton rbCauHinhTungNgay;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTatCaNgay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTu;
        private Guna.UI2.WinForms.Guna2TextBox txtGioMoCua;
        private System.Windows.Forms.Label lblDen;
        private Guna.UI2.WinForms.Guna2TextBox txtGioDongCua;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
        private Guna2ComboBox cmbTrangThai;
        private Label lblTrangThai;
        private Label lblKhuVuc;
        private Guna2TextBox txtKhuVuc;
    }
}