// TableCard.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo
{
    partial class TableCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableCard));
            this.guna2PanelCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.picChairIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.picPrinterIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picListIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChairIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrinterIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picListIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelCard
            // 
            this.guna2PanelCard.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(153))))); // Default Green (Empty)
            this.guna2PanelCard.BorderRadius = 12;
            this.guna2PanelCard.BorderThickness = 2;
            this.guna2PanelCard.Controls.Add(this.lblTableName);
            this.guna2PanelCard.Controls.Add(this.lblCustomerName);
            this.guna2PanelCard.Controls.Add(this.picChairIcon);
            this.guna2PanelCard.Controls.Add(this.lblCapacity);
            this.guna2PanelCard.Controls.Add(this.picPrinterIcon);
            this.guna2PanelCard.Controls.Add(this.picListIcon);
            this.guna2PanelCard.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard.Location = new System.Drawing.Point(3, 3);
            this.guna2PanelCard.Name = "guna2PanelCard";
            this.guna2PanelCard.Padding = new System.Windows.Forms.Padding(5);
            this.guna2PanelCard.ShadowDecoration.Color = System.Drawing.Color.Gainsboro;
            this.guna2PanelCard.ShadowDecoration.Enabled = true;
            this.guna2PanelCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 3, 3);
            this.guna2PanelCard.Size = new System.Drawing.Size(130, 110); // Adjust size
            this.guna2PanelCard.TabIndex = 0;
            this.guna2PanelCard.UseTransparentBackground = true;
            // 
            // lblTableName
            // 
            this.lblTableName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTableName.Location = new System.Drawing.Point(8, 85); // Position at bottom center
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(114, 17);
            this.lblTableName.TabIndex = 5;
            this.lblTableName.Text = "Bàn 1"; // Example
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Pink for customer name
            this.lblCustomerName.Location = new System.Drawing.Point(8, 65); // Position above table name
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(114, 15);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Viên Nguyệt"; // Example
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustomerName.Visible = false; // Initially hidden (show for occupied tables)
            // 
            // picChairIcon
            // 
            this.picChairIcon.Anchor = System.Windows.Forms.AnchorStyles.None; // Center
            this.picChairIcon.BackColor = System.Drawing.Color.Transparent;
            this.picChairIcon.Image = ((System.Drawing.Image)(resources.GetObject("picChairIcon.Image"))); // <<<--- ADD CHAIR ICON RESOURCE HERE
            this.picChairIcon.ImageRotate = 0F;
            this.picChairIcon.Location = new System.Drawing.Point(70, 38); // Position next to capacity
            this.picChairIcon.Name = "picChairIcon";
            this.picChairIcon.Size = new System.Drawing.Size(20, 20);
            this.picChairIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChairIcon.TabIndex = 3;
            this.picChairIcon.TabStop = false;
            this.picChairIcon.UseTransparentBackground = true;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.None; // Center
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCapacity.Location = new System.Drawing.Point(45, 38); // Position capacity number
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(18, 20); // Example Capacity
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "4";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picPrinterIcon
            // 
            this.picPrinterIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPrinterIcon.BackColor = System.Drawing.Color.Transparent;
            this.picPrinterIcon.Image = ((System.Drawing.Image)(resources.GetObject("picPrinterIcon.Image"))); // <<<--- ADD PRINTER ICON RESOURCE HERE (RED)
            this.picPrinterIcon.ImageRotate = 0F;
            this.picPrinterIcon.Location = new System.Drawing.Point(97, 8);
            this.picPrinterIcon.Name = "picPrinterIcon";
            this.picPrinterIcon.Size = new System.Drawing.Size(25, 25);
            this.picPrinterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrinterIcon.TabIndex = 1;
            this.picPrinterIcon.TabStop = false;
            this.picPrinterIcon.UseTransparentBackground = true;
            this.picPrinterIcon.Visible = false; // Initially hidden (show for occupied tables)
            // 
            // picListIcon
            // 
            this.picListIcon.BackColor = System.Drawing.Color.Transparent;
            this.picListIcon.Image = ((System.Drawing.Image)(resources.GetObject("picListIcon.Image"))); // <<<--- ADD LIST ICON RESOURCE HERE (RED)
            this.picListIcon.ImageRotate = 0F;
            this.picListIcon.Location = new System.Drawing.Point(8, 8);
            this.picListIcon.Name = "picListIcon";
            this.picListIcon.Size = new System.Drawing.Size(25, 25);
            this.picListIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picListIcon.TabIndex = 0;
            this.picListIcon.TabStop = false;
            this.picListIcon.UseTransparentBackground = true;
            this.picListIcon.Visible = false; // Initially hidden (show for occupied tables)
            // 
            // TableCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelCard);
            this.Margin = new System.Windows.Forms.Padding(10); // Margin for FlowLayoutPanel
            this.Name = "TableCard";
            this.Size = new System.Drawing.Size(136, 116); // Control size slightly larger for shadow
            this.guna2PanelCard.ResumeLayout(false);
            this.guna2PanelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChairIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrinterIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picListIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelCard;
        private Guna.UI2.WinForms.Guna2PictureBox picListIcon;
        private Guna.UI2.WinForms.Guna2PictureBox picPrinterIcon;
        private System.Windows.Forms.Label lblCapacity;
        private Guna.UI2.WinForms.Guna2PictureBox picChairIcon;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblTableName;
    }
}