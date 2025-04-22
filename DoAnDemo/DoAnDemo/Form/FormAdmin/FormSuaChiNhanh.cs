// FormSuaChiNhanh.cs (Code-behind đầy đủ)
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.Core; // Using cho WebView2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormSuaChiNhanh : UserControl
    {
        private readonly ICuaHangService _cuaHangService;
        private StoreViewModel _storeToEdit;
        private bool _isEditMode => _storeToEdit != null && _storeToEdit.Id > 0;
        private bool _isWebViewInitialized = false;

        // Events
        public event EventHandler<SaveCompleteEventArgs> SaveComplete;
        public event EventHandler CancelRequested;

        // Constructor
        public FormSuaChiNhanh()
        {
            InitializeComponent();
            try { _cuaHangService = new CuaHangService(); } catch (Exception ex) { LogError("Service Init", ex); MessageBox.Show("Lỗi khởi tạo service."); this.Enabled = false; return; }
            AssignEventHandlers();
            this.Load += FormSuaChiNhanh_Load;
        }

        private async void FormSuaChiNhanh_Load(object sender, EventArgs e)
        {
            await InitializeWebViewAsync();
            LoadTrangThaiComboBox();
            // PopulateForm() sẽ được gọi bởi LoadStoreData
        }

        private void AssignEventHandlers()
        {
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click; // Gọi hàm riêng để raise event
            txtSoDienThoai1.KeyPress += NumberValidation_KeyPress; // Chỉ cho nhập số ở SĐT
            // Gán thêm các event khác nếu cần
        }

        /// <summary>
        /// Khởi tạo CoreWebView2 bất đồng bộ.
        /// </summary>
        private async Task InitializeWebViewAsync()
        {
            if (!_isWebViewInitialized && webViewMap != null && webViewMap.CoreWebView2 == null)
            {
                try
                {
                    Log("Initializing WebView2...");
                    await webViewMap.EnsureCoreWebView2Async(null);
                    if (webViewMap.CoreWebView2 != null)
                    {
                        _isWebViewInitialized = true; Log("WebView2 Initialized.");
                        await LoadMapAddressAsync(_isEditMode ? _storeToEdit?.DiaChi : "");
                    }
                    else { LogError("WebView2 CoreWebView2 is null after EnsureCoreWebView2Async.", null); }
                }
                catch (Exception ex) { LogError("Lỗi khởi tạo WebView2", ex); webViewMap.Visible = false; }
            }
            else if (webViewMap?.CoreWebView2 != null) { _isWebViewInitialized = true; Log("WebView2 already initialized."); }
            else { LogError("Control 'webViewMap' not found or invalid.", null); }
        }

        /// <summary>
        /// Nạp dữ liệu chi nhánh vào form và tải bản đồ.
        /// </summary>
        public async void LoadStoreData(StoreViewModel storeData) // Thêm async
        {
            _storeToEdit = storeData;
            PopulateForm();
            if (!_isWebViewInitialized) await InitializeWebViewAsync();
            await LoadMapAddressAsync(_isEditMode ? _storeToEdit?.DiaChi : "");
        }

        // --- Load dữ liệu lên Form ---
        private void LoadTrangThaiComboBox()
        {
            try
            {
                if (cmbTrangThai.DataSource == null)
                {
                    var statusList = new List<KeyValuePair<string, string>>() {
                         new KeyValuePair<string, string>("dang_hoat_dong", "Đang hoạt động"),
                         new KeyValuePair<string, string>("tam_ngung", "Tạm ngưng"),
                         new KeyValuePair<string, string>("sap_khai_truong", "Sắp khai trương"),
                         // new KeyValuePair<string, string>("da_dong_cua", "Đã đóng cửa")
                     };
                    cmbTrangThai.DataSource = new BindingSource(statusList, null);
                    cmbTrangThai.DisplayMember = "Value"; cmbTrangThai.ValueMember = "Key";
                }
                cmbTrangThai.SelectedValue = "dang_hoat_dong"; // Mặc định
            }
            catch (Exception ex) { LogError("LoadTrangThaiComboBox", ex); }
        }

        /// <summary>
        /// Điền dữ liệu từ ViewModel lên các control của form.
        /// </summary>
        private void PopulateForm()
        {
            try
            {
                if (_isEditMode && _storeToEdit != null)
                {
                    lblTitle.Text = "CẬP NHẬT THÔNG TIN CHI NHÁNH";
                    txtTenHienThi.Text = _storeToEdit.TenCuaHang;
                    txtDiaChiDatHang.Text = _storeToEdit.DiaChi;
                    txtSoDienThoai1.Text = _storeToEdit.SoDienThoai;
                    txtKhuVuc.Text = _storeToEdit.KhuVuc;
                    cmbTrangThai.SelectedValue = _storeToEdit.TrangThai;
                    // Mã CH không hiển thị
                }
                else // Thêm mới
                {
                    lblTitle.Text = "THÊM MỚI CHI NHÁNH";
                    txtTenHienThi.Clear(); txtDiaChiDatHang.Clear(); txtSoDienThoai1.Clear();
                    txtKhuVuc.Clear();
                    cmbTrangThai.SelectedValue = "dang_hoat_dong";
                    // Xóa các trường không liên quan khác
                    cboQuocGia.SelectedIndex = 0; cboThanhPho.SelectedIndex = 0;
                    txtSoDienThoai2.Clear(); txtWifiPassword.Clear(); txtMoTa.Clear();
                    chkCauHinhGio.Checked = false; rbApDungTatCaNgay.Checked = true;
                    txtGioMoCua.Text = "00 : 00"; txtGioDongCua.Text = "00 : 01";
                    txtTenHienThi.Focus();
                }
            }
            catch (Exception ex) { LogError("PopulateForm", ex); MessageBox.Show("Lỗi hiển thị dữ liệu chi nhánh."); }
        }

        /// <summary>
        /// Tải bản đồ dựa trên địa chỉ bằng WebView2.
        /// </summary>
        private async Task LoadMapAddressAsync(string address)
        {
            if (!_isWebViewInitialized || webViewMap == null || webViewMap.CoreWebView2 == null) { Log("WebView not ready for map."); return; }
            if (string.IsNullOrWhiteSpace(address)) { Log("Address empty, show blank map."); webViewMap.CoreWebView2.Navigate("about:blank"); return; }
            try
            {
                string encodedAddress = Uri.EscapeDataString(address);
                string mapUrl = $"https://www.google.com/maps/search/{encodedAddress}";
                Log($"Navigating WebView2 to: {mapUrl}");

                await Task.Delay(100);
                webViewMap.CoreWebView2.Navigate(mapUrl);
            }
            catch (Exception ex) { LogError($"Lỗi điều hướng WebView2 đến '{address}'", ex); }
        }

        // --- Xử lý Lưu ---
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return; // Kiểm tra nhập liệu
            if (_cuaHangService == null) { MessageBox.Show("Lỗi Service Cửa hàng."); return; }

            // Tham chiếu control
            var txtKhuVucCtrl = this.Controls.Find("txtKhuVuc", true).FirstOrDefault() as Guna2TextBox;
            var cmbTrangThaiCtrl = this.Controls.Find("cmbTrangThai", true).FirstOrDefault() as Guna2ComboBox;

            // Thu thập dữ liệu vào ViewModel
            var storeData = new StoreViewModel
            {
                Id = _isEditMode ? _storeToEdit.Id : 0, // *** Lấy ID nếu là Sửa ***
                MaCuaHang = _isEditMode ? _storeToEdit.MaCuaHang : null, // *** Giữ mã cũ khi sửa, service sẽ tự sinh khi thêm ***
                TenCuaHang = txtTenHienThi.Text.Trim(),
                DiaChi = txtDiaChiDatHang.Text.Trim(),
                SoDienThoai = txtSoDienThoai1.Text.Trim(),
                KhuVuc = txtKhuVucCtrl?.Text.Trim(),
                TrangThai = cmbTrangThaiCtrl?.SelectedValue?.ToString() ?? "dang_hoat_dong"
            };

            bool success = false;
            string successMessage = "";
            string failureMessage = "";

            try
            {
                this.Cursor = Cursors.WaitCursor; this.Enabled = false; Application.DoEvents();

                // *** KIỂM TRA _isEditMode ĐỂ GỌI ĐÚNG HÀM SERVICE ***
                if (_isEditMode)
                {
                    Log($"Attempting to UPDATE store ID: {storeData.Id}");
                    success = _cuaHangService.UpdateStore(storeData); // Gọi Update
                    successMessage = "Cập nhật chi nhánh thành công!";
                    failureMessage = "Cập nhật chi nhánh thất bại.";
                }
                else
                {
                    Log($"Attempting to ADD new store: {storeData.TenCuaHang}");
                    success = _cuaHangService.AddStore(storeData); // Gọi Add (đã sửa trả về bool)
                    successMessage = "Thêm mới chi nhánh thành công!";
                    failureMessage = "Thêm mới chi nhánh thất bại.";
                    // Không cần gán lại _storeToEdit vì form này chỉ dùng 1 lần rồi đóng
                }

                this.Enabled = true; this.Cursor = Cursors.Default;

                if (success)
                {
                    MessageBox.Show(successMessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(true)); // Báo thành công
                }
                else
                {
                    MessageBox.Show(failureMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false)); // Báo thất bại
                }
            }
            catch (ArgumentException argEx) { this.Enabled = true; this.Cursor = Cursors.Default; MessageBox.Show(argEx.Message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { this.Enabled = true; this.Cursor = Cursors.Default; LogError($"Lỗi lưu chi nhánh (IsEdit: {_isEditMode})", ex); MessageBox.Show($"Đã xảy ra lỗi khi lưu: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        // --- Xử lý Hủy ---
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            CancelRequested?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập trên form.
        /// </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenHienThi.Text)) { MessageBox.Show("Nhập Tên chi nhánh."); txtTenHienThi.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtDiaChiDatHang.Text)) { MessageBox.Show("Nhập Địa chỉ."); txtDiaChiDatHang.Focus(); return false; }
            if (cmbTrangThai.SelectedValue == null) { MessageBox.Show("Chọn Trạng thái."); cmbTrangThai.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtKhuVuc.Text)) { MessageBox.Show("Nhập Khu vực."); txtKhuVuc.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtSoDienThoai1.Text) && !Regex.IsMatch(txtSoDienThoai1.Text.Trim(), @"^[0-9\s\-\+\(\)]*$")) { MessageBox.Show("Số điện thoại không hợp lệ."); txtSoDienThoai1.Focus(); return false; }
            return true;
        }

        /// <summary>
        /// Chỉ cho phép nhập số và phím control.
        /// </summary>
        private void NumberValidation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        /// <summary>
        /// Chỉ cho phép nhập ký tự phù hợp cho Mã Voucher (Ví dụ).
        /// </summary>
        private void VoucherCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-') e.Handled = true;
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        // --- Hàm Ghi Log ---
        private void Log(string message) { Debug.WriteLine($"[FormSuaChiNhanh] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormSuaChiNhanh ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class

    // --- LỚP EXTENSION CHO DATETIME (Nên đặt ở file riêng) ---
    public static class DateTimeExtensions
    {
        public static DateTime ClampDateTime(this DateTime dt, DateTime min, DateTime max)
        {
            if (dt < min) return min;
            if (dt > max) return max;
            return dt;
        }
    }
} // End Namespace