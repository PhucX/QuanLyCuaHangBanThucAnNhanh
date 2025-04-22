namespace DoAnDemo
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeftNav = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNavTroGiup = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavTaiKhoan = new Guna.UI2.WinForms.Guna2Button(); 
            this.btnNavUngDung = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavKho = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavQuanLy = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLeftNav.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();

            // panelLeftNav
            this.panelLeftNav.BackColor = System.Drawing.Color.White;
            this.panelLeftNav.Controls.Add(this.btnNavTroGiup);
            this.panelLeftNav.Controls.Add(this.btnNavTaiKhoan);
            this.panelLeftNav.Controls.Add(this.btnNavUngDung);
            this.panelLeftNav.Controls.Add(this.btnNavKhachHang);
            this.panelLeftNav.Controls.Add(this.btnNavKho);
            this.panelLeftNav.Controls.Add(this.btnNavSanPham);
            this.panelLeftNav.Controls.Add(this.btnNavQuanLy);
            this.panelLeftNav.Controls.Add(this.btnNavBaoCao);
            this.panelLeftNav.Controls.Add(this.btnNavTrangChu);
            this.panelLeftNav.Controls.Add(this.panelLogo);
            this.panelLeftNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNav.FillColor = System.Drawing.Color.White;
            this.panelLeftNav.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNav.Name = "panelLeftNav";
            this.panelLeftNav.Size = new System.Drawing.Size(200, 720);
            this.panelLeftNav.TabIndex = 0;

            // Navigation Buttons Configuration
            this.ConfigureNavButton(btnNavTrangChu, "TRANG CHỦ", 65);
            this.ConfigureNavButton(btnNavBaoCao, "BÁO CÁO", 115);
            this.ConfigureNavButton(btnNavQuanLy, "QUẢN LÝ", 165);
            this.ConfigureNavButton(btnNavSanPham, "SẢN PHẨM", 215);
            this.ConfigureNavButton(btnNavKho, "KHO", 265);
            this.ConfigureNavButton(btnNavKhachHang, "KHÁCH HÀNG", 315);
            this.ConfigureNavButton(btnNavUngDung, "ỨNG DỤNG", 365);
            this.ConfigureNavButton(btnNavTaiKhoan, "TÀI KHOẢN", 415);
            this.ConfigureNavButton(btnNavTroGiup, "TRỢ GIÚP", 465);

            // panelLogo
            this.panelLogo.Controls.Add(this.labelAppName);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 65);

            // labelAppName
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.labelAppName.Location = new System.Drawing.Point(65, 21);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(64, 28);
            this.labelAppName.TabIndex = 1;
            this.labelAppName.Text = "LOOP";

            // pictureBoxLogo
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;

            // panelMainContent
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(200, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(1102, 720);
            this.panelMainContent.TabIndex = 2;

            // AdminForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 720);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelLeftNav);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "AdminForm";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hệ thống";
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeftNav.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel panelLeftNav;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelAppName;
        private Guna.UI2.WinForms.Guna2Button btnNavTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnNavBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnNavQuanLy;
        private Guna.UI2.WinForms.Guna2Button btnNavSanPham;
        private Guna.UI2.WinForms.Guna2Button btnNavKho;
        private Guna.UI2.WinForms.Guna2Button btnNavKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnNavUngDung;
        private Guna.UI2.WinForms.Guna2Button btnNavTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnNavTroGiup;
        private Guna.UI2.WinForms.Guna2Panel panelMainContent;
    }
}

