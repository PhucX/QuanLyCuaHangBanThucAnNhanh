// FormMember.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PanelTabs = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTabIndicator = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTabVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnTabThanhVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelGridContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemMoiMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuiVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelSummaryCards = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelSummaryCards = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PanelCard1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCard1Text = new System.Windows.Forms.Label();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.guna2PanelCard2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCard2Text = new System.Windows.Forms.Label();
            this.picCard2Icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelCard5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCard5Text = new System.Windows.Forms.Label();
            this.picCard5Icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelCard3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCard3Text = new System.Windows.Forms.Label();
            this.picCard3Icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelCard4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCard4Text = new System.Windows.Forms.Label();
            this.picCard4Icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvMembers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanMucThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacVuCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2PanelTabs.SuspendLayout();
            this.guna2PanelGridContainer.SuspendLayout();
            this.guna2PanelSummaryCards.SuspendLayout();
            this.flowLayoutPanelSummaryCards.SuspendLayout();
            this.guna2PanelCard1.SuspendLayout();
            this.guna2PanelCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2Icon)).BeginInit();
            this.guna2PanelCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5Icon)).BeginInit();
            this.guna2PanelCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3Icon)).BeginInit();
            this.guna2PanelCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelTabs
            // 
            this.guna2PanelTabs.Controls.Add(this.panelTabIndicator);
            this.guna2PanelTabs.Controls.Add(this.btnTabVoucher);
            this.guna2PanelTabs.Controls.Add(this.btnTabThanhVien);
            this.guna2PanelTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTabs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelTabs.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTabs.Name = "guna2PanelTabs";
            this.guna2PanelTabs.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.guna2PanelTabs.Size = new System.Drawing.Size(1080, 50);
            this.guna2PanelTabs.TabIndex = 3;
            // 
            // panelTabIndicator
            // 
            this.panelTabIndicator.BackColor = System.Drawing.Color.White;
            this.panelTabIndicator.Location = new System.Drawing.Point(15, 47);
            this.panelTabIndicator.Name = "panelTabIndicator";
            this.panelTabIndicator.Size = new System.Drawing.Size(120, 3);
            this.panelTabIndicator.TabIndex = 3;
            // 
            // btnTabVoucher
            // 
            this.btnTabVoucher.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTabVoucher.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnTabVoucher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTabVoucher.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTabVoucher.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTabVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTabVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTabVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTabVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTabVoucher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTabVoucher.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(203)))));
            this.btnTabVoucher.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnTabVoucher.Location = new System.Drawing.Point(183, 0);
            this.btnTabVoucher.Name = "btnTabVoucher";
            this.btnTabVoucher.Size = new System.Drawing.Size(130, 47);
            this.btnTabVoucher.TabIndex = 1;
            this.btnTabVoucher.Text = "VOUCHER";
            // 
            // btnTabThanhVien
            // 
            this.btnTabThanhVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTabThanhVien.Checked = true;
            this.btnTabThanhVien.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnTabThanhVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTabThanhVien.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTabThanhVien.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTabThanhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTabThanhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTabThanhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTabThanhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTabThanhVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTabThanhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabThanhVien.ForeColor = System.Drawing.Color.White;
            this.btnTabThanhVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnTabThanhVien.Location = new System.Drawing.Point(15, 0);
            this.btnTabThanhVien.Name = "btnTabThanhVien";
            this.btnTabThanhVien.Size = new System.Drawing.Size(153, 47);
            this.btnTabThanhVien.TabIndex = 0;
            this.btnTabThanhVien.Text = "THÀNH VIÊN";
            // 
            // guna2PanelGridContainer
            // 
            this.guna2PanelGridContainer.Controls.Add(this.btnThemMoiMember);
            this.guna2PanelGridContainer.Controls.Add(this.btnGuiVoucher);
            this.guna2PanelGridContainer.Controls.Add(this.guna2PanelSummaryCards);
            this.guna2PanelGridContainer.Controls.Add(this.dgvMembers);
            this.guna2PanelGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelGridContainer.Location = new System.Drawing.Point(0, 50);
            this.guna2PanelGridContainer.Name = "guna2PanelGridContainer";
            this.guna2PanelGridContainer.Padding = new System.Windows.Forms.Padding(20);
            this.guna2PanelGridContainer.Size = new System.Drawing.Size(1080, 580);
            this.guna2PanelGridContainer.TabIndex = 4;
            // 
            // btnThemMoiMember
            // 
            this.btnThemMoiMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoiMember.BorderRadius = 5;
            this.btnThemMoiMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnThemMoiMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemMoiMember.ForeColor = System.Drawing.Color.White;
            this.btnThemMoiMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemMoiMember.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnThemMoiMember.Location = new System.Drawing.Point(920, 525);
            this.btnThemMoiMember.Name = "btnThemMoiMember";
            this.btnThemMoiMember.Size = new System.Drawing.Size(130, 36);
            this.btnThemMoiMember.TabIndex = 6;
            this.btnThemMoiMember.Text = "+ THÊM MỚI";
            this.btnThemMoiMember.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btnGuiVoucher
            // 
            this.btnGuiVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuiVoucher.BorderRadius = 5;
            this.btnGuiVoucher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGuiVoucher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuiVoucher.ForeColor = System.Drawing.Color.White;
            this.btnGuiVoucher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuiVoucher.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnGuiVoucher.Location = new System.Drawing.Point(735, 525);
            this.btnGuiVoucher.Name = "btnGuiVoucher";
            this.btnGuiVoucher.Size = new System.Drawing.Size(153, 36);
            this.btnGuiVoucher.TabIndex = 5;
            this.btnGuiVoucher.Text = "GỬI VOUCHER";
            this.btnGuiVoucher.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2PanelSummaryCards
            // 
            this.guna2PanelSummaryCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelSummaryCards.Controls.Add(this.flowLayoutPanelSummaryCards);
            this.guna2PanelSummaryCards.FillColor = System.Drawing.Color.Transparent;
            this.guna2PanelSummaryCards.Location = new System.Drawing.Point(20, 399);
            this.guna2PanelSummaryCards.Name = "guna2PanelSummaryCards";
            this.guna2PanelSummaryCards.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.guna2PanelSummaryCards.Size = new System.Drawing.Size(1030, 120);
            this.guna2PanelSummaryCards.TabIndex = 7;
            // 
            // flowLayoutPanelSummaryCards
            // 
            this.flowLayoutPanelSummaryCards.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelSummaryCards.Controls.Add(this.guna2PanelCard1);
            this.flowLayoutPanelSummaryCards.Controls.Add(this.guna2PanelCard2);
            this.flowLayoutPanelSummaryCards.Controls.Add(this.guna2PanelCard5);
            this.flowLayoutPanelSummaryCards.Controls.Add(this.guna2PanelCard3);
            this.flowLayoutPanelSummaryCards.Controls.Add(this.guna2PanelCard4);
            this.flowLayoutPanelSummaryCards.Location = new System.Drawing.Point(0, 10);
            this.flowLayoutPanelSummaryCards.Name = "flowLayoutPanelSummaryCards";
            this.flowLayoutPanelSummaryCards.Size = new System.Drawing.Size(1030, 100);
            this.flowLayoutPanelSummaryCards.TabIndex = 0;
            // 
            // guna2PanelCard1
            // 
            this.guna2PanelCard1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard1.BorderRadius = 8;
            this.guna2PanelCard1.Controls.Add(this.lblCard1Text);
            this.guna2PanelCard1.Controls.Add(this.lblCard1Value);
            this.guna2PanelCard1.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard1.Location = new System.Drawing.Point(10, 3);
            this.guna2PanelCard1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.guna2PanelCard1.Name = "guna2PanelCard1";
            this.guna2PanelCard1.Size = new System.Drawing.Size(230, 94);
            this.guna2PanelCard1.TabIndex = 0;
            // 
            // lblCard1Text
            // 
            this.lblCard1Text.AutoSize = true;
            this.lblCard1Text.Location = new System.Drawing.Point(15, 55);
            this.lblCard1Text.Name = "lblCard1Text";
            this.lblCard1Text.Size = new System.Drawing.Size(76, 19);
            this.lblCard1Text.TabIndex = 0;
            this.lblCard1Text.Text = "Thành viên";
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.AutoSize = true;
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.Location = new System.Drawing.Point(15, 15);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(69, 41);
            this.lblCard1Value.TabIndex = 1;
            this.lblCard1Value.Text = "137";
            // 
            // guna2PanelCard2
            // 
            this.guna2PanelCard2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard2.BorderRadius = 8;
            this.guna2PanelCard2.Controls.Add(this.lblCard2Text);
            this.guna2PanelCard2.Controls.Add(this.picCard2Icon);
            this.guna2PanelCard2.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard2.Location = new System.Drawing.Point(253, 3);
            this.guna2PanelCard2.Name = "guna2PanelCard2";
            this.guna2PanelCard2.Size = new System.Drawing.Size(251, 94);
            this.guna2PanelCard2.TabIndex = 1;
            // 
            // lblCard2Text
            // 
            this.lblCard2Text.AutoSize = true;
            this.lblCard2Text.Location = new System.Drawing.Point(60, 35);
            this.lblCard2Text.Name = "lblCard2Text";
            this.lblCard2Text.Size = new System.Drawing.Size(162, 19);
            this.lblCard2Text.TabIndex = 0;
            this.lblCard2Text.Text = "WELCOME: 2 Thành viên";
            // 
            // picCard2Icon
            // 
            this.picCard2Icon.ImageRotate = 0F;
            this.picCard2Icon.Location = new System.Drawing.Point(15, 30);
            this.picCard2Icon.Name = "picCard2Icon";
            this.picCard2Icon.Size = new System.Drawing.Size(30, 30);
            this.picCard2Icon.TabIndex = 1;
            this.picCard2Icon.TabStop = false;
            // 
            // guna2PanelCard5
            // 
            this.guna2PanelCard5.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard5.BorderRadius = 8;
            this.guna2PanelCard5.Controls.Add(this.lblCard5Text);
            this.guna2PanelCard5.Controls.Add(this.picCard5Icon);
            this.guna2PanelCard5.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard5.Location = new System.Drawing.Point(510, 3);
            this.guna2PanelCard5.Name = "guna2PanelCard5";
            this.guna2PanelCard5.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelCard5.ShadowDecoration.Enabled = true;
            this.guna2PanelCard5.Size = new System.Drawing.Size(251, 94);
            this.guna2PanelCard5.TabIndex = 4;
            // 
            // lblCard5Text
            // 
            this.lblCard5Text.AutoSize = true;
            this.lblCard5Text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard5Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCard5Text.Location = new System.Drawing.Point(60, 35);
            this.lblCard5Text.Name = "lblCard5Text";
            this.lblCard5Text.Size = new System.Drawing.Size(159, 20);
            this.lblCard5Text.TabIndex = 1;
            this.lblCard5Text.Text = "HOMMIE: 1 Thành viên";
            // 
            // picCard5Icon
            // 
            this.picCard5Icon.ImageRotate = 0F;
            this.picCard5Icon.Location = new System.Drawing.Point(15, 30);
            this.picCard5Icon.Name = "picCard5Icon";
            this.picCard5Icon.Size = new System.Drawing.Size(30, 30);
            this.picCard5Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard5Icon.TabIndex = 0;
            this.picCard5Icon.TabStop = false;
            // 
            // guna2PanelCard3
            // 
            this.guna2PanelCard3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard3.BorderRadius = 8;
            this.guna2PanelCard3.Controls.Add(this.lblCard3Text);
            this.guna2PanelCard3.Controls.Add(this.picCard3Icon);
            this.guna2PanelCard3.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard3.Location = new System.Drawing.Point(767, 3);
            this.guna2PanelCard3.Name = "guna2PanelCard3";
            this.guna2PanelCard3.Size = new System.Drawing.Size(251, 94);
            this.guna2PanelCard3.TabIndex = 2;
            // 
            // lblCard3Text
            // 
            this.lblCard3Text.AutoSize = true;
            this.lblCard3Text.Location = new System.Drawing.Point(60, 35);
            this.lblCard3Text.Name = "lblCard3Text";
            this.lblCard3Text.Size = new System.Drawing.Size(172, 19);
            this.lblCard3Text.TabIndex = 0;
            this.lblCard3Text.Text = "Laha Loyalty: 1 Thành viên";
            // 
            // picCard3Icon
            // 
            this.picCard3Icon.ImageRotate = 0F;
            this.picCard3Icon.Location = new System.Drawing.Point(15, 30);
            this.picCard3Icon.Name = "picCard3Icon";
            this.picCard3Icon.Size = new System.Drawing.Size(30, 30);
            this.picCard3Icon.TabIndex = 1;
            this.picCard3Icon.TabStop = false;
            // 
            // guna2PanelCard4
            // 
            this.guna2PanelCard4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard4.BorderRadius = 8;
            this.guna2PanelCard4.Controls.Add(this.lblCard4Text);
            this.guna2PanelCard4.Controls.Add(this.picCard4Icon);
            this.guna2PanelCard4.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard4.Location = new System.Drawing.Point(3, 103);
            this.guna2PanelCard4.Name = "guna2PanelCard4";
            this.guna2PanelCard4.Size = new System.Drawing.Size(252, 94);
            this.guna2PanelCard4.TabIndex = 3;
            // 
            // lblCard4Text
            // 
            this.lblCard4Text.AutoSize = true;
            this.lblCard4Text.Location = new System.Drawing.Point(60, 35);
            this.lblCard4Text.Name = "lblCard4Text";
            this.lblCard4Text.Size = new System.Drawing.Size(141, 19);
            this.lblCard4Text.TabIndex = 0;
            this.lblCard4Text.Text = "FRIEND: 3 Thành viên";
            // 
            // picCard4Icon
            // 
            this.picCard4Icon.ImageRotate = 0F;
            this.picCard4Icon.Location = new System.Drawing.Point(15, 30);
            this.picCard4Icon.Name = "picCard4Icon";
            this.picCard4Icon.Size = new System.Drawing.Size(30, 30);
            this.picCard4Icon.TabIndex = 1;
            this.picCard4Icon.TabStop = false;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMembers.ColumnHeadersHeight = 45;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colMaTV,
            this.colEmail,
            this.colSDT,
            this.colHanMucThe,
            this.colDiem,
            this.colDiaChi,
            this.colDiaChiLamViec,
            this.colTrangThai,
            this.colTacVuCapNhat});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembers.Location = new System.Drawing.Point(20, 20);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 60;
            this.dgvMembers.Size = new System.Drawing.Size(1030, 373);
            this.dgvMembers.TabIndex = 0;
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMembers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMembers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvMembers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvMembers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvMembers.ThemeStyle.ReadOnly = true;
            this.dgvMembers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMembers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvMembers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMembers.ThemeStyle.RowsStyle.Height = 60;
            this.dgvMembers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.FillWeight = 30F;
            this.colSTT.HeaderText = "#";
            this.colSTT.MinimumWidth = 40;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 40;
            // 
            // colHoTen
            // 
            this.colHoTen.FillWeight = 120F;
            this.colHoTen.HeaderText = "HỌ TÊN";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FillWeight = 60F;
            this.colGioiTinh.HeaderText = "GIỚI TÍNH";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FillWeight = 90F;
            this.colNgaySinh.HeaderText = "NGÀY SINH";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            // 
            // colMaTV
            // 
            this.colMaTV.FillWeight = 90F;
            this.colMaTV.HeaderText = "MÃ THÀNH VIÊN";
            this.colMaTV.MinimumWidth = 6;
            this.colMaTV.Name = "colMaTV";
            this.colMaTV.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.FillWeight = 110F;
            this.colEmail.HeaderText = "EMAIL";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SỐ ĐIỆN THOẠI";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colHanMucThe
            // 
            this.colHanMucThe.HeaderText = "HẠN MỨC THẺ";
            this.colHanMucThe.MinimumWidth = 6;
            this.colHanMucThe.Name = "colHanMucThe";
            this.colHanMucThe.ReadOnly = true;
            // 
            // colDiem
            // 
            this.colDiem.FillWeight = 50F;
            this.colDiem.HeaderText = "ĐIỂM";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FillWeight = 130F;
            this.colDiaChi.HeaderText = "ĐỊA CHỈ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colDiaChiLamViec
            // 
            this.colDiaChiLamViec.FillWeight = 130F;
            this.colDiaChiLamViec.HeaderText = "ĐỊA CHỈ NƠI LÀM VIỆC";
            this.colDiaChiLamViec.MinimumWidth = 6;
            this.colDiaChiLamViec.Name = "colDiaChiLamViec";
            this.colDiaChiLamViec.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FillWeight = 80F;
            this.colTrangThai.HeaderText = "TRẠNG THÁI";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colTacVuCapNhat
            // 
            this.colTacVuCapNhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTacVuCapNhat.FillWeight = 80F;
            this.colTacVuCapNhat.HeaderText = "Cập nhật";
            this.colTacVuCapNhat.MinimumWidth = 80;
            this.colTacVuCapNhat.Name = "colTacVuCapNhat";
            this.colTacVuCapNhat.ReadOnly = true;
            this.colTacVuCapNhat.Width = 80;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelGridContainer);
            this.Controls.Add(this.guna2PanelTabs);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMember";
            this.Size = new System.Drawing.Size(1080, 630);
            this.guna2PanelTabs.ResumeLayout(false);
            this.guna2PanelGridContainer.ResumeLayout(false);
            this.guna2PanelSummaryCards.ResumeLayout(false);
            this.flowLayoutPanelSummaryCards.ResumeLayout(false);
            this.guna2PanelCard1.ResumeLayout(false);
            this.guna2PanelCard1.PerformLayout();
            this.guna2PanelCard2.ResumeLayout(false);
            this.guna2PanelCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2Icon)).EndInit();
            this.guna2PanelCard5.ResumeLayout(false);
            this.guna2PanelCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5Icon)).EndInit();
            this.guna2PanelCard3.ResumeLayout(false);
            this.guna2PanelCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3Icon)).EndInit();
            this.guna2PanelCard4.ResumeLayout(false);
            this.guna2PanelCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTabs;
        private Guna.UI2.WinForms.Guna2Button btnTabThanhVien;
        private Guna.UI2.WinForms.Guna2Button btnTabVoucher;
        private Guna.UI2.WinForms.Guna2Panel panelTabIndicator;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelGridContainer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMembers;
        //private System.Windows.Forms.DataGridViewTextBoxColumn colTacVuDieuChinh;
        private Guna2Button btnThemMoiMember;
        private Guna2Button btnGuiVoucher;
        private Guna2Panel guna2PanelSummaryCards;
        private FlowLayoutPanel flowLayoutPanelSummaryCards;
        private Guna2Panel guna2PanelCard1;
        private Label lblCard1Text;
        private Label lblCard1Value;
        private Guna2Panel guna2PanelCard2;
        private Label lblCard2Text;
        private Guna2PictureBox picCard2Icon;
        private Guna2Panel guna2PanelCard5;
        private Label lblCard5Text;
        private Guna2PictureBox picCard5Icon;
        private Guna2Panel guna2PanelCard3;
        private Label lblCard3Text;
        private Guna2PictureBox picCard3Icon;
        private Guna2Panel guna2PanelCard4;
        private Label lblCard4Text;
        private Guna2PictureBox picCard4Icon;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colMaTV;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colHanMucThe;
        private DataGridViewTextBoxColumn colDiem;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colDiaChiLamViec;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colTacVuCapNhat;
    }
}