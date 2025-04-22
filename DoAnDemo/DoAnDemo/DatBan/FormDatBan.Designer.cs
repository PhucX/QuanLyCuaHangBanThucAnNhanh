// FormDatBan.Designer.cs
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo.DatBan
{
    partial class FormDatBan
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
            // ==================================================================
            // === ĐẢM BẢO DÒNG NÀY CÓ NGAY SAU KHI MỞ InitializeComponent() ===
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatBan));
            // ==================================================================

            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChuThich = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelSubTop = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGroupTang3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnGroupTang1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnGroupDaHoaCanh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelLegend = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLegendOccupied = new System.Windows.Forms.Label();
            this.lblLegendEmpty = new System.Windows.Forms.Label();
            this.guna2PanelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelSubTop.SuspendLayout();
            this.flowLayoutPanelGroups.SuspendLayout();
            this.guna2PanelLegend.SuspendLayout();
            this.guna2PanelContent.SuspendLayout();
            this.flowLayoutPanelTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelTop.Controls.Add(this.btnChuThich);
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Controls.Add(this.btnBack);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Size = new System.Drawing.Size(1080, 55);
            this.guna2PanelTop.TabIndex = 2;
            // 
            // btnChuThich
            // 
            this.btnChuThich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuThich.BorderColor = System.Drawing.Color.White;
            this.btnChuThich.BorderRadius = 5;
            this.btnChuThich.BorderThickness = 1;
            this.btnChuThich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuThich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuThich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuThich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuThich.FillColor = System.Drawing.Color.Transparent;
            this.btnChuThich.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChuThich.ForeColor = System.Drawing.Color.White;
            this.btnChuThich.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnChuThich.Location = new System.Drawing.Point(938, 10);
            this.btnChuThich.Name = "btnChuThich";
            this.btnChuThich.Size = new System.Drawing.Size(130, 35);
            this.btnChuThich.TabIndex = 2;
            this.btnChuThich.Text = "Chú thích bàn";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(515, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Bàn";
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
            // guna2PanelSubTop
            // 
            this.guna2PanelSubTop.Controls.Add(this.flowLayoutPanelGroups);
            this.guna2PanelSubTop.Controls.Add(this.guna2PanelLegend);
            this.guna2PanelSubTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelSubTop.FillColor = System.Drawing.Color.White;
            this.guna2PanelSubTop.Location = new System.Drawing.Point(0, 55);
            this.guna2PanelSubTop.Name = "guna2PanelSubTop";
            this.guna2PanelSubTop.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.guna2PanelSubTop.Size = new System.Drawing.Size(1080, 50);
            this.guna2PanelSubTop.TabIndex = 3;
            // 
            // flowLayoutPanelGroups
            // 
            this.flowLayoutPanelGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelGroups.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGroups.Controls.Add(this.btnGroupTang3);
            this.flowLayoutPanelGroups.Controls.Add(this.btnGroupTang1);
            this.flowLayoutPanelGroups.Controls.Add(this.btnGroupDaHoaCanh);
            this.flowLayoutPanelGroups.Location = new System.Drawing.Point(275, 5); // Position groups next to legend
            this.flowLayoutPanelGroups.Name = "flowLayoutPanelGroups";
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(792, 40);
            this.flowLayoutPanelGroups.TabIndex = 1;
            // 
            // btnGroupTang3
            // 
            this.btnGroupTang3.BorderRadius = 15;
            this.btnGroupTang3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGroupTang3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGroupTang3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnGroupTang3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupTang3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupTang3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGroupTang3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGroupTang3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroupTang3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGroupTang3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGroupTang3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGroupTang3.Location = new System.Drawing.Point(3, 3);
            this.btnGroupTang3.Name = "btnGroupTang3";
            this.btnGroupTang3.Size = new System.Drawing.Size(100, 34);
            this.btnGroupTang3.TabIndex = 0;
            this.btnGroupTang3.Text = "Tầng 3";
            // 
            // btnGroupTang1
            // 
            this.btnGroupTang1.BorderRadius = 15;
            this.btnGroupTang1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGroupTang1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGroupTang1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnGroupTang1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupTang1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupTang1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGroupTang1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGroupTang1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroupTang1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGroupTang1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGroupTang1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGroupTang1.Location = new System.Drawing.Point(109, 3);
            this.btnGroupTang1.Name = "btnGroupTang1";
            this.btnGroupTang1.Size = new System.Drawing.Size(100, 34);
            this.btnGroupTang1.TabIndex = 1;
            this.btnGroupTang1.Text = "Tầng 1";
            // 
            // btnGroupDaHoaCanh
            // 
            this.btnGroupDaHoaCanh.BorderRadius = 15;
            this.btnGroupDaHoaCanh.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGroupDaHoaCanh.Checked = true; // Default Selected Group
            this.btnGroupDaHoaCanh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnGroupDaHoaCanh.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnGroupDaHoaCanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupDaHoaCanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGroupDaHoaCanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGroupDaHoaCanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGroupDaHoaCanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Selected Color
            this.btnGroupDaHoaCanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGroupDaHoaCanh.ForeColor = System.Drawing.Color.White; // Selected Text Color
            this.btnGroupDaHoaCanh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btnGroupDaHoaCanh.Location = new System.Drawing.Point(215, 3);
            this.btnGroupDaHoaCanh.Name = "btnGroupDaHoaCanh";
            this.btnGroupDaHoaCanh.Size = new System.Drawing.Size(120, 34); // Wider button
            this.btnGroupDaHoaCanh.TabIndex = 2;
            this.btnGroupDaHoaCanh.Text = "Dạ Hoa Cảnh";
            // 
            // guna2PanelLegend
            // 
            this.guna2PanelLegend.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelLegend.Controls.Add(this.lblLegendOccupied);
            this.guna2PanelLegend.Controls.Add(this.lblLegendEmpty);
            this.guna2PanelLegend.Location = new System.Drawing.Point(13, 5);
            this.guna2PanelLegend.Name = "guna2PanelLegend";
            this.guna2PanelLegend.Size = new System.Drawing.Size(250, 40); // Adjust size
            this.guna2PanelLegend.TabIndex = 0;
            // 
            // lblLegendOccupied
            // 
            this.lblLegendOccupied.AutoSize = true;
            this.lblLegendOccupied.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendOccupied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLegendOccupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLegendOccupied.Image = ((System.Drawing.Image)(resources.GetObject("lblLegendOccupied.Image"))); // <<<--- ADD RED SQUARE ICON RESOURCE HERE
            this.lblLegendOccupied.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLegendOccupied.Location = new System.Drawing.Point(125, 13); // Adjust Position
            this.lblLegendOccupied.Name = "lblLegendOccupied";
            this.lblLegendOccupied.Size = new System.Drawing.Size(105, 15);
            this.lblLegendOccupied.TabIndex = 1;
            this.lblLegendOccupied.Text = "       4  Bàn Có Người"; // Add spaces for icon
            this.lblLegendOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLegendEmpty
            // 
            this.lblLegendEmpty.AutoSize = true;
            this.lblLegendEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendEmpty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLegendEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLegendEmpty.Image = ((System.Drawing.Image)(resources.GetObject("lblLegendEmpty.Image"))); // <<<--- ADD GREEN SQUARE ICON RESOURCE HERE
            this.lblLegendEmpty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLegendEmpty.Location = new System.Drawing.Point(5, 13); // Adjust Position
            this.lblLegendEmpty.Name = "lblLegendEmpty";
            this.lblLegendEmpty.Size = new System.Drawing.Size(95, 15);
            this.lblLegendEmpty.TabIndex = 0;
            this.lblLegendEmpty.Text = "      10  Bàn Trống"; // Add spaces for icon
            this.lblLegendEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2PanelContent
            // 
            this.guna2PanelContent.Controls.Add(this.flowLayoutPanelTables);
            this.guna2PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContent.Location = new System.Drawing.Point(0, 105); // Position below subtop bar
            this.guna2PanelContent.Name = "guna2PanelContent";
            this.guna2PanelContent.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelContent.Size = new System.Drawing.Size(1080, 615); // Adjust height
            this.guna2PanelContent.TabIndex = 4;
            // 
            // flowLayoutPanelTables
            // 
            this.flowLayoutPanelTables.AutoScroll = true;
            this.flowLayoutPanelTables.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTables.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            this.flowLayoutPanelTables.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelTables.Size = new System.Drawing.Size(1060, 595);
            this.flowLayoutPanelTables.TabIndex = 0;
            // 
            // FormDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelContent);
            this.Controls.Add(this.guna2PanelSubTop);
            this.Controls.Add(this.guna2PanelTop);
            this.Name = "FormDatBan";
            this.Size = new System.Drawing.Size(1080, 720);
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelSubTop.ResumeLayout(false);
            this.flowLayoutPanelGroups.ResumeLayout(false);
            this.guna2PanelLegend.ResumeLayout(false);
            this.guna2PanelLegend.PerformLayout();
            this.guna2PanelContent.ResumeLayout(false);
            this.flowLayoutPanelTables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnChuThich;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSubTop;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLegend;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private Guna.UI2.WinForms.Guna2Button btnGroupTang3;
        private Guna.UI2.WinForms.Guna2Button btnGroupTang1;
        private Guna.UI2.WinForms.Guna2Button btnGroupDaHoaCanh;
        private System.Windows.Forms.Label lblLegendEmpty;
        private System.Windows.Forms.Label lblLegendOccupied;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTables;
    }
}