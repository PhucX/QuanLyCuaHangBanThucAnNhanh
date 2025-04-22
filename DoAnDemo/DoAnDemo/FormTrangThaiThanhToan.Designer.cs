// FormTrangThaiThanhToan.Designer.cs
namespace DoAnDemo // Hoặc namespace phù hợp
{
    partial class FormTrangThaiThanhToan
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
            this.lblItemQty2 = new System.Windows.Forms.Label();
            this.lblItemQty1 = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblItemName2 = new System.Windows.Forms.Label();
            this.lblItemName1 = new System.Windows.Forms.Label();
            this.chipOrderCode = new Guna.UI2.WinForms.Guna2Chip();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.guna2PanelCard.SuspendLayout();
            this.SuspendLayout();
            //
            // guna2PanelCard
            //
            this.guna2PanelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PanelCard.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard.BorderRadius = 8;
            this.guna2PanelCard.Controls.Add(this.lblItemQty2);
            this.guna2PanelCard.Controls.Add(this.lblItemQty1);
            this.guna2PanelCard.Controls.Add(this.btnDeleteOrder);
            this.guna2PanelCard.Controls.Add(this.lblTotalAmount);
            this.guna2PanelCard.Controls.Add(this.lblItemName2);
            this.guna2PanelCard.Controls.Add(this.lblItemName1);
            this.guna2PanelCard.Controls.Add(this.chipOrderCode);
            this.guna2PanelCard.Controls.Add(this.lblIdentifier);
            this.guna2PanelCard.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard.Location = new System.Drawing.Point(3, 3);
            this.guna2PanelCard.Name = "guna2PanelCard";
            this.guna2PanelCard.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelCard.ShadowDecoration.Color = System.Drawing.Color.Gainsboro;
            this.guna2PanelCard.ShadowDecoration.Enabled = true;
            this.guna2PanelCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.guna2PanelCard.Size = new System.Drawing.Size(234, 214); // Kích thước thẻ (điều chỉnh nếu cần)
            this.guna2PanelCard.TabIndex = 0;
            this.guna2PanelCard.UseTransparentBackground = true;
            //
            // lblItemQty2
            //
            this.lblItemQty2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemQty2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemQty2.ForeColor = System.Drawing.Color.DimGray;
            this.lblItemQty2.Location = new System.Drawing.Point(188, 100);
            this.lblItemQty2.Name = "lblItemQty2";
            this.lblItemQty2.Size = new System.Drawing.Size(33, 15);
            this.lblItemQty2.TabIndex = 7;
            this.lblItemQty2.Text = "1";
            this.lblItemQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblItemQty1
            //
            this.lblItemQty1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemQty1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemQty1.ForeColor = System.Drawing.Color.DimGray;
            this.lblItemQty1.Location = new System.Drawing.Point(188, 79);
            this.lblItemQty1.Name = "lblItemQty1";
            this.lblItemQty1.Size = new System.Drawing.Size(33, 15);
            this.lblItemQty1.TabIndex = 6;
            this.lblItemQty1.Text = "1";
            this.lblItemQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // btnDeleteOrder
            //
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.BorderRadius = 5;
            this.btnDeleteOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu hồng/đỏ
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Location = new System.Drawing.Point(13, 168);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(208, 33);
            this.btnDeleteOrder.TabIndex = 5;
            this.btnDeleteOrder.Text = "XOÁ ĐƠN HÀNG";
            //
            // lblTotalAmount
            //
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96))))); // Màu hồng/đỏ
            this.lblTotalAmount.Location = new System.Drawing.Point(13, 138);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(103, 20);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "80.000 VND";
            //
            // lblItemName2
            //
            this.lblItemName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName2.AutoEllipsis = true;
            this.lblItemName2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemName2.ForeColor = System.Drawing.Color.DimGray;
            this.lblItemName2.Location = new System.Drawing.Point(13, 100);
            this.lblItemName2.Name = "lblItemName2";
            this.lblItemName2.Size = new System.Drawing.Size(169, 15);
            this.lblItemName2.TabIndex = 3;
            this.lblItemName2.Text = "Pagini Bread (XL)";
            //
            // lblItemName1
            //
            this.lblItemName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName1.AutoEllipsis = true;
            this.lblItemName1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemName1.ForeColor = System.Drawing.Color.DimGray;
            this.lblItemName1.Location = new System.Drawing.Point(13, 79);
            this.lblItemName1.Name = "lblItemName1";
            this.lblItemName1.Size = new System.Drawing.Size(169, 15);
            this.lblItemName1.TabIndex = 2;
            this.lblItemName1.Text = "Bánh Xoài (S)";
            //
            // chipOrderCode
            //
            this.chipOrderCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chipOrderCode.AutoRoundedCorners = true;
            this.chipOrderCode.BorderRadius = 11;
            this.chipOrderCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); // Màu nền tối
            this.chipOrderCode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.chipOrderCode.ForeColor = System.Drawing.Color.White;
            this.chipOrderCode.Location = new System.Drawing.Point(13, 41);
            this.chipOrderCode.Name = "chipOrderCode";
            this.chipOrderCode.Size = new System.Drawing.Size(208, 25); // Điều chỉnh kích thước chip
            this.chipOrderCode.TabIndex = 1;
            this.chipOrderCode.Text = "3729862975";
            this.chipOrderCode.UseTransparentBackground = true;
            //
            // lblIdentifier
            //
            this.lblIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdentifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdentifier.Location = new System.Drawing.Point(13, 13);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(116, 15); // Kích thước label định danh
            this.lblIdentifier.TabIndex = 0;
            this.lblIdentifier.Text = "#1 - 03/10 - 11:19"; // Định danh ví dụ
            //
            // FormTrangThaiThanhToan
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PanelCard);
            this.Margin = new System.Windows.Forms.Padding(8); // Khoảng cách giữa các thẻ
            this.Name = "FormTrangThaiThanhToan";
            this.Size = new System.Drawing.Size(240, 220); // Kích thước UserControl (bao gồm shadow/margin)
            this.guna2PanelCard.ResumeLayout(false);
            this.guna2PanelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelCard;
        private System.Windows.Forms.Label lblIdentifier;
        private Guna.UI2.WinForms.Guna2Chip chipOrderCode;
        private System.Windows.Forms.Label lblItemName1;
        private System.Windows.Forms.Label lblItemName2;
        private System.Windows.Forms.Label lblTotalAmount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteOrder;
        private System.Windows.Forms.Label lblItemQty2;
        private System.Windows.Forms.Label lblItemQty1;
    }
}