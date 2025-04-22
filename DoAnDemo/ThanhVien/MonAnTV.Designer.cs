// MonAnTV.Designer.cs (Thêm các control và điều chỉnh layout)
namespace DoAnDemo
{
    partial class MonAnTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonAnTV));
            this.guna2PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDecrease = new Guna.UI2.WinForms.Guna2CircleButton(); // <<< THÊM NÚT TRỪ
            this.btnIncrease = new Guna.UI2.WinForms.Guna2CircleButton(); // <<< THÊM NÚT CỘNG
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.picFoodImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoodImage)).BeginInit();
            this.SuspendLayout();
            //
            // guna2PanelMain
            //
            this.guna2PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelMain.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelMain.BorderRadius = 8;
            this.guna2PanelMain.BorderThickness = 1;
            this.guna2PanelMain.Controls.Add(this.btnDecrease); // <<< THÊM
            this.guna2PanelMain.Controls.Add(this.btnIncrease); // <<< THÊM
            this.guna2PanelMain.Controls.Add(this.lblPrice);
            this.guna2PanelMain.Controls.Add(this.lblFoodName);
            this.guna2PanelMain.Controls.Add(this.picFoodImage);
            this.guna2PanelMain.FillColor = System.Drawing.Color.White;
            this.guna2PanelMain.Location = new System.Drawing.Point(5, 5);
            this.guna2PanelMain.Margin = new System.Windows.Forms.Padding(5);
            this.guna2PanelMain.Name = "guna2PanelMain";
            this.guna2PanelMain.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelMain.ShadowDecoration.Enabled = true;
            this.guna2PanelMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 2, 2);
            this.guna2PanelMain.Size = new System.Drawing.Size(180, 100); // << Tăng chiều cao 1 chút
            this.guna2PanelMain.TabIndex = 0;
            this.guna2PanelMain.UseTransparentBackground = true;
            //
            // btnDecrease
            //
            this.btnDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrease.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230))))); // Màu hồng nhạt
            this.btnDecrease.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDecrease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu hồng đậm
            this.btnDecrease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDecrease.Location = new System.Drawing.Point(112, 67); // Vị trí nút trừ
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDecrease.Size = new System.Drawing.Size(28, 28);
            this.btnDecrease.TabIndex = 4;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseTransparentBackground = true;
            //
            // btnIncrease
            //
            this.btnIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncrease.BackColor = System.Drawing.Color.Transparent;
            this.btnIncrease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu hồng đậm
            this.btnIncrease.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIncrease.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnIncrease.Location = new System.Drawing.Point(145, 67); // Vị trí nút cộng
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnIncrease.Size = new System.Drawing.Size(28, 28);
            this.btnIncrease.TabIndex = 3;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseTransparentBackground = true;
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(65, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "50.000 VND";
            //
            // lblFoodName
            //
            this.lblFoodName.AutoEllipsis = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFoodName.Location = new System.Drawing.Point(65, 15);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(108, 20); // Giảm chiều rộng để chừa chỗ cho nút
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "Example Food Long Name";
            //
            // picFoodImage
            //
            this.picFoodImage.BorderRadius = 5;
            this.picFoodImage.Image = ((System.Drawing.Image)(resources.GetObject("picFoodImage.Image")));
            this.picFoodImage.ImageRotate = 0F;
            this.picFoodImage.Location = new System.Drawing.Point(10, 10);
            this.picFoodImage.Name = "picFoodImage";
            this.picFoodImage.Size = new System.Drawing.Size(50, 50);
            this.picFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoodImage.TabIndex = 0;
            this.picFoodImage.TabStop = false;
            //
            // MonAnTV
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelMain);
            this.Name = "MonAnTV";
            this.Size = new System.Drawing.Size(190, 110); // << Tăng chiều cao control
            this.guna2PanelMain.ResumeLayout(false);
            this.guna2PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelMain;
        private Guna.UI2.WinForms.Guna2PictureBox picFoodImage;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2CircleButton btnIncrease; // <<< KHAI BÁO
        private Guna.UI2.WinForms.Guna2CircleButton btnDecrease; // <<< KHAI BÁO
    }
}