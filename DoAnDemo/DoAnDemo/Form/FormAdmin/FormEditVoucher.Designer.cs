// FormEditVoucher.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace DoAnDemo.Form.FormAdmin // Namespace giữ nguyên
{
    partial class FormEditVoucher // Class name giữ nguyên
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPreview = new Guna.UI2.WinForms.Guna2GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.grpLoaiGiamGia = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtGiaTriToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiaTriToiDa = new System.Windows.Forms.Label();
            this.lblGiaTriToiThieu = new System.Windows.Forms.Label();
            this.txtGiaTriToiThieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSanPhamMienPhi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSanPhamMienPhi = new System.Windows.Forms.Label();
            this.txtGiamToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiamToiDa = new System.Windows.Forms.Label();
            this.txtGiaTriGiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.radSanPhamMienPhi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoAmount = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoPercent = new Guna.UI2.WinForms.Guna2RadioButton();
            this.grpThoiGian = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkVoThoiHan = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dtpNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grpPhamVi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ckoMember = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtTimKiemCuaHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTimKiemCH = new System.Windows.Forms.Label();
            this.chkListCuaHang = new System.Windows.Forms.CheckedListBox();
            this.radTheoCuaHang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radToanChuoi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.grpDieuKien = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvDanhMuc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chkApDungSanPham = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkApDungDanhMuc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grpThongTinCoBan = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblValidationTenVoucher = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtMaVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaVoucher = new System.Windows.Forms.Label();
            this.txtTenVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenVoucher = new System.Windows.Forms.Label();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPreview = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlMainContent.SuspendLayout();
            this.grpLoaiGiamGia.SuspendLayout();
            this.grpThoiGian.SuspendLayout();
            this.grpPhamVi.SuspendLayout();
            this.grpDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.grpThongTinCoBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // grpPreview
            // 
            this.grpPreview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpPreview.Location = new System.Drawing.Point(0, 0);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(300, 200);
            this.grpPreview.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Sản phẩm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.Controls.Add(this.btnCancel);
            this.pnlMainContent.Controls.Add(this.grpLoaiGiamGia);
            this.pnlMainContent.Controls.Add(this.grpThoiGian);
            this.pnlMainContent.Controls.Add(this.guna2HtmlLabel1);
            this.pnlMainContent.Controls.Add(this.grpPhamVi);
            this.pnlMainContent.Controls.Add(this.btnSave);
            this.pnlMainContent.Controls.Add(this.btnRemove);
            this.pnlMainContent.Controls.Add(this.grpDieuKien);
            this.pnlMainContent.Controls.Add(this.grpThongTinCoBan);
            this.pnlMainContent.Controls.Add(this.lblTitle);
            this.pnlMainContent.Controls.Add(this.lblStatus);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(20, 20);
            this.pnlMainContent.MinimumSize = new System.Drawing.Size(1040, 800);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(1040, 800);
            this.pnlMainContent.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(787, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Hủy";
            // 
            // grpLoaiGiamGia
            // 
            this.grpLoaiGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoaiGiamGia.Controls.Add(this.txtGiaTriToiDa);
            this.grpLoaiGiamGia.Controls.Add(this.lblGiaTriToiDa);
            this.grpLoaiGiamGia.Controls.Add(this.lblGiaTriToiThieu);
            this.grpLoaiGiamGia.Controls.Add(this.txtGiaTriToiThieu);
            this.grpLoaiGiamGia.Controls.Add(this.cmbSanPhamMienPhi);
            this.grpLoaiGiamGia.Controls.Add(this.lblSanPhamMienPhi);
            this.grpLoaiGiamGia.Controls.Add(this.txtGiamToiDa);
            this.grpLoaiGiamGia.Controls.Add(this.lblGiamToiDa);
            this.grpLoaiGiamGia.Controls.Add(this.txtGiaTriGiam);
            this.grpLoaiGiamGia.Controls.Add(this.lblGiaTri);
            this.grpLoaiGiamGia.Controls.Add(this.radSanPhamMienPhi);
            this.grpLoaiGiamGia.Controls.Add(this.rdoAmount);
            this.grpLoaiGiamGia.Controls.Add(this.rdoPercent);
            this.grpLoaiGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpLoaiGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpLoaiGiamGia.Location = new System.Drawing.Point(3, 412);
            this.grpLoaiGiamGia.Name = "grpLoaiGiamGia";
            this.grpLoaiGiamGia.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.grpLoaiGiamGia.Size = new System.Drawing.Size(547, 277);
            this.grpLoaiGiamGia.TabIndex = 29;
            this.grpLoaiGiamGia.Text = "Loại giảm giá";
            this.grpLoaiGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiaTriToiDa
            // 
            this.txtGiaTriToiDa.BorderRadius = 5;
            this.txtGiaTriToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTriToiDa.DefaultText = "";
            this.txtGiaTriToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaTriToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaTriToiDa.Location = new System.Drawing.Point(218, 228);
            this.txtGiaTriToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTriToiDa.Name = "txtGiaTriToiDa";
            this.txtGiaTriToiDa.PlaceholderText = "";
            this.txtGiaTriToiDa.SelectedText = "";
            this.txtGiaTriToiDa.Size = new System.Drawing.Size(150, 30);
            this.txtGiaTriToiDa.TabIndex = 13;
            // 
            // lblGiaTriToiDa
            // 
            this.lblGiaTriToiDa.AutoSize = true;
            this.lblGiaTriToiDa.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaTriToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiaTriToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiaTriToiDa.Location = new System.Drawing.Point(20, 238);
            this.lblGiaTriToiDa.Name = "lblGiaTriToiDa";
            this.lblGiaTriToiDa.Size = new System.Drawing.Size(98, 20);
            this.lblGiaTriToiDa.TabIndex = 12;
            this.lblGiaTriToiDa.Text = "Giá trị tối đa*";
            // 
            // lblGiaTriToiThieu
            // 
            this.lblGiaTriToiThieu.AutoSize = true;
            this.lblGiaTriToiThieu.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaTriToiThieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiaTriToiThieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiaTriToiThieu.Location = new System.Drawing.Point(20, 197);
            this.lblGiaTriToiThieu.Name = "lblGiaTriToiThieu";
            this.lblGiaTriToiThieu.Size = new System.Drawing.Size(114, 20);
            this.lblGiaTriToiThieu.TabIndex = 11;
            this.lblGiaTriToiThieu.Text = "Giá trị tối thiểu*";
            // 
            // txtGiaTriToiThieu
            // 
            this.txtGiaTriToiThieu.BorderRadius = 5;
            this.txtGiaTriToiThieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTriToiThieu.DefaultText = "";
            this.txtGiaTriToiThieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaTriToiThieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaTriToiThieu.Location = new System.Drawing.Point(218, 191);
            this.txtGiaTriToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTriToiThieu.Name = "txtGiaTriToiThieu";
            this.txtGiaTriToiThieu.PlaceholderText = "";
            this.txtGiaTriToiThieu.SelectedText = "";
            this.txtGiaTriToiThieu.Size = new System.Drawing.Size(150, 30);
            this.txtGiaTriToiThieu.TabIndex = 10;
            // 
            // cmbSanPhamMienPhi
            // 
            this.cmbSanPhamMienPhi.BackColor = System.Drawing.Color.Transparent;
            this.cmbSanPhamMienPhi.BorderRadius = 5;
            this.cmbSanPhamMienPhi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSanPhamMienPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanPhamMienPhi.Enabled = false;
            this.cmbSanPhamMienPhi.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSanPhamMienPhi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSanPhamMienPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSanPhamMienPhi.ItemHeight = 30;
            this.cmbSanPhamMienPhi.Location = new System.Drawing.Point(218, 148);
            this.cmbSanPhamMienPhi.Name = "cmbSanPhamMienPhi";
            this.cmbSanPhamMienPhi.Size = new System.Drawing.Size(320, 36);
            this.cmbSanPhamMienPhi.TabIndex = 8;
            // 
            // lblSanPhamMienPhi
            // 
            this.lblSanPhamMienPhi.AutoSize = true;
            this.lblSanPhamMienPhi.BackColor = System.Drawing.Color.Transparent;
            this.lblSanPhamMienPhi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSanPhamMienPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSanPhamMienPhi.Location = new System.Drawing.Point(168, 125);
            this.lblSanPhamMienPhi.Name = "lblSanPhamMienPhi";
            this.lblSanPhamMienPhi.Size = new System.Drawing.Size(137, 20);
            this.lblSanPhamMienPhi.TabIndex = 7;
            this.lblSanPhamMienPhi.Text = "Sản phẩm miễn phí";
            // 
            // txtGiamToiDa
            // 
            this.txtGiamToiDa.BorderRadius = 5;
            this.txtGiamToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiamToiDa.DefaultText = "";
            this.txtGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiamToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiamToiDa.Location = new System.Drawing.Point(372, 95);
            this.txtGiamToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiamToiDa.Name = "txtGiamToiDa";
            this.txtGiamToiDa.PlaceholderText = "";
            this.txtGiamToiDa.SelectedText = "";
            this.txtGiamToiDa.Size = new System.Drawing.Size(150, 30);
            this.txtGiamToiDa.TabIndex = 6;
            // 
            // lblGiamToiDa
            // 
            this.lblGiamToiDa.AutoSize = true;
            this.lblGiamToiDa.BackColor = System.Drawing.Color.Transparent;
            this.lblGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiamToiDa.ForeColor = System.Drawing.Color.Gray;
            this.lblGiamToiDa.Location = new System.Drawing.Point(168, 95);
            this.lblGiamToiDa.Name = "lblGiamToiDa";
            this.lblGiamToiDa.Size = new System.Drawing.Size(151, 20);
            this.lblGiamToiDa.TabIndex = 5;
            this.lblGiamToiDa.Text = "Giảm tối đa (Tiền/SP)";
            // 
            // txtGiaTriGiam
            // 
            this.txtGiaTriGiam.BorderRadius = 5;
            this.txtGiaTriGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTriGiam.DefaultText = "";
            this.txtGiaTriGiam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaTriGiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaTriGiam.Location = new System.Drawing.Point(372, 63);
            this.txtGiaTriGiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTriGiam.Name = "txtGiaTriGiam";
            this.txtGiaTriGiam.PlaceholderText = "";
            this.txtGiaTriGiam.SelectedText = "";
            this.txtGiaTriGiam.Size = new System.Drawing.Size(150, 30);
            this.txtGiaTriGiam.TabIndex = 4;
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaTri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiaTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiaTri.Location = new System.Drawing.Point(168, 65);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(55, 20);
            this.lblGiaTri.TabIndex = 3;
            this.lblGiaTri.Text = "Giá trị*";
            // 
            // radSanPhamMienPhi
            // 
            this.radSanPhamMienPhi.AutoSize = true;
            this.radSanPhamMienPhi.BackColor = System.Drawing.Color.Transparent;
            this.radSanPhamMienPhi.CheckedState.BorderThickness = 0;
            this.radSanPhamMienPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radSanPhamMienPhi.Location = new System.Drawing.Point(11, 123);
            this.radSanPhamMienPhi.Name = "radSanPhamMienPhi";
            this.radSanPhamMienPhi.Size = new System.Drawing.Size(158, 24);
            this.radSanPhamMienPhi.TabIndex = 2;
            this.radSanPhamMienPhi.Text = "Sản phẩm miễn phí";
            this.radSanPhamMienPhi.UncheckedState.BorderThickness = 0;
            this.radSanPhamMienPhi.UseVisualStyleBackColor = false;
            // 
            // rdoAmount
            // 
            this.rdoAmount.AutoSize = true;
            this.rdoAmount.BackColor = System.Drawing.Color.Transparent;
            this.rdoAmount.CheckedState.BorderThickness = 0;
            this.rdoAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoAmount.Location = new System.Drawing.Point(11, 93);
            this.rdoAmount.Name = "rdoAmount";
            this.rdoAmount.Size = new System.Drawing.Size(129, 24);
            this.rdoAmount.TabIndex = 1;
            this.rdoAmount.Text = "Số tiền cố định";
            this.rdoAmount.UncheckedState.BorderThickness = 0;
            this.rdoAmount.UseVisualStyleBackColor = false;
            // 
            // rdoPercent
            // 
            this.rdoPercent.AutoSize = true;
            this.rdoPercent.BackColor = System.Drawing.Color.Transparent;
            this.rdoPercent.Checked = true;
            this.rdoPercent.CheckedState.BorderThickness = 0;
            this.rdoPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoPercent.Location = new System.Drawing.Point(11, 63);
            this.rdoPercent.Name = "rdoPercent";
            this.rdoPercent.Size = new System.Drawing.Size(123, 24);
            this.rdoPercent.TabIndex = 0;
            this.rdoPercent.TabStop = true;
            this.rdoPercent.Text = "Phần trăm (%)";
            this.rdoPercent.UncheckedState.BorderThickness = 0;
            this.rdoPercent.UseVisualStyleBackColor = false;
            // 
            // grpThoiGian
            // 
            this.grpThoiGian.Controls.Add(this.chkVoThoiHan);
            this.grpThoiGian.Controls.Add(this.dtpNgayKetThuc);
            this.grpThoiGian.Controls.Add(this.lblNgayKetThuc);
            this.grpThoiGian.Controls.Add(this.dtpNgayBatDau);
            this.grpThoiGian.Controls.Add(this.lblNgayBatDau);
            this.grpThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpThoiGian.Location = new System.Drawing.Point(3, 287);
            this.grpThoiGian.Name = "grpThoiGian";
            this.grpThoiGian.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.grpThoiGian.Size = new System.Drawing.Size(547, 115);
            this.grpThoiGian.TabIndex = 28;
            this.grpThoiGian.Text = "Thời gian áp dụng";
            this.grpThoiGian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkVoThoiHan
            // 
            this.chkVoThoiHan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVoThoiHan.AutoSize = true;
            this.chkVoThoiHan.BackColor = System.Drawing.Color.Transparent;
            this.chkVoThoiHan.CheckedState.BorderRadius = 0;
            this.chkVoThoiHan.CheckedState.BorderThickness = 0;
            this.chkVoThoiHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkVoThoiHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkVoThoiHan.Location = new System.Drawing.Point(267, 47);
            this.chkVoThoiHan.Name = "chkVoThoiHan";
            this.chkVoThoiHan.Size = new System.Drawing.Size(106, 24);
            this.chkVoThoiHan.TabIndex = 4;
            this.chkVoThoiHan.Text = "Vô thời hạn";
            this.chkVoThoiHan.UncheckedState.BorderRadius = 0;
            this.chkVoThoiHan.UncheckedState.BorderThickness = 0;
            this.chkVoThoiHan.UseVisualStyleBackColor = false;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayKetThuc.BorderRadius = 5;
            this.dtpNgayKetThuc.Checked = true;
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(284, 69);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.ShowUpDown = true;
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(250, 36);
            this.dtpNgayKetThuc.TabIndex = 3;
            this.dtpNgayKetThuc.Value = new System.DateTime(2025, 5, 12, 22, 18, 55, 568);
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(281, 47);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(100, 20);
            this.lblNgayKetThuc.TabIndex = 2;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.BorderRadius = 5;
            this.dtpNgayBatDau.Checked = true;
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(13, 69);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.ShowUpDown = true;
            this.dtpNgayBatDau.Size = new System.Drawing.Size(250, 36);
            this.dtpNgayBatDau.TabIndex = 1;
            this.dtpNgayBatDau.Value = new System.DateTime(2025, 4, 12, 22, 18, 55, 617);
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayBatDau.Location = new System.Drawing.Point(10, 47);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(114, 20);
            this.lblNgayBatDau.TabIndex = 0;
            this.lblNgayBatDau.Text = "Ngày bắt đầu *";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(341, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = null;
            this.guna2HtmlLabel1.Visible = false;
            // 
            // grpPhamVi
            // 
            this.grpPhamVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhamVi.Controls.Add(this.ckoMember);
            this.grpPhamVi.Controls.Add(this.txtTimKiemCuaHang);
            this.grpPhamVi.Controls.Add(this.lblTimKiemCH);
            this.grpPhamVi.Controls.Add(this.chkListCuaHang);
            this.grpPhamVi.Controls.Add(this.radTheoCuaHang);
            this.grpPhamVi.Controls.Add(this.radToanChuoi);
            this.grpPhamVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPhamVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpPhamVi.Location = new System.Drawing.Point(562, 58);
            this.grpPhamVi.Name = "grpPhamVi";
            this.grpPhamVi.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.grpPhamVi.Size = new System.Drawing.Size(466, 140);
            this.grpPhamVi.TabIndex = 31;
            this.grpPhamVi.Text = "Phạm vi áp dụng";
            this.grpPhamVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckoMember
            // 
            this.ckoMember.AutoSize = true;
            this.ckoMember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckoMember.CheckedState.BorderRadius = 0;
            this.ckoMember.CheckedState.BorderThickness = 0;
            this.ckoMember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckoMember.Location = new System.Drawing.Point(13, 110);
            this.ckoMember.Name = "ckoMember";
            this.ckoMember.Size = new System.Drawing.Size(160, 24);
            this.ckoMember.TabIndex = 5;
            this.ckoMember.Text = "Áp dụng thành viên";
            this.ckoMember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckoMember.UncheckedState.BorderRadius = 0;
            this.ckoMember.UncheckedState.BorderThickness = 0;
            this.ckoMember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtTimKiemCuaHang
            // 
            this.txtTimKiemCuaHang.BorderRadius = 3;
            this.txtTimKiemCuaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemCuaHang.DefaultText = "";
            this.txtTimKiemCuaHang.Enabled = false;
            this.txtTimKiemCuaHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemCuaHang.Location = new System.Drawing.Point(179, 61);
            this.txtTimKiemCuaHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemCuaHang.Name = "txtTimKiemCuaHang";
            this.txtTimKiemCuaHang.PlaceholderText = "Tìm cửa hàng...";
            this.txtTimKiemCuaHang.SelectedText = "";
            this.txtTimKiemCuaHang.Size = new System.Drawing.Size(279, 25);
            this.txtTimKiemCuaHang.TabIndex = 3;
            // 
            // lblTimKiemCH
            // 
            this.lblTimKiemCH.AutoSize = true;
            this.lblTimKiemCH.BackColor = System.Drawing.Color.Transparent;
            this.lblTimKiemCH.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTimKiemCH.ForeColor = System.Drawing.Color.Gray;
            this.lblTimKiemCH.Location = new System.Drawing.Point(176, 41);
            this.lblTimKiemCH.Name = "lblTimKiemCH";
            this.lblTimKiemCH.Size = new System.Drawing.Size(64, 19);
            this.lblTimKiemCH.TabIndex = 4;
            this.lblTimKiemCH.Text = "Tìm kiếm";
            // 
            // chkListCuaHang
            // 
            this.chkListCuaHang.CheckOnClick = true;
            this.chkListCuaHang.Enabled = false;
            this.chkListCuaHang.FormattingEnabled = true;
            this.chkListCuaHang.Location = new System.Drawing.Point(179, 91);
            this.chkListCuaHang.Name = "chkListCuaHang";
            this.chkListCuaHang.Size = new System.Drawing.Size(279, 26);
            this.chkListCuaHang.TabIndex = 2;
            // 
            // radTheoCuaHang
            // 
            this.radTheoCuaHang.AutoSize = true;
            this.radTheoCuaHang.BackColor = System.Drawing.Color.Transparent;
            this.radTheoCuaHang.CheckedState.BorderThickness = 0;
            this.radTheoCuaHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radTheoCuaHang.Location = new System.Drawing.Point(13, 70);
            this.radTheoCuaHang.Name = "radTheoCuaHang";
            this.radTheoCuaHang.Size = new System.Drawing.Size(128, 24);
            this.radTheoCuaHang.TabIndex = 1;
            this.radTheoCuaHang.Text = "Theo cửa hàng";
            this.radTheoCuaHang.UncheckedState.BorderThickness = 0;
            this.radTheoCuaHang.UseVisualStyleBackColor = false;
            // 
            // radToanChuoi
            // 
            this.radToanChuoi.AutoSize = true;
            this.radToanChuoi.BackColor = System.Drawing.Color.Transparent;
            this.radToanChuoi.Checked = true;
            this.radToanChuoi.CheckedState.BorderThickness = 0;
            this.radToanChuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radToanChuoi.Location = new System.Drawing.Point(13, 45);
            this.radToanChuoi.Name = "radToanChuoi";
            this.radToanChuoi.Size = new System.Drawing.Size(102, 24);
            this.radToanChuoi.TabIndex = 0;
            this.radToanChuoi.TabStop = true;
            this.radToanChuoi.Text = "Toàn chuỗi";
            this.radToanChuoi.UncheckedState.BorderThickness = 0;
            this.radToanChuoi.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(907, 609);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "✔ Lưu";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(667, 609);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 40);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Xóa";
            // 
            // grpDieuKien
            // 
            this.grpDieuKien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDieuKien.Controls.Add(this.dgvSanPham);
            this.grpDieuKien.Controls.Add(this.dgvDanhMuc);
            this.grpDieuKien.Controls.Add(this.chkApDungSanPham);
            this.grpDieuKien.Controls.Add(this.chkApDungDanhMuc);
            this.grpDieuKien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDieuKien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpDieuKien.Location = new System.Drawing.Point(562, 208);
            this.grpDieuKien.Name = "grpDieuKien";
            this.grpDieuKien.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.grpDieuKien.Size = new System.Drawing.Size(466, 385);
            this.grpDieuKien.TabIndex = 30;
            this.grpDieuKien.Text = "Điều kiện áp dụng";
            this.grpDieuKien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeight = 22;
            this.dgvSanPham.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.Location = new System.Drawing.Point(13, 230);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(440, 140);
            this.dgvSanPham.TabIndex = 3;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvSanPham.ThemeStyle.ReadOnly = false;
            this.dgvSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhMuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhMuc.ColumnHeadersHeight = 29;
            this.dgvDanhMuc.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.Location = new System.Drawing.Point(13, 65);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDanhMuc.ShowCellToolTips = false;
            this.dgvDanhMuc.ShowEditingIcon = false;
            this.dgvDanhMuc.Size = new System.Drawing.Size(429, 134);
            this.dgvDanhMuc.TabIndex = 2;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvDanhMuc.ThemeStyle.ReadOnly = false;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDanhMuc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // chkApDungSanPham
            // 
            this.chkApDungSanPham.AutoSize = true;
            this.chkApDungSanPham.BackColor = System.Drawing.Color.Transparent;
            this.chkApDungSanPham.CheckedState.BorderRadius = 0;
            this.chkApDungSanPham.CheckedState.BorderThickness = 0;
            this.chkApDungSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkApDungSanPham.Location = new System.Drawing.Point(13, 205);
            this.chkApDungSanPham.Name = "chkApDungSanPham";
            this.chkApDungSanPham.Size = new System.Drawing.Size(156, 24);
            this.chkApDungSanPham.TabIndex = 1;
            this.chkApDungSanPham.Text = "Áp dụng sản phẩm";
            this.chkApDungSanPham.UncheckedState.BorderRadius = 0;
            this.chkApDungSanPham.UncheckedState.BorderThickness = 0;
            this.chkApDungSanPham.UseVisualStyleBackColor = false;
            // 
            // chkApDungDanhMuc
            // 
            this.chkApDungDanhMuc.AutoSize = true;
            this.chkApDungDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.chkApDungDanhMuc.CheckedState.BorderRadius = 0;
            this.chkApDungDanhMuc.CheckedState.BorderThickness = 0;
            this.chkApDungDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkApDungDanhMuc.Location = new System.Drawing.Point(13, 45);
            this.chkApDungDanhMuc.Name = "chkApDungDanhMuc";
            this.chkApDungDanhMuc.Size = new System.Drawing.Size(157, 24);
            this.chkApDungDanhMuc.TabIndex = 0;
            this.chkApDungDanhMuc.Text = "Áp dụng danh mục";
            this.chkApDungDanhMuc.UncheckedState.BorderRadius = 0;
            this.chkApDungDanhMuc.UncheckedState.BorderThickness = 0;
            this.chkApDungDanhMuc.UseVisualStyleBackColor = false;
            // 
            // grpThongTinCoBan
            // 
            this.grpThongTinCoBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinCoBan.Controls.Add(this.chkActive);
            this.grpThongTinCoBan.Controls.Add(this.lblValidationTenVoucher);
            this.grpThongTinCoBan.Controls.Add(this.txtMoTa);
            this.grpThongTinCoBan.Controls.Add(this.lblMoTa);
            this.grpThongTinCoBan.Controls.Add(this.txtSoLuong);
            this.grpThongTinCoBan.Controls.Add(this.lblSoLuong);
            this.grpThongTinCoBan.Controls.Add(this.txtMaVoucher);
            this.grpThongTinCoBan.Controls.Add(this.lblMaVoucher);
            this.grpThongTinCoBan.Controls.Add(this.txtTenVoucher);
            this.grpThongTinCoBan.Controls.Add(this.lblTenVoucher);
            this.grpThongTinCoBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpThongTinCoBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpThongTinCoBan.Location = new System.Drawing.Point(3, 47);
            this.grpThongTinCoBan.Name = "grpThongTinCoBan";
            this.grpThongTinCoBan.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.grpThongTinCoBan.Size = new System.Drawing.Size(547, 230);
            this.grpThongTinCoBan.TabIndex = 27;
            this.grpThongTinCoBan.Text = "Thông tin cơ bản";
            this.grpThongTinCoBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(13, 183);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(103, 24);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "Hoạt động";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblValidationTenVoucher
            // 
            this.lblValidationTenVoucher.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationTenVoucher.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblValidationTenVoucher.ForeColor = System.Drawing.Color.Red;
            this.lblValidationTenVoucher.Location = new System.Drawing.Point(115, 50);
            this.lblValidationTenVoucher.Name = "lblValidationTenVoucher";
            this.lblValidationTenVoucher.Size = new System.Drawing.Size(3, 2);
            this.lblValidationTenVoucher.TabIndex = 8;
            this.lblValidationTenVoucher.Text = null;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.BorderRadius = 5;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(284, 121);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "Mô tả voucher";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(250, 86);
            this.txtMoTa.TabIndex = 7;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.BackColor = System.Drawing.Color.Transparent;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMoTa.Location = new System.Drawing.Point(281, 102);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(48, 20);
            this.lblMoTa.TabIndex = 6;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.BorderRadius = 5;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(284, 66);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(250, 31);
            this.txtSoLuong.TabIndex = 5;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoLuong.Location = new System.Drawing.Point(281, 47);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(139, 20);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng phát hành";
            // 
            // txtMaVoucher
            // 
            this.txtMaVoucher.BorderRadius = 5;
            this.txtMaVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVoucher.DefaultText = "";
            this.txtMaVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaVoucher.Location = new System.Drawing.Point(13, 121);
            this.txtMaVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaVoucher.Name = "txtMaVoucher";
            this.txtMaVoucher.PlaceholderText = "Mã voucher (tùy chọn)";
            this.txtMaVoucher.SelectedText = "";
            this.txtMaVoucher.Size = new System.Drawing.Size(250, 31);
            this.txtMaVoucher.TabIndex = 3;
            // 
            // lblMaVoucher
            // 
            this.lblMaVoucher.AutoSize = true;
            this.lblMaVoucher.BackColor = System.Drawing.Color.Transparent;
            this.lblMaVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaVoucher.Location = new System.Drawing.Point(10, 102);
            this.lblMaVoucher.Name = "lblMaVoucher";
            this.lblMaVoucher.Size = new System.Drawing.Size(86, 20);
            this.lblMaVoucher.TabIndex = 2;
            this.lblMaVoucher.Text = "Mã voucher";
            // 
            // txtTenVoucher
            // 
            this.txtTenVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenVoucher.BorderRadius = 5;
            this.txtTenVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenVoucher.DefaultText = "";
            this.txtTenVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenVoucher.Location = new System.Drawing.Point(13, 66);
            this.txtTenVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenVoucher.Name = "txtTenVoucher";
            this.txtTenVoucher.PlaceholderText = "Tên voucher *";
            this.txtTenVoucher.SelectedText = "";
            this.txtTenVoucher.Size = new System.Drawing.Size(237, 31);
            this.txtTenVoucher.TabIndex = 1;
            // 
            // lblTenVoucher
            // 
            this.lblTenVoucher.AutoSize = true;
            this.lblTenVoucher.BackColor = System.Drawing.Color.Transparent;
            this.lblTenVoucher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenVoucher.Location = new System.Drawing.Point(10, 47);
            this.lblTenVoucher.Name = "lblTenVoucher";
            this.lblTenVoucher.Size = new System.Drawing.Size(106, 20);
            this.lblTenVoucher.TabIndex = 0;
            this.lblTenVoucher.Text = "Tên Voucher *";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(46, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 39);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "CHỈNH SỬA VOUCHER";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatus.Location = new System.Drawing.Point(341, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(3, 2);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = null;
            this.lblStatus.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // lblPreview
            // 
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Location = new System.Drawing.Point(0, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(3, 2);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = null;
            // 
            // FormEditVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 800);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMainContent);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormEditVoucher";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(977, 700);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.grpLoaiGiamGia.ResumeLayout(false);
            this.grpLoaiGiamGia.PerformLayout();
            this.grpThoiGian.ResumeLayout(false);
            this.grpThoiGian.PerformLayout();
            this.grpPhamVi.ResumeLayout(false);
            this.grpPhamVi.PerformLayout();
            this.grpDieuKien.ResumeLayout(false);
            this.grpDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.grpThongTinCoBan.ResumeLayout(false);
            this.grpThongTinCoBan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        // Added Labels
        private System.Windows.Forms.Label lblThongTinCoBan;
        private System.Windows.Forms.Label lblGioiHanDichVu;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Guna2GroupBox grpPreview;
        private ErrorProvider errorProvider;
        private Guna2Panel pnlMainContent;
        private Guna2HtmlLabel lblStatus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Guna2HtmlLabel lblPreview;
        private Guna2Button btnCancel;
        private Guna2GroupBox grpLoaiGiamGia;
        private Label lblGiaTriToiThieu;
        private Guna2TextBox txtGiaTriToiThieu;
        private Guna2ComboBox cmbSanPhamMienPhi;
        private Label lblSanPhamMienPhi;
        private Guna2TextBox txtGiamToiDa;
        private Label lblGiamToiDa;
        private Guna2TextBox txtGiaTriGiam;
        private Label lblGiaTri;
        private Guna2RadioButton radSanPhamMienPhi;
        private Guna2RadioButton rdoAmount;
        private Guna2RadioButton rdoPercent;
        private Guna2GroupBox grpThoiGian;
        private Guna2CheckBox chkVoThoiHan;
        private Guna2DateTimePicker dtpNgayKetThuc;
        private Label lblNgayKetThuc;
        private Guna2DateTimePicker dtpNgayBatDau;
        private Label lblNgayBatDau;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private Guna2GroupBox grpPhamVi;
        private Guna2TextBox txtTimKiemCuaHang;
        private Label lblTimKiemCH;
        private CheckedListBox chkListCuaHang;
        private Guna2RadioButton radTheoCuaHang;
        private Guna2RadioButton radToanChuoi;
        private Guna2Button btnSave;
        private Guna2Button btnRemove;
        private Guna2GroupBox grpDieuKien;
        private Guna2DataGridView dgvSanPham;
        private Guna2DataGridView dgvDanhMuc;
        private Guna2CheckBox chkApDungSanPham;
        private Guna2CheckBox chkApDungDanhMuc;
        private Guna2GroupBox grpThongTinCoBan;
        private Guna2HtmlLabel lblValidationTenVoucher;
        private Guna2TextBox txtMoTa;
        private Label lblMoTa;
        private Guna2TextBox txtSoLuong;
        private Label lblSoLuong;
        private Guna2TextBox txtMaVoucher;
        private Label lblMaVoucher;
        private Guna2TextBox txtTenVoucher;
        private Label lblTenVoucher;
        private Guna2HtmlLabel lblTitle;
        private CheckBox chkActive;
        private Guna2TextBox txtGiaTriToiDa;
        private Label lblGiaTriToiDa;
        private Guna2CheckBox ckoMember;
    }
}