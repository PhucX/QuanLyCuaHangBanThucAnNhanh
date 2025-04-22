using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using DoAnDemo.Utils;
using System.Linq;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormNhanVien : UserControl
    {
        private readonly INhanVienService _nhanVienService;
        private readonly ICuaHangService _cuaHangService;
        private BindingSource _bindingSourceNhanVien;

        // Thông tin người dùng hiện tại (lưu khi load)
        private string _currentUserRole;
        private int _currentUserStoreId;
        private string _currentUserRegion; // Khu vực của QLKV

        public event EventHandler AddEmployeeRequested;
        public event EventHandler<NhanVienViewModel> EditEmployeeRequested;

        public FormNhanVien()
        {
            InitializeComponent();
            try 
            {
                _nhanVienService = new NhanVienService(); 
                _cuaHangService = new CuaHangService();
            }
            catch (Exception ex) 
            { 
                LogError("Service Init", ex);
                this.Enabled = false; 
                return;
            }
            _bindingSourceNhanVien = new BindingSource();
            SetupDataGridView();
            this.Load += FormNhanVien_Load; // Gọi sự kiện Load để cấu hình UI và tải dữ liệu
            AssignEventHandlers();
        }

        /// <summary>
        /// Phương thức công khai để tải lại dữ liệu và cấu hình lại UI theo quyền.
        /// Sẽ được gọi từ Form cha khi UserControl này được hiển thị.
        /// </summary>
        public void RefreshUIAndData()
        {
            Log("RefreshUIAndData called.");
            ConfigureUIBasedOnRole(); // Cấu hình lại UI trước khi load data
        }

        /// <summary>
        /// Cấu hình các cột cho DataGridView Nhân viên một cách programmatic.
        /// </summary>
        private void SetupDataGridView()
        {
            // *** Sử dụng tên đúng dgvNhanVien (YÊU CẦU ĐỔI TÊN TRONG DESIGNER) ***
            var dgv = dgvNhanVien;

            dgv.DataSource = null; // Xóa DataSource cũ nếu có từ Designer
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false; // Tắt tự tạo cột

            // Thêm các cột cần thiết
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMaNV", HeaderText = "Mã NV", DataPropertyName = "MaNV", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTenNV", HeaderText = "Tên Nhân Viên", DataPropertyName = "TenNV", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSDT", HeaderText = "Số Điện Thoại", DataPropertyName = "SDT", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTaiKhoan", HeaderText = "Tài Khoản", DataPropertyName = "TaiKhoan", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colChiNhanh", HeaderText = "Chi Nhánh", DataPropertyName = "TenChiNhanh", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQuyenHan", HeaderText = "Quyền", DataPropertyName = "QuyenHan", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTrangThaiNV", HeaderText = "Trạng Thái", DataPropertyName = "TrangThai", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNgayVaoLam", HeaderText = "Ngày Vào Làm", DataPropertyName = "NgayVaoLam", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgv.Columns.Add(new DataGridViewButtonColumn { Name = "colSuaNV", HeaderText = "Sửa", Text = "Sửa", UseColumnTextForButtonValue = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = false, FlatStyle = FlatStyle.Flat, DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Blue } });
            dgv.Columns.Add(new DataGridViewButtonColumn { Name = "colToggleNV", HeaderText = "Đổi TT", Text = "Đổi TT", UseColumnTextForButtonValue = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = false, FlatStyle = FlatStyle.Flat, DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red } });

            // Gán BindingSource sau khi đã cấu hình cột
            dgv.DataSource = _bindingSourceNhanVien;
        }

        /// <summary>
        /// Gán các phương thức xử lý sự kiện cho controls.
        /// </summary>
        private void AssignEventHandlers()
        {
            cboChiNhanh.SelectedIndexChanged += CboChiNhanh_SelectedIndexChanged;
            btnThemMoi.Click += BtnThemMoi_Click;
            btnRefresh.Click += BtnRefresh_Click;
            dgvNhanVien.CellContentClick += DgvNhanVien_CellContentClick; // Dùng tên grid từ Designer
            dgvNhanVien.CellFormatting += DgvNhanVien_CellFormatting; // Dùng tên grid từ Designer
            dgvNhanVien.DataError += DgvNhanVien_DataError;       // Dùng tên grid từ Designer
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ConfigureUIBasedOnRole();
        }

        /// <summary>
        /// Cấu hình giao diện và tải dữ liệu dựa trên quyền của người dùng đăng nhập.
        /// </summary>
        private void ConfigureUIBasedOnRole()
        {
            if (!CurrentUserContext.IsLoggedIn) 
            {
                MessageBox.Show("Lỗi phân quyền."); 
                this.Enabled = false;
                return;
            }

            _currentUserRole = CurrentUserContext.User.Role;
            _currentUserStoreId = CurrentUserContext.User.DefaultStoreId;

            Log("Configuring UI based on role.");
            string userRole = CurrentUserContext.User.Role;
            int userStoreId = CurrentUserContext.User.DefaultStoreId;
            _currentUserRegion = null; // Reset region

            bool allowSelectStore = (userRole == "admin"); // Chỉ Admin được chọn ALL
            bool allowSelectRegionStore = (userRole == "quan_ly_khu_vuc");
            bool isStoreManager = (userRole == "quan_ly_cua_hang");

            // Lấy khu vực nếu là QLKV
            if (allowSelectRegionStore && _cuaHangService != null) 
            {
                var userStore = _cuaHangService.GetStoreById(_currentUserStoreId);
                _currentUserRegion = userStore?.KhuVuc;
            }

            // --- Cấu hình ComboBox Chi nhánh ---
            cboChiNhanh.Visible = allowSelectStore || allowSelectRegionStore;
            lblContentTitle.Visible = isStoreManager;
            if (lblContentTitle.Visible) lblContentTitle.Text = $"NHÂN VIÊN: {CurrentUserContext.User.TenCuaHang ?? "Cửa hàng"}";

            // Load ComboBox nếu user được phép chọn
            if (allowSelectStore || allowSelectRegionStore) { LoadChiNhanhComboBox(_currentUserRegion); }

            // --- Cấu hình Nút Thêm mới ---
            btnThemMoi.Visible = (userRole != "nhan_vien"); // Ai cũng được thêm trừ nhân viên? (Tùy chỉnh)

            // --- Tải dữ liệu dựa trên quyền ---
            // LoadData sẽ được gọi sau khi ComboBox được load (nếu có) hoặc gọi trực tiếp ở đây nếu là QLCH
            if (isStoreManager) { LoadNhanVienData(userStoreId); } // QLCH chỉ load CH của mình
            else if (!cboChiNhanh.Visible) { LoadNhanVienData(); } // Trường hợp đặc biệt: Load tất cả nếu CBB bị ẩn do lỗi?
        }

        /// <summary>
        /// Tải danh sách chi nhánh đang hoạt động vào ComboBox.
        /// </summary>
        private void LoadChiNhanhComboBox(string regionFilter = null)
        {
            if (_cuaHangService == null) return;
            try
            {
                List<StoreViewModel> stores;
                if (_currentUserRole == "quan_ly_cua_hang") // QLCH
                    stores = _cuaHangService.GetActiveStores().Where(s => s.Id == _currentUserStoreId).ToList(); // Lấy cửa hàng của QLCH
                else if (_currentUserRole == "quan_ly_khu_vuc")
                    stores = _cuaHangService.GetActiveStoresByRegion(regionFilter); // QLKV
                else
                    stores = _cuaHangService.GetActiveStores(); // Admin

                //var displayList = new List<StoreViewModel> { new StoreViewModel { Id = 0, TenCuaHang = string.IsNullOrWhiteSpace(regionFilter) ? "Tất cả Chi nhánh" : $"Tất cả ({regionFilter})" } };
                //displayList.AddRange(stores);

                cboChiNhanh.SelectedIndexChanged -= CboChiNhanh_SelectedIndexChanged;
                cboChiNhanh.DataSource = stores;
                cboChiNhanh.DisplayMember = "TenCuaHang"; cboChiNhanh.ValueMember = "Id";
                cboChiNhanh.SelectedValue = 0; // Chọn "Tất cả" mặc định
                cboChiNhanh.SelectedIndexChanged += CboChiNhanh_SelectedIndexChanged;
                // *** KHÔNG GỌI LoadData() ở đây, để nó được gọi một lần trong ConfigureUIBasedOnRole hoặc SelectedIndexChanged ***
                // Nếu SelectedValue = 0 đã trigger event thì LoadData() đã được gọi rồi.
                // Nếu cần chắc chắn load lần đầu:
                if (cboChiNhanh.SelectedIndex == 0) LoadNhanVienData();
            }
            catch (Exception ex) { LogError("LoadChiNhanhComboBox", ex); }
        }

        /// <summary>
        /// Tải danh sách nhân viên dựa trên bộ lọc và quyền hạn.
        /// </summary>
        public void LoadNhanVienData(int? forceStoreId = null) // Giữ nguyên tham số ép lọc
        {
            if (_nhanVienService == null) return;
            int? storeIdFilter = forceStoreId; // Ưu tiên ID ép vào
            string regionFilter = null;

            if (!storeIdFilter.HasValue) // Nếu không ép lọc
            {
                if (cboChiNhanh.Visible && cboChiNhanh.SelectedValue is int selectedId && selectedId > 0) { storeIdFilter = selectedId; } // Lấy từ CBB nếu hiển thị và đã chọn
                else if (_currentUserRole == "quan_ly_khu_vuc") { regionFilter = _currentUserRegion; } // Nếu chọn "Tất cả" của QLKV -> lọc theo region
                                                                                                       // Nếu Admin chọn "Tất cả" -> storeIdFilter=null, regionFilter=null -> Service lấy hết
            }

            // Cập nhật tiêu đề
            if (cboChiNhanh.Visible) { lblContentTitle.Text = $"NHÂN VIÊN: {cboChiNhanh.Text}"; }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<NhanVienViewModel> nhanViens = _nhanVienService.GetNhanVienList(storeIdFilter, regionFilter);
                _bindingSourceNhanVien.DataSource = typeof(NhanVienViewModel);
                _bindingSourceNhanVien.DataSource = nhanViens;
                _bindingSourceNhanVien.ResetBindings(false);
                dgvNhanVien.ClearSelection();
                Log($"Loaded {nhanViens?.Count ?? 0} employees. Filter StoreID: {storeIdFilter?.ToString() ?? "N/A"}, Region: {regionFilter ?? "N/A"}.");
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi tải danh sách nhân viên: {ex.Message}"); LogError("LoadData", ex); }
            finally { if (!this.IsDisposed && this.IsHandleCreated) this.Cursor = Cursors.Default; }
        }

        /// <summary>
        /// Tải danh sách nhân viên dựa trên bộ lọc.
        /// </summary>
        public void LoadData(int? storeId = null)
        {
            if (_nhanVienService == null) return;

            int? filterStoreId = storeId; // ID cửa hàng cụ thể được ép (từ QLCH)
            string filterRegion = null;

            // Nếu không bị ép lọc bởi QLCH, lấy từ ComboBox (Admin/QLKV)
            if (!filterStoreId.HasValue && cboChiNhanh.Visible)
            {
                if (cboChiNhanh.SelectedValue is int selectedId && selectedId > 0) { filterStoreId = selectedId; }
                else if (_currentUserRole == "quan_ly_khu_vuc") { filterRegion = _currentUserRegion; } // Nếu chọn "Tất cả" nhưng là QLKV, lọc theo region
                // Nếu là Admin chọn "Tất cả", filterStoreId và filterRegion đều null
            }

            // Cập nhật tiêu đề nếu ComboBox hiển thị
            if (cboChiNhanh.Visible) { lblContentTitle.Text = $"NHÂN VIÊN: {cboChiNhanh.Text}"; }


            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<NhanVienViewModel> nhanViens = _nhanVienService.GetNhanVienList(filterStoreId, filterRegion); // Gọi service với bộ lọc
                _bindingSourceNhanVien.DataSource = typeof(NhanVienViewModel);
                _bindingSourceNhanVien.DataSource = nhanViens;
                _bindingSourceNhanVien.ResetBindings(false);
                dgvNhanVien.ClearSelection();
                Log($"Loaded {nhanViens?.Count ?? 0} employees. Filter StoreID: {filterStoreId?.ToString() ?? "N/A"}, Region: {filterRegion ?? "N/A"}.");
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi tải danh sách nhân viên: {ex.Message}"); LogError("LoadData", ex); }
            finally { if (!this.IsDisposed && this.IsHandleCreated) this.Cursor = Cursors.Default; }
        }


        /// <summary>
        /// Xử lý khi chọn chi nhánh khác trong ComboBox.
        /// </summary>
        private void CboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ load lại khi người dùng chủ động thay đổi lựa chọn
            if (cboChiNhanh.Focused && cboChiNhanh.DataSource != null)
            {
                Log("CboChiNhanh_SelectedIndexChanged triggered by user.");
                LoadData();
            }
        }

        /// <summary>
        /// Xử lý nút làm mới danh sách.
        /// </summary>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ConfigureUIBasedOnRole();
            // Load lại dữ liệu dựa trên quyền và lựa chọn hiện tại
            if (CurrentUserContext.IsStoreManager)
            {
                LoadData(CurrentUserContext.User.DefaultStoreId);
            }
            else // Admin or Area Manager
            {
                LoadData(); // Load theo lựa chọn ComboBox
            }
        }

        /// <summary>
        /// Xử lý nút thêm mới nhân viên.
        /// </summary>
        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            // Chỉ kích hoạt sự kiện, việc kiểm tra quyền thêm chi tiết sẽ ở FormQuanLy hoặc FormThemNhanVien
            AddEmployeeRequested?.Invoke(this, EventArgs.Empty);
        }

        // Xử lý click nút Sửa/Đổi TT trên grid
        private void DgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvNhanVien.Rows.Count) return;
            if (dgvNhanVien.Rows[e.RowIndex].DataBoundItem is NhanVienViewModel selectedNV)
            {
                string colName = dgvNhanVien.Columns[e.ColumnIndex].Name;
                bool canEditThisEmployee = _currentUserRole == "admin" || _currentUserRole == "quan_ly_khu_vuc" || (_currentUserRole == "quan_ly_cua_hang" && selectedNV.IdCuaHangLamViec == _currentUserStoreId);

                if (colName == "colSuaNV") // Nút Sửa
                {
                    if (canEditThisEmployee) HandleEdit(selectedNV); // Gọi HandleEdit
                    else MessageBox.Show("Không có quyền sửa nhân viên này.");
                }
                else if (colName == "colToggleNV") // Nút Đổi TT
                {
                    if (canEditThisEmployee) HandleToggleStatus(selectedNV);
                    else MessageBox.Show("Không có quyền đổi trạng thái nhân viên này.");
                }
            }
        }

        /// <summary>
        /// Xử lý khi nhấn nút Sửa. Kích hoạt sự kiện để mở form chi tiết.
        /// </summary>
        private void HandleEdit(NhanVienViewModel nvToEdit)
        {
            if (nvToEdit == null) return;
            Log($"Edit requested for Employee ID: {nvToEdit.Id}");
            // Kích hoạt sự kiện Edit, gửi kèm ViewModel (FormQuanLy sẽ gọi service GetDetails nếu cần thêm)
            EditEmployeeRequested?.Invoke(this, nvToEdit);
        }

        /// <summary>
        /// Xử lý khi nhấn nút Đổi Trạng thái (Placeholder).
        /// </summary>
        private void HandleToggleStatus(NhanVienViewModel nv)
        {
            if (_nhanVienService == null) return;
            string newStatus = (nv.TrangThai == "dang_lam_viec") ? "da_nghi_viec" : "dang_lam_viec";
            string actionText = (newStatus == "da_nghi_viec") ? "cho nghỉ việc" : "kích hoạt lại";
            if (MessageBox.Show($"Bạn chắc chắn muốn {actionText} nhân viên '{nv.TenNV}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    bool success = _nhanVienService.ChangeNhanVienStatus(nv.Id, newStatus); // Gọi service
                    this.Cursor = Cursors.Default;
                    if (success) { MessageBox.Show($"Đã {actionText} thành công!"); LoadData(); } // Tải lại grid
                    else { MessageBox.Show($"Thao tác {actionText} thất bại."); }
                }
                catch (Exception ex) { this.Cursor = Cursors.Default; MessageBox.Show($"Lỗi khi {actionText}: {ex.Message}"); LogError($"HandleToggleStatus ID {nv.Id}", ex); }
            }
        }

        /// <summary>
        /// Định dạng hiển thị cho các ô trong DataGridView.
        /// </summary>
        private void DgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null || e.ColumnIndex < 0) return;
            string colName = dgvNhanVien.Columns[e.ColumnIndex].Name; // Dùng tên grid từ Designer
            try
            {
                switch (colName)
                {
                    case "colNgayVaoLam": if (e.Value is DateTime d) e.CellStyle.Format = "dd/MM/yyyy"; break;
                    case "colQuyenHan": e.Value = FormatRole(e.Value.ToString()); break;
                    case "colTrangThaiNV": string status = e.Value.ToString(); e.Value = FormatEmployeeStatus(status); e.CellStyle.ForeColor = (status == "dang_lam_viec") ? Color.Green : Color.OrangeRed; break;
                }
            }
            catch (Exception ex) { LogError($"CellFormatting Col:{colName} Row:{e.RowIndex}", ex); }
        }

        /// <summary>
        /// Xử lý lỗi dữ liệu DataGridView.
        /// </summary>
        private void DgvNhanVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            LogError($"DataGridView DataError at Col:{e.ColumnIndex} Row:{e.RowIndex}", e.Exception);
            e.ThrowException = false; e.Cancel = false;
        }

        // --- Hàm Helper Format ---
        private string FormatRole(string dbValue) 
        {
            if (dbValue == "nhan_vien")
                return "Nhân viên";
            else if (dbValue == "quan_ly_cua_hang")
                return "QL Cửa hàng";
            else if (dbValue == "quan_ly_khu_vuc")
                return "QL Khu vực";
            else if (dbValue == "admin")
                return "Admin";
            else
                return dbValue;

        }
        private string FormatEmployeeStatus(string dbValue) { return dbValue == "dang_lam_viec" ? "Đang làm" : (dbValue == "da_nghi_viec" ? "Đã nghỉ" : dbValue); }

        // --- Hàm Ghi Log ---
        private void Log(string message) { Debug.WriteLine($"[FormNhanVien] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormNhanVien ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class
} // End Namespace