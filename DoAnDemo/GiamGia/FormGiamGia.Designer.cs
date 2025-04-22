// FormGiamGia.Designer.cs (Modified)
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using DoAnDemo.GiamGia;

namespace DoAnDemo
{
    partial class FormGiamGia
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
            this.guna2PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelDiscounts = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMaVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2PanelMain.SuspendLayout();
            this.guna2PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelMain
            // 
            this.guna2PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelMain.BorderRadius = 10;
            this.guna2PanelMain.Controls.Add(this.btnXacNhan);
            this.guna2PanelMain.Controls.Add(this.btnThoat);
            this.guna2PanelMain.Controls.Add(this.flowLayoutPanelDiscounts);
            this.guna2PanelMain.Controls.Add(this.txtMaVoucher);
            this.guna2PanelMain.Controls.Add(this.guna2PanelTitleBar);
            this.guna2PanelMain.FillColor = System.Drawing.Color.White;
            this.guna2PanelMain.Location = new System.Drawing.Point(13, 12);
            this.guna2PanelMain.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.guna2PanelMain.Name = "guna2PanelMain";
            this.guna2PanelMain.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2PanelMain.ShadowDecoration.Enabled = true;
            this.guna2PanelMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.guna2PanelMain.Size = new System.Drawing.Size(667, 591);
            this.guna2PanelMain.TabIndex = 0;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BorderRadius = 5;
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnXacNhan.Location = new System.Drawing.Point(496, 526);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(147, 49);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.BorderRadius = 5;
            this.btnThoat.BorderThickness = 1;
            this.btnThoat.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Location = new System.Drawing.Point(24, 526);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            // 
            // flowLayoutPanelDiscounts
            // 
            this.flowLayoutPanelDiscounts.Location = new System.Drawing.Point(24, 140);
            this.flowLayoutPanelDiscounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelDiscounts.Name = "flowLayoutPanelDiscounts";
            this.flowLayoutPanelDiscounts.Size = new System.Drawing.Size(619, 378);
            this.flowLayoutPanelDiscounts.TabIndex = 5;
            // 
            // txtMaVoucher
            // 
            this.txtMaVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaVoucher.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMaVoucher.BorderRadius = 5;
            this.txtMaVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVoucher.DefaultText = "";
            this.txtMaVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaVoucher.Location = new System.Drawing.Point(24, 78);
            this.txtMaVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaVoucher.Name = "txtMaVoucher";
            this.txtMaVoucher.PlaceholderText = "Nhập mã voucher";
            this.txtMaVoucher.SelectedText = "";
            this.txtMaVoucher.Size = new System.Drawing.Size(619, 44);
            this.txtMaVoucher.TabIndex = 1;
            // 
            // guna2PanelTitleBar
            // 
            this.guna2PanelTitleBar.Controls.Add(this.lblTitle);
            this.guna2PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTitleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PanelTitleBar.Name = "guna2PanelTitleBar";
            this.guna2PanelTitleBar.Size = new System.Drawing.Size(667, 62);
            this.guna2PanelTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(173, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách giảm giá có thể áp dụng";
            // 
            // FormGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.guna2PanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGiamGia";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Size = new System.Drawing.Size(693, 615);
            this.guna2PanelMain.ResumeLayout(false);
            this.guna2PanelTitleBar.ResumeLayout(false);
            this.guna2PanelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelMain;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtMaVoucher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDiscounts;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
    }
}