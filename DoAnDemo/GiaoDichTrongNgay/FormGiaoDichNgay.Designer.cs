// FormGiaoDichNgay.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.GiaoDichTrongNgay
{
    partial class FormGiaoDichNgay
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDichNgay));
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelContent.SuspendLayout();
            this.flowLayoutPanelOrders.SuspendLayout(); // Add this
            this.SuspendLayout();
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelTop.Controls.Add(this.btnSearch);
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Controls.Add(this.btnBack);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Size = new System.Drawing.Size(1080, 55);
            this.guna2PanelTop.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSearch.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            //this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image"))); // <<<--- ADD YOUR SEARCH ICON RESOURCE HERE
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSearch.Location = new System.Drawing.Point(1028, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseTransparentBackground = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(417, 17); // Center title
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Danh sách đơn hàng trong ngày";
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 55);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            // 
            // guna2PanelContent
            // 
            this.guna2PanelContent.Controls.Add(this.flowLayoutPanelOrders);
            this.guna2PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContent.Location = new System.Drawing.Point(0, 55);
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.Padding = new System.Windows.Forms.Padding(5); // Padding around FlowLayoutPanel
            this.guna2PanelContent.Size = new System.Drawing.Size(1080, 665);
            this.guna2PanelContent.TabIndex = 4;
            // 
            // flowLayoutPanelOrders
            // 
            this.flowLayoutPanelOrders.AutoScroll = true;
            this.flowLayoutPanelOrders.BackColor = System.Drawing.Color.WhiteSmoke; // Background for the scrolling area
            this.flowLayoutPanelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Padding = new System.Windows.Forms.Padding(5); // Padding inside FlowLayoutPanel
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(1070, 655);
            this.flowLayoutPanelOrders.TabIndex = 0;
            // 
            // FormGiaoDichNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.guna2PanelContent);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiaoDichNgay";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiaoDichNgay";
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelContent.ResumeLayout(false);
            this.flowLayoutPanelOrders.ResumeLayout(false); // Add this
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders;
    }
}