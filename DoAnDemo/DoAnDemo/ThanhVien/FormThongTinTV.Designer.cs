// FormThongTinTV.Designer.cs
// Required using statements at the top of the file
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo
{
    partial class FormThongTinTV
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
            this.btnDeleteMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscountMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnNoteMember = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonMemberInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnScanQR = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuickSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchMember = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMemberNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLevelValue = new System.Windows.Forms.Label();
            this.lblLevelLabel = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblPointsValue = new System.Windows.Forms.Label();
            this.lblPointsLabel = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblWalletValue = new System.Windows.Forms.Label();
            this.lblWalletLabel = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblMemberNameLeft = new System.Windows.Forms.Label();
            this.picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnNapTien = new Guna.UI2.WinForms.Guna2Button();
            this.btnTongHop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelMiddle = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelGifts = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGiftsTitle = new System.Windows.Forms.Label();
            this.guna2PanelVouchers = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNextVoucher = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblVoucherTitle = new System.Windows.Forms.Label();
            this.guna2PanelFavFood = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoFavFood = new System.Windows.Forms.Label();
            this.lblFavFoodTitle = new System.Windows.Forms.Label();
            this.btnCloseMemberInfo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblMemberNameMiddle = new System.Windows.Forms.Label();
            this.picProfileMiddle = new Guna.UI2.WinForms.Guna2CirclePictureBox();
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
            this.lblTableValue = new System.Windows.Forms.Label();
            this.lblItemsLabel = new System.Windows.Forms.Label();
            this.btnMangDi = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnTaiBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelLeft.SuspendLayout();
            this.guna2PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.guna2PanelMiddle.SuspendLayout();
            this.guna2PanelGifts.SuspendLayout();
            this.guna2PanelVouchers.SuspendLayout();
            this.guna2PanelFavFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileMiddle)).BeginInit();
            this.guna2PanelRight.SuspendLayout();
            this.guna2PanelOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelTop.Controls.Add(this.btnRegister);
            this.guna2PanelTop.Controls.Add(this.btnDeleteMember);
            this.guna2PanelTop.Controls.Add(this.btnDiscountMember);
            this.guna2PanelTop.Controls.Add(this.btnNoteMember);
            this.guna2PanelTop.Controls.Add(this.guna2ButtonMemberInfo);
            this.guna2PanelTop.Controls.Add(this.btnFilter);
            this.guna2PanelTop.Controls.Add(this.btnScanQR);
            this.guna2PanelTop.Controls.Add(this.btnQuickSearch);
            this.guna2PanelTop.Controls.Add(this.txtSearchMember);
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Controls.Add(this.btnBack);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Size = new System.Drawing.Size(1302, 55);
            this.guna2PanelTop.TabIndex = 2;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMember.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteMember.BorderRadius = 8;
            this.btnDeleteMember.BorderThickness = 1;
            this.btnDeleteMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteMember.FillColor = System.Drawing.Color.White;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnDeleteMember.Location = new System.Drawing.Point(1250, 8);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteMember.TabIndex = 10;
            // 
            // btnDiscountMember
            // 
            this.btnDiscountMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscountMember.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDiscountMember.BorderRadius = 8;
            this.btnDiscountMember.BorderThickness = 1;
            this.btnDiscountMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscountMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscountMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscountMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscountMember.FillColor = System.Drawing.Color.White;
            this.btnDiscountMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiscountMember.ForeColor = System.Drawing.Color.White;
            this.btnDiscountMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnDiscountMember.Location = new System.Drawing.Point(1204, 8);
            this.btnDiscountMember.Name = "btnDiscountMember";
            this.btnDiscountMember.Size = new System.Drawing.Size(40, 40);
            this.btnDiscountMember.TabIndex = 9;
            // 
            // btnNoteMember
            // 
            this.btnNoteMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoteMember.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnNoteMember.BorderRadius = 8;
            this.btnNoteMember.BorderThickness = 1;
            this.btnNoteMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNoteMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNoteMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNoteMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNoteMember.FillColor = System.Drawing.Color.White;
            this.btnNoteMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNoteMember.ForeColor = System.Drawing.Color.White;
            this.btnNoteMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnNoteMember.Location = new System.Drawing.Point(1158, 8);
            this.btnNoteMember.Name = "btnNoteMember";
            this.btnNoteMember.Size = new System.Drawing.Size(40, 40);
            this.btnNoteMember.TabIndex = 8;
            // 
            // guna2ButtonMemberInfo
            // 
            this.guna2ButtonMemberInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonMemberInfo.BorderRadius = 8;
            this.guna2ButtonMemberInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonMemberInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonMemberInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonMemberInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonMemberInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(153)))));
            this.guna2ButtonMemberInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonMemberInfo.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonMemberInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonMemberInfo.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2ButtonMemberInfo.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ButtonMemberInfo.Location = new System.Drawing.Point(1007, 8);
            this.guna2ButtonMemberInfo.Name = "guna2ButtonMemberInfo";
            this.guna2ButtonMemberInfo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.guna2ButtonMemberInfo.Size = new System.Drawing.Size(145, 40);
            this.guna2ButtonMemberInfo.TabIndex = 7;
            this.guna2ButtonMemberInfo.Text = "PHAM...\r\n0853173...";
            this.guna2ButtonMemberInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonMemberInfo.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnFilter
            // 
            this.btnFilter.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.BorderRadius = 8;
            this.btnFilter.BorderThickness = 1;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.White;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.DimGray;
            this.btnFilter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnFilter.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnFilter.ImageSize = new System.Drawing.Size(18, 18);
            this.btnFilter.Location = new System.Drawing.Point(638, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(140, 40);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "LỌC HỌC SINH";
            this.btnFilter.TextOffset = new System.Drawing.Point(0, 8);
            // 
            // btnScanQR
            // 
            this.btnScanQR.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnScanQR.BorderRadius = 8;
            this.btnScanQR.BorderThickness = 1;
            this.btnScanQR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScanQR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScanQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScanQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScanQR.FillColor = System.Drawing.Color.White;
            this.btnScanQR.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnScanQR.ForeColor = System.Drawing.Color.DimGray;
            this.btnScanQR.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnScanQR.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnScanQR.ImageSize = new System.Drawing.Size(18, 18);
            this.btnScanQR.Location = new System.Drawing.Point(492, 8);
            this.btnScanQR.Name = "btnScanQR";
            this.btnScanQR.Size = new System.Drawing.Size(140, 40);
            this.btnScanQR.TabIndex = 5;
            this.btnScanQR.Text = "QUÉT MÃ QR";
            this.btnScanQR.TextOffset = new System.Drawing.Point(0, 8);
            // 
            // btnQuickSearch
            // 
            this.btnQuickSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnQuickSearch.BorderRadius = 18;
            this.btnQuickSearch.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnQuickSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuickSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuickSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuickSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuickSearch.FillColor = System.Drawing.Color.White;
            this.btnQuickSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuickSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnQuickSearch.Location = new System.Drawing.Point(375, 8);
            this.btnQuickSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuickSearch.Name = "btnQuickSearch";
            this.btnQuickSearch.Size = new System.Drawing.Size(55, 40);
            this.btnQuickSearch.TabIndex = 4;
            this.btnQuickSearch.Text = "123";
            this.btnQuickSearch.UseTransparentBackground = true;
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchMember.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchMember.BorderRadius = 18;
            this.txtSearchMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMember.DefaultText = "1901";
            this.txtSearchMember.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMember.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMember.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchMember.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchMember.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMember.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearchMember.Location = new System.Drawing.Point(220, 8);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchMember.PlaceholderText = "";
            this.txtSearchMember.SelectedText = "";
            this.txtSearchMember.Size = new System.Drawing.Size(210, 40);
            this.txtSearchMember.TabIndex = 3;
            this.txtSearchMember.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(60, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Thành viên";
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 55);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            // 
            // guna2PanelLeft
            // 
            this.guna2PanelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelLeft.Controls.Add(this.guna2PanelProfile);
            this.guna2PanelLeft.Controls.Add(this.btnNapTien);
            this.guna2PanelLeft.Controls.Add(this.btnTongHop);
            this.guna2PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PanelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.guna2PanelLeft.Location = new System.Drawing.Point(0, 55);
            this.guna2PanelLeft.Name = "guna2PanelLeft";
            this.guna2PanelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelLeft.Size = new System.Drawing.Size(250, 665);
            this.guna2PanelLeft.TabIndex = 3;
            // 
            // guna2PanelProfile
            // 
            this.guna2PanelProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelProfile.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelProfile.BorderRadius = 10;
            this.guna2PanelProfile.Controls.Add(this.txtMemberNote);
            this.guna2PanelProfile.Controls.Add(this.lblLevelValue);
            this.guna2PanelProfile.Controls.Add(this.lblLevelLabel);
            this.guna2PanelProfile.Controls.Add(this.guna2Separator3);
            this.guna2PanelProfile.Controls.Add(this.lblPointsValue);
            this.guna2PanelProfile.Controls.Add(this.lblPointsLabel);
            this.guna2PanelProfile.Controls.Add(this.guna2Separator2);
            this.guna2PanelProfile.Controls.Add(this.lblWalletValue);
            this.guna2PanelProfile.Controls.Add(this.lblWalletLabel);
            this.guna2PanelProfile.Controls.Add(this.guna2Separator1);
            this.guna2PanelProfile.Controls.Add(this.lblMemberNameLeft);
            this.guna2PanelProfile.Controls.Add(this.picProfile);
            this.guna2PanelProfile.FillColor = System.Drawing.Color.White;
            this.guna2PanelProfile.Location = new System.Drawing.Point(10, 65);
            this.guna2PanelProfile.Name = "guna2PanelProfile";
            this.guna2PanelProfile.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelProfile.Size = new System.Drawing.Size(230, 590);
            this.guna2PanelProfile.TabIndex = 2;
            this.guna2PanelProfile.UseTransparentBackground = true;
            // 
            // txtMemberNote
            // 
            this.txtMemberNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberNote.BorderRadius = 5;
            this.txtMemberNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberNote.DefaultText = "";
            this.txtMemberNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMemberNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMemberNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMemberNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberNote.Location = new System.Drawing.Point(15, 350);
            this.txtMemberNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberNote.Multiline = true;
            this.txtMemberNote.Name = "txtMemberNote";
            this.txtMemberNote.PlaceholderText = "Ghi chú thành viên ...";
            this.txtMemberNote.SelectedText = "";
            this.txtMemberNote.Size = new System.Drawing.Size(200, 70);
            this.txtMemberNote.TabIndex = 11;
            // 
            // lblLevelValue
            // 
            this.lblLevelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevelValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLevelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLevelValue.Location = new System.Drawing.Point(117, 305);
            this.lblLevelValue.Name = "lblLevelValue";
            this.lblLevelValue.Size = new System.Drawing.Size(98, 17);
            this.lblLevelValue.TabIndex = 10;
            this.lblLevelValue.Text = "Basic";
            this.lblLevelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLevelLabel
            // 
            this.lblLevelLabel.AutoSize = true;
            this.lblLevelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLevelLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblLevelLabel.Location = new System.Drawing.Point(15, 305);
            this.lblLevelLabel.Name = "lblLevelLabel";
            this.lblLevelLabel.Size = new System.Drawing.Size(65, 23);
            this.lblLevelLabel.TabIndex = 9;
            this.lblLevelLabel.Text = "Cấp độ";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator3.Location = new System.Drawing.Point(15, 285);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator3.TabIndex = 8;
            // 
            // lblPointsValue
            // 
            this.lblPointsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPointsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPointsValue.Location = new System.Drawing.Point(117, 260);
            this.lblPointsValue.Name = "lblPointsValue";
            this.lblPointsValue.Size = new System.Drawing.Size(98, 17);
            this.lblPointsValue.TabIndex = 7;
            this.lblPointsValue.Text = "5";
            this.lblPointsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPointsLabel
            // 
            this.lblPointsLabel.AutoSize = true;
            this.lblPointsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPointsLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblPointsLabel.Location = new System.Drawing.Point(15, 260);
            this.lblPointsLabel.Name = "lblPointsLabel";
            this.lblPointsLabel.Size = new System.Drawing.Size(50, 23);
            this.lblPointsLabel.TabIndex = 6;
            this.lblPointsLabel.Text = "Điểm";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator2.Location = new System.Drawing.Point(15, 240);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator2.TabIndex = 5;
            // 
            // lblWalletValue
            // 
            this.lblWalletValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWalletValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWalletValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWalletValue.Location = new System.Drawing.Point(117, 215);
            this.lblWalletValue.Name = "lblWalletValue";
            this.lblWalletValue.Size = new System.Drawing.Size(98, 17);
            this.lblWalletValue.TabIndex = 4;
            this.lblWalletValue.Text = "0 VND";
            this.lblWalletValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWalletLabel
            // 
            this.lblWalletLabel.AutoSize = true;
            this.lblWalletLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblWalletLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblWalletLabel.Location = new System.Drawing.Point(15, 215);
            this.lblWalletLabel.Name = "lblWalletLabel";
            this.lblWalletLabel.Size = new System.Drawing.Size(25, 23);
            this.lblWalletLabel.TabIndex = 3;
            this.lblWalletLabel.Text = "Ví";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator1.Location = new System.Drawing.Point(15, 195);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // lblMemberNameLeft
            // 
            this.lblMemberNameLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberNameLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMemberNameLeft.Location = new System.Drawing.Point(15, 150);
            this.lblMemberNameLeft.Name = "lblMemberNameLeft";
            this.lblMemberNameLeft.Size = new System.Drawing.Size(200, 23);
            this.lblMemberNameLeft.TabIndex = 1;
            this.lblMemberNameLeft.Text = "Pham Tra";
            this.lblMemberNameLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.FillColor = System.Drawing.Color.DarkGray;
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(65, 30);
            this.picProfile.Name = "picProfile";
            this.picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProfile.Size = new System.Drawing.Size(100, 100);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            this.picProfile.UseTransparentBackground = true;
            // 
            // btnNapTien
            // 
            this.btnNapTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNapTien.BorderRadius = 5;
            this.btnNapTien.BorderThickness = 1;
            this.btnNapTien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNapTien.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnNapTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNapTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNapTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNapTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNapTien.FillColor = System.Drawing.Color.White;
            this.btnNapTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNapTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNapTien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnNapTien.Location = new System.Drawing.Point(128, 13);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(112, 40);
            this.btnNapTien.TabIndex = 1;
            this.btnNapTien.Text = "Nạp tiền";
            // 
            // btnTongHop
            // 
            this.btnTongHop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTongHop.BorderRadius = 5;
            this.btnTongHop.BorderThickness = 1;
            this.btnTongHop.Checked = true;
            this.btnTongHop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTongHop.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTongHop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTongHop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTongHop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTongHop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTongHop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTongHop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTongHop.ForeColor = System.Drawing.Color.White;
            this.btnTongHop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnTongHop.Location = new System.Drawing.Point(10, 13);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(112, 40);
            this.btnTongHop.TabIndex = 0;
            this.btnTongHop.Text = "Tổng hợp";
            // 
            // guna2PanelMiddle
            // 
            this.guna2PanelMiddle.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelMiddle.Controls.Add(this.guna2PanelGifts);
            this.guna2PanelMiddle.Controls.Add(this.guna2PanelVouchers);
            this.guna2PanelMiddle.Controls.Add(this.guna2PanelFavFood);
            this.guna2PanelMiddle.Controls.Add(this.btnCloseMemberInfo);
            this.guna2PanelMiddle.Controls.Add(this.lblMemberNameMiddle);
            this.guna2PanelMiddle.Controls.Add(this.picProfileMiddle);
            this.guna2PanelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelMiddle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.guna2PanelMiddle.Location = new System.Drawing.Point(250, 55);
            this.guna2PanelMiddle.Name = "guna2PanelMiddle";
            this.guna2PanelMiddle.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelMiddle.Size = new System.Drawing.Size(782, 665);
            this.guna2PanelMiddle.TabIndex = 4;
            this.guna2PanelMiddle.UseTransparentBackground = true;
            // 
            // guna2PanelGifts
            // 
            this.guna2PanelGifts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelGifts.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelGifts.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelGifts.BorderRadius = 5;
            this.guna2PanelGifts.BorderThickness = 1;
            this.guna2PanelGifts.Controls.Add(this.lblGiftsTitle);
            this.guna2PanelGifts.FillColor = System.Drawing.Color.White;
            this.guna2PanelGifts.Location = new System.Drawing.Point(15, 460);
            this.guna2PanelGifts.Name = "guna2PanelGifts";
            this.guna2PanelGifts.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelGifts.Size = new System.Drawing.Size(752, 190);
            this.guna2PanelGifts.TabIndex = 5;
            this.guna2PanelGifts.UseTransparentBackground = true;
            // 
            // lblGiftsTitle
            // 
            this.lblGiftsTitle.AutoSize = true;
            this.lblGiftsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGiftsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblGiftsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiftsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblGiftsTitle.Name = "lblGiftsTitle";
            this.lblGiftsTitle.Size = new System.Drawing.Size(128, 25);
            this.lblGiftsTitle.TabIndex = 0;
            this.lblGiftsTitle.Text = "Các phần quà";
            // 
            // guna2PanelVouchers
            // 
            this.guna2PanelVouchers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelVouchers.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelVouchers.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelVouchers.BorderRadius = 5;
            this.guna2PanelVouchers.BorderThickness = 1;
            this.guna2PanelVouchers.Controls.Add(this.btnNextVoucher);
            this.guna2PanelVouchers.Controls.Add(this.lblVoucherTitle);
            this.guna2PanelVouchers.FillColor = System.Drawing.Color.White;
            this.guna2PanelVouchers.Location = new System.Drawing.Point(15, 260);
            this.guna2PanelVouchers.Name = "guna2PanelVouchers";
            this.guna2PanelVouchers.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelVouchers.Size = new System.Drawing.Size(752, 190);
            this.guna2PanelVouchers.TabIndex = 4;
            this.guna2PanelVouchers.UseTransparentBackground = true;
            // 
            // btnNextVoucher
            // 
            this.btnNextVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnNextVoucher.CheckedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnNextVoucher.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNextVoucher.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNextVoucher.ImageRotate = 0F;
            this.btnNextVoucher.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextVoucher.Location = new System.Drawing.Point(712, 5);
            this.btnNextVoucher.Name = "btnNextVoucher";
            this.btnNextVoucher.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnNextVoucher.Size = new System.Drawing.Size(30, 30);
            this.btnNextVoucher.TabIndex = 6;
            this.btnNextVoucher.UseTransparentBackground = true;
            // 
            // lblVoucherTitle
            // 
            this.lblVoucherTitle.AutoSize = true;
            this.lblVoucherTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblVoucherTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVoucherTitle.Location = new System.Drawing.Point(15, 10);
            this.lblVoucherTitle.Name = "lblVoucherTitle";
            this.lblVoucherTitle.Size = new System.Drawing.Size(156, 25);
            this.lblVoucherTitle.TabIndex = 0;
            this.lblVoucherTitle.Text = "Voucher đang có";
            // 
            // guna2PanelFavFood
            // 
            this.guna2PanelFavFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelFavFood.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelFavFood.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelFavFood.BorderRadius = 5;
            this.guna2PanelFavFood.BorderThickness = 1;
            this.guna2PanelFavFood.Controls.Add(this.lblNoFavFood);
            this.guna2PanelFavFood.Controls.Add(this.lblFavFoodTitle);
            this.guna2PanelFavFood.FillColor = System.Drawing.Color.White;
            this.guna2PanelFavFood.Location = new System.Drawing.Point(15, 65);
            this.guna2PanelFavFood.Name = "guna2PanelFavFood";
            this.guna2PanelFavFood.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelFavFood.Size = new System.Drawing.Size(752, 185);
            this.guna2PanelFavFood.TabIndex = 3;
            this.guna2PanelFavFood.UseTransparentBackground = true;
            // 
            // lblNoFavFood
            // 
            this.lblNoFavFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoFavFood.BackColor = System.Drawing.Color.Transparent;
            this.lblNoFavFood.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNoFavFood.ForeColor = System.Drawing.Color.Gray;
            this.lblNoFavFood.Location = new System.Drawing.Point(15, 50);
            this.lblNoFavFood.Name = "lblNoFavFood";
            this.lblNoFavFood.Size = new System.Drawing.Size(722, 120);
            this.lblNoFavFood.TabIndex = 1;
            this.lblNoFavFood.Text = "Không có dữ liệu";
            this.lblNoFavFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFavFoodTitle
            // 
            this.lblFavFoodTitle.AutoSize = true;
            this.lblFavFoodTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFavFoodTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblFavFoodTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFavFoodTitle.Location = new System.Drawing.Point(15, 10);
            this.lblFavFoodTitle.Name = "lblFavFoodTitle";
            this.lblFavFoodTitle.Size = new System.Drawing.Size(163, 25);
            this.lblFavFoodTitle.TabIndex = 0;
            this.lblFavFoodTitle.Text = "Món ăn hay dùng";
            // 
            // btnCloseMemberInfo
            // 
            this.btnCloseMemberInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMemberInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseMemberInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnCloseMemberInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCloseMemberInfo.ForeColor = System.Drawing.Color.White;
            this.btnCloseMemberInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnCloseMemberInfo.Location = new System.Drawing.Point(732, 13);
            this.btnCloseMemberInfo.Name = "btnCloseMemberInfo";
            this.btnCloseMemberInfo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloseMemberInfo.Size = new System.Drawing.Size(35, 35);
            this.btnCloseMemberInfo.TabIndex = 2;
            this.btnCloseMemberInfo.Text = "X";
            this.btnCloseMemberInfo.UseTransparentBackground = true;
            // 
            // lblMemberNameMiddle
            // 
            this.lblMemberNameMiddle.AutoSize = true;
            this.lblMemberNameMiddle.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberNameMiddle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMemberNameMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMemberNameMiddle.Location = new System.Drawing.Point(65, 20);
            this.lblMemberNameMiddle.Name = "lblMemberNameMiddle";
            this.lblMemberNameMiddle.Size = new System.Drawing.Size(91, 25);
            this.lblMemberNameMiddle.TabIndex = 1;
            this.lblMemberNameMiddle.Text = "Pham Tra";
            // 
            // picProfileMiddle
            // 
            this.picProfileMiddle.BackColor = System.Drawing.Color.Transparent;
            this.picProfileMiddle.FillColor = System.Drawing.Color.DarkGray;
            this.picProfileMiddle.ImageRotate = 0F;
            this.picProfileMiddle.Location = new System.Drawing.Point(15, 10);
            this.picProfileMiddle.Name = "picProfileMiddle";
            this.picProfileMiddle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProfileMiddle.Size = new System.Drawing.Size(40, 40);
            this.picProfileMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileMiddle.TabIndex = 0;
            this.picProfileMiddle.TabStop = false;
            this.picProfileMiddle.UseTransparentBackground = true;
            // 
            // guna2PanelRight
            // 
            this.guna2PanelRight.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelRight.Controls.Add(this.btnDatMon);
            this.guna2PanelRight.Controls.Add(this.guna2PanelOrderSummary);
            this.guna2PanelRight.Controls.Add(this.btnMangDi);
            this.guna2PanelRight.Controls.Add(this.btnAnTaiBan);
            this.guna2PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PanelRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.guna2PanelRight.Location = new System.Drawing.Point(1032, 55);
            this.guna2PanelRight.Name = "guna2PanelRight";
            this.guna2PanelRight.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelRight.Size = new System.Drawing.Size(270, 665);
            this.guna2PanelRight.TabIndex = 5;
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
            this.btnDatMon.Location = new System.Drawing.Point(13, 597);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(244, 55);
            this.btnDatMon.TabIndex = 3;
            this.btnDatMon.Text = "ĐẶT MÓN";
            // 
            // guna2PanelOrderSummary
            // 
            this.guna2PanelOrderSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.guna2PanelOrderSummary.Controls.Add(this.lblTableValue);
            this.guna2PanelOrderSummary.Controls.Add(this.lblItemsLabel);
            this.guna2PanelOrderSummary.FillColor = System.Drawing.Color.White;
            this.guna2PanelOrderSummary.Location = new System.Drawing.Point(10, 65);
            this.guna2PanelOrderSummary.Name = "guna2PanelOrderSummary";
            this.guna2PanelOrderSummary.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelOrderSummary.Size = new System.Drawing.Size(250, 520);
            this.guna2PanelOrderSummary.TabIndex = 2;
            this.guna2PanelOrderSummary.UseTransparentBackground = true;
            // 
            // lblTotalPaymentValue
            // 
            this.lblTotalPaymentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPaymentValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPaymentValue.Location = new System.Drawing.Point(97, 160);
            this.lblTotalPaymentValue.Name = "lblTotalPaymentValue";
            this.lblTotalPaymentValue.Size = new System.Drawing.Size(140, 20);
            this.lblTotalPaymentValue.TabIndex = 10;
            this.lblTotalPaymentValue.Text = "0 VND";
            this.lblTotalPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPaymentLabel
            // 
            this.lblTotalPaymentLabel.AutoSize = true;
            this.lblTotalPaymentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPaymentLabel.Location = new System.Drawing.Point(15, 160);
            this.lblTotalPaymentLabel.Name = "lblTotalPaymentLabel";
            this.lblTotalPaymentLabel.Size = new System.Drawing.Size(113, 25);
            this.lblTotalPaymentLabel.TabIndex = 9;
            this.lblTotalPaymentLabel.Text = "Thanh toán";
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator6.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator6.Location = new System.Drawing.Point(15, 140);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(220, 10);
            this.guna2Separator6.TabIndex = 8;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiscountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscountValue.Location = new System.Drawing.Point(137, 110);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(100, 17);
            this.lblDiscountValue.TabIndex = 7;
            this.lblDiscountValue.Text = "0";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountLabel
            // 
            this.lblDiscountLabel.AutoSize = true;
            this.lblDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDiscountLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblDiscountLabel.Location = new System.Drawing.Point(15, 110);
            this.lblDiscountLabel.Name = "lblDiscountLabel";
            this.lblDiscountLabel.Size = new System.Drawing.Size(78, 23);
            this.lblDiscountLabel.TabIndex = 6;
            this.lblDiscountLabel.Text = "Giảm giá";
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator5.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator5.Location = new System.Drawing.Point(15, 90);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(220, 10);
            this.guna2Separator5.TabIndex = 5;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(107, 60);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(130, 17);
            this.lblTotalAmountValue.TabIndex = 4;
            this.lblTotalAmountValue.Text = "0 VND";
            this.lblTotalAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountLabel
            // 
            this.lblTotalAmountLabel.AutoSize = true;
            this.lblTotalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTotalAmountLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalAmountLabel.Location = new System.Drawing.Point(15, 60);
            this.lblTotalAmountLabel.Name = "lblTotalAmountLabel";
            this.lblTotalAmountLabel.Size = new System.Drawing.Size(83, 23);
            this.lblTotalAmountLabel.TabIndex = 3;
            this.lblTotalAmountLabel.Text = "Tổng tiền";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator4.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator4.Location = new System.Drawing.Point(15, 40);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(220, 10);
            this.guna2Separator4.TabIndex = 2;
            // 
            // lblTableValue
            // 
            this.lblTableValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTableValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTableValue.Location = new System.Drawing.Point(137, 15);
            this.lblTableValue.Name = "lblTableValue";
            this.lblTableValue.Size = new System.Drawing.Size(100, 17);
            this.lblTableValue.TabIndex = 1;
            this.lblTableValue.Text = "Bàn";
            this.lblTableValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemsLabel
            // 
            this.lblItemsLabel.AutoSize = true;
            this.lblItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblItemsLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblItemsLabel.Location = new System.Drawing.Point(15, 15);
            this.lblItemsLabel.Name = "lblItemsLabel";
            this.lblItemsLabel.Size = new System.Drawing.Size(45, 23);
            this.lblItemsLabel.TabIndex = 0;
            this.lblItemsLabel.Text = "món";
            // 
            // btnMangDi
            // 
            this.btnMangDi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMangDi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnMangDi.BorderRadius = 5;
            this.btnMangDi.BorderThickness = 1;
            this.btnMangDi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnMangDi.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnMangDi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMangDi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMangDi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMangDi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMangDi.FillColor = System.Drawing.Color.White;
            this.btnMangDi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMangDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnMangDi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnMangDi.Location = new System.Drawing.Point(138, 13);
            this.btnMangDi.Name = "btnMangDi";
            this.btnMangDi.Size = new System.Drawing.Size(122, 40);
            this.btnMangDi.TabIndex = 1;
            this.btnMangDi.Text = "Mang đi";
            // 
            // btnAnTaiBan
            // 
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
            this.btnAnTaiBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnTaiBan.ForeColor = System.Drawing.Color.White;
            this.btnAnTaiBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnAnTaiBan.Location = new System.Drawing.Point(10, 13);
            this.btnAnTaiBan.Name = "btnAnTaiBan";
            this.btnAnTaiBan.Size = new System.Drawing.Size(122, 40);
            this.btnAnTaiBan.TabIndex = 0;
            this.btnAnTaiBan.Text = "Ăn tại bàn";
            // 
            // btnRegister
            // 
            this.btnRegister.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRegister.BorderRadius = 8;
            this.btnRegister.BorderThickness = 1;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.FillColor = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegister.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnRegister.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnRegister.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRegister.Location = new System.Drawing.Point(784, 8);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 40);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.TextOffset = new System.Drawing.Point(0, 8);
            // 
            // FormThongTinTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.guna2PanelMiddle);
            this.Controls.Add(this.guna2PanelRight);
            this.Controls.Add(this.guna2PanelLeft);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormThongTinTV";
            this.Size = new System.Drawing.Size(1302, 720);
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelLeft.ResumeLayout(false);
            this.guna2PanelProfile.ResumeLayout(false);
            this.guna2PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.guna2PanelMiddle.ResumeLayout(false);
            this.guna2PanelMiddle.PerformLayout();
            this.guna2PanelGifts.ResumeLayout(false);
            this.guna2PanelGifts.PerformLayout();
            this.guna2PanelVouchers.ResumeLayout(false);
            this.guna2PanelVouchers.PerformLayout();
            this.guna2PanelFavFood.ResumeLayout(false);
            this.guna2PanelFavFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileMiddle)).EndInit();
            this.guna2PanelRight.ResumeLayout(false);
            this.guna2PanelOrderSummary.ResumeLayout(false);
            this.guna2PanelOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMember;
        private Guna.UI2.WinForms.Guna2Button btnQuickSearch;
        private Guna.UI2.WinForms.Guna2Button btnScanQR;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonMemberInfo;
        private Guna.UI2.WinForms.Guna2Button btnNoteMember;      // Changed type
        private Guna.UI2.WinForms.Guna2Button btnDiscountMember;  // Changed type
        private Guna.UI2.WinForms.Guna2Button btnDeleteMember;    // Changed type
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLeft;
        private Guna.UI2.WinForms.Guna2Button btnTongHop;
        private Guna.UI2.WinForms.Guna2Button btnNapTien;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelProfile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
        private System.Windows.Forms.Label lblMemberNameLeft;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblWalletValue;
        private System.Windows.Forms.Label lblWalletLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label lblPointsValue;
        private System.Windows.Forms.Label lblPointsLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label lblLevelValue;
        private System.Windows.Forms.Label lblLevelLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtMemberNote;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMiddle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelRight;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picProfileMiddle;
        private System.Windows.Forms.Label lblMemberNameMiddle;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloseMemberInfo;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelFavFood;
        private System.Windows.Forms.Label lblFavFoodTitle;
        private System.Windows.Forms.Label lblNoFavFood;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelVouchers;
        private System.Windows.Forms.Label lblVoucherTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnNextVoucher;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelGifts;
        private System.Windows.Forms.Label lblGiftsTitle;
        private Guna.UI2.WinForms.Guna2Button btnAnTaiBan;
        private Guna.UI2.WinForms.Guna2Button btnMangDi;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelOrderSummary;
        private System.Windows.Forms.Label lblItemsLabel;
        private System.Windows.Forms.Label lblTableValue;
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
        private Guna2Button btnRegister;
    }
}