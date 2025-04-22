// FormNhanVien.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System;

// Namespace theo yêu cầu
namespace DoAnDemo.Form.FormAdmin
{
    partial class FormNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.cboChiNhanh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PanelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colQL_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQL_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQL_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQL_NgayTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQL_TacVu_CapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQL_TacVu_LoaiBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGrid1Header = new System.Windows.Forms.Label();
            this.btnThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblContentTitle = new System.Windows.Forms.Label();
            this.guna2PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMainTitle.Location = new System.Drawing.Point(20, 15);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(261, 32);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(22, 45);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(266, 20);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Thông tin chi tiết về nhân viên của bạn.";
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.cboChiNhanh.BorderColor = System.Drawing.Color.Gainsboro;
            this.cboChiNhanh.BorderRadius = 5;
            this.cboChiNhanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboChiNhanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboChiNhanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChiNhanh.ItemHeight = 30;
            this.cboChiNhanh.Location = new System.Drawing.Point(20, 82);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(250, 36);
            this.cboChiNhanh.StartIndex = 0;
            this.cboChiNhanh.TabIndex = 3;
            // 
            // guna2PanelContent
            // 
            this.guna2PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelContent.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelContent.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelContent.BorderRadius = 8;
            this.guna2PanelContent.BorderThickness = 1;
            this.guna2PanelContent.Controls.Add(this.dgvNhanVien);
            this.guna2PanelContent.Controls.Add(this.lblGrid1Header);
            this.guna2PanelContent.Controls.Add(this.btnThemMoi);
            this.guna2PanelContent.Controls.Add(this.btnRefresh);
            this.guna2PanelContent.Controls.Add(this.lblContentTitle);
            this.guna2PanelContent.FillColor = System.Drawing.Color.White;
            this.guna2PanelContent.Location = new System.Drawing.Point(25, 124);
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.Padding = new System.Windows.Forms.Padding(15);
            this.guna2PanelContent.Size = new System.Drawing.Size(1030, 491);
            this.guna2PanelContent.TabIndex = 4;
            this.guna2PanelContent.UseTransparentBackground = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeight = 28;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQL_STT,
            this.colQL_Ten,
            this.colQL_SDT,
            this.colQL_NgayTG,
            this.colQL_TacVu_CapNhat,
            this.colQL_TacVu_LoaiBo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(18, 95);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 26;
            this.dgvNhanVien.Size = new System.Drawing.Size(994, 378);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvNhanVien.ThemeStyle.ReadOnly = true;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.Height = 26;
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colQL_STT
            // 
            this.colQL_STT.FillWeight = 40F;
            this.colQL_STT.HeaderText = "#";
            this.colQL_STT.MinimumWidth = 6;
            this.colQL_STT.Name = "colQL_STT";
            this.colQL_STT.ReadOnly = true;
            // 
            // colQL_Ten
            // 
            this.colQL_Ten.FillWeight = 150F;
            this.colQL_Ten.HeaderText = "TÊN";
            this.colQL_Ten.MinimumWidth = 6;
            this.colQL_Ten.Name = "colQL_Ten";
            this.colQL_Ten.ReadOnly = true;
            // 
            // colQL_SDT
            // 
            this.colQL_SDT.FillWeight = 120F;
            this.colQL_SDT.HeaderText = "SỐ ĐIỆN THOẠI";
            this.colQL_SDT.MinimumWidth = 6;
            this.colQL_SDT.Name = "colQL_SDT";
            this.colQL_SDT.ReadOnly = true;
            // 
            // colQL_NgayTG
            // 
            this.colQL_NgayTG.FillWeight = 120F;
            this.colQL_NgayTG.HeaderText = "NGÀY THAM GIA";
            this.colQL_NgayTG.MinimumWidth = 6;
            this.colQL_NgayTG.Name = "colQL_NgayTG";
            this.colQL_NgayTG.ReadOnly = true;
            // 
            // colQL_TacVu_CapNhat
            // 
            this.colQL_TacVu_CapNhat.FillWeight = 80F;
            this.colQL_TacVu_CapNhat.HeaderText = "Cập nhật";
            this.colQL_TacVu_CapNhat.MinimumWidth = 6;
            this.colQL_TacVu_CapNhat.Name = "colQL_TacVu_CapNhat";
            this.colQL_TacVu_CapNhat.ReadOnly = true;
            // 
            // colQL_TacVu_LoaiBo
            // 
            this.colQL_TacVu_LoaiBo.FillWeight = 80F;
            this.colQL_TacVu_LoaiBo.HeaderText = "Loại bỏ";
            this.colQL_TacVu_LoaiBo.MinimumWidth = 6;
            this.colQL_TacVu_LoaiBo.Name = "colQL_TacVu_LoaiBo";
            this.colQL_TacVu_LoaiBo.ReadOnly = true;
            // 
            // lblGrid1Header
            // 
            this.lblGrid1Header.AutoSize = true;
            this.lblGrid1Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGrid1Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGrid1Header.Location = new System.Drawing.Point(18, 70);
            this.lblGrid1Header.Name = "lblGrid1Header";
            this.lblGrid1Header.Size = new System.Drawing.Size(194, 23);
            this.lblGrid1Header.TabIndex = 3;
            this.lblGrid1Header.Text = "# QUẢN LÝ CỬA HÀNG";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.BorderRadius = 5;
            this.btnThemMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemMoi.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnThemMoi.ImageSize = new System.Drawing.Size(16, 16);
            this.btnThemMoi.Location = new System.Drawing.Point(902, 18);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(110, 35);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "THÊM MỚI";
            this.btnThemMoi.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefresh.ImageRotate = 0F;
            this.btnRefresh.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRefresh.Location = new System.Drawing.Point(220, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseTransparentBackground = true;
            // 
            // lblContentTitle
            // 
            this.lblContentTitle.AutoSize = true;
            this.lblContentTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblContentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblContentTitle.Location = new System.Drawing.Point(18, 25);
            this.lblContentTitle.Name = "lblContentTitle";
            this.lblContentTitle.Size = new System.Drawing.Size(226, 25);
            this.lblContentTitle.TabIndex = 0;
            this.lblContentTitle.Text = "CHI NHÁNH : 12 ĐẠI LA";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelContent);
            this.Controls.Add(this.cboChiNhanh);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblMainTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormNhanVien";
            this.Size = new System.Drawing.Size(1080, 630);
            this.guna2PanelContent.ResumeLayout(false);
            this.guna2PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cboChiNhanh;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelContent;
        private System.Windows.Forms.Label lblContentTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnThemMoi;
        private System.Windows.Forms.Label lblGrid1Header;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhanVien;
        // Placeholder Columns for Grid 1 (Quản lý cửa hàng)
        private System.Windows.Forms.DataGridViewTextBoxColumn colQL_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQL_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQL_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQL_NgayTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQL_TacVu_CapNhat; // Placeholder for button/image
        private System.Windows.Forms.DataGridViewTextBoxColumn colQL_TacVu_LoaiBo; // Placeholder for button/image
    }
}