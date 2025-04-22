// AppContainerForm.Designer.cs
using Guna.UI2.WinForms; // Using cho Guna Panel
using System.Windows.Forms;
using System.Drawing;

namespace DoAnDemo // Hoặc namespace gốc của project
{
    partial class AppContainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppContainerForm));
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            //
            // panelContainer
            //
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill; // Cho panel chiếm hết Form
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1350, 750); // Kích thước ví dụ, sẽ tự chỉnh theo form
            this.panelContainer.TabIndex = 0;
            //
            // AppContainerForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Hoặc Font mặc định của bạn
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 750); // Kích thước khởi tạo ví dụ
            this.Controls.Add(this.panelContainer); // Thêm panel vào Form
                                                    // Thiết lập Icon nếu có file .ico
                                                    // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720); // Kích thước tối thiểu ví dụ
            this.Name = "AppContainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Hiện giữa màn hình
            this.Text = "Hệ thống Quản lý Bán hàng"; // Tiêu đề cửa sổ
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // Mở Full màn hình
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo biến cho panel container
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
    }
}