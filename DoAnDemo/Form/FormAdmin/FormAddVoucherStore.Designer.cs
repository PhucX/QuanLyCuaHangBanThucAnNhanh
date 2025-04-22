// FormAddVoucherStore.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormAddVoucherStore
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddVoucherStore));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCuaHang = new System.Windows.Forms.Label();
            this.fpnlCuaHang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDropdownCuaHang = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenChuongTrinh = new System.Windows.Forms.Label();
            this.txtTenChuongTrinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiaTriGiamGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGiaTriGiamGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGiamGiaPercent = new Guna.UI2.WinForms.Guna2Button();
            this.btnGiamGiaVND = new Guna.UI2.WinForms.Guna2Button();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkGiaTriToiThieu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkApDungKhachHang = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblSoTienGiamToiDa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoTienGiamToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ckoApDungCuaHang = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtGiaTriToiThieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colProdSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCacSanPham = new System.Windows.Forms.Label();
            this.dgvCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCatSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGiamGiaTrenDM = new System.Windows.Forms.Label();
            this.rbApDungSanPham = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbApDungDanhMuc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtMaVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAnhVoucherPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDisplayThoiGian = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkSuDungMotMa = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnKhongGioiHan = new Guna.UI2.WinForms.Guna2Button();
            this.btnGioiHanSoLan = new Guna.UI2.WinForms.Guna2Button();
            this.chkDiemCanThiet = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtDiemCanThiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLanSuDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSanPhamMienPhi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnMienPhiSanPham = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(474, 39);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "TẠO MỚI CHƯƠNG TRÌNH GIẢM GIÁ";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuaHang
            // 
            this.lblCuaHang.AutoSize = true;
            this.lblCuaHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuaHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCuaHang.Location = new System.Drawing.Point(22, 54);
            this.lblCuaHang.Name = "lblCuaHang";
            this.lblCuaHang.Size = new System.Drawing.Size(72, 20);
            this.lblCuaHang.TabIndex = 1;
            this.lblCuaHang.Text = "Cửa hàng";
            // 
            // fpnlCuaHang
            // 
            this.fpnlCuaHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlCuaHang.AutoScroll = true;
            this.fpnlCuaHang.BackColor = System.Drawing.Color.White;
            this.fpnlCuaHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlCuaHang.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlCuaHang.Location = new System.Drawing.Point(25, 74);
            this.fpnlCuaHang.Name = "fpnlCuaHang";
            this.fpnlCuaHang.Padding = new System.Windows.Forms.Padding(3);
            this.fpnlCuaHang.Size = new System.Drawing.Size(990, 36);
            this.fpnlCuaHang.TabIndex = 2;
            // 
            // btnDropdownCuaHang
            // 
            this.btnDropdownCuaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropdownCuaHang.BackColor = System.Drawing.Color.White;
            this.btnDropdownCuaHang.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDropdownCuaHang.BorderRadius = 5;
            this.btnDropdownCuaHang.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDropdownCuaHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDropdownCuaHang.ForeColor = System.Drawing.Color.Gray;
            this.btnDropdownCuaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDropdownCuaHang.Image")));
            this.btnDropdownCuaHang.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDropdownCuaHang.Location = new System.Drawing.Point(1015, 74);
            this.btnDropdownCuaHang.Name = "btnDropdownCuaHang";
            this.btnDropdownCuaHang.Size = new System.Drawing.Size(35, 36);
            this.btnDropdownCuaHang.TabIndex = 3;
            // 
            // lblTenChuongTrinh
            // 
            this.lblTenChuongTrinh.AutoSize = true;
            this.lblTenChuongTrinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenChuongTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenChuongTrinh.Location = new System.Drawing.Point(22, 130);
            this.lblTenChuongTrinh.Name = "lblTenChuongTrinh";
            this.lblTenChuongTrinh.Size = new System.Drawing.Size(183, 20);
            this.lblTenChuongTrinh.TabIndex = 4;
            this.lblTenChuongTrinh.Text = "Tên chương trình giảm giá";
            // 
            // txtTenChuongTrinh
            // 
            this.txtTenChuongTrinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenChuongTrinh.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTenChuongTrinh.BorderRadius = 5;
            this.txtTenChuongTrinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChuongTrinh.DefaultText = "";
            this.txtTenChuongTrinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenChuongTrinh.Location = new System.Drawing.Point(25, 150);
            this.txtTenChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenChuongTrinh.Name = "txtTenChuongTrinh";
            this.txtTenChuongTrinh.PlaceholderText = "Nhập tên";
            this.txtTenChuongTrinh.SelectedText = "";
            this.txtTenChuongTrinh.Size = new System.Drawing.Size(600, 36);
            this.txtTenChuongTrinh.TabIndex = 5;
            // 
            // lblGiaTriGiamGia
            // 
            this.lblGiaTriGiamGia.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaTriGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiaTriGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiaTriGiamGia.Location = new System.Drawing.Point(22, 200);
            this.lblGiaTriGiamGia.Name = "lblGiaTriGiamGia";
            this.lblGiaTriGiamGia.Size = new System.Drawing.Size(106, 22);
            this.lblGiaTriGiamGia.TabIndex = 6;
            this.lblGiaTriGiamGia.Text = "Giá trị giảm giá";
            // 
            // txtGiaTriGiamGia
            // 
            this.txtGiaTriGiamGia.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtGiaTriGiamGia.BorderRadius = 5;
            this.txtGiaTriGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTriGiamGia.DefaultText = "";
            this.txtGiaTriGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaTriGiamGia.Location = new System.Drawing.Point(25, 220);
            this.txtGiaTriGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTriGiamGia.Name = "txtGiaTriGiamGia";
            this.txtGiaTriGiamGia.PlaceholderText = "Nhập %";
            this.txtGiaTriGiamGia.SelectedText = "";
            this.txtGiaTriGiamGia.Size = new System.Drawing.Size(150, 36);
            this.txtGiaTriGiamGia.TabIndex = 7;
            // 
            // btnGiamGiaPercent
            // 
            this.btnGiamGiaPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGiamGiaPercent.Checked = true;
            this.btnGiamGiaPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGiamGiaPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiamGiaPercent.ForeColor = System.Drawing.Color.White;
            this.btnGiamGiaPercent.Location = new System.Drawing.Point(181, 220);
            this.btnGiamGiaPercent.Name = "btnGiamGiaPercent";
            this.btnGiamGiaPercent.Size = new System.Drawing.Size(50, 36);
            this.btnGiamGiaPercent.TabIndex = 8;
            this.btnGiamGiaPercent.Text = "%";
            // 
            // btnGiamGiaVND
            // 
            this.btnGiamGiaVND.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGiamGiaVND.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGiamGiaVND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiamGiaVND.ForeColor = System.Drawing.Color.Gray;
            this.btnGiamGiaVND.Location = new System.Drawing.Point(237, 220);
            this.btnGiamGiaVND.Name = "btnGiamGiaVND";
            this.btnGiamGiaVND.Size = new System.Drawing.Size(60, 36);
            this.btnGiamGiaVND.TabIndex = 9;
            this.btnGiamGiaVND.Text = "VND";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayBatDau.Location = new System.Drawing.Point(22, 270);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(99, 20);
            this.lblNgayBatDau.TabIndex = 10;
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
            this.dtpNgayBatDau.Location = new System.Drawing.Point(25, 290);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(272, 36);
            this.dtpNgayBatDau.TabIndex = 11;
            this.dtpNgayBatDau.Value = new System.DateTime(2020, 10, 29, 0, 0, 0, 0);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMoTa.Location = new System.Drawing.Point(18, 527);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(48, 20);
            this.lblMoTa.TabIndex = 12;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMoTa.BorderRadius = 5;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(21, 547);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "Nhập mô tả";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(474, 100);
            this.txtMoTa.TabIndex = 13;
            // 
            // chkGiaTriToiThieu
            // 
            this.chkGiaTriToiThieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGiaTriToiThieu.AutoSize = true;
            this.chkGiaTriToiThieu.CheckedState.BorderRadius = 0;
            this.chkGiaTriToiThieu.CheckedState.BorderThickness = 0;
            this.chkGiaTriToiThieu.Location = new System.Drawing.Point(669, 130);
            this.chkGiaTriToiThieu.Name = "chkGiaTriToiThieu";
            this.chkGiaTriToiThieu.Size = new System.Drawing.Size(178, 23);
            this.chkGiaTriToiThieu.TabIndex = 14;
            this.chkGiaTriToiThieu.Text = "Giá trị hoá đơn tối thiểu";
            this.chkGiaTriToiThieu.UncheckedState.BorderRadius = 0;
            this.chkGiaTriToiThieu.UncheckedState.BorderThickness = 0;
            // 
            // chkApDungKhachHang
            // 
            this.chkApDungKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApDungKhachHang.AutoSize = true;
            this.chkApDungKhachHang.CheckedState.BorderRadius = 0;
            this.chkApDungKhachHang.CheckedState.BorderThickness = 0;
            this.chkApDungKhachHang.Location = new System.Drawing.Point(668, 249);
            this.chkApDungKhachHang.Name = "chkApDungKhachHang";
            this.chkApDungKhachHang.Size = new System.Drawing.Size(179, 23);
            this.chkApDungKhachHang.TabIndex = 15;
            this.chkApDungKhachHang.Text = "Áp dụng cho thành viên";
            this.chkApDungKhachHang.UncheckedState.BorderRadius = 0;
            this.chkApDungKhachHang.UncheckedState.BorderThickness = 0;
            // 
            // lblSoTienGiamToiDa
            // 
            this.lblSoTienGiamToiDa.BackColor = System.Drawing.Color.Transparent;
            this.lblSoTienGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTienGiamToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoTienGiamToiDa.Location = new System.Drawing.Point(315, 200);
            this.lblSoTienGiamToiDa.Name = "lblSoTienGiamToiDa";
            this.lblSoTienGiamToiDa.Size = new System.Drawing.Size(250, 22);
            this.lblSoTienGiamToiDa.TabIndex = 16;
            this.lblSoTienGiamToiDa.Text = "Số tiền giảm tối đa (Không bắt buộc)";
            // 
            // txtSoTienGiamToiDa
            // 
            this.txtSoTienGiamToiDa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienGiamToiDa.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSoTienGiamToiDa.BorderRadius = 5;
            this.txtSoTienGiamToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTienGiamToiDa.DefaultText = "";
            this.txtSoTienGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoTienGiamToiDa.Location = new System.Drawing.Point(319, 220);
            this.txtSoTienGiamToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTienGiamToiDa.Name = "txtSoTienGiamToiDa";
            this.txtSoTienGiamToiDa.PlaceholderText = "";
            this.txtSoTienGiamToiDa.SelectedText = "";
            this.txtSoTienGiamToiDa.Size = new System.Drawing.Size(306, 36);
            this.txtSoTienGiamToiDa.TabIndex = 17;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(315, 270);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(205, 19);
            this.lblNgayKetThuc.TabIndex = 18;
            this.lblNgayKetThuc.Text = "Ngày kết thúc (Không bắt buộc)";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayKetThuc.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpNgayKetThuc.BorderRadius = 5;
            this.dtpNgayKetThuc.Checked = true;
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(319, 290);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.ShowCheckBox = true;
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(306, 36);
            this.dtpNgayKetThuc.TabIndex = 19;
            this.dtpNgayKetThuc.Value = new System.DateTime(2025, 4, 12, 12, 20, 27, 99);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLuu.Location = new System.Drawing.Point(940, 559);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 40);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "✔ Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLuu.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(816, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Hủy";
            // 
            // ckoApDungCuaHang
            // 
            this.ckoApDungCuaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckoApDungCuaHang.AutoSize = true;
            this.ckoApDungCuaHang.CheckedState.BorderRadius = 0;
            this.ckoApDungCuaHang.CheckedState.BorderThickness = 0;
            this.ckoApDungCuaHang.Location = new System.Drawing.Point(669, 220);
            this.ckoApDungCuaHang.Name = "ckoApDungCuaHang";
            this.ckoApDungCuaHang.Size = new System.Drawing.Size(170, 23);
            this.ckoApDungCuaHang.TabIndex = 22;
            this.ckoApDungCuaHang.Text = "Áp dụng cho cửa hàng";
            this.ckoApDungCuaHang.UncheckedState.BorderRadius = 0;
            this.ckoApDungCuaHang.UncheckedState.BorderThickness = 0;
            // 
            // txtGiaTriToiThieu
            // 
            this.txtGiaTriToiThieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaTriToiThieu.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtGiaTriToiThieu.BorderRadius = 5;
            this.txtGiaTriToiThieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTriToiThieu.DefaultText = "";
            this.txtGiaTriToiThieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaTriToiThieu.Location = new System.Drawing.Point(669, 160);
            this.txtGiaTriToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTriToiThieu.Name = "txtGiaTriToiThieu";
            this.txtGiaTriToiThieu.PlaceholderText = "";
            this.txtGiaTriToiThieu.SelectedText = "";
            this.txtGiaTriToiThieu.Size = new System.Drawing.Size(306, 36);
            this.txtGiaTriToiThieu.TabIndex = 23;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 22;
            this.dgvProducts.ColumnHeadersVisible = false;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdSelect,
            this.colProdName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(575, 396);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(475, 120);
            this.dgvProducts.TabIndex = 43;
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
            this.lblCacSanPham.Location = new System.Drawing.Point(572, 376);
            this.lblCacSanPham.Name = "lblCacSanPham";
            this.lblCacSanPham.Size = new System.Drawing.Size(101, 20);
            this.lblCacSanPham.TabIndex = 42;
            this.lblCacSanPham.Text = "Các sản phẩm";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategories.ColumnHeadersHeight = 22;
            this.dgvCategories.ColumnHeadersVisible = false;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCatSelect,
            this.colCatName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategories.Location = new System.Drawing.Point(20, 396);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(475, 120);
            this.dgvCategories.TabIndex = 41;
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
            this.dgvCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblGiamGiaTrenDM.Location = new System.Drawing.Point(17, 376);
            this.lblGiamGiaTrenDM.Name = "lblGiamGiaTrenDM";
            this.lblGiamGiaTrenDM.Size = new System.Drawing.Size(168, 20);
            this.lblGiamGiaTrenDM.TabIndex = 40;
            this.lblGiamGiaTrenDM.Text = "Giảm giá trên danh mục";
            // 
            // rbApDungSanPham
            // 
            this.rbApDungSanPham.AutoSize = true;
            this.rbApDungSanPham.CheckedState.BorderThickness = 0;
            this.rbApDungSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbApDungSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbApDungSanPham.Location = new System.Drawing.Point(392, 344);
            this.rbApDungSanPham.Name = "rbApDungSanPham";
            this.rbApDungSanPham.Size = new System.Drawing.Size(155, 24);
            this.rbApDungSanPham.TabIndex = 45;
            this.rbApDungSanPham.Text = "Áp dụng sản phẩm";
            this.rbApDungSanPham.UncheckedState.BorderThickness = 0;
            // 
            // rbApDungDanhMuc
            // 
            this.rbApDungDanhMuc.AutoSize = true;
            this.rbApDungDanhMuc.Checked = true;
            this.rbApDungDanhMuc.CheckedState.BorderThickness = 0;
            this.rbApDungDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbApDungDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbApDungDanhMuc.Location = new System.Drawing.Point(237, 344);
            this.rbApDungDanhMuc.Name = "rbApDungDanhMuc";
            this.rbApDungDanhMuc.Size = new System.Drawing.Size(156, 24);
            this.rbApDungDanhMuc.TabIndex = 44;
            this.rbApDungDanhMuc.TabStop = true;
            this.rbApDungDanhMuc.Text = "Áp dụng danh mục";
            this.rbApDungDanhMuc.UncheckedState.BorderThickness = 0;
            // 
            // txtMaVoucher
            // 
            this.txtMaVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVoucher.DefaultText = "";
            this.txtMaVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaVoucher.Location = new System.Drawing.Point(0, 0);
            this.txtMaVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaVoucher.Name = "txtMaVoucher";
            this.txtMaVoucher.PlaceholderText = "";
            this.txtMaVoucher.SelectedText = "";
            this.txtMaVoucher.Size = new System.Drawing.Size(229, 48);
            this.txtMaVoucher.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(0, 0);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(229, 48);
            this.txtSoLuong.TabIndex = 0;
            // 
            // txtAnhVoucherPath
            // 
            this.txtAnhVoucherPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnhVoucherPath.DefaultText = "";
            this.txtAnhVoucherPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnhVoucherPath.Location = new System.Drawing.Point(0, 0);
            this.txtAnhVoucherPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnhVoucherPath.Name = "txtAnhVoucherPath";
            this.txtAnhVoucherPath.PlaceholderText = "";
            this.txtAnhVoucherPath.SelectedText = "";
            this.txtAnhVoucherPath.Size = new System.Drawing.Size(229, 48);
            this.txtAnhVoucherPath.TabIndex = 0;
            // 
            // txtDisplayThoiGian
            // 
            this.txtDisplayThoiGian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplayThoiGian.DefaultText = "";
            this.txtDisplayThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDisplayThoiGian.Location = new System.Drawing.Point(0, 0);
            this.txtDisplayThoiGian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDisplayThoiGian.Name = "txtDisplayThoiGian";
            this.txtDisplayThoiGian.PlaceholderText = "";
            this.txtDisplayThoiGian.SelectedText = "";
            this.txtDisplayThoiGian.Size = new System.Drawing.Size(229, 48);
            this.txtDisplayThoiGian.TabIndex = 0;
            // 
            // chkSuDungMotMa
            // 
            this.chkSuDungMotMa.CheckedState.BorderRadius = 0;
            this.chkSuDungMotMa.CheckedState.BorderThickness = 0;
            this.chkSuDungMotMa.Location = new System.Drawing.Point(0, 0);
            this.chkSuDungMotMa.Name = "chkSuDungMotMa";
            this.chkSuDungMotMa.Size = new System.Drawing.Size(104, 24);
            this.chkSuDungMotMa.TabIndex = 0;
            this.chkSuDungMotMa.UncheckedState.BorderRadius = 0;
            this.chkSuDungMotMa.UncheckedState.BorderThickness = 0;
            // 
            // btnKhongGioiHan
            // 
            this.btnKhongGioiHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhongGioiHan.ForeColor = System.Drawing.Color.White;
            this.btnKhongGioiHan.Location = new System.Drawing.Point(0, 0);
            this.btnKhongGioiHan.Name = "btnKhongGioiHan";
            this.btnKhongGioiHan.Size = new System.Drawing.Size(180, 45);
            this.btnKhongGioiHan.TabIndex = 0;
            // 
            // btnGioiHanSoLan
            // 
            this.btnGioiHanSoLan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGioiHanSoLan.ForeColor = System.Drawing.Color.White;
            this.btnGioiHanSoLan.Location = new System.Drawing.Point(0, 0);
            this.btnGioiHanSoLan.Name = "btnGioiHanSoLan";
            this.btnGioiHanSoLan.Size = new System.Drawing.Size(180, 45);
            this.btnGioiHanSoLan.TabIndex = 0;
            // 
            // chkDiemCanThiet
            // 
            this.chkDiemCanThiet.CheckedState.BorderRadius = 0;
            this.chkDiemCanThiet.CheckedState.BorderThickness = 0;
            this.chkDiemCanThiet.Location = new System.Drawing.Point(0, 0);
            this.chkDiemCanThiet.Name = "chkDiemCanThiet";
            this.chkDiemCanThiet.Size = new System.Drawing.Size(104, 24);
            this.chkDiemCanThiet.TabIndex = 0;
            this.chkDiemCanThiet.UncheckedState.BorderRadius = 0;
            this.chkDiemCanThiet.UncheckedState.BorderThickness = 0;
            // 
            // txtDiemCanThiet
            // 
            this.txtDiemCanThiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemCanThiet.DefaultText = "";
            this.txtDiemCanThiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemCanThiet.Location = new System.Drawing.Point(0, 0);
            this.txtDiemCanThiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemCanThiet.Name = "txtDiemCanThiet";
            this.txtDiemCanThiet.PlaceholderText = "";
            this.txtDiemCanThiet.SelectedText = "";
            this.txtDiemCanThiet.Size = new System.Drawing.Size(229, 48);
            this.txtDiemCanThiet.TabIndex = 0;
            // 
            // txtSoLanSuDung
            // 
            this.txtSoLanSuDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLanSuDung.DefaultText = "";
            this.txtSoLanSuDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLanSuDung.Location = new System.Drawing.Point(0, 0);
            this.txtSoLanSuDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLanSuDung.Name = "txtSoLanSuDung";
            this.txtSoLanSuDung.PlaceholderText = "";
            this.txtSoLanSuDung.SelectedText = "";
            this.txtSoLanSuDung.Size = new System.Drawing.Size(229, 48);
            this.txtSoLanSuDung.TabIndex = 0;
            // 
            // cmbSanPhamMienPhi
            // 
            this.cmbSanPhamMienPhi.BackColor = System.Drawing.Color.Transparent;
            this.cmbSanPhamMienPhi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSanPhamMienPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanPhamMienPhi.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSanPhamMienPhi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSanPhamMienPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSanPhamMienPhi.ItemHeight = 30;
            this.cmbSanPhamMienPhi.Location = new System.Drawing.Point(0, 0);
            this.cmbSanPhamMienPhi.Name = "cmbSanPhamMienPhi";
            this.cmbSanPhamMienPhi.Size = new System.Drawing.Size(140, 36);
            this.cmbSanPhamMienPhi.TabIndex = 0;
            // 
            // btnMienPhiSanPham
            // 
            this.btnMienPhiSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMienPhiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnMienPhiSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnMienPhiSanPham.Name = "btnMienPhiSanPham";
            this.btnMienPhiSanPham.Size = new System.Drawing.Size(180, 45);
            this.btnMienPhiSanPham.TabIndex = 0;
            // 
            // FormAddVoucherStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbApDungSanPham);
            this.Controls.Add(this.rbApDungDanhMuc);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblCacSanPham);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.lblGiamGiaTrenDM);
            this.Controls.Add(this.txtGiaTriToiThieu);
            this.Controls.Add(this.ckoApDungCuaHang);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.txtSoTienGiamToiDa);
            this.Controls.Add(this.lblSoTienGiamToiDa);
            this.Controls.Add(this.chkApDungKhachHang);
            this.Controls.Add(this.chkGiaTriToiThieu);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.btnGiamGiaVND);
            this.Controls.Add(this.btnGiamGiaPercent);
            this.Controls.Add(this.txtGiaTriGiamGia);
            this.Controls.Add(this.lblGiaTriGiamGia);
            this.Controls.Add(this.txtTenChuongTrinh);
            this.Controls.Add(this.lblTenChuongTrinh);
            this.Controls.Add(this.btnDropdownCuaHang);
            this.Controls.Add(this.fpnlCuaHang);
            this.Controls.Add(this.lblCuaHang);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAddVoucherStore";
            this.Size = new System.Drawing.Size(1080, 662);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private System.Windows.Forms.Label lblCuaHang;
        private System.Windows.Forms.FlowLayoutPanel fpnlCuaHang;
        private Guna.UI2.WinForms.Guna2Button btnDropdownCuaHang;
        private System.Windows.Forms.Label lblTenChuongTrinh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenChuongTrinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGiaTriGiamGia;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaTriGiamGia;
        private Guna.UI2.WinForms.Guna2Button btnGiamGiaPercent;
        private Guna.UI2.WinForms.Guna2Button btnGiamGiaVND;
        private System.Windows.Forms.Label lblNgayBatDau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2CheckBox chkGiaTriToiThieu;
        private Guna.UI2.WinForms.Guna2CheckBox chkApDungKhachHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoTienGiamToiDa;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTienGiamToiDa;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKetThuc;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2CheckBox ckoApDungCuaHang;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaTriToiThieu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProdSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.Label lblCacSanPham;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCatSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatName;
        private System.Windows.Forms.Label lblGiamGiaTrenDM;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungSanPham;
        private Guna.UI2.WinForms.Guna2RadioButton rbApDungDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox txtMaVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtAnhVoucherPath;
        private Guna.UI2.WinForms.Guna2TextBox txtDisplayThoiGian;
        private Guna.UI2.WinForms.Guna2CheckBox chkSuDungMotMa;
        private Guna.UI2.WinForms.Guna2Button btnKhongGioiHan;
        private Guna.UI2.WinForms.Guna2Button btnGioiHanSoLan;
        private Guna.UI2.WinForms.Guna2CheckBox chkDiemCanThiet;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemCanThiet;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLanSuDung;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSanPhamMienPhi;
        private Guna.UI2.WinForms.Guna2Button btnMienPhiSanPham;
    }
}