// FormAddMember.cs (Code-behind đầy đủ - Chỉ Thêm mới)
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
    // EventArgs (Nên đặt ở file riêng Models/EventArgs)
    // public class SaveCompleteEventArgs : EventArgs { public bool Success { get; } public SaveCompleteEventArgs(bool success) { Success = success; } }

    public partial class FormAddMember : UserControl // Kế thừa UserControl
    {
        private readonly IMemberService _memberService;
        private readonly ICuaHangService _cuaHangService; // Cần để lấy tên CH hiện tại

        // Không cần _memberToEdit và _isEditMode

        public event EventHandler<SaveCompleteEventArgs> SaveComplete;
        public event EventHandler CancelRequested;

        public FormAddMember()
        {
            InitializeComponent();
            try
            {
                _memberService = new MemberService();
                _cuaHangService = new CuaHangService();
            }
            catch (Exception ex) { LogError("Service Init", ex); this.Enabled = false; return; }

            AssignEventHandlers();
            this.Load += FormAddMember_Load;
        }

        private void AssignEventHandlers()
        {
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            txtSDT.KeyPress += NumberValidation_KeyPress;
            txtMaTV.KeyPress += MemberCode_KeyPress;
            txtHoTen.KeyPress += NameValidation_KeyPress;
            txtEmail.Leave += TxtEmail_Leave;
        }

        private void FormAddMember_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGioiTinhComboBox();
                // Không load Trạng thái vì mặc định là Active khi thêm
                ResetForm(); // Reset về trạng thái thêm mới
            }
            catch (Exception ex) { LogError("Lỗi FormAddMember_Load", ex); }
        }

        // Bỏ LoadMemberData(ViewModel)

        private void LoadGioiTinhComboBox()
        {
            // Tham chiếu control
            var cbo = this.Controls.Find("cboGioiTinh", true).FirstOrDefault() as Guna2ComboBox;
            if (cbo != null && cbo.DataSource == null)
            {
                var genders = new List<KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("", "(Chưa chọn)"), // Thêm lựa chọn trống
                    new KeyValuePair<string, string>("nam", "Nam"),
                    new KeyValuePair<string, string>("nu", "Nữ"),
                    new KeyValuePair<string, string>("khac", "Khác")
                };
                cbo.DataSource = new BindingSource(genders, null);
                cbo.DisplayMember = "Value"; cbo.ValueMember = "Key";
                cbo.SelectedIndex = 0; // Mặc định chưa chọn
            }
            else if (cbo == null) { LogError("Control 'cboGioiTinh' not found.", null); }
        }
        // Bỏ LoadTrangThaiComboBox vì không cần chọn khi thêm mới

        /// <summary>
        /// Reset form về trạng thái Thêm mới.
        /// </summary>
        private void ResetForm()
        {
            try
            {
                lblTitle.Text = "THÊM MỚI THÀNH VIÊN";
                // Tham chiếu control
                var txtHoTenCtrl = this.Controls.Find("txtHoTen", true).FirstOrDefault() as Guna2TextBox;
                var txtMaTVCtrl = this.Controls.Find("txtMaTV", true).FirstOrDefault() as Guna2TextBox;
                var txtEmailCtrl = this.Controls.Find("txtEmail", true).FirstOrDefault() as Guna2TextBox;
                var txtSDTCtrl = this.Controls.Find("txtSDT", true).FirstOrDefault() as Guna2TextBox;
                var cboGioiTinhCtrl = this.Controls.Find("cboGioiTinh", true).FirstOrDefault() as Guna2ComboBox;
                var dtpNgaySinhCtrl = this.Controls.Find("dtpNgaySinh", true).FirstOrDefault() as Guna2DateTimePicker;
                var txtGhiChuCtrl = this.Controls.Find("txtGhiChu", true).FirstOrDefault() as Guna2TextBox;
                var txtCHDangKyCtrl = this.Controls.Find("txtCHDangKy", true).FirstOrDefault() as Guna2TextBox;

                // Xóa trắng và đặt mặc định
                if (txtHoTenCtrl != null) txtHoTenCtrl.Clear();
                if (txtMaTVCtrl != null) { txtMaTVCtrl.Clear(); txtMaTVCtrl.ReadOnly = false; txtMaTVCtrl.PlaceholderText = "Để trống tự sinh hoặc nhập mã"; }
                if (txtEmailCtrl != null) txtEmailCtrl.Clear();
                if (txtSDTCtrl != null) txtSDTCtrl.Clear();
                if (cboGioiTinhCtrl != null) cboGioiTinhCtrl.SelectedIndex = 0; // Chưa chọn
                if (dtpNgaySinhCtrl != null) { dtpNgaySinhCtrl.Checked = false; dtpNgaySinhCtrl.Value = DateTime.Now.AddYears(-18).Date.ClampDateTime(dtpNgaySinhCtrl.MinDate, dtpNgaySinhCtrl.MaxDate); } // Gợi ý 18 tuổi
                if (txtGhiChuCtrl != null) txtGhiChuCtrl.Clear();

                // Hiển thị cửa hàng đăng ký hiện tại (không cho sửa)
                if (txtCHDangKyCtrl != null && CurrentUserContext.IsLoggedIn)
                {
                    txtCHDangKyCtrl.Text = CurrentUserContext.User.TenCuaHang ?? $"(ID: {CurrentUserContext.User.DefaultStoreId})";
                    txtCHDangKyCtrl.ReadOnly = true;
                }
                else if (txtCHDangKyCtrl != null)
                {
                    txtCHDangKyCtrl.Text = "(Không xác định)";
                    txtCHDangKyCtrl.ReadOnly = true;
                }

                txtHoTenCtrl?.Focus();
            }
            catch (Exception ex) { LogError("ResetForm", ex); MessageBox.Show("Lỗi reset form."); }
        }

        // --- Xử lý Lưu ---
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (_memberService == null) { MessageBox.Show("Lỗi Service Thành viên."); return; }

            int currentStoreId = CurrentUserContext.User?.DefaultStoreId ?? 0; // Lấy từ lớp static
            if (currentStoreId <= 0) { MessageBox.Show("Không xác định được cửa hàng đăng ký."); return; }

            // Tham chiếu control
            var txtHoTenCtrl = this.Controls.Find("txtHoTen", true).FirstOrDefault() as Guna2TextBox;
            var txtMaTVCtrl = this.Controls.Find("txtMaTV", true).FirstOrDefault() as Guna2TextBox;
            var txtEmailCtrl = this.Controls.Find("txtEmail", true).FirstOrDefault() as Guna2TextBox;
            var txtSDTCtrl = this.Controls.Find("txtSDT", true).FirstOrDefault() as Guna2TextBox;
            var cboGioiTinhCtrl = this.Controls.Find("cboGioiTinh", true).FirstOrDefault() as Guna2ComboBox;
            var dtpNgaySinhCtrl = this.Controls.Find("dtpNgaySinh", true).FirstOrDefault() as Guna2DateTimePicker;
            var txtGhiChuCtrl = this.Controls.Find("txtGhiChu", true).FirstOrDefault() as Guna2TextBox;

            // Thu thập dữ liệu
            var newMemberData = new MemberViewModel
            {
                Id = 0, // Thêm mới
                MaThanhVien = string.IsNullOrWhiteSpace(txtMaTVCtrl?.Text) ? null : txtMaTVCtrl.Text.Trim(), // Cho phép null để service tự sinh
                TenThanhVien = txtHoTenCtrl?.Text.Trim(),
                SoDienThoai = txtSDTCtrl?.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmailCtrl?.Text) ? null : txtEmailCtrl.Text.Trim(),
                NgaySinh = dtpNgaySinhCtrl.Value.Date,
                GioiTinh = cboGioiTinhCtrl?.SelectedValue?.ToString(),
                GhiChu = txtGhiChuCtrl?.Text.Trim(),
                IdCuaHangDangKy = currentStoreId, // Gán cửa hàng hiện tại
                                                  // Các trường còn lại sẽ lấy giá trị mặc định trong CSDL hoặc Service
                TrangThai = "active",
                CapDo = "Basic",
                ViTien = 0,
                DiemTichLuy = 0
            };

            bool success = false;
            try
            {
                this.Cursor = Cursors.WaitCursor; this.Enabled = false; Application.DoEvents();
                // Gọi RegisterMember hoặc AddMember
                var addedMember = _memberService.RegisterMember(newMemberData); // Giả sử dùng hàm này
                success = (addedMember != null);
                this.Enabled = true; this.Cursor = Cursors.Default;

                if (success) { MessageBox.Show("Thêm mới thành viên thành công!", "Thành công"); SaveComplete?.Invoke(this, new SaveCompleteEventArgs(true)); }
                else { MessageBox.Show("Thêm mới thành viên thất bại.", "Lỗi"); SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false)); }
            }
            catch (ArgumentException argEx) { this.Enabled = true; this.Cursor = Cursors.Default; MessageBox.Show(argEx.Message, "Dữ liệu không hợp lệ"); }
            catch (Exception ex) { this.Enabled = true; this.Cursor = Cursors.Default; LogError("Lỗi thêm thành viên", ex); MessageBox.Show($"Lỗi khi lưu: {ex.Message}"); }
        }

        // --- Xử lý Hủy ---
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            CancelRequested?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập trên form khi Thêm mới.
        /// </summary>
        private bool ValidateInput()
        {
            var txtHoTenCtrl = this.Controls.Find("txtHoTen", true).FirstOrDefault() as Guna2TextBox;
            var txtSDTCtrl = this.Controls.Find("txtSDT", true).FirstOrDefault() as Guna2TextBox;
            var txtEmailCtrl = this.Controls.Find("txtEmail", true).FirstOrDefault() as Guna2TextBox;
            var dtpNgaySinhCtrl = this.Controls.Find("dtpNgaySinh", true).FirstOrDefault() as Guna2DateTimePicker;

            if (txtHoTenCtrl != null && string.IsNullOrWhiteSpace(txtHoTenCtrl.Text)) { MessageBox.Show("Nhập Họ và tên."); txtHoTenCtrl.Focus(); return false; }
            if (txtSDTCtrl != null && string.IsNullOrWhiteSpace(txtSDTCtrl.Text)) { MessageBox.Show("Nhập Số điện thoại."); txtSDTCtrl.Focus(); return false; }
            if (txtSDTCtrl != null && !string.IsNullOrWhiteSpace(txtSDTCtrl.Text) && !Regex.IsMatch(txtSDTCtrl.Text.Trim(), @"^(0[3|5|7|8|9])+([0-9]{8})\b$")) { MessageBox.Show("Định dạng Số điện thoại không hợp lệ."); txtSDTCtrl.Focus(); return false; }
            if (txtEmailCtrl != null && !string.IsNullOrWhiteSpace(txtEmailCtrl.Text) && !Regex.IsMatch(txtEmailCtrl.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { MessageBox.Show("Định dạng Email không hợp lệ."); txtEmailCtrl.Focus(); return false; }
            if (dtpNgaySinhCtrl != null && dtpNgaySinhCtrl.Checked && dtpNgaySinhCtrl.Value.Date >= DateTime.Now.Date) { MessageBox.Show("Ngày sinh không hợp lệ."); dtpNgaySinhCtrl.Focus(); return false; }
            // Không cần validate các trường chỉ đọc hoặc tự động gán

            return true;
        }

        // --- Helpers ---
        private void NumberValidation_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void NameValidation_KeyPress(object sender, KeyPressEventArgs e) { /* Cho phép nhập tên */ }
        private void MemberCode_KeyPress(object sender, KeyPressEventArgs e) { e.KeyChar = char.ToUpper(e.KeyChar); /* Giới hạn ký tự nếu cần */ }
        private void AccountName_KeyPress(object sender, KeyPressEventArgs e) { /* Giới hạn ký tự */ }
        private void TxtEmail_Leave(object sender, EventArgs e) { /* Validate email */ }
        private void Log(string message) { Debug.WriteLine($"[FormAddMember] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormAddMember ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class

    // --- LỚP EXTENSION CHO DATETIME (Nên đặt ở file riêng) ---
    // public static class DateTimeExtensions { public static DateTime ClampDateTime(...) }

} // End Namespace