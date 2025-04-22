// FormAddVoucherStore.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Utils;
using DoAnDemo.Models;
using Guna.UI2.WinForms;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormAddVoucherStore : UserControl
    {
        #region --- Services & Data ---
        // --- Services ---
        private readonly IVoucherAdminService _voucherAdminService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ICuaHangService _cuaHangService;

        private BindingSource _bsCategories;
        private BindingSource _bsProducts;
        private BindingSource _bsFreeProducts;
        private BindingSource _bsStores;
        private VoucherEditViewModel _currentVoucher;
        private bool _isEditMode = false;
        private List<StoreViewModel> _allActiveStores;

        private CheckedListBox checkedListBoxStores;

        // Note: Control fields are now defined in Designer.cs
        #endregion

        #region --- Events ---
        public event EventHandler<SaveCompleteEventArgs> SaveComplete;
        public event EventHandler CancelRequested;
        #endregion

        #region --- Constructor & Initial Setup ---
        public FormAddVoucherStore()
        {
            InitializeComponent();

            // Initialize Services
            try
            {
                _voucherAdminService = new VoucherAdminService();
                _categoryService = new CategoryService();
                _productService = new ProductService();
                _cuaHangService = new CuaHangService();
            }
            catch (Exception ex)
            {
                LogError("Service Initialization", ex);
                MessageBox.Show(
                    $"Lỗi khởi tạo dịch vụ: {ex.Message}",
                    "Lỗi nghiêm trọng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Enabled = false;
                return;
            }

            // Initialize BindingSources
            _bsCategories = new BindingSource();
            _bsProducts = new BindingSource();
            _bsFreeProducts = new BindingSource();
            _bsStores = new BindingSource();

            // Set up controls and assign events
            SetupDataGridViewsAndComboBox();
            SetupStoreSelectionMechanism();
            AssignEventHandlers();
        }
        #endregion

        #region --- Constructor & Initial Setup ---

        /// <summary>
        /// Gán các sự kiện cho controls.
        /// </summary>
        private void AssignEventHandlers()
        {
            // Form events
            this.Load += FormAddVoucherStore_Load;
            btnLuu.Click += BtnLuu_Click;

            if (btnCancel != null)
            {
                btnCancel.Click += BtnCancel_Click;
            }

            // DateTime events
            dtpNgayBatDau.ValueChanged += DateTimePicker_ValueChanged;
            dtpNgayKetThuc.ValueChanged += DateTimePicker_ValueChanged;
            dtpNgayKetThuc.ShowCheckBox = true;
            dtpNgayKetThuc.Checked = false;

            // Radio button events
            rbApDungDanhMuc.CheckedChanged += ProductConditionRadioButton_CheckedChanged;
            rbApDungSanPham.CheckedChanged += ProductConditionRadioButton_CheckedChanged;

            // Discount type button events
            btnGiamGiaPercent.Click += DiscountTypeButton_Click;
            btnGiamGiaPercent.Tag = "percentage";

            btnGiamGiaVND.Click += DiscountTypeButton_Click;
            btnGiamGiaVND.Tag = "fixed_amount";

            if (btnMienPhiSanPham != null)
            {
                btnMienPhiSanPham.Click += DiscountTypeButton_Click;
                btnMienPhiSanPham.Tag = "free_item";
            }

            // Store selection events
            btnDropdownCuaHang.Click += BtnDropdownCuaHang_Click;

            // Condition checkbox events
            chkGiaTriToiThieu.CheckedChanged += ConditionCheckBox_CheckedChanged;
            chkApDungKhachHang.CheckedChanged += ConditionCheckBox_CheckedChanged;
            ckoApDungCuaHang.CheckedChanged += ConditionCheckBox_CheckedChanged;
        }

        /// <summary>
        /// Xử lý sự kiện Load của UserControl.
        /// </summary>
        private void FormAddVoucherStore_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadCategories();
                LoadProducts();
                LoadFreeProductsCombo();

                // Load danh sách cửa hàng dựa trên vai trò của admin
                if (CurrentUserContext.IsAdmin)
                {
                    _allActiveStores = _cuaHangService.GetActiveStores();
                }
                else if (CurrentUserContext.IsAreaManager)
                {
                    _allActiveStores = _cuaHangService.GetActiveStoresByRegion(CurrentUserContext.User.DefaultStoreId.ToString());
                }
                else
                {
                    _allActiveStores = new List<StoreViewModel>
                    {
                        _cuaHangService.GetStoreById(CurrentUserContext.User.EmployeeId)
                    };
                }

                _bsStores.DataSource = _allActiveStores;
                LoadStoresForSelection();

                if (!_isEditMode)
                {
                    ResetFormForAdd();
                }

                UpdateDiscountTypeUI();
                UpdateConditionControlsState();
                ProductConditionRadioButton_CheckedChanged(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gọi các hàm setup controls.
        /// </summary>
        private void SetupDataGridViewsAndComboBox()
        {
            SetupCategoryDataGridView();
            SetupProductDataGridView();
            SetupFreeProductComboBox();
            SetupStoreSelectionMechanism();
        }

        /// <summary>
        /// Setup cơ chế chọn cửa hàng (ví dụ: tạo context menu).
        /// </summary>
        private void SetupStoreSelectionMechanism()
        {
            if (checkedListBoxStores == null)
            {
                checkedListBoxStores = new CheckedListBox
                {
                    CheckOnClick = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = fpnlCuaHang.Width,
                    Height = 200,
                    Visible = false // Ẩn ban đầu
                };

                checkedListBoxStores.DataSource = _bsStores;
                checkedListBoxStores.DisplayMember = "TenCuaHang";
                checkedListBoxStores.ValueMember = "Id";
                checkedListBoxStores.ItemCheck += CheckedListBoxStores_ItemCheck;

                this.Controls.Add(checkedListBoxStores);

                // Thêm sự kiện để ẩn checkedListBox khi click ra ngoài
                this.Click += (sender, e) => HideStoresList();
                checkedListBoxStores.LostFocus += (sender, e) => HideStoresList();

                Log("Store selection mechanism setup complete.");
            }
            else
            {
                Log("Store selection mechanism already setup.");
            }
        }

        private void SetupControls()
        {
            // Set title style
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 85, 155);

            // Setup DataGridViews
            SetupDataGridView(dgvCategories, "Danh Mục");
            SetupDataGridView(dgvProducts, "Sản Phẩm");

            // Setup DateTimePickers
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            // Setup Buttons
            SetupButton(btnGiamGiaPercent, "percentage");
            SetupButton(btnGiamGiaVND, "fixed_amount");
            SetupButton(btnMienPhiSanPham, "free_item");

            // Setup ComboBox
            if (cmbSanPhamMienPhi != null)
            {
                cmbSanPhamMienPhi.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbSanPhamMienPhi.Enabled = false;
            }

            // Setup FlowLayoutPanel for stores
            fpnlCuaHang.FlowDirection = FlowDirection.LeftToRight;
            fpnlCuaHang.WrapContents = true;
            fpnlCuaHang.AutoScroll = true;
        }

        private void SetupDataGridView(Guna2DataGridView dgv, string headerText)
        {
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count > 1)
            {
                dgv.Columns[1].HeaderText = headerText;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        private void SetupButton(Guna2Button btn, string tag)
        {
            if (btn != null)
            {
                btn.Tag = tag;
                btn.FillColor = Color.WhiteSmoke;
                btn.ForeColor = Color.Gray;
                btn.BorderColor = Color.Gainsboro;
                btn.BorderThickness = 1;
                btn.BorderRadius = 5;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                SetupControls();
                LoadInitialData();
            }
        }

        private void LoadInitialData()
        {
            try
            {
                LoadCategories();
                LoadProducts();
                LoadFreeProductsCombo();
                LoadStoresForSelection();

                if (!_isEditMode)
                {
                    ResetFormForAdd();
                }

                UpdateDiscountTypeUI();
                UpdateConditionControlsState();
            }
            catch (Exception ex)
            {
                LogError("LoadInitialData", ex);
                MessageBox.Show(
                    "Có lỗi khi tải dữ liệu ban đầu. Vui lòng thử lại.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        #endregion

        #region --- Data Loading Methods ---

        private void LoadCategories()
        {
            try
            {
                var categories = _categoryService.GetAllCategories();
                if (categories == null) categories = new List<CategoryViewModel>(); // Xử lý null
                var displayCategories = categories.Select((c, index) => new CategorySelectionViewModel { CategoryId = c.CategoryId, TenDanhMuc = c.TenDanhMuc, IsSelected = false }).ToList();
                _bsCategories.DataSource = displayCategories;
                if (dgvCategories.DataSource == null) dgvCategories.DataSource = _bsCategories; else _bsCategories.ResetBindings(false);
                dgvCategories.ClearSelection(); Log($"Loaded {displayCategories.Count} categories.");
            }
            catch (Exception ex) { LogError("LoadCategories", ex); /*...*/ }
        }

        private void LoadProducts()
        {
            try
            {
                List<ProductViewModel> products = _productService.GetAvailableProductsByStore(CurrentUserContext.User.DefaultStoreId);
                var displayProducts = products.Select(p => new ProductSelectionViewModel { IdSanPham = p.Id, TenSanPham = p.TenSanPham, IsSelected = false }).ToList();
                _bsProducts.DataSource = displayProducts;
                if (dgvProducts.DataSource == null) dgvProducts.DataSource = _bsProducts; else _bsProducts.ResetBindings(false);
                dgvProducts.ClearSelection(); Log($"Loaded {displayProducts.Count} products.");
            }
            catch (Exception ex) { LogError("LoadProducts", ex); /*...*/ }
        }

        /// <summary>
        /// Load danh sách sản phẩm vào ComboBox chọn sản phẩm miễn phí.
        /// </summary>
        private void LoadFreeProductsCombo()
        {
            Guna2ComboBox targetComboBox = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi");
            if (targetComboBox == null) { Log("LoadFreeProductsCombo: cmbSanPhamMienPhi not found."); return; }

            try
            {
                List<ProductViewModel> products = _productService.GetAvailableProductsByStore(CurrentUserContext.User.DefaultStoreId);

                var comboItems = new List<object> { new { IdSanPham = (int?)null, TenSanPham = "-- Chọn Sản phẩm --" } };
                comboItems.AddRange(products.Select(p => new { IdSanPham = (int?)p.Id, TenSanPham = p.TenSanPham }).ToList());

                _bsFreeProducts.DataSource = comboItems;

                targetComboBox.DisplayMember = "";
                targetComboBox.ValueMember = "";
                targetComboBox.DataSource = null; // Ngắt binding cũ

                targetComboBox.DataSource = _bsFreeProducts; // Gán binding mới
                targetComboBox.DisplayMember = "TenSanPham";
                targetComboBox.ValueMember = "IdSanPham";

                // Các cài đặt khác
                targetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                targetComboBox.SelectedIndex = 0; // Chọn dòng mặc định
                targetComboBox.Enabled = false; // Mặc định tắt
                Log($"Loaded {products.Count} products into Free Product ComboBox.");
            }
            catch (Exception ex) { LogError("LoadFreeProductsCombo", ex); /*...*/ }
        }

        /// <summary>
        /// Load danh sách cửa hàng đang hoạt động để chuẩn bị cho việc chọn lựa.
        /// </summary>
        private void LoadStoresForSelection()
        {
            Log("Loading active stores for selection...");
            try
            {
                if (_cuaHangService == null) throw new InvalidOperationException("CuaHang Service is not initialized.");
                _allActiveStores = _cuaHangService.GetActiveStores();

                var storeSelectionList = new List<StoreSelectionViewModel>();

                if (CurrentUserContext.IsAdmin)
                {
                    storeSelectionList = _allActiveStores.Select(s => new StoreSelectionViewModel { Id = s.Id, TenCuaHang = s.TenCuaHang, IsSelected = false }).ToList();
                }
                else if (CurrentUserContext.IsAreaManager)
                {
                    storeSelectionList = _cuaHangService.GetActiveStoresByRegion(_cuaHangService.GetRegionByStoreId(CurrentUserContext.User.DefaultStoreId))
                        .Select(s => new StoreSelectionViewModel { Id = s.Id, TenCuaHang = s.TenCuaHang, IsSelected = false }).ToList();
                }
                else if (CurrentUserContext.IsStoreManager)
                {
                    storeSelectionList.Add(new StoreSelectionViewModel { Id = CurrentUserContext.User.EmployeeId, TenCuaHang = _cuaHangService.GetStoreNameById(CurrentUserContext.User.EmployeeId), IsSelected = false });
                }

                _bsStores.DataSource = storeSelectionList;

                Log($"Loaded {_allActiveStores.Count} active stores for selection.");
            }
            catch (Exception ex) { LogError("LoadStoresForSelection", ex); /*...*/ }
        }

        #endregion

        #region --- Load/Reset Form ---

        public void LoadVoucherForEdit(VoucherEditViewModel voucher)
        {
            if (voucher == null) { Log("LoadVoucherForEdit: null voucher."); ResetFormForAdd(); return; }
            _currentVoucher = voucher; _isEditMode = true; Log($"Loading voucher for edit. ID: {voucher.Id}");
            try
            {
                lblTitle.Text = "SỬA CHƯƠNG TRÌNH GIẢM GIÁ";
                txtTenChuongTrinh.Text = voucher.TenVoucher;
                txtMaVoucher.Text = voucher.MaVoucher; // txtMaVoucher có thể null nếu control bị xóa/ẩn
                if (txtMaVoucher != null) txtMaVoucher.ReadOnly = true;
                if (chkSuDungMotMa != null) { chkSuDungMotMa.Checked = !string.IsNullOrWhiteSpace(voucher.MaVoucher); chkSuDungMotMa.Enabled = false; }
                if (txtSoLuong != null) txtSoLuong.Text = voucher.SoLuongPhatHanh?.ToString("N0") ?? "";
                txtMoTa.Text = voucher.MoTa;
                txtSoTienGiamToiDa.Text = voucher.GiamGiaToiDa?.ToString("N0") ?? "";
                dtpNgayBatDau.Value = voucher.NgayBatDau > dtpNgayBatDau.MinDate ? voucher.NgayBatDau : DateTime.Now.Date;
                if (voucher.NgayKetThuc < new DateTime(9000, 1, 1)) { dtpNgayKetThuc.Checked = true; dtpNgayKetThuc.Value = voucher.NgayKetThuc > dtpNgayKetThuc.MinDate ? voucher.NgayKetThuc : DateTime.Now.Date; }
                else { dtpNgayKetThuc.Checked = false; }

                // Load Discount Type
                txtGiaTriGiamGia.Text = voucher.GiaTriGiam > 0 ? voucher.GiaTriGiam.ToString("G", CultureInfo.InvariantCulture) : "";
                if (cmbSanPhamMienPhi != null) cmbSanPhamMienPhi.SelectedValue = null;
                if (btnMienPhiSanPham != null) btnMienPhiSanPham.Checked = false;
                btnGiamGiaPercent.Checked = false; btnGiamGiaVND.Checked = false;
                if (voucher.LoaiGiamGia == "percentage") { btnGiamGiaPercent.Checked = true; }
                else if (voucher.LoaiGiamGia == "fixed_amount") { btnGiamGiaVND.Checked = true; }
                else if (voucher.LoaiGiamGia == "free_item") { if (btnMienPhiSanPham != null) btnMienPhiSanPham.Checked = true; if (voucher.IdSanPhamMienPhi.HasValue && cmbSanPhamMienPhi != null) { cmbSanPhamMienPhi.SelectedValue = voucher.IdSanPhamMienPhi.Value; } }

                // Load Store Scope & Selection
                ckoApDungCuaHang.Checked = (voucher.PhamViApDung == "theo_cua_hang");
                CheckSelectedStores(voucher.SelectedStoreIds);

                // Load Usage Limit
                if (txtSoLanSuDung != null && btnGioiHanSoLan != null && btnKhongGioiHan != null)
                {
                    if (voucher.SoLuotSuDungToiDaMoiThanhVien.HasValue && voucher.SoLuotSuDungToiDaMoiThanhVien > 0) { btnGioiHanSoLan.Checked = true; txtSoLanSuDung.Text = voucher.SoLuotSuDungToiDaMoiThanhVien.Value.ToString("N0"); txtSoLanSuDung.Enabled = true; }
                    else { btnKhongGioiHan.Checked = true; txtSoLanSuDung.Text = ""; txtSoLanSuDung.Enabled = false; }
                }

                // Load Conditions
                chkGiaTriToiThieu.Checked = voucher.GiaTriDonHangToiThieu > 0;
                txtGiaTriToiThieu.Text = chkGiaTriToiThieu.Checked ? voucher.GiaTriDonHangToiThieu.ToString("N0") : "";
                chkApDungKhachHang.Checked = voucher.DoiTuongApDung == "thanh_vien" || voucher.DoiTuongApDung == "thanh_vien_dac_biet";

                // Parse và set Product/Category Conditions
                ParseDieuKienSanPhamAndSetControls(voucher.DieuKienSanPham);

                // Update UI states
                UpdateThoiGianDisplay(); UpdateDiscountTypeUI(); UpdateConditionControlsState();
                ProductConditionRadioButton_CheckedChanged(null, EventArgs.Empty);
            }
            catch (Exception ex) { LogError($"LoadVoucherForEdit", ex); /*...*/ }
        }

        public void ResetFormForAdd()
        {
            _currentVoucher = null; _isEditMode = false; lblTitle.Text = "TẠO MỚI CHƯƠNG TRÌNH GIẢM GIÁ";
            Log("Resetting form for Add mode.");

            txtTenChuongTrinh.Clear(); txtMoTa.Clear(); txtGiaTriGiamGia.Clear(); txtSoTienGiamToiDa.Text = "";
            if (txtMaVoucher != null) { txtMaVoucher.Clear(); txtMaVoucher.ReadOnly = false; }
            if (chkSuDungMotMa != null) { chkSuDungMotMa.Checked = false; chkSuDungMotMa.Enabled = true; }
            if (txtSoLuong != null) txtSoLuong.Text = "";
            if (txtAnhVoucherPath != null) txtAnhVoucherPath.Clear();

            ckoApDungCuaHang.Checked = false;
            ClearStoreSelectionPopup();
            UpdateStoreSelectionUI(false);
            btnGiamGiaPercent.Checked = true; if (btnMienPhiSanPham != null) btnMienPhiSanPham.Checked = false; btnGiamGiaVND.Checked = false; if (cmbSanPhamMienPhi != null && cmbSanPhamMienPhi.Items.Count > 0) cmbSanPhamMienPhi.SelectedIndex = 0;
            dtpNgayBatDau.Value = DateTime.Now.Date; dtpNgayKetThuc.Checked = false; dtpNgayKetThuc.Value = DateTime.Now.Date.AddMonths(1);
            if (btnKhongGioiHan != null) btnKhongGioiHan.Checked = true; if (txtSoLanSuDung != null) { txtSoLanSuDung.Clear(); txtSoLanSuDung.Enabled = false; }
            chkGiaTriToiThieu.Checked = false; txtGiaTriToiThieu.Clear(); txtGiaTriToiThieu.Enabled = false;
            chkApDungKhachHang.Checked = false; // Default Mọi người?

            rbApDungDanhMuc.Checked = false; rbApDungSanPham.Checked = false;
            ClearGridCheckboxes(dgvCategories); ClearGridCheckboxes(dgvProducts);

            UpdateThoiGianDisplay(); UpdateDiscountTypeUI(); UpdateConditionControlsState();
            ProductConditionRadioButton_CheckedChanged(null, EventArgs.Empty);
        }
        #endregion

        #region --- DataGridView & ComboBox Setup ---
        private void SetupCategoryDataGridView()
        {
            _bsCategories = _bsCategories ?? new BindingSource(); dgvCategories.DataSource = null; dgvCategories.Columns.Clear(); dgvCategories.AutoGenerateColumns = false; dgvCategories.AllowUserToAddRows = false; dgvCategories.RowHeadersVisible = false;
            dgvCategories.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colCatSelect", HeaderText = "", Width = 40, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, DataPropertyName = "IsSelected", FlatStyle = FlatStyle.Standard });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCatName", HeaderText = "Danh Mục", DataPropertyName = "TenDanhMuc", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            dgvCategories.ColumnHeadersVisible = true; dgvCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold); dgvCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; dgvCategories.Columns["colCatName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCategories.DataSource = _bsCategories;
        }

        private void SetupProductDataGridView()
        {
            _bsProducts = _bsProducts ?? new BindingSource(); dgvProducts.DataSource = null; dgvProducts.Columns.Clear(); dgvProducts.AutoGenerateColumns = false; dgvProducts.AllowUserToAddRows = false; dgvProducts.RowHeadersVisible = false;
            dgvProducts.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colProdSelect", HeaderText = "", Width = 40, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, DataPropertyName = "IsSelected", FlatStyle = FlatStyle.Standard });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProdName", HeaderText = "Sản Phẩm", DataPropertyName = "TenSanPham", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            dgvProducts.ColumnHeadersVisible = true; dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold); dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; dgvProducts.Columns["colProdName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProducts.DataSource = _bsProducts;
        }

        private void SetupFreeProductComboBox()
        {
            Log("Setting up Free Product ComboBox."); if (cmbSanPhamMienPhi != null) { cmbSanPhamMienPhi.DataSource = _bsFreeProducts; cmbSanPhamMienPhi.DisplayMember = "TenSanPham"; cmbSanPhamMienPhi.ValueMember = "IdSanPham"; cmbSanPhamMienPhi.DropDownStyle = ComboBoxStyle.DropDownList; cmbSanPhamMienPhi.SelectedIndex = -1; cmbSanPhamMienPhi.Enabled = false; } else { Log("WARNING: cmbSanPhamMienPhi control not found."); }
        }
        #endregion

        #region --- Event Handlers ---
        private void ProductConditionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool categoriesInteractive = rbApDungDanhMuc.Checked; bool productsInteractive = rbApDungSanPham.Checked; Log($"Product condition changed: Cats Interactive={categoriesInteractive}, Prods Interactive={productsInteractive}"); if (dgvCategories.Columns.Contains("colCatSelect")) { dgvCategories.Columns["colCatSelect"].ReadOnly = !categoriesInteractive; }
            dgvCategories.DefaultCellStyle.BackColor = categoriesInteractive ? Color.White : Color.FromArgb(240, 240, 240); dgvCategories.DefaultCellStyle.ForeColor = categoriesInteractive ? Color.FromArgb(64, 64, 64) : Color.Gray; dgvCategories.AlternatingRowsDefaultCellStyle.BackColor = categoriesInteractive ? Color.White : Color.FromArgb(240, 240, 240); dgvCategories.BackgroundColor = categoriesInteractive ? Color.White : Color.FromArgb(224, 224, 224); dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = categoriesInteractive ? Color.WhiteSmoke : Color.LightGray; if (dgvProducts.Columns.Contains("colProdSelect")) { dgvProducts.Columns["colProdSelect"].ReadOnly = !productsInteractive; }
            dgvProducts.DefaultCellStyle.BackColor = productsInteractive ? Color.White : Color.FromArgb(240, 240, 240); dgvProducts.DefaultCellStyle.ForeColor = productsInteractive ? Color.FromArgb(64, 64, 64) : Color.Gray; dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = productsInteractive ? Color.White : Color.FromArgb(240, 240, 240); dgvProducts.BackgroundColor = productsInteractive ? Color.White : Color.FromArgb(224, 224, 224); dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = productsInteractive ? Color.WhiteSmoke : Color.LightGray; if (!categoriesInteractive) ClearGridCheckboxes(dgvCategories); if (!productsInteractive) ClearGridCheckboxes(dgvProducts); dgvCategories.Refresh(); dgvProducts.Refresh();
        }

        private void DiscountTypeButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button clickedButton && clickedButton.Tag != null) { Log($"Discount type button clicked: {clickedButton.Tag}"); if (clickedButton != btnGiamGiaPercent) btnGiamGiaPercent.Checked = false; if (clickedButton != btnGiamGiaVND) btnGiamGiaVND.Checked = false; if (btnMienPhiSanPham != null && clickedButton != btnMienPhiSanPham) btnMienPhiSanPham.Checked = false; clickedButton.Checked = true; UpdateDiscountTypeUI(); }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            Log("Save button clicked.");
            if (!ValidateInput()) return;

            VoucherEditViewModel viewModel = GatherDataFromForm();
            if (viewModel == null)
            {
                MessageBox.Show("Không thể thu thập dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = false;
            string resultMessage = "";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (_isEditMode)
                {
                    success = _voucherAdminService.UpdateVoucher(viewModel);
                    resultMessage = success ? "Cập nhật thành công!" : "Cập nhật thất bại.";
                }
                else
                {
                    var savedVoucher = _voucherAdminService.AddVoucher(viewModel);
                    success = (savedVoucher != null && savedVoucher.Id > 0);
                    resultMessage = success ? "Thêm mới thành công!" : "Thêm mới thất bại.";
                    if (success)
                    {
                        _currentVoucher = savedVoucher;
                        await HandleSuccessfulVoucherSave(savedVoucher);
                    }
                }

                if (success)
                {
                    MessageBox.Show(resultMessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(true, resultMessage, _currentVoucher));
                }
                else
                {
                    MessageBox.Show(resultMessage, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, resultMessage));
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogError("Save Validation", argEx);
                SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, argEx.Message));
            }
            catch (Exception ex)
            {
                string action = _isEditMode ? "cập nhật" : "thêm mới";
                MessageBox.Show($"Lỗi khi {action}:\n{ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError("Save Voucher", ex);
                SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, $"Lỗi hệ thống: {ex.Message}"));
            }
            finally
            {
                if (!this.IsDisposed && this.IsHandleCreated)
                    this.Cursor = Cursors.Default;
            }
        }

        private async Task HandleSuccessfulVoucherSave(VoucherEditViewModel voucher)
        {
            try
            {
                // Nếu là voucher áp dụng cho thành viên, tự động gửi cho tất cả thành viên
                if (voucher.DoiTuongApDung == "thanh_vien")
                {
                    bool success = _voucherAdminService.AssignVouchersToGroup(new List<int> { voucher.Id }, "all");
                    if (!success)
                    {
                        MessageBox.Show("Đã lưu voucher nhưng không thể gửi cho tất cả thành viên.", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("HandleSuccessfulVoucherSave", ex);
                MessageBox.Show("Đã lưu voucher nhưng gặp lỗi khi gửi cho thành viên.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) { Log("Cancel button clicked."); CancelRequested?.Invoke(this, EventArgs.Empty); }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e) { UpdateThoiGianDisplay(); }
        private void BtnBrowseAnh_Click(object sender, EventArgs e) { Log("Browse image button clicked."); using (OpenFileDialog ofd = new OpenFileDialog()) { ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif"; ofd.Title = "Chọn ảnh cho Voucher"; if (ofd.ShowDialog() == DialogResult.OK) { if (txtAnhVoucherPath != null) txtAnhVoucherPath.Text = ofd.FileName; } } }
        private void ConditionCheckBox_CheckedChanged(object sender, EventArgs e) { UpdateConditionControlsState(); }
        private void BtnDropdownCuaHang_Click(object sender, EventArgs e)
        {
            if (checkedListBoxStores != null)
            {
                // Tính toán vị trí hiển thị dưới fpnlCuaHang
                Point location = fpnlCuaHang.PointToScreen(Point.Empty);
                location = this.PointToClient(location);
                location.Y += fpnlCuaHang.Height;
                checkedListBoxStores.Location = location;

                // Hiện checkedListBox
                checkedListBoxStores.Visible = !checkedListBoxStores.Visible;
                if (checkedListBoxStores.Visible)
                {
                    checkedListBoxStores.BringToFront();
                    checkedListBoxStores.Focus();
                }
            }
        }

        private void HideStoresList()
        {
            if (checkedListBoxStores != null && checkedListBoxStores.Visible)
            {
                checkedListBoxStores.Visible = false;
            }
        }

        private void CheckedListBoxStores_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox clb && clb.Items.Count > e.Index && clb.Items[e.Index] is StoreSelectionViewModel item)
            {
                item.IsSelected = (e.NewValue == CheckState.Checked);
                Log($"Store '{item.TenCuaHang}' IsSelected set to {item.IsSelected}");

                // Use BeginInvoke to update the UI after the check state has changed
                this.BeginInvoke((MethodInvoker)delegate
                {
                    UpdateSelectedStoresDisplay();
                });
            }
        }

        #endregion

        #region --- Input Validation ---
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenChuongTrinh.Text)) { MessageBox.Show("Vui lòng nhập Tên Chương trình.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenChuongTrinh.Focus(); return false; }
            if (btnGiamGiaPercent.Checked || btnGiamGiaVND.Checked) { if (!decimal.TryParse(txtGiaTriGiamGia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal gv) || gv <= 0) { MessageBox.Show("Giá trị voucher không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaTriGiamGia.Focus(); return false; } if (btnGiamGiaPercent.Checked && gv > 100) { MessageBox.Show("Giá trị giảm theo % không được lớn hơn 100.", "Giá trị không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaTriGiamGia.Focus(); return false; } }
            else if (btnMienPhiSanPham != null && btnMienPhiSanPham.Checked) { if (cmbSanPhamMienPhi == null || cmbSanPhamMienPhi.SelectedValue == null || !(cmbSanPhamMienPhi.SelectedValue is int)) { MessageBox.Show("Vui lòng chọn một sản phẩm miễn phí.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); if (cmbSanPhamMienPhi != null) cmbSanPhamMienPhi.Focus(); return false; } }
            else { MessageBox.Show("Vui lòng chọn loại giảm giá.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!string.IsNullOrWhiteSpace(txtSoTienGiamToiDa.Text)) { if (!decimal.TryParse(txtSoTienGiamToiDa.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal gt) || gt < 0) { MessageBox.Show("Số tiền giảm tối đa không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoTienGiamToiDa.Focus(); return false; } }
            if (dtpNgayKetThuc.Checked && dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date) { MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Ngày không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); dtpNgayKetThuc.Focus(); return false; }
            if (chkGiaTriToiThieu.Checked) { if (!decimal.TryParse(txtGiaTriToiThieu.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal minV) || minV <= 0) { MessageBox.Show("Giá trị hoá đơn tối thiểu không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaTriToiThieu.Focus(); return false; } }
            if (ckoApDungCuaHang.Checked) { if (GetSelectedStoreIdsFromPopup().Count == 0) { MessageBox.Show("Vui lòng chọn ít nhất một cửa hàng áp dụng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); btnDropdownCuaHang.Focus(); return false; } }
            return true;
        }

        private int CountSelectedItems(Guna2DataGridView dgv, string checkBoxColumnName)
        { int count = 0; if (dgv == null || !dgv.Columns.Contains(checkBoxColumnName)) return 0; foreach (DataGridViewRow row in dgv.Rows) { if (Convert.ToBoolean(row.Cells[checkBoxColumnName].EditedFormattedValue) == true) { count++; } } return count; }
        #endregion

        #region --- Data Gathering ---
        private VoucherEditViewModel GatherDataFromForm()
        {
            try
            {
                var viewModel = new VoucherEditViewModel();
                if (_isEditMode && _currentVoucher != null)
                {
                    viewModel.Id = _currentVoucher.Id;
                    viewModel.MaVoucher = _currentVoucher.MaVoucher;
                }
                else
                {
                    viewModel.MaVoucher = string.IsNullOrWhiteSpace(txtMaVoucher?.Text) ? null : txtMaVoucher.Text.Trim().ToUpper();
                }

                viewModel.TenVoucher = txtTenChuongTrinh.Text.Trim();
                viewModel.MoTa = txtMoTa.Text.Trim();
                viewModel.GiamGiaToiDa = TryParseNullableDecimal(txtSoTienGiamToiDa.Text);
                viewModel.NgayBatDau = dtpNgayBatDau.Value;

                if (dtpNgayKetThuc.Checked)
                {
                    viewModel.NgayKetThuc = dtpNgayKetThuc.Value.Date.AddDays(1).AddSeconds(-1);
                }
                else { viewModel.NgayKetThuc = new DateTime(9998, 12, 31); }

                if (txtSoLuong != null) viewModel.SoLuongPhatHanh = TryParseNullableInt(txtSoLuong.Text);

                if (btnGioiHanSoLan != null && txtSoLanSuDung != null)
                {
                    if (btnGioiHanSoLan.Checked)
                    {
                        viewModel.SoLuotSuDungToiDaMoiThanhVien = TryParseNullableInt(txtSoLanSuDung.Text);
                    }
                    else { viewModel.SoLuotSuDungToiDaMoiThanhVien = null; }
                }
                viewModel.PhamViApDung = ckoApDungCuaHang.Checked ? "theo_cua_hang" : "toan_chuoi";

                if (viewModel.PhamViApDung == "theo_cua_hang")
                {
                    viewModel.SelectedStoreIds = GetSelectedStoreIdsFromPopup();
                }
                else { viewModel.SelectedStoreIds = new List<int>(); }
                viewModel.TrangThai = "active";

                // Gather Discount Type
                if (btnGiamGiaPercent.Checked) { viewModel.LoaiGiamGia = "percentage"; decimal.TryParse(txtGiaTriGiamGia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var valP); viewModel.GiaTriGiam = valP; viewModel.IdSanPhamMienPhi = null; }
                else if (btnGiamGiaVND.Checked) { viewModel.LoaiGiamGia = "fixed_amount"; decimal.TryParse(txtGiaTriGiamGia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var valV); viewModel.GiaTriGiam = valV; viewModel.IdSanPhamMienPhi = null; }
                else if (btnMienPhiSanPham != null && btnMienPhiSanPham.Checked) { viewModel.LoaiGiamGia = "free_item"; viewModel.GiaTriGiam = 0; viewModel.IdSanPhamMienPhi = (cmbSanPhamMienPhi != null) ? (int?)cmbSanPhamMienPhi.SelectedValue : null; }
                else { viewModel.LoaiGiamGia = "unknown"; }

                // Gather Target Audience
                viewModel.DoiTuongApDung = chkApDungKhachHang.Checked ? "thanh_vien" : "moi_nguoi";

                // Gather Min Order Value
                viewModel.GiaTriDonHangToiThieu = chkGiaTriToiThieu.Checked ? (TryParseNullableDecimal(txtGiaTriToiThieu.Text) ?? 0) : 0;

                // Gather Product/Category Conditions
                viewModel.SelectedCategoryIds = GetSelectedIds<CategorySelectionViewModel, int>(dgvCategories, "colCatSelect", vm => vm.CategoryId);
                viewModel.SelectedProductIds = GetSelectedIds<ProductSelectionViewModel, int>(dgvProducts, "colProdSelect", vm => vm.IdSanPham);
                //List<string> selectedCategoryNames = GetSelectedNames<CategorySelectionViewModel>(dgvCategories, "colCatSelect", vm => vm.TenDanhMuc);
                //List<string> selectedProductNames = GetSelectedNames<ProductSelectionViewModel>(dgvProducts, "colProdSelect", vm => vm.TenSanPham);
                StringBuilder conditionBuilder = new StringBuilder(); bool added = false;
                if ((rbApDungDanhMuc.Checked) && viewModel.SelectedCategoryIds.Any()) { conditionBuilder.Append($"Category: {string.Join(", ", viewModel.SelectedCategoryIds)}"); added = true; }
                if ((rbApDungSanPham.Checked) && viewModel.SelectedProductIds.Any()) { if (added) conditionBuilder.Append("; "); conditionBuilder.Append($"Product: {string.Join(", ", viewModel.SelectedProductIds)}"); }
                MessageBox.Show(conditionBuilder.ToString());
                viewModel.DieuKienSanPham = conditionBuilder.Length > 0 ? conditionBuilder.ToString() : null;
                Log($"Generated DieuKienSanPham: '{viewModel.DieuKienSanPham}'");

                return viewModel;
            }
            catch (Exception ex) { LogError("GatherDataFromForm", ex); return null; }
        }

        private List<TId> GetSelectedIds<TViewModel, TId>(Guna2DataGridView dgv, string checkBoxColName, Func<TViewModel, TId> idSelector) where TViewModel : class, ISelectable
        {
            List<TId> selectedIds = new List<TId>(); bool canSelect = (dgv == dgvCategories && (rbApDungDanhMuc.Checked)) || (dgv == dgvProducts && (rbApDungSanPham.Checked)); if (canSelect && dgv != null && dgv.Columns.Contains(checkBoxColName)) { try { if (dgv.DataSource is BindingSource bs && bs.DataSource is IEnumerable<TViewModel> sourceList) { selectedIds.AddRange(sourceList.Where(vm => vm.IsSelected).Select(idSelector)); } } catch (Exception ex) { LogError($"GetSelectedIds for {dgv.Name}", ex); } }
            Log($"Gathered selected IDs for {dgv.Name}: {selectedIds.Count}"); return selectedIds;
        }

        //private List<string> GetSelectedNames<TViewModel>(Guna2DataGridView dgv, string checkBoxColName, Func<TViewModel, string> nameSelector) where TViewModel : class, ISelectable
        //{
        //    List<string> selectedNames = new List<string>(); bool canSelect = (dgv == dgvCategories && (rbApDungDanhMuc.Checked || rbApDungCaHai.Checked)) || (dgv == dgvProducts && (rbApDungSanPham.Checked || rbApDungCaHai.Checked)); if (canSelect && dgv != null && dgv.Columns.Contains(checkBoxColName)) { try { if (dgv.DataSource is BindingSource bs && bs.DataSource is IEnumerable<TViewModel> sourceList) { selectedNames.AddRange(sourceList.Where(vm => vm.IsSelected).Select(nameSelector)); } } catch (Exception ex) { LogError($"GetSelectedNames for {dgv.Name}", ex); } }
        //    Log($"Gathered selected Names for {dgv.Name}: {selectedNames.Count}"); return selectedNames;
        //}

        private List<int> GetSelectedStoreIdsFromPopup()
        {
            List<int> selectedIds = new List<int>();

            if (checkedListBoxStores?.DataSource is BindingSource bs && bs.DataSource is List<StoreSelectionViewModel> storeList)
            {
                selectedIds.AddRange(storeList.Where(svm => svm.IsSelected).Select(svm => svm.Id));
            }

            Log($"Gathered selected Store IDs from popup: {selectedIds.Count}");
            return selectedIds;
        }
        #endregion

        #region --- Parsing Helpers ---
        private int? TryParseNullableInt(string value) { if (int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out int result)) return result; return null; }
        private decimal? TryParseNullableDecimal(string value) { if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result)) return result; return null; }
        #endregion

        #region --- UI Update & Helper Methods ---
        private void UpdateThoiGianDisplay()
        {
            Guna2TextBox txtDisplay = this.Controls.OfType<Guna2TextBox>().FirstOrDefault(c => c.Name == "txtDisplayThoiGian"); if (txtDisplay == null) return; try { DateTime start = dtpNgayBatDau.Value; string startStr = $"Áp dụng từ: {start:dd/MM/yyyy HH:mm:ss}"; string endStr = "Không thời hạn"; txtDisplay.ForeColor = Color.FromArgb(94, 148, 255); if (dtpNgayKetThuc.Checked) { DateTime end = dtpNgayKetThuc.Value; if (end.Date < start.Date) { endStr = "Ngày kết thúc KHÔNG HỢP LỆ!"; txtDisplay.ForeColor = Color.Red; } else { DateTime endOfDay = end.Date.AddDays(1).AddSeconds(-1); endStr = $"Đến hết ngày: {endOfDay:dd/MM/yyyy HH:mm:ss}"; } } txtDisplay.Text = $"{startStr}   |   {endStr}"; } catch (Exception ex) { LogError("UpdateThoiGianDisplay", ex); txtDisplay.Text = "Lỗi hiển thị thời gian"; txtDisplay.ForeColor = Color.Red; }
        }

        private void ClearGridCheckboxes(Guna2DataGridView dgv)
        {
            if (dgv == null || dgv.Rows.Count == 0 || dgv.Columns.Count < 1) return; string checkBoxColName = dgv.Columns[0].Name; if (dgv.Columns.Contains(checkBoxColName) && dgv.Columns[checkBoxColName] is DataGridViewCheckBoxColumn) { Log($"Clearing checkboxes in {dgv.Name}"); bool changed = false; if (dgv.DataSource is BindingSource bs && bs.DataSource is System.Collections.IList sourceList) { for (int i = 0; i < sourceList.Count; i++) { if (sourceList[i] is ISelectable item && item.IsSelected) { item.IsSelected = false; if (i < dgv.Rows.Count && !dgv.Rows[i].IsNewRow) dgv.Rows[i].Cells[checkBoxColName].Value = false; changed = true; } } if (changed) bs.ResetBindings(false); } else { foreach (DataGridViewRow row in dgv.Rows) { if (Convert.ToBoolean(row.Cells[checkBoxColName].EditedFormattedValue) == true) { row.Cells[checkBoxColName].Value = false; changed = true; } } } if (changed) dgv.Refresh(); }
        }

        private void UpdateDiscountTypeUI()
        {
            Guna2ComboBox cmbFreeProd = this.Controls.OfType<Guna2ComboBox>().FirstOrDefault(c => c.Name == "cmbSanPhamMienPhi"); bool isFreeItem = (btnMienPhiSanPham != null && btnMienPhiSanPham.Checked); bool isValueDiscount = btnGiamGiaPercent.Checked || btnGiamGiaVND.Checked; txtGiaTriGiamGia.Enabled = isValueDiscount; lblSoTienGiamToiDa.Enabled = btnGiamGiaPercent.Checked; txtSoTienGiamToiDa.Enabled = lblSoTienGiamToiDa.Enabled; if (cmbFreeProd != null) cmbFreeProd.Enabled = isFreeItem; if (!isValueDiscount) txtGiaTriGiamGia.Clear(); if (!lblSoTienGiamToiDa.Enabled) txtSoTienGiamToiDa.Clear(); if (!isFreeItem && cmbFreeProd != null && cmbFreeProd.Items.Count > 0) { cmbFreeProd.SelectedIndex = 0; }
            lblGiaTriGiamGia.Text = isFreeItem ? "Sản phẩm miễn phí *" : "Giá trị giảm giá *"; txtGiaTriGiamGia.PlaceholderText = btnGiamGiaPercent.Checked ? "Nhập %" : (btnGiamGiaVND.Checked ? "Nhập số tiền VND" : "");
        }

        private void UpdateConditionControlsState()
        {
            txtGiaTriToiThieu.Enabled = chkGiaTriToiThieu.Checked; if (!chkGiaTriToiThieu.Checked) txtGiaTriToiThieu.Clear();
            UpdateStoreSelectionUI(ckoApDungCuaHang.Checked);
        }

        private void UpdateSelectedStoresDisplay()
        {
            fpnlCuaHang.Controls.Clear();

            if (ckoApDungCuaHang.Checked && _allActiveStores != null && checkedListBoxStores?.DataSource is BindingSource bs && bs.DataSource is List<StoreSelectionViewModel> storeList)
            {
                // Only show selected stores
                foreach (var store in storeList.Where(s => s.IsSelected))
                {
                    var label = CreateStoreLabel(store.TenCuaHang);
                    fpnlCuaHang.Controls.Add(label);
                }
            }
        }

        private Label CreateStoreLabel(string storeName)
        {
            var label = new Label
            {
                Text = storeName,
                AutoSize = true,
                Margin = new Padding(3),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackColor = Color.FromArgb(94, 148, 255),
                ForeColor = Color.White,
                Padding = new Padding(8, 4, 8, 4)
            };

            return label;
        }

        private void UpdateStoreSelectionUI(bool enabled)
        {
            fpnlCuaHang.Enabled = enabled; btnDropdownCuaHang.Enabled = enabled; fpnlCuaHang.BackColor = enabled ? Color.White : SystemColors.Control; if (!enabled) { ClearStoreSelectionPopup(); UpdateSelectedStoresDisplay(); } else { UpdateSelectedStoresDisplay(); }
        }

        private void ClearStoreSelectionPopup()
        {
            if (checkedListBoxStores?.DataSource is BindingSource bs && bs.DataSource is List<StoreSelectionViewModel> storeList)
            {
                foreach (var store in storeList)
                {
                    store.IsSelected = false;
                }
                bs.ResetBindings(false);
            }
        }

        private void ParseDieuKienSanPhamAndSetControls(string dieuKienSanPhamString)
        {
            Log($"Parsing DieuKienSanPhamString: '{dieuKienSanPhamString}'"); List<string> categoryNamesToSelect = new List<string>(); List<string> productNamesToSelect = new List<string>(); bool applyToCats = false; bool applyToProds = false; ClearGridCheckboxes(dgvCategories); ClearGridCheckboxes(dgvProducts); if (!string.IsNullOrWhiteSpace(dieuKienSanPhamString)) { string[] parts = dieuKienSanPhamString.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries); foreach (string part in parts) { string trimmedPart = part.Trim(); Match catMatch = Regex.Match(trimmedPart, @"^Category:\s*(.+)$", RegexOptions.IgnoreCase); if (catMatch.Success) { applyToCats = true; string namesString = catMatch.Groups[1].Value.Trim(); categoryNamesToSelect.AddRange(namesString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(name => name.Trim()).Where(name => !string.IsNullOrEmpty(name))); continue; } Match prodMatch = Regex.Match(trimmedPart, @"^Product:\s*(.+)$", RegexOptions.IgnoreCase); if (prodMatch.Success) { applyToProds = true; string namesString = prodMatch.Groups[1].Value.Trim(); productNamesToSelect.AddRange(namesString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(name => name.Trim()).Where(name => !string.IsNullOrEmpty(name))); } } }
            if (applyToCats) { rbApDungDanhMuc.Checked = true; } else if (applyToProds) { rbApDungSanPham.Checked = true; } else { rbApDungDanhMuc.Checked = false; rbApDungSanPham.Checked = false; }
            CheckSelectedItemsByName<CategorySelectionViewModel>(dgvCategories, categoryNamesToSelect, vm => vm.TenDanhMuc); CheckSelectedItemsByName<ProductSelectionViewModel>(dgvProducts, productNamesToSelect, vm => vm.TenSanPham);
        }

        private void CheckSelectedItemsByName<TViewModel>(Guna2DataGridView dgv, List<string> namesToSelect, Func<TViewModel, string> nameSelector) where TViewModel : class, ISelectable
        {
            if (namesToSelect == null || dgv?.DataSource == null) return; Log($"Checking items by name in {dgv.Name}. Count: {namesToSelect.Count}"); bool changed = false; if (dgv.DataSource is BindingSource bs && bs.List is IList<TViewModel> itemList) { var nameSet = new HashSet<string>(namesToSelect, StringComparer.OrdinalIgnoreCase); foreach (TViewModel item in itemList) { bool shouldBeSelected = nameSet.Contains(nameSelector(item)); if (item.IsSelected != shouldBeSelected) { item.IsSelected = shouldBeSelected; changed = true; } } if (changed) bs.ResetBindings(false); } else { LogError($"CheckSelectedItemsByName failed for {dgv.Name}", null); }
            if (changed) dgv.Refresh();
        }

        private void CheckSelectedStores(List<int> storeIds)
        {
            Log($"Checking selected stores in popup. Count: {storeIds?.Count ?? 0}"); if (storeIds == null) { ClearStoreSelectionPopup(); UpdateSelectedStoresDisplay(); return; }
            if (checkedListBoxStores?.DataSource is BindingSource bs && bs.DataSource is List<StoreSelectionViewModel> storeList)
            {
                var idSet = new HashSet<int>(storeIds);
                foreach (var store in storeList)
                {
                    store.IsSelected = idSet.Contains(store.Id);
                }
                bs.ResetBindings(false);
                UpdateSelectedStoresDisplay();
            }
        }

        #endregion

        #region --- Logging ---
        private void Log(string message) { Debug.WriteLine($"[FormAddVoucherStore] {DateTime.Now:HH:mm:ss.fff} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormAddVoucherStore ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }
        #endregion

    } // End Class
} // End Namespace