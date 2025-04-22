// OrderItems.Designer.cs
// Lưu ý: Tên lớp là OrderItems theo yêu cầu của bạn.

using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.HienThiGoc // Sử dụng namespace đã dùng trước đó
{
    partial class OrderItemCard // Đổi tên lớp thành OrderItems
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
            this.picItemImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblDetail1 = new System.Windows.Forms.Label();
            this.lblDetail2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picItemImage
            // 
            this.picItemImage.BorderRadius = 5;
            this.picItemImage.ImageRotate = 0F;
            this.picItemImage.Location = new System.Drawing.Point(13, 12);
            this.picItemImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picItemImage.Name = "picItemImage";
            this.picItemImage.Size = new System.Drawing.Size(80, 74);
            this.picItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemImage.TabIndex = 0;
            this.picItemImage.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Location = new System.Drawing.Point(107, 12);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(240, 25);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Ham and Cheese Baked Rice";
            // 
            // lblDetail1
            // 
            this.lblDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetail1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDetail1.ForeColor = System.Drawing.Color.Gray;
            this.lblDetail1.Location = new System.Drawing.Point(107, 41);
            this.lblDetail1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetail1.Name = "lblDetail1";
            this.lblDetail1.Size = new System.Drawing.Size(260, 18);
            this.lblDetail1.TabIndex = 2;
            this.lblDetail1.Text = "- Healthy Options (Food) No Oil";
            // 
            // lblDetail2
            // 
            this.lblDetail2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetail2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDetail2.ForeColor = System.Drawing.Color.Gray;
            this.lblDetail2.Location = new System.Drawing.Point(107, 62);
            this.lblDetail2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetail2.Name = "lblDetail2";
            this.lblDetail2.Size = new System.Drawing.Size(260, 18);
            this.lblDetail2.TabIndex = 3;
            this.lblDetail2.Text = "- Pasta Cheese x2";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.lblPrice.Location = new System.Drawing.Point(105, 89);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(107, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "318.000 VND";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuantity.Location = new System.Drawing.Point(367, 10);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(33, 25);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "2";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnDeleteItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDeleteItem.Location = new System.Drawing.Point(363, 52);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDeleteItem.Size = new System.Drawing.Size(37, 34);
            this.btnDeleteItem.TabIndex = 6;
            this.btnDeleteItem.Text = "X";
            this.btnDeleteItem.UseTransparentBackground = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator1.Location = new System.Drawing.Point(13, 117);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(387, 12);
            this.guna2Separator1.TabIndex = 7;
            // 
            // OrderItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDetail2);
            this.Controls.Add(this.lblDetail1);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.picItemImage);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Name = "OrderItemCard";
            this.Size = new System.Drawing.Size(413, 129);
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picItemImage;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDetail1;
        private System.Windows.Forms.Label lblDetail2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2CircleButton btnDeleteItem;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}