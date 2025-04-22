// FormDangKyTV.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo // Hoặc namespace phù hợp
{
    partial class FormDangKyTV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button(); // Thêm nút Hủy
            this.labelTenTV = new System.Windows.Forms.Label();
            this.txtTenThanhVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelSDT = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtMaThanhVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelMaTV = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelCuaHangDK = new System.Windows.Forms.Label();
            this.cmbCuaHangDK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.labelRequired1 = new System.Windows.Forms.Label();
            this.labelRequired2 = new System.Windows.Forms.Label();
            this.guna2PanelTop.SuspendLayout();
            this.SuspendLayout();
            //
            // guna2PanelTop
            //
            this.guna2PanelTop.BackColor = System.Drawing.Color.WhiteSmoke; // Màu nền nhẹ
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Controls.Add(this.btnCancel); // Nút Hủy trên top bar
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.guna2PanelTop.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelTop.ShadowDecoration.Enabled = true;
            this.guna2PanelTop.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2PanelTop.Size = new System.Drawing.Size(500, 50); // Chiều rộng ví dụ
            this.guna2PanelTop.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(160, 13); // Căn giữa tiêu đề
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đăng Ký Thành Viên";
            //
            // btnCancel
            //
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel; // Đặt DialogResult cho nút Hủy
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro; // Màu xám nhạt
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(417, 8); // Góc trên phải
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 35);
            this.btnCancel.TabIndex = 11; // TabIndex cao hơn các input
            this.btnCancel.Text = "HỦY";
            //
            // labelTenTV
            //
            this.labelTenTV.AutoSize = true;
            this.labelTenTV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelTenTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTenTV.Location = new System.Drawing.Point(30, 80);
            this.labelTenTV.Name = "labelTenTV";
            this.labelTenTV.Size = new System.Drawing.Size(101, 17);
            this.labelTenTV.TabIndex = 1;
            this.labelTenTV.Text = "Tên thành viên";
            //
            // txtTenThanhVien
            //
            this.txtTenThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenThanhVien.BorderRadius = 5;
            this.txtTenThanhVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenThanhVien.DefaultText = "";
            this.txtTenThanhVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenThanhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenThanhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenThanhVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenThanhVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenThanhVien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenThanhVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenThanhVien.Location = new System.Drawing.Point(160, 75);
            this.txtTenThanhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenThanhVien.Name = "txtTenThanhVien";
            this.txtTenThanhVien.PasswordChar = '\0';
            this.txtTenThanhVien.PlaceholderText = "Nhập tên thành viên";
            this.txtTenThanhVien.SelectedText = "";
            this.txtTenThanhVien.Size = new System.Drawing.Size(310, 36);
            this.txtTenThanhVien.TabIndex = 1; // TabIndex đầu tiên
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDienThoai.BorderRadius = 5;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(160, 120);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PlaceholderText = "Nhập số điện thoại";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(310, 36);
            this.txtSoDienThoai.TabIndex = 2;
            //
            // labelSDT
            //
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSDT.Location = new System.Drawing.Point(30, 125);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(89, 17);
            this.labelSDT.TabIndex = 3;
            this.labelSDT.Text = "Số điện thoại";
            //
            // txtEmail
            //
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(160, 165);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Nhập email (không bắt buộc)";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(310, 36);
            this.txtEmail.TabIndex = 3;
            //
            // labelEmail
            //
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEmail.Location = new System.Drawing.Point(30, 170);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 17);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            //
            // txtMaThanhVien
            //
            this.txtMaThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaThanhVien.BorderRadius = 5;
            this.txtMaThanhVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaThanhVien.DefaultText = "";
            this.txtMaThanhVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaThanhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaThanhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaThanhVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaThanhVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaThanhVien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaThanhVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaThanhVien.Location = new System.Drawing.Point(160, 210);
            this.txtMaThanhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaThanhVien.Name = "txtMaThanhVien";
            this.txtMaThanhVien.PasswordChar = '\0';
            this.txtMaThanhVien.PlaceholderText = "Để trống sẽ tự sinh mã";
            this.txtMaThanhVien.SelectedText = "";
            this.txtMaThanhVien.Size = new System.Drawing.Size(310, 36);
            this.txtMaThanhVien.TabIndex = 4;
            //
            // labelMaTV
            //
            this.labelMaTV.AutoSize = true;
            this.labelMaTV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelMaTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMaTV.Location = new System.Drawing.Point(30, 215);
            this.labelMaTV.Name = "labelMaTV";
            this.labelMaTV.Size = new System.Drawing.Size(94, 17);
            this.labelMaTV.TabIndex = 7;
            this.labelMaTV.Text = "Mã thành viên";
            //
            // labelNgaySinh
            //
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNgaySinh.Location = new System.Drawing.Point(30, 260);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(66, 17);
            this.labelNgaySinh.TabIndex = 9;
            this.labelNgaySinh.Text = "Ngày sinh";
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.BorderRadius = 5;
            this.dtpNgaySinh.Checked = true; // Mặc định có chọn ngày
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày Việt Nam
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom; // Sử dụng CustomFormat
            this.dtpNgaySinh.Location = new System.Drawing.Point(160, 255);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0); // Giới hạn ngày tối thiểu
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShowCheckBox = true; // Cho phép không chọn ngày sinh
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 36); // Kích thước nhỏ hơn
            this.dtpNgaySinh.TabIndex = 5;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 4, 7, 0, 0, 0, 0); // Giá trị mặc định
                                                                                  // Bỏ check ban đầu để người dùng có thể không nhập
            this.dtpNgaySinh.Checked = false;
            //
            // labelGioiTinh
            //
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGioiTinh.Location = new System.Drawing.Point(30, 305);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(56, 17);
            this.labelGioiTinh.TabIndex = 11;
            this.labelGioiTinh.Text = "Giới tính";
            //
            // cmbGioiTinh
            //
            this.cmbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cmbGioiTinh.BorderRadius = 5;
            this.cmbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Chỉ cho phép chọn từ danh sách
            this.cmbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGioiTinh.ItemHeight = 30;
            this.cmbGioiTinh.Items.AddRange(new object[] { // Thêm các lựa chọn
            "Nam",
            "Nữ",
            "Khác"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(160, 300);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(150, 36); // Kích thước nhỏ hơn
            this.cmbGioiTinh.TabIndex = 6;
            //
            // labelCuaHangDK
            //
            this.labelCuaHangDK.AutoSize = true;
            this.labelCuaHangDK.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelCuaHangDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCuaHangDK.Location = new System.Drawing.Point(30, 350);
            this.labelCuaHangDK.Name = "labelCuaHangDK";
            this.labelCuaHangDK.Size = new System.Drawing.Size(114, 17);
            this.labelCuaHangDK.TabIndex = 13;
            this.labelCuaHangDK.Text = "Cửa hàng đăng ký";
            //
            // cmbCuaHangDK
            //
            this.cmbCuaHangDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCuaHangDK.BackColor = System.Drawing.Color.Transparent;
            this.cmbCuaHangDK.BorderRadius = 5;
            this.cmbCuaHangDK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCuaHangDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuaHangDK.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCuaHangDK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCuaHangDK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCuaHangDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCuaHangDK.ItemHeight = 30;
            // Items sẽ được load từ CSDL trong code-behind
            this.cmbCuaHangDK.Location = new System.Drawing.Point(160, 345);
            this.cmbCuaHangDK.Name = "cmbCuaHangDK";
            this.cmbCuaHangDK.Size = new System.Drawing.Size(310, 36);
            this.cmbCuaHangDK.TabIndex = 7;
            //
            // txtGhiChu
            //
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.BorderRadius = 5;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(160, 390);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "Nhập ghi chú nếu có";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(310, 80); // Tăng chiều cao
            this.txtGhiChu.TabIndex = 8;
            //
            // labelGhiChu
            //
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGhiChu.Location = new System.Drawing.Point(30, 395);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(51, 17);
            this.labelGhiChu.TabIndex = 15;
            this.labelGhiChu.Text = "Ghi chú";
            //
            // btnLuu
            //
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu hồng/đỏ
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(350, 490); // Vị trí góc dưới phải
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 45);
            this.btnLuu.TabIndex = 10; // TabIndex sau nút hủy để nhấn Enter có thể là Lưu
            this.btnLuu.Text = "LƯU";
            //
            // labelRequired1
            //
            this.labelRequired1.AutoSize = true;
            this.labelRequired1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelRequired1.ForeColor = System.Drawing.Color.Red; // Màu đỏ cho dấu *
            this.labelRequired1.Location = new System.Drawing.Point(125, 80);
            this.labelRequired1.Name = "labelRequired1";
            this.labelRequired1.Size = new System.Drawing.Size(13, 17);
            this.labelRequired1.TabIndex = 17;
            this.labelRequired1.Text = "*";
            //
            // labelRequired2
            //
            this.labelRequired2.AutoSize = true;
            this.labelRequired2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelRequired2.ForeColor = System.Drawing.Color.Red;
            this.labelRequired2.Location = new System.Drawing.Point(115, 125);
            this.labelRequired2.Name = "labelRequired2";
            this.labelRequired2.Size = new System.Drawing.Size(13, 17);
            this.labelRequired2.TabIndex = 18;
            this.labelRequired2.Text = "*";
            //
            // FormDangKyTV
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White; // Nền trắng
            this.Controls.Add(this.labelRequired2);
            this.Controls.Add(this.labelRequired1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.labelGhiChu);
            this.Controls.Add(this.cmbCuaHangDK);
            this.Controls.Add(this.labelCuaHangDK);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.txtMaThanhVien);
            this.Controls.Add(this.labelMaTV);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.labelSDT);
            this.Controls.Add(this.txtTenThanhVien);
            this.Controls.Add(this.labelTenTV);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FormDangKyTV";
            this.Size = new System.Drawing.Size(500, 550); // Kích thước UserControl
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label labelTenTV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenThanhVien;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private System.Windows.Forms.Label labelSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMaThanhVien;
        private System.Windows.Forms.Label labelMaTV;
        private System.Windows.Forms.Label labelNgaySinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label labelGioiTinh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label labelCuaHangDK;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCuaHangDK;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private System.Windows.Forms.Label labelGhiChu;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.Label labelRequired1; // Dấu sao cho Tên TV
        private System.Windows.Forms.Label labelRequired2; // Dấu sao cho SĐT
    }
}