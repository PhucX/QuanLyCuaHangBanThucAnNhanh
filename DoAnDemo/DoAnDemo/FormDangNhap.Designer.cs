namespace DoAnDemo
{
    partial class FormDangNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.pictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            this.panelLeft.Controls.Add(this.labelSlogan);
            this.panelLeft.Controls.Add(this.labelBrand);
            this.panelLeft.Controls.Add(this.pictureLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.labelSlogan.ForeColor = System.Drawing.Color.White;
            this.labelSlogan.Location = new System.Drawing.Point(60, 300);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(280, 21);
            this.labelSlogan.TabIndex = 2;
            this.labelSlogan.Text = "Phần mềm quản lý chuỗi thức ăn nhanh";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(130, 250);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(140, 45);
            this.labelBrand.TabIndex = 1;
            this.labelBrand.Text = "FastFood";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureLogo.ImageRotate = 0F;
            this.pictureLogo.Location = new System.Drawing.Point(125, 100);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.labelError);
            this.panelRight.Controls.Add(this.checkBoxShowPassword);
            this.panelRight.Controls.Add(this.buttonLogin);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.labelWelcome);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 500);
            this.panelRight.TabIndex = 1;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(50, 290);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 5;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            this.checkBoxShowPassword.CheckedState.BorderRadius = 0;
            this.checkBoxShowPassword.CheckedState.BorderThickness = 0;
            this.checkBoxShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxShowPassword.Location = new System.Drawing.Point(50, 260);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(95, 19);
            this.checkBoxShowPassword.TabIndex = 4;
            this.checkBoxShowPassword.Text = "Hiện mật khẩu";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BorderRadius = 5;
            this.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(50, 320);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(300, 45);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "ĐĂNG NHẬP";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            //this.txtPassword.IconLeft = global::DoAnDemo.Properties.Resources.password;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPassword.Location = new System.Drawing.Point(50, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(300, 40);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            //this.txtUsername.IconLeft = global::DoAnDemo.Properties.Resources.user;
            this.txtUsername.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUsername.Location = new System.Drawing.Point(50, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(300, 40);
            this.txtUsername.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(182)))));
            this.labelWelcome.Location = new System.Drawing.Point(50, 100);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(300, 37);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Đăng nhập hệ thống";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormDangNhap";
            this.Size = new System.Drawing.Size(800, 500);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Windows Form Designer generated code

        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.Label labelBrand;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogo;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private System.Windows.Forms.Label labelError;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxShowPassword;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label labelWelcome;

        #endregion
    }
}