using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormQuanLyGiamGiaList : UserControl
    {
        #region --- Services & Data ---
        private readonly IVoucherAdminService _voucherAdminService;
        private BindingSource _bindingSource;
        #endregion

        #region --- Events ---
        /// <summary>
        /// Event được kích hoạt khi người dùng nhấn nút Thêm Mới Voucher.
        /// FormQuanLy sẽ bắt sự kiện này để hiển thị FormAddVoucherStore.
        /// </summary>
        public event EventHandler AddVoucherRequested;

        /// <summary>
        /// Event được kích hoạt khi người dùng nhấn nút Sửa Voucher.
        /// FormQuanLy sẽ bắt sự kiện này để hiển thị FormAddVoucherStore ở chế độ sửa.
        /// </summary>
        public event EventHandler<VoucherEditViewModel> EditVoucherRequested;
        #endregion

        #region --- Constructor & Initial Setup ---
        public FormQuanLyGiamGiaList()
        {
            InitializeComponent();
            try
            {
                // Initialize service
                _voucherAdminService = new VoucherAdminService();

                // Set control anchoring and layout
                this.Dock = DockStyle.Fill;
                this.AutoScroll = true;

                // Initialize grid and bindings
                _bindingSource = new BindingSource();
                SetupDataGridView();
                dgvGiamGia.Dock = DockStyle.Fill;
                dgvGiamGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Assign event handlers
                AssignEventHandlers();
            }
            catch (Exception ex)
            {
                LogError("Constructor", ex);
                MessageBox.Show(
                    "Lỗi khởi tạo: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Enabled = false;
            }
        }

        /// <summary>
        /// Thiết lập các thuộc tính và cột cho DataGridView.
        /// </summary>
        private void SetupDataGridView()
        {
            dgvGiamGia.AutoGenerateColumns = false; // Tắt tự động sinh cột
            dgvGiamGia.DataSource = _bindingSource; // Gán BindingSource

            // Gán DataPropertyName cho từng cột đã tạo trong Designer
            // Đảm bảo tên cột (ví dụ: colMaVoucher) và DataPropertyName khớp với ViewModel
            // Sử dụng VoucherEditViewModel vì nó chứa đủ các trường cần hiển thị
            colMaVoucher.DataPropertyName = nameof(VoucherEditViewModel.MaVoucher);
            colTenVoucher.DataPropertyName = nameof(VoucherEditViewModel.TenVoucher);
            colLoaiGiamGia.DataPropertyName = nameof(VoucherEditViewModel.LoaiGiamGia);
            colGiaTri.DataPropertyName = nameof(VoucherEditViewModel.GiaTriGiam);
            colNgayBatDau.DataPropertyName = nameof(VoucherEditViewModel.NgayBatDau);
            colNgayKetThuc.DataPropertyName = nameof(VoucherEditViewModel.NgayKetThuc);
            //colPhamVi.DataPropertyName = nameof(VoucherEditViewModel.PhamViApDung);
            colTrangThai.DataPropertyName = nameof(VoucherEditViewModel.TrangThai);

            // Các cột nút không cần DataPropertyName
        }

        /// <summary>
        /// Gán các phương thức xử lý sự kiện cho controls.
        /// </summary>
        private void AssignEventHandlers()
        {
            btnThemMoi.Click += BtnThemMoi_Click; // Gán sự kiện cho nút Thêm Mới
            dgvGiamGia.CellContentClick += DgvGiamGia_CellContentClick; // Xử lý click nút trong grid
            dgvGiamGia.CellFormatting += DgvGiamGia_CellFormatting;     // Định dạng hiển thị cell
            dgvGiamGia.DataError += DgvGiamGia_DataError;                // Xử lý lỗi binding dữ liệu
        }

        private void FormQuanLyGiamGiaList_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) LoadData(); // Tải dữ liệu khi form được load
        }

        #endregion

        #region --- Data Loading ---
        /// <summary>
        /// Tải danh sách chương trình giảm giá từ service và hiển thị lên grid.
        /// </summary>
        public void LoadData()
        {
            if (_voucherAdminService == null)
            {
                MessageBox.Show("Lỗi Service Voucher không khả dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Log("Loading voucher programs list...");
            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<VoucherEditViewModel> vouchers = _voucherAdminService.GetAllVoucherPrograms();
                _bindingSource.DataSource = typeof(VoucherEditViewModel); // Gán kiểu dữ liệu cho BindingSource
                _bindingSource.DataSource = vouchers; // Gán danh sách dữ liệu
                dgvGiamGia.ClearSelection(); // Bỏ chọn dòng hiện tại (nếu có)
                Log($"Loaded {vouchers?.Count ?? 0} voucher programs.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách giảm giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError("LoadData", ex);
                _bindingSource.DataSource = null; // Xóa dữ liệu cũ nếu lỗi
            }
            finally
            {
                if (!this.IsDisposed && this.IsHandleCreated) this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region --- Event Handlers ---
        /// <summary>
        /// Xử lý sự kiện click nút Thêm mới.
        /// Kích hoạt event AddVoucherRequested để báo cho Form cha (FormQuanLy).
        /// </summary>
        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            Log("Add New button clicked. Raising AddVoucherRequested event...");
            AddVoucherRequested?.Invoke(this, EventArgs.Empty);
            // FormQuanLy sẽ bắt sự kiện này và gọi ShowAddEditVoucherStoreControl(null)
        }

        /// <summary>
        /// Xử lý click vào nút Sửa hoặc Xóa/Đổi TT trong grid.
        /// </summary>
        private void DgvGiamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvGiamGia.Rows.Count || e.ColumnIndex < 0) return;

            if (dgvGiamGia.Rows[e.RowIndex].DataBoundItem is VoucherEditViewModel selectedVoucherRow)
            {
                string columnName = dgvGiamGia.Columns[e.ColumnIndex].Name;
                Log($"CellContentClick on Row {e.RowIndex}, Col {columnName}, Voucher ID: {selectedVoucherRow.Id}");

                if (columnName == "colSua") // Nút Sửa
                {
                    Log($"Edit button clicked for voucher ID: {selectedVoucherRow.Id}. Raising EditVoucherRequested event...");
                    EditVoucherRequested?.Invoke(this, selectedVoucherRow);
                }
                else if (columnName == "colXoa") // Nút Đổi Trạng Thái (Tên cột là Xoa)
                {
                    HandleToggleStatus(selectedVoucherRow);
                }
            }
        }

        /// <summary>
        /// Xử lý khi nhấn nút Đổi TT (Thay đổi trạng thái Active/Inactive).
        /// </summary>
        private void HandleToggleStatus(VoucherEditViewModel voucher)
        {
            if (_voucherAdminService == null) return;
            if (voucher == null) return;

            string currentStatus = voucher.TrangThai;
            string actionText; string newStatus;

            if (currentStatus.Equals("active", StringComparison.OrdinalIgnoreCase)) { actionText = "ngưng kích hoạt"; newStatus = "inactive"; }
            else if (currentStatus.Equals("inactive", StringComparison.OrdinalIgnoreCase)) { actionText = "kích hoạt lại"; newStatus = "active"; }
            else { MessageBox.Show($"Không thể thay đổi trạng thái cho voucher đang '{FormatStatus(currentStatus)}'.", "Thao tác không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            DialogResult confirmResult = MessageBox.Show($"Bạn có chắc muốn {actionText} chương trình '{voucher.TenVoucher}' (Mã: {voucher.MaVoucher})?",
                                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    Log($"Attempting to change status for Voucher ID {voucher.Id} to '{newStatus}'");
                    bool success = _voucherAdminService.ChangeVoucherStatus(voucher.Id, newStatus);

                    if (success)
                    {
                        MessageBox.Show($"Đã {actionText} thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Tải lại danh sách để cập nhật grid
                    }
                    else { MessageBox.Show($"Thao tác {actionText} thất bại (Service trả về false).", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi {actionText}: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogError($"HandleToggleStatus ID {voucher.Id}", ex);
                }
                finally { if (!this.IsDisposed && this.IsHandleCreated) this.Cursor = Cursors.Default; }
            }
        }

        /// <summary>
        /// Định dạng hiển thị cho các ô trong DataGridView.
        /// </summary>
        private void DgvGiamGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null || e.ColumnIndex < 0) return;

            string colName = dgvGiamGia.Columns[e.ColumnIndex].Name;
            try
            {
                switch (colName)
                {
                    case "colLoaiGiamGia":
                        e.Value = FormatDiscountType(e.Value.ToString());
                        e.FormattingApplied = true;
                        break;
                    case "colGiaTri":
                        if (dgvGiamGia.Rows[e.RowIndex].DataBoundItem is VoucherEditViewModel v)
                        {
                            if (v.LoaiGiamGia == "percentage") { e.CellStyle.Format = "N0'%';'-'N0'%'"; }
                            else if (v.LoaiGiamGia == "fixed_amount") { e.CellStyle.Format = "N0';'-'N0"; }
                            else { e.CellStyle.Format = ""; } // Loại 'free_item' hoặc khác không format số
                        }
                        e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "colNgayBatDau":
                        if (e.Value is DateTime x)
                        {
                            if (x.Year > 9000) { e.Value = "Không giới hạn"; } // Hiển thị nếu là ngày rất xa
                            else { e.CellStyle.Format = "dd/MM/yyyy"; }
                            e.FormattingApplied = true;
                        }
                        break;
                    case "colNgayKetThuc":
                        if (e.Value is DateTime d)
                        {
                            if (d.Year > 9000) { e.Value = "Không giới hạn"; } // Hiển thị nếu là ngày rất xa
                            else { e.CellStyle.Format = "dd/MM/yyyy"; }
                            e.FormattingApplied = true;
                        }
                        break;
                    case "colPhamVi":
                        e.Value = FormatScope(e.Value.ToString());
                        e.FormattingApplied = true;
                        break;
                    case "colTrangThai":
                        string status = e.Value.ToString();
                        e.Value = FormatStatus(status);
                        if (status.Equals("active", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.Green;
                        else if (status.Equals("inactive", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.OrangeRed;
                        else e.CellStyle.ForeColor = Color.Gray;
                        e.FormattingApplied = true;
                        break;
                }
            }
            catch (Exception ex) { LogError($"CellFormatting Col:{colName} Row:{e.RowIndex} Value:'{e.Value}'", ex); }
        }

        /// <summary>
        /// Xử lý lỗi dữ liệu DataGridView (ví dụ: lỗi binding).
        /// </summary>
        private void DgvGiamGia_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            LogError($"DataGridView DataError at Col:{e.ColumnIndex} Row:{e.RowIndex}. Context: {e.Context}", e.Exception);
            // Chỉ log lỗi, không làm crash app
            e.ThrowException = false;
            e.Cancel = false;
        }

        #endregion

        #region --- Hàm Helper Format ---
        private string FormatDiscountType(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "percentage": return "%";
                case "fixed_amount": return "VND";
                case "free_item": return "Tặng SP";
                default: return dbValue ?? "";
            }
        }
        private string FormatScope(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "toan_chuoi": return "Toàn chuỗi";
                case "theo_cua_hang": return "Theo CH";
                case "theo_khu_vuc": return "Theo KV";
                default: return dbValue ?? "";
            }
        }
        private string FormatStatus(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "active": return "Hoạt động";
                case "inactive": return "Ngưng hoạt động";
                case "expired": return "Hết hạn";
                case "used_up": return "Hết số lượng";
                default: return dbValue ?? "";
            }
        }
        #endregion

        #region --- Hàm Ghi Log ---
        private void Log(string message) { Debug.WriteLine($"[FormQLGiamGiaList] {DateTime.Now:HH:mm:ss.fff} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormQLGiamGiaList ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }
        #endregion

    } // End Class
} // End Namespace