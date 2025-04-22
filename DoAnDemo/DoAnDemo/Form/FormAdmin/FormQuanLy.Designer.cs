// FormQuanLy.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.Form.FormAdmin
{
    partial class FormQuanLy
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
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSubContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelInfoCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTiLeDoiDiem = new Guna.UI2.WinForms.Guna2Panel();
            this.iconTiLeDoiDiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblValueTiLeDoiDiem = new System.Windows.Forms.Label();
            this.lblTitleTiLeDoiDiem = new System.Windows.Forms.Label();
            this.cardSoNhanVien = new Guna.UI2.WinForms.Guna2Panel();
            this.iconSoNhanVien = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblValueSoNhanVien = new System.Windows.Forms.Label();
            this.lblTitleSoNhanVien = new System.Windows.Forms.Label();
            this.panelTabs = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTabNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnTabGiamGia = new Guna.UI2.WinForms.Guna2Button();
            this.btnTabTongHop = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblSubHeaderTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelInfoCards.SuspendLayout();
            this.cardTiLeDoiDiem.SuspendLayout();
            this.cardSoNhanVien.SuspendLayout();
            this.panelTabs.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.panelHeader.ShadowDecoration.Enabled = true;
            this.panelHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelHeader.Size = new System.Drawing.Size(1302, 55);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMainContent.Controls.Add(this.panelSubContent);
            this.panelMainContent.Controls.Add(this.panelInfoCards);
            this.panelMainContent.Controls.Add(this.panelTabs);
            this.panelMainContent.Controls.Add(this.lblSubHeaderSubtitle);
            this.panelMainContent.Controls.Add(this.lblSubHeaderTitle);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 55);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(1302, 665);
            this.panelMainContent.TabIndex = 3;
            // 
            // panelSubContent
            // 
            this.panelSubContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubContent.Location = new System.Drawing.Point(20, 155);
            this.panelSubContent.Name = "panelSubContent";
            this.panelSubContent.Size = new System.Drawing.Size(1262, 490);
            this.panelSubContent.TabIndex = 4;
            // 
            // panelInfoCards
            // 
            this.panelInfoCards.AutoSize = true;
            this.panelInfoCards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInfoCards.Controls.Add(this.cardTiLeDoiDiem);
            this.panelInfoCards.Controls.Add(this.cardSoNhanVien);
            this.panelInfoCards.Controls.Add(this.guna2Panel1);
            this.panelInfoCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoCards.Location = new System.Drawing.Point(20, 70);
            this.panelInfoCards.Name = "panelInfoCards";
            this.panelInfoCards.Size = new System.Drawing.Size(1262, 85);
            this.panelInfoCards.TabIndex = 3;
            this.panelInfoCards.WrapContents = false;
            // 
            // cardTiLeDoiDiem
            // 
            this.cardTiLeDoiDiem.BackColor = System.Drawing.Color.Transparent;
            this.cardTiLeDoiDiem.BorderRadius = 8;
            this.cardTiLeDoiDiem.Controls.Add(this.iconTiLeDoiDiem);
            this.cardTiLeDoiDiem.Controls.Add(this.lblValueTiLeDoiDiem);
            this.cardTiLeDoiDiem.Controls.Add(this.lblTitleTiLeDoiDiem);
            this.cardTiLeDoiDiem.FillColor = System.Drawing.Color.White;
            this.cardTiLeDoiDiem.Location = new System.Drawing.Point(3, 3);
            this.cardTiLeDoiDiem.Name = "cardTiLeDoiDiem";
            this.cardTiLeDoiDiem.ShadowDecoration.Color = System.Drawing.Color.Gainsboro;
            this.cardTiLeDoiDiem.ShadowDecoration.Enabled = true;
            this.cardTiLeDoiDiem.Size = new System.Drawing.Size(250, 79);
            this.cardTiLeDoiDiem.TabIndex = 0;
            // 
            // iconTiLeDoiDiem
            // 
            this.iconTiLeDoiDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iconTiLeDoiDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconTiLeDoiDiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.iconTiLeDoiDiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconTiLeDoiDiem.ForeColor = System.Drawing.Color.White;
            this.iconTiLeDoiDiem.Location = new System.Drawing.Point(195, 20);
            this.iconTiLeDoiDiem.Name = "iconTiLeDoiDiem";
            this.iconTiLeDoiDiem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.iconTiLeDoiDiem.Size = new System.Drawing.Size(40, 40);
            this.iconTiLeDoiDiem.TabIndex = 2;
            // 
            // lblValueTiLeDoiDiem
            // 
            this.lblValueTiLeDoiDiem.AutoSize = true;
            this.lblValueTiLeDoiDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValueTiLeDoiDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValueTiLeDoiDiem.Location = new System.Drawing.Point(15, 40);
            this.lblValueTiLeDoiDiem.Name = "lblValueTiLeDoiDiem";
            this.lblValueTiLeDoiDiem.Size = new System.Drawing.Size(95, 20);
            this.lblValueTiLeDoiDiem.TabIndex = 1;
            this.lblValueTiLeDoiDiem.Text = "10,000 VND";
            // 
            // lblTitleTiLeDoiDiem
            // 
            this.lblTitleTiLeDoiDiem.AutoSize = true;
            this.lblTitleTiLeDoiDiem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTitleTiLeDoiDiem.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleTiLeDoiDiem.Location = new System.Drawing.Point(15, 15);
            this.lblTitleTiLeDoiDiem.Name = "lblTitleTiLeDoiDiem";
            this.lblTitleTiLeDoiDiem.Size = new System.Drawing.Size(111, 19);
            this.lblTitleTiLeDoiDiem.TabIndex = 0;
            this.lblTitleTiLeDoiDiem.Text = "TỶ LỆ ĐỔI ĐIỂM";
            // 
            // cardSoNhanVien
            // 
            this.cardSoNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cardSoNhanVien.Controls.Add(this.iconSoNhanVien);
            this.cardSoNhanVien.Controls.Add(this.lblValueSoNhanVien);
            this.cardSoNhanVien.Controls.Add(this.lblTitleSoNhanVien);
            this.cardSoNhanVien.Location = new System.Drawing.Point(259, 3);
            this.cardSoNhanVien.Name = "cardSoNhanVien";
            this.cardSoNhanVien.Size = new System.Drawing.Size(250, 79);
            this.cardSoNhanVien.TabIndex = 2;
            // 
            // iconSoNhanVien
            // 
            this.iconSoNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.iconSoNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconSoNhanVien.ForeColor = System.Drawing.Color.White;
            this.iconSoNhanVien.Location = new System.Drawing.Point(195, 20);
            this.iconSoNhanVien.Name = "iconSoNhanVien";
            this.iconSoNhanVien.Size = new System.Drawing.Size(40, 40);
            this.iconSoNhanVien.TabIndex = 0;
            // 
            // lblValueSoNhanVien
            // 
            this.lblValueSoNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueSoNhanVien.Location = new System.Drawing.Point(15, 40);
            this.lblValueSoNhanVien.Name = "lblValueSoNhanVien";
            this.lblValueSoNhanVien.Size = new System.Drawing.Size(100, 23);
            this.lblValueSoNhanVien.TabIndex = 1;
            this.lblValueSoNhanVien.Text = "31";
            // 
            // lblTitleSoNhanVien
            // 
            this.lblTitleSoNhanVien.Location = new System.Drawing.Point(15, 15);
            this.lblTitleSoNhanVien.Name = "lblTitleSoNhanVien";
            this.lblTitleSoNhanVien.Size = new System.Drawing.Size(100, 23);
            this.lblTitleSoNhanVien.TabIndex = 2;
            this.lblTitleSoNhanVien.Text = "SỐ NHÂN VIÊN";
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.White;
            this.panelTabs.Controls.Add(this.btnTabNhanVien);
            this.panelTabs.Controls.Add(this.btnTabGiamGia);
            this.panelTabs.Controls.Add(this.btnTabTongHop);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabs.Location = new System.Drawing.Point(20, 20);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(1262, 50);
            this.panelTabs.TabIndex = 2;
            // 
            // btnTabNhanVien
            // 
            this.btnTabNhanVien.DefaultAutoSize = true;
            this.btnTabNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTabNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnTabNhanVien.Location = new System.Drawing.Point(324, 0);
            this.btnTabNhanVien.Name = "btnTabNhanVien";
            this.btnTabNhanVien.Size = new System.Drawing.Size(112, 50);
            this.btnTabNhanVien.TabIndex = 2;
            this.btnTabNhanVien.Text = "NHÂN VIÊN";
            // 
            // btnTabGiamGia
            // 
            this.btnTabGiamGia.DefaultAutoSize = true;
            this.btnTabGiamGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTabGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabGiamGia.ForeColor = System.Drawing.Color.White;
            this.btnTabGiamGia.Location = new System.Drawing.Point(108, 0);
            this.btnTabGiamGia.Name = "btnTabGiamGia";
            this.btnTabGiamGia.Size = new System.Drawing.Size(216, 50);
            this.btnTabGiamGia.TabIndex = 4;
            this.btnTabGiamGia.Text = "CHƯƠNG TRÌNH GIẢM GIÁ";
            // 
            // btnTabTongHop
            // 
            this.btnTabTongHop.Checked = true;
            this.btnTabTongHop.DefaultAutoSize = true;
            this.btnTabTongHop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTabTongHop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabTongHop.ForeColor = System.Drawing.Color.White;
            this.btnTabTongHop.Location = new System.Drawing.Point(0, 0);
            this.btnTabTongHop.Name = "btnTabTongHop";
            this.btnTabTongHop.Size = new System.Drawing.Size(108, 50);
            this.btnTabTongHop.TabIndex = 7;
            this.btnTabTongHop.Text = "TỔNG HỢP";
            // 
            // lblSubHeaderSubtitle
            // 
            this.lblSubHeaderSubtitle.AutoSize = true;
            this.lblSubHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubHeaderSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubHeaderSubtitle.Location = new System.Drawing.Point(20, 40);
            this.lblSubHeaderSubtitle.Name = "lblSubHeaderSubtitle";
            this.lblSubHeaderSubtitle.Size = new System.Drawing.Size(276, 20);
            this.lblSubHeaderSubtitle.TabIndex = 1;
            this.lblSubHeaderSubtitle.Text = "Thống kê chung về thương hiệu của bạn.";
            // 
            // lblSubHeaderTitle
            // 
            this.lblSubHeaderTitle.AutoSize = true;
            this.lblSubHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubHeaderTitle.Location = new System.Drawing.Point(18, 15);
            this.lblSubHeaderTitle.Name = "lblSubHeaderTitle";
            this.lblSubHeaderTitle.Size = new System.Drawing.Size(134, 28);
            this.lblSubHeaderTitle.TabIndex = 0;
            this.lblSubHeaderTitle.Text = "TỔNG QUAN";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(515, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(250, 79);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(195, 20);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Voucher";
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormQuanLy";
            this.Size = new System.Drawing.Size(1302, 720);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            this.panelInfoCards.ResumeLayout(false);
            this.cardTiLeDoiDiem.ResumeLayout(false);
            this.cardTiLeDoiDiem.PerformLayout();
            this.cardSoNhanVien.ResumeLayout(false);
            this.panelTabs.ResumeLayout(false);
            this.panelTabs.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel panelMainContent;
        private System.Windows.Forms.Label lblSubHeaderSubtitle;
        private System.Windows.Forms.Label lblSubHeaderTitle;
        private Guna.UI2.WinForms.Guna2Panel panelTabs;
        private Guna.UI2.WinForms.Guna2Button btnTabTongHop;
        // No btnTabBan declaration
        private Guna.UI2.WinForms.Guna2Button btnTabGiamGia;
        private Guna.UI2.WinForms.Guna2Button btnTabNhanVien;
        private System.Windows.Forms.FlowLayoutPanel panelInfoCards;
        private Guna.UI2.WinForms.Guna2Panel cardTiLeDoiDiem;
        private Guna.UI2.WinForms.Guna2CircleButton iconTiLeDoiDiem;
        private System.Windows.Forms.Label lblValueTiLeDoiDiem;
        private System.Windows.Forms.Label lblTitleTiLeDoiDiem;
        private Guna.UI2.WinForms.Guna2Panel cardSoNhanVien;
        private Guna.UI2.WinForms.Guna2CircleButton iconSoNhanVien;
        private System.Windows.Forms.Label lblValueSoNhanVien;
        private System.Windows.Forms.Label lblTitleSoNhanVien;
        private Guna.UI2.WinForms.Guna2Panel panelSubContent;
        private Guna2Panel guna2Panel1;
        private Guna2CircleButton guna2CircleButton1;
        private Label label1;
        private Label label2;
    }
}