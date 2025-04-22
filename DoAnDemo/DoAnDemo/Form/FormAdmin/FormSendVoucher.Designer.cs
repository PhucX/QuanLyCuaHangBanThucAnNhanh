// FormSendVoucher.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

// Namespace theo yêu cầu
namespace DoAnDemo.Form.FormAdmin
{
    partial class FormSendVoucher
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2PanelVoucherSelection = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvVouchersToSend = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colChonVoucher = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMaVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVoucherSelectionTitle = new System.Windows.Forms.Label();
            this.guna2PanelRecipientSelection = new Guna.UI2.WinForms.Guna2Panel();
            this.txtThanhVienCuThe = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbThanhVienCuThe = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cboNhomThanhVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rbNhomThanhVien = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblRecipientSelectionTitle = new System.Windows.Forms.Label();
            this.guna2PanelActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelVoucherSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchersToSend)).BeginInit();
            this.guna2PanelRecipientSelection.SuspendLayout();
            this.guna2PanelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GỬI VOUCHER CHO THÀNH VIÊN";
            // 
            // guna2PanelVoucherSelection
            // 
            this.guna2PanelVoucherSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelVoucherSelection.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelVoucherSelection.BorderRadius = 5;
            this.guna2PanelVoucherSelection.BorderThickness = 1;
            this.guna2PanelVoucherSelection.Controls.Add(this.dgvVouchersToSend);
            this.guna2PanelVoucherSelection.Controls.Add(this.lblVoucherSelectionTitle);
            this.guna2PanelVoucherSelection.FillColor = System.Drawing.Color.White;
            this.guna2PanelVoucherSelection.Location = new System.Drawing.Point(25, 55);
            this.guna2PanelVoucherSelection.Name = "guna2PanelVoucherSelection";
            this.guna2PanelVoucherSelection.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelVoucherSelection.Size = new System.Drawing.Size(650, 495);
            this.guna2PanelVoucherSelection.TabIndex = 1;
            // 
            // dgvVouchersToSend
            // 
            this.dgvVouchersToSend.AllowUserToAddRows = false;
            this.dgvVouchersToSend.AllowUserToDeleteRows = false;
            this.dgvVouchersToSend.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVouchersToSend.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVouchersToSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVouchersToSend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVouchersToSend.ColumnHeadersHeight = 28;
            this.dgvVouchersToSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChonVoucher,
            this.colMaVoucher,
            this.colTenVoucher,
            this.colGiaTri,
            this.colNgayHetHan});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVouchersToSend.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVouchersToSend.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVouchersToSend.Location = new System.Drawing.Point(13, 43);
            this.dgvVouchersToSend.MultiSelect = false;
            this.dgvVouchersToSend.Name = "dgvVouchersToSend";
            this.dgvVouchersToSend.RowHeadersVisible = false;
            this.dgvVouchersToSend.RowHeadersWidth = 51;
            this.dgvVouchersToSend.RowTemplate.Height = 26;
            this.dgvVouchersToSend.Size = new System.Drawing.Size(624, 439);
            this.dgvVouchersToSend.TabIndex = 1;
            this.dgvVouchersToSend.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVouchersToSend.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVouchersToSend.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVouchersToSend.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVouchersToSend.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVouchersToSend.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVouchersToSend.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVouchersToSend.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVouchersToSend.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVouchersToSend.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvVouchersToSend.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVouchersToSend.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVouchersToSend.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvVouchersToSend.ThemeStyle.ReadOnly = false;
            this.dgvVouchersToSend.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVouchersToSend.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVouchersToSend.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvVouchersToSend.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVouchersToSend.ThemeStyle.RowsStyle.Height = 26;
            this.dgvVouchersToSend.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVouchersToSend.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colChonVoucher
            // 
            this.colChonVoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colChonVoucher.FillWeight = 40F;
            this.colChonVoucher.HeaderText = "";
            this.colChonVoucher.MinimumWidth = 40;
            this.colChonVoucher.Name = "colChonVoucher";
            this.colChonVoucher.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChonVoucher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colChonVoucher.Width = 40;
            // 
            // colMaVoucher
            // 
            this.colMaVoucher.FillWeight = 80F;
            this.colMaVoucher.HeaderText = "Mã Voucher";
            this.colMaVoucher.MinimumWidth = 6;
            this.colMaVoucher.Name = "colMaVoucher";
            this.colMaVoucher.ReadOnly = true;
            // 
            // colTenVoucher
            // 
            this.colTenVoucher.FillWeight = 150F;
            this.colTenVoucher.HeaderText = "Tên Voucher";
            this.colTenVoucher.MinimumWidth = 6;
            this.colTenVoucher.Name = "colTenVoucher";
            this.colTenVoucher.ReadOnly = true;
            // 
            // colGiaTri
            // 
            this.colGiaTri.FillWeight = 80F;
            this.colGiaTri.HeaderText = "Giá trị";
            this.colGiaTri.MinimumWidth = 6;
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.ReadOnly = true;
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.HeaderText = "Ngày hết hạn";
            this.colNgayHetHan.MinimumWidth = 6;
            this.colNgayHetHan.Name = "colNgayHetHan";
            this.colNgayHetHan.ReadOnly = true;
            // 
            // lblVoucherSelectionTitle
            // 
            this.lblVoucherSelectionTitle.AutoSize = true;
            this.lblVoucherSelectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherSelectionTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVoucherSelectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVoucherSelectionTitle.Location = new System.Drawing.Point(13, 10);
            this.lblVoucherSelectionTitle.Name = "lblVoucherSelectionTitle";
            this.lblVoucherSelectionTitle.Size = new System.Drawing.Size(200, 25);
            this.lblVoucherSelectionTitle.TabIndex = 0;
            this.lblVoucherSelectionTitle.Text = "Chọn Voucher để gửi";
            // 
            // guna2PanelRecipientSelection
            // 
            this.guna2PanelRecipientSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelRecipientSelection.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelRecipientSelection.BorderRadius = 5;
            this.guna2PanelRecipientSelection.BorderThickness = 1;
            this.guna2PanelRecipientSelection.Controls.Add(this.txtThanhVienCuThe);
            this.guna2PanelRecipientSelection.Controls.Add(this.rbThanhVienCuThe);
            this.guna2PanelRecipientSelection.Controls.Add(this.cboNhomThanhVien);
            this.guna2PanelRecipientSelection.Controls.Add(this.rbNhomThanhVien);
            this.guna2PanelRecipientSelection.Controls.Add(this.lblRecipientSelectionTitle);
            this.guna2PanelRecipientSelection.FillColor = System.Drawing.Color.White;
            this.guna2PanelRecipientSelection.Location = new System.Drawing.Point(690, 55);
            this.guna2PanelRecipientSelection.Name = "guna2PanelRecipientSelection";
            this.guna2PanelRecipientSelection.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelRecipientSelection.Size = new System.Drawing.Size(365, 495);
            this.guna2PanelRecipientSelection.TabIndex = 2;
            // 
            // txtThanhVienCuThe
            // 
            this.txtThanhVienCuThe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhVienCuThe.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtThanhVienCuThe.BorderRadius = 5;
            this.txtThanhVienCuThe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhVienCuThe.DefaultText = "";
            this.txtThanhVienCuThe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhVienCuThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhVienCuThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhVienCuThe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhVienCuThe.Enabled = false;
            this.txtThanhVienCuThe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhVienCuThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThanhVienCuThe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhVienCuThe.Location = new System.Drawing.Point(35, 145);
            this.txtThanhVienCuThe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhVienCuThe.Multiline = true;
            this.txtThanhVienCuThe.Name = "txtThanhVienCuThe";
            this.txtThanhVienCuThe.PlaceholderText = "Nhập Mã TV hoặc SĐT, cách nhau bởi dấu phẩy hoặc xuống dòng";
            this.txtThanhVienCuThe.SelectedText = "";
            this.txtThanhVienCuThe.Size = new System.Drawing.Size(317, 90);
            this.txtThanhVienCuThe.TabIndex = 4;
            // 
            // rbThanhVienCuThe
            // 
            this.rbThanhVienCuThe.AutoSize = true;
            this.rbThanhVienCuThe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbThanhVienCuThe.CheckedState.BorderThickness = 0;
            this.rbThanhVienCuThe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbThanhVienCuThe.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbThanhVienCuThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbThanhVienCuThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbThanhVienCuThe.Location = new System.Drawing.Point(15, 120);
            this.rbThanhVienCuThe.Name = "rbThanhVienCuThe";
            this.rbThanhVienCuThe.Size = new System.Drawing.Size(145, 24);
            this.rbThanhVienCuThe.TabIndex = 3;
            this.rbThanhVienCuThe.Text = "Thành viên cụ thể";
            this.rbThanhVienCuThe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbThanhVienCuThe.UncheckedState.BorderThickness = 2;
            this.rbThanhVienCuThe.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbThanhVienCuThe.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbThanhVienCuThe.UseVisualStyleBackColor = true;
            // 
            // cboNhomThanhVien
            // 
            this.cboNhomThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhomThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.cboNhomThanhVien.BorderColor = System.Drawing.Color.Gainsboro;
            this.cboNhomThanhVien.BorderRadius = 5;
            this.cboNhomThanhVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhomThanhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomThanhVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhomThanhVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhomThanhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhomThanhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNhomThanhVien.ItemHeight = 30;
            this.cboNhomThanhVien.Items.AddRange(new object[] {
            "WELCOME",
            "Laha Loyalty",
            "FRIEND",
            "HOMMIE"});
            this.cboNhomThanhVien.Location = new System.Drawing.Point(35, 75);
            this.cboNhomThanhVien.Name = "cboNhomThanhVien";
            this.cboNhomThanhVien.Size = new System.Drawing.Size(317, 36);
            this.cboNhomThanhVien.TabIndex = 2;
            // 
            // rbNhomThanhVien
            // 
            this.rbNhomThanhVien.AutoSize = true;
            this.rbNhomThanhVien.Checked = true;
            this.rbNhomThanhVien.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNhomThanhVien.CheckedState.BorderThickness = 0;
            this.rbNhomThanhVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNhomThanhVien.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNhomThanhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbNhomThanhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbNhomThanhVien.Location = new System.Drawing.Point(15, 50);
            this.rbNhomThanhVien.Name = "rbNhomThanhVien";
            this.rbNhomThanhVien.Size = new System.Drawing.Size(143, 24);
            this.rbNhomThanhVien.TabIndex = 1;
            this.rbNhomThanhVien.TabStop = true;
            this.rbNhomThanhVien.Text = "Nhóm thành viên";
            this.rbNhomThanhVien.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbNhomThanhVien.UncheckedState.BorderThickness = 2;
            this.rbNhomThanhVien.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNhomThanhVien.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbNhomThanhVien.UseVisualStyleBackColor = true;
            // 
            // lblRecipientSelectionTitle
            // 
            this.lblRecipientSelectionTitle.AutoSize = true;
            this.lblRecipientSelectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipientSelectionTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecipientSelectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecipientSelectionTitle.Location = new System.Drawing.Point(13, 10);
            this.lblRecipientSelectionTitle.Name = "lblRecipientSelectionTitle";
            this.lblRecipientSelectionTitle.Size = new System.Drawing.Size(93, 25);
            this.lblRecipientSelectionTitle.TabIndex = 0;
            this.lblRecipientSelectionTitle.Text = "Gửi đến :";
            // 
            // guna2PanelActions
            // 
            this.guna2PanelActions.Controls.Add(this.btnGui);
            this.guna2PanelActions.Controls.Add(this.btnHuy);
            this.guna2PanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PanelActions.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelActions.Location = new System.Drawing.Point(10, 560);
            this.guna2PanelActions.Name = "guna2PanelActions";
            this.guna2PanelActions.Padding = new System.Windows.Forms.Padding(0, 10, 25, 10);
            this.guna2PanelActions.Size = new System.Drawing.Size(1060, 60);
            this.guna2PanelActions.TabIndex = 3;
            // 
            // btnGui
            // 
            this.btnGui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGui.BorderRadius = 5;
            this.btnGui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnGui.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGui.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnGui.Location = new System.Drawing.Point(925, 10);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(110, 40);
            this.btnGui.TabIndex = 1;
            this.btnGui.Text = "Gửi";
            this.btnGui.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGui.TextOffset = new System.Drawing.Point(10, 0);
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
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHuy.Location = new System.Drawing.Point(805, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 40);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            // 
            // FormSendVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelActions);
            this.Controls.Add(this.guna2PanelRecipientSelection);
            this.Controls.Add(this.guna2PanelVoucherSelection);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSendVoucher";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1080, 630);
            this.guna2PanelVoucherSelection.ResumeLayout(false);
            this.guna2PanelVoucherSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchersToSend)).EndInit();
            this.guna2PanelRecipientSelection.ResumeLayout(false);
            this.guna2PanelRecipientSelection.PerformLayout();
            this.guna2PanelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelVoucherSelection;
        private System.Windows.Forms.Label lblVoucherSelectionTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVouchersToSend;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelRecipientSelection;
        private System.Windows.Forms.Label lblRecipientSelectionTitle;
        private Guna.UI2.WinForms.Guna2RadioButton rbNhomThanhVien;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhomThanhVien;
        private Guna.UI2.WinForms.Guna2RadioButton rbThanhVienCuThe;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhVienCuThe;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelActions;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChonVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHetHan;
    }
}