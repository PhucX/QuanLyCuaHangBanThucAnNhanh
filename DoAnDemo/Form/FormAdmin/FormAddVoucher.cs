// FormAddVoucher.cs
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using DoAnDemo.Utils;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormAddVoucher : UserControl
    {
        #region --- Services & Data ---

        // --- Services ---
        private readonly IVoucherAdminService _voucherAdminService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        // --- Data & State ---
        private BindingSource _bsCategories;
        private BindingSource _bsProducts;
        private BindingSource _bsFreeProducts;

        private VoucherEditViewModel _currentVoucher; // Dùng khi Edit
        private bool _isEditMode = false;

        private const string _defaultTarget = "thanh_vien_dac_biet";

        #endregion

        #region --- Events ---
        /// <summary>
        /// Event được kích hoạt khi lưu thành công hoặc thất bại.
        /// </summary>
        public event EventHandler<SaveCompleteEventArgs> SaveComplete; // Event báo lưu xong
        /// <summary>
        /// Event được kích hoạt khi người dùng muốn hủy bỏ thao tác.
        /// </summary>
        public event EventHandler CancelRequested;                 // Event báo hủy

        #endregion

        #region --- Constructor & Initial Setup ---

        public FormAddVoucher()
        {
            InitializeComponent();

            // Khởi tạo Services (Nên dùng Dependency Injection nếu có thể)
            try
            {
                _voucherAdminService = new VoucherAdminService();
                _categoryService = new CategoryService();
                _productService = new ProductService();
                // _storeService = new StoreService(); // <<< KHỞI TẠO STORE SERVICE
            }
            catch (Exception ex)
            {
                LogError("Service Initialization", ex);
                MessageBox.Show($"Lỗi khởi tạo dịch vụ: {ex.Message}", "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false;
                return;
            }

            // Khởi tạo BindingSources
            _bsCategories = new BindingSource();
            _bsProducts = new BindingSource();
            _bsFreeProducts = new BindingSource();

            // Gán sự kiện
            AssignEventHandlers(); // Call method to assign handlers

            // Cấu hình DataGridViews và Controls ban đầu
            SetupDataGridViewsAndComboBox(); // Đổi tên hàm setup
        }

        /// <summary>
        /// Gán các sự kiện cho controls.
        /// </summary>
        private void AssignEventHandlers()
        {
            this.Load += FormAddVoucher_Load;
            btnLuu.Click += BtnLuu_Click;
            // Giả sử bạn thêm nút Hủy tên là btnCancel vào Designer
            // btnCancel.Click += BtnCancel_Click;
            dtpNgayBatDau.ValueChanged += DateTimePicker_ValueChanged;
            dtpNgayKetThuc.ValueChanged += DateTimePicker_ValueChanged;
            dtpNgayKetThuc.ShowCheckBox = true; // Đảm bảo có thể bỏ chọn ngày KT
            dtpNgayKetThuc.Checked = false;     // Mặc định không chọn ngày KT

            // Gán sự kiện chung cho các RadioButton điều kiện sản phẩm/danh mục
            rbApDungDanhMuc.CheckedChanged += ProductConditionRadioButton_CheckedChanged;
            rbApDungSanPham.CheckedChanged += ProductConditionRadioButton_CheckedChanged;
            rbApDungCaHai.CheckedChanged += ProductConditionRadioButton_CheckedChanged;

            btnBrowseAnh.Click += BtnBrowseAnh_Click;

            // *** GÁN SỰ KIỆN CHO CONTROLS MỚI (GIẢ ĐỊNH) ***
            // Gán sự kiện chung cho 3 nút loại giảm giá
            btnGiamGiaPercent.Click += DiscountTypeButton_Click; 
            btnGiamGiaPercent.Tag = "percentage";
            btnGiamGiaVND.Click += DiscountTypeButton_Click; btnGiamGiaVND.Tag = "fixed_amount";
            //if (btnMienPhiSanPham != null) // Kiểm tra nếu control tồn tại
            //{
            //    btnMienPhiSanPham.Click += DiscountTypeButton_Click; btnMienPhiSanPham.Tag = "free_item";
            //}
        }

        /// <summary>
        /// Xử lý sự kiện Load của UserControl.
        /// </summary>
        private void FormAddVoucher_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) // Chỉ chạy khi không ở chế độ Design
            {
                LoadCategories();
                LoadProducts();

                // Nếu không phải edit mode, reset form về trạng thái thêm mới
                if (!_isEditMode)
                {
                    ResetFormForAdd();
                }
                UpdateDiscountTypeUI(); // Cập nhật UI loại giảm giá ban đầu
                // Kích hoạt handler để đặt trạng thái grid ban đầu
                ProductConditionRadioButton_CheckedChanged(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Calls methods to setup DataGridViews and ComboBoxes.
        /// </summary>
        private void SetupDataGridViewsAndComboBox()
        {
            SetupCategoryDataGridView();
            SetupProductDataGridView();
            SetupFreeProductComboBox();
        }

        #endregion

        #region --- Data Loading Methods ---

        /// <summary>
        /// Load danh sách Danh mục vào DataGridView.
        /// </summary>
        private void LoadCategories()
        {
            try
            {
                // Giả sử CategoryViewModel từ service có CategoryId và TenDanhMuc
                 var categories = _categoryService.GetAllCategories();


                var displayCategories = categories.Select(c => new CategorySelectionViewModel
                {
                    CategoryId = c.CategoryId,
                    TenDanhMuc = c.TenDanhMuc,
                    IsSelected = false
                }).ToList();

                _bsCategories.DataSource = displayCategories;
                if (dgvCategories.DataSource == null) dgvCategories.DataSource = _bsCategories;
                else _bsCategories.ResetBindings(false);

                dgvCategories.ClearSelection();
                Log($"Loaded {displayCategories.Count} categories.");
            }
            catch (Exception ex)
            {
                LogError("LoadCategories", ex);
                MessageBox.Show($"Lỗi tải danh sách danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Load danh sách Sản phẩm vào DataGridView.
        /// </summary>
        private void LoadProducts()
        {
            try
            {
                List<ProductViewModel> products = _productService.GetAvailableProductsByStore(CurrentUserContext.User.DefaultStoreId);

                var displayProducts = products.Select(p => new ProductSelectionViewModel
                {
                    IdSanPham = p.Id,
                    TenSanPham = p.TenSanPham,
                    IsSelected = false
                }).ToList();

                _bsProducts.DataSource = displayProducts;
                if (dgvProducts.DataSource == null) dgvProducts.DataSource = _bsProducts;
                else _bsProducts.ResetBindings(false);

                dgvProducts.ClearSelection();
                Log($"Loaded {displayProducts.Count} products.");
            }
            catch (Exception ex)
            {
                LogError("LoadProducts", ex);
                MessageBox.Show($"Lỗi tải danh sách sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Placeholder: Load danh sách Cửa hàng vào control lựa chọn.
        /// </summary>
        private void LoadStores()
        {
            Log("LoadStores called (Placeholder - Store selection control and service missing).");
            // TODO: Implement logic to load stores into the missing selection control
            // try { ... _storeService.GetAllStores()... populate control ... } catch { ... }
        }

        #endregion

        #region --- Load/Reset Form ---

        /// <summary>
        /// Đổ dữ liệu của Voucher cần sửa lên Form.
        /// Hàm này được gọi từ bên ngoài (ví dụ: Form cha) trước khi hiển thị form.
        /// </summary>
        public void LoadVoucherForEdit(VoucherEditViewModel voucher)
        {
            if (voucher == null)
            {
                Log("LoadVoucherForEdit called with null voucher.");
                ResetFormForAdd();
                MessageBox.Show("Dữ liệu voucher không hợp lệ để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentVoucher = voucher;
            _isEditMode = true;
            Log($"Loading voucher for edit. ID: {voucher.Id}, Code: {voucher.MaVoucher}");

            try
            {
                // --- Đổ dữ liệu cơ bản ---
                lblTitle.Text = "SỬA VOUCHER";
                txtTenVoucher.Text = voucher.TenVoucher;
                txtMaVoucher.Text = voucher.MaVoucher;
                txtMaVoucher.ReadOnly = true;
                chkSuDungMotMa.Checked = !string.IsNullOrWhiteSpace(voucher.MaVoucher);
                chkSuDungMotMa.Enabled = false;
                txtSoLuong.Text = voucher.SoLuongPhatHanh?.ToString("N0", CultureInfo.InvariantCulture) ?? "";

                // --- Loại Giảm Giá & Giá trị ---
                txtGiaTriVoucher.Text = voucher.GiaTriGiam > 0 ? voucher.GiaTriGiam.ToString("G", CultureInfo.InvariantCulture) : "";
                txtTienGiamToiDa.Text = voucher.GiamGiaToiDa?.ToString("N0", CultureInfo.InvariantCulture) ?? "";
                // Giả sử cmbSanPhamMienPhi đã được load dữ liệu
                Guna2ComboBox cmbFreeProd = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi");
                if (cmbFreeProd != null) cmbFreeProd.SelectedValue = null; // Reset trước khi set

                // Check đúng nút loại giảm giá
                Guna2Button btnFreeItem = this.Controls.OfType<Guna2Button>().FirstOrDefault(c => c.Name == "btnMienPhiSanPham");
                btnGiamGiaPercent.Checked = false;
                btnGiamGiaVND.Checked = false;
                if (btnFreeItem != null) btnFreeItem.Checked = false;

                if (voucher.LoaiGiamGia == "percentage") { btnGiamGiaPercent.Checked = true; }
                else if (voucher.LoaiGiamGia == "fixed_amount") { btnGiamGiaVND.Checked = true; }
                else if (voucher.LoaiGiamGia == "free_item")
                {
                    if (btnFreeItem != null) btnFreeItem.Checked = true;
                    if (voucher.IdSanPhamMienPhi.HasValue && cmbFreeProd != null)
                    {
                        cmbFreeProd.SelectedValue = voucher.IdSanPhamMienPhi.Value;
                        if (cmbFreeProd.SelectedValue == null || Convert.ToInt32(cmbFreeProd.SelectedValue) != voucher.IdSanPhamMienPhi.Value)
                        { LogError($"LoadVoucher: Free product ID {voucher.IdSanPhamMienPhi} not found in ComboBox.", null); }
                    }
                }
                UpdateDiscountTypeUI(); // Cập nhật trạng thái enable/visible

                // --- Thời hạn ---
                dtpNgayBatDau.Value = voucher.NgayBatDau > dtpNgayBatDau.MinDate ? voucher.NgayBatDau : DateTime.Now.Date;
                if (voucher.NgayKetThuc < new DateTime(9000, 1, 1))
                {
                    dtpNgayKetThuc.Checked = true;
                    dtpNgayKetThuc.Value = voucher.NgayKetThuc > dtpNgayKetThuc.MinDate ? voucher.NgayKetThuc : DateTime.Now.Date;
                }
                else { dtpNgayKetThuc.Checked = false; }
                UpdateThoiGianDisplay();

                // --- Mô tả, Ảnh ---
                txtMoTa.Text = voucher.MoTa;
                // TODO: Xử lý hiển thị đường dẫn ảnh hoặc preview ảnh

                // --- Phạm vi cửa hàng ---
                if (voucher.PhamViApDung == "theo_cua_hang") { rbApDungMotSoCH.Checked = true; /* TODO: Check stores */ }
                else { rbApDungAllCH.Checked = true; /* TODO: Disable/Clear store selection */ }

                // --- Giới hạn sử dụng ---
                if (voucher.SoLuotSuDungToiDaMoiThanhVien.HasValue && voucher.SoLuotSuDungToiDaMoiThanhVien > 0)
                { btnGioiHanSoLan.Checked = true; txtSoLanSuDung.Text = voucher.SoLuotSuDungToiDaMoiThanhVien.Value.ToString("N0"); txtSoLanSuDung.Enabled = true; }
                else { btnKhongGioiHan.Checked = true; txtSoLanSuDung.Text = ""; txtSoLanSuDung.Enabled = false; }
                // TODO: Update usage limit button visual state

                // --- Điều kiện Đơn hàng, Điểm ---
                // TODO: Load các checkbox và textbox điều kiện

                // *** Đối tượng áp dụng ***
                Guna2RadioButton rbTV = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongThanhVien");
                Guna2RadioButton rbDB = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongDacBiet");
                Guna2RadioButton rbMN = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongMoiNguoi");
                if (rbTV != null) rbTV.Checked = false; if (rbDB != null) rbDB.Checked = false; if (rbMN != null) rbMN.Checked = false;

                switch (voucher.DoiTuongApDung?.ToLower())
                {
                    case "thanh_vien_dac_biet": if (rbDB != null) rbDB.Checked = true; break;
                    case "moi_nguoi": if (rbMN != null) rbMN.Checked = true; break;
                    case "thanh_vien":
                    default: if (rbTV != null) rbTV.Checked = true; break;
                }

                // *** Điều kiện Sản phẩm/Danh mục ***
                ParseDieuKienSanPhamAndSetControls(voucher.DieuKienSanPham); // Parse chuỗi cũ để set RadioButton và check grids

                // Kích hoạt handler để cập nhật trạng thái grid cuối cùng
                ProductConditionRadioButton_CheckedChanged(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                LogError($"LoadVoucherForEdit (ID: {voucher?.Id})", ex);
                MessageBox.Show($"Lỗi tải dữ liệu voucher để sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Đặt lại Form về trạng thái thêm mới mặc định.
        /// </summary>
        private void ResetFormForAdd()
        {
            _currentVoucher = null;
            _isEditMode = false;
            lblTitle.Text = "TẠO MỚI VOUCHER";
            Log("Resetting form for Add mode.");

            // --- Xóa/Đặt lại giá trị các control ---
            txtTenVoucher.Clear();
            txtMaVoucher.Clear();
            txtMaVoucher.ReadOnly = false;
            chkSuDungMotMa.Checked = false;
            chkSuDungMotMa.Enabled = true;
            txtSoLuong.Text = ""; // Hoặc default "1000"
            txtGiaTriVoucher.Clear();
            btnGiamGiaPercent.Checked = true; // Mặc định loại giảm giá
            txtTienGiamToiDa.Text = "";
            dtpNgayBatDau.Value = DateTime.Now.Date;
            dtpNgayKetThuc.Checked = false;
            dtpNgayKetThuc.Value = DateTime.Now.Date.AddMonths(1);
            txtAnhVoucherPath.Clear();
            txtMoTa.Clear();
            rbApDungAllCH.Checked = true; // Mặc định phạm vi CH
            btnKhongGioiHan.Checked = true; // Mặc định giới hạn SD
            txtSoLanSuDung.Clear();
            txtSoLanSuDung.Enabled = false;
            // Reset condition checkboxes và textboxes
            chkGiaTriToiThieu.Checked = false; /* txtGiaTriToiThieuInput.Clear(); txtGiaTriToiThieuInput.Enabled = false; */
            chkSoLuongMonToiDa.Checked = false; /* txtSoLuongMonInput.Clear(); txtSoLuongMonInput.Enabled = false; */
            chkDiemCanThiet.Checked = false; txtDiemCanThiet.Text = "0"; txtDiemCanThiet.Enabled = false;

            // Reset Loại Giảm Giá & SP Miễn Phí
            Guna2ComboBox cmbFreeProd = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi");
            if (cmbFreeProd != null) cmbFreeProd.SelectedIndex = 0; // Chọn lại "-- Chọn SP --"
            UpdateDiscountTypeUI(); // Cập nhật enable/disable theo loại mặc định

            // Reset Đối tượng áp dụng
            Guna2RadioButton rbTV = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongThanhVien");
            if (rbTV != null) rbTV.Checked = true; // Mặc định là Thành viên thường

            // Reset Điều kiện SP/DM
            rbApDungDanhMuc.Checked = false;
            rbApDungSanPham.Checked = false;
            rbApDungCaHai.Checked = false;
            ClearGridCheckboxes(dgvCategories);
            ClearGridCheckboxes(dgvProducts);

            // Update dependent UI states based on defaults
            UpdateThoiGianDisplay();
            ProductConditionRadioButton_CheckedChanged(null, EventArgs.Empty); // Cập nhật trạng thái grid
        }
        #endregion

        #region --- DataGridView & ComboBox Setup ---
        /// <summary>
        /// Configures the Category DataGridView.
        /// </summary>
        private void SetupCategoryDataGridView()
        {
            _bsCategories = _bsCategories ?? new BindingSource();
            dgvCategories.DataSource = null;
            dgvCategories.Columns.Clear();
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.RowHeadersVisible = false;

            dgvCategories.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colCatSelect", HeaderText = "", Width = 40, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, DataPropertyName = "IsSelected", FlatStyle = FlatStyle.Standard });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCatName", HeaderText = "Danh Mục", DataPropertyName = "TenDanhMuc", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });

            dgvCategories.ColumnHeadersVisible = true;
            dgvCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategories.Columns["colCatName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvCategories.DataSource = _bsCategories; // Gán DataSource sau khi định nghĩa cột
        }

        /// <summary>
        /// Configures the Product DataGridView.
        /// </summary>
        private void SetupProductDataGridView()
        {
            _bsProducts = _bsProducts ?? new BindingSource();
            dgvProducts.DataSource = null;
            dgvProducts.Columns.Clear();
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.RowHeadersVisible = false;

            dgvProducts.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colProdSelect", HeaderText = "", Width = 40, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, DataPropertyName = "IsSelected", FlatStyle = FlatStyle.Standard });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProdName", HeaderText = "Sản Phẩm", DataPropertyName = "TenSanPham", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });

            dgvProducts.ColumnHeadersVisible = true;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns["colProdName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvProducts.DataSource = _bsProducts; // Gán DataSource sau khi định nghĩa cột
        }

        /// <summary>
        /// Configures the ComboBox for selecting the free product.
        /// </summary>
        private void SetupFreeProductComboBox()
        {
            Log("Setting up Free Product ComboBox.");
            // Giả sử có ComboBox tên cmbSanPhamMienPhi trong Designer
            Guna2ComboBox targetComboBox = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi");
            if (targetComboBox != null)
            {
                targetComboBox.DataSource = _bsFreeProducts;
                targetComboBox.DisplayMember = "TenSanPham";
                targetComboBox.ValueMember = "IdSanPham";
                targetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                targetComboBox.SelectedIndex = -1; // Không chọn gì ban đầu
                targetComboBox.Enabled = false; // Mặc định tắt
            }
            else
            {
                Log("WARNING: cmbSanPhamMienPhi control not found.");
            }
        }

        // private void SetupStoreSelectionControl() { /* TODO: Setup for store selector */ }

        #endregion

        #region --- Event Handlers ---

        /// <summary>
        /// Handles the CheckedChanged event for the product condition RadioButtons.
        /// Enables/disables interaction with the corresponding DataGridViews' checkboxes
        /// and updates their visual appearance.
        /// </summary>
        private void ProductConditionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool categoriesInteractive = rbApDungDanhMuc.Checked || rbApDungCaHai.Checked;
            bool productsInteractive = rbApDungSanPham.Checked || rbApDungCaHai.Checked;

            Log($"Product condition changed: Categories Interactive={categoriesInteractive}, Products Interactive={productsInteractive}");

            // Cập nhật Grid Danh mục
            if (dgvCategories.Columns.Contains("colCatSelect")) { dgvCategories.Columns["colCatSelect"].ReadOnly = !categoriesInteractive; }
            dgvCategories.DefaultCellStyle.BackColor = categoriesInteractive ? Color.White : Color.FromArgb(240, 240, 240);
            dgvCategories.DefaultCellStyle.ForeColor = categoriesInteractive ? Color.FromArgb(64, 64, 64) : Color.Gray;
            dgvCategories.AlternatingRowsDefaultCellStyle.BackColor = categoriesInteractive ? Color.White : Color.FromArgb(240, 240, 240);
            dgvCategories.BackgroundColor = categoriesInteractive ? Color.White : Color.FromArgb(224, 224, 224);
            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = categoriesInteractive ? Color.WhiteSmoke : Color.LightGray;

            // Cập nhật Grid Sản phẩm
            if (dgvProducts.Columns.Contains("colProdSelect")) { dgvProducts.Columns["colProdSelect"].ReadOnly = !productsInteractive; }
            dgvProducts.DefaultCellStyle.BackColor = productsInteractive ? Color.White : Color.FromArgb(240, 240, 240);
            dgvProducts.DefaultCellStyle.ForeColor = productsInteractive ? Color.FromArgb(64, 64, 64) : Color.Gray;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = productsInteractive ? Color.White : Color.FromArgb(240, 240, 240);
            dgvProducts.BackgroundColor = productsInteractive ? Color.White : Color.FromArgb(224, 224, 224);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = productsInteractive ? Color.WhiteSmoke : Color.LightGray;

            // Xóa check ở grid không tương tác
            if (!categoriesInteractive) ClearGridCheckboxes(dgvCategories);
            if (!productsInteractive) ClearGridCheckboxes(dgvProducts);

            dgvCategories.Refresh();
            dgvProducts.Refresh();
        }

        /// <summary>
        /// Handles clicks on the Discount Type buttons (%, VND, Free Item).
        /// </summary>
        private void DiscountTypeButton_Click(object sender, EventArgs e)
        {
            Guna2Button btnFreeItem = this.Controls.OfType<Guna2Button>().FirstOrDefault(c => c.Name == "btnMienPhiSanPham");

            if (sender is Guna2Button clickedButton && clickedButton.Tag != null)
            {
                Log($"Discount type button clicked: {clickedButton.Tag}");

                // Logic để đảm bảo chỉ một nút được check (nếu không dùng ButtonMode=RadioButton)
                if (clickedButton != btnGiamGiaPercent) btnGiamGiaPercent.Checked = false;
                if (clickedButton != btnGiamGiaVND) btnGiamGiaVND.Checked = false;
                if (btnFreeItem != null && clickedButton != btnFreeItem) btnFreeItem.Checked = false;
                // Đảm bảo nút được click là checked
                clickedButton.Checked = true;

                UpdateDiscountTypeUI(); // Update UI based on the new selection
            }
        }


        /// <summary>
        /// Handles the Save button click event.
        /// </summary>
        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            Log("Save button clicked.");

            if (!ValidateInput()) return; // Dừng nếu validate lỗi

            VoucherEditViewModel viewModel = GatherDataFromForm(); // Thu thập data
            if (viewModel == null)
            {
                MessageBox.Show("Không thể thu thập dữ liệu từ form.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = false;
            string resultMessage = "";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (_isEditMode) // Chế độ sửa
                {
                    Log($"Attempting to update Voucher ID: {viewModel.Id}");
                    success = _voucherAdminService.UpdateVoucher(viewModel); // Thêm await ở đây
                    resultMessage = success ? "Cập nhật voucher thành công!" : "Cập nhật voucher thất bại (Service trả về false).";
                }
                else // Chế độ thêm mới
                {
                    Log("Attempting to add new Voucher.");
                    var savedVoucher = _voucherAdminService.AddVoucher(viewModel); // Gọi service Add
                    success = (savedVoucher != null && savedVoucher.Id > 0); // Kiểm tra ID trả về
                    resultMessage = success ? "Thêm mới voucher thành công!" : "Thêm mới voucher thất bại (Service không trả về ID).";
                    if (success) _currentVoucher = savedVoucher; // Lưu lại voucher vừa thêm nếu cần
                }

                // Xử lý kết quả và kích hoạt event
                if (success)
                {
                    MessageBox.Show(resultMessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(true, resultMessage, _currentVoucher)); // Gửi kèm cả voucher đã lưu/sửa
                }
                else
                {
                    MessageBox.Show(resultMessage, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, resultMessage));
                }
            }
            catch (ArgumentException argEx)
            {
                LogError("BtnLuu_Click ArgumentException", argEx);
                MessageBox.Show(argEx.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, argEx.Message));
            }
            catch (Exception ex)
            {
                LogError("BtnLuu_Click", ex);
                MessageBox.Show($"Lỗi không mong muốn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, ex.Message));
            }
            finally
            {
                if (!this.IsDisposed && this.IsHandleCreated)
                    this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Placeholder for Cancel button handler. Needs button added to Designer.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Log("Cancel button clicked.");
            CancelRequested?.Invoke(this, EventArgs.Empty); // Notify parent form
        }

        /// <summary>
        /// Handles changes in the DateTimePicker controls to update the display text.
        /// </summary>
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateThoiGianDisplay();
        }

        /// <summary>
        /// Handles the Browse button click to select an image file.
        /// </summary>
        private void BtnBrowseAnh_Click(object sender, EventArgs e)
        {
            Log("Browse image button clicked.");
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                ofd.Title = "Chọn ảnh cho Voucher";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtAnhVoucherPath.Text = ofd.FileName;
                    // TODO: Optionally display a preview of the image
                }
            }
        }

        // Add handler for TargetAudienceRadioButton_CheckedChanged if needed

        #endregion

        #region --- Input Validation ---

        /// <summary>
        /// Validates the user input on the form.
        /// </summary>
        /// <returns>True if all inputs are valid, otherwise false.</returns>
        private bool ValidateInput()
        {
            // 1. Tên Voucher
            if (string.IsNullOrWhiteSpace(txtTenVoucher.Text))
            { MessageBox.Show("Vui lòng nhập Tên Voucher.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenVoucher.Focus(); return false; }

            // 2. Loại & Giá trị Voucher
            Guna2Button btnFreeItem = this.Controls.OfType<Guna2Button>().FirstOrDefault(c => c.Name == "btnMienPhiSanPham");
            Guna2ComboBox cmbFreeProd = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi");

            if (btnGiamGiaPercent.Checked || btnGiamGiaVND.Checked)
            {
                if (!decimal.TryParse(txtGiaTriVoucher.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal giaTri) || giaTri <= 0)
                { MessageBox.Show("Giá trị voucher không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaTriVoucher.Focus(); return false; }
                if (btnGiamGiaPercent.Checked && giaTri > 100)
                { MessageBox.Show("Giá trị giảm theo % không được lớn hơn 100.", "Giá trị không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaTriVoucher.Focus(); return false; }
            }
            else if (btnFreeItem != null && btnFreeItem.Checked)
            {
                if (cmbFreeProd == null || cmbFreeProd.SelectedValue == null || !(cmbFreeProd.SelectedValue is int))
                { MessageBox.Show("Vui lòng chọn một sản phẩm miễn phí.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); if (cmbFreeProd != null) cmbFreeProd.Focus(); return false; }
            }
            else // No discount type selected
            {
                MessageBox.Show("Vui lòng chọn loại giảm giá (%, VND hoặc Miễn phí SP).", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }

            // 3. Tiền giảm tối đa (nếu có nhập)
            if (!string.IsNullOrWhiteSpace(txtTienGiamToiDa.Text))
            {
                if (!decimal.TryParse(txtTienGiamToiDa.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal giamToiDa) || giamToiDa < 0)
                { MessageBox.Show("Số tiền giảm tối đa không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTienGiamToiDa.Focus(); return false; }
            }

            // 4. Số lượng phát hành (nếu có nhập)
            if (!string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
                { MessageBox.Show("Số lượng phát hành không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoLuong.Focus(); return false; }
            }

            // 5. Số lần sử dụng / thành viên (nếu chọn giới hạn)
            if (btnGioiHanSoLan.Checked)
            {
                if (!int.TryParse(txtSoLanSuDung.Text, out int soLan) || soLan <= 0)
                { MessageBox.Show("Số lần sử dụng tối đa không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoLanSuDung.Focus(); return false; }
            }

            // 6. Ngày bắt đầu / kết thúc
            if (dtpNgayKetThuc.Checked && dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date)
            { MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Ngày không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); dtpNgayKetThuc.Focus(); return false; }

            // 7. Điểm cần thiết (nếu check)
            if (chkDiemCanThiet.Checked)
            {
                if (!int.TryParse(txtDiemCanThiet.Text, out int diem) || diem <= 0)
                { MessageBox.Show("Số điểm cần thiết không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDiemCanThiet.Focus(); return false; }
            }

            // 8. *** VALIDATION MỚI: Kiểm tra khi chọn "Cả hai" ***
            if (rbApDungCaHai.Checked)
            {
                int selectedCategoryCount = CountSelectedItems(dgvCategories, "colCatSelect");
                int selectedProductCount = CountSelectedItems(dgvProducts, "colProdSelect");

                if (selectedCategoryCount > 1 || selectedProductCount > 1)
                {
                    MessageBox.Show("Khi chọn áp dụng cho 'Cả hai', bạn chỉ được chọn tối đa 1 danh mục VÀ tối đa 1 sản phẩm.",
                                    "Giới hạn lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Lỗi validation
                }
                // Optional: Require at least one selection if 'Both' is checked?
                // if (selectedCategoryCount == 0 && selectedProductCount == 0) { ... return false; }
            }

            // 9. Kiểm tra chọn cửa hàng (placeholder)
            if (rbApDungMotSoCH.Checked) { Log("WARNING: Store selection validation skipped - Control missing."); /* TODO: Validate store selection */ }

            // 10. Kiểm tra chọn Đối tượng áp dụng
            Guna2RadioButton rbTV = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongThanhVien");
            Guna2RadioButton rbDB = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongDacBiet");
            Guna2RadioButton rbMN = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongMoiNguoi");
            if ((rbTV != null && !rbTV.Checked) && (rbDB != null && !rbDB.Checked) && (rbMN != null && !rbMN.Checked))
            {
                MessageBox.Show("Vui lòng chọn Đối tượng áp dụng cho voucher.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Focus the first radio button
                if (rbTV != null) rbTV.Focus(); else if (rbDB != null) rbDB.Focus(); else if (rbMN != null) rbMN.Focus();
                return false;
            }


            return true; // Tất cả hợp lệ
        }

        /// <summary>
        /// Helper đếm số item được check trong một cột checkbox của DataGridView.
        /// </summary>
        private int CountSelectedItems(Guna2DataGridView dgv, string checkBoxColumnName)
        {
            int count = 0;
            if (dgv == null || !dgv.Columns.Contains(checkBoxColumnName)) return 0;
            foreach (DataGridViewRow row in dgv.Rows) { if (Convert.ToBoolean(row.Cells[checkBoxColumnName].EditedFormattedValue) == true) { count++; } }
            return count;
        }

        #endregion

        #region --- Data Gathering ---

        /// <summary>
        /// Thu thập dữ liệu từ các control trên form vào đối tượng VoucherEditViewModel.
        /// Bao gồm việc xác định DieuKienSanPham string và lấy danh sách ID đã chọn.
        /// </summary>
        private VoucherEditViewModel GatherDataFromForm()
        {
            try
            {
                var viewModel = new VoucherEditViewModel();
                // Gán ID và Mã nếu sửa
                if (_isEditMode && _currentVoucher != null) { viewModel.Id = _currentVoucher.Id; viewModel.MaVoucher = _currentVoucher.MaVoucher; }
                else { viewModel.MaVoucher = string.IsNullOrWhiteSpace(txtMaVoucher.Text) ? null : txtMaVoucher.Text.Trim().ToUpper(); }
                // Gán các thuộc tính khác từ controls
                viewModel.TenVoucher = txtTenVoucher.Text.Trim();
                viewModel.MoTa = txtMoTa.Text.Trim();
                viewModel.GiamGiaToiDa = TryParseNullableDecimal(txtTienGiamToiDa.Text);
                viewModel.NgayBatDau = dtpNgayBatDau.Value;
                if (dtpNgayKetThuc.Checked) { viewModel.NgayKetThuc = dtpNgayKetThuc.Value.Date.AddDays(1).AddSeconds(-1); }
                else { viewModel.NgayKetThuc = new DateTime(9998, 12, 31); } // Ngày max hợp lệ
                viewModel.SoLuongPhatHanh = TryParseNullableInt(txtSoLuong.Text);
                if (btnGioiHanSoLan.Checked) { viewModel.SoLuotSuDungToiDaMoiThanhVien = TryParseNullableInt(txtSoLanSuDung.Text); }
                else { viewModel.SoLuotSuDungToiDaMoiThanhVien = null; } // Hoặc 0
                viewModel.PhamViApDung = rbApDungAllCH.Checked ? "toan_chuoi" : "theo_cua_hang";
                if (viewModel.PhamViApDung == "theo_cua_hang") { /* viewModel.SelectedStoreIds = GetSelectedStoreIds(); */ }
                else { viewModel.SelectedStoreIds = new List<int>(); }
                viewModel.TrangThai = "active"; // Mặc định là active khi tạo/sửa

                // *** Gather Discount Type, Value, Free Item ID ***
                Guna2Button btnFreeItem = this.Controls.OfType<Guna2Button>().FirstOrDefault(c => c.Name == "btnMienPhiSanPham");
                Guna2ComboBox cmbFreeProd = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi");

                if (btnGiamGiaPercent.Checked)
                {
                    viewModel.LoaiGiamGia = "percentage";
                    decimal.TryParse(txtGiaTriVoucher.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal percentValue);
                    viewModel.GiaTriGiam = percentValue;
                    viewModel.IdSanPhamMienPhi = null;
                }
                else if (btnGiamGiaVND.Checked)
                {
                    viewModel.LoaiGiamGia = "fixed_amount";
                    decimal.TryParse(txtGiaTriVoucher.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal amountValue);
                    viewModel.GiaTriGiam = amountValue;
                    viewModel.IdSanPhamMienPhi = null;
                }
                else if (btnFreeItem != null && btnFreeItem.Checked)
                {
                    viewModel.LoaiGiamGia = "free_item";
                    viewModel.GiaTriGiam = 0;
                    viewModel.IdSanPhamMienPhi = (cmbFreeProd != null) ? (int?)cmbFreeProd.SelectedValue : null;
                }
                else { /* Error state handled by validation */ }

                // *** Gather Target Audience ***
                Guna2RadioButton rbDB = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongDacBiet");
                Guna2RadioButton rbMN = this.Controls.OfType<Guna2RadioButton>().FirstOrDefault(c => c.Name == "rbDoiTuongMoiNguoi");

                if (rbDB != null && rbDB.Checked) { viewModel.DoiTuongApDung = "thanh_vien_dac_biet"; }
                else if (rbMN != null && rbMN.Checked) { viewModel.DoiTuongApDung = "moi_nguoi"; }
                else { viewModel.DoiTuongApDung = "thanh_vien"; } // Default


                // *** THU THẬP ID VÀ TẠO CHUỖI DieuKienSanPham ***
                viewModel.SelectedCategoryIds = GetSelectedIds<CategorySelectionViewModel, int>(dgvCategories, "colCatSelect", vm => vm.CategoryId);
                viewModel.SelectedProductIds = GetSelectedIds<ProductSelectionViewModel, int>(dgvProducts, "colProdSelect", vm => vm.IdSanPham);

                List<string> selectedCategoryNames = GetSelectedNames<CategorySelectionViewModel>(dgvCategories, "colCatSelect", vm => vm.TenDanhMuc);
                List<string> selectedProductNames = GetSelectedNames<ProductSelectionViewModel>(dgvProducts, "colProdSelect", vm => vm.TenSanPham);

                StringBuilder conditionBuilder = new StringBuilder();
                bool conditionAdded = false;

                if ((rbApDungDanhMuc.Checked || rbApDungCaHai.Checked) && selectedCategoryNames.Any())
                { conditionBuilder.Append($"Category: {string.Join(", ", selectedCategoryNames)}"); conditionAdded = true; }
                if ((rbApDungSanPham.Checked || rbApDungCaHai.Checked) && selectedProductNames.Any())
                { if (conditionAdded) conditionBuilder.Append("; "); conditionBuilder.Append($"Product: {string.Join(", ", selectedProductNames)}"); }

                viewModel.DieuKienSanPham = conditionBuilder.Length > 0 ? conditionBuilder.ToString() : null; // Gán chuỗi hoặc null nếu rỗng
                Log($"Generated DieuKienSanPham: '{viewModel.DieuKienSanPham}'");

                // TODO: Gather other condition values (min order, points, ...)

                return viewModel;
            }
            catch (Exception ex) { LogError("GatherDataFromForm", ex); return null; }
        }

        /// <summary>
        /// Helper lấy danh sách ID của các item được chọn trong DataGridView.
        /// </summary>
        private List<TId> GetSelectedIds<TViewModel, TId>(Guna2DataGridView dgv, string checkBoxColName, Func<TViewModel, TId> idSelector) where TViewModel : class, ISelectable
        {
            List<TId> selectedIds = new List<TId>();
            bool canSelect = (dgv == dgvCategories && (rbApDungDanhMuc.Checked || rbApDungCaHai.Checked)) ||
                             (dgv == dgvProducts && (rbApDungSanPham.Checked || rbApDungCaHai.Checked));

            if (canSelect && dgv != null && dgv.Columns.Contains(checkBoxColName))
            {
                try
                {
                    if (dgv.DataSource is BindingSource bs && bs.DataSource is IEnumerable<TViewModel> sourceList)
                    { selectedIds.AddRange(sourceList.Where(vm => vm.IsSelected).Select(idSelector)); }
                    else { /* Fallback */ }
                }
                catch (Exception ex) { LogError($"GetSelectedIds for {dgv.Name}", ex); }
            }
            Log($"Gathered selected IDs for {dgv.Name}: {selectedIds.Count}");
            return selectedIds;
        }

        /// <summary>
        /// Helper lấy danh sách TÊN của các item được chọn trong DataGridView.
        /// </summary>
        private List<string> GetSelectedNames<TViewModel>(Guna2DataGridView dgv, string checkBoxColName, Func<TViewModel, string> nameSelector) where TViewModel : class, ISelectable
        {
            List<string> selectedNames = new List<string>();
            bool canSelect = (dgv == dgvCategories && (rbApDungDanhMuc.Checked || rbApDungCaHai.Checked)) ||
                             (dgv == dgvProducts && (rbApDungSanPham.Checked || rbApDungCaHai.Checked));

            if (canSelect && dgv != null && dgv.Columns.Contains(checkBoxColName))
            {
                try
                {
                    if (dgv.DataSource is BindingSource bs && bs.DataSource is IEnumerable<TViewModel> sourceList)
                    { selectedNames.AddRange(sourceList.Where(vm => vm.IsSelected).Select(nameSelector)); }
                    else { /* Fallback */ }
                }
                catch (Exception ex) { LogError($"GetSelectedNames for {dgv.Name}", ex); }
            }
            Log($"Gathered selected Names for {dgv.Name}: {selectedNames.Count}");
            return selectedNames;
        }

        // <<< CẦN HÀM GetSelectedStoreIds() KHI CÓ CONTROL >>>

        #endregion

        #region --- Parsing Helpers ---
        private int? TryParseNullableInt(string value) { if (int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out int result)) { return result; } return null; }
        private decimal? TryParseNullableDecimal(string value) { if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result)) { return result; } return null; }
        #endregion

        #region --- UI Update & Helper Methods ---
        private void UpdateThoiGianDisplay()
        {
            // ... (Implementation remains the same) ...
            try 
            { 
                DateTime start = dtpNgayBatDau.Value;
                string startStr = $"Áp dụng từ: {start:dd/MM/yyyy HH:mm:ss}";
                string endStr = "Không thời hạn"; 
                txtDisplayThoiGian.ForeColor = Color.FromArgb(94, 148, 255);
                if (dtpNgayKetThuc.Checked) 
                { 
                    DateTime end = dtpNgayKetThuc.Value; 
                    if (end.Date < start.Date) 
                    { 
                        endStr = "Ngày kết thúc KHÔNG HỢP LỆ!"; 
                        txtDisplayThoiGian.ForeColor = Color.Red;
                    }
                    else 
                    {
                        DateTime endOfDay = end.Date.AddDays(1).AddSeconds(-1);
                        endStr = $"Đến hết ngày: {endOfDay:dd/MM/yyyy HH:mm:ss}";
                    }
                }
                txtDisplayThoiGian.Text = $"{startStr}   |   {endStr}"; } 
            catch (Exception ex) { LogError("Đã xảy ra lỗi", ex);  }
        }

        private void ClearGridCheckboxes(Guna2DataGridView dgv)
        {
            // ... (Implementation remains the same) ...
            if (dgv == null || dgv.Rows.Count == 0 || dgv.Columns.Count == 0) return; string checkBoxColName = dgv.Columns[0].Name; if (dgv.Columns.Contains(checkBoxColName) && dgv.Columns[checkBoxColName] is DataGridViewCheckBoxColumn) { Log($"Clearing checkboxes in {dgv.Name}"); bool changed = false; if (dgv.DataSource is BindingSource bs && bs.DataSource is System.Collections.IList sourceList) { for (int i = 0; i < sourceList.Count; i++) { if (sourceList[i] is ISelectable item && item.IsSelected) { item.IsSelected = false; if (i < dgv.Rows.Count && !dgv.Rows[i].IsNewRow) dgv.Rows[i].Cells[checkBoxColName].Value = false; changed = true; } } if (changed) bs.ResetBindings(false); } else { foreach (DataGridViewRow row in dgv.Rows) { if (Convert.ToBoolean(row.Cells[checkBoxColName].EditedFormattedValue) == true) { row.Cells[checkBoxColName].Value = false; changed = true; } } } if (changed) dgv.Refresh(); }
        }

        /// <summary>
        /// Updates the UI elements related to the discount type selection.
        /// </summary>
        private void UpdateDiscountTypeUI()
        {
            Guna2Button btnFreeItem = this.Controls.OfType<Guna2Button>().FirstOrDefault(c => c.Name == "btnMienPhiSanPham");
            Guna2ComboBox cmbFreeProd = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi");

            bool isFreeItem = (btnFreeItem != null && btnFreeItem.Checked);
            bool isValueDiscount = btnGiamGiaPercent.Checked || btnGiamGiaVND.Checked;

            // Enable/disable controls
            txtGiaTriVoucher.Enabled = isValueDiscount;
            lblTienGiamToiDa.Enabled = btnGiamGiaPercent.Checked; // Only for percentage? Or always?
            txtTienGiamToiDa.Enabled = lblTienGiamToiDa.Enabled;
            if (cmbFreeProd != null) cmbFreeProd.Enabled = isFreeItem;

            // Clear irrelevant fields
            if (!isValueDiscount) txtGiaTriVoucher.Clear();
            if (!lblTienGiamToiDa.Enabled) txtTienGiamToiDa.Clear();
            if (!isFreeItem && cmbFreeProd != null && cmbFreeProd.Items.Count > 0) { cmbFreeProd.SelectedIndex = 0; } // Reset combo if not free item

            // Update labels/placeholders
            lblGiaTriVoucher.Text = isFreeItem ? "Sản phẩm miễn phí" : "Giá trị voucher";
            txtGiaTriVoucher.PlaceholderText = btnGiamGiaPercent.Checked ? "Nhập %" : (btnGiamGiaVND.Checked ? "Nhập số tiền VND" : "");

            // Update visual state of buttons if not using ButtonMode=RadioButton
            // ... (update FillColor/ForeColor if needed) ...
        }


        /// <summary>
        /// Parses the DieuKienSanPham string and sets RadioButtons and checks grids accordingly.
        /// </summary>
        private void ParseDieuKienSanPhamAndSetControls(string dieuKienSanPhamString)
        {
            // ... (Implementation remains the same as previous version) ...
            Log($"Parsing DieuKienSanPhamString: '{dieuKienSanPhamString}'");
            List<string> categoryNamesToSelect = new List<string>();
            List<string> productNamesToSelect = new List<string>();
            bool applyToCats = false;
            bool applyToProds = false;
            ClearGridCheckboxes(dgvCategories);
            ClearGridCheckboxes(dgvProducts); 
            if (!string.IsNullOrWhiteSpace(dieuKienSanPhamString)) 
            { /* ... Parsing logic using Regex ... */ 
                string[] parts = dieuKienSanPhamString.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string part in parts) 
                { 
                    string trimmedPart = part.Trim();
                    Match catMatch = Regex.Match(trimmedPart, @"^Category:\s*(.+)$", RegexOptions.IgnoreCase);
                    if (catMatch.Success) 
                    { 
                        applyToCats = true;
                        string namesString = catMatch.Groups[1].Value.Trim();
                        categoryNamesToSelect.AddRange(namesString.Split(new[] { ',' },     StringSplitOptions.RemoveEmptyEntries)
                            .Select(name => name.Trim())
                            .Where(name => !string.IsNullOrEmpty(name)));
                        continue;
                    }
                    Match prodMatch = Regex.Match(trimmedPart, @"^Product:\s*(.+)$", RegexOptions.IgnoreCase);
                    if (prodMatch.Success) 
                    { 
                        applyToProds = true;
                        string namesString = prodMatch.Groups[1].Value.Trim();
                        productNamesToSelect.AddRange(namesString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(name => name.Trim()).Where(name => !string.IsNullOrEmpty(name))); 
                    } 
                } 
            }
            if (applyToCats && applyToProds) 
            {
                rbApDungCaHai.Checked = true; 
            }
            else if (applyToCats) 
            {
                rbApDungDanhMuc.Checked = true;
            }
            else if (applyToProds) 
            {
                rbApDungSanPham.Checked = true; 
            }
            else
            { 
                rbApDungDanhMuc.Checked = false;
                rbApDungSanPham.Checked = false;
                rbApDungCaHai.Checked = false; 
            }
            CheckSelectedItemsByName<CategorySelectionViewModel>(dgvCategories, categoryNamesToSelect, vm => vm.TenDanhMuc); CheckSelectedItemsByName<ProductSelectionViewModel>(dgvProducts, productNamesToSelect, vm => vm.TenSanPham);
        }

        /// <summary>
        /// Helper method to check items in a DataGridView based on a list of names.
        /// </summary>
        private void CheckSelectedItemsByName<TViewModel>(Guna2DataGridView dgv, List<string> namesToSelect, Func<TViewModel, string> nameSelector)
            where TViewModel : class, ISelectable
        {
            // ... (Implementation remains the same) ...
            if (namesToSelect == null || dgv?.DataSource == null) return; Log($"Checking items by name in {dgv.Name}. Names count: {namesToSelect.Count}"); bool changed = false; if (dgv.DataSource is BindingSource bs && bs.List is IList<TViewModel> itemList) { var nameSet = new HashSet<string>(namesToSelect, StringComparer.OrdinalIgnoreCase); foreach (TViewModel item in itemList) { bool shouldBeSelected = nameSet.Contains(nameSelector(item)); if (item.IsSelected != shouldBeSelected) { item.IsSelected = shouldBeSelected; changed = true; } } if (changed) bs.ResetBindings(false); } else { LogError($"CheckSelectedItemsByName failed for {dgv.Name} - DataSource is not IList<{typeof(TViewModel).Name}>", null); }
            if (changed) dgv.Refresh();
        }

        #endregion

        #region --- Logging ---
        private void Log(string message) { Debug.WriteLine($"[FormAddVoucher] {DateTime.Now:HH:mm:ss.fff} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormAddVoucher ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }
        #endregion

    } // End Class

} // End Namespace