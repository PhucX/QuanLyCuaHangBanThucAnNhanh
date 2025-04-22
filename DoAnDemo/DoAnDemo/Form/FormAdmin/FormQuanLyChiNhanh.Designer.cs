using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormQuanLyChiNhanh
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
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.dgvChiNhanh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).BeginInit();
            this.SuspendLayout();
            //
            // panelTop
            //
            this.panelTop.Controls.Add(this.btnThemMoi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5); // Padding top/bottom
            this.panelTop.Size = new System.Drawing.Size(1062, 55); // Chiều cao cố định cho thanh trên cùng
            this.panelTop.TabIndex = 0;
            //
            // btnThemMoi
            //
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.BorderRadius = 5;
            this.btnThemMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(153))))); // Màu xanh lá cây
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            // Icon Thêm mới (ví dụ)
            // this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnThemMoi.Location = new System.Drawing.Point(909, 10);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(140, 40);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "+ THÊM MỚI";
            this.btnThemMoi.TextOffset = new System.Drawing.Point(5, 0);
            //
            // dgvChiNhanh
            //
            this.dgvChiNhanh.AllowUserToAddRows = false;
            this.dgvChiNhanh.AllowUserToDeleteRows = false;
            this.dgvChiNhanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiNhanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiNhanh.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu header hồng đậm
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold); // Header font bold
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiNhanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiNhanh.ColumnHeadersHeight = 40; // Tăng chiều cao header
            this.dgvChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCH,
            this.colTenCH,
            this.colDiaChi,
            this.colSoDienThoai,
            this.colKhuVuc,
            this.colTrangThai,
            this.colSua,
            this.colXoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F); // Font nội dung
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiNhanh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiNhanh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiNhanh.Location = new System.Drawing.Point(0, 55); // Vị trí dưới panelTop
            this.dgvChiNhanh.Name = "dgvChiNhanh";
            this.dgvChiNhanh.ReadOnly = true; // Đặt read only cho toàn bộ grid trước
            this.dgvChiNhanh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiNhanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiNhanh.RowHeadersVisible = false; // Ẩn cột header hàng bên trái
            this.dgvChiNhanh.RowHeadersWidth = 51;
            this.dgvChiNhanh.RowTemplate.Height = 35; // Tăng chiều cao hàng
            this.dgvChiNhanh.Size = new System.Drawing.Size(1062, 510); // Kích thước tự điều chỉnh theo form cha
            this.dgvChiNhanh.TabIndex = 1;
            this.dgvChiNhanh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiNhanh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChiNhanh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChiNhanh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChiNhanh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChiNhanh.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChiNhanh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiNhanh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.dgvChiNhanh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChiNhanh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvChiNhanh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChiNhanh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiNhanh.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvChiNhanh.ThemeStyle.ReadOnly = true;
            this.dgvChiNhanh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiNhanh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiNhanh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvChiNhanh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiNhanh.ThemeStyle.RowsStyle.Height = 35;
            this.dgvChiNhanh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiNhanh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //
            // colMaCH
            //
            this.colMaCH.DataPropertyName = "MaCuaHang"; // Liên kết với thuộc tính của ViewModel/Entity
            this.colMaCH.HeaderText = "Mã CH";
            this.colMaCH.MinimumWidth = 6;
            this.colMaCH.Name = "colMaCH";
            this.colMaCH.ReadOnly = true;
            this.colMaCH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Tự động điều chỉnh độ rộng
            //
            // colTenCH
            //
            this.colTenCH.DataPropertyName = "TenCuaHang";
            this.colTenCH.HeaderText = "Tên Chi Nhánh";
            this.colTenCH.MinimumWidth = 6;
            this.colTenCH.Name = "colTenCH";
            this.colTenCH.ReadOnly = true;
            this.colTenCH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            // colDiaChi
            //
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Cho cột địa chỉ chiếm phần còn lại
            //
            // colSoDienThoai
            //
            this.colSoDienThoai.DataPropertyName = "SoDienThoai";
            this.colSoDienThoai.HeaderText = "Điện Thoại";
            this.colSoDienThoai.MinimumWidth = 6;
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            this.colSoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            // colKhuVuc
            //
            this.colKhuVuc.DataPropertyName = "KhuVuc";
            this.colKhuVuc.HeaderText = "Khu Vực";
            this.colKhuVuc.MinimumWidth = 6;
            this.colKhuVuc.Name = "colKhuVuc";
            this.colKhuVuc.ReadOnly = true;
            this.colKhuVuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            // colTrangThai
            //
            this.colTrangThai.DataPropertyName = "TrangThai"; // Sẽ cần format lại trong code-behind để hiển thị dễ đọc
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            // colSua
            //
            this.colSua.HeaderText = "Sửa";
            this.colSua.MinimumWidth = 6;
            this.colSua.Name = "colSua";
            this.colSua.ReadOnly = false; // Cho phép nhấn nút
            this.colSua.Text = "Sửa";
            this.colSua.UseColumnTextForButtonValue = true; // Hiển thị chữ "Sửa"
            this.colSua.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // Thêm style cho nút (Tùy chọn)
            // DataGridViewCellStyle buttonStyle = new DataGridViewCellStyle();
            // buttonStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // // ... set colors, font ...
            // this.colSua.DefaultCellStyle = buttonStyle;
            //
            // colXoa
            //
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.MinimumWidth = 6;
            this.colXoa.Name = "colXoa";
            this.colXoa.ReadOnly = false; // Cho phép nhấn nút
            this.colXoa.Text = "Xóa";
            this.colXoa.UseColumnTextForButtonValue = true; // Hiển thị chữ "Xóa"
            this.colXoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // this.colXoa.DefaultCellStyle = buttonStyle; // Dùng chung style nếu muốn
            //
            // FormQuanLyChiNhanh
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.dgvChiNhanh);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FormQuanLyChiNhanh";
            this.Size = new System.Drawing.Size(1062, 565); // Kích thước UserControl
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Button btnThemMoi;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colSua;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
    }
}