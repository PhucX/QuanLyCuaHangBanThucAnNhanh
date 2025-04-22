// FormQuanLyGiamGiaList.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormQuanLyGiamGiaList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGiamGia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.colPhamVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnThemMoi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.panelTop.Size = new System.Drawing.Size(1062, 55);
            this.panelTop.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.BorderRadius = 5;
            this.btnThemMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(153)))));
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(909, 10);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(140, 40);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "+ THÊM MỚI";
            // 
            // dgvGiamGia
            // 
            this.dgvGiamGia.AllowUserToAddRows = false;
            this.dgvGiamGia.AllowUserToDeleteRows = false;
            this.dgvGiamGia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiamGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiamGia.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiamGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiamGia.ColumnHeadersHeight = 35;
            this.dgvGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGiamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaVoucher,
            this.colTenVoucher,
            this.colLoaiGiamGia,
            this.colGiaTri,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            //this.colPhamVi,
            this.colTrangThai,
            this.colSua,
            this.colXoa});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiamGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGiamGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiamGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiamGia.Location = new System.Drawing.Point(0, 55);
            this.dgvGiamGia.Name = "dgvGiamGia";
            this.dgvGiamGia.ReadOnly = true;
            this.dgvGiamGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiamGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGiamGia.RowHeadersVisible = false;
            this.dgvGiamGia.RowHeadersWidth = 51;
            this.dgvGiamGia.RowTemplate.Height = 30;
            this.dgvGiamGia.Size = new System.Drawing.Size(1062, 510);
            this.dgvGiamGia.TabIndex = 2;
            this.dgvGiamGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiamGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGiamGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGiamGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGiamGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGiamGia.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGiamGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiamGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.dgvGiamGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGiamGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvGiamGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGiamGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGiamGia.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvGiamGia.ThemeStyle.ReadOnly = true;
            this.dgvGiamGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiamGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiamGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGiamGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiamGia.ThemeStyle.RowsStyle.Height = 30;
            this.dgvGiamGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiamGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colXoa
            // 
            this.colXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colXoa.HeaderText = "";
            this.colXoa.MinimumWidth = 6;
            this.colXoa.Name = "colXoa";
            this.colXoa.ReadOnly = true;
            this.colXoa.Text = "Đổi TT";
            this.colXoa.UseColumnTextForButtonValue = true;
            this.colXoa.Width = 6;
            // 
            // colSua
            // 
            this.colSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSua.HeaderText = "";
            this.colSua.MinimumWidth = 6;
            this.colSua.Name = "colSua";
            this.colSua.ReadOnly = true;
            this.colSua.Text = "Sửa";
            this.colSua.UseColumnTextForButtonValue = true;
            this.colSua.Width = 6;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 99;
            // 
            // colPhamVi
            //// 
            //this.colPhamVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            //this.colPhamVi.DataPropertyName = "PhamViApDung";
            //this.colPhamVi.HeaderText = "Phạm Vi";
            //this.colPhamVi.MinimumWidth = 6;
            //this.colPhamVi.Name = "colPhamVi";
            //this.colPhamVi.ReadOnly = true;
            //this.colPhamVi.Width = 87;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNgayKetThuc.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.colNgayKetThuc.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNgayKetThuc.HeaderText = "Ngày KT";
            this.colNgayKetThuc.MinimumWidth = 6;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.ReadOnly = true;
            this.colNgayKetThuc.Width = 87;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNgayBatDau.DataPropertyName = "NgayBatDau";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.colNgayBatDau.DefaultCellStyle = dataGridViewCellStyle4;
            this.colNgayBatDau.HeaderText = "Ngày BĐ";
            this.colNgayBatDau.MinimumWidth = 6;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            this.colNgayBatDau.Width = 90;
            // 
            // colGiaTri
            // 
            this.colGiaTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGiaTri.DataPropertyName = "GiaTriGiam";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.colGiaTri.DefaultCellStyle = dataGridViewCellStyle3;
            this.colGiaTri.HeaderText = "Giá trị";
            this.colGiaTri.MinimumWidth = 6;
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.ReadOnly = true;
            this.colGiaTri.Width = 73;
            // 
            // colLoaiGiamGia
            // 
            this.colLoaiGiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLoaiGiamGia.DataPropertyName = "LoaiGiamGia";
            this.colLoaiGiamGia.HeaderText = "Loại";
            this.colLoaiGiamGia.MinimumWidth = 6;
            this.colLoaiGiamGia.Name = "colLoaiGiamGia";
            this.colLoaiGiamGia.ReadOnly = true;
            this.colLoaiGiamGia.Width = 61;
            // 
            // colTenVoucher
            // 
            this.colTenVoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenVoucher.DataPropertyName = "TenVoucher";
            this.colTenVoucher.HeaderText = "Tên Chương trình";
            this.colTenVoucher.MinimumWidth = 6;
            this.colTenVoucher.Name = "colTenVoucher";
            this.colTenVoucher.ReadOnly = true;
            // 
            // colMaVoucher
            // 
            this.colMaVoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaVoucher.DataPropertyName = "MaVoucher";
            this.colMaVoucher.HeaderText = "Mã Voucher";
            this.colMaVoucher.MinimumWidth = 6;
            this.colMaVoucher.Name = "colMaVoucher";
            this.colMaVoucher.ReadOnly = true;
            this.colMaVoucher.Width = 110;
            // 
            // FormQuanLyGiamGiaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.dgvGiamGia);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FormQuanLyGiamGiaList";
            this.Size = new System.Drawing.Size(1062, 565);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Button btnThemMoi;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiamGia;
        private DataGridViewTextBoxColumn colMaVoucher;
        private DataGridViewTextBoxColumn colTenVoucher;
        private DataGridViewTextBoxColumn colLoaiGiamGia;
        private DataGridViewTextBoxColumn colGiaTri;
        private DataGridViewTextBoxColumn colNgayBatDau;
        private DataGridViewTextBoxColumn colNgayKetThuc;
        //private DataGridViewTextBoxColumn colPhamVi;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewButtonColumn colSua;
        private DataGridViewButtonColumn colXoa;
    }
}