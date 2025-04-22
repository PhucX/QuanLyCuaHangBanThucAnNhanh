// FormThemNhanVien.cs (Đầy đủ, đã thêm LoadNhanVienData)
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using DoAnDemo.Utils; // Namespace chứa CurrentAdminInfo
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
    public partial class FormThemNhanVien : UserControl
    {
        private readonly INhanVienService _nhanVienService;

        public event EventHandler<SaveCompleteEventArgs> SaveComplete;
        public event EventHandler CancelRequested;

        public FormThemNhanVien()
        {
            InitializeComponent();
            try { _nhanVienService = new NhanVienService(); /* Khởi tạo service khác nếu cần */ }
            catch (Exception ex) { LogError("Service Init", ex); this.Enabled = false; return; }
            AssignEventHandlers();
            this.Load += FormThemNhanVien_Load;
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureFormBasedOnRole(); // Load ComboBox Quyền theo Role
                LoadTrangThaiComboBox();
                ResetForm(); // Reset về trạng thái thêm mới
            }
            catch (Exception ex) { LogError("Lỗi FormThemNhanVien_Load", ex); }
        }

        private void AssignEventHandlers()
        {
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            txtSoDienThoai.KeyPress += NumberValidation_KeyPress;
            txtMaNhanVien.KeyPress += EmployeeCode_KeyPress;
            txtTaiKhoan.KeyPress += AccountName_KeyPress;
        }

        /// <summary>
        /// Load danh sách quyền hạn vào ComboBox DỰA TRÊN QUYỀN của người dùng hiện tại.
        /// </summary>
        /// <summary>
        /// Tải danh sách quyền hạn dựa trên quyền của người dùng hiện tại.
        /// </summary>
        private void LoadQuyenHanComboBoxBasedOnRole(string currentUserRole)
        {
            var roles = new List<KeyValuePair<string, string>>();
            bool enableRoleSelection = true;
            if (currentUserRole == "admin") { roles.Add(new KeyValuePair<string, string>("nhan_vien", "Nhân viên")); roles.Add(new KeyValuePair<string, string>("quan_ly_cua_hang", "Quản lý cửa hàng")); roles.Add(new KeyValuePair<string, string>("quan_ly_khu_vuc", "Quản lý khu vực")); }
            else if (currentUserRole == "quan_ly_khu_vuc") { roles.Add(new KeyValuePair<string, string>("nhan_vien", "Nhân viên")); roles.Add(new KeyValuePair<string, string>("quan_ly_cua_hang", "Quản lý cửa hàng")); }
            else if (currentUserRole == "quan_ly_cua_hang") { roles.Add(new KeyValuePair<string, string>("nhan_vien", "Nhân viên")); enableRoleSelection = false; }
            else { enableRoleSelection = false; this.Enabled = false; return; }
            try { cmbQuyenHan.DataSource = new BindingSource(roles, null); cmbQuyenHan.DisplayMember = "Value"; cmbQuyenHan.ValueMember = "Key"; if (roles.Any()) cmbQuyenHan.SelectedIndex = 0; cmbQuyenHan.Enabled = enableRoleSelection; } catch (Exception ex) { LogError("LoadQuyenHanComboBoxBasedOnRole", ex); }
        }

        private void LoadQuyenHanComboBox() 
        { 
            try { var roles = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("nhan_vien", "Nhân viên"), new KeyValuePair<string, string>("quan_ly_cua_hang", "Quản lý cửa hàng"), }; cmbQuyenHan.DataSource = new BindingSource(roles, null); cmbQuyenHan.DisplayMember = "Value"; cmbQuyenHan.ValueMember = "Key"; cmbQuyenHan.SelectedValue = "nhan_vien"; } catch (Exception ex) { LogError("LoadQuyenHanComboBox", ex); 
            } 
        }

        /// <summary>
        /// Reset form về trạng thái Thêm mới.
        /// </summary>
        private void ResetForm() // Đổi tên từ PopulateForm
        {
            try
            {
                lblTitle.Text = "THÊM MỚI NHÂN VIÊN";
                txtMaNhanVien.Clear(); txtMaNhanVien.ReadOnly = false; txtMaNhanVien.PlaceholderText = "Nhập mã NV (VD: NV008)";
                txtTenNhanVien.Clear();
                txtSoDienThoai.Clear();
                txtTaiKhoan.Clear(); txtTaiKhoan.ReadOnly = false; txtTaiKhoan.PlaceholderText = "Nhập tài khoản đăng nhập";
                txtMatKhau.Clear(); txtMatKhau.PlaceholderText = "Nhập mật khẩu"; txtMatKhau.Enabled = true;
                txtXacNhanMK.Clear(); txtXacNhanMK.PlaceholderText = "Nhập lại mật khẩu"; txtXacNhanMK.Enabled = true;
                // Không còn ComboBox chi nhánh
                if (cmbQuyenHan.Items.Count > 0) cmbQuyenHan.SelectedValue = "nhan_vien";
                if (cmbTrangThaiNV.Items.Count > 0) cmbTrangThaiNV.SelectedValue = "dang_lam_viec";
                dtpNgayVaoLam.Value = DateTime.Now.Date; dtpNgayVaoLam.Checked = true;
                txtMaNhanVien.Focus();
            }
            catch (Exception ex) { LogError("ResetForm", ex); }
        }

        /// <summary>
        /// Cấu hình ComboBox Quyền hạn dựa trên quyền người dùng hiện tại.
        /// </summary>
        private void ConfigureFormBasedOnRole()
        {
            string currentUserRole = CurrentUserContext.User?.Role ?? "";
            LoadQuyenHanComboBoxBasedOnRole(currentUserRole);
            // Không cần load chi nhánh nữa
        }

        private void LoadTrangThaiComboBox()
        { 
            try 
            { 
                var statuses = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("dang_lam_viec", "Đang làm việc"), new KeyValuePair<string, string>("da_nghi_viec", "Đã nghỉ việc") }; cmbTrangThaiNV.DataSource = new BindingSource(statuses, null); cmbTrangThaiNV.DisplayMember = "Value"; cmbTrangThaiNV.ValueMember = "Key"; cmbTrangThaiNV.SelectedValue = "dang_lam_viec"; } catch (Exception ex) { LogError("LoadTrangThaiComboBox", ex);
            } 
        }

        // --- Xử lý Lưu (Chỉ Add) ---
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (_nhanVienService == null) { MessageBox.Show("Lỗi Service Nhân viên."); return; }

            int managerStoreId = CurrentUserContext.User?.DefaultStoreId ?? 0;
            if (managerStoreId <= 0) { MessageBox.Show("Không thể xác định cửa hàng."); return; }

            var nvData = new NhanVienViewModel
            {
                Id = 0,
                MaNV = txtMaNhanVien.Text.Trim(),
                TenNV = txtTenNhanVien.Text.Trim(),
                SDT = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? null : txtSoDienThoai.Text.Trim(),
                TaiKhoan = txtTaiKhoan.Text.Trim(),
                IdCuaHangLamViec = managerStoreId, // GÁN ID CỬA HÀNG TỪ NGƯỜI DÙNG HT
                QuyenHan = cmbQuyenHan.SelectedValue?.ToString(),
                TrangThai = cmbTrangThaiNV.SelectedValue?.ToString(),
                NgayVaoLam = dtpNgayVaoLam.Checked ? dtpNgayVaoLam.Value.Date : (DateTime?)null
            };
            string plainPassword = txtMatKhau.Text;

            // Kiểm tra quyền hạn được phép gán
            string currentUserRole = CurrentUserContext.User?.Role ?? "";
            if (currentUserRole == "quan_ly_cua_hang" && nvData.QuyenHan != "nhan_vien") { MessageBox.Show("QLCH chỉ được thêm Nhân viên."); return; }
            if (currentUserRole == "quan_ly_khu_vuc" && (nvData.QuyenHan == "quan_ly_khu_vuc" || nvData.QuyenHan == "admin")) { MessageBox.Show("QLKV không được thêm quyền cao hơn hoặc bằng."); return; }


            bool success = false; string msg = "";
            try
            {
                this.Cursor = Cursors.WaitCursor; this.Enabled = false; Application.DoEvents();
                var addedNV = _nhanVienService.AddNhanVien(nvData, plainPassword); // Chỉ gọi Add
                success = (addedNV != null);
                msg = success ? "Thêm mới nhân viên thành công!" : "Thêm mới nhân viên thất bại.";
                this.Enabled = true; this.Cursor = Cursors.Default;

                if (success) { MessageBox.Show(msg, "Thành công"); SaveComplete?.Invoke(this, new SaveCompleteEventArgs(true)); }
                else { MessageBox.Show(msg, "Lỗi"); SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false)); }
            }
            catch (ArgumentException argEx) { this.Enabled = true; this.Cursor = Cursors.Default; MessageBox.Show(argEx.Message, "Dữ liệu không hợp lệ"); }
            catch (Exception ex) { this.Enabled = true; this.Cursor = Cursors.Default; LogError("Lỗi thêm nhân viên", ex); MessageBox.Show($"Lỗi khi lưu: {ex.Message}"); }
        }

        // --- Xử lý Hủy ---
        private void BtnHuy_Click(object sender, EventArgs e) { CancelRequested?.Invoke(this, EventArgs.Empty); }

        /// <summary>
        /// Kiểm tra dữ liệu nhập trên form.
        /// </summary>
        private bool ValidateInput()
        {
            // Bỏ kiểm tra ComboBox Chi nhánh
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text)) { MessageBox.Show("Nhập Mã NV."); txtMaNhanVien.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text)) { MessageBox.Show("Nhập Tên NV."); txtTenNhanVien.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text)) { MessageBox.Show("Nhập Tài khoản."); txtTaiKhoan.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text)) { MessageBox.Show("Nhập Mật khẩu."); txtMatKhau.Focus(); return false; }
            if (txtMatKhau.Text != txtXacNhanMK.Text) { MessageBox.Show("Xác nhận MK không khớp."); txtXacNhanMK.Focus(); return false; }
            if (cmbQuyenHan.SelectedValue == null) { MessageBox.Show("Chọn Quyền hạn."); cmbQuyenHan.Focus(); return false; }
            if (cmbTrangThaiNV.SelectedValue == null) { MessageBox.Show("Chọn Trạng thái."); cmbTrangThaiNV.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && !Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^(0[3|5|7|8|9])+([0-9]{8})\b$")) { MessageBox.Show("SĐT không hợp lệ."); txtSoDienThoai.Focus(); return false; }
            return true;
        }

        // --- Helpers ---
        private void NumberValidation_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void EmployeeCode_KeyPress(object sender, KeyPressEventArgs e) { e.KeyChar = char.ToUpper(e.KeyChar); /* Thêm giới hạn ký tự nếu cần */ }
        private void AccountName_KeyPress(object sender, KeyPressEventArgs e) { /* Giới hạn ký tự cho tài khoản (vd: không dấu cách, không ký tự đặc biệt...) */}
        private void Log(string message) { Debug.WriteLine($"[FormThemNV] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormThemNV ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class
} // End Namespace