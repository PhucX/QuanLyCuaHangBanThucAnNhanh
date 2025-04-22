// Cần thêm using Guna.UI2.WinForms; ở đầu file nếu chưa có
using Guna.UI2.WinForms;
using System.Windows.Forms; // Thêm using này
using System.Drawing; // Thêm using này

namespace DoAnDemo
{
    partial class FormChiTietMonAn
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
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelHanLá = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHanLaNhieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHanLaIt = new Guna.UI2.WinForms.Guna2Button();
            this.lblHanLaTitle = new System.Windows.Forms.Label();
            this.guna2PanelHealthy = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHealthyNoOil = new Guna.UI2.WinForms.Guna2Button();
            this.btnHealthyLessSugar = new Guna.UI2.WinForms.Guna2Button();
            this.lblHealthyTitle = new System.Windows.Forms.Label();
            this.guna2PanelTomato = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTomatoYes = new Guna.UI2.WinForms.Guna2Button();
            this.btnTomatoMedium = new Guna.UI2.WinForms.Guna2Button();
            this.lblTomatoTitle = new System.Windows.Forms.Label();
            this.guna2PanelChilli = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChilliNo = new Guna.UI2.WinForms.Guna2Button();
            this.btnChilliYes = new Guna.UI2.WinForms.Guna2Button();
            this.lblChilliTitle = new System.Windows.Forms.Label();
            this.guna2PanelMiddle = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelQuickQuantity = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQuantityOther = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuantity7 = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuantity6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuantity5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuantity4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuantity3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuantity2 = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuickQuantityTitle = new System.Windows.Forms.Label();
            this.guna2PanelNote = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.guna2PanelExtras = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelExtraMeats = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExtraMeatsPlus = new Guna.UI2.WinForms.Guna2Button();
            this.lblExtraMeatsQuantity = new System.Windows.Forms.Label();
            this.btnExtraMeatsMinus = new Guna.UI2.WinForms.Guna2Button();
            this.lblExtraMeatsPrice = new System.Windows.Forms.Label();
            this.lblExtraMeatsTitle = new System.Windows.Forms.Label();
            this.guna2PanelExtraCheese = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExtraCheesePlus = new Guna.UI2.WinForms.Guna2Button();
            this.lblExtraCheeseQuantity = new System.Windows.Forms.Label();
            this.btnExtraCheeseMinus = new Guna.UI2.WinForms.Guna2Button();
            this.lblExtraCheesePrice = new System.Windows.Forms.Label();
            this.lblExtraCheeseTitle = new System.Windows.Forms.Label();
            this.lblExtrasTitle = new System.Windows.Forms.Label();
            this.guna2PanelSelectedOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSelectedOptions = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSelectedOptionsTitle = new System.Windows.Forms.Label();
            this.guna2PanelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelDiscount = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.guna2PanelItemInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQuantityPlus = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnQuantityMinus = new Guna.UI2.WinForms.Guna2Button();
            this.btnSizeL = new Guna.UI2.WinForms.Guna2Button();
            this.btnSizeX = new Guna.UI2.WinForms.Guna2Button();
            this.btnSizeXL = new Guna.UI2.WinForms.Guna2Button();
            this.lblSizeTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.guna2PictureBoxFoodItem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelLeft.SuspendLayout();
            this.guna2PanelHanLá.SuspendLayout();
            this.guna2PanelHealthy.SuspendLayout();
            this.guna2PanelTomato.SuspendLayout();
            this.guna2PanelChilli.SuspendLayout();
            this.guna2PanelMiddle.SuspendLayout();
            this.guna2PanelQuickQuantity.SuspendLayout();
            this.guna2PanelNote.SuspendLayout();
            this.guna2PanelExtras.SuspendLayout();
            this.guna2PanelExtraMeats.SuspendLayout();
            this.guna2PanelExtraCheese.SuspendLayout();
            this.guna2PanelSelectedOptions.SuspendLayout();
            this.guna2PanelRight.SuspendLayout();
            this.guna2PanelDiscount.SuspendLayout();
            this.guna2PanelItemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxFoodItem)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Controls.Add(this.btnBack);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Size = new System.Drawing.Size(1234, 50);
            this.guna2PanelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(478, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Chi tiết món ăn";
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
            this.btnBack.Text = "<";
            // 
            // guna2PanelLeft
            // 
            this.guna2PanelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelLeft.Controls.Add(this.guna2PanelHanLá);
            this.guna2PanelLeft.Controls.Add(this.guna2PanelHealthy);
            this.guna2PanelLeft.Controls.Add(this.guna2PanelTomato);
            this.guna2PanelLeft.Controls.Add(this.guna2PanelChilli);
            this.guna2PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PanelLeft.Location = new System.Drawing.Point(0, 115);
            this.guna2PanelLeft.Name = "guna2PanelLeft";
            this.guna2PanelLeft.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.guna2PanelLeft.Size = new System.Drawing.Size(230, 605);
            this.guna2PanelLeft.TabIndex = 3;
            // 
            // guna2PanelHanLá
            // 
            this.guna2PanelHanLá.Controls.Add(this.btnHanLaNhieu);
            this.guna2PanelHanLá.Controls.Add(this.btnHanLaIt);
            this.guna2PanelHanLá.Controls.Add(this.lblHanLaTitle);
            this.guna2PanelHanLá.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelHanLá.Location = new System.Drawing.Point(10, 365);
            this.guna2PanelHanLá.Name = "guna2PanelHanLá";
            this.guna2PanelHanLá.Size = new System.Drawing.Size(210, 120);
            this.guna2PanelHanLá.TabIndex = 3;
            // 
            // btnHanLaNhieu
            // 
            this.btnHanLaNhieu.BorderRadius = 5;
            this.btnHanLaNhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHanLaNhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHanLaNhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHanLaNhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHanLaNhieu.FillColor = System.Drawing.Color.White;
            this.btnHanLaNhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHanLaNhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHanLaNhieu.Location = new System.Drawing.Point(7, 73);
            this.btnHanLaNhieu.Name = "btnHanLaNhieu";
            this.btnHanLaNhieu.Size = new System.Drawing.Size(196, 35);
            this.btnHanLaNhieu.TabIndex = 2;
            this.btnHanLaNhieu.Text = "Nhiều";
            // 
            // btnHanLaIt
            // 
            this.btnHanLaIt.BorderRadius = 5;
            this.btnHanLaIt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnHanLaIt.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHanLaIt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHanLaIt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHanLaIt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHanLaIt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHanLaIt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnHanLaIt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHanLaIt.ForeColor = System.Drawing.Color.White;
            this.btnHanLaIt.Location = new System.Drawing.Point(7, 32);
            this.btnHanLaIt.Name = "btnHanLaIt";
            this.btnHanLaIt.Size = new System.Drawing.Size(196, 35);
            this.btnHanLaIt.TabIndex = 1;
            this.btnHanLaIt.Text = "Ít";
            // 
            // lblHanLaTitle
            // 
            this.lblHanLaTitle.AutoSize = true;
            this.lblHanLaTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHanLaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHanLaTitle.Location = new System.Drawing.Point(4, 7);
            this.lblHanLaTitle.Name = "lblHanLaTitle";
            this.lblHanLaTitle.Size = new System.Drawing.Size(70, 23);
            this.lblHanLaTitle.TabIndex = 0;
            this.lblHanLaTitle.Text = "Hành lá";
            // 
            // guna2PanelHealthy
            // 
            this.guna2PanelHealthy.Controls.Add(this.btnHealthyNoOil);
            this.guna2PanelHealthy.Controls.Add(this.btnHealthyLessSugar);
            this.guna2PanelHealthy.Controls.Add(this.lblHealthyTitle);
            this.guna2PanelHealthy.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelHealthy.Location = new System.Drawing.Point(10, 245);
            this.guna2PanelHealthy.Name = "guna2PanelHealthy";
            this.guna2PanelHealthy.Size = new System.Drawing.Size(210, 120);
            this.guna2PanelHealthy.TabIndex = 2;
            // 
            // btnHealthyNoOil
            // 
            this.btnHealthyNoOil.BorderRadius = 5;
            this.btnHealthyNoOil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHealthyNoOil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHealthyNoOil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHealthyNoOil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHealthyNoOil.FillColor = System.Drawing.Color.White;
            this.btnHealthyNoOil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHealthyNoOil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHealthyNoOil.Location = new System.Drawing.Point(7, 73);
            this.btnHealthyNoOil.Name = "btnHealthyNoOil";
            this.btnHealthyNoOil.Size = new System.Drawing.Size(196, 35);
            this.btnHealthyNoOil.TabIndex = 2;
            this.btnHealthyNoOil.Text = "No Oil";
            // 
            // btnHealthyLessSugar
            // 
            this.btnHealthyLessSugar.BorderRadius = 5;
            this.btnHealthyLessSugar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnHealthyLessSugar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHealthyLessSugar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHealthyLessSugar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHealthyLessSugar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHealthyLessSugar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHealthyLessSugar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnHealthyLessSugar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHealthyLessSugar.ForeColor = System.Drawing.Color.White;
            this.btnHealthyLessSugar.Location = new System.Drawing.Point(7, 32);
            this.btnHealthyLessSugar.Name = "btnHealthyLessSugar";
            this.btnHealthyLessSugar.Size = new System.Drawing.Size(196, 35);
            this.btnHealthyLessSugar.TabIndex = 1;
            this.btnHealthyLessSugar.Text = "Less Sugar";
            // 
            // lblHealthyTitle
            // 
            this.lblHealthyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHealthyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHealthyTitle.Location = new System.Drawing.Point(4, 0);
            this.lblHealthyTitle.Name = "lblHealthyTitle";
            this.lblHealthyTitle.Size = new System.Drawing.Size(200, 35);
            this.lblHealthyTitle.TabIndex = 0;
            this.lblHealthyTitle.Text = "Healthy Options (Food) (Có thể chọn nhiều)";
            // 
            // guna2PanelTomato
            // 
            this.guna2PanelTomato.Controls.Add(this.btnTomatoYes);
            this.guna2PanelTomato.Controls.Add(this.btnTomatoMedium);
            this.guna2PanelTomato.Controls.Add(this.lblTomatoTitle);
            this.guna2PanelTomato.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTomato.Location = new System.Drawing.Point(10, 125);
            this.guna2PanelTomato.Name = "guna2PanelTomato";
            this.guna2PanelTomato.Size = new System.Drawing.Size(210, 120);
            this.guna2PanelTomato.TabIndex = 1;
            // 
            // btnTomatoYes
            // 
            this.btnTomatoYes.BorderRadius = 5;
            this.btnTomatoYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTomatoYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTomatoYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTomatoYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTomatoYes.FillColor = System.Drawing.Color.White;
            this.btnTomatoYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTomatoYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTomatoYes.Location = new System.Drawing.Point(7, 73);
            this.btnTomatoYes.Name = "btnTomatoYes";
            this.btnTomatoYes.Size = new System.Drawing.Size(196, 35);
            this.btnTomatoYes.TabIndex = 2;
            this.btnTomatoYes.Text = "Yes";
            // 
            // btnTomatoMedium
            // 
            this.btnTomatoMedium.BorderRadius = 5;
            this.btnTomatoMedium.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTomatoMedium.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTomatoMedium.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTomatoMedium.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTomatoMedium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTomatoMedium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTomatoMedium.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnTomatoMedium.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTomatoMedium.ForeColor = System.Drawing.Color.White;
            this.btnTomatoMedium.Location = new System.Drawing.Point(7, 32);
            this.btnTomatoMedium.Name = "btnTomatoMedium";
            this.btnTomatoMedium.Size = new System.Drawing.Size(196, 35);
            this.btnTomatoMedium.TabIndex = 1;
            this.btnTomatoMedium.Text = "Medium";
            // 
            // lblTomatoTitle
            // 
            this.lblTomatoTitle.AutoSize = true;
            this.lblTomatoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTomatoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTomatoTitle.Location = new System.Drawing.Point(4, 7);
            this.lblTomatoTitle.Name = "lblTomatoTitle";
            this.lblTomatoTitle.Size = new System.Drawing.Size(117, 23);
            this.lblTomatoTitle.TabIndex = 0;
            this.lblTomatoTitle.Text = "Tomato Sauce";
            // 
            // guna2PanelChilli
            // 
            this.guna2PanelChilli.Controls.Add(this.btnChilliNo);
            this.guna2PanelChilli.Controls.Add(this.btnChilliYes);
            this.guna2PanelChilli.Controls.Add(this.lblChilliTitle);
            this.guna2PanelChilli.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelChilli.Location = new System.Drawing.Point(10, 5);
            this.guna2PanelChilli.Name = "guna2PanelChilli";
            this.guna2PanelChilli.Size = new System.Drawing.Size(210, 120);
            this.guna2PanelChilli.TabIndex = 0;
            // 
            // btnChilliNo
            // 
            this.btnChilliNo.BorderRadius = 5;
            this.btnChilliNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChilliNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChilliNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChilliNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChilliNo.FillColor = System.Drawing.Color.White;
            this.btnChilliNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChilliNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChilliNo.Location = new System.Drawing.Point(7, 73);
            this.btnChilliNo.Name = "btnChilliNo";
            this.btnChilliNo.Size = new System.Drawing.Size(196, 35);
            this.btnChilliNo.TabIndex = 2;
            this.btnChilliNo.Text = "No";
            // 
            // btnChilliYes
            // 
            this.btnChilliYes.BorderRadius = 5;
            this.btnChilliYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnChilliYes.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnChilliYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChilliYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChilliYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChilliYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChilliYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnChilliYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChilliYes.ForeColor = System.Drawing.Color.White;
            this.btnChilliYes.Location = new System.Drawing.Point(7, 32);
            this.btnChilliYes.Name = "btnChilliYes";
            this.btnChilliYes.Size = new System.Drawing.Size(196, 35);
            this.btnChilliYes.TabIndex = 1;
            this.btnChilliYes.Text = "Yes";
            // 
            // lblChilliTitle
            // 
            this.lblChilliTitle.AutoSize = true;
            this.lblChilliTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChilliTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChilliTitle.Location = new System.Drawing.Point(4, 7);
            this.lblChilliTitle.Name = "lblChilliTitle";
            this.lblChilliTitle.Size = new System.Drawing.Size(47, 23);
            this.lblChilliTitle.TabIndex = 0;
            this.lblChilliTitle.Text = "Chilli";
            // 
            // guna2PanelMiddle
            // 
            this.guna2PanelMiddle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelMiddle.Controls.Add(this.guna2PanelQuickQuantity);
            this.guna2PanelMiddle.Controls.Add(this.guna2PanelNote);
            this.guna2PanelMiddle.Controls.Add(this.guna2PanelExtras);
            this.guna2PanelMiddle.Controls.Add(this.guna2PanelSelectedOptions);
            this.guna2PanelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelMiddle.Location = new System.Drawing.Point(230, 115);
            this.guna2PanelMiddle.Name = "guna2PanelMiddle";
            this.guna2PanelMiddle.Padding = new System.Windows.Forms.Padding(10);
            this.guna2PanelMiddle.Size = new System.Drawing.Size(734, 605);
            this.guna2PanelMiddle.TabIndex = 4;
            // 
            // guna2PanelQuickQuantity
            // 
            this.guna2PanelQuickQuantity.BackColor = System.Drawing.Color.White;
            this.guna2PanelQuickQuantity.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelQuickQuantity.BorderRadius = 5;
            this.guna2PanelQuickQuantity.BorderThickness = 1;
            this.guna2PanelQuickQuantity.Controls.Add(this.btnQuantityOther);
            this.guna2PanelQuickQuantity.Controls.Add(this.btnQuantity7);
            this.guna2PanelQuickQuantity.Controls.Add(this.btnQuantity6);
            this.guna2PanelQuickQuantity.Controls.Add(this.btnQuantity5);
            this.guna2PanelQuickQuantity.Controls.Add(this.btnQuantity4);
            this.guna2PanelQuickQuantity.Controls.Add(this.btnQuantity3);
            this.guna2PanelQuickQuantity.Controls.Add(this.btnQuantity2);
            this.guna2PanelQuickQuantity.Controls.Add(this.lblQuickQuantityTitle);
            this.guna2PanelQuickQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelQuickQuantity.Location = new System.Drawing.Point(10, 425);
            this.guna2PanelQuickQuantity.Name = "guna2PanelQuickQuantity";
            this.guna2PanelQuickQuantity.Padding = new System.Windows.Forms.Padding(5);
            this.guna2PanelQuickQuantity.Size = new System.Drawing.Size(714, 80);
            this.guna2PanelQuickQuantity.TabIndex = 3;
            // 
            // btnQuantityOther
            // 
            this.btnQuantityOther.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityOther.BorderRadius = 5;
            this.btnQuantityOther.BorderThickness = 1;
            this.btnQuantityOther.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityOther.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityOther.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantityOther.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantityOther.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantityOther.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnQuantityOther.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantityOther.Location = new System.Drawing.Point(480, 30);
            this.btnQuantityOther.Name = "btnQuantityOther";
            this.btnQuantityOther.Size = new System.Drawing.Size(70, 40);
            this.btnQuantityOther.TabIndex = 7;
            this.btnQuantityOther.Text = "Khác";
            // 
            // btnQuantity7
            // 
            this.btnQuantity7.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity7.BorderRadius = 5;
            this.btnQuantity7.BorderThickness = 1;
            this.btnQuantity7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantity7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantity7.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantity7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuantity7.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantity7.Location = new System.Drawing.Point(400, 30);
            this.btnQuantity7.Name = "btnQuantity7";
            this.btnQuantity7.Size = new System.Drawing.Size(70, 40);
            this.btnQuantity7.TabIndex = 6;
            this.btnQuantity7.Text = "7";
            // 
            // btnQuantity6
            // 
            this.btnQuantity6.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity6.BorderRadius = 5;
            this.btnQuantity6.BorderThickness = 1;
            this.btnQuantity6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantity6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantity6.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantity6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuantity6.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantity6.Location = new System.Drawing.Point(320, 30);
            this.btnQuantity6.Name = "btnQuantity6";
            this.btnQuantity6.Size = new System.Drawing.Size(70, 40);
            this.btnQuantity6.TabIndex = 5;
            this.btnQuantity6.Text = "6";
            // 
            // btnQuantity5
            // 
            this.btnQuantity5.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity5.BorderRadius = 5;
            this.btnQuantity5.BorderThickness = 1;
            this.btnQuantity5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantity5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantity5.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantity5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuantity5.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantity5.Location = new System.Drawing.Point(240, 30);
            this.btnQuantity5.Name = "btnQuantity5";
            this.btnQuantity5.Size = new System.Drawing.Size(70, 40);
            this.btnQuantity5.TabIndex = 4;
            this.btnQuantity5.Text = "5";
            // 
            // btnQuantity4
            // 
            this.btnQuantity4.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity4.BorderRadius = 5;
            this.btnQuantity4.BorderThickness = 1;
            this.btnQuantity4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantity4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantity4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantity4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuantity4.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantity4.Location = new System.Drawing.Point(160, 30);
            this.btnQuantity4.Name = "btnQuantity4";
            this.btnQuantity4.Size = new System.Drawing.Size(70, 40);
            this.btnQuantity4.TabIndex = 3;
            this.btnQuantity4.Text = "4";
            // 
            // btnQuantity3
            // 
            this.btnQuantity3.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity3.BorderRadius = 5;
            this.btnQuantity3.BorderThickness = 1;
            this.btnQuantity3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantity3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantity3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantity3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuantity3.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantity3.Location = new System.Drawing.Point(85, 30);
            this.btnQuantity3.Name = "btnQuantity3";
            this.btnQuantity3.Size = new System.Drawing.Size(70, 40);
            this.btnQuantity3.TabIndex = 2;
            this.btnQuantity3.Text = "3";
            // 
            // btnQuantity2
            // 
            this.btnQuantity2.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity2.BorderRadius = 5;
            this.btnQuantity2.BorderThickness = 1;
            this.btnQuantity2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnQuantity2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnQuantity2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantity2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantity2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantity2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantity2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuantity2.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantity2.Location = new System.Drawing.Point(10, 30);
            this.btnQuantity2.Name = "btnQuantity2";
            this.btnQuantity2.Size = new System.Drawing.Size(70, 40);
            this.btnQuantity2.TabIndex = 1;
            this.btnQuantity2.Text = "2";
            // 
            // lblQuickQuantityTitle
            // 
            this.lblQuickQuantityTitle.AutoSize = true;
            this.lblQuickQuantityTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickQuantityTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuickQuantityTitle.Location = new System.Drawing.Point(7, 7);
            this.lblQuickQuantityTitle.Name = "lblQuickQuantityTitle";
            this.lblQuickQuantityTitle.Size = new System.Drawing.Size(203, 20);
            this.lblQuickQuantityTitle.TabIndex = 0;
            this.lblQuickQuantityTitle.Text = "Chọn số lượng món ăn nhanh";
            // 
            // guna2PanelNote
            // 
            this.guna2PanelNote.BackColor = System.Drawing.Color.White;
            this.guna2PanelNote.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelNote.BorderRadius = 5;
            this.guna2PanelNote.BorderThickness = 1;
            this.guna2PanelNote.Controls.Add(this.txtNote);
            this.guna2PanelNote.Controls.Add(this.lblNoteTitle);
            this.guna2PanelNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelNote.Location = new System.Drawing.Point(10, 345);
            this.guna2PanelNote.Name = "guna2PanelNote";
            this.guna2PanelNote.Padding = new System.Windows.Forms.Padding(5);
            this.guna2PanelNote.Size = new System.Drawing.Size(714, 80);
            this.guna2PanelNote.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.BorderColor = System.Drawing.Color.LightGray;
            this.txtNote.BorderRadius = 3;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(10, 30);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.PlaceholderText = "Nội Dung";
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(540, 40);
            this.txtNote.TabIndex = 1;
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.AutoSize = true;
            this.lblNoteTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNoteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNoteTitle.Location = new System.Drawing.Point(7, 7);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(69, 23);
            this.lblNoteTitle.TabIndex = 0;
            this.lblNoteTitle.Text = "Ghi chú";
            // 
            // guna2PanelExtras
            // 
            this.guna2PanelExtras.BackColor = System.Drawing.Color.White;
            this.guna2PanelExtras.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelExtras.BorderRadius = 5;
            this.guna2PanelExtras.BorderThickness = 1;
            this.guna2PanelExtras.Controls.Add(this.guna2PanelExtraMeats);
            this.guna2PanelExtras.Controls.Add(this.guna2PanelExtraCheese);
            this.guna2PanelExtras.Controls.Add(this.lblExtrasTitle);
            this.guna2PanelExtras.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelExtras.Location = new System.Drawing.Point(10, 85);
            this.guna2PanelExtras.Name = "guna2PanelExtras";
            this.guna2PanelExtras.Padding = new System.Windows.Forms.Padding(5);
            this.guna2PanelExtras.Size = new System.Drawing.Size(714, 260);
            this.guna2PanelExtras.TabIndex = 1;
            // 
            // guna2PanelExtraMeats
            // 
            this.guna2PanelExtraMeats.BorderColor = System.Drawing.Color.LightGray;
            this.guna2PanelExtraMeats.BorderRadius = 5;
            this.guna2PanelExtraMeats.BorderThickness = 1;
            this.guna2PanelExtraMeats.Controls.Add(this.btnExtraMeatsPlus);
            this.guna2PanelExtraMeats.Controls.Add(this.lblExtraMeatsQuantity);
            this.guna2PanelExtraMeats.Controls.Add(this.btnExtraMeatsMinus);
            this.guna2PanelExtraMeats.Controls.Add(this.lblExtraMeatsPrice);
            this.guna2PanelExtraMeats.Controls.Add(this.lblExtraMeatsTitle);
            this.guna2PanelExtraMeats.Location = new System.Drawing.Point(285, 35);
            this.guna2PanelExtraMeats.Name = "guna2PanelExtraMeats";
            this.guna2PanelExtraMeats.Size = new System.Drawing.Size(265, 215);
            this.guna2PanelExtraMeats.TabIndex = 2;
            // 
            // btnExtraMeatsPlus
            // 
            this.btnExtraMeatsPlus.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraMeatsPlus.BorderRadius = 5;
            this.btnExtraMeatsPlus.BorderThickness = 1;
            this.btnExtraMeatsPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraMeatsPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraMeatsPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExtraMeatsPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExtraMeatsPlus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtraMeatsPlus.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExtraMeatsPlus.ForeColor = System.Drawing.Color.DimGray;
            this.btnExtraMeatsPlus.Location = new System.Drawing.Point(190, 155);
            this.btnExtraMeatsPlus.Name = "btnExtraMeatsPlus";
            this.btnExtraMeatsPlus.Size = new System.Drawing.Size(45, 40);
            this.btnExtraMeatsPlus.TabIndex = 8;
            this.btnExtraMeatsPlus.Text = "+";
            // 
            // lblExtraMeatsQuantity
            // 
            this.lblExtraMeatsQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtraMeatsQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblExtraMeatsQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExtraMeatsQuantity.Location = new System.Drawing.Point(85, 155);
            this.lblExtraMeatsQuantity.Name = "lblExtraMeatsQuantity";
            this.lblExtraMeatsQuantity.Size = new System.Drawing.Size(100, 40);
            this.lblExtraMeatsQuantity.TabIndex = 7;
            this.lblExtraMeatsQuantity.Text = "0";
            this.lblExtraMeatsQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExtraMeatsMinus
            // 
            this.btnExtraMeatsMinus.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraMeatsMinus.BorderRadius = 5;
            this.btnExtraMeatsMinus.BorderThickness = 1;
            this.btnExtraMeatsMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraMeatsMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraMeatsMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExtraMeatsMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExtraMeatsMinus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtraMeatsMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExtraMeatsMinus.ForeColor = System.Drawing.Color.DimGray;
            this.btnExtraMeatsMinus.Location = new System.Drawing.Point(35, 155);
            this.btnExtraMeatsMinus.Name = "btnExtraMeatsMinus";
            this.btnExtraMeatsMinus.Size = new System.Drawing.Size(45, 40);
            this.btnExtraMeatsMinus.TabIndex = 6;
            this.btnExtraMeatsMinus.Text = "-";
            // 
            // lblExtraMeatsPrice
            // 
            this.lblExtraMeatsPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblExtraMeatsPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExtraMeatsPrice.Location = new System.Drawing.Point(15, 50);
            this.lblExtraMeatsPrice.Name = "lblExtraMeatsPrice";
            this.lblExtraMeatsPrice.Size = new System.Drawing.Size(235, 20);
            this.lblExtraMeatsPrice.TabIndex = 2;
            this.lblExtraMeatsPrice.Text = "15.000 VND";
            this.lblExtraMeatsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExtraMeatsTitle
            // 
            this.lblExtraMeatsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExtraMeatsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExtraMeatsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblExtraMeatsTitle.Name = "lblExtraMeatsTitle";
            this.lblExtraMeatsTitle.Size = new System.Drawing.Size(235, 20);
            this.lblExtraMeatsTitle.TabIndex = 1;
            this.lblExtraMeatsTitle.Text = "Extra meats";
            this.lblExtraMeatsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PanelExtraCheese
            // 
            this.guna2PanelExtraCheese.BorderColor = System.Drawing.Color.LightGray;
            this.guna2PanelExtraCheese.BorderRadius = 5;
            this.guna2PanelExtraCheese.BorderThickness = 1;
            this.guna2PanelExtraCheese.Controls.Add(this.btnExtraCheesePlus);
            this.guna2PanelExtraCheese.Controls.Add(this.lblExtraCheeseQuantity);
            this.guna2PanelExtraCheese.Controls.Add(this.btnExtraCheeseMinus);
            this.guna2PanelExtraCheese.Controls.Add(this.lblExtraCheesePrice);
            this.guna2PanelExtraCheese.Controls.Add(this.lblExtraCheeseTitle);
            this.guna2PanelExtraCheese.Location = new System.Drawing.Point(10, 35);
            this.guna2PanelExtraCheese.Name = "guna2PanelExtraCheese";
            this.guna2PanelExtraCheese.Size = new System.Drawing.Size(265, 215);
            this.guna2PanelExtraCheese.TabIndex = 1;
            // 
            // btnExtraCheesePlus
            // 
            this.btnExtraCheesePlus.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraCheesePlus.BorderRadius = 5;
            this.btnExtraCheesePlus.BorderThickness = 1;
            this.btnExtraCheesePlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraCheesePlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraCheesePlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExtraCheesePlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExtraCheesePlus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtraCheesePlus.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExtraCheesePlus.ForeColor = System.Drawing.Color.DimGray;
            this.btnExtraCheesePlus.Location = new System.Drawing.Point(190, 155);
            this.btnExtraCheesePlus.Name = "btnExtraCheesePlus";
            this.btnExtraCheesePlus.Size = new System.Drawing.Size(45, 40);
            this.btnExtraCheesePlus.TabIndex = 5;
            this.btnExtraCheesePlus.Text = "+";
            // 
            // lblExtraCheeseQuantity
            // 
            this.lblExtraCheeseQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtraCheeseQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblExtraCheeseQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExtraCheeseQuantity.Location = new System.Drawing.Point(85, 155);
            this.lblExtraCheeseQuantity.Name = "lblExtraCheeseQuantity";
            this.lblExtraCheeseQuantity.Size = new System.Drawing.Size(100, 40);
            this.lblExtraCheeseQuantity.TabIndex = 4;
            this.lblExtraCheeseQuantity.Text = "1";
            this.lblExtraCheeseQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExtraCheeseMinus
            // 
            this.btnExtraCheeseMinus.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraCheeseMinus.BorderRadius = 5;
            this.btnExtraCheeseMinus.BorderThickness = 1;
            this.btnExtraCheeseMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraCheeseMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExtraCheeseMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExtraCheeseMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExtraCheeseMinus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtraCheeseMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExtraCheeseMinus.ForeColor = System.Drawing.Color.DimGray;
            this.btnExtraCheeseMinus.Location = new System.Drawing.Point(35, 155);
            this.btnExtraCheeseMinus.Name = "btnExtraCheeseMinus";
            this.btnExtraCheeseMinus.Size = new System.Drawing.Size(45, 40);
            this.btnExtraCheeseMinus.TabIndex = 3;
            this.btnExtraCheeseMinus.Text = "-";
            // 
            // lblExtraCheesePrice
            // 
            this.lblExtraCheesePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblExtraCheesePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExtraCheesePrice.Location = new System.Drawing.Point(15, 50);
            this.lblExtraCheesePrice.Name = "lblExtraCheesePrice";
            this.lblExtraCheesePrice.Size = new System.Drawing.Size(235, 20);
            this.lblExtraCheesePrice.TabIndex = 1;
            this.lblExtraCheesePrice.Text = "10.000 VND";
            this.lblExtraCheesePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExtraCheeseTitle
            // 
            this.lblExtraCheeseTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExtraCheeseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExtraCheeseTitle.Location = new System.Drawing.Point(15, 15);
            this.lblExtraCheeseTitle.Name = "lblExtraCheeseTitle";
            this.lblExtraCheeseTitle.Size = new System.Drawing.Size(235, 20);
            this.lblExtraCheeseTitle.TabIndex = 0;
            this.lblExtraCheeseTitle.Text = "Extra Cheesee";
            this.lblExtraCheeseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExtrasTitle
            // 
            this.lblExtrasTitle.AutoSize = true;
            this.lblExtrasTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExtrasTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExtrasTitle.Location = new System.Drawing.Point(7, 7);
            this.lblExtrasTitle.Name = "lblExtrasTitle";
            this.lblExtrasTitle.Size = new System.Drawing.Size(230, 23);
            this.lblExtrasTitle.TabIndex = 0;
            this.lblExtrasTitle.Text = "Phần ăn thêm cho từng suất";
            // 
            // guna2PanelSelectedOptions
            // 
            this.guna2PanelSelectedOptions.BackColor = System.Drawing.Color.White;
            this.guna2PanelSelectedOptions.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelSelectedOptions.BorderRadius = 5;
            this.guna2PanelSelectedOptions.BorderThickness = 1;
            this.guna2PanelSelectedOptions.Controls.Add(this.txtSelectedOptions);
            this.guna2PanelSelectedOptions.Controls.Add(this.lblSelectedOptionsTitle);
            this.guna2PanelSelectedOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelSelectedOptions.Location = new System.Drawing.Point(10, 10);
            this.guna2PanelSelectedOptions.Name = "guna2PanelSelectedOptions";
            this.guna2PanelSelectedOptions.Padding = new System.Windows.Forms.Padding(5);
            this.guna2PanelSelectedOptions.Size = new System.Drawing.Size(714, 75);
            this.guna2PanelSelectedOptions.TabIndex = 0;
            // 
            // txtSelectedOptions
            // 
            this.txtSelectedOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedOptions.BackColor = System.Drawing.Color.Transparent;
            this.txtSelectedOptions.BorderColor = System.Drawing.Color.LightGray;
            this.txtSelectedOptions.BorderRadius = 3;
            this.txtSelectedOptions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectedOptions.DefaultText = "Chilli Yes, Tomato Sauce Medium, Healthy Options (Food) Less Sugar, Healthy Optio" +
    "ns (Food) No Oil";
            this.txtSelectedOptions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSelectedOptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSelectedOptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectedOptions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectedOptions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSelectedOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectedOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSelectedOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(153)))));
            this.txtSelectedOptions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectedOptions.Location = new System.Drawing.Point(10, 30);
            this.txtSelectedOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSelectedOptions.Name = "txtSelectedOptions";
            this.txtSelectedOptions.PlaceholderText = "";
            this.txtSelectedOptions.ReadOnly = true;
            this.txtSelectedOptions.SelectedText = "";
            this.txtSelectedOptions.Size = new System.Drawing.Size(393, 35);
            this.txtSelectedOptions.TabIndex = 1;
            // 
            // lblSelectedOptionsTitle
            // 
            this.lblSelectedOptionsTitle.AutoSize = true;
            this.lblSelectedOptionsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSelectedOptionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectedOptionsTitle.Location = new System.Drawing.Point(7, 7);
            this.lblSelectedOptionsTitle.Name = "lblSelectedOptionsTitle";
            this.lblSelectedOptionsTitle.Size = new System.Drawing.Size(123, 23);
            this.lblSelectedOptionsTitle.TabIndex = 0;
            this.lblSelectedOptionsTitle.Text = "Chọn Option : ";
            // 
            // guna2PanelRight
            // 
            this.guna2PanelRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelRight.Controls.Add(this.btnAddToCart);
            this.guna2PanelRight.Controls.Add(this.guna2PanelDiscount);
            this.guna2PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PanelRight.Location = new System.Drawing.Point(964, 115);
            this.guna2PanelRight.Name = "guna2PanelRight";
            this.guna2PanelRight.Padding = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.guna2PanelRight.Size = new System.Drawing.Size(270, 605);
            this.guna2PanelRight.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderRadius = 5;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(10, 535);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(250, 55);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.Text = "THÊM MÓN";
            // 
            // guna2PanelDiscount
            // 
            this.guna2PanelDiscount.BackColor = System.Drawing.Color.White;
            this.guna2PanelDiscount.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelDiscount.BorderRadius = 5;
            this.guna2PanelDiscount.BorderThickness = 1;
            this.guna2PanelDiscount.Controls.Add(this.lblDiscountTitle);
            this.guna2PanelDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelDiscount.Location = new System.Drawing.Point(10, 10);
            this.guna2PanelDiscount.Name = "guna2PanelDiscount";
            this.guna2PanelDiscount.Padding = new System.Windows.Forms.Padding(5);
            this.guna2PanelDiscount.Size = new System.Drawing.Size(250, 580);
            this.guna2PanelDiscount.TabIndex = 0;
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiscountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscountTitle.Location = new System.Drawing.Point(8, 8);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(283, 23);
            this.lblDiscountTitle.TabIndex = 0;
            this.lblDiscountTitle.Text = "Danh sách giảm giá có thể áp dụng";
            // 
            // guna2PanelItemInfo
            // 
            this.guna2PanelItemInfo.BackColor = System.Drawing.Color.White;
            this.guna2PanelItemInfo.Controls.Add(this.btnQuantityPlus);
            this.guna2PanelItemInfo.Controls.Add(this.lblQuantity);
            this.guna2PanelItemInfo.Controls.Add(this.btnQuantityMinus);
            this.guna2PanelItemInfo.Controls.Add(this.btnSizeL);
            this.guna2PanelItemInfo.Controls.Add(this.btnSizeX);
            this.guna2PanelItemInfo.Controls.Add(this.btnSizeXL);
            this.guna2PanelItemInfo.Controls.Add(this.lblSizeTitle);
            this.guna2PanelItemInfo.Controls.Add(this.lblPrice);
            this.guna2PanelItemInfo.Controls.Add(this.lblFoodName);
            this.guna2PanelItemInfo.Controls.Add(this.guna2PictureBoxFoodItem);
            this.guna2PanelItemInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelItemInfo.Location = new System.Drawing.Point(0, 50);
            this.guna2PanelItemInfo.Name = "guna2PanelItemInfo";
            this.guna2PanelItemInfo.Size = new System.Drawing.Size(1234, 65);
            this.guna2PanelItemInfo.TabIndex = 2;
            // 
            // btnQuantityPlus
            // 
            this.btnQuantityPlus.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityPlus.BorderRadius = 5;
            this.btnQuantityPlus.BorderThickness = 1;
            this.btnQuantityPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantityPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantityPlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnQuantityPlus.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuantityPlus.ForeColor = System.Drawing.Color.White;
            this.btnQuantityPlus.Location = new System.Drawing.Point(720, 12);
            this.btnQuantityPlus.Name = "btnQuantityPlus";
            this.btnQuantityPlus.Size = new System.Drawing.Size(45, 40);
            this.btnQuantityPlus.TabIndex = 9;
            this.btnQuantityPlus.Text = "+";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantity.Location = new System.Drawing.Point(615, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 40);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "2";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuantityMinus
            // 
            this.btnQuantityMinus.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityMinus.BorderRadius = 5;
            this.btnQuantityMinus.BorderThickness = 1;
            this.btnQuantityMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuantityMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuantityMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuantityMinus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuantityMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuantityMinus.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuantityMinus.Location = new System.Drawing.Point(565, 12);
            this.btnQuantityMinus.Name = "btnQuantityMinus";
            this.btnQuantityMinus.Size = new System.Drawing.Size(45, 40);
            this.btnQuantityMinus.TabIndex = 7;
            this.btnQuantityMinus.Text = "-";
            // 
            // btnSizeL
            // 
            this.btnSizeL.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeL.BorderRadius = 5;
            this.btnSizeL.BorderThickness = 1;
            this.btnSizeL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSizeL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSizeL.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSizeL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSizeL.ForeColor = System.Drawing.Color.DimGray;
            this.btnSizeL.Location = new System.Drawing.Point(480, 12);
            this.btnSizeL.Name = "btnSizeL";
            this.btnSizeL.Size = new System.Drawing.Size(50, 40);
            this.btnSizeL.TabIndex = 6;
            this.btnSizeL.Text = "L";
            // 
            // btnSizeX
            // 
            this.btnSizeX.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeX.BorderRadius = 5;
            this.btnSizeX.BorderThickness = 1;
            this.btnSizeX.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeX.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSizeX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSizeX.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSizeX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSizeX.ForeColor = System.Drawing.Color.DimGray;
            this.btnSizeX.Location = new System.Drawing.Point(420, 12);
            this.btnSizeX.Name = "btnSizeX";
            this.btnSizeX.Size = new System.Drawing.Size(50, 40);
            this.btnSizeX.TabIndex = 5;
            this.btnSizeX.Text = "X";
            // 
            // btnSizeXL
            // 
            this.btnSizeXL.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeXL.BorderRadius = 5;
            this.btnSizeXL.BorderThickness = 1;
            this.btnSizeXL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnSizeXL.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSizeXL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeXL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeXL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSizeXL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSizeXL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.btnSizeXL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSizeXL.ForeColor = System.Drawing.Color.White;
            this.btnSizeXL.Location = new System.Drawing.Point(360, 12);
            this.btnSizeXL.Name = "btnSizeXL";
            this.btnSizeXL.Size = new System.Drawing.Size(50, 40);
            this.btnSizeXL.TabIndex = 4;
            this.btnSizeXL.Text = "XL";
            // 
            // lblSizeTitle
            // 
            this.lblSizeTitle.AutoSize = true;
            this.lblSizeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSizeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSizeTitle.Location = new System.Drawing.Point(295, 23);
            this.lblSizeTitle.Name = "lblSizeTitle";
            this.lblSizeTitle.Size = new System.Drawing.Size(65, 23);
            this.lblSizeTitle.TabIndex = 3;
            this.lblSizeTitle.Text = "Kích cỡ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(70, 35);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(146, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá : 130.000 VND";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFoodName.Location = new System.Drawing.Point(70, 10);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(125, 25);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "Pagini Bread";
            // 
            // guna2PictureBoxFoodItem
            // 
            this.guna2PictureBoxFoodItem.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2PictureBoxFoodItem.ImageRotate = 0F;
            this.guna2PictureBoxFoodItem.Location = new System.Drawing.Point(10, 7);
            this.guna2PictureBoxFoodItem.Name = "guna2PictureBoxFoodItem";
            this.guna2PictureBoxFoodItem.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBoxFoodItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxFoodItem.TabIndex = 0;
            this.guna2PictureBoxFoodItem.TabStop = false;
            // 
            // FormChiTietMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelMiddle);
            this.Controls.Add(this.guna2PanelRight);
            this.Controls.Add(this.guna2PanelLeft);
            this.Controls.Add(this.guna2PanelItemInfo);
            this.Controls.Add(this.guna2PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormChiTietMonAn";
            this.Size = new System.Drawing.Size(1080, 720);
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelLeft.ResumeLayout(false);
            this.guna2PanelHanLá.ResumeLayout(false);
            this.guna2PanelHanLá.PerformLayout();
            this.guna2PanelHealthy.ResumeLayout(false);
            this.guna2PanelTomato.ResumeLayout(false);
            this.guna2PanelTomato.PerformLayout();
            this.guna2PanelChilli.ResumeLayout(false);
            this.guna2PanelChilli.PerformLayout();
            this.guna2PanelMiddle.ResumeLayout(false);
            this.guna2PanelQuickQuantity.ResumeLayout(false);
            this.guna2PanelQuickQuantity.PerformLayout();
            this.guna2PanelNote.ResumeLayout(false);
            this.guna2PanelNote.PerformLayout();
            this.guna2PanelExtras.ResumeLayout(false);
            this.guna2PanelExtras.PerformLayout();
            this.guna2PanelExtraMeats.ResumeLayout(false);
            this.guna2PanelExtraCheese.ResumeLayout(false);
            this.guna2PanelSelectedOptions.ResumeLayout(false);
            this.guna2PanelSelectedOptions.PerformLayout();
            this.guna2PanelRight.ResumeLayout(false);
            this.guna2PanelDiscount.ResumeLayout(false);
            this.guna2PanelDiscount.PerformLayout();
            this.guna2PanelItemInfo.ResumeLayout(false);
            this.guna2PanelItemInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxFoodItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelItemInfo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxFoodItem;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSizeTitle;
        private Guna.UI2.WinForms.Guna2Button btnSizeXL;
        private Guna.UI2.WinForms.Guna2Button btnSizeL;
        private Guna.UI2.WinForms.Guna2Button btnSizeX;
        private Guna.UI2.WinForms.Guna2Button btnQuantityMinus;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2Button btnQuantityPlus;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLeft;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMiddle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelRight;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelChilli;
        private System.Windows.Forms.Label lblChilliTitle;
        private Guna.UI2.WinForms.Guna2Button btnChilliYes;
        private Guna.UI2.WinForms.Guna2Button btnChilliNo;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTomato;
        private Guna.UI2.WinForms.Guna2Button btnTomatoYes;
        private Guna.UI2.WinForms.Guna2Button btnTomatoMedium;
        private System.Windows.Forms.Label lblTomatoTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelHealthy;
        private Guna.UI2.WinForms.Guna2Button btnHealthyNoOil;
        private Guna.UI2.WinForms.Guna2Button btnHealthyLessSugar;
        private System.Windows.Forms.Label lblHealthyTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelHanLá;
        private Guna.UI2.WinForms.Guna2Button btnHanLaNhieu;
        private Guna.UI2.WinForms.Guna2Button btnHanLaIt;
        private System.Windows.Forms.Label lblHanLaTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSelectedOptions;
        private System.Windows.Forms.Label lblSelectedOptionsTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSelectedOptions;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelExtras;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelExtraCheese;
        private System.Windows.Forms.Label lblExtraCheeseTitle;
        private System.Windows.Forms.Label lblExtrasTitle;
        private System.Windows.Forms.Label lblExtraCheesePrice;
        private Guna.UI2.WinForms.Guna2Button btnExtraCheesePlus;
        private System.Windows.Forms.Label lblExtraCheeseQuantity;
        private Guna.UI2.WinForms.Guna2Button btnExtraCheeseMinus;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelExtraMeats;
        private Guna.UI2.WinForms.Guna2Button btnExtraMeatsPlus;
        private System.Windows.Forms.Label lblExtraMeatsQuantity;
        private Guna.UI2.WinForms.Guna2Button btnExtraMeatsMinus;
        private System.Windows.Forms.Label lblExtraMeatsPrice;
        private System.Windows.Forms.Label lblExtraMeatsTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelNote;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private System.Windows.Forms.Label lblNoteTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelQuickQuantity;
        private Guna.UI2.WinForms.Guna2Button btnQuantity2;
        private System.Windows.Forms.Label lblQuickQuantityTitle;
        private Guna.UI2.WinForms.Guna2Button btnQuantityOther;
        private Guna.UI2.WinForms.Guna2Button btnQuantity7;
        private Guna.UI2.WinForms.Guna2Button btnQuantity6;
        private Guna.UI2.WinForms.Guna2Button btnQuantity5;
        private Guna.UI2.WinForms.Guna2Button btnQuantity4;
        private Guna.UI2.WinForms.Guna2Button btnQuantity3;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelDiscount;
        private System.Windows.Forms.Label lblDiscountTitle;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
    }
}