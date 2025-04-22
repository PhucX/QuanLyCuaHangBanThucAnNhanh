// FormSuaNhanVien.cs (Code-behind đầy đủ cho chức năng Sửa)
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using DoAnDemo.Utils; // Namespace chứa CurrentUserContext
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormSuaNhanVien : UserControl
    {
        // --- Services ---
        private readonly INhanVienService _nhanVienService;
        private readonly ICuaHangService _cuaHangService;

        // --- State ---
        private NhanVienViewModel _nvToEdit = null; // Chỉ lưu thông tin NV cần sửa

        // --- Events ---
        public event EventHandler<SaveCompleteEventArgs> SaveComplete;
        public event EventHandler CancelRequested;

        // --- Constructor ---
        public FormSuaNhanVien()
        {
            InitializeComponent();
            try
            {
                _nhanVienService = new NhanVienService();
                _cuaHangService = new CuaHangService();
            }
            catch (Exception ex) { LogError("Service Init", ex); this.Enabled = false; return; }

            AssignEventHandlers();
            // Load ComboBoxes khi form được tạo, nhưng PopulateForm sẽ gọi khi có data
            this.Load += FormSuaNhanVien_Load;
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            // Load các ComboBox với dữ liệu tĩnh hoặc dựa trên quyền (nhưng chưa chọn giá trị)
            LoadQuyenHanComboBoxBasedOnRole(CurrentUserContext.User?.Role);
            LoadTrangThaiComboBox();
            // LoadChiNhanhComboBoxBasedOnRole sẽ được gọi trong PopulateForm khi có _nvToEdit
        }

        /// <summary>
        /// Gán các phương thức xử lý sự kiện cho controls.
        /// </summary>
        private void AssignEventHandlers()
        {
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            btnResetPassword.Click += BtnResetPassword_Click; // Nút đặt lại MK
            txtSoDienThoai.KeyPress += NumberValidation_KeyPress;
            // Gán event khác nếu cần
        }

        /// <summary>
        /// Load dữ liệu nhân viên cần sửa và hiển thị lên form.
        /// </summary>
        public void LoadNhanVienData(NhanVienViewModel nvData)
        {
            if (nvData == null || nvData.Id <= 0)
            {
                LogError("LoadNhanVienData called with invalid data.", null);
                MessageBox.Show("Dữ liệu nhân viên không hợp lệ để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CancelRequested?.Invoke(this, EventArgs.Empty); // Yêu cầu đóng form
                return;
            }
            _nvToEdit = nvData;
            PopulateForm(); // Điền dữ liệu lên form
        }

        /// <summary>
        /// Tải danh sách quyền hạn vào ComboBox dựa trên quyền người dùng hiện tại.
        /// </summary>
        private void LoadQuyenHanComboBoxBasedOnRole(string currentUserRole)
        {
            var roles = new List<KeyValuePair<string, string>>();
            bool enableRoleSelection = false; // Mặc định không cho sửa quyền

            // Chỉ Admin và QLKV mới có thể sửa quyền (trong giới hạn)
            if (currentUserRole == "admin")
            {
                roles.Add(new KeyValuePair<string, string>("nhan_vien", "Nhân viên"));
                roles.Add(new KeyValuePair<string, string>("quan_ly_cua_hang", "Quản lý cửa hàng"));
                roles.Add(new KeyValuePair<string, string>("quan_ly_khu_vuc", "Quản lý khu vực"));
                enableRoleSelection = true; // Admin được sửa
            }
            else if (currentUserRole == "quan_ly_khu_vuc")
            {
                roles.Add(new KeyValuePair<string, string>("nhan_vien", "Nhân viên"));
                roles.Add(new KeyValuePair<string, string>("quan_ly_cua_hang", "Quản lý cửa hàng"));
                // QLKV chỉ được sửa thành quyền thấp hơn hoặc bằng QLCH
                enableRoleSelection = true;
            }
            else // QLCH hoặc các role khác không được sửa quyền hạn
            {
                // Load tất cả để hiển thị đúng quyền hiện tại, nhưng disable combobox
                roles.Add(new KeyValuePair<string, string>("nhan_vien", "Nhân viên"));
                roles.Add(new KeyValuePair<string, string>("quan_ly_cua_hang", "Quản lý cửa hàng"));
                roles.Add(new KeyValuePair<string, string>("quan_ly_khu_vuc", "Quản lý khu vực"));
                roles.Add(new KeyValuePair<string, string>("admin", "Admin"));
                enableRoleSelection = false;
            }

            try
            {
                cmbQuyenHan.DataSource = new BindingSource(roles, null);
                cmbQuyenHan.DisplayMember = "Value"; cmbQuyenHan.ValueMember = "Key";
                cmbQuyenHan.Enabled = enableRoleSelection; // Enable/Disable dựa trên quyền
            }
            catch (Exception ex) { LogError("LoadQuyenHanComboBoxBasedOnRole", ex); }
        }

        /// <summary>
        /// Tải danh sách trạng thái (chỉ dùng để hiển thị, không cho sửa).
        /// </summary>
        private void LoadTrangThaiComboBox()
        {
            try
            {
                var statuses = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("dang_lam_viec", "Đang làm việc"), new KeyValuePair<string, string>("da_nghi_viec", "Đã nghỉ việc") }; cmbTrangThaiNV.DataSource = new BindingSource(statuses, null); cmbTrangThaiNV.DisplayMember = "Value"; cmbTrangThaiNV.ValueMember = "Key"; cmbTrangThaiNV.Enabled = false; // Luôn disable
            }
            catch (Exception ex) { LogError("LoadTrangThaiComboBox", ex); }
        }

        /// <summary>
        /// Tải danh sách chi nhánh dựa trên quyền hạn của người dùng đang sửa.
        /// </summary>
        private void LoadChiNhanhComboBoxBasedOnRole(string currentUserRole, int employeeStoreId, string employeeRegion)
        {
            bool allowBranchChange = (currentUserRole == "admin" || currentUserRole == "quan_ly_khu_vuc");
            cmbChiNhanhLamViec.Enabled = allowBranchChange; // Enable/Disable

            if (allowBranchChange && _cuaHangService != null)
            {
                try
                {
                    List<StoreViewModel> stores;
                    if (currentUserRole == "quan_ly_khu_vuc")
                    {
                        stores = _cuaHangService.GetActiveStoresByRegion(employeeRegion); // Chỉ hiển thị CH trong khu vực QLKV quản lý
                    }
                    else // Admin
                    {
                        stores = _cuaHangService.GetActiveStores(); // Admin thấy hết
                    }
                    cmbChiNhanhLamViec.DataSource = stores;
                    cmbChiNhanhLamViec.DisplayMember = "TenCuaHang";
                    cmbChiNhanhLamViec.ValueMember = "Id";
                    cmbChiNhanhLamViec.SelectedValue = employeeStoreId; // Chọn chi nhánh hiện tại của NV
                }
                catch (Exception ex) { LogError("LoadChiNhanhComboBoxBasedOnRole (Edit)", ex); }
            }
            else if (!allowBranchChange && _cuaHangService != null)
            {
                // Nếu là QLCH, chỉ hiển thị tên CH của NV và disable
                cmbChiNhanhLamViec.DataSource = new List<StoreViewModel> { _cuaHangService.GetStoreById(employeeStoreId) ?? new StoreViewModel { Id = employeeStoreId, TenCuaHang = "Lỗi tải tên CH" } };
                cmbChiNhanhLamViec.DisplayMember = "TenCuaHang";
                cmbChiNhanhLamViec.ValueMember = "Id";
                cmbChiNhanhLamViec.SelectedIndex = 0;
            }
            else
            {
                cmbChiNhanhLamViec.DataSource = null; // Lỗi service hoặc không có quyền
            }
        }


        /// <summary>
        /// Điền dữ liệu của nhân viên cần sửa lên form.
        /// </summary>
        private void PopulateForm()
        {
            if (_nvToEdit == null) // Phải có dữ liệu khi sửa
            {
                LogError("PopulateForm called with null _nvToEdit in Edit mode.", null);
                MessageBox.Show("Không có thông tin nhân viên để sửa.");
                CancelRequested?.Invoke(this, EventArgs.Empty); // Đóng form
                return;
            }

            try
            {
                lblTitle.Text = $"CẬP NHẬT NHÂN VIÊN: {_nvToEdit.TenNV}";
                txtMaNhanVien.Text = _nvToEdit.MaNV;
                txtTenNhanVien.Text = _nvToEdit.TenNV;
                txtSoDienThoai.Text = _nvToEdit.SDT;
                txtTaiKhoan.Text = _nvToEdit.TaiKhoan;
                cmbTrangThaiNV.SelectedValue = _nvToEdit.TrangThai;
                dtpNgayVaoLam.Value = _nvToEdit.NgayVaoLam ?? DateTime.Now.Date;
                dtpNgayVaoLam.Checked = _nvToEdit.NgayVaoLam.HasValue;

                // Lấy khu vực của cửa hàng hiện tại để lọc combobox nếu cần
                var currentStore = _cuaHangService?.GetStoreById(_nvToEdit.IdCuaHangLamViec);

                // Load và set giá trị cho ComboBox Quyền hạn và Chi nhánh dựa trên quyền người sửa
                string currentUserRole = CurrentUserContext.User?.Role ?? "";
                LoadQuyenHanComboBoxBasedOnRole(currentUserRole); // Load đúng danh sách quyền được phép chọn
                cmbQuyenHan.SelectedValue = _nvToEdit.QuyenHan; // Chọn quyền hiện tại của NV

                LoadChiNhanhComboBoxBasedOnRole(currentUserRole, _nvToEdit.IdCuaHangLamViec, currentStore?.KhuVuc); // Load chi nhánh theo quyền

                // Khóa các trường không được sửa
                txtMaNhanVien.ReadOnly = true;
                txtTaiKhoan.ReadOnly = true;
                cmbTrangThaiNV.Enabled = false; // Trạng thái đổi ở grid list
                btnResetPassword.Visible = true; // Hiện nút reset password
            }
            catch (Exception ex) { LogError("PopulateForm Edit", ex); MessageBox.Show("Lỗi hiển thị thông tin nhân viên."); }
        }

        // --- Xử lý Lưu ---
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (_nvToEdit == null) { MessageBox.Show("Không có thông tin nhân viên để cập nhật."); return; } // Kiểm tra có dữ liệu sửa không
            if (!ValidateInput()) return; // Kiểm tra nhập liệu
            if (_nhanVienService == null) { MessageBox.Show("Lỗi Service Nhân viên."); return; }

            // Thu thập dữ liệu từ các control *được phép sửa*
            var updatedNvData = new NhanVienViewModel
            {
                Id = _nvToEdit.Id,                  // Giữ nguyên ID
                MaNV = _nvToEdit.MaNV,              // Giữ nguyên Mã NV
                TenNV = txtTenNhanVien.Text.Trim(), // Lấy tên mới
                SDT = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? null : txtSoDienThoai.Text.Trim(), // Lấy SĐT mới
                TaiKhoan = _nvToEdit.TaiKhoan,      // Giữ nguyên Tài khoản
                // Lấy chi nhánh mới nếu ComboBox được phép sửa, ngược lại giữ chi nhánh cũ
                IdCuaHangLamViec = (cmbChiNhanhLamViec.Enabled && cmbChiNhanhLamViec.SelectedValue is int newStoreId) ? newStoreId : _nvToEdit.IdCuaHangLamViec,
                // Lấy quyền mới nếu ComboBox được phép sửa, ngược lại giữ quyền cũ
                QuyenHan = (cmbQuyenHan.Enabled && cmbQuyenHan.SelectedValue != null) ? cmbQuyenHan.SelectedValue.ToString() : _nvToEdit.QuyenHan,
                TrangThai = _nvToEdit.TrangThai,    // Giữ nguyên Trạng thái (đổi ở grid)
                NgayVaoLam = dtpNgayVaoLam.Checked ? dtpNgayVaoLam.Value.Date : (DateTime?)null // Lấy ngày vào làm mới
            };

            // TODO: Kiểm tra lại phân quyền lần cuối trước khi gọi Service
            string currentUserRole = CurrentUserContext.User?.Role ?? "";
            if (currentUserRole == "quan_ly_khu_vuc" && (updatedNvData.QuyenHan == "quan_ly_khu_vuc" || updatedNvData.QuyenHan == "admin")) { MessageBox.Show("QLKV không được gán quyền này."); return; }
            if (currentUserRole == "quan_ly_cua_hang" && updatedNvData.QuyenHan != "nhan_vien") { MessageBox.Show("QLCH chỉ quản lý Nhân viên."); return; }
            if (currentUserRole == "quan_ly_cua_hang" && updatedNvData.IdCuaHangLamViec != CurrentUserContext.User.DefaultStoreId) { MessageBox.Show("QLCH không được đổi chi nhánh NV."); return; }

            bool success = false;
            try
            {
                this.Cursor = Cursors.WaitCursor; this.Enabled = false; Application.DoEvents();
                // Luôn gọi UpdateNhanVien vì form này chỉ để sửa
                success = _nhanVienService.UpdateNhanVien(updatedNvData);
                this.Enabled = true; this.Cursor = Cursors.Default;

                if (success) 
                { 
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công"); 
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(true)); 
                } // Báo thành công
                else { MessageBox.Show("Cập nhật nhân viên thất bại.", "Lỗi"); SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false)); } // Báo thất bại
            }
            catch (ArgumentException argEx) { this.Enabled = true; this.Cursor = Cursors.Default; MessageBox.Show(argEx.Message, "Dữ liệu không hợp lệ"); }
            catch (Exception ex) { this.Enabled = true; this.Cursor = Cursors.Default; LogError("Lỗi cập nhật nhân viên", ex); MessageBox.Show($"Lỗi khi lưu: {ex.Message}"); }
        }

        // --- Xử lý Hủy ---
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            CancelRequested?.Invoke(this, EventArgs.Empty); // Kích hoạt sự kiện hủy
        }

        // --- Xử lý Đặt lại mật khẩu (Placeholder) ---
        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            // TODO: Implement Reset Password Functionality
            // 1. Có thể mở một Dialog mới yêu cầu nhập mật khẩu mới + xác nhận
            // 2. Hoặc tạo mật khẩu ngẫu nhiên và gửi cho người dùng/admin
            // 3. Gọi một phương thức Service riêng để đổi mật khẩu (ví dụ: _nhanVienService.ResetPassword(employeeId))
            MessageBox.Show($"Chức năng đặt lại mật khẩu cho NV '{_nvToEdit.TenNV}' chưa được cài đặt.", "Thông báo");
        }


        /// <summary>
        /// Kiểm tra dữ liệu nhập trên form khi Sửa.
        /// </summary>
        private bool ValidateInput()
        {
            // Chỉ kiểm tra các trường được phép sửa
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text)) { MessageBox.Show("Nhập Tên nhân viên."); txtTenNhanVien.Focus(); return false; }
            if (cmbChiNhanhLamViec.Enabled && (cmbChiNhanhLamViec.SelectedValue == null || (int)cmbChiNhanhLamViec.SelectedValue <= 0)) { MessageBox.Show("Chọn Chi nhánh làm việc."); cmbChiNhanhLamViec.Focus(); return false; } // Chỉ kiểm tra nếu được phép sửa
            if (cmbQuyenHan.Enabled && cmbQuyenHan.SelectedValue == null) { MessageBox.Show("Chọn Quyền hạn."); cmbQuyenHan.Focus(); return false; } // Chỉ kiểm tra nếu được phép sửa
            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && !Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^(0[3|5|7|8|9])+([0-9]{8})\b$")) { MessageBox.Show("Định dạng Số điện thoại không hợp lệ."); txtSoDienThoai.Focus(); return false; }

            return true;
        }

        // --- Helpers ---
        private void NumberValidation_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void EmployeeCode_KeyPress(object sender, KeyPressEventArgs e) { e.KeyChar = char.ToUpper(e.KeyChar); }
        private void AccountName_KeyPress(object sender, KeyPressEventArgs e) { /* Giới hạn ký tự */ }
        private void Log(string message) { Debug.WriteLine($"[FormSuaNV] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormSuaNV ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class
} // End Namespace