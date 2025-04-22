// FormDetailMember.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

// Namespace theo yêu cầu
namespace DoAnDemo.Form.FormAdmin
{
    partial class FormDetailMember
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.guna2PanelInfoLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblGioiTinhValue = new System.Windows.Forms.Label();
            this.lblGioiTinhLabel = new System.Windows.Forms.Label();
            this.lblSDTValue = new System.Windows.Forms.Label();
            this.lblSDTLabel = new System.Windows.Forms.Label();
            this.lblNgaySinhValue = new System.Windows.Forms.Label();
            this.lblNgaySinhLabel = new System.Windows.Forms.Label();
            this.lblMaTVValue = new System.Windows.Forms.Label();
            this.lblMaTVLabel = new System.Windows.Forms.Label();
            this.lblHoTenValue = new System.Windows.Forms.Label();
            this.lblHoTenLabel = new System.Windows.Forms.Label();
            this.guna2PanelInfoRight = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHanMucTheValue = new System.Windows.Forms.Label();
            this.lblHanMucTheLabel = new System.Windows.Forms.Label();
            this.lblDiemValue = new System.Windows.Forms.Label();
            this.lblDiemLabel = new System.Windows.Forms.Label();
            this.lblTongTienTieuValue = new System.Windows.Forms.Label();
            this.lblTongTienTieuLabel = new System.Windows.Forms.Label();
            this.lblThamGiaValue = new System.Windows.Forms.Label();
            this.lblThamGiaLabel = new System.Windows.Forms.Label();
            this.guna2PanelVoucherList = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvVouchers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVoucherListTitle = new System.Windows.Forms.Label();
            this.guna2PanelChart1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblChart1Title = new System.Windows.Forms.Label();
            this.guna2PanelChart2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblChart2Title = new System.Windows.Forms.Label();
            this.chartOrderTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStoreVisits = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.guna2PanelInfoLeft.SuspendLayout();
            this.guna2PanelInfoRight.SuspendLayout();
            this.guna2PanelVoucherList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.guna2PanelChart1.SuspendLayout();
            this.guna2PanelChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStoreVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.lblMainTitle.Location = new System.Drawing.Point(20, 15);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(464, 32);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "THÔNG TIN CHI TIẾT CỦA THÀNH VIÊN";
            // 
            // guna2PanelInfoLeft
            // 
            this.guna2PanelInfoLeft.Controls.Add(this.lblEmailValue);
            this.guna2PanelInfoLeft.Controls.Add(this.lblEmailLabel);
            this.guna2PanelInfoLeft.Controls.Add(this.lblGioiTinhValue);
            this.guna2PanelInfoLeft.Controls.Add(this.lblGioiTinhLabel);
            this.guna2PanelInfoLeft.Controls.Add(this.lblSDTValue);
            this.guna2PanelInfoLeft.Controls.Add(this.lblSDTLabel);
            this.guna2PanelInfoLeft.Controls.Add(this.lblNgaySinhValue);
            this.guna2PanelInfoLeft.Controls.Add(this.lblNgaySinhLabel);
            this.guna2PanelInfoLeft.Controls.Add(this.lblMaTVValue);
            this.guna2PanelInfoLeft.Controls.Add(this.lblMaTVLabel);
            this.guna2PanelInfoLeft.Controls.Add(this.lblHoTenValue);
            this.guna2PanelInfoLeft.Controls.Add(this.lblHoTenLabel);
            this.guna2PanelInfoLeft.Location = new System.Drawing.Point(25, 55);
            this.guna2PanelInfoLeft.Name = "guna2PanelInfoLeft";
            this.guna2PanelInfoLeft.Size = new System.Drawing.Size(350, 150);
            this.guna2PanelInfoLeft.TabIndex = 1;
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmailValue.Location = new System.Drawing.Point(120, 125);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(41, 23);
            this.lblEmailValue.TabIndex = 11;
            this.lblEmailValue.Text = "N/A";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblEmailLabel.Location = new System.Drawing.Point(3, 125);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(55, 23);
            this.lblEmailLabel.TabIndex = 10;
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblGioiTinhValue
            // 
            this.lblGioiTinhValue.AutoSize = true;
            this.lblGioiTinhValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinhValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGioiTinhValue.Location = new System.Drawing.Point(120, 100);
            this.lblGioiTinhValue.Name = "lblGioiTinhValue";
            this.lblGioiTinhValue.Size = new System.Drawing.Size(47, 23);
            this.lblGioiTinhValue.TabIndex = 9;
            this.lblGioiTinhValue.Text = "Nam";
            // 
            // lblGioiTinhLabel
            // 
            this.lblGioiTinhLabel.AutoSize = true;
            this.lblGioiTinhLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGioiTinhLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblGioiTinhLabel.Location = new System.Drawing.Point(3, 100);
            this.lblGioiTinhLabel.Name = "lblGioiTinhLabel";
            this.lblGioiTinhLabel.Size = new System.Drawing.Size(79, 23);
            this.lblGioiTinhLabel.TabIndex = 8;
            this.lblGioiTinhLabel.Text = "Giới tính:";
            // 
            // lblSDTValue
            // 
            this.lblSDTValue.AutoSize = true;
            this.lblSDTValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSDTValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSDTValue.Location = new System.Drawing.Point(120, 75);
            this.lblSDTValue.Name = "lblSDTValue";
            this.lblSDTValue.Size = new System.Drawing.Size(97, 23);
            this.lblSDTValue.TabIndex = 7;
            this.lblSDTValue.Text = "0931451095";
            // 
            // lblSDTLabel
            // 
            this.lblSDTLabel.AutoSize = true;
            this.lblSDTLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSDTLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblSDTLabel.Location = new System.Drawing.Point(3, 75);
            this.lblSDTLabel.Name = "lblSDTLabel";
            this.lblSDTLabel.Size = new System.Drawing.Size(115, 23);
            this.lblSDTLabel.TabIndex = 6;
            this.lblSDTLabel.Text = "Số điện thoại:";
            // 
            // lblNgaySinhValue
            // 
            this.lblNgaySinhValue.AutoSize = true;
            this.lblNgaySinhValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinhValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgaySinhValue.Location = new System.Drawing.Point(120, 50);
            this.lblNgaySinhValue.Name = "lblNgaySinhValue";
            this.lblNgaySinhValue.Size = new System.Drawing.Size(92, 23);
            this.lblNgaySinhValue.TabIndex = 5;
            this.lblNgaySinhValue.Text = "30/10/1989";
            // 
            // lblNgaySinhLabel
            // 
            this.lblNgaySinhLabel.AutoSize = true;
            this.lblNgaySinhLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgaySinhLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblNgaySinhLabel.Location = new System.Drawing.Point(3, 50);
            this.lblNgaySinhLabel.Name = "lblNgaySinhLabel";
            this.lblNgaySinhLabel.Size = new System.Drawing.Size(90, 23);
            this.lblNgaySinhLabel.TabIndex = 4;
            this.lblNgaySinhLabel.Text = "Ngày sinh:";
            // 
            // lblMaTVValue
            // 
            this.lblMaTVValue.AutoSize = true;
            this.lblMaTVValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMaTVValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaTVValue.Location = new System.Drawing.Point(120, 25);
            this.lblMaTVValue.Name = "lblMaTVValue";
            this.lblMaTVValue.Size = new System.Drawing.Size(63, 23);
            this.lblMaTVValue.TabIndex = 3;
            this.lblMaTVValue.Text = "142089";
            // 
            // lblMaTVLabel
            // 
            this.lblMaTVLabel.AutoSize = true;
            this.lblMaTVLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaTVLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblMaTVLabel.Location = new System.Drawing.Point(3, 25);
            this.lblMaTVLabel.Name = "lblMaTVLabel";
            this.lblMaTVLabel.Size = new System.Drawing.Size(124, 23);
            this.lblMaTVLabel.TabIndex = 2;
            this.lblMaTVLabel.Text = "Mã thành viên:";
            // 
            // lblHoTenValue
            // 
            this.lblHoTenValue.AutoSize = true;
            this.lblHoTenValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHoTenValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoTenValue.Location = new System.Drawing.Point(120, 0);
            this.lblHoTenValue.Name = "lblHoTenValue";
            this.lblHoTenValue.Size = new System.Drawing.Size(84, 23);
            this.lblHoTenValue.TabIndex = 1;
            this.lblHoTenValue.Text = "Thái Bạch";
            // 
            // lblHoTenLabel
            // 
            this.lblHoTenLabel.AutoSize = true;
            this.lblHoTenLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHoTenLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblHoTenLabel.Location = new System.Drawing.Point(3, 0);
            this.lblHoTenLabel.Name = "lblHoTenLabel";
            this.lblHoTenLabel.Size = new System.Drawing.Size(66, 23);
            this.lblHoTenLabel.TabIndex = 0;
            this.lblHoTenLabel.Text = "Họ tên:";
            // 
            // guna2PanelInfoRight
            // 
            this.guna2PanelInfoRight.Controls.Add(this.lblHanMucTheValue);
            this.guna2PanelInfoRight.Controls.Add(this.lblHanMucTheLabel);
            this.guna2PanelInfoRight.Controls.Add(this.lblDiemValue);
            this.guna2PanelInfoRight.Controls.Add(this.lblDiemLabel);
            this.guna2PanelInfoRight.Controls.Add(this.lblTongTienTieuValue);
            this.guna2PanelInfoRight.Controls.Add(this.lblTongTienTieuLabel);
            this.guna2PanelInfoRight.Controls.Add(this.lblThamGiaValue);
            this.guna2PanelInfoRight.Controls.Add(this.lblThamGiaLabel);
            this.guna2PanelInfoRight.Location = new System.Drawing.Point(400, 55);
            this.guna2PanelInfoRight.Name = "guna2PanelInfoRight";
            this.guna2PanelInfoRight.Size = new System.Drawing.Size(350, 100);
            this.guna2PanelInfoRight.TabIndex = 2;
            // 
            // lblHanMucTheValue
            // 
            this.lblHanMucTheValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHanMucTheValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHanMucTheValue.Location = new System.Drawing.Point(153, 75);
            this.lblHanMucTheValue.Name = "lblHanMucTheValue";
            this.lblHanMucTheValue.Size = new System.Drawing.Size(194, 17);
            this.lblHanMucTheValue.TabIndex = 7;
            this.lblHanMucTheValue.Text = "WELCOME";
            this.lblHanMucTheValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHanMucTheLabel
            // 
            this.lblHanMucTheLabel.AutoSize = true;
            this.lblHanMucTheLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHanMucTheLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblHanMucTheLabel.Location = new System.Drawing.Point(3, 75);
            this.lblHanMucTheLabel.Name = "lblHanMucTheLabel";
            this.lblHanMucTheLabel.Size = new System.Drawing.Size(113, 23);
            this.lblHanMucTheLabel.TabIndex = 6;
            this.lblHanMucTheLabel.Text = "Hạn mức thẻ:";
            // 
            // lblDiemValue
            // 
            this.lblDiemValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiemValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiemValue.Location = new System.Drawing.Point(153, 50);
            this.lblDiemValue.Name = "lblDiemValue";
            this.lblDiemValue.Size = new System.Drawing.Size(194, 17);
            this.lblDiemValue.TabIndex = 5;
            this.lblDiemValue.Text = "6";
            this.lblDiemValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiemLabel
            // 
            this.lblDiemLabel.AutoSize = true;
            this.lblDiemLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDiemLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblDiemLabel.Location = new System.Drawing.Point(3, 50);
            this.lblDiemLabel.Name = "lblDiemLabel";
            this.lblDiemLabel.Size = new System.Drawing.Size(54, 23);
            this.lblDiemLabel.TabIndex = 4;
            this.lblDiemLabel.Text = "Điểm:";
            // 
            // lblTongTienTieuValue
            // 
            this.lblTongTienTieuValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTongTienTieuValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTongTienTieuValue.Location = new System.Drawing.Point(153, 25);
            this.lblTongTienTieuValue.Name = "lblTongTienTieuValue";
            this.lblTongTienTieuValue.Size = new System.Drawing.Size(194, 17);
            this.lblTongTienTieuValue.TabIndex = 3;
            this.lblTongTienTieuValue.Text = "50.000 VND";
            this.lblTongTienTieuValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienTieuLabel
            // 
            this.lblTongTienTieuLabel.AutoSize = true;
            this.lblTongTienTieuLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTongTienTieuLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblTongTienTieuLabel.Location = new System.Drawing.Point(3, 25);
            this.lblTongTienTieuLabel.Name = "lblTongTienTieuLabel";
            this.lblTongTienTieuLabel.Size = new System.Drawing.Size(167, 23);
            this.lblTongTienTieuLabel.TabIndex = 2;
            this.lblTongTienTieuLabel.Text = "Tổng số tiền đã tiêu:";
            // 
            // lblThamGiaValue
            // 
            this.lblThamGiaValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblThamGiaValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblThamGiaValue.Location = new System.Drawing.Point(153, 0);
            this.lblThamGiaValue.Name = "lblThamGiaValue";
            this.lblThamGiaValue.Size = new System.Drawing.Size(194, 17);
            this.lblThamGiaValue.TabIndex = 1;
            this.lblThamGiaValue.Text = "28/10/2020";
            this.lblThamGiaValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThamGiaLabel
            // 
            this.lblThamGiaLabel.AutoSize = true;
            this.lblThamGiaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblThamGiaLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblThamGiaLabel.Location = new System.Drawing.Point(3, 0);
            this.lblThamGiaLabel.Name = "lblThamGiaLabel";
            this.lblThamGiaLabel.Size = new System.Drawing.Size(85, 23);
            this.lblThamGiaLabel.TabIndex = 0;
            this.lblThamGiaLabel.Text = "Tham gia:";
            // 
            // guna2PanelVoucherList
            // 
            this.guna2PanelVoucherList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PanelVoucherList.Controls.Add(this.dgvVouchers);
            this.guna2PanelVoucherList.Controls.Add(this.lblVoucherListTitle);
            this.guna2PanelVoucherList.Location = new System.Drawing.Point(25, 220);
            this.guna2PanelVoucherList.Name = "guna2PanelVoucherList";
            this.guna2PanelVoucherList.Size = new System.Drawing.Size(350, 390);
            this.guna2PanelVoucherList.TabIndex = 3;
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.AllowUserToDeleteRows = false;
            this.dgvVouchers.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVouchers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVouchers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVouchers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVouchers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVouchers.ColumnHeadersHeight = 28;
            this.dgvVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenVoucher,
            this.colGiamGia});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVouchers.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVouchers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVouchers.Location = new System.Drawing.Point(0, 30);
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersVisible = false;
            this.dgvVouchers.RowHeadersWidth = 51;
            this.dgvVouchers.RowTemplate.Height = 26;
            this.dgvVouchers.Size = new System.Drawing.Size(350, 360);
            this.dgvVouchers.TabIndex = 1;
            this.dgvVouchers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVouchers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVouchers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVouchers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVouchers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVouchers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVouchers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVouchers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVouchers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVouchers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvVouchers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvVouchers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVouchers.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvVouchers.ThemeStyle.ReadOnly = true;
            this.dgvVouchers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVouchers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVouchers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvVouchers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVouchers.ThemeStyle.RowsStyle.Height = 26;
            this.dgvVouchers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVouchers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.FillWeight = 30F;
            this.colSTT.HeaderText = "#";
            this.colSTT.MinimumWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 30;
            // 
            // colTenVoucher
            // 
            this.colTenVoucher.FillWeight = 150F;
            this.colTenVoucher.HeaderText = "TÊN VOUCHER";
            this.colTenVoucher.MinimumWidth = 6;
            this.colTenVoucher.Name = "colTenVoucher";
            this.colTenVoucher.ReadOnly = true;
            // 
            // colGiamGia
            // 
            this.colGiamGia.FillWeight = 80F;
            this.colGiamGia.HeaderText = "GIẢM GIÁ";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.ReadOnly = true;
            // 
            // lblVoucherListTitle
            // 
            this.lblVoucherListTitle.AutoSize = true;
            this.lblVoucherListTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVoucherListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVoucherListTitle.Location = new System.Drawing.Point(0, 5);
            this.lblVoucherListTitle.Name = "lblVoucherListTitle";
            this.lblVoucherListTitle.Size = new System.Drawing.Size(240, 23);
            this.lblVoucherListTitle.TabIndex = 0;
            this.lblVoucherListTitle.Text = "Các Vouchers của thành viên:";
            // 
            // guna2PanelChart1
            // 
            this.guna2PanelChart1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelChart1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelChart1.BorderRadius = 8;
            this.guna2PanelChart1.BorderThickness = 1;
            this.guna2PanelChart1.Controls.Add(this.chartStoreVisits);
            this.guna2PanelChart1.Controls.Add(this.lblChart1Title);
            this.guna2PanelChart1.FillColor = System.Drawing.Color.White;
            this.guna2PanelChart1.Location = new System.Drawing.Point(390, 220);
            this.guna2PanelChart1.Name = "guna2PanelChart1";
            this.guna2PanelChart1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelChart1.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelChart1.ShadowDecoration.Enabled = true;
            this.guna2PanelChart1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.guna2PanelChart1.Size = new System.Drawing.Size(320, 390);
            this.guna2PanelChart1.TabIndex = 4;
            // 
            // lblChart1Title
            // 
            this.lblChart1Title.BackColor = System.Drawing.Color.Transparent;
            this.lblChart1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChart1Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChart1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChart1Title.Location = new System.Drawing.Point(10, 10);
            this.lblChart1Title.Name = "lblChart1Title";
            this.lblChart1Title.Size = new System.Drawing.Size(300, 32);
            this.lblChart1Title.TabIndex = 0;
            this.lblChart1Title.Text = "NHỮNG CỬA HÀNG THÀNH VIÊN ĐÃ TỚI";
            this.lblChart1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PanelChart2
            // 
            this.guna2PanelChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelChart2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelChart2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelChart2.BorderRadius = 8;
            this.guna2PanelChart2.BorderThickness = 1;
            this.guna2PanelChart2.Controls.Add(this.chartOrderTypes);
            this.guna2PanelChart2.Controls.Add(this.lblChart2Title);
            this.guna2PanelChart2.FillColor = System.Drawing.Color.White;
            this.guna2PanelChart2.Location = new System.Drawing.Point(725, 220);
            this.guna2PanelChart2.Name = "guna2PanelChart2";
            this.guna2PanelChart2.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelChart2.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelChart2.ShadowDecoration.Enabled = true;
            this.guna2PanelChart2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.guna2PanelChart2.Size = new System.Drawing.Size(330, 390);
            this.guna2PanelChart2.TabIndex = 5;
            // 
            // lblChart2Title
            // 
            this.lblChart2Title.BackColor = System.Drawing.Color.Transparent;
            this.lblChart2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChart2Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChart2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChart2Title.Location = new System.Drawing.Point(10, 10);
            this.lblChart2Title.Name = "lblChart2Title";
            this.lblChart2Title.Size = new System.Drawing.Size(310, 32);
            this.lblChart2Title.TabIndex = 0;
            this.lblChart2Title.Text = "NHỮNG HÌNH THỨC ĐẶT MÓN CỦA THÀNH VIÊN";
            this.lblChart2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartOrderTypes
            // 
            chartArea5.Name = "ChartArea1";
            this.chartOrderTypes.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartOrderTypes.Legends.Add(legend5);
            this.chartOrderTypes.Location = new System.Drawing.Point(17, 62);
            this.chartOrderTypes.Name = "chartOrderTypes";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 4;
            this.chartOrderTypes.Series.Add(series5);
            this.chartOrderTypes.Size = new System.Drawing.Size(300, 300);
            this.chartOrderTypes.TabIndex = 1;
            this.chartOrderTypes.Text = "chart1";
            // 
            // chartStoreVisits
            // 
            chartArea6.Name = "ChartArea1";
            this.chartStoreVisits.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartStoreVisits.Legends.Add(legend6);
            this.chartStoreVisits.Location = new System.Drawing.Point(7, 62);
            this.chartStoreVisits.Name = "chartStoreVisits";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.YValuesPerPoint = 4;
            this.chartStoreVisits.Series.Add(series6);
            this.chartStoreVisits.Size = new System.Drawing.Size(300, 300);
            this.chartStoreVisits.TabIndex = 2;
            this.chartStoreVisits.Text = "chart2";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(923, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FormDetailMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.guna2PanelChart2);
            this.Controls.Add(this.guna2PanelChart1);
            this.Controls.Add(this.guna2PanelVoucherList);
            this.Controls.Add(this.guna2PanelInfoRight);
            this.Controls.Add(this.guna2PanelInfoLeft);
            this.Controls.Add(this.lblMainTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDetailMember";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1080, 630);
            this.guna2PanelInfoLeft.ResumeLayout(false);
            this.guna2PanelInfoLeft.PerformLayout();
            this.guna2PanelInfoRight.ResumeLayout(false);
            this.guna2PanelInfoRight.PerformLayout();
            this.guna2PanelVoucherList.ResumeLayout(false);
            this.guna2PanelVoucherList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.guna2PanelChart1.ResumeLayout(false);
            this.guna2PanelChart2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStoreVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelInfoLeft;
        private System.Windows.Forms.Label lblHoTenLabel;
        private System.Windows.Forms.Label lblHoTenValue;
        private System.Windows.Forms.Label lblMaTVLabel;
        private System.Windows.Forms.Label lblMaTVValue;
        private System.Windows.Forms.Label lblNgaySinhLabel;
        private System.Windows.Forms.Label lblNgaySinhValue;
        private System.Windows.Forms.Label lblSDTLabel;
        private System.Windows.Forms.Label lblSDTValue;
        private System.Windows.Forms.Label lblGioiTinhLabel;
        private System.Windows.Forms.Label lblGioiTinhValue;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmailValue;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelInfoRight;
        private System.Windows.Forms.Label lblThamGiaLabel;
        private System.Windows.Forms.Label lblThamGiaValue;
        private System.Windows.Forms.Label lblTongTienTieuLabel;
        private System.Windows.Forms.Label lblTongTienTieuValue;
        private System.Windows.Forms.Label lblDiemLabel;
        private System.Windows.Forms.Label lblDiemValue;
        private System.Windows.Forms.Label lblHanMucTheLabel;
        private System.Windows.Forms.Label lblHanMucTheValue;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelVoucherList;
        private System.Windows.Forms.Label lblVoucherListTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVouchers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelChart1;
        private System.Windows.Forms.Label lblChart1Title;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelChart2;
        private System.Windows.Forms.Label lblChart2Title;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrintBill; // Added based on UI element
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrderTypes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStoreVisits;
        private Button btnBack;
    }
}