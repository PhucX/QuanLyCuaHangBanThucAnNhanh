// FormChuaThanhToan.Designer.cs
namespace DoAnDemo // Hoặc namespace phù hợp
{
    partial class FormChuaThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuaThanhToan));
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PanelTop.SuspendLayout();
            this.SuspendLayout();
            //
            // guna2PanelTop
            //
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu hồng/đỏ
            this.guna2PanelTop.Controls.Add(this.btnMenu);
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Controls.Add(this.btnBack);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Size = new System.Drawing.Size(800, 50); // Chiều rộng ví dụ
            this.guna2PanelTop.TabIndex = 0;
            //
            // btnMenu
            //
            this.btnMenu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image"))); // << THAY BẰNG ICON MENU CỦA BẠN
            this.btnMenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMenu.Location = new System.Drawing.Point(740, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMenu.Size = new System.Drawing.Size(60, 50);
            this.btnMenu.TabIndex = 2;
            //
            // lblTitle
            //
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(281, 14); // Điều chỉnh vị trí giữa
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Đơn hàng chưa hoàn thành";
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
            this.btnBack.Size = new System.Drawing.Size(60, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<"; // Dấu quay lại
            //
            // flowLayoutPanelOrders
            //
            this.flowLayoutPanelOrders.AutoScroll = true; // Cho phép cuộn nếu có nhiều đơn hàng
            this.flowLayoutPanelOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))); // Màu nền xám nhạt
            this.flowLayoutPanelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Padding = new System.Windows.Forms.Padding(10); // Padding cho các thẻ bên trong
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(800, 400); // Chiều cao ví dụ
            this.flowLayoutPanelOrders.TabIndex = 1;
            // Thêm ví dụ một thẻ vào để xem trước (có thể xóa sau)
            // this.flowLayoutPanelOrders.Controls.Add(new FormTrangThaiThanhToan());
            //
            // FormChuaThanhToan
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelOrders);
            this.Controls.Add(this.guna2PanelTop);
            this.Name = "FormChuaThanhToan";
            this.Size = new System.Drawing.Size(800, 450); // Kích thước ví dụ cho UserControl chính
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders; // Panel để chứa các thẻ đơn hàng
    }
}