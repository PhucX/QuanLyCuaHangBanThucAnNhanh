// DonHangCard.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo
{
    partial class DonHangCard
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
            this.btnAction2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAction1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.panelItems = new System.Windows.Forms.Panel();
            this.lblItemQty2 = new System.Windows.Forms.Label();
            this.lblItemName2 = new System.Windows.Forms.Label();
            this.lblItemQty1 = new System.Windows.Forms.Label();
            this.lblItemName1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.guna2PanelCard.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelCard
            // 
            this.guna2PanelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelCard.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelCard.BorderRadius = 8;
            this.guna2PanelCard.BorderThickness = 1;
            this.guna2PanelCard.Controls.Add(this.btnAction2);
            this.guna2PanelCard.Controls.Add(this.btnAction1);
            this.guna2PanelCard.Controls.Add(this.guna2Separator2);
            this.guna2PanelCard.Controls.Add(this.lblTotalAmount);
            this.guna2PanelCard.Controls.Add(this.lblPaymentMethod);
            this.guna2PanelCard.Controls.Add(this.panelItems);
            this.guna2PanelCard.Controls.Add(this.guna2Separator1);
            this.guna2PanelCard.Controls.Add(this.lblOrderID);
            this.guna2PanelCard.Controls.Add(this.lblDateTime);
            this.guna2PanelCard.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard.Location = new System.Drawing.Point(4, 4);
            this.guna2PanelCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PanelCard.Name = "guna2PanelCard";
            this.guna2PanelCard.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.guna2PanelCard.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.guna2PanelCard.ShadowDecoration.Enabled = true;
            this.guna2PanelCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.guna2PanelCard.Size = new System.Drawing.Size(272, 337);
            this.guna2PanelCard.TabIndex = 0;
            this.guna2PanelCard.UseTransparentBackground = true;
            // 
            // btnAction2
            // 
            this.btnAction2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction2.BorderRadius = 5;
            this.btnAction2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAction2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAction2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAction2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAction2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnAction2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAction2.ForeColor = System.Drawing.Color.White;
            this.btnAction2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnAction2.Location = new System.Drawing.Point(155, 284);
            this.btnAction2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Size = new System.Drawing.Size(100, 37);
            this.btnAction2.TabIndex = 8;
            this.btnAction2.Text = "IN";
            // 
            // btnAction1
            // 
            this.btnAction1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAction1.BorderRadius = 5;
            this.btnAction1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAction1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAction1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAction1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAction1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnAction1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAction1.ForeColor = System.Drawing.Color.White;
            this.btnAction1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnAction1.Location = new System.Drawing.Point(17, 284);
            this.btnAction1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Size = new System.Drawing.Size(127, 37);
            this.btnAction1.TabIndex = 7;
            this.btnAction1.Text = "ĐÁNH LỖI";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator2.Location = new System.Drawing.Point(13, 268);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(245, 12);
            this.guna2Separator2.TabIndex = 6;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(121, 240);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(133, 18);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "100.000 VND";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPaymentMethod.Location = new System.Drawing.Point(17, 240);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(50, 20);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "Credit";
            // 
            // panelItems
            // 
            this.panelItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItems.Controls.Add(this.lblItemQty2);
            this.panelItems.Controls.Add(this.lblItemName2);
            this.panelItems.Controls.Add(this.lblItemQty1);
            this.panelItems.Controls.Add(this.lblItemName1);
            this.panelItems.Location = new System.Drawing.Point(13, 62);
            this.panelItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(245, 166);
            this.panelItems.TabIndex = 3;
            // 
            // lblItemQty2
            // 
            this.lblItemQty2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblItemQty2.ForeColor = System.Drawing.Color.Gray;
            this.lblItemQty2.Location = new System.Drawing.Point(193, 31);
            this.lblItemQty2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQty2.Name = "lblItemQty2";
            this.lblItemQty2.Size = new System.Drawing.Size(47, 16);
            this.lblItemQty2.TabIndex = 3;
            this.lblItemQty2.Text = "1";
            this.lblItemQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemName2
            // 
            this.lblItemName2.AutoSize = true;
            this.lblItemName2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName2.Location = new System.Drawing.Point(7, 31);
            this.lblItemName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName2.MaximumSize = new System.Drawing.Size(187, 0);
            this.lblItemName2.Name = "lblItemName2";
            this.lblItemName2.Size = new System.Drawing.Size(130, 20);
            this.lblItemName2.TabIndex = 2;
            this.lblItemName2.Text = "Pagini Bread ( XL )";
            // 
            // lblItemQty1
            // 
            this.lblItemQty1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblItemQty1.ForeColor = System.Drawing.Color.Gray;
            this.lblItemQty1.Location = new System.Drawing.Point(193, 6);
            this.lblItemQty1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQty1.Name = "lblItemQty1";
            this.lblItemQty1.Size = new System.Drawing.Size(47, 16);
            this.lblItemQty1.TabIndex = 1;
            this.lblItemQty1.Text = "2";
            this.lblItemQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemName1
            // 
            this.lblItemName1.AutoSize = true;
            this.lblItemName1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName1.Location = new System.Drawing.Point(7, 6);
            this.lblItemName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName1.MaximumSize = new System.Drawing.Size(187, 0);
            this.lblItemName1.Name = "lblItemName1";
            this.lblItemName1.Size = new System.Drawing.Size(69, 20);
            this.lblItemName1.TabIndex = 0;
            this.lblItemName1.Text = "Món mới";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator1.Location = new System.Drawing.Point(13, 46);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(245, 12);
            this.guna2Separator1.TabIndex = 2;
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOrderID.ForeColor = System.Drawing.Color.Gray;
            this.lblOrderID.Location = new System.Drawing.Point(95, 16);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(160, 16);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "# 3101945463";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDateTime.ForeColor = System.Drawing.Color.Gray;
            this.lblDateTime.Location = new System.Drawing.Point(17, 16);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(103, 19);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "14 / 03-11 : 19";
            // 
            // DonHangCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelCard);
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "DonHangCard";
            this.Size = new System.Drawing.Size(280, 345);
            this.guna2PanelCard.ResumeLayout(false);
            this.guna2PanelCard.PerformLayout();
            this.panelItems.ResumeLayout(false);
            this.panelItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelCard;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblOrderID;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblTotalAmount;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button btnAction1;
        private Guna.UI2.WinForms.Guna2Button btnAction2;
        private System.Windows.Forms.Label lblItemQty1; // Example
        private System.Windows.Forms.Label lblItemName1; // Example
        private System.Windows.Forms.Label lblItemQty2; // Example 2
        private System.Windows.Forms.Label lblItemName2; // Example 2
    }
}