// Gift.Designer.cs
namespace DoAnDemo
{
    partial class Gift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gift));
            this.guna2PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPointsRequired = new System.Windows.Forms.Label();
            this.lblGiftName = new System.Windows.Forms.Label();
            this.picGiftImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRedeem = new Guna.UI2.WinForms.Guna2Button(); // Thêm nút đổi quà (ví dụ)
            this.guna2PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGiftImage)).BeginInit();
            this.SuspendLayout();
            //
            // guna2PanelMain
            //
            this.guna2PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelMain.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelMain.BorderRadius = 8;
            this.guna2PanelMain.BorderThickness = 1;
            this.guna2PanelMain.Controls.Add(this.btnRedeem); // Thêm nút đổi quà vào panel
            this.guna2PanelMain.Controls.Add(this.lblPointsRequired);
            this.guna2PanelMain.Controls.Add(this.lblGiftName);
            this.guna2PanelMain.Controls.Add(this.picGiftImage);
            this.guna2PanelMain.FillColor = System.Drawing.Color.White;
            this.guna2PanelMain.Location = new System.Drawing.Point(5, 5);
            this.guna2PanelMain.Margin = new System.Windows.Forms.Padding(5);
            this.guna2PanelMain.Name = "guna2PanelMain";
            this.guna2PanelMain.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelMain.ShadowDecoration.Enabled = true;
            this.guna2PanelMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 3, 3);
            this.guna2PanelMain.Size = new System.Drawing.Size(150, 160); // Tăng chiều cao để chứa nút
            this.guna2PanelMain.TabIndex = 1;
            this.guna2PanelMain.UseTransparentBackground = true;
            //
            // lblPointsRequired
            //
            this.lblPointsRequired.AutoSize = true;
            this.lblPointsRequired.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPointsRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu hồng/đỏ
            this.lblPointsRequired.Location = new System.Drawing.Point(10, 100);
            this.lblPointsRequired.Name = "lblPointsRequired";
            this.lblPointsRequired.Size = new System.Drawing.Size(58, 15);
            this.lblPointsRequired.TabIndex = 2;
            this.lblPointsRequired.Text = "100 Điểm";
            //
            // lblGiftName
            //
            this.lblGiftName.AutoEllipsis = true;
            this.lblGiftName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGiftName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiftName.Location = new System.Drawing.Point(10, 75);
            this.lblGiftName.Name = "lblGiftName";
            this.lblGiftName.Size = new System.Drawing.Size(130, 20); // Giới hạn chiều rộng
            this.lblGiftName.TabIndex = 1;
            this.lblGiftName.Text = "Ly Sứ Cao Cấp";
            //
            // picGiftImage
            //
            this.picGiftImage.BorderRadius = 5;
            this.picGiftImage.Image = ((System.Drawing.Image)(resources.GetObject("picGiftImage.Image"))); // Placeholder Image
            this.picGiftImage.ImageRotate = 0F;
            this.picGiftImage.Location = new System.Drawing.Point(10, 10);
            this.picGiftImage.Name = "picGiftImage";
            this.picGiftImage.Size = new System.Drawing.Size(130, 55); // Kích thước ảnh
            this.picGiftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGiftImage.TabIndex = 0;
            this.picGiftImage.TabStop = false;
            //
            // btnRedeem
            //
            this.btnRedeem.BorderRadius = 5;
            this.btnRedeem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRedeem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRedeem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRedeem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRedeem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(153))))); // Màu xanh lá cây
            this.btnRedeem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRedeem.ForeColor = System.Drawing.Color.White;
            this.btnRedeem.Location = new System.Drawing.Point(13, 120); // Vị trí nút đổi quà
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(124, 30);
            this.btnRedeem.TabIndex = 3;
            this.btnRedeem.Text = "Đổi quà";
            //
            // Gift
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelMain);
            this.Name = "Gift";
            this.Size = new System.Drawing.Size(160, 170); // Kích thước control
            this.guna2PanelMain.ResumeLayout(false);
            this.guna2PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGiftImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelMain;
        private Guna.UI2.WinForms.Guna2PictureBox picGiftImage;
        private System.Windows.Forms.Label lblGiftName;
        private System.Windows.Forms.Label lblPointsRequired;
        private Guna.UI2.WinForms.Guna2Button btnRedeem;
    }
}