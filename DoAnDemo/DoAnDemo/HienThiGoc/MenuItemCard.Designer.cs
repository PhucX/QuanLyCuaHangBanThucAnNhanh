// MenuItemCard.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.HienThiGoc
{
    partial class MenuItemCard
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
            this.guna2PanelCard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.picItemImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelCard
            // 
            this.guna2PanelCard.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelCard.BorderRadius = 8;
            this.guna2PanelCard.BorderThickness = 1;
            this.guna2PanelCard.Controls.Add(this.btnAddItem);
            this.guna2PanelCard.Controls.Add(this.lblPrice);
            this.guna2PanelCard.Controls.Add(this.lblItemName);
            this.guna2PanelCard.Controls.Add(this.picItemImage);
            this.guna2PanelCard.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard.Location = new System.Drawing.Point(5, 5);
            this.guna2PanelCard.Margin = new System.Windows.Forms.Padding(5);
            this.guna2PanelCard.Name = "guna2PanelCard";
            this.guna2PanelCard.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelCard.ShadowDecoration.Enabled = true;
            this.guna2PanelCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 3, 3);
            this.guna2PanelCard.Size = new System.Drawing.Size(200, 123);
            this.guna2PanelCard.TabIndex = 0;
            this.guna2PanelCard.UseTransparentBackground = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnAddItem.Location = new System.Drawing.Point(149, 10);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddItem.Size = new System.Drawing.Size(40, 37);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseTransparentBackground = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(11, 92);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "20.000 VND";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Location = new System.Drawing.Point(11, 68);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(76, 23);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "tiramisu";
            // 
            // picItemImage
            // 
            this.picItemImage.BackColor = System.Drawing.Color.Gainsboro;
            this.picItemImage.ImageRotate = 0F;
            this.picItemImage.Location = new System.Drawing.Point(11, 10);
            this.picItemImage.Margin = new System.Windows.Forms.Padding(4);
            this.picItemImage.Name = "picItemImage";
            this.picItemImage.Size = new System.Drawing.Size(93, 49);
            this.picItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemImage.TabIndex = 0;
            this.picItemImage.TabStop = false;
            // 
            // MenuItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelCard);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MenuItemCard";
            this.Size = new System.Drawing.Size(211, 133);
            this.guna2PanelCard.ResumeLayout(false);
            this.guna2PanelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelCard;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddItem;
        private Guna2PictureBox picItemImage;
    }
}