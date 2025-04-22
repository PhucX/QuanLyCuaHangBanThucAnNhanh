// FormEditMember.cs (Code-behind đầy đủ, kế thừa UserControl)
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

namespace DoAnDemo.Form.FormAdmin // Namespace theo yêu cầu
{
    public partial class FormEditMember : UserControl // <<< Kế thừa UserControl
    {
        // --- Services ---
        private readonly IMemberService _memberService;
        private readonly ICuaHangService _cuaHangService;

        // --- State ---
        private MemberViewModel _memberToEdit = null; // Chỉ lưu thông tin Member cần sửa

        // --- Events ---
        public event EventHandler<SaveCompleteEventArgs> SaveComplete;
        public event EventHandler CancelRequested;

        // --- Constructor ---
        public FormEditMember()
        {
            InitializeComponent();
            try
            {
                _memberService = new MemberService();
                _cuaHangService = new CuaHangService();
            }
            catch (Exception ex) { LogError("Service Init", ex); this.Enabled = false; return; }

            AssignEventHandlers();
            this.Load += FormEditMember_Load;
        }

        private void FormEditMember_Load(object sender, EventArgs e)
        {
            // Load dữ liệu tĩnh cho ComboBox
            LoadGioiTinhComboBox();
            LoadTrangThaiComboBox();
            // PopulateForm sẽ được gọi bởi LoadMemberData
        }

        /// <summary>
        /// Gán các phương thức xử lý sự kiện cho controls.
        /// </summary>
        private void AssignEventHandlers()
        {
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            // Gán KeyPress hoặc Leave event cho validation nếu cần
            txtHoTen.KeyPress += NameValidation_KeyPress;
            txtSDT.KeyPress += NumberValidation_KeyPress;
            txtEmail.Leave += TxtEmail_Leave;
            // btnResetPassword.Click += BtnResetPassword_Click; // Gắn sự kiện nếu nút này được dùng
        }

        /// <summary>
        /// Load dữ liệu thành viên cần sửa vào form.
        /// </summary>
        public void LoadMemberData(MemberViewModel memberData)
        {
            if (memberData == null || memberData.Id <= 0)
            {
                LogError("LoadMemberData called with invalid data.", null);
                MessageBox.Show("Dữ liệu thành viên không hợp lệ để sửa.", "Lỗi");
                CancelRequested?.Invoke(this, EventArgs.Empty); // Yêu cầu đóng form
                return;
            }
            _memberToEdit = memberData;
            PopulateForm(); // Điền dữ liệu lên form
        }

        // --- Load ComboBox ---
        private void LoadGioiTinhComboBox()
        {
            if (cboGioiTinh.DataSource == null)
            {
                var genders = new List<KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("", "(Chưa chọn)"), new KeyValuePair<string, string>("nam", "Nam"),
                    new KeyValuePair<string, string>("nu", "Nữ"), new KeyValuePair<string, string>("khac", "Khác")
                };
                cboGioiTinh.DataSource = new BindingSource(genders, null);
                cboGioiTinh.DisplayMember = "Value"; cboGioiTinh.ValueMember = "Key";
            }
        }
        private void LoadTrangThaiComboBox()
        {
            if (cboTrangThai.DataSource == null)
            {
                var statuses = new List<KeyValuePair<string, string>>() {
                     new KeyValuePair<string, string>("active", "Hoạt động"),
                     new KeyValuePair<string, string>("inactive", "Ngưng hoạt động"),
                     new KeyValuePair<string, string>("banned", "Bị khóa")
                 };
                cboTrangThai.DataSource = new BindingSource(statuses, null);
                cboTrangThai.DisplayMember = "Value"; cboTrangThai.ValueMember = "Key";
            }
        }

        /// <summary>
        /// Điền dữ liệu từ _memberToEdit lên các control.
        /// </summary>
        private void PopulateForm()
        {
            if (_memberToEdit == null) return;
            try
            {
                lblTitle.Text = $"CẬP NHẬT TV: {_memberToEdit.TenThanhVien} ({_memberToEdit.SoDienThoai})";
                txtHoTen.Text = _memberToEdit.TenThanhVien;
                txtMaTV.Text = _memberToEdit.MaThanhVien ?? "(chưa có)"; txtMaTV.ReadOnly = true;
                txtEmail.Text = _memberToEdit.Email;
                txtSDT.Text = _memberToEdit.SoDienThoai;
                cboGioiTinh.SelectedValue = _memberToEdit.GioiTinh ?? "";
                dtpNgaySinh.Value = _memberToEdit.NgaySinh.ClampDateTime(dtpNgaySinh.MinDate, dtpNgaySinh.MaxDate);
                //dtpNgaySinh.Checked = _memberToEdit.NgaySinh.HasValue;
                txtDiem.Text = _memberToEdit.DiemTichLuy.ToString("N0"); txtDiem.ReadOnly = true;
                //txtSoDu.Text = _memberToEdit.ViTien.ToString("N0") + " VND"; 
                //txtSoDu.ReadOnly = true;
                cboTrangThai.SelectedValue = _memberToEdit.TrangThai;
                txtCapDo.Text = _memberToEdit.CapDo; txtCapDo.ReadOnly = true;
                txtGhiChu.Text = _memberToEdit.GhiChu;

                if (_memberToEdit.IdCuaHangDangKy.HasValue && _cuaHangService != null)
                {
                    var store = _cuaHangService.GetStoreById(_memberToEdit.IdCuaHangDangKy.Value);
                    txtCHDangKy.Text = store?.TenCuaHang ?? $"(ID: {_memberToEdit.IdCuaHangDangKy.Value})";
                }
                else { txtCHDangKy.Text = "(Không có)"; }
                txtCHDangKy.ReadOnly = true;
                if (cmbCuaHangDK != null) cmbCuaHangDK.Visible = false; // Ẩn ComboBox Cửa hàng đăng ký

                // Các trường không có trong CSDL thì reset hoặc ẩn đi
                // Ví dụ: txtHanMucThe.Clear(); txtDiaChi.Clear();...

                txtHoTen.Focus();
            }
            catch (Exception ex) { LogError("PopulateForm Edit Member", ex); MessageBox.Show("Lỗi hiển thị thông tin thành viên."); }
        }

        // --- Xử lý Lưu ---
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (_memberToEdit == null) return;
            if (!ValidateInput()) return;
            if (_memberService == null) { MessageBox.Show("Lỗi Service Thành viên."); return; }

            // Thu thập dữ liệu từ các trường *được phép sửa*
            var updatedMemberData = new MemberViewModel
            {
                Id = _memberToEdit.Id,
                MaThanhVien = _memberToEdit.MaThanhVien,
                TenThanhVien = txtHoTen.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = cboGioiTinh.SelectedValue?.ToString(),
                TrangThai = cboTrangThai.SelectedValue?.ToString(),
                GhiChu = txtGhiChu.Text.Trim(),
                ViTien = _memberToEdit.ViTien, DiemTichLuy = _memberToEdit.DiemTichLuy, CapDo = _memberToEdit.CapDo, IdCuaHangDangKy = _memberToEdit.IdCuaHangDangKy
            };

            bool success = false; string msg = "";
            try
            {
                this.Cursor = Cursors.WaitCursor; this.Enabled = false; Application.DoEvents();
                success = _memberService.UpdateMember(updatedMemberData); // Gọi Update Service
                this.Enabled = true; this.Cursor = Cursors.Default;
                msg = success ? "Cập nhật thành viên thành công!" : "Cập nhật thành viên thất bại.";
                MessageBox.Show(msg, success ? "Thành công" : "Lỗi", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                SaveComplete?.Invoke(this, new SaveCompleteEventArgs(success)); // Báo hiệu cho Form cha
            }
            catch (ArgumentException argEx) { this.Enabled = true; this.Cursor = Cursors.Default; MessageBox.Show(argEx.Message, "Dữ liệu không hợp lệ"); SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false)); }
            catch (Exception ex) { this.Enabled = true; this.Cursor = Cursors.Default; LogError("Lỗi cập nhật thành viên", ex); MessageBox.Show($"Lỗi khi lưu: {ex.Message}"); SaveComplete?.Invoke(this, new SaveCompleteEventArgs(false)); }
        }

        // --- Xử lý Hủy ---
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            CancelRequested?.Invoke(this, EventArgs.Empty); // Kích hoạt sự kiện hủy
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập trên form khi Sửa.
        /// </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) { MessageBox.Show("Nhập Họ và tên."); txtHoTen.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtSDT.Text)) { MessageBox.Show("Nhập Số điện thoại."); txtSDT.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtSDT.Text) && !Regex.IsMatch(txtSDT.Text.Trim(), @"^(0[3|5|7|8|9])+([0-9]{8})\b$")) { MessageBox.Show("Định dạng Số điện thoại không hợp lệ."); txtSDT.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { MessageBox.Show("Định dạng Email không hợp lệ."); txtEmail.Focus(); return false; }
            if (dtpNgaySinh.Checked && dtpNgaySinh.Value.Date >= DateTime.Now.Date) { MessageBox.Show("Ngày sinh không hợp lệ."); dtpNgaySinh.Focus(); return false; }
            if (cboTrangThai.SelectedValue == null) { MessageBox.Show("Chọn Trạng thái."); cboTrangThai.Focus(); return false; }
            return true;
        }

        // --- Helpers ---
        private void NumberValidation_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void NameValidation_KeyPress(object sender, KeyPressEventArgs e) { /* Cho phép nhập tên */ }
        private void TxtEmail_Leave(object sender, EventArgs e) { /* Có thể validate email ở đây */ }
        private void Log(string message) { Debug.WriteLine($"[FormEditMember] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormEditMember ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class

} // End Namespace