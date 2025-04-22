// FormHienThi.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.HienThiGoc
{
    partial class FormHienThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHienThi));
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThanhVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonDaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnMainMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PanelSubTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAnTaiBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PanelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDatMon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelOrderSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalPaymentValue = new System.Windows.Forms.Label();
            this.lblTotalPaymentLabel = new System.Windows.Forms.Label();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblDiscountLabel = new System.Windows.Forms.Label();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmountLabel = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblItemsCountValue = new System.Windows.Forms.Label();
            this.lblItemsCountLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscountOrder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelSubTop.SuspendLayout();
            this.guna2PanelLeft.SuspendLayout();
            this.guna2PanelRight.SuspendLayout();
            this.guna2PanelOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelTop.Controls.Add(this.btnThanhVien);
            this.guna2PanelTop.Controls.Add(this.btnDeleteOrder);
            this.guna2PanelTop.Controls.Add(this.btnDiscountOrder);
            this.guna2PanelTop.Controls.Add(this.btnUserInfo);
            this.guna2PanelTop.Controls.Add(this.btnDonDaBan);
            this.guna2PanelTop.Controls.Add(this.btnMainMenu);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Size = new System.Drawing.Size(1440, 68);
            this.guna2PanelTop.TabIndex = 0;
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnThanhVien.BorderRadius = 8;
            this.btnThanhVien.BorderThickness = 1;
            this.btnThanhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhVien.FillColor = System.Drawing.Color.White;
            this.btnThanhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnThanhVien.ForeColor = System.Drawing.Color.DimGray;
            this.btnThanhVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnThanhVien.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnThanhVien.ImageSize = new System.Drawing.Size(18, 18);
            this.btnThanhVien.Location = new System.Drawing.Point(257, 10);
            this.btnThanhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(120, 49);
            this.btnThanhVien.TabIndex = 9;
            this.btnThanhVien.Text = "THÀNH VIÊN";
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserInfo.BorderRadius = 8;
            this.btnUserInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(153)))));
            this.btnUserInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnUserInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserInfo.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnUserInfo.ImageSize = new System.Drawing.Size(24, 24);
            this.btnUserInfo.Location = new System.Drawing.Point(1004, 10);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnUserInfo.Size = new System.Drawing.Size(193, 49);
            this.btnUserInfo.TabIndex = 5;
            this.btnUserInfo.Text = "HOANG ANH\r\n09654123654";
            this.btnUserInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserInfo.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnDonDaBan
            // 
            this.btnDonDaBan.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDonDaBan.BorderRadius = 8;
            this.btnDonDaBan.BorderThickness = 1;
            this.btnDonDaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonDaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonDaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonDaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonDaBan.FillColor = System.Drawing.Color.White;
            this.btnDonDaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnDonDaBan.ForeColor = System.Drawing.Color.DimGray;
            this.btnDonDaBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnDonDaBan.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnDonDaBan.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDonDaBan.Location = new System.Drawing.Point(105, 10);
            this.btnDonDaBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonDaBan.Name = "btnDonDaBan";
            this.btnDonDaBan.Size = new System.Drawing.Size(120, 49);
            this.btnDonDaBan.TabIndex = 2;
            this.btnDonDaBan.Text = "ĐƠN ĐÃ BÁN";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMainMenu.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
            this.btnMainMenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMainMenu.ImageRotate = 0F;
            this.btnMainMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMainMenu.Location = new System.Drawing.Point(16, 10);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMainMenu.Size = new System.Drawing.Size(53, 49);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.UseTransparentBackground = true;
            // 
            // guna2PanelSubTop
            // 
            this.guna2PanelSubTop.Controls.Add(this.btnAnTaiBan);
            this.guna2PanelSubTop.Controls.Add(this.btnFilter);
            this.guna2PanelSubTop.Controls.Add(this.txtSearchBox);
            this.guna2PanelSubTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelSubTop.FillColor = System.Drawing.Color.White;
            this.guna2PanelSubTop.Location = new System.Drawing.Point(0, 68);
            this.guna2PanelSubTop.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelSubTop.Name = "guna2PanelSubTop";
            this.guna2PanelSubTop.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.guna2PanelSubTop.Size = new System.Drawing.Size(1440, 68);
            this.guna2PanelSubTop.TabIndex = 1;
            // 
            // btnAnTaiBan
            // 
            this.btnAnTaiBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnTaiBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnAnTaiBan.BorderRadius = 5;
            this.btnAnTaiBan.BorderThickness = 1;
            this.btnAnTaiBan.Checked = true;
            this.btnAnTaiBan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnAnTaiBan.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAnTaiBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnTaiBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnTaiBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnTaiBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnTaiBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnAnTaiBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnTaiBan.ForeColor = System.Drawing.Color.White;
            this.btnAnTaiBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnAnTaiBan.Location = new System.Drawing.Point(1168, 14);
            this.btnAnTaiBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnTaiBan.Name = "btnAnTaiBan";
            this.btnAnTaiBan.Size = new System.Drawing.Size(133, 42);
            this.btnAnTaiBan.TabIndex = 3;
            this.btnAnTaiBan.Text = "Đơn hàng";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFilter.ImageRotate = 0F;
            this.btnFilter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFilter.Location = new System.Drawing.Point(547, 16);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnFilter.Size = new System.Drawing.Size(40, 37);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseTransparentBackground = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchBox.BorderRadius = 15;
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearchBox.Location = new System.Drawing.Point(17, 14);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PlaceholderText = "Nhập tên món ăn cần tìm kiếm ....";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(520, 42);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2PanelLeft
            // 
            this.guna2PanelLeft.Controls.Add(this.flowLayoutPanelCategories);
            this.guna2PanelLeft.Controls.Add(this.lblCategoryTitle);
            this.guna2PanelLeft.Controls.Add(this.flowLayoutPanelMenuItems);
            this.guna2PanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelLeft.Location = new System.Drawing.Point(0, 136);
            this.guna2PanelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelLeft.Name = "guna2PanelLeft";
            this.guna2PanelLeft.Padding = new System.Windows.Forms.Padding(13, 6, 7, 12);
            this.guna2PanelLeft.Size = new System.Drawing.Size(973, 750);
            this.guna2PanelLeft.TabIndex = 2;
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCategories.AutoScroll = true;
            this.flowLayoutPanelCategories.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(17, 651);
            this.flowLayoutPanelCategories.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(945, 86);
            this.flowLayoutPanelCategories.TabIndex = 2;
            this.flowLayoutPanelCategories.WrapContents = false;
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoryTitle.Location = new System.Drawing.Point(17, 621);
            this.lblCategoryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(282, 23);
            this.lblCategoryTitle.TabIndex = 1;
            this.lblCategoryTitle.Text = "Danh mục Món ăn được tạo nhanh";
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMenuItems.AutoScroll = true;
            this.flowLayoutPanelMenuItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelMenuItems.Location = new System.Drawing.Point(13, 10);
            this.flowLayoutPanelMenuItems.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            this.flowLayoutPanelMenuItems.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.flowLayoutPanelMenuItems.Size = new System.Drawing.Size(949, 602);
            this.flowLayoutPanelMenuItems.TabIndex = 0;
            // 
            // guna2PanelRight
            // 
            this.guna2PanelRight.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelRight.Controls.Add(this.btnDatMon);
            this.guna2PanelRight.Controls.Add(this.guna2PanelOrderSummary);
            this.guna2PanelRight.Controls.Add(this.flowLayoutPanelOrderItems);
            this.guna2PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PanelRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.guna2PanelRight.Location = new System.Drawing.Point(973, 136);
            this.guna2PanelRight.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelRight.Name = "guna2PanelRight";
            this.guna2PanelRight.Padding = new System.Windows.Forms.Padding(7, 0, 13, 12);
            this.guna2PanelRight.Size = new System.Drawing.Size(467, 750);
            this.guna2PanelRight.TabIndex = 3;
            this.guna2PanelRight.UseTransparentBackground = true;
            // 
            // btnDatMon
            // 
            this.btnDatMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatMon.BorderRadius = 5;
            this.btnDatMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnDatMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDatMon.ForeColor = System.Drawing.Color.White;
            this.btnDatMon.Location = new System.Drawing.Point(11, 666);
            this.btnDatMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(439, 68);
            this.btnDatMon.TabIndex = 2;
            this.btnDatMon.Text = "ĐẶT MÓN";
            this.btnDatMon.Click += new System.EventHandler(this.BtnDatMon_Click);
            // 
            // guna2PanelOrderSummary
            // 
            this.guna2PanelOrderSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelOrderSummary.BorderRadius = 10;
            this.guna2PanelOrderSummary.Controls.Add(this.lblTotalPaymentValue);
            this.guna2PanelOrderSummary.Controls.Add(this.lblTotalPaymentLabel);
            this.guna2PanelOrderSummary.Controls.Add(this.guna2Separator6);
            this.guna2PanelOrderSummary.Controls.Add(this.lblDiscountValue);
            this.guna2PanelOrderSummary.Controls.Add(this.lblDiscountLabel);
            this.guna2PanelOrderSummary.Controls.Add(this.guna2Separator5);
            this.guna2PanelOrderSummary.Controls.Add(this.lblTotalAmountValue);
            this.guna2PanelOrderSummary.Controls.Add(this.lblTotalAmountLabel);
            this.guna2PanelOrderSummary.Controls.Add(this.guna2Separator4);
            this.guna2PanelOrderSummary.Controls.Add(this.lblItemsCountValue);
            this.guna2PanelOrderSummary.Controls.Add(this.lblItemsCountLabel);
            this.guna2PanelOrderSummary.FillColor = System.Drawing.Color.White;
            this.guna2PanelOrderSummary.Location = new System.Drawing.Point(11, 417);
            this.guna2PanelOrderSummary.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelOrderSummary.Name = "guna2PanelOrderSummary";
            this.guna2PanelOrderSummary.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.guna2PanelOrderSummary.Size = new System.Drawing.Size(439, 234);
            this.guna2PanelOrderSummary.TabIndex = 1;
            this.guna2PanelOrderSummary.UseTransparentBackground = true;
            // 
            // lblTotalPaymentValue
            // 
            this.lblTotalPaymentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPaymentValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPaymentValue.Location = new System.Drawing.Point(235, 191);
            this.lblTotalPaymentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaymentValue.Name = "lblTotalPaymentValue";
            this.lblTotalPaymentValue.Size = new System.Drawing.Size(187, 25);
            this.lblTotalPaymentValue.TabIndex = 12;
            this.lblTotalPaymentValue.Text = "369.000 VND";
            this.lblTotalPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPaymentLabel
            // 
            this.lblTotalPaymentLabel.AutoSize = true;
            this.lblTotalPaymentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPaymentLabel.Location = new System.Drawing.Point(20, 191);
            this.lblTotalPaymentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaymentLabel.Name = "lblTotalPaymentLabel";
            this.lblTotalPaymentLabel.Size = new System.Drawing.Size(113, 25);
            this.lblTotalPaymentLabel.TabIndex = 11;
            this.lblTotalPaymentLabel.Text = "Thanh toán";
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator6.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator6.Location = new System.Drawing.Point(20, 170);
            this.guna2Separator6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(401, 12);
            this.guna2Separator6.TabIndex = 10;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiscountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscountValue.Location = new System.Drawing.Point(288, 135);
            this.lblDiscountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(133, 21);
            this.lblDiscountValue.TabIndex = 9;
            this.lblDiscountValue.Text = "0";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountLabel
            // 
            this.lblDiscountLabel.AutoSize = true;
            this.lblDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDiscountLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblDiscountLabel.Location = new System.Drawing.Point(20, 135);
            this.lblDiscountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountLabel.Name = "lblDiscountLabel";
            this.lblDiscountLabel.Size = new System.Drawing.Size(78, 23);
            this.lblDiscountLabel.TabIndex = 8;
            this.lblDiscountLabel.Text = "Giảm giá";
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator5.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator5.Location = new System.Drawing.Point(20, 111);
            this.guna2Separator5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(401, 12);
            this.guna2Separator5.TabIndex = 7;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(248, 74);
            this.lblTotalAmountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(173, 21);
            this.lblTotalAmountValue.TabIndex = 6;
            this.lblTotalAmountValue.Text = "369.000 VND";
            this.lblTotalAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountLabel
            // 
            this.lblTotalAmountLabel.AutoSize = true;
            this.lblTotalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTotalAmountLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalAmountLabel.Location = new System.Drawing.Point(20, 74);
            this.lblTotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountLabel.Name = "lblTotalAmountLabel";
            this.lblTotalAmountLabel.Size = new System.Drawing.Size(83, 23);
            this.lblTotalAmountLabel.TabIndex = 5;
            this.lblTotalAmountLabel.Text = "Tổng tiền";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator4.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator4.Location = new System.Drawing.Point(20, 49);
            this.guna2Separator4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(401, 12);
            this.guna2Separator4.TabIndex = 4;
            // 
            // lblItemsCountValue
            // 
            this.lblItemsCountValue.AutoSize = true;
            this.lblItemsCountValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblItemsCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemsCountValue.Location = new System.Drawing.Point(73, 18);
            this.lblItemsCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsCountValue.Name = "lblItemsCountValue";
            this.lblItemsCountValue.Size = new System.Drawing.Size(20, 23);
            this.lblItemsCountValue.TabIndex = 1;
            this.lblItemsCountValue.Text = "2";
            // 
            // lblItemsCountLabel
            // 
            this.lblItemsCountLabel.AutoSize = true;
            this.lblItemsCountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblItemsCountLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblItemsCountLabel.Location = new System.Drawing.Point(20, 18);
            this.lblItemsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsCountLabel.Name = "lblItemsCountLabel";
            this.lblItemsCountLabel.Size = new System.Drawing.Size(45, 23);
            this.lblItemsCountLabel.TabIndex = 0;
            this.lblItemsCountLabel.Text = "Món";
            // 
            // flowLayoutPanelOrderItems
            // 
            this.flowLayoutPanelOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOrderItems.AutoScroll = true;
            this.flowLayoutPanelOrderItems.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelOrderItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOrderItems.Location = new System.Drawing.Point(11, 10);
            this.flowLayoutPanelOrderItems.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelOrderItems.Name = "flowLayoutPanelOrderItems";
            this.flowLayoutPanelOrderItems.Size = new System.Drawing.Size(439, 399);
            this.flowLayoutPanelOrderItems.TabIndex = 0;
            this.flowLayoutPanelOrderItems.WrapContents = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteOrder.BorderRadius = 8;
            this.btnDeleteOrder.BorderThickness = 1;
            this.btnDeleteOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteOrder.FillColor = System.Drawing.SystemColors.Window;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnDeleteOrder.Location = new System.Drawing.Point(1339, 11);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(85, 48);
            this.btnDeleteOrder.TabIndex = 8;
            this.btnDeleteOrder.Text = "Xóa đơn hàng";
            // 
            // btnDiscountOrder
            // 
            this.btnDiscountOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscountOrder.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDiscountOrder.BorderRadius = 8;
            this.btnDiscountOrder.BorderThickness = 1;
            this.btnDiscountOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscountOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscountOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscountOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscountOrder.FillColor = System.Drawing.Color.White;
            this.btnDiscountOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiscountOrder.ForeColor = System.Drawing.Color.Black;
            this.btnDiscountOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnDiscountOrder.Location = new System.Drawing.Point(1205, 11);
            this.btnDiscountOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscountOrder.Name = "btnDiscountOrder";
            this.btnDiscountOrder.Size = new System.Drawing.Size(126, 49);
            this.btnDiscountOrder.TabIndex = 7;
            this.btnDiscountOrder.Text = "Giảm giá";
            // 
            // FormHienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelLeft);
            this.Controls.Add(this.guna2PanelRight);
            this.Controls.Add(this.guna2PanelSubTop);
            this.Controls.Add(this.guna2PanelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHienThi";
            this.Size = new System.Drawing.Size(1440, 886);
            this.Load += new System.EventHandler(this.FormHienThi_Load);
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelSubTop.ResumeLayout(false);
            this.guna2PanelLeft.ResumeLayout(false);
            this.guna2PanelLeft.PerformLayout();
            this.guna2PanelRight.ResumeLayout(false);
            this.guna2PanelOrderSummary.ResumeLayout(false);
            this.guna2PanelOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2ImageButton btnMainMenu;
        private Guna.UI2.WinForms.Guna2Button btnDonDaBan;
        private Guna.UI2.WinForms.Guna2Button btnUserInfo;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSubTop;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private Guna.UI2.WinForms.Guna2ImageButton btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnAnTaiBan;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLeft;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrderItems;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelOrderSummary;
        private System.Windows.Forms.Label lblItemsCountLabel;
        private System.Windows.Forms.Label lblItemsCountValue;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmountLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblDiscountLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private System.Windows.Forms.Label lblTotalPaymentValue;
        private System.Windows.Forms.Label lblTotalPaymentLabel;
        private Guna.UI2.WinForms.Guna2Button btnDatMon;
        private Guna2Button btnThanhVien;
        private Guna2Button btnDeleteOrder;
        private Guna2Button btnDiscountOrder;
    }
}