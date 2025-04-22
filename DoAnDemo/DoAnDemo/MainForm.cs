using System;
using DoAnDemo.HienThiGoc;
using System.Windows.Forms;
using DoAnDemo.Models;
using DoAnDemo.GiaoDichTrongNgay;

namespace DoAnDemo
{
    // Trong Form chính (Ví dụ: Form1.cs)
    public partial class MainForm : System.Windows.Forms.Form
    {
        private FormHienThi formHienThi;
        private FormThanhToan formThanhToan;
        private FormThongTinTV formThongTinTV;
        // Thêm biến cho FormDangKyTV
        private FormDangKyTV formDangKyTV;
        // Thêm biến cho FormGiaoDichNgay
        private FormGiaoDichNgay formGiaoDichNgay;
        private FormGiamGia formGiamGia; // Thêm biến instance

        public MainForm()
        {
            InitializeComponent();
            LoadHienThiControl(); // Load màn hình bán hàng ban đầu
            formHienThi.NavigateToMemberViewRequested += FormHienThi_NavigateToMemberViewRequested; // Lắng nghe sự kiện từ FormHienThi
            formThongTinTV = new FormThongTinTV();
            formGiaoDichNgay = new FormGiaoDichNgay();
            formThongTinTV.ShowRegisterMemberRequested += FormThongTinTV_ShowRegisterMemberRequested;
            formThongTinTV.NavigateBackRequested += FormThongTinTV_NavigateBackRequested; // Lắng nghe sự kiện từ FormThongTinTV
            formThongTinTV.ShowDiscountFormRequested += FormHienThi_ShowDiscountFormRequested; // Lắng nghe sự kiện giảm giá
            formGiaoDichNgay.NavigateBackRequested += FormGiaoDichNgay_NavigateBackRequested; // Lắng nghe sự kiện từ FormGiaoDichNgay
        }

        private void LoadHienThiControl()
        {
            panelMain.Controls.Clear(); // panelMain là Panel chứa UserControl
            if (formHienThi == null)
            {
                formHienThi = new FormHienThi();
                //formHienThi.Dock = DockStyle.Fill;
                // Gắn sự kiện NavigateToPaymentRequested
                formHienThi.NavigateToPaymentRequested += FormHienThi_NavigateToPaymentRequested;
                formHienThi.ShowDailyOrdersRequested += FormHienThi_ShowDailyOrdersRequested; // Lắng nghe sự kiện mới
                formHienThi.ShowDiscountFormRequested += FormHienThi_ShowDiscountFormRequested; // Lắng nghe sự kiện giảm giá
            }
            panelMain.Controls.Add(formHienThi);
            formHienThi.BringToFront();
        }

        private void LoadThanhToanControl(PaymentEventArgs paymentArgs)
        {
            panelMain.Controls.Clear();
            if (formThanhToan == null)
            {
                formThanhToan = new FormThanhToan();
                formThanhToan.Dock = DockStyle.Fill;
                // Gắn sự kiện quay lại và thanh toán xong
                formThanhToan.NavigateBackRequested += FormThanhToan_NavigateBackRequested;
                formThanhToan.PaymentCompleted += FormThanhToan_PaymentCompleted;
            }
            // Truyền dữ liệu vào FormThanhToan
            formThanhToan.LoadOrderData(paymentArgs);
            panelMain.Controls.Add(formThanhToan);
            formThanhToan.BringToFront();
        }

        // Xử lý sự kiện yêu cầu chuyển sang thanh toán từ FormHienThi
        private void FormHienThi_NavigateToPaymentRequested(object sender, PaymentEventArgs e)
        {
            LoadThanhToanControl(e); // Hiển thị màn hình thanh toán và truyền data
        }

        // Xử lý sự kiện yêu cầu quay lại từ FormThanhToan
        private void FormThanhToan_NavigateBackRequested(object sender, EventArgs e)
        {
            LoadHienThiControl(); // Quay lại màn hình bán hàng
        }

        // Xử lý sự kiện thanh toán thành công từ FormThanhToan
        private void FormThanhToan_PaymentCompleted(object sender, EventArgs e)
        {
            // Quay lại màn hình bán hàng và xóa đơn hàng tạm
            LoadHienThiControl();
            formHienThi?.ClearCurrentOrder(); // Gọi hàm xóa đơn hàng trên FormHienThi
        }

        // Phương thức hiển thị FormThongTinTV
        private void LoadMemberViewControl()
        {
            panelMain.Controls.Clear(); // panelMain là Panel chứa các UserControl
            if (formThongTinTV == null)
            {
                formThongTinTV = new FormThongTinTV();
                //formThongTinTV.Dock = DockStyle.Fill;
                // Lắng nghe sự kiện quay lại từ FormThongTinTV (Sẽ thêm vào FormThongTinTV sau)
                formThongTinTV.NavigateBackRequested += FormThongTinTV_NavigateBackRequested;
            }
            panelMain.Controls.Add(formThongTinTV);
            formThongTinTV.BringToFront();
            // Có thể gọi một hàm LoadData ban đầu cho formThongTinTV nếu cần
            // formThongTinTV.InitialLoad();
        }

        // Xử lý sự kiện yêu cầu mở màn hình thành viên
        private void FormHienThi_NavigateToMemberViewRequested(object sender, EventArgs e)
        {
            LoadMemberViewControl();
        }

        // Xử lý sự kiện yêu cầu quay lại từ FormThongTinTV
        private void FormThongTinTV_NavigateBackRequested(object sender, EventArgs e)
        {
            LoadHienThiControl(); // Quay lại màn hình bán hàng
        }

        // Xử lý sự kiện yêu cầu hiển thị form đăng ký
        private void FormThongTinTV_ShowRegisterMemberRequested(object sender, EventArgs e)
        {
            ShowRegisterMemberControl();
        }

        // Phương thức hiển thị UserControl Đăng ký
        private void ShowRegisterMemberControl(bool show = true)
        {
            if (show)
            {
                if (formDangKyTV == null)
                {
                    formDangKyTV = new FormDangKyTV();
                    // Đặt kích thước mong muốn (có thể nhỏ hơn form chính)
                    //formDangKyTV.Size = new Size(550, 600); // Ví dụ
                    //                                        // Vị trí (ví dụ: căn giữa panelMain)
                    //formDangKyTV.Location = new Point(
                    //    (panelMain.ClientSize.Width - formDangKyTV.Width) / 2,
                    //    (panelMain.ClientSize.Height - formDangKyTV.Height) / 2);
                    formDangKyTV.Anchor = AnchorStyles.None; // Bỏ anchor để giữ vị trí

                    // Gắn sự kiện để biết khi nào form đăng ký đóng
                    formDangKyTV.RegistrationComplete += FormDangKyTV_RegistrationComplete;
                    formDangKyTV.RegistrationCancelled += FormDangKyTV_RegistrationCancelled;

                    // Thêm vào panel chính (hoặc panel overlay)
                    panelMain.Controls.Add(formDangKyTV);
                }
                formDangKyTV.BringToFront(); // Đưa lên trên cùng
                formDangKyTV.Visible = true;
                // Có thể làm mờ hoặc disable FormThongTinTV bên dưới nếu muốn
                // formThongTinTV.Enabled = false;
            }
            else // Ẩn form đăng ký
            {
                if (formDangKyTV != null)
                {
                    formDangKyTV.Visible = false;
                    // Có thể xóa control nếu không dùng lại thường xuyên:
                    // panelMain.Controls.Remove(formDangKyTV);
                    // formDangKyTV.Dispose();
                    // formDangKyTV = null;
                }
                // Enable lại form bên dưới
                // formThongTinTV.Enabled = true;
            }
        }

        // Xử lý khi đăng ký thành công
        private void FormDangKyTV_RegistrationComplete(object sender, MemberViewModel newMember) // Nhận TV mới nếu cần
        {
            ShowRegisterMemberControl(false); // Ẩn form đăng ký
            MessageBox.Show($"Đăng ký thành viên '{newMember?.TenThanhVien}' thành công!", "Thành công");
            // Tùy chọn: Tự động tìm kiếm và hiển thị thành viên vừa đăng ký trên FormThongTinTV
             //formThongTinTV.SearchAndDisplayMember(newMember?.SoDienThoai ?? "");
        }

        // Xử lý khi hủy đăng ký
        private void FormDangKyTV_RegistrationCancelled(object sender, EventArgs e)
        {
            ShowRegisterMemberControl(false); // Ẩn form đăng ký
        }

        // Phương thức hiển thị FormGiaoDichNgay
        private void LoadDailyOrdersControl()
        {
            panelMain.Controls.Clear(); // panelMain là Panel chứa UserControl
            if (formGiaoDichNgay == null || formGiaoDichNgay.IsDisposed) // Kiểm tra nếu đã dispose
            {
                formGiaoDichNgay = new FormGiaoDichNgay();
                formGiaoDichNgay.Dock = DockStyle.Fill;
                // Lắng nghe sự kiện quay lại từ FormGiaoDichNgay (Sẽ thêm vào FormGiaoDichNgay sau)
                formGiaoDichNgay.NavigateBackRequested += FormGiaoDichNgay_NavigateBackRequested;
            }
            panelMain.Controls.Add(formGiaoDichNgay);
            formGiaoDichNgay.BringToFront();
            formGiaoDichNgay.LoadOrders(); // Gọi hàm tải dữ liệu khi hiển thị
        }

        // Xử lý sự kiện yêu cầu hiển thị đơn trong ngày
        private void FormHienThi_ShowDailyOrdersRequested(object sender, EventArgs e)
        {
            LoadDailyOrdersControl();
        }

        // Xử lý sự kiện yêu cầu quay lại từ FormGiaoDichNgay
        private void FormGiaoDichNgay_NavigateBackRequested(object sender, EventArgs e)
        {
            LoadHienThiControl(); // Quay lại màn hình bán hàng
        }

        // Hàm hiển thị FormGiamGia (Tương tự ShowRegisterMemberControl)
        private void ShowDiscountControl(ShowDiscountEventArgs args, bool show = true)
        {
            if (show)
            {
                if (formGiamGia == null || formGiamGia.IsDisposed)
                {
                    formGiamGia = new FormGiamGia();
                    // Kích thước và vị trí như trong ảnh bạn gửi
                    formGiamGia.Anchor = AnchorStyles.None;

                    // Gắn sự kiện từ FormGiamGia
                    formGiamGia.DiscountApplied += FormGiamGia_DiscountApplied;
                    formGiamGia.DiscountCancelled += FormGiamGia_DiscountCancelled;

                    panelMain.Controls.Add(formGiamGia);
                }
                formGiamGia.LoadApplicableDiscounts(args); // Load dữ liệu giảm giá
                formGiamGia.BringToFront();
                formGiamGia.Visible = true;
                // formHienThi.Enabled = false; // Disable form dưới nếu muốn
            }
            else
            {
                if (formGiamGia != null) formGiamGia.Visible = false;
                formHienThi.Enabled = true; // Enable lại form dưới
                formGiamGia = null; // Xóa nếu không cần dùng lại
            }
        }

        // Handler khi FormHienThi yêu cầu mở form giảm giá
        private void FormHienThi_ShowDiscountFormRequested(object sender, ShowDiscountEventArgs e)
        {
            ShowDiscountControl(e, true);
        }

        // Handler khi FormGiamGia xác nhận áp dụng giảm giá
        private void FormGiamGia_DiscountApplied(object sender, DiscountInfo e)
        {
            ShowDiscountControl(null, false); // Ẩn form giảm giá
            formHienThi?.ApplyDiscount(e);    // Gọi hàm cập nhật trên FormHienThi
        }

        // Handler khi FormGiamGia hủy
        private void FormGiamGia_DiscountCancelled(object sender, EventArgs e)
        {
            ShowDiscountControl(null, false); // Ẩn form giảm giá
        }
    }
}
