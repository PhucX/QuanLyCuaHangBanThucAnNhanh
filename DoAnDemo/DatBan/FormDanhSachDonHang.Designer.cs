// FormDanhSachDonHang.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using DoAnDemo.DatBan;

namespace DoAnDemo.DatBan
{
    partial class FormDanhSachDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachDonHang));
            this.guna2PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrintBill = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowLayoutPanelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PanelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThanhToanValue = new System.Windows.Forms.Label();
            this.lblThanhToanLabel = new System.Windows.Forms.Label();
            this.lblGiamGiaValue = new System.Windows.Forms.Label();
            this.lblGiamGiaLabel = new System.Windows.Forms.Label();
            this.lblTongTienValue = new System.Windows.Forms.Label();
            this.lblTongTienLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picHeaderImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelTopInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.picUserIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelMain.SuspendLayout();
            this.flowLayoutPanelItems.SuspendLayout();
            this.guna2PanelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderImage)).BeginInit();
            this.guna2PanelTopInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelMain
            // 
            this.guna2PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelMain.BorderRadius = 10;
            this.guna2PanelMain.Controls.Add(this.btnPrintBill);
            this.guna2PanelMain.Controls.Add(this.flowLayoutPanelItems);
            this.guna2PanelMain.Controls.Add(this.guna2Separator1);
            this.guna2PanelMain.Controls.Add(this.guna2PanelSummary);
            this.guna2PanelMain.Controls.Add(this.lblTitle);
            this.guna2PanelMain.Controls.Add(this.picHeaderImage);
            this.guna2PanelMain.Controls.Add(this.guna2PanelTopInfo);
            this.guna2PanelMain.FillColor = System.Drawing.Color.White;
            this.guna2PanelMain.Location = new System.Drawing.Point(5, 5); // Add padding/margin around the control
            this.guna2PanelMain.Margin = new System.Windows.Forms.Padding(5);
            this.guna2PanelMain.Name = "guna2PanelMain";
            this.guna2PanelMain.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2PanelMain.ShadowDecoration.Enabled = true;
            this.guna2PanelMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.guna2PanelMain.Size = new System.Drawing.Size(400, 550); // Adjust popup size
            this.guna2PanelMain.TabIndex = 0;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintBill.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrintBill.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnPrintBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.Image"))); // <<<--- ADD PRINT ICON RESOURCE HERE (GRAY)
            this.btnPrintBill.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPrintBill.ImageRotate = 0F;
            this.btnPrintBill.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrintBill.Location = new System.Drawing.Point(357, 507);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPrintBill.Size = new System.Drawing.Size(30, 30);
            this.btnPrintBill.TabIndex = 6;
            this.btnPrintBill.UseTransparentBackground = true;
            // 
            // flowLayoutPanelItems
            // 
            this.flowLayoutPanelItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelItems.AutoScroll = true;
            this.flowLayoutPanelItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelItems.Location = new System.Drawing.Point(20, 265); // Position below separator
            this.flowLayoutPanelItems.Name = "flowLayoutPanelItems";
            this.flowLayoutPanelItems.Size = new System.Drawing.Size(360, 235); // Adjust size
            this.flowLayoutPanelItems.TabIndex = 5;
            this.flowLayoutPanelItems.WrapContents = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator1.Location = new System.Drawing.Point(20, 255);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(360, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // guna2PanelSummary
            // 
            this.guna2PanelSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelSummary.Controls.Add(this.lblThanhToanValue);
            this.guna2PanelSummary.Controls.Add(this.lblThanhToanLabel);
            this.guna2PanelSummary.Controls.Add(this.lblGiamGiaValue);
            this.guna2PanelSummary.Controls.Add(this.lblGiamGiaLabel);
            this.guna2PanelSummary.Controls.Add(this.lblTongTienValue);
            this.guna2PanelSummary.Controls.Add(this.lblTongTienLabel);
            this.guna2PanelSummary.Location = new System.Drawing.Point(15, 195); // Position below title
            this.guna2PanelSummary.Name = "guna2PanelSummary";
            this.guna2PanelSummary.Size = new System.Drawing.Size(370, 55);
            this.guna2PanelSummary.TabIndex = 3;
            // 
            // lblThanhToanValue
            // 
            this.lblThanhToanValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThanhToanValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblThanhToanValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Pink
            this.lblThanhToanValue.Location = new System.Drawing.Point(250, 30);
            this.lblThanhToanValue.Name = "lblThanhToanValue";
            this.lblThanhToanValue.Size = new System.Drawing.Size(115, 17);
            this.lblThanhToanValue.TabIndex = 5;
            this.lblThanhToanValue.Text = "140.000 VND";
            this.lblThanhToanValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThanhToanLabel
            // 
            this.lblThanhToanLabel.AutoSize = true;
            this.lblThanhToanLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThanhToanLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblThanhToanLabel.Location = new System.Drawing.Point(280, 5); // Align Right Column
            this.lblThanhToanLabel.Name = "lblThanhToanLabel";
            this.lblThanhToanLabel.Size = new System.Drawing.Size(67, 15);
            this.lblThanhToanLabel.TabIndex = 4;
            this.lblThanhToanLabel.Text = "Thanh toán";
            // 
            // lblGiamGiaValue
            // 
            this.lblGiamGiaValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGiamGiaValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGiamGiaValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiamGiaValue.Location = new System.Drawing.Point(127, 30);
            this.lblGiamGiaValue.Name = "lblGiamGiaValue";
            this.lblGiamGiaValue.Size = new System.Drawing.Size(115, 17);
            this.lblGiamGiaValue.TabIndex = 3;
            this.lblGiamGiaValue.Text = "0 VND";
            this.lblGiamGiaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGiamGiaLabel
            // 
            this.lblGiamGiaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGiamGiaLabel.AutoSize = true;
            this.lblGiamGiaLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGiamGiaLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblGiamGiaLabel.Location = new System.Drawing.Point(155, 5); // Align Middle Column
            this.lblGiamGiaLabel.Name = "lblGiamGiaLabel";
            this.lblGiamGiaLabel.Size = new System.Drawing.Size(54, 15);
            this.lblGiamGiaLabel.TabIndex = 2;
            this.lblGiamGiaLabel.Text = "Giảm giá";
            // 
            // lblTongTienValue
            // 
            this.lblTongTienValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTongTienValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTongTienValue.Location = new System.Drawing.Point(5, 30);
            this.lblTongTienValue.Name = "lblTongTienValue";
            this.lblTongTienValue.Size = new System.Drawing.Size(115, 17);
            this.lblTongTienValue.TabIndex = 1;
            this.lblTongTienValue.Text = "140.000 VND";
            this.lblTongTienValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTongTienLabel
            // 
            this.lblTongTienLabel.AutoSize = true;
            this.lblTongTienLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongTienLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblTongTienLabel.Location = new System.Drawing.Point(5, 5); // Align Left Column
            this.lblTongTienLabel.Name = "lblTongTienLabel";
            this.lblTongTienLabel.Size = new System.Drawing.Size(57, 15);
            this.lblTongTienLabel.TabIndex = 0;
            this.lblTongTienLabel.Text = "Tổng tiền";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(135, 170); // Adjust position
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Thông tin đơn hàng";
            // 
            // picHeaderImage
            // 
            this.picHeaderImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHeaderImage.Image = ((System.Drawing.Image)(resources.GetObject("picHeaderImage.Image"))); // <<<--- ADD HEADER IMAGE RESOURCE
            this.picHeaderImage.ImageRotate = 0F;
            this.picHeaderImage.Location = new System.Drawing.Point(15, 60); // Position below top info
            this.picHeaderImage.Name = "picHeaderImage";
            this.picHeaderImage.Size = new System.Drawing.Size(370, 100); // Adjust size
            this.picHeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeaderImage.TabIndex = 1;
            this.picHeaderImage.TabStop = false;
            // 
            // guna2PanelTopInfo
            // 
            this.guna2PanelTopInfo.Controls.Add(this.btnClose);
            this.guna2PanelTopInfo.Controls.Add(this.lblTableInfo);
            this.guna2PanelTopInfo.Controls.Add(this.picUserIcon);
            this.guna2PanelTopInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTopInfo.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTopInfo.Name = "guna2PanelTopInfo";
            this.guna2PanelTopInfo.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.guna2PanelTopInfo.Size = new System.Drawing.Size(400, 50);
            this.guna2PanelTopInfo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image"))); // <<<--- ADD CLOSE ICON (X) RESOURCE HERE
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(357, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseTransparentBackground = true;
            // 
            // lblTableInfo
            // 
            this.lblTableInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTableInfo.AutoSize = true;
            this.lblTableInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTableInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTableInfo.Location = new System.Drawing.Point(156, 15); // Adjust for centering
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(88, 20);
            this.lblTableInfo.TabIndex = 1;
            this.lblTableInfo.Text = "Bàn 2 Tầng 1";
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("picUserIcon.Image"))); // <<<--- ADD USER ICON RESOURCE HERE
            this.picUserIcon.ImageRotate = 0F;
            this.picUserIcon.Location = new System.Drawing.Point(13, 8);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(35, 35);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 0;
            this.picUserIcon.TabStop = false;
            // 
            // FormDanhSachDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))); // Light background for the UC itself
            this.Controls.Add(this.guna2PanelMain);
            this.Name = "FormDanhSachDonHang";
            this.Padding = new System.Windows.Forms.Padding(5); // Padding around the main panel
            this.Size = new System.Drawing.Size(410, 560); // Size of the UserControl popup
            this.guna2PanelMain.ResumeLayout(false);
            this.guna2PanelMain.PerformLayout();
            this.flowLayoutPanelItems.ResumeLayout(false);
            this.guna2PanelSummary.ResumeLayout(false);
            this.guna2PanelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderImage)).EndInit();
            this.guna2PanelTopInfo.ResumeLayout(false);
            this.guna2PanelTopInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelMain;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTopInfo;
        private Guna.UI2.WinForms.Guna2PictureBox picUserIcon;
        private System.Windows.Forms.Label lblTableInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2PictureBox picHeaderImage;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSummary;
        private System.Windows.Forms.Label lblTongTienLabel;
        private System.Windows.Forms.Label lblTongTienValue;
        private System.Windows.Forms.Label lblGiamGiaLabel;
        private System.Windows.Forms.Label lblGiamGiaValue;
        private System.Windows.Forms.Label lblThanhToanLabel;
        private System.Windows.Forms.Label lblThanhToanValue;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrintBill;
    }
}