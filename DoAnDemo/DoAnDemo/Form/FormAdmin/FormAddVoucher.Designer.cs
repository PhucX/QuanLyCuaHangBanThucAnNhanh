// FormAddVoucher.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormAddVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblThongTinCoBan = new System.Windows.Forms.Label();
            this.lblGioiHanDichVu = new System.Windows.Forms.Label();
            this.lblTenVoucher = new System.Windows.Forms.Label();
            this.txtTenVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaVoucher = new System.Windows.Forms.Label();
            this.txtMaVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkSuDungMotMa = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiaTriVoucher = new System.Windows.Forms.Label();
            this.txtGiaTriVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGiamGiaPercent = new Guna.UI2.WinForms.Guna2Button();
            this.btnGiamGiaVND = new Guna.UI2.WinForms.Guna2Button();
            this.lblTienGiamToiDa = new System.Windows.Forms.Label();
            this.txtTienGiamToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDisplayThoiGian = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAnhVoucher = new System.Windows.Forms.Label();
            this.txtAnhVoucherPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowseAnh = new Guna.UI2.WinForms.Guna2Button();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbApDungAllCH = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbApDungMotSoCH = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblSoLanSuDung = new System.Windows.Forms.Label();
            this.txtSoLanSuDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKhongGioiHan = new Guna.UI2.WinForms.Guna2Button();
            this.btnGioiHanSoLan = new Guna.UI2.WinForms.Guna2Button();
            this.chkGiaTriToiThieu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkSoLuongMonToiDa = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtDiemCanThiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLuuYChiDinh = new System.Windows.Forms.Label();
            this.dgvCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCatSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGiamGiaTrenDM = new System.Windows.Forms.Label();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colProdSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCacSanPham = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.rbApDungDanhMuc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbApDungSanPham = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbApDungCaHai = new Guna.UI2.WinForms.Guna2RadioButton();
            this.chkDiemCanThiet = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TẠO MỚI VOUCHER";
            // 
            // lblThongTinCoBan
            // 
            this.lblThongTinCoBan.AutoSize = true;
            this.lblThongTinCoBan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTinCoBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblThongTinCoBan.Location = new System.Drawing.Point(21, 55);
            this.lblThongTinCoBan.Name = "lblThongTinCoBan";
            this.lblThongTinCoBan.Size = new System.Drawing.Size(164, 25);
            this.lblThongTinCoBan.TabIndex = 1;
            this.lblThongTinCoBan.Text = "Thông tin cơ bản";
            // 
            // lblGioiHanDichVu
            // 
            this.lblGioiHanDichVu.AutoSize = true;
            this.lblGioiHanDichVu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGioiHanDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGioiHanDichVu.Location = new System.Drawing.Point(576, 55);
            this.lblGioiHanDichVu.Name = "lblGioiHanDichVu";
            this.lblGioiHanDichVu.Size = new System.Drawing.Size(235, 25);
            this.lblGioiHanDichVu.TabIndex = 21;
            this.lblGioiHanDichVu.Text = "Giới hạn dịch vụ áp dụng";
            // 
            // lblTenVoucher
            // 
            this.lblTenVoucher.AutoSize = true;
            this.lblTenVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenVoucher.Location = new System.Drawing.Point(22, 90);
            this.lblTenVoucher.Name = "lblTenVoucher";
            this.lblTenVoucher.Size = new System.Drawing.Size(89, 20);
            this.lblTenVoucher.TabIndex = 2;
            this.lblTenVoucher.Text = "Tên Voucher";
            // 
            // txtTenVoucher
            // 
            this.txtTenVoucher.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTenVoucher.BorderRadius = 5;
            this.txtTenVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenVoucher.DefaultText = "";
            this.txtTenVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenVoucher.Location = new System.Drawing.Point(25, 110);
            this.txtTenVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenVoucher.Name = "txtTenVoucher";
            this.txtTenVoucher.PlaceholderText = "Nhập tên";
            this.txtTenVoucher.SelectedText = "";
            this.txtTenVoucher.Size = new System.Drawing.Size(510, 36);
            this.txtTenVoucher.TabIndex = 3;
            // 
            // lblMaVoucher
            // 
            this.lblMaVoucher.AutoSize = true;
            this.lblMaVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaVoucher.ForeColor = System.Drawing.Color.Gray;
            this.lblMaVoucher.Location = new System.Drawing.Point(22, 161);
            this.lblMaVoucher.Name = "lblMaVoucher";
            this.lblMaVoucher.Size = new System.Drawing.Size(206, 20);
            this.lblMaVoucher.TabIndex = 4;
            this.lblMaVoucher.Text = "Mã voucher (Không bắt buộc)";
            // 
            // txtMaVoucher
            // 
            this.txtMaVoucher.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMaVoucher.BorderRadius = 5;
            this.txtMaVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVoucher.DefaultText = "";
            this.txtMaVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaVoucher.Location = new System.Drawing.Point(25, 181);
            this.txtMaVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaVoucher.Name = "txtMaVoucher";
            this.txtMaVoucher.PlaceholderText = "NHẬP MÃ";
            this.txtMaVoucher.SelectedText = "";
            this.txtMaVoucher.Size = new System.Drawing.Size(250, 36);
            this.txtMaVoucher.TabIndex = 5;
            // 
            // chkSuDungMotMa
            // 
            this.chkSuDungMotMa.AutoSize = true;
            this.chkSuDungMotMa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSuDungMotMa.CheckedState.BorderRadius = 0;
            this.chkSuDungMotMa.CheckedState.BorderThickness = 0;
            this.chkSuDungMotMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkSuDungMotMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkSuDungMotMa.Location = new System.Drawing.Point(25, 222);
            this.chkSuDungMotMa.Name = "chkSuDungMotMa";
            this.chkSuDungMotMa.Size = new System.Drawing.Size(267, 24);
            this.chkSuDungMotMa.TabIndex = 6;
            this.chkSuDungMotMa.Text = "Sử dụng một mã cho tất cả voucher";
            this.chkSuDungMotMa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSuDungMotMa.UncheckedState.BorderRadius = 0;
            this.chkSuDungMotMa.UncheckedState.BorderThickness = 0;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLuong.ForeColor = System.Drawing.Color.Gray;
            this.lblSoLuong.Location = new System.Drawing.Point(302, 161);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(189, 20);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng (Không bắt buộc)";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSoLuong.BorderRadius = 5;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "1000";
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(305, 181);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(230, 36);
            this.txtSoLuong.TabIndex = 8;
            // 
            // lblGiaTriVoucher
            // 
            this.lblGiaTriVoucher.AutoSize = true;
            this.lblGiaTriVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiaTriVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiaTriVoucher.Location = new System.Drawing.Point(22, 256);
            this.lblGiaTriVoucher.Name = "lblGiaTriVoucher";
            this.lblGiaTriVoucher.Size = new System.Drawing.Size(105, 20);
            this.lblGiaTriVoucher.TabIndex = 9;
            this.lblGiaTriVoucher.Text = "Giá trị voucher";
            // 
            // txtGiaTriVoucher
            // 
            this.txtGiaTriVoucher.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtGiaTriVoucher.BorderRadius = 5;
            this.txtGiaTriVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTriVoucher.DefaultText = "";
            this.txtGiaTriVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaTriVoucher.Location = new System.Drawing.Point(25, 276);
            this.txtGiaTriVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTriVoucher.Name = "txtGiaTriVoucher";
            this.txtGiaTriVoucher.PlaceholderText = "Nhập %";
            this.txtGiaTriVoucher.SelectedText = "";
            this.txtGiaTriVoucher.Size = new System.Drawing.Size(150, 36);
            this.txtGiaTriVoucher.TabIndex = 10;
            // 
            // btnGiamGiaPercent
            // 
            this.btnGiamGiaPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGiamGiaPercent.Checked = true;
            this.btnGiamGiaPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGiamGiaPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiamGiaPercent.ForeColor = System.Drawing.Color.White;
            this.btnGiamGiaPercent.Location = new System.Drawing.Point(181, 276);
            this.btnGiamGiaPercent.Name = "btnGiamGiaPercent";
            this.btnGiamGiaPercent.Size = new System.Drawing.Size(50, 36);
            this.btnGiamGiaPercent.TabIndex = 11;
            this.btnGiamGiaPercent.Text = "%";
            // 
            // btnGiamGiaVND
            // 
            this.btnGiamGiaVND.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGiamGiaVND.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGiamGiaVND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiamGiaVND.ForeColor = System.Drawing.Color.Gray;
            this.btnGiamGiaVND.Location = new System.Drawing.Point(237, 276);
            this.btnGiamGiaVND.Name = "btnGiamGiaVND";
            this.btnGiamGiaVND.Size = new System.Drawing.Size(60, 36);
            this.btnGiamGiaVND.TabIndex = 12;
            this.btnGiamGiaVND.Text = "VND";
            // 
            // lblTienGiamToiDa
            // 
            this.lblTienGiamToiDa.AutoSize = true;
            this.lblTienGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienGiamToiDa.ForeColor = System.Drawing.Color.Gray;
            this.lblTienGiamToiDa.Location = new System.Drawing.Point(302, 256);
            this.lblTienGiamToiDa.Name = "lblTienGiamToiDa";
            this.lblTienGiamToiDa.Size = new System.Drawing.Size(256, 20);
            this.lblTienGiamToiDa.TabIndex = 13;
            this.lblTienGiamToiDa.Text = "Số tiền giảm tối đa (Không bắt buộc)";
            // 
            // txtTienGiamToiDa
            // 
            this.txtTienGiamToiDa.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTienGiamToiDa.BorderRadius = 5;
            this.txtTienGiamToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienGiamToiDa.DefaultText = "0";
            this.txtTienGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienGiamToiDa.Location = new System.Drawing.Point(305, 276);
            this.txtTienGiamToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienGiamToiDa.Name = "txtTienGiamToiDa";
            this.txtTienGiamToiDa.PlaceholderText = "";
            this.txtTienGiamToiDa.SelectedText = "";
            this.txtTienGiamToiDa.Size = new System.Drawing.Size(230, 36);
            this.txtTienGiamToiDa.TabIndex = 14;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayBatDau.Location = new System.Drawing.Point(22, 326);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(99, 20);
            this.lblNgayBatDau.TabIndex = 15;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpNgayBatDau.BorderRadius = 5;
            this.dtpNgayBatDau.Checked = true;
            this.dtpNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(25, 346);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(250, 36);
            this.dtpNgayBatDau.TabIndex = 16;
            this.dtpNgayBatDau.Value = new System.DateTime(2020, 10, 29, 0, 0, 0, 0);
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayKetThuc.ForeColor = System.Drawing.Color.Gray;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(302, 326);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(220, 20);
            this.lblNgayKetThuc.TabIndex = 17;
            this.lblNgayKetThuc.Text = "Ngày kết thúc (Không bắt buộc)";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpNgayKetThuc.BorderRadius = 5;
            this.dtpNgayKetThuc.Checked = true;
            this.dtpNgayKetThuc.FillColor = System.Drawing.Color.White;
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(305, 346);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.ShowCheckBox = true;
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(230, 36);
            this.dtpNgayKetThuc.TabIndex = 18;
            this.dtpNgayKetThuc.Value = new System.DateTime(2025, 4, 11, 18, 59, 21, 377);
            // 
            // txtDisplayThoiGian
            // 
            this.txtDisplayThoiGian.BorderRadius = 5;
            this.txtDisplayThoiGian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplayThoiGian.DefaultText = "Có thể sử dụng từ: 29/10/2020 00:00:00 ~ Thời hạn sử dụng đến: Có thể sử dụng khô" +
    "ng thời hạn";
            this.txtDisplayThoiGian.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtDisplayThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDisplayThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisplayThoiGian.Location = new System.Drawing.Point(25, 388);
            this.txtDisplayThoiGian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDisplayThoiGian.Name = "txtDisplayThoiGian";
            this.txtDisplayThoiGian.PlaceholderText = "";
            this.txtDisplayThoiGian.ReadOnly = true;
            this.txtDisplayThoiGian.SelectedText = "";
            this.txtDisplayThoiGian.Size = new System.Drawing.Size(510, 50);
            this.txtDisplayThoiGian.TabIndex = 19;
            this.txtDisplayThoiGian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnhVoucher
            // 
            this.lblAnhVoucher.AutoSize = true;
            this.lblAnhVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAnhVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAnhVoucher.Location = new System.Drawing.Point(22, 450);
            this.lblAnhVoucher.Name = "lblAnhVoucher";
            this.lblAnhVoucher.Size = new System.Drawing.Size(92, 20);
            this.lblAnhVoucher.TabIndex = 20;
            this.lblAnhVoucher.Text = "Ảnh Voucher";
            // 
            // txtAnhVoucherPath
            // 
            this.txtAnhVoucherPath.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtAnhVoucherPath.BorderRadius = 5;
            this.txtAnhVoucherPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnhVoucherPath.DefaultText = "";
            this.txtAnhVoucherPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnhVoucherPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAnhVoucherPath.Location = new System.Drawing.Point(25, 470);
            this.txtAnhVoucherPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnhVoucherPath.Name = "txtAnhVoucherPath";
            this.txtAnhVoucherPath.PlaceholderText = "Choose file";
            this.txtAnhVoucherPath.ReadOnly = true;
            this.txtAnhVoucherPath.SelectedText = "";
            this.txtAnhVoucherPath.Size = new System.Drawing.Size(400, 36);
            this.txtAnhVoucherPath.TabIndex = 21;
            // 
            // btnBrowseAnh
            // 
            this.btnBrowseAnh.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBrowseAnh.BorderRadius = 5;
            this.btnBrowseAnh.BorderThickness = 1;
            this.btnBrowseAnh.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowseAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseAnh.Location = new System.Drawing.Point(435, 470);
            this.btnBrowseAnh.Name = "btnBrowseAnh";
            this.btnBrowseAnh.Size = new System.Drawing.Size(100, 36);
            this.btnBrowseAnh.TabIndex = 22;
            this.btnBrowseAnh.Text = "Browse";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMoTa.Location = new System.Drawing.Point(22, 518);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(48, 20);
            this.lblMoTa.TabIndex = 23;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMoTa.BorderRadius = 5;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMoTa.Location = new System.Drawing.Point(25, 538);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(510, 70);
            this.txtMoTa.TabIndex = 24;
            // 
            // rbApDungAllCH
            // 
            this.rbApDungAllCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbApDungAllCH.AutoSize = true;
            this.rbApDungAllCH.Checked = true;
            this.rbApDungAllCH.CheckedState.BorderThickness = 0;
            this.rbApDungAllCH.Location = new System.Drawing.Point(578, 90);
            this.rbApDungAllCH.Name = "rbApDungAllCH";
            this.rbApDungAllCH.Size = new System.Drawing.Size(207, 23);
            this.rbApDungAllCH.TabIndex = 22;
            this.rbApDungAllCH.TabStop = true;
            this.rbApDungAllCH.Text = "Áp dụng cho tất cả cửa hàng";
            this.rbApDungAllCH.UncheckedState.BorderThickness = 0;
            // 
            // rbApDungMotSoCH
            // 
            this.rbApDungMotSoCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbApDungMotSoCH.AutoSize = true;
            this.rbApDungMotSoCH.CheckedState.BorderThickness = 0;
            this.rbApDungMotSoCH.Location = new System.Drawing.Point(802, 90);
            this.rbApDungMotSoCH.Name = "rbApDungMotSoCH";
            this.rbApDungMotSoCH.Size = new System.Drawing.Size(203, 23);
            this.rbApDungMotSoCH.TabIndex = 23;
            this.rbApDungMotSoCH.Text = "Áp dụng cho 1 số chi nhánh";
            this.rbApDungMotSoCH.UncheckedState.BorderThickness = 0;
            // 
            // lblSoLanSuDung
            // 
            this.lblSoLanSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLanSuDung.AutoSize = true;
            this.lblSoLanSuDung.Location = new System.Drawing.Point(577, 125);
            this.lblSoLanSuDung.Name = "lblSoLanSuDung";
            this.lblSoLanSuDung.Size = new System.Drawing.Size(263, 19);
            this.lblSoLanSuDung.TabIndex = 24;
            this.lblSoLanSuDung.Text = "Số lần sử dụng tối đa cho một thành viên";
            // 
            // txtSoLanSuDung
            // 
            this.txtSoLanSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLanSuDung.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSoLanSuDung.BorderRadius = 5;
            this.txtSoLanSuDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLanSuDung.DefaultText = "";
            this.txtSoLanSuDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLanSuDung.Location = new System.Drawing.Point(580, 145);
            this.txtSoLanSuDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLanSuDung.Name = "txtSoLanSuDung";
            this.txtSoLanSuDung.PlaceholderText = "";
            this.txtSoLanSuDung.SelectedText = "";
            this.txtSoLanSuDung.Size = new System.Drawing.Size(250, 36);
            this.txtSoLanSuDung.TabIndex = 25;
            // 
            // btnKhongGioiHan
            // 
            this.btnKhongGioiHan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhongGioiHan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnKhongGioiHan.Checked = true;
            this.btnKhongGioiHan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnKhongGioiHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhongGioiHan.ForeColor = System.Drawing.Color.White;
            this.btnKhongGioiHan.Location = new System.Drawing.Point(840, 145);
            this.btnKhongGioiHan.Name = "btnKhongGioiHan";
            this.btnKhongGioiHan.Size = new System.Drawing.Size(110, 36);
            this.btnKhongGioiHan.TabIndex = 26;
            this.btnKhongGioiHan.Text = "Không giới hạn";
            // 
            // btnGioiHanSoLan
            // 
            this.btnGioiHanSoLan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGioiHanSoLan.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGioiHanSoLan.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGioiHanSoLan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGioiHanSoLan.ForeColor = System.Drawing.Color.Gray;
            this.btnGioiHanSoLan.Location = new System.Drawing.Point(955, 145);
            this.btnGioiHanSoLan.Name = "btnGioiHanSoLan";
            this.btnGioiHanSoLan.Size = new System.Drawing.Size(110, 36);
            this.btnGioiHanSoLan.TabIndex = 27;
            this.btnGioiHanSoLan.Text = "Giới hạn (Số lần)";
            // 
            // chkGiaTriToiThieu
            // 
            this.chkGiaTriToiThieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGiaTriToiThieu.AutoSize = true;
            this.chkGiaTriToiThieu.CheckedState.BorderRadius = 0;
            this.chkGiaTriToiThieu.CheckedState.BorderThickness = 0;
            this.chkGiaTriToiThieu.Location = new System.Drawing.Point(580, 195);
            this.chkGiaTriToiThieu.Name = "chkGiaTriToiThieu";
            this.chkGiaTriToiThieu.Size = new System.Drawing.Size(104, 24);
            this.chkGiaTriToiThieu.TabIndex = 28;
            this.chkGiaTriToiThieu.Text = "Giá trị hoá đơn tối thiểu";
            this.chkGiaTriToiThieu.UncheckedState.BorderRadius = 0;
            this.chkGiaTriToiThieu.UncheckedState.BorderThickness = 0;
            // 
            // chkSoLuongMonToiDa
            // 
            this.chkSoLuongMonToiDa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSoLuongMonToiDa.AutoSize = true;
            this.chkSoLuongMonToiDa.CheckedState.BorderRadius = 0;
            this.chkSoLuongMonToiDa.CheckedState.BorderThickness = 0;
            this.chkSoLuongMonToiDa.Location = new System.Drawing.Point(580, 220);
            this.chkSoLuongMonToiDa.Name = "chkSoLuongMonToiDa";
            this.chkSoLuongMonToiDa.Size = new System.Drawing.Size(104, 24);
            this.chkSoLuongMonToiDa.TabIndex = 29;
            this.chkSoLuongMonToiDa.Text = "Số lượng món ăn tối đa được áp dụng";
            this.chkSoLuongMonToiDa.UncheckedState.BorderRadius = 0;
            this.chkSoLuongMonToiDa.UncheckedState.BorderThickness = 0;
            // 
            // txtDiemCanThiet
            // 
            this.txtDiemCanThiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiemCanThiet.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDiemCanThiet.BorderRadius = 5;
            this.txtDiemCanThiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemCanThiet.DefaultText = "0";
            this.txtDiemCanThiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemCanThiet.Location = new System.Drawing.Point(581, 222);
            this.txtDiemCanThiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemCanThiet.Name = "txtDiemCanThiet";
            this.txtDiemCanThiet.PlaceholderText = "";
            this.txtDiemCanThiet.SelectedText = "";
            this.txtDiemCanThiet.Size = new System.Drawing.Size(475, 36);
            this.txtDiemCanThiet.TabIndex = 31;
            // 
            // lblLuuYChiDinh
            // 
            this.lblLuuYChiDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLuuYChiDinh.AutoSize = true;
            this.lblLuuYChiDinh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblLuuYChiDinh.ForeColor = System.Drawing.Color.Gray;
            this.lblLuuYChiDinh.Location = new System.Drawing.Point(572, 287);
            this.lblLuuYChiDinh.Name = "lblLuuYChiDinh";
            this.lblLuuYChiDinh.Size = new System.Drawing.Size(501, 19);
            this.lblLuuYChiDinh.TabIndex = 35;
            this.lblLuuYChiDinh.Text = "*Voucher này sẽ chỉ áp dụng được trên những danh mục hoặc món ăn đã chọn";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategories.ColumnHeadersHeight = 22;
            this.dgvCategories.ColumnHeadersVisible = false;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCatSelect,
            this.colCatName});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategories.Location = new System.Drawing.Point(578, 326);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(475, 120);
            this.dgvCategories.TabIndex = 37;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategories.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvCategories.ThemeStyle.ReadOnly = false;
            this.dgvCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategories.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCatSelect
            // 
            this.colCatSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCatSelect.FillWeight = 40F;
            this.colCatSelect.HeaderText = "";
            this.colCatSelect.MinimumWidth = 40;
            this.colCatSelect.Name = "colCatSelect";
            this.colCatSelect.Width = 40;
            // 
            // colCatName
            // 
            this.colCatName.HeaderText = "Tên danh mục";
            this.colCatName.MinimumWidth = 6;
            this.colCatName.Name = "colCatName";
            // 
            // lblGiamGiaTrenDM
            // 
            this.lblGiamGiaTrenDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiamGiaTrenDM.AutoSize = true;
            this.lblGiamGiaTrenDM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiamGiaTrenDM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiamGiaTrenDM.Location = new System.Drawing.Point(575, 306);
            this.lblGiamGiaTrenDM.Name = "lblGiamGiaTrenDM";
            this.lblGiamGiaTrenDM.Size = new System.Drawing.Size(168, 20);
            this.lblGiamGiaTrenDM.TabIndex = 36;
            this.lblGiamGiaTrenDM.Text = "Giảm giá trên danh mục";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProducts.ColumnHeadersHeight = 22;
            this.dgvProducts.ColumnHeadersVisible = false;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdSelect,
            this.colProdName});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(578, 476);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(475, 118);
            this.dgvProducts.TabIndex = 39;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvProducts.ThemeStyle.ReadOnly = false;
            this.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducts.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colProdSelect
            // 
            this.colProdSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProdSelect.FillWeight = 40F;
            this.colProdSelect.HeaderText = "";
            this.colProdSelect.MinimumWidth = 40;
            this.colProdSelect.Name = "colProdSelect";
            this.colProdSelect.Width = 40;
            // 
            // colProdName
            // 
            this.colProdName.FillWeight = 200F;
            this.colProdName.HeaderText = "Tên Sản Phẩm";
            this.colProdName.MinimumWidth = 6;
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            // 
            // lblCacSanPham
            // 
            this.lblCacSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCacSanPham.AutoSize = true;
            this.lblCacSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCacSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCacSanPham.Location = new System.Drawing.Point(575, 456);
            this.lblCacSanPham.Name = "lblCacSanPham";
            this.lblCacSanPham.Size = new System.Drawing.Size(101, 20);
            this.lblCacSanPham.TabIndex = 38;
            this.lblCacSanPham.Text = "Các sản phẩm";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(895, 630);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 40);
            this.btnLuu.TabIndex = 42;
            // 
            // rbApDungDanhMuc
            // 
            this.rbApDungDanhMuc.AutoSize = true;
            this.rbApDungDanhMuc.Checked = true;
            this.rbApDungDanhMuc.CheckedState.BorderThickness = 0;
            this.rbApDungDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbApDungDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbApDungDanhMuc.Location = new System.Drawing.Point(25, 620);
            this.rbApDungDanhMuc.Name = "rbApDungDanhMuc";
            this.rbApDungDanhMuc.Size = new System.Drawing.Size(156, 24);
            this.rbApDungDanhMuc.TabIndex = 25;
            this.rbApDungDanhMuc.TabStop = true;
            this.rbApDungDanhMuc.Text = "Áp dụng danh mục";
            this.rbApDungDanhMuc.UncheckedState.BorderThickness = 0;
            // 
            // rbApDungSanPham
            // 
            this.rbApDungSanPham.AutoSize = true;
            this.rbApDungSanPham.CheckedState.BorderThickness = 0;
            this.rbApDungSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbApDungSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbApDungSanPham.Location = new System.Drawing.Point(180, 620);
            this.rbApDungSanPham.Name = "rbApDungSanPham";
            this.rbApDungSanPham.Size = new System.Drawing.Size(155, 24);
            this.rbApDungSanPham.TabIndex = 26;
            this.rbApDungSanPham.Text = "Áp dụng sản phẩm";
            this.rbApDungSanPham.UncheckedState.BorderThickness = 0;
            // 
            // rbApDungCaHai
            // 
            this.rbApDungCaHai.AutoSize = true;
            this.rbApDungCaHai.CheckedState.BorderThickness = 0;
            this.rbApDungCaHai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbApDungCaHai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbApDungCaHai.Location = new System.Drawing.Point(320, 620);
            this.rbApDungCaHai.Name = "rbApDungCaHai";
            this.rbApDungCaHai.Size = new System.Drawing.Size(130, 24);
            this.rbApDungCaHai.TabIndex = 27;
            this.rbApDungCaHai.Text = "Áp dụng cả hai";
            this.rbApDungCaHai.UncheckedState.BorderThickness = 0;
            // 
            // chkDiemCanThiet
            // 
            this.chkDiemCanThiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDiemCanThiet.AutoSize = true;
            this.chkDiemCanThiet.Checked = true;
            this.chkDiemCanThiet.CheckedState.BorderRadius = 0;
            this.chkDiemCanThiet.CheckedState.BorderThickness = 0;
            this.chkDiemCanThiet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiemCanThiet.Location = new System.Drawing.Point(581, 194);
            this.chkDiemCanThiet.Name = "chkDiemCanThiet";
            this.chkDiemCanThiet.Size = new System.Drawing.Size(232, 23);
            this.chkDiemCanThiet.TabIndex = 30;
            this.chkDiemCanThiet.Text = "Số điểm cần thiết để đổi voucher";
            this.chkDiemCanThiet.UncheckedState.BorderRadius = 0;
            this.chkDiemCanThiet.UncheckedState.BorderThickness = 0;
            // 
            // FormAddVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblCacSanPham);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.lblGiamGiaTrenDM);
            this.Controls.Add(this.lblLuuYChiDinh);
            this.Controls.Add(this.txtDiemCanThiet);
            this.Controls.Add(this.chkDiemCanThiet);
            this.Controls.Add(this.btnGioiHanSoLan);
            this.Controls.Add(this.btnKhongGioiHan);
            this.Controls.Add(this.txtSoLanSuDung);
            this.Controls.Add(this.lblSoLanSuDung);
            this.Controls.Add(this.rbApDungMotSoCH);
            this.Controls.Add(this.rbApDungAllCH);
            this.Controls.Add(this.rbApDungCaHai);
            this.Controls.Add(this.rbApDungSanPham);
            this.Controls.Add(this.rbApDungDanhMuc);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.btnBrowseAnh);
            this.Controls.Add(this.txtAnhVoucherPath);
            this.Controls.Add(this.lblAnhVoucher);
            this.Controls.Add(this.txtDisplayThoiGian);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.txtTienGiamToiDa);
            this.Controls.Add(this.lblTienGiamToiDa);
            this.Controls.Add(this.btnGiamGiaVND);
            this.Controls.Add(this.btnGiamGiaPercent);
            this.Controls.Add(this.txtGiaTriVoucher);
            this.Controls.Add(this.lblGiaTriVoucher);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.chkSuDungMotMa);
            this.Controls.Add(this.txtMaVoucher);
            this.Controls.Add(this.lblMaVoucher);
            this.Controls.Add(this.txtTenVoucher);
            this.Controls.Add(this.lblTenVoucher);
            this.Controls.Add(this.lblGioiHanDichVu);
            this.Controls.Add(this.lblThongTinCoBan);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAddVoucher";
            this.Size = new System.Drawing.Size(1080, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThongTinCoBan;
        private System.Windows.Forms.Label lblGioiHanDichVu;
        private System.Windows.Forms.Label lblTenVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtTenVoucher;
        private System.Windows.Forms.Label lblMaVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtMaVoucher;
        private Guna.UI2.WinForms.Guna2CheckBox chkSuDungMotMa;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiaTriVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaTriVoucher;
        private Guna.UI2.WinForms.Guna2Button btnGiamGiaPercent;
        private Guna.UI2.WinForms.Guna2Button btnGiamGiaVND;
        private System.Windows.Forms.Label lblTienGiamToiDa;
        private Guna.UI2.WinForms.Guna2TextBox txtTienGiamToiDa;
        private System.Windows.Forms.Label lblNgayBatDau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKetThuc;
        private Guna.UI2.WinForms.Guna2TextBox txtDisplayThoiGian;
        private System.Windows.Forms.Label lblAnhVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtAnhVoucherPath;
        private Guna.UI2.WinForms.Guna2Button btnBrowseAnh;
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungAllCH;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungMotSoCH;
        private System.Windows.Forms.Label lblSoLanSuDung;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLanSuDung;
        private Guna.UI2.WinForms.Guna2Button btnKhongGioiHan;
        private Guna.UI2.WinForms.Guna2Button btnGioiHanSoLan;
        private Guna.UI2.WinForms.Guna2CheckBox chkGiaTriToiThieu;
        private Guna.UI2.WinForms.Guna2CheckBox chkSoLuongMonToiDa;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemCanThiet;
        private System.Windows.Forms.Label lblLuuYChiDinh;
        private System.Windows.Forms.Label lblGiamGiaTrenDM;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategories;
        private System.Windows.Forms.Label lblCacSanPham;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungDanhMuc;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungSanPham;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungCaHai;
        private Guna2CheckBox chkDiemCanThiet;
        private DataGridViewCheckBoxColumn colProdSelect;
        private DataGridViewTextBoxColumn colProdName;
        private DataGridViewCheckBoxColumn colCatSelect;
        private DataGridViewTextBoxColumn colCatName;
    }
}