// FormTrangChuAdmin.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormTrangChuAdmin
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
            this.panelLeftNav = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNavKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavQuanLy = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnNavTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLeftNav.SuspendLayout();
            this.guna2PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftNav
            // 
            this.panelLeftNav.BackColor = System.Drawing.Color.White;
            this.panelLeftNav.Controls.Add(this.btnNavKhachHang);
            this.panelLeftNav.Controls.Add(this.btnNavSanPham);
            this.panelLeftNav.Controls.Add(this.btnNavQuanLy);
            this.panelLeftNav.Controls.Add(this.btnNavBaoCao);
            this.panelLeftNav.Controls.Add(this.btnNavTrangChu);
            this.panelLeftNav.Controls.Add(this.guna2PanelLogo);
            this.panelLeftNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNav.FillColor = System.Drawing.Color.White;
            this.panelLeftNav.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNav.Name = "panelLeftNav";
            this.panelLeftNav.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.panelLeftNav.ShadowDecoration.Enabled = true;
            this.panelLeftNav.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panelLeftNav.Size = new System.Drawing.Size(200, 720);
            this.panelLeftNav.TabIndex = 0;
            // 
            // btnNavKhachHang
            // 
            this.btnNavKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnNavKhachHang.BorderRadius = 5;
            this.btnNavKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavKhachHang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnNavKhachHang.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNavKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavKhachHang.FillColor = System.Drawing.Color.White;
            this.btnNavKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavKhachHang.ForeColor = System.Drawing.Color.DimGray;
            this.btnNavKhachHang.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavKhachHang.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnNavKhachHang.Location = new System.Drawing.Point(0, 265);
            this.btnNavKhachHang.Name = "btnNavKhachHang";
            this.btnNavKhachHang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNavKhachHang.Size = new System.Drawing.Size(200, 50);
            this.btnNavKhachHang.TabIndex = 6;
            this.btnNavKhachHang.Text = "KHÁCH HÀNG";
            this.btnNavKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavKhachHang.TextOffset = new System.Drawing.Point(20, 0);
            this.btnNavKhachHang.UseTransparentBackground = true;
            // 
            // btnNavSanPham
            // 
            this.btnNavSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnNavSanPham.BorderRadius = 5;
            this.btnNavSanPham.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavSanPham.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnNavSanPham.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNavSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSanPham.FillColor = System.Drawing.Color.White;
            this.btnNavSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavSanPham.ForeColor = System.Drawing.Color.DimGray;
            this.btnNavSanPham.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavSanPham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavSanPham.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnNavSanPham.Location = new System.Drawing.Point(0, 215);
            this.btnNavSanPham.Name = "btnNavSanPham";
            this.btnNavSanPham.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNavSanPham.Size = new System.Drawing.Size(200, 50);
            this.btnNavSanPham.TabIndex = 4;
            this.btnNavSanPham.Text = "SẢN PHẨM";
            this.btnNavSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavSanPham.TextOffset = new System.Drawing.Point(20, 0);
            this.btnNavSanPham.UseTransparentBackground = true;
            // 
            // btnNavQuanLy
            // 
            this.btnNavQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.btnNavQuanLy.BorderRadius = 5;
            this.btnNavQuanLy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavQuanLy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnNavQuanLy.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNavQuanLy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavQuanLy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavQuanLy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavQuanLy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavQuanLy.FillColor = System.Drawing.Color.White;
            this.btnNavQuanLy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavQuanLy.ForeColor = System.Drawing.Color.DimGray;
            this.btnNavQuanLy.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavQuanLy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavQuanLy.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnNavQuanLy.Location = new System.Drawing.Point(0, 165);
            this.btnNavQuanLy.Name = "btnNavQuanLy";
            this.btnNavQuanLy.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNavQuanLy.Size = new System.Drawing.Size(200, 50);
            this.btnNavQuanLy.TabIndex = 3;
            this.btnNavQuanLy.Text = "QUẢN LÝ";
            this.btnNavQuanLy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavQuanLy.TextOffset = new System.Drawing.Point(20, 0);
            this.btnNavQuanLy.UseTransparentBackground = true;
            // 
            // btnNavBaoCao
            // 
            this.btnNavBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBaoCao.BorderRadius = 5;
            this.btnNavBaoCao.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavBaoCao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnNavBaoCao.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNavBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavBaoCao.FillColor = System.Drawing.Color.White;
            this.btnNavBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavBaoCao.ForeColor = System.Drawing.Color.DimGray;
            this.btnNavBaoCao.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavBaoCao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavBaoCao.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnNavBaoCao.Location = new System.Drawing.Point(0, 115);
            this.btnNavBaoCao.Name = "btnNavBaoCao";
            this.btnNavBaoCao.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNavBaoCao.Size = new System.Drawing.Size(200, 50);
            this.btnNavBaoCao.TabIndex = 2;
            this.btnNavBaoCao.Text = "BÁO CÁO";
            this.btnNavBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavBaoCao.TextOffset = new System.Drawing.Point(20, 0);
            this.btnNavBaoCao.UseTransparentBackground = true;
            // 
            // btnNavTrangChu
            // 
            this.btnNavTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTrangChu.BorderRadius = 5;
            this.btnNavTrangChu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNavTrangChu.Checked = true;
            this.btnNavTrangChu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnNavTrangChu.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnNavTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTrangChu.FillColor = System.Drawing.Color.White;
            this.btnNavTrangChu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavTrangChu.ForeColor = System.Drawing.Color.DimGray;
            this.btnNavTrangChu.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavTrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavTrangChu.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnNavTrangChu.Location = new System.Drawing.Point(0, 65);
            this.btnNavTrangChu.Name = "btnNavTrangChu";
            this.btnNavTrangChu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNavTrangChu.Size = new System.Drawing.Size(200, 50);
            this.btnNavTrangChu.TabIndex = 1;
            this.btnNavTrangChu.Text = "TRANG CHỦ";
            this.btnNavTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavTrangChu.TextOffset = new System.Drawing.Point(20, 0);
            this.btnNavTrangChu.UseTransparentBackground = true;
            // 
            // guna2PanelLogo
            // 
            this.guna2PanelLogo.Controls.Add(this.labelAppName);
            this.guna2PanelLogo.Controls.Add(this.pictureBoxLogo);
            this.guna2PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelLogo.Name = "guna2PanelLogo";
            this.guna2PanelLogo.Size = new System.Drawing.Size(200, 65);
            this.guna2PanelLogo.TabIndex = 0;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.BackColor = System.Drawing.Color.Transparent;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.labelAppName.Location = new System.Drawing.Point(65, 21);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(64, 28);
            this.labelAppName.TabIndex = 1;
            this.labelAppName.Text = "LOOP";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.ImageRotate = 0F;
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.UseTransparentBackground = true;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(200, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(1102, 720);
            this.panelMainContent.TabIndex = 2;
            // 
            // FormTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelLeftNav);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTrangChuAdmin";
            this.Size = new System.Drawing.Size(1302, 720);
            this.panelLeftNav.ResumeLayout(false);
            this.guna2PanelLogo.ResumeLayout(false);
            this.guna2PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelLeftNav;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLogo;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelAppName;
        private Guna.UI2.WinForms.Guna2Button btnNavTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnNavBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnNavQuanLy;
        private Guna.UI2.WinForms.Guna2Button btnNavSanPham;
        private Guna.UI2.WinForms.Guna2Button btnNavKhachHang;
        private Guna2Panel panelMainContent;
    }
}