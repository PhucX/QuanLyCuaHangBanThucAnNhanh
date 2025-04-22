// DiscountButtonCard.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.GiamGia
{
    partial class DiscountButtonCard
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
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscount.BorderRadius = 5;
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscount.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiscount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDiscount.Location = new System.Drawing.Point(0, 0);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.ShadowDecoration.Color = System.Drawing.Color.Gainsboro;
            this.btnDiscount.ShadowDecoration.Enabled = true;
            this.btnDiscount.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 2, 2);
            this.btnDiscount.Size = new System.Drawing.Size(133, 74);
            this.btnDiscount.TabIndex = 0;
            this.btnDiscount.Text = "Discount Text";
            this.btnDiscount.UseTransparentBackground = true;
            // 
            // DiscountButtonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDiscount);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DiscountButtonCard";
            this.Size = new System.Drawing.Size(133, 74);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDiscount;
    }
}