// BillItemRow.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.DatBan
{
    partial class BillItemRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillItemRow));
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Location = new System.Drawing.Point(10, 5);
            this.lblItemName.MaximumSize = new System.Drawing.Size(250, 0); // Allow wrapping
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(94, 17); // Example Text
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Bánh sừng bò";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(10, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 15); // Example Price
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "35.000 VND";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))); // Light gray background
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantity.Location = new System.Drawing.Point(317, 12); // Adjust position
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(25, 25);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "1"; // Example Quantity
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // To make it circular - this is an approximation with padding/alignment
            // Consider using Guna2Chip or custom drawing for perfect circle
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 49);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(350, 1); // Match width
            this.guna2Separator1.TabIndex = 3;
            // 
            // BillItemRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.Name = "BillItemRow";
            this.Size = new System.Drawing.Size(350, 50); // Set height for one row
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}