using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DoAnDemo.Utils; // Assuming this namespace exists

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormEditVoucher : UserControl
    {
        #region --- Fields & Properties ---
        private readonly IVoucherAdminService _voucherService;
        private readonly ICuaHangService _cuaHangService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        // The voucher currently being edited
        private VoucherEditViewModel _currentVoucher;

        // Master lists loaded once
        private List<StoreViewModel> _allStores = new List<StoreViewModel>();
        private List<CategoryViewModel> _allCategories = new List<CategoryViewModel>();
        private List<ProductViewModel> _allProducts = new List<ProductViewModel>();

        // Stores the checked state of stores based on their ID, persistent across filtering
        private Dictionary<int, bool> _storeCheckedStates = new Dictionary<int, bool>();

        // Flags to prevent re-entry issues during async operations
        private bool _isInitializing = false;
        private bool _isPopulating = false;

        // Events for communication with the parent form/control
        public event EventHandler<SaveCompleteEventArgs> SaveComplete;
        public event EventHandler CancelRequested;
        #endregion

        #region --- Constructor & Setup ---
        public FormEditVoucher()
        {
            InitializeComponent(); // Standard WinForms initialization

            // Instantiate required services
            _voucherService = new VoucherAdminService();
            _cuaHangService = new CuaHangService();
            _categoryService = new CategoryService();
            _productService = new ProductService();

            // Attach event handlers for controls
            SetupEventHandlers();

            // Set initial state (e.g., disable save button)
            ValidateForm();

            // Defer loading master data until the control is loaded
            this.Load += FormEditVoucher_Load;
        }

        // Event handler called when the UserControl is loaded
        private async void FormEditVoucher_Load(object sender, EventArgs e)
        {
            // Load master lists (all categories, products, stores) first
            await InitializeDataAsync();

            // If a voucher was assigned *before* InitializeDataAsync completed,
            // ensure its specific data is fetched and populated now.
            if (_currentVoucher != null && !_isPopulating)
            {
                await FetchAndPopulateVoucherData();
            }
        }

        // Loads the master lists of all Categories, Products, and Stores (role-based)
        private async Task InitializeDataAsync()
        {
            if (_isInitializing) return; // Prevent re-entry
            _isInitializing = true;
            this.Cursor = Cursors.WaitCursor;
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] InitializeDataAsync: Starting Master Data Load");

            try
            {
                // Clear any previous master data
                _allCategories.Clear();
                _allProducts.Clear();
                _allStores.Clear();

                // Load Categories Master List
                _allCategories = await Task.Run(() => _categoryService.GetAllCategories()) ?? new List<CategoryViewModel>();
                PopulateCategoryGrid(); // Populates dgvDanhMuc with _allCategories
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] InitializeDataAsync: Loaded {_allCategories.Count} categories.");

                // Load Products Master List
                // Assuming loading all products initially is desired. Filter if needed.
                _allProducts = await Task.Run(() => _productService.GetAvailableProductsByStore(CurrentUserContext.User.DefaultStoreId)) ?? new List<ProductViewModel>();
                PopulateProductGrid();       // Populates dgvSanPham with _allProducts
                PopulateFreeProductComboBox(); // Uses _allProducts for the free item dropdown
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] InitializeDataAsync: Loaded {_allProducts.Count} products.");

                // Load Stores Master List based on User Role
                _allStores = await LoadStoresBasedOnRoleAsync() ?? new List<StoreViewModel>();
                PopulateStoreChecklist(_allStores); // Populates chkListCuaHang with _allStores
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] InitializeDataAsync: Loaded {_allStores.Count} stores based on role.");
            }
            catch (Exception ex)
            {
                LogError("InitializeDataAsync (Master Data Load)", ex);
                MessageBox.Show($"Lỗi nghiêm trọng khi tải dữ liệu khởi tạo. Vui lòng thử lại.\nChi tiết: {ex.Message}",
                                "Lỗi Tải Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure cursor returns to default even if errors occur
                if (!this.IsDisposed && this.IsHandleCreated)
                    this.Cursor = Cursors.Default;
                _isInitializing = false;
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] InitializeDataAsync: Finished Master Data Load");
            }
        }

        // Entry point for loading a specific voucher for editing (called externally)
        public async void LoadVoucherForEdit(VoucherEditViewModel voucher)
        {
            if (voucher == null)
            {
                LogError("LoadVoucherForEdit", new ArgumentNullException(nameof(voucher), "Voucher object provided was null."));
                MessageBox.Show("Không thể tải voucher không hợp lệ (null).", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CancelRequested?.Invoke(this, EventArgs.Empty); // Notify parent to cancel/close
                return;
            }

            // Prevent processing if already populating or if the same voucher is re-loaded quickly
            if (_isPopulating || _currentVoucher?.Id == voucher.Id)
            {
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] LoadVoucherForEdit: Skipped - Already processing or same voucher ID ({voucher.Id}).");
                return;
            }

            // Assign the new voucher
            _currentVoucher = voucher;

            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] LoadVoucherForEdit: Received voucher ID: {_currentVoucher.Id}. Condition: '{_currentVoucher.DieuKienSanPham}'");

            // Ensure master data is loaded before proceeding
            // This loop waits if InitializeDataAsync is still running
            while (_isInitializing)
            {
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] LoadVoucherForEdit: Waiting for InitializeDataAsync to complete...");
                await Task.Delay(100); // Small delay to avoid busy-waiting
            }

            // Now fetch the specific items associated with this voucher and update the UI
            await FetchAndPopulateVoucherData();
        }

        // Coordinates fetching voucher-specific items and then populating the form controls
        private async Task FetchAndPopulateVoucherData()
        {
            // Ensure there's a voucher and we're not already in the process
            if (_currentVoucher == null || _isPopulating) return;

            _isPopulating = true; // Set flag to indicate population process started
            this.Cursor = Cursors.WaitCursor; // Show wait cursor
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchAndPopulateVoucherData: Starting data fetch for Voucher ID: {_currentVoucher.Id}");

            try
            {
                // Step 1: Fetch IDs of stores/categories/products associated ONLY with this specific voucher
                await FetchVoucherSpecificItemsAsync();

                // Step 2: Populate the form controls using the updated _currentVoucher object
                // (which now includes the correctly populated Selected...Ids lists)
                PopulateFormWithVoucherData();

                // Step 3: Re-validate the form based on the populated data
                ValidateForm();
            }
            catch (Exception ex)
            {
                // Log any errors during the fetch/populate process
                LogError("FetchAndPopulateVoucherData", ex);
                MessageBox.Show($"Lỗi khi tải và hiển thị chi tiết voucher ID {_currentVoucher.Id}.\nChi tiết: {ex.Message}",
                                "Lỗi Hiển thị Voucher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset cursor and flag when done
                if (!this.IsDisposed && this.IsHandleCreated)
                    this.Cursor = Cursors.Default;
                _isPopulating = false;
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchAndPopulateVoucherData: Finished for Voucher ID: {_currentVoucher.Id}");
            }
        }

        // Fetches specific Store/Category/Product IDs associated with _currentVoucher
        // Uses the 'condition' string approach for Categories/Products as requested.
        private async Task FetchVoucherSpecificItemsAsync()
        {
            if (_currentVoucher == null)
            {
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: Skipped - _currentVoucher is null.");
                return;
            }

            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: Fetching items for Voucher ID: {_currentVoucher.Id}");
            try
            {
                int voucherId = _currentVoucher.Id;
                string condition = _currentVoucher.DieuKienSanPham; // Get the condition string from the voucher

                // --- Fetch Associated Stores (Uses Voucher ID) ---
                // Assumes GetVoucherStore correctly takes the voucher ID
                var stores = await Task.Run(() => _cuaHangService.GetVoucherStore(voucherId));
                _currentVoucher.SelectedStoreIds = stores?.Select(s => s.Id).ToList() ?? new List<int>();
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: Fetched {_currentVoucher.SelectedStoreIds.Count} store IDs using Voucher ID.");

                // --- Fetch Associated Categories/Products (Uses Condition String) ---
                // Initialize/clear lists before fetching
                _currentVoucher.SelectedCategoryIds = new List<int>();
                _currentVoucher.SelectedProductIds = new List<int>();

                if (!string.IsNullOrEmpty(condition))
                {
                    // Use OrdinalIgnoreCase for robust, case-insensitive comparison
                    bool isCategoryCondition = condition.Contains("Category");

                    if (isCategoryCondition)
                    {
                        // Fetch Categories using the condition string
                        Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: Condition '{condition}' is Category type. Calling GetCategoriesByCondition...");
                        var categories = await Task.Run(() => _categoryService.GetCategoriesByCondition(condition));
                        // Populate the Category ID list
                        _currentVoucher.SelectedCategoryIds = categories?.Select(c => c.CategoryId).ToList() ?? new List<int>();
                        Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: Fetched {_currentVoucher.SelectedCategoryIds.Count} category IDs using condition '{condition}'.");
                    }
                    else // Assume Product condition if not Category and not null/empty
                    {
                        // Fetch Products using the condition string
                        Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: Condition '{condition}' is Product type. Calling GetVoucherProductByConditon...");
                        // Ensure 'GetVoucherProductByConditon' is the correct method name in your service
                        var products = await Task.Run(() => _productService.GetVoucherProductByConditon(condition));
                        // Populate the Product ID list

                        _currentVoucher.SelectedProductIds = products?.Select(p => p.Id).ToList() ?? new List<int>();
                        Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: Fetched {_currentVoucher.SelectedProductIds.Count} product IDs using condition '{condition}'.");
                    }
                }
                else
                {
                    // Log if no condition is set for categories/products
                    Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] FetchVoucherSpecificItemsAsync: No specific category/product condition found (DieuKienSanPham is null or empty).");
                }
            }
            catch (Exception ex)
            {
                LogError("FetchVoucherSpecificItemsAsync", ex);
                // Reset lists on error to prevent potential issues with partial data
                _currentVoucher.SelectedStoreIds = new List<int>();
                _currentVoucher.SelectedCategoryIds = new List<int>();
                _currentVoucher.SelectedProductIds = new List<int>();
                MessageBox.Show($"Lỗi khi tải danh sách cửa hàng/danh mục/sản phẩm liên kết với voucher.\nChi tiết: {ex.Message}",
                                "Lỗi Tải Dữ liệu Liên kết", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region --- Data Loading & Population (Master Lists UI) ---

        // Loads stores based on the current user's role (Admin, Area Manager, Store Manager)
        private async Task<List<StoreViewModel>> LoadStoresBasedOnRoleAsync()
        {
            List<StoreViewModel> stores = new List<StoreViewModel>();
            try
            {
                // Check user roles using CurrentUserContext (ensure this context is properly set up)
                if (CurrentUserContext.IsAdmin)
                {
                    // Admins get all stores
                    stores = await Task.Run(() => _cuaHangService.GetAllStores());
                }
                else if (CurrentUserContext.IsAreaManager)
                {
                    // Area Managers get stores in their region
                    var userStoreId = CurrentUserContext.User?.DefaultStoreId; // Assuming User object has DefaultStoreId
                    if (userStoreId.HasValue)
                    {
                        // Get region based on the manager's default store
                        var region = await Task.Run(() => _cuaHangService.GetRegionByStoreId(userStoreId.Value));
                        // Get active stores in that region
                        stores = await Task.Run(() => _cuaHangService.GetActiveStoresByRegion(region));
                    }
                    else
                    {
                        // Handle case where Area Manager might not have a default store assigned
                        LogError("LoadStoresBasedOnRoleAsync", new Exception("Area Manager user does not have a DefaultStoreId assigned."));
                    }
                }
                else if (CurrentUserContext.IsStoreManager)
                {
                    // Store Managers only get their own store
                    var userStoreId = CurrentUserContext.User?.DefaultStoreId;
                    if (userStoreId.HasValue)
                    {
                        var store = await Task.Run(() => _cuaHangService.GetStoreById(userStoreId.Value));
                        if (store != null)
                        {
                            stores.Add(store);
                        }
                        else
                        {
                            LogError("LoadStoresBasedOnRoleAsync", new Exception($"Store Manager's assigned store ID {userStoreId.Value} not found."));
                        }
                    }
                    else
                    {
                        LogError("LoadStoresBasedOnRoleAsync", new Exception("Store Manager user does not have a DefaultStoreId assigned."));
                    }
                }
                else
                {
                    // Handle other roles or default case if necessary
                    // Maybe log a warning or load no stores?
                    Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] LoadStoresBasedOnRoleAsync: User role not recognized or handled. Loading empty store list.");
                }
            }
            catch (Exception ex)
            {
                LogError("LoadStoresBasedOnRoleAsync", ex);
                MessageBox.Show($"Lỗi khi tải danh sách cửa hàng theo quyền người dùng.\nChi tiết: {ex.Message}",
                                "Lỗi Tải Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Return empty list on error
                stores = new List<StoreViewModel>();
            }
            // Ensure a non-null list is always returned
            return stores ?? new List<StoreViewModel>();
        }

        // Populates the Store CheckedListBox control with a list of stores (master or filtered)
        // Uses the _storeCheckedStates dictionary to determine the checked status.
        private void PopulateStoreChecklist(IEnumerable<StoreViewModel> storesToDisplay)
        {
            // Unsubscribe from the event temporarily to prevent it firing during population
            chkListCuaHang.ItemCheck -= ChkListCuaHang_ItemCheck;

            chkListCuaHang.Items.Clear(); // Clear existing items
            chkListCuaHang.DisplayMember = "TenCuaHang"; // Property to display in the list
            chkListCuaHang.ValueMember = "Id";         // Property to use as the value (though we store the object)

            // Add each store to the list
            if (storesToDisplay != null)
            {
                foreach (var store in storesToDisplay)
                {
                    // Determine if this store should be checked based on the persistent dictionary
                    bool isChecked = _storeCheckedStates.ContainsKey(store.Id) && _storeCheckedStates[store.Id];
                    // Add the StoreViewModel object itself, along with its checked state
                    chkListCuaHang.Items.Add(store, isChecked);
                }
            }

            // Apply styling to the checklist and search box
            chkListCuaHang.ItemHeight = 20;
            chkListCuaHang.BackColor = Color.White;
            chkListCuaHang.Font = new Font("Segoe UI", 9F);
            chkListCuaHang.BorderStyle = BorderStyle.None;

            txtTimKiemCuaHang.BorderRadius = 8;
            txtTimKiemCuaHang.FillColor = Color.FromArgb(240, 240, 240);
            txtTimKiemCuaHang.Font = new Font("Segoe UI", 9F);
            txtTimKiemCuaHang.PlaceholderText = "🔍 Tìm kiếm cửa hàng...";

            // Re-subscribe to the event now that population is complete
            chkListCuaHang.ItemCheck += ChkListCuaHang_ItemCheck;
        }

        // Populates the Category DataGridView with the master list (_allCategories)
        private void PopulateCategoryGrid()
        {
            // Create a DataTable structure matching the grid columns
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));          // Hidden ID column
            table.Columns.Add("IsSelected", typeof(bool)); // Checkbox column
            table.Columns.Add("TenDanhMuc", typeof(string)); // Display name

            // Add each category from the master list to the DataTable
            if (_allCategories != null)
            {
                foreach (var category in _allCategories)
                {
                    // Add row: CategoryId, default check state (false), Category Name
                    table.Rows.Add(category.CategoryId, false, category.TenDanhMuc);
                }
            }

            // Set the DataTable as the data source for the grid
            dgvDanhMuc.DataSource = table;

            // Configure column appearance and behavior
            ConfigureDataGridView(dgvDanhMuc, "TenDanhMuc", "Tên danh mục");
        }

        // Populates the Product DataGridView with the master list (_allProducts)
        private void PopulateProductGrid()
        {
            // Create a DataTable structure matching the grid columns
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));         // Hidden ID column
            table.Columns.Add("IsSelected", typeof(bool)); // Checkbox column
            table.Columns.Add("TenSanPham", typeof(string)); // Display name

            // Add each product from the master list to the DataTable
            if (_allProducts != null)
            {
                foreach (var product in _allProducts)
                {
                    // Add row: ProductId, default check state (false), Product Name
                    table.Rows.Add(product.Id, false, product.TenSanPham);
                }
            }

            // Set the DataTable as the data source for the grid
            dgvSanPham.DataSource = table;

            // Configure column appearance and behavior
            ConfigureDataGridView(dgvSanPham, "TenSanPham", "Tên sản phẩm");
        }

        // Helper method to configure common DataGridView properties
        private void ConfigureDataGridView(DataGridView dgv, string displayNameColumn, string headerText)
        {
            // Hide the ID column
            dgv.Columns["Id"].Visible = false;

            // Configure the Checkbox column
            dgv.Columns["IsSelected"].HeaderText = ""; // No header text
            dgv.Columns["IsSelected"].Width = 40;      // Fixed small width
            dgv.Columns["IsSelected"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Configure the Display Name column
            dgv.Columns[displayNameColumn].HeaderText = headerText; // Set header text
            dgv.Columns[displayNameColumn].ReadOnly = true;         // Make it read-only
            dgv.Columns[displayNameColumn].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Fill remaining space

            // General grid properties
            dgv.AllowUserToAddRows = false;     // Don't allow adding new rows
            dgv.RowHeadersVisible = false;    // Hide the row header column
            dgv.BackgroundColor = Color.White;  // Set background color
            dgv.BorderStyle = BorderStyle.Fixed3D; // Set border style
        }

        // Populates the ComboBox used for selecting a free item voucher type
        private void PopulateFreeProductComboBox()
        {
            // Get necessary data from the master product list
            object dataSource = null; // Initialize DataSource variable to null

            // Check if the master product list is available and has items
            if (_allProducts != null && _allProducts.Any())
            {
                // If yes, create the list of anonymous objects for the ComboBox
                dataSource = _allProducts
                    .Select(p => new { p.Id, p.TenSanPham }) // Select only ID and Name
                    .OrderBy(p => p.TenSanPham)             // Optional: Sort alphabetically
                    .ToList();                              // Create the list
            }
            // If _allProducts is null or empty, dataSource remains null

            // Assign the result (either the populated list or null) to the DataSource
            cmbSanPhamMienPhi.DataSource = dataSource;

            // Set DisplayMember and ValueMember - these work even if DataSource is null initially
            cmbSanPhamMienPhi.DisplayMember = "TenSanPham";
            cmbSanPhamMienPhi.ValueMember = "Id";

            // Ensure initial state is correct
            cmbSanPhamMienPhi.SelectedIndex = -1; // Nothing selected
            cmbSanPhamMienPhi.Enabled = false;   // Disabled by default
        }

        // Populates all form controls based on the state of the _currentVoucher object.
        // Assumes _currentVoucher is assigned and its Selected...Ids lists are populated.
        private void PopulateFormWithVoucherData()
        {
            if (_currentVoucher == null)
            {
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] PopulateFormWithVoucherData: Aborted, _currentVoucher is null.");
                return; // Cannot populate if voucher is null
            }
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] PopulateFormWithVoucherData: Populating form for Voucher ID: {_currentVoucher.Id}");

            try
            {
                // --- Basic Voucher Information ---
                txtMaVoucher.Text = _currentVoucher.MaVoucher;
                txtTenVoucher.Text = _currentVoucher.TenVoucher;
                txtMoTa.Text = _currentVoucher.MoTa;
                // Format quantity with thousands separator if SoLuongPhatHanh exists
                txtSoLuong.Text = _currentVoucher.SoLuongPhatHanh?.ToString("N0") ?? "0";

                // --- Discount Type & Associated Values ---
                // Set the correct radio button based on LoaiGiamGia
                rdoPercent.Checked = _currentVoucher.LoaiGiamGia == "percentage";
                rdoAmount.Checked = _currentVoucher.LoaiGiamGia == "fixed_amount";
                radSanPhamMienPhi.Checked = _currentVoucher.LoaiGiamGia == "free_item";

                // Populate value textboxes, formatting as currency (N0 = no decimals)
                txtGiaTriGiam.Text = _currentVoucher.GiaTriGiam.ToString("N0");
                txtGiamToiDa.Text = _currentVoucher.GiamGiaToiDa?.ToString("N0") ?? ""; // Handle nullable
                txtGiaTriToiThieu.Text = _currentVoucher.GiaTriDonHangToiThieu.ToString("N0") ?? ""; // Handle nullable

                // Set selected free product if applicable
                if (radSanPhamMienPhi.Checked && _currentVoucher.IdSanPhamMienPhi.HasValue)
                {
                    // Safely set SelectedValue, checking if the ID exists in the ComboBox list
                    cmbSanPhamMienPhi.SelectedValue = _currentVoucher.IdSanPhamMienPhi.Value;
                    // Verify if the selection was successful (SelectedValue might remain null if ID not found)
                    if (cmbSanPhamMienPhi.SelectedValue == null || Convert.ToInt32(cmbSanPhamMienPhi.SelectedValue) != _currentVoucher.IdSanPhamMienPhi.Value)
                    {
                        cmbSanPhamMienPhi.SelectedIndex = -1; // Reset if ID wasn't found
                        LogError("PopulateFormWithVoucherData", new Exception($"Free product ID {_currentVoucher.IdSanPhamMienPhi.Value} from voucher data not found in ComboBox items."));
                    }
                }
                else
                {
                    // No free product selected or applicable
                    cmbSanPhamMienPhi.SelectedIndex = -1;
                }
                // Update enabled state of controls based on the discount type just set
                HandleDiscountTypeChange(null, EventArgs.Empty);

                // --- Date Range ---
                // Use safe defaults if voucher dates are outside the picker's range
                DateTime minDate = dtpNgayBatDau.MinDate;
                DateTime maxDate = dtpNgayBatDau.MaxDate; // Assume pickers share the same min/max
                // Set Start Date
                dtpNgayBatDau.Value = (_currentVoucher.NgayBatDau >= minDate && _currentVoucher.NgayBatDau <= maxDate)
                                      ? _currentVoucher.NgayBatDau
                                      : DateTime.Now; // Use current date as default if out of range
                // Set End Date / Indefinite
                chkVoThoiHan.Checked = (_currentVoucher.NgayKetThuc.Year >= DateTime.MaxValue.Year - 1); // Safer check for MaxValue
                if (chkVoThoiHan.Checked)
                {
                    // If indefinite, set to picker's max date and disable it
                    dtpNgayKetThuc.Value = maxDate;
                    dtpNgayKetThuc.Enabled = false;
                }
                else
                {
                    // If specific end date, set it (with range check) and enable picker
                    dtpNgayKetThuc.Value = (_currentVoucher.NgayKetThuc >= minDate && _currentVoucher.NgayKetThuc <= maxDate)
                                           ? _currentVoucher.NgayKetThuc
                                           : DateTime.Now.AddMonths(1); // Default to 1 month ahead if out of range
                    dtpNgayKetThuc.Enabled = true;
                }

                // --- Scope & Store Selection ---
                // Set scope radio buttons
                radToanChuoi.Checked = _currentVoucher.PhamViApDung == "toan_chuoi";
                radTheoCuaHang.Checked = _currentVoucher.PhamViApDung == "theo_cua_hang";

                // Update the persistent checked state dictionary based on fetched store IDs
                _storeCheckedStates.Clear(); // Clear any previous state
                if (_currentVoucher.SelectedStoreIds != null)
                {
                    foreach (int storeId in _currentVoucher.SelectedStoreIds)
                    {
                        _storeCheckedStates[storeId] = true; // Mark associated stores as checked
                    }
                }
                // Refresh the checklist UI to reflect the _storeCheckedStates and current filter
                FilterStoreChecklist(txtTimKiemCuaHang.Text.Trim());
                // Update enabled state of checklist/search box based on scope
                HandleScopeChange(null, EventArgs.Empty);

                // --- Applicable Audience ---
                // Set the 'Member Only' checkbox
                ckoMember.Checked = _currentVoucher.DoiTuongApDung == "thanh_vien"; // Adjust "member" string if needed

                // --- Conditions & Product/Category Selection ---
                string condition = _currentVoucher.DieuKienSanPham;
                // Set condition checkboxes based on the condition string *and* whether items were actually fetched/selected
                chkApDungDanhMuc.Checked = (!string.IsNullOrEmpty(condition)
                                           && condition.Contains("Category")
                                           && _currentVoucher.SelectedCategoryIds?.Any() == true);
                chkApDungSanPham.Checked = (!string.IsNullOrEmpty(condition)
                                           && !condition.Contains("Category")
                                           && _currentVoucher.SelectedProductIds?.Any() == true);
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] PopulateFormWithVoucherData: Setting chkApDungDanhMuc = {chkApDungDanhMuc.Checked} (Condition: '{condition}', Categories Selected: {_currentVoucher.SelectedCategoryIds?.Count ?? 0})");
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] PopulateFormWithVoucherData: Setting chkApDungSanPham = {chkApDungSanPham.Checked} (Condition: '{condition}', Products Selected: {_currentVoucher.SelectedProductIds?.Count ?? 0})");

                // Check the rows in the DataGridViews corresponding to the fetched IDs
                //SetDataGridViewCheckboxState(dgvDanhMuc, "Id", _currentVoucher.SelectedCategoryIds ?? new List<int>());
                SetDataGridViewCheckboxState(dgvSanPham, "Id", _currentVoucher.SelectedProductIds ?? new List<int>());
                // Update enabled state of the grids based on the condition checkboxes
                HandleConditionChange(null, EventArgs.Empty);

                // --- Voucher Status ---
                // Set the Active checkbox
                chkActive.Checked = _currentVoucher.TrangThai == "active";

                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] PopulateFormWithVoucherData: Form population complete for Voucher ID: {_currentVoucher.Id}");
            }
            catch (Exception ex)
            {
                LogError("PopulateFormWithVoucherData", ex);
                MessageBox.Show($"Lỗi không mong muốn khi hiển thị dữ liệu voucher.\nChi tiết: {ex.Message}",
                                "Lỗi Hiển thị", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sets the 'IsSelected' checkbox state in a DataGridView based on a provided list of IDs.
        // Assumes the DataGridView is populated and has columns named "Id" and "IsSelected".
        private void SetDataGridViewCheckboxState(DataGridView dgv, string idColumnName, List<int> selectedIds)
        {
            if (dgv.DataSource == null || selectedIds == null)
            {
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] SetDataGridViewCheckboxState [{dgv.Name}]: Aborted, DataSource or selectedIds list is null.");
                return; // Cannot proceed without data source or IDs
            }
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] SetDataGridViewCheckboxState [{dgv.Name}]: Setting states for {selectedIds.Count} IDs: [{string.Join(",", selectedIds)}]");

            bool stateChanged = false; // Flag to track if any changes were made
            // Optimize by accessing underlying DataTable if possible
            if (dgv.DataSource is DataTable dt)
            {
                // Iterate through DataRows for potentially better performance
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        if (row[idColumnName] != DBNull.Value && int.TryParse(row[idColumnName].ToString(), out int rowId))
                        {
                            // Determine if this row's ID is in the list of IDs to be selected
                            bool shouldBeSelected = selectedIds.Contains(rowId);
                            // Only update if the current state is different

                            if (Convert.ToBoolean(row["IsSelected"]) != shouldBeSelected)
                            {
                                row["IsSelected"] = shouldBeSelected; // Update the data source value
                                stateChanged = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log errors during row processing but continue if possible
                        LogError($"SetDataGridViewCheckboxState - Row Iteration (DataTable) for ID {row[idColumnName]} in {dgv.Name}", ex);
                    }
                }
            }
            else // Fallback to iterating DataGridViewRows if not bound to a DataTable
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the 'new row' placeholder if present
                    try
                    {
                        if (row.Cells[idColumnName].Value != null && int.TryParse(row.Cells[idColumnName].Value.ToString(), out int rowId))
                        {
                            // Determine if this row should be selected
                            bool shouldBeSelected = selectedIds.Contains(rowId);
                            // Only update the cell value if it's different
                            if (Convert.ToBoolean(row.Cells["IsSelected"].Value) != shouldBeSelected)
                            {
                                row.Cells["IsSelected"].Value = shouldBeSelected; // Update the cell value
                                stateChanged = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LogError($"SetDataGridViewCheckboxState - Row Iteration (DGV Rows) for ID {row.Cells[idColumnName].Value} in {dgv.Name}", ex);
                    }
                }
            }
            // If the grid doesn't update visually automatically, uncomment one of these:
            // if (stateChanged) dgv.Refresh();
            // if (stateChanged) dgv.Invalidate();

            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] SetDataGridViewCheckboxState [{dgv.Name}]: Finished setting states. Changes made: {stateChanged}");
        }

        #endregion

        #region --- Event Handlers ---
        // Centralized setup for all control event handlers
        private void SetupEventHandlers()
        {
            // Text Input Formatting & Validation Triggers
            txtGiaTriGiam.TextChanged += CurrencyTextChangedHandler;     // Format as currency
            txtGiamToiDa.TextChanged += CurrencyTextChangedHandler;       // Format as currency
            txtGiaTriToiThieu.TextChanged += CurrencyTextChangedHandler; // Format as currency
            txtSoLuong.TextChanged += NumericTextChangedHandler;          // Format as number only
            txtTenVoucher.TextChanged += (s, e) => ValidateForm();       // Validate on change

            // Discount Type Radio Buttons
            rdoPercent.CheckedChanged += HandleDiscountTypeChange;
            rdoAmount.CheckedChanged += HandleDiscountTypeChange;
            radSanPhamMienPhi.CheckedChanged += HandleDiscountTypeChange;

            // Scope Radio Buttons
            radToanChuoi.CheckedChanged += HandleScopeChange;
            radTheoCuaHang.CheckedChanged += HandleScopeChange;

            // Member Checkbox
            ckoMember.CheckedChanged += (s, e) => ValidateForm(); // Re-validate if audience changes

            // Date Pickers
            dtpNgayBatDau.ValueChanged += (s, e) => ValidateForm();
            dtpNgayKetThuc.ValueChanged += (s, e) => ValidateForm();

            // Indefinite Expiry Checkbox
            chkVoThoiHan.CheckedChanged += (s, e) =>
            {
                dtpNgayKetThuc.Enabled = !chkVoThoiHan.Checked; // Enable/disable end date picker
                if (chkVoThoiHan.Checked)
                {
                    dtpNgayKetThuc.Value = dtpNgayKetThuc.MaxDate; // Set to max if indefinite
                }
                else
                {
                    // Set to a sensible default when unchecked (e.g., 1 month after start date)
                    // Ensure the default doesn't exceed MaxDate
                    DateTime defaultEndDate = dtpNgayBatDau.Value.AddMonths(1);
                    dtpNgayKetThuc.Value = (defaultEndDate <= dtpNgayKetThuc.MaxDate)
                                          ? defaultEndDate
                                          : dtpNgayKetThuc.MaxDate;
                }
                ValidateForm(); // Re-validate after date change
            };

            // Condition Checkboxes (Apply to Category/Product)
            chkApDungDanhMuc.CheckedChanged += HandleConditionChange;
            chkApDungSanPham.CheckedChanged += HandleConditionChange;

            // Store Search Textbox
            txtTimKiemCuaHang.TextChanged += (s, e) =>
            {
                // Filter the store checklist in real-time as user types
                FilterStoreChecklist(txtTimKiemCuaHang.Text.Trim());
            };

            // Store Checklist Item Check/Uncheck
            chkListCuaHang.ItemCheck += ChkListCuaHang_ItemCheck;

            // DataGridView Checkbox Interaction (using MouseUp and KeyDown)
            dgvDanhMuc.CellMouseUp += Dgv_CellMouseUp; // Clicking checkbox cell
            dgvSanPham.CellMouseUp += Dgv_CellMouseUp;
            dgvDanhMuc.KeyDown += Dgv_KeyDown;         // Using Space key on checkbox cell
            dgvSanPham.KeyDown += Dgv_KeyDown;

            // Save and Cancel Buttons
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty); // Raise event for parent
        }

        // Handles changes to the Discount Type radio buttons
        private void HandleDiscountTypeChange(object sender, EventArgs e)
        {
            // Determine which radio button is checked
            bool isPercent = rdoPercent.Checked;
            bool isAmount = rdoAmount.Checked;
            bool isFreeItem = radSanPhamMienPhi.Checked;

            // Enable/disable controls based on the selected type
            txtGiaTriGiam.Enabled = isPercent; // Value field needed for % and fixed amount
            txtGiamToiDa.Enabled = isAmount;              // Max discount only relevant for %
            cmbSanPhamMienPhi.Enabled = isFreeItem;        // Free item combo only relevant for free item type

            // Clear values in controls that are no longer relevant
            if (!isPercent && txtGiamToiDa.Text.Length > 0)
            {
                txtGiamToiDa.Clear(); // Clear max discount if not percentage
            }
            if (!isFreeItem && cmbSanPhamMienPhi.SelectedIndex != -1)
            {
                cmbSanPhamMienPhi.SelectedIndex = -1; // Clear free item selection if not free item type
            }
            if (isFreeItem && txtGiaTriGiam.Text != "0")
            {
                txtGiaTriGiam.Text = "0"; // Set value to 0 (or clear?) if free item type
                                          // Also clear max discount if switching to free item
                if (txtGiamToiDa.Text.Length > 0) txtGiamToiDa.Clear();
            }
            else if (!isPercent && !isAmount && txtGiaTriGiam.Text.Length > 0)
            {
                // Clear value if no discount type selected (shouldn't happen with radios?)
                // txtGiaTriGiam.Clear();
            }


            ValidateForm(); // Re-validate after changing enabled states/values
        }

        // Handles changes to the Scope radio buttons (All Stores / Specific Stores)
        private void HandleScopeChange(object sender, EventArgs e)
        {
            // Determine if 'Specific Stores' (Theo Cửa Hàng) is selected
            bool isStoreSpecific = radTheoCuaHang.Checked;

            // Enable/disable the checklist and search box accordingly
            chkListCuaHang.Enabled = isStoreSpecific;
            txtTimKiemCuaHang.Enabled = isStoreSpecific;

            // Note: We don't clear the checked state (_storeCheckedStates) here when switching
            // back to 'All Stores'. The state is preserved in case the user switches back.
            // The GetSelectedStoreIds() method used during Save correctly checks the scope.

            ValidateForm(); // Re-validate (e.g., check if stores are selected when scope requires it)
        }

        // Handles changes to the Condition checkboxes (Apply to Category / Apply to Product)
        private void HandleConditionChange(object sender, EventArgs e)
        {
            // Enable/disable the corresponding DataGridViews
            dgvDanhMuc.Enabled = chkApDungDanhMuc.Checked;
            dgvSanPham.Enabled = chkApDungSanPham.Checked;

            // Optional: Prevent both Category and Product from being checked simultaneously.
            // If this is desired, uncomment and adjust this logic. Radio buttons might be better.
            // if (sender == chkApDungDanhMuc && chkApDungDanhMuc.Checked && chkApDungSanPham.Checked)
            // {
            //     chkApDungSanPham.CheckedChanged -= HandleConditionChange; // Prevent recursion
            //     chkApDungSanPham.Checked = false;
            //     chkApDungSanPham.CheckedChanged += HandleConditionChange;
            // }
            // else if (sender == chkApDungSanPham && chkApDungSanPham.Checked && chkApDungDanhMuc.Checked)
            // {
            //     chkApDungDanhMuc.CheckedChanged -= HandleConditionChange;
            //     chkApDungDanhMuc.Checked = false;
            //     chkApDungDanhMuc.CheckedChanged += HandleConditionChange;
            // }

            ValidateForm(); // Re-validate (e.g., check if items are selected when condition requires it)
        }

        // Handles the ItemCheck event for the Store CheckedListBox
        private void ChkListCuaHang_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Ensure the index is valid
            if (e.Index >= 0 && e.Index < chkListCuaHang.Items.Count)
            {
                // Get the StoreViewModel object associated with the item being checked/unchecked
                var store = chkListCuaHang.Items[e.Index] as StoreViewModel;
                if (store != null)
                {
                    // Update the persistent state dictionary using the store's ID and the *new* check state
                    _storeCheckedStates[store.Id] = (e.NewValue == CheckState.Checked);
                    Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] ChkListCuaHang_ItemCheck: Store ID {store.Id} check state set to {_storeCheckedStates[store.Id]}");

                    // Use BeginInvoke to ensure validation happens after the UI reflects the change
                    this.BeginInvoke((MethodInvoker)delegate { ValidateForm(); });
                }
                else
                {
                    // Log an error if the item is not a StoreViewModel (shouldn't happen)
                    LogError("ChkListCuaHang_ItemCheck", new InvalidCastException($"Item at index {e.Index} in chkListCuaHang is not a valid StoreViewModel object."));
                }
            }
        }

        // Handles MouseUp event on DataGridView cells, specifically for clicking the checkbox column
        private void Dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgv = sender as DataGridView;
            // Check if the click was on a valid row and within the 'IsSelected' checkbox column
            if (dgv == null || e.RowIndex < 0 || e.ColumnIndex != dgv.Columns["IsSelected"].Index)
                return;

            // Commit the edit immediately. The DataGridView handles toggling the value
            // when the checkbox part of the cell is clicked. EndEdit ensures the underlying source updates.
            dgv.EndEdit();

            // Use BeginInvoke to trigger validation after the UI update cycle completes
            this.BeginInvoke((MethodInvoker)delegate { ValidateForm(); });
        }

        // Handles KeyDown event on DataGridViews, specifically for using the Space key on the checkbox column
        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            var dgv = sender as DataGridView;
            // Check if Space key was pressed and the current cell is the 'IsSelected' checkbox column
            if (dgv == null || e.KeyCode != Keys.Space || dgv.CurrentCell == null || dgv.CurrentCell.RowIndex < 0 || dgv.CurrentCell.ColumnIndex != dgv.Columns["IsSelected"].Index)
                return;

            // Get the current boolean value and toggle it
            bool currentValue = Convert.ToBoolean(dgv.CurrentCell.Value);
            dgv.CurrentCell.Value = !currentValue;
            dgv.EndEdit(); // Commit the change to the data source

            e.Handled = true; // Prevent the Space key from performing other actions (like scrolling)

            // Use BeginInvoke to trigger validation after the UI update cycle completes
            this.BeginInvoke((MethodInvoker)delegate { ValidateForm(); });
        }

        // Handles the Save button click event
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            // First, validate the form data
            if (!ValidateForm())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập liệu. Các trường có lỗi đã được đánh dấu.",
                                "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop saving if validation fails
            }

            bool success = false;
            string resultMessage = "";
            this.Cursor = Cursors.WaitCursor; // Indicate processing
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] BtnSave_Click: Attempting to save Voucher ID: {_currentVoucher?.Id}");

            try
            {
                // Step 1: Update the _currentVoucher object with the latest data from form controls
                UpdateVoucherFromForm();

                // Safety check - should not be null if validation passed, but good practice
                if (_currentVoucher == null)
                {
                    throw new InvalidOperationException("Không thể lưu vì đối tượng voucher hiện tại không hợp lệ (null).");
                }

                // Debug output of data being sent to service
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] BtnSave_Click: Calling _voucherService.UpdateVoucher for ID: {_currentVoucher.Id}");
                Debug.WriteLine($" - Name: {_currentVoucher.TenVoucher}");
                Debug.WriteLine($" - Scope: {_currentVoucher.PhamViApDung}");
                Debug.WriteLine($" - Condition: {_currentVoucher.DieuKienSanPham}");
                Debug.WriteLine($" - Stores: {string.Join(",", _currentVoucher.SelectedStoreIds ?? new List<int>())}");
                Debug.WriteLine($" - Categories: {string.Join(",", _currentVoucher.SelectedCategoryIds ?? new List<int>())}");
                Debug.WriteLine($" - Products: {string.Join(",", _currentVoucher.SelectedProductIds ?? new List<int>())}");
                Debug.WriteLine($" - Status: {_currentVoucher.TrangThai}");


                // Step 2: Call the service method to save the voucher data
                // Run the potentially long-running database operation on a background thread
                success = await Task.Run(() => _voucherService.UpdateVoucher(_currentVoucher));

                // Step 3: Handle the result
                resultMessage = success ? "Cập nhật voucher thành công!" : "Cập nhật voucher thất bại.";
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] BtnSave_Click: UpdateVoucher BLL result: {success}");

                if (success)
                {
                    // Optional: Perform any post-save actions if needed
                    // await HandleSuccessfulVoucherUpdate(_currentVoucher);

                    MessageBox.Show(resultMessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Notify parent form/control about successful save, passing back the saved voucher
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(true, resultMessage, _currentVoucher));
                }
                else
                {
                    // Show failure message
                    MessageBox.Show(resultMessage, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Notify parent form/control about failed save
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, resultMessage));
                }
            }
            catch (ArgumentException argEx) // Catch specific validation errors from BLL/UpdateVoucherFromForm
            {
                LogError("Save Validation/BLL Error", argEx);
                MessageBox.Show($"Lỗi dữ liệu khi lưu:\n{argEx.Message}", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, argEx.Message)); // Notify failure
            }
            catch (Exception ex) // Catch unexpected errors
            {
                LogError("BtnSave_Click General Error", ex);
                resultMessage = $"Lỗi hệ thống không mong muốn khi cập nhật voucher.\nChi tiết: {ex.Message}";
                MessageBox.Show(resultMessage, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false, resultMessage)); // Notify failure
            }
            finally
            {
                // Ensure cursor returns to default
                if (!this.IsDisposed && this.IsHandleCreated)
                    this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region --- Data Update & Validation ---

        // Reads current values from UI controls and updates the _currentVoucher object
        private void UpdateVoucherFromForm()
        {
            // Ensure the voucher object exists
            if (_currentVoucher == null)
            {
                LogError("UpdateVoucherFromForm", new InvalidOperationException("_currentVoucher object is null during update attempt. Cannot proceed."));
                throw new InvalidOperationException("Không có đối tượng voucher nào được tải để cập nhật.");
            }
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] UpdateVoucherFromForm: Reading UI state into _currentVoucher object (ID: {_currentVoucher.Id})");

            // Basic Info
            _currentVoucher.TenVoucher = txtTenVoucher.Text.Trim();
            _currentVoucher.MoTa = txtMoTa.Text.Trim();

            // --- Corrected SoLuongPhatHanh Parsing ---
            // Try parsing directly as int. Handle nullable int? property.
            if (int.TryParse(txtSoLuong.Text.Replace(",", ""), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out int slIntValue))
            {
                _currentVoucher.SoLuongPhatHanh = slIntValue; // Assign the parsed int value
            }
            else
            {
                // If parsing fails (e.g., empty or invalid text), set to null
                // (Assuming _currentVoucher.SoLuongPhatHanh is int?)
                _currentVoucher.SoLuongPhatHanh = null;
                // If it was non-nullable int, you'd set it to 0 or throw validation error
                // _currentVoucher.SoLuongPhatHanh = 0;
            }
            // --- End Corrected SoLuongPhatHanh Parsing ---


            // Discount Type
            if (rdoPercent.Checked) _currentVoucher.LoaiGiamGia = "percentage";
            else if (rdoAmount.Checked) _currentVoucher.LoaiGiamGia = "fixed_amount";
            else if (radSanPhamMienPhi.Checked) _currentVoucher.LoaiGiamGia = "free_item";
            else _currentVoucher.LoaiGiamGia = null; // Or handle default case

            // Discount Values
            // Assuming GiaTriGiam is decimal (non-nullable)
            _currentVoucher.GiaTriGiam = TryParseDecimal(txtGiaTriGiam.Text) ?? 0M; // Use ?? 0M for non-nullable decimal

            // Assuming GiamGiaToiDa is decimal? (nullable) - Assignment is OK
            _currentVoucher.GiamGiaToiDa = TryParseDecimal(txtGiamToiDa.Text);

            // Assuming GiaTriDonHangToiThieu is decimal? (nullable) - Assignment is OK
            _currentVoucher.GiaTriDonHangToiThieu = TryParseDecimal(txtGiaTriToiThieu.Text) ?? 0M;

            // Free Product ID
            if (radSanPhamMienPhi.Checked && cmbSanPhamMienPhi.SelectedValue is int idSP)
            {
                _currentVoucher.IdSanPhamMienPhi = idSP;
            }
            else
            {
                _currentVoucher.IdSanPhamMienPhi = null;
            }

            // Dates
            _currentVoucher.NgayBatDau = dtpNgayBatDau.Value;
            _currentVoucher.NgayKetThuc = chkVoThoiHan.Checked ? DateTime.MaxValue.Date : dtpNgayKetThuc.Value; // Use MaxValue.Date

            // Scope & Stores
            _currentVoucher.PhamViApDung = radToanChuoi.Checked ? "toan_chuoi" : "theo_cua_hang";
            if (_currentVoucher.PhamViApDung == "theo_cua_hang")
            {
                // Get selected store IDs based on the *current* state of the checklist (_storeCheckedStates)
                _currentVoucher.SelectedStoreIds = GetSelectedStoreIds();
                Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] UpdateVoucherFromForm: Reading {GetSelectedStoreIds().Count} selected store IDs from UI state (_storeCheckedStates).");
            }
            else
            {
                // If scope is all stores, ensure the list is empty or null
                _currentVoucher.SelectedStoreIds = new List<int>();
            }

            // Audience
            _currentVoucher.DoiTuongApDung = ckoMember.Checked ? "thanh_vien" : "moi_nguoi"; // Adjust "member"/"all" as needed

            // Conditions & Products/Categories
            // Get selected IDs based on the *current* checked state of the DataGridViews
            _currentVoucher.SelectedCategoryIds = GetSelectedIdsFromDataGridView(dgvDanhMuc, "Id");
            _currentVoucher.SelectedProductIds = GetSelectedIdsFromDataGridView(dgvSanPham, "Id");
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] UpdateVoucherFromForm: Reading {_currentVoucher.SelectedCategoryIds.Count} selected category IDs from UI (dgvDanhMuc).");
            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] UpdateVoucherFromForm: Reading {_currentVoucher.SelectedProductIds.Count} selected product IDs from UI (dgvSanPham).");

            // Determine the DieuKienSanPham string based on which checkbox is checked *AND* has items selected
            _currentVoucher.DieuKienSanPham = null; // Default to no condition
            if (chkApDungDanhMuc.Checked && _currentVoucher.SelectedCategoryIds.Any())
            {
                // If category checkbox is checked AND categories are selected, set condition
                _currentVoucher.DieuKienSanPham = "Category: " + string.Join(",", _currentVoucher.SelectedCategoryIds); // Or "Category..." depending on expected value
                // Clear product list if category condition is chosen (cannot have both)
                _currentVoucher.SelectedProductIds = new List<int>();
            }
            else if (chkApDungSanPham.Checked && _currentVoucher.SelectedProductIds.Any())
            {
                // If product checkbox is checked AND products are selected, set condition
                _currentVoucher.DieuKienSanPham = "Product: " + string.Join(",", _currentVoucher.SelectedProductIds); // Or the expected condition string
                // Clear category list if product condition is chosen
                _currentVoucher.SelectedCategoryIds = new List<int>();
            }
            // If neither is checked, or checked but list is empty, DieuKienSanPham remains null.

            // Status
            _currentVoucher.TrangThai = chkActive.Checked ? "active" : "inactive"; // Or other status values

            Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] UpdateVoucherFromForm: Finished updating _currentVoucher object. Final Condition: '{_currentVoucher.DieuKienSanPham}'");
        }

        // Validates the entire form, sets error providers, and returns true if valid
        private bool ValidateForm()
        {
            bool isValid = true;
            errorProvider.Clear(); // Clear all previous errors

            // --- Required Fields ---
            // Voucher Name
            if (string.IsNullOrWhiteSpace(txtTenVoucher.Text))
            {
                errorProvider.SetError(txtTenVoucher, "Tên voucher không được để trống.");
                isValid = false;
            }

            // --- Discount Type Specific Validation ---
            decimal? giaTriGiam = TryParseDecimal(txtGiaTriGiam.Text);
            if (rdoPercent.Checked)
            {
                // Percentage Value (0-100]
                if (!giaTriGiam.HasValue || giaTriGiam.Value <= 0 || giaTriGiam.Value > 100)
                {
                    errorProvider.SetError(txtGiaTriGiam, "Giá trị phần trăm phải lớn hơn 0 và nhỏ hơn hoặc bằng 100.");
                    isValid = false;
                }
                // Max Discount (Optional, but must be > 0 if entered)
                decimal? giamToiDa = TryParseDecimal(txtGiamToiDa.Text);
                if (giamToiDa.HasValue && giamToiDa.Value <= 0)
                {
                    errorProvider.SetError(txtGiamToiDa, "Giảm giá tối đa phải lớn hơn 0.");
                    isValid = false;
                }
            }
            else if (rdoAmount.Checked)
            {
                // Fixed Amount Value (> 0)
                if (!giaTriGiam.HasValue || giaTriGiam.Value <= 0)
                {
                    errorProvider.SetError(txtGiaTriGiam, "Giá trị giảm phải lớn hơn 0.");
                    isValid = false;
                }
            }
            else if (radSanPhamMienPhi.Checked)
            {
                // Free Item Selection
                if (cmbSanPhamMienPhi.SelectedIndex == -1)
                {
                    errorProvider.SetError(cmbSanPhamMienPhi, "Vui lòng chọn một sản phẩm miễn phí.");
                    isValid = false;
                }
            }
            else
            {
                // Should not happen with RadioButtons in a group, but as a fallback:
                errorProvider.SetError(rdoPercent, "Vui lòng chọn loại giảm giá."); // Set error on one of the radios
                isValid = false;
            }

            // --- Other Numeric Fields ---
            // Minimum Order Value (Optional, but >= 0 if entered)
            decimal? giaTriToiThieu = TryParseDecimal(txtGiaTriToiThieu.Text);
            if (giaTriToiThieu.HasValue && giaTriToiThieu.Value < 0)
            {
                errorProvider.SetError(txtGiaTriToiThieu, "Giá trị đơn hàng tối thiểu không được âm.");
                isValid = false;
            }
            // Quantity (Optional, but >= 0 if entered)
            if (!string.IsNullOrWhiteSpace(txtSoLuong.Text)) // Only validate if not empty
            {
                // Try parsing as int, disallow non-integer or negative
                if (!int.TryParse(txtSoLuong.Text.Replace(",", ""), out int sl) || sl < 0)
                {
                    errorProvider.SetError(txtSoLuong, "Số lượng phát hành không hợp lệ (phải là số nguyên không âm).");
                    isValid = false;
                }
            }

            // --- Date Validation ---
            // End date must be on or after start date (if not indefinite)
            if (!chkVoThoiHan.Checked && dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date)
            {
                errorProvider.SetError(dtpNgayKetThuc, "Ngày kết thúc phải bằng hoặc sau ngày bắt đầu.");
                isValid = false;
            }
            // Optional: Check if start date is in the past for *new* vouchers if needed
            // if (_currentVoucher.Id == 0 && dtpNgayBatDau.Value.Date < DateTime.Today) { ... }

            // --- Scope & Selection Validation ---
            // Store Selection (if scope is 'Specific Stores')
            if (radTheoCuaHang.Checked && GetSelectedStoreIds().Count == 0)
            {
                errorProvider.SetError(chkListCuaHang, "Vui lòng chọn ít nhất một cửa hàng khi áp dụng theo cửa hàng.");
                isValid = false;
            }
            // Category Selection (if condition is 'Category')
            if (chkApDungDanhMuc.Checked && GetSelectedIdsFromDataGridView(dgvDanhMuc, "Id").Count == 0)
            {
                errorProvider.SetError(dgvDanhMuc, "Vui lòng chọn ít nhất một danh mục khi áp dụng theo danh mục.");
                isValid = false;
            }
            // Product Selection (if condition is 'Product')
            if (chkApDungSanPham.Checked && GetSelectedIdsFromDataGridView(dgvSanPham, "Id").Count == 0)
            {
                errorProvider.SetError(dgvSanPham, "Vui lòng chọn ít nhất một sản phẩm khi áp dụng theo sản phẩm.");
                isValid = false;
            }
            // Prevent selecting BOTH Category and Product conditions if that's invalid
            if (chkApDungDanhMuc.Checked && chkApDungSanPham.Checked)
            {
                // Set error on both checkboxes
                errorProvider.SetError(chkApDungDanhMuc, "Không thể áp dụng đồng thời theo Danh mục và Sản phẩm.");
                errorProvider.SetError(chkApDungSanPham, "Không thể áp dụng đồng thời theo Danh mục và Sản phẩm.");
                isValid = false;
            }

            // --- Final Step: Enable/Disable Save Button ---
            btnSave.Enabled = isValid;
            return isValid;
        }

        #endregion

        #region --- Helpers ---
        // Filters the store checklist based on the search term
        private void FilterStoreChecklist(string searchTerm)
        {
            // Determine the source list (all stores loaded based on role)
            var sourceStores = _allStores ?? new List<StoreViewModel>();

            // Filter the source list based on the search term (case-insensitive)
            var filteredStores = string.IsNullOrWhiteSpace(searchTerm)
                ? sourceStores // Show all if search is empty
                : sourceStores.Where(s => s.TenCuaHang != null &&
                                          s.TenCuaHang.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);

            // Repopulate the checklist UI with the filtered list.
            // PopulateStoreChecklist uses _storeCheckedStates to set the checkmarks correctly.
            PopulateStoreChecklist(filteredStores);
        }

        // Gets the list of Store IDs that are currently checked, reading from the persistent state dictionary
        private List<int> GetSelectedStoreIds()
        {
            // Filters the dictionary for entries where the value (checked state) is true,
            // and selects the key (Store ID).
            return _storeCheckedStates.Where(kv => kv.Value).Select(kv => kv.Key).ToList();
        }

        // Gets the list of IDs for rows where the 'IsSelected' checkbox is currently checked in a DataGridView
        private List<int> GetSelectedIdsFromDataGridView(DataGridView dgv, string idColumnName)
        {
            var selectedIds = new List<int>();
            // Check if the grid has a data source
            if (dgv.DataSource == null) return selectedIds; // Return empty list if no data

            // Iterate through all rows in the grid
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Skip the 'new row' placeholder if it exists
                if (row.IsNewRow) continue;

                // Get the checkbox cell for the current row
                var checkBoxCell = row.Cells["IsSelected"] as DataGridViewCheckBoxCell;
                // Check if the checkbox cell exists and its value is true (checked)
                bool isSelected = checkBoxCell?.Value != null && Convert.ToBoolean(checkBoxCell.Value);

                if (isSelected)
                {
                    // If checked, try to get the ID from the specified ID column
                    if (row.Cells[idColumnName].Value != null && int.TryParse(row.Cells[idColumnName].Value.ToString(), out int id))
                    {
                        // Add the valid ID to the list
                        selectedIds.Add(id);
                    }
                    else
                    {
                        // Log an error if ID parsing fails for a selected row
                        LogError("GetSelectedIdsFromDataGridView", new FormatException($"Could not parse ID from selected row in {dgv.Name}. Row Index: {row.Index}, Value: '{row.Cells[idColumnName].Value}'"));
                    }
                }
            }
            // Debug.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] GetSelectedIdsFromDataGridView [{dgv.Name}]: Found {selectedIds.Count} selected IDs in UI.");
            return selectedIds;
        }

        // Safely parses a string to a decimal, handling potential formatting issues and returning null if invalid.
        private decimal? TryParseDecimal(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null; // Return null for empty input

            // Prepare the input for parsing: remove commas, use invariant decimal separator (.)
            // Use CultureInfo.InvariantCulture for reliable parsing regardless of system locale
            string cleanInput = input.Replace(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator, "")
                                     .Replace(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator,
                                              System.Globalization.CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);


            // Try parsing using InvariantCulture to avoid locale-specific issues
            if (decimal.TryParse(cleanInput,
                                System.Globalization.NumberStyles.Any, // Allow various styles (like negative signs)
                                System.Globalization.CultureInfo.InvariantCulture, // Use invariant culture for parsing
                                out decimal result))
            {
                return result; // Return the parsed value
            }
            return null; // Return null if parsing fails
        }

        // Formats the text in a Guna2TextBox to display as currency (N0 format - thousands separators, no decimals)
        private void FormatCurrencyInput(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Check for null textbox or empty text
            if (textBox == null || string.IsNullOrWhiteSpace(textBox.Text)) return;

            // Remove handler to prevent recursive calls during text update
            textBox.TextChanged -= CurrencyTextChangedHandler;

            // Store cursor position to restore it later
            int selectionStart = textBox.SelectionStart;
            int originalLength = textBox.Text.Length;

            // Try parsing the cleaned text using TryParseDecimal helper
            decimal? value = TryParseDecimal(textBox.Text);

            if (value.HasValue)
            {
                // Format the parsed value using "N0" and CurrentCulture for display
                textBox.Text = value.Value.ToString("N0", System.Globalization.CultureInfo.CurrentCulture);

                // Restore cursor position intelligently
                int newLength = textBox.Text.Length;
                textBox.SelectionStart = Math.Max(0, selectionStart + (newLength - originalLength));
            }
            else
            {
                // If not parseable but not empty, maybe clear it or just maintain cursor
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    // Option: Clear invalid input?
                    // textBox.Clear();
                    // Option: Just maintain cursor
                    textBox.SelectionStart = Math.Max(0, selectionStart);
                }
            }


            // Re-attach the handler
            textBox.TextChanged += CurrencyTextChangedHandler;
        }
        // Named handler required for removing/re-adding
        private void CurrencyTextChangedHandler(object sender, EventArgs e)
        {
            FormatCurrencyInput(sender as Guna.UI2.WinForms.Guna2TextBox);
            ValidateForm(); // Validate after formatting
        }

        // Formats the text in a Guna2TextBox to contain only digits (for quantity, etc.)
        private void FormatNumericInput(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            if (textBox == null) return; // Check for null textbox

            // Remove handler to prevent recursion
            textBox.TextChanged -= NumericTextChangedHandler;

            // Store cursor position
            int selectionStart = textBox.SelectionStart;
            int originalLength = textBox.Text.Length;

            // Keep only digit characters
            string cleanValue = new string((textBox.Text ?? "").Where(char.IsDigit).ToArray());

            // Only update the text if it actually changed to avoid unnecessary updates/flicker
            if (textBox.Text != cleanValue)
            {
                textBox.Text = cleanValue;
                // Restore cursor position
                int newLength = textBox.Text.Length;
                textBox.SelectionStart = Math.Max(0, selectionStart + (newLength - originalLength));
            }
            else
            {
                // If text didn't change (e.g., user typed non-digit), just restore cursor
                textBox.SelectionStart = Math.Max(0, selectionStart);
            }

            // Re-attach the handler
            textBox.TextChanged += NumericTextChangedHandler;
        }
        // Named handler required for removing/re-adding
        private void NumericTextChangedHandler(object sender, EventArgs e)
        {
            FormatNumericInput(sender as Guna.UI2.WinForms.Guna2TextBox);
            ValidateForm(); // Validate after formatting
        }


        // Basic error logging helper method (outputs to Debug console)
        private void LogError(string context, Exception ex)
        {
            // Log timestamp, context, exception type, message, and stack trace
            string logMessage = $"[ERROR][{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}][FormEditVoucher] Context: {context} | Type: {ex.GetType().Name} | Message: {ex.Message}\nStackTrace: {ex.StackTrace}";
            Debug.WriteLine(logMessage);
            // Optionally write to a file or other logging system here
            // System.IO.File.AppendAllText("error_log.txt", logMessage + Environment.NewLine);

            // Recursively log inner exceptions if they exist
            if (ex.InnerException != null)
            {
                Debug.WriteLine($"--- Inner Exception ({context}) ---");
                LogError($"{context} (Inner)", ex.InnerException);
            }
        }

        #endregion
    }
}