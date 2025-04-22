// Voucher.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo
{
    partial class Voucher
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
            this.guna2PanelVoucherCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblVoucherCount = new System.Windows.Forms.Label();
            this.lblVoucherCountLabel = new System.Windows.Forms.Label();
            this.lblVoucherName = new System.Windows.Forms.Label();
            this.picVoucherImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelVoucherCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucherImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelVoucherCard
            // 
            this.guna2PanelVoucherCard.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelVoucherCard.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelVoucherCard.BorderRadius = 8;
            this.guna2PanelVoucherCard.BorderThickness = 1;
            this.guna2PanelVoucherCard.Controls.Add(this.lblVoucherCount);
            this.guna2PanelVoucherCard.Controls.Add(this.lblVoucherCountLabel);
            this.guna2PanelVoucherCard.Controls.Add(this.lblVoucherName);
            this.guna2PanelVoucherCard.Controls.Add(this.picVoucherImage);
            this.guna2PanelVoucherCard.FillColor = System.Drawing.Color.White;
            this.guna2PanelVoucherCard.Location = new System.Drawing.Point(7, 6);
            this.guna2PanelVoucherCard.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guna2PanelVoucherCard.Name = "guna2PanelVoucherCard";
            this.guna2PanelVoucherCard.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelVoucherCard.ShadowDecoration.Enabled = true;
            this.guna2PanelVoucherCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 5, 5);
            this.guna2PanelVoucherCard.Size = new System.Drawing.Size(327, 160);
            this.guna2PanelVoucherCard.TabIndex = 5;
            this.guna2PanelVoucherCard.UseTransparentBackground = true;
            // 
            // lblVoucherCount
            // 
            this.lblVoucherCount.AutoSize = true;
            this.lblVoucherCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVoucherCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVoucherCount.Location = new System.Drawing.Point(173, 129);
            this.lblVoucherCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoucherCount.Name = "lblVoucherCount";
            this.lblVoucherCount.Size = new System.Drawing.Size(18, 20);
            this.lblVoucherCount.TabIndex = 3;
            this.lblVoucherCount.Text = "1";
            // 
            // lblVoucherCountLabel
            // 
            this.lblVoucherCountLabel.AutoSize = true;
            this.lblVoucherCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVoucherCountLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblVoucherCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVoucherCountLabel.Location = new System.Drawing.Point(20, 129);
            this.lblVoucherCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoucherCountLabel.Name = "lblVoucherCountLabel";
            this.lblVoucherCountLabel.Size = new System.Drawing.Size(106, 20);
            this.lblVoucherCountLabel.TabIndex = 2;
            this.lblVoucherCountLabel.Text = "      Số voucher";
            this.lblVoucherCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVoucherName
            // 
            this.lblVoucherName.AutoSize = true;
            this.lblVoucherName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVoucherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVoucherName.Location = new System.Drawing.Point(173, 18);
            this.lblVoucherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoucherName.Name = "lblVoucherName";
            this.lblVoucherName.Size = new System.Drawing.Size(143, 23);
            this.lblVoucherName.TabIndex = 1;
            this.lblVoucherName.Text = "Example Voucher";
            // 
            // picVoucherImage
            // 
            this.picVoucherImage.BorderRadius = 5;
            this.picVoucherImage.ImageRotate = 0F;
            this.picVoucherImage.Location = new System.Drawing.Point(20, 18);
            this.picVoucherImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picVoucherImage.Name = "picVoucherImage";
            this.picVoucherImage.Size = new System.Drawing.Size(133, 92);
            this.picVoucherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVoucherImage.TabIndex = 0;
            this.picVoucherImage.TabStop = false;
            // 
            // Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelVoucherCard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Voucher";
            this.Size = new System.Drawing.Size(340, 172);
            this.guna2PanelVoucherCard.ResumeLayout(false);
            this.guna2PanelVoucherCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucherImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelVoucherCard;
        private Guna.UI2.WinForms.Guna2PictureBox picVoucherImage;
        private System.Windows.Forms.Label lblVoucherName;
        private System.Windows.Forms.Label lblVoucherCountLabel;
        private System.Windows.Forms.Label lblVoucherCount;
    }
}