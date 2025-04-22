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
using System.Text.RegularExpressions; // Cho validation
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDemo // Hoặc namespace phù hợp
{
    public partial class FormDangKyTV : UserControl
    {
        // Services
        private readonly IMemberService _memberService;
        private readonly ICuaHangService _cuaHangService;

        // Events
        public event EventHandler<MemberViewModel> RegistrationComplete; // Gửi thông tin TV mới khi thành công
        public event EventHandler RegistrationCancelled;

        public FormDangKyTV()
        {
            InitializeComponent();

            // Khởi tạo Services (Nên dùng Dependency Injection)
            _memberService = new MemberService();
            _cuaHangService = new CuaHangService();

            // Gán sự kiện
            btnLuu.Click += BtnLuu_Click;
            btnCancel.Click += BtnCancel_Click;
            this.Load += FormDangKyTV_Load;
        }

        private void FormDangKyTV_Load(object sender, EventArgs e)
        {
            LoadCuaHangComboBox();
            // Thiết lập giá trị mặc định khác nếu cần
            cmbGioiTinh.SelectedIndex = -1; // Không chọn gì ban đầu
            dtpNgaySinh.Value = DateTime.Now; // Đặt ngày hiện tại
            dtpNgaySinh.Checked = false; // Bỏ check mặc định
        }

        /// <summary>
        /// Tải danh sách cửa hàng vào ComboBox.
        /// </summary>
        private void LoadCuaHangComboBox()
        {
            try
            {
                var stores = _cuaHangService.GetActiveStores();
                cmbCuaHangDK.DataSource = stores;
                cmbCuaHangDK.DisplayMember = "TenCuaHang";
                cmbCuaHangDK.ValueMember = "Id";
                cmbCuaHangDK.SelectedIndex = -1; // Không chọn gì ban đầu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách cửa hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Ghi log
            }
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu nhập.
        /// </summary>
        /// <returns>True nếu hợp lệ, False nếu không.</returns>
        private bool ValidateInput()
        {
            // Clear error messages (Nếu dùng ErrorProvider)

            // 1. Kiểm tra Tên (Bắt buộc)
            if (string.IsNullOrWhiteSpace(txtTenThanhVien.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thành viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThanhVien.Focus();
                return false;
            }

            // 2. Kiểm tra SĐT (Bắt buộc và định dạng cơ bản)
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }
            // Regex kiểm tra SĐT Việt Nam đơn giản (có thể cần phức tạp hơn)
            if (!Regex.IsMatch(txtSoDienThoai.Text, @"^(0[3|5|7|8|9])+([0-9]{8})\b$"))
            {
                MessageBox.Show("Định dạng số điện thoại không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }


            // 3. Kiểm tra Email (Không bắt buộc nhưng nếu nhập phải đúng định dạng)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                // Regex kiểm tra Email đơn giản
                if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Định dạng email không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            // 4. Kiểm tra Ngày sinh (Nếu chọn thì không được là ngày tương lai)
            if (dtpNgaySinh.Checked && dtpNgaySinh.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không thể là ngày trong tương lai.", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }


            // Các kiểm tra khác nếu cần (Mã TV nếu nhập, Cửa hàng nếu bắt buộc...)

            return true; // Tất cả hợp lệ
        }


        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return; // Dừng lại nếu dữ liệu không hợp lệ
            }

            // Thu thập dữ liệu từ Form
            var newMember = new MemberViewModel
            {
                TenThanhVien = txtTenThanhVien.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                MaThanhVien = string.IsNullOrWhiteSpace(txtMaThanhVien.Text) ? null : txtMaThanhVien.Text.Trim(),
                //NgaySinh = dtpNgaySinh.Checked ? dtpNgaySinh.Value.Date : (DateTime?)null,
                NgaySinh = dtpNgaySinh.Value.Date,
                //GioiTinh = cmbGioiTinh.SelectedItem?.ToString() switch // Map giá trị ComboBox sang giá trị DB
                //{
                //    "Nam" => "nam",
                //    "Nữ" => "nu",
                //    "Khác" => "khac",
                //    _ => null // Hoặc giá trị mặc định nếu không chọn
                //},
                GioiTinh = "nam",
                // Lấy ID cửa hàng từ ComboBox (ValueMember là "Id")
                IdCuaHangDangKy = (cmbCuaHangDK.SelectedValue != null && cmbCuaHangDK.SelectedIndex != -1) ? (int)cmbCuaHangDK.SelectedValue : (int?)null,
                GhiChu = txtGhiChu.Text.Trim()
            };

            // Gọi Service để đăng ký
            try
            {
                this.Enabled = false; // Disable form tạm thời
                Application.DoEvents();

                MemberViewModel registeredMember = _memberService.RegisterMember(newMember);

                this.Enabled = true;

                if (registeredMember != null) // Đăng ký thành công (Service trả về thông tin TV mới)
                {
                    // Kích hoạt sự kiện báo thành công và gửi thông tin TV mới
                    RegistrationComplete?.Invoke(this, registeredMember);
                    // Không cần MessageBox ở đây vì Form cha sẽ xử lý
                    // ResetForm(); // Có thể xóa trắng form sau khi lưu thành công
                }
                else
                {
                    // Trường hợp này ít xảy ra nếu service dùng throw cho lỗi CSDL/logic
                    MessageBox.Show("Đăng ký thành viên thất bại. Nguyên nhân không xác định.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException argEx) // Bắt lỗi validation từ Service (ví dụ: SĐT trùng)
            {
                this.Enabled = true;
                MessageBox.Show(argEx.Message, "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) // Bắt các lỗi khác từ Service (ví dụ: lỗi CSDL)
            {
                this.Enabled = true;
                MessageBox.Show($"Đã xảy ra lỗi khi đăng ký: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Registration Error: {ex.ToString()}"); // Ghi log chi tiết
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện báo hủy
            RegistrationCancelled?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Xóa trắng các trường trên form.
        /// </summary>
        private void ResetForm()
        {
            txtTenThanhVien.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtMaThanhVien.Clear();
            dtpNgaySinh.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            cmbGioiTinh.SelectedIndex = -1;
            cmbCuaHangDK.SelectedIndex = -1;
            txtGhiChu.Clear();
            txtTenThanhVien.Focus();
        }
    }
}