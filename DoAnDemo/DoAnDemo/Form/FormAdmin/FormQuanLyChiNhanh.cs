// FormQuanLyChiNhanh.cs (Đầy đủ, đã sửa lỗi)
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models; // Namespace chứa StoreViewModel
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
using System.Diagnostics; // Cho LogError

namespace DoAnDemo.Form.FormAdmin // Namespace theo yêu cầu
{
    public partial class FormQuanLyChiNhanh : UserControl
    {
        private readonly ICuaHangService _cuaHangService;
        private BindingSource _bindingSource;

        // --- THÊM LẠI CÁC EVENTS ---
        /// <summary>
        /// Yêu cầu mở form để thêm chi nhánh mới.
        /// </summary>
        public event EventHandler AddStoreRequested;
        /// <summary>
        /// Yêu cầu mở form để sửa chi nhánh. Gửi kèm thông tin chi nhánh cần sửa.
        /// </summary>
        public event EventHandler<StoreViewModel> EditStoreRequested; // <<< THÊM KHAI BÁO EVENT NÀY

        public FormQuanLyChiNhanh()
        {
            InitializeComponent();
            try { _cuaHangService = new CuaHangService(); } catch (Exception ex) { LogError("Service Init", ex); /* Xử lý lỗi */ return; }
            _bindingSource = new BindingSource();
            SetupDataGridView();
            AssignEventHandlers();
            this.Load += FormQuanLyChiNhanh_Load;
        }

        private void SetupDataGridView()
        {
            dgvChiNhanh.AutoGenerateColumns = false;
            dgvChiNhanh.DataSource = _bindingSource;
            colMaCH.DataPropertyName = "MaCuaHang";
            colTenCH.DataPropertyName = "TenCuaHang";
            colDiaChi.DataPropertyName = "DiaChi";
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colKhuVuc.DataPropertyName = "KhuVuc";
            colTrangThai.DataPropertyName = "TrangThai";
        }

        private void AssignEventHandlers()
        {
            btnThemMoi.Click += BtnThemMoi_Click;
            dgvChiNhanh.CellContentClick += DgvChiNhanh_CellContentClick;
            dgvChiNhanh.CellFormatting += DgvChiNhanh_CellFormatting;
        }

        private void FormQuanLyChiNhanh_Load(object sender, EventArgs e) { LoadData(); }

        public void LoadData()
        {
            if (_cuaHangService == null) { MessageBox.Show("Lỗi: Service cửa hàng chưa được khởi tạo."); return; }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                // Lưu lại dòng đang được chọn (nếu có) để thử khôi phục sau khi load lại
                int? selectedRowIndex = dgvChiNhanh.CurrentRow?.Index;

                _bindingSource.DataSource = null; // Xóa nguồn cũ trước khi gán mới
                List<StoreViewModel> stores = _cuaHangService.GetAllStores();

                _bindingSource.DataSource = stores; // Gán danh sách mới

                // *** THÊM DÒNG NÀY ĐỂ BUỘC DATAGRIDVIEW CẬP NHẬT ***
                _bindingSource.ResetBindings(false);
                //***************************************************

                dgvChiNhanh.ClearSelection(); // Bỏ chọn dòng

                // Thử chọn lại dòng trước đó (nếu còn tồn tại)
                if (selectedRowIndex.HasValue && selectedRowIndex.Value < dgvChiNhanh.Rows.Count)
                {
                    dgvChiNhanh.Rows[selectedRowIndex.Value].Selected = true;
                    dgvChiNhanh.CurrentCell = dgvChiNhanh.Rows[selectedRowIndex.Value].Cells[0]; // Focus lại ô đầu tiên
                }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi tải danh sách chi nhánh: {ex.Message}", "Lỗi Hệ thống"); LogError("LoadData", ex); }
            finally { if (!this.IsDisposed && this.IsHandleCreated) this.Cursor = Cursors.Default; }
        }

        private void DgvChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvChiNhanh.Rows[e.RowIndex].DataBoundItem is StoreViewModel selectedStore)
            {
                if (dgvChiNhanh.Columns[e.ColumnIndex].Name == "colSua")
                {
                    HandleEdit(selectedStore);
                }
                else if (dgvChiNhanh.Columns[e.ColumnIndex].Name == "colXoa")
                {
                    // *** GỌI ĐÚNG TÊN HÀM ĐÃ ĐỊNH NGHĨA Ở DƯỚI ***
                    HandleDeleteOrToggle(selectedStore);
                }
            }
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện yêu cầu mở form Thêm mới
            AddStoreRequested?.Invoke(this, EventArgs.Empty);
            // MessageBox.Show("Chức năng Thêm mới Chi nhánh cần tạo Form nhập liệu.", "Thông báo");
        }

        // Hàm xử lý khi nút Sửa được nhấn
        private void HandleEdit(StoreViewModel storeToEdit)
        {
            // Kích hoạt sự kiện yêu cầu mở form Sửa và gửi dữ liệu đi
            EditStoreRequested?.Invoke(this, storeToEdit); // <<< SỰ KIỆN ĐÃ ĐƯỢC KHAI BÁO
            // MessageBox.Show($"Yêu cầu sửa chi nhánh: {storeToEdit.TenCuaHang} (ID: {storeToEdit.Id}).\nChức năng cần tạo Form nhập liệu.", "Thông báo");
        }

        // *** THÊM LẠI ĐỊNH NGHĨA HÀM NÀY ***
        /// <summary>
        /// Xử lý khi nhấn nút Xóa/Thay đổi trạng thái trên một dòng.
        /// </summary>
        private void HandleDeleteOrToggle(StoreViewModel store)
        {
            if (_cuaHangService == null) { MessageBox.Show("Lỗi Service."); return; }

            string currentStatus = store.TrangThai;
            string actionText = "";
            string newStatus = "";
            DialogResult confirmResult;

            // Xác định hành động và trạng thái mới
            if (currentStatus == "dang_hoat_dong") { actionText = "tạm ngưng"; newStatus = "tam_ngung"; }
            else if (currentStatus == "tam_ngung") { actionText = "kích hoạt lại"; newStatus = "dang_hoat_dong"; }
            else { MessageBox.Show($"Không thể thay đổi trạng thái cho chi nhánh đang '{FormatStatus(currentStatus)}'.", "Thông báo"); return; }

            confirmResult = MessageBox.Show($"Bạn có chắc muốn {actionText} chi nhánh '{store.TenCuaHang}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    bool success = _cuaHangService.ChangeStoreStatus(store.Id, newStatus);
                    this.Cursor = Cursors.Default;

                    if (success) { MessageBox.Show($"Đã {actionText} chi nhánh thành công!", "Hoàn tất"); LoadData(); }
                    else { MessageBox.Show($"Thao tác {actionText} thất bại.", "Lỗi"); }
                }
                catch (Exception ex) { this.Cursor = Cursors.Default; MessageBox.Show($"Lỗi khi {actionText} chi nhánh: {ex.Message}", "Lỗi Hệ thống"); LogError($"HandleDeleteOrToggle for ID {store.Id}", ex); }
            }
        }

        /// <summary>
        /// Định dạng lại cách hiển thị của ô trong cột Trạng Thái.
        /// </summary>
        private void DgvChiNhanh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChiNhanh.Columns[e.ColumnIndex].Name == "colTrangThai" && e.Value != null)
            {
                e.Value = FormatStatus(e.Value.ToString());
                // Set màu nếu muốn
                // if (e.Value.ToString() == "Đang hoạt động") e.CellStyle.ForeColor = Color.Green; else ...
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// Hàm helper để chuyển đổi mã trạng thái sang text dễ đọc.
        /// </summary>
        private string FormatStatus(string dbStatus)
        {
            switch (dbStatus?.ToLower())
            {
                case "dang_hoat_dong": return "Đang hoạt động";
                case "tam_ngung": return "Tạm ngưng";
                case "sap_khai_truong": return "Sắp khai trương";
                case "da_dong_cua": return "Đã đóng cửa";
                default: return dbStatus ?? "Không xác định";
            }
        }

        /// <summary>
        /// Hàm ghi log lỗi đơn giản.
        /// </summary>
        private void LogError(string context, Exception ex)
        {
            Debug.WriteLine($"[FormQuanLyChiNhanh ERROR] Context: {context} - Error: {ex.ToString()}");
        }

    } // End Class
} // End Namespace