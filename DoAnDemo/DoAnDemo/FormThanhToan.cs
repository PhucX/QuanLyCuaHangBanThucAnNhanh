using DoAnDemo.Models;                     
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DoAnDemo.Utils;

namespace DoAnDemo // Hoặc namespace phù hợp với project của bạn
{
    public partial class FormThanhToan : UserControl
    {
        // --- Private fields để lưu trữ dữ liệu đơn hàng và trạng thái thanh toán ---
        private List<OrderItemViewModel> _orderItemsToPay;
        private decimal _totalAmountDue; // Tổng tiền phải trả (đã bao gồm giảm giá, phí...)
        private int _storeId;

        // --- Thông tin ngữ cảnh (CẦN LẤY TỪ LOGIC THỰC TẾ) ---
        private int _currentEmployeeId = CurrentUserContext.User.EmployeeId;
        private int? _memberId = null;
        private string _tableCode = "Mang đi";
        private string _orderType = "mang_di";

        // --- Trạng thái thanh toán hiện tại ---
        private string _selectedPaymentMethod = "Cash"; // Mặc định là tiền mặt
        private decimal _amountEntered = 0; // Số tiền khách nhập/đưa (Numpad/Quick Amount)
        private CultureInfo _viVNCulture = new CultureInfo("vi-VN"); // Culture cho format tiền tệ VNĐ

        // --- Services (Nên dùng Dependency Injection) ---
        private readonly IPaymentProcessingService _paymentProcessingService;

        // --- Events cho Navigation ---
        public event EventHandler NavigateBackRequested; // Yêu cầu quay lại màn hình trước (FormHienThi)
        public event EventHandler PaymentCompleted;    // Thông báo thanh toán thành công

        // --- Constructor ---
        public FormThanhToan()
        {
            InitializeComponent();

            // Khởi tạo services (Nên dùng Dependency Injection cho dự án lớn)
            _paymentProcessingService = new PaymentProcessingService();

            // Gán các sự kiện cho control
            AssignEventHandlers();
        }

        // --- Public Method để nhận dữ liệu từ FormHienThi ---
        /// <summary>
        /// Nạp dữ liệu đơn hàng cần thanh toán vào Form.
        /// </summary>
        /// <param name="paymentArgs">Dữ liệu chứa danh sách món và tổng tiền.</param>
        public void LoadOrderData(PaymentEventArgs paymentArgs)
        {
            if (paymentArgs == null)
            {
                // Xử lý trường hợp không có dữ liệu (ví dụ: quay lại, báo lỗi)
                MessageBox.Show("Không có dữ liệu đơn hàng để thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NavigateBackRequested?.Invoke(this, EventArgs.Empty); // Yêu cầu quay lại
                return;
            }

            // Lưu trữ dữ liệu nhận được
            _orderItemsToPay = paymentArgs.OrderItems ?? new List<OrderItemViewModel>(); // Đảm bảo không null
            _totalAmountDue = paymentArgs.TotalAmount;
            _storeId = paymentArgs.StoreId;

            // --- Cập nhật giao diện ---
            DisplayInitialData(); // Hiển thị tổng tiền, mã bàn...
            _amountEntered = _totalAmountDue; // Mặc định tiền khách đưa = tổng tiền (có thể đổi thành 0)
            UpdatePaymentDisplay(); // Cập nhật các ô hiển thị tiền
            SelectDefaultPaymentMethod(); // Chọn phương thức thanh toán mặc định (Cash)
        }

        // --- Private Methods ---

        /// <summary>
        /// Gán các phương thức xử lý sự kiện cho các control trên Form.
        /// </summary>
        private void AssignEventHandlers()
        {
            // Nút quay lại/về menu chính
            btnBack.Click += BtnBack_Click;
            btnGoToMainMenu.Click += BtnGoToMainMenu_Click;

            // Nút chọn phương thức thanh toán
            btnCash.Click += PaymentMethodButton_Click;
            btnBankTransfer.Click += PaymentMethodButton_Click;
            btnGrabPay.Click += PaymentMethodButton_Click;
            btnVnPay.Click += PaymentMethodButton_Click;
            btnOnAccount.Click += PaymentMethodButton_Click;
            btnOthers.Click += PaymentMethodButton_Click;
            btnCredit.Click += PaymentMethodButton_Click;
            // Gán Tag cho các nút để dễ nhận biết khi xử lý (có thể làm trong Designer)
            btnCash.Tag = "tien_mat";
            btnBankTransfer.Tag = "chuyen_khoan";
            btnCredit.Tag = "the"; // Thẻ tín dụng/ghi nợ
            btnGrabPay.Tag = "vi_dien_tu"; // Hoặc 'khac' nếu muốn phân biệt rõ hơn
            btnVnPay.Tag = "vi_dien_tu";   // Hoặc 'khac'
            btnOnAccount.Tag = "khac";        // Ghi nợ (OnAccount) thường không có sẵn, dùng 'khac'? Hoặc thêm vào DB nếu cần
            btnOthers.Tag = "khac";


            // Nút Numpad
            btnNum0.Click += NumpadButton_Click;
            btnNum1.Click += NumpadButton_Click;
            btnNum2.Click += NumpadButton_Click;
            btnNum3.Click += NumpadButton_Click;
            btnNum4.Click += NumpadButton_Click;
            btnNum5.Click += NumpadButton_Click;
            btnNum6.Click += NumpadButton_Click;
            btnNum7.Click += NumpadButton_Click;
            btnNum8.Click += NumpadButton_Click;
            btnNum9.Click += NumpadButton_Click;
            btnDelete.Click += BtnDelete_Click;

            // Nút chọn nhanh số tiền
            btnAmount10k.Click += QuickAmountButton_Click;
            btnAmount20k.Click += QuickAmountButton_Click;
            btnAmount50k.Click += QuickAmountButton_Click;
            btnAmount100k.Click += QuickAmountButton_Click;
            btnAmount200k.Click += QuickAmountButton_Click;
            btnAmount500k.Click += QuickAmountButton_Click;

            // Nút chọn tiền tệ (Tạm thời chưa xử lý logic chuyển đổi)
            btnVND.Click += CurrencyButton_Click;
            btnUSD.Click += CurrencyButton_Click;
            btnTHB.Click += CurrencyButton_Click;

            // Nút Thanh toán cuối cùng
            btnThanhToanFinal.Click += BtnThanhToanFinal_Click;
        }

        /// <summary>
        /// Hiển thị các dữ liệu ban đầu lên giao diện khi Form được load hoặc nhận dữ liệu mới.
        /// </summary>
        private void DisplayInitialData()
        {
            lblSummaryAmount.Text = _totalAmountDue.ToString("C0", _viVNCulture);
            lblBanCodeValue.Text = _tableCode ?? "N/A"; // Hiển thị mã bàn hoặc "N/A"
            // !!! Cần logic lấy và hiển thị giảm giá thực tế nếu có
            lblGiamGiaValue.Text = (0m).ToString("C0", _viVNCulture);

            // Tạm ẩn các phần không cần thiết ban đầu
            lblCashTitle.Visible = false;
            lblCashAmount1.Visible = false;
            lblCashAmount2.Visible = false;
            lblQRCodeTitle.Visible = false;
            guna2PictureBoxQR.Visible = false; // Ẩn QR code mặc định
        }

        /// <summary>
        /// Chọn và highlight phương thức thanh toán mặc định (Cash).
        /// </summary>
        private void SelectDefaultPaymentMethod()
        {
            SelectPaymentMethod(btnCash);
        }

        /// <summary>
        /// Cập nhật hiển thị số tiền khách đưa và tiền thối lại.
        /// </summary>
        private void UpdatePaymentDisplay()
        {
            // Hiển thị số tiền khách nhập/đưa (format không có chữ VND)
            txtDisplayAmount.Text = _amountEntered.ToString("N0", _viVNCulture);
            // Hiển thị tiền khách đưa (format có chữ VND)
            lblTienKhachDuaValue.Text = _amountEntered.ToString("C0", _viVNCulture);

            // Tính và hiển thị tiền thối (không âm)
            decimal changeDue = Math.Max(0, _amountEntered - _totalAmountDue);
            lblSoTienTraValue.Text = changeDue.ToString("C0", _viVNCulture);
        }

        /// <summary>
        /// Xử lý giao diện khi một nút phương thức thanh toán được chọn.
        /// </summary>
        /// <param name="selectedButton">Nút được chọn.</param>
        private void SelectPaymentMethod(Guna2Button selectedButton)
        {
            if (selectedButton == null || selectedButton.Tag == null) return;

            _selectedPaymentMethod = selectedButton.Tag.ToString(); // Lưu lại phương thức được chọn từ Tag

            // Đặt lại giao diện cho tất cả các nút phương thức
            foreach (Control ctrl in guna2PanelLeft.Controls)
            {
                if (ctrl is Guna2Button btn && btn.Tag != null && ctrl != btnGoToMainMenu)
                {
                    btn.FillColor = Color.WhiteSmoke;
                    btn.ForeColor = Color.DimGray;
                    btn.Checked = false; // Đảm bảo chỉ có 1 nút được check (visual)
                }
            }

            // Highlight nút được chọn
            selectedButton.FillColor = Color.FromArgb(200, 54, 96);
            selectedButton.ForeColor = Color.White;
            selectedButton.Checked = true;

            // --- Logic hiển thị/ẩn UI tùy chọn ---
            bool showQR = (_selectedPaymentMethod == "VNPAY" || _selectedPaymentMethod == "Bank Transfer");
            guna2PictureBoxQR.Visible = showQR;
            lblQRCodeTitle.Visible = showQR;
            if (showQR)
            {
                // !!! Cần logic tạo và hiển thị mã QR thực tế vào guna2PictureBoxQR !!!
                // Ví dụ: guna2PictureBoxQR.Image = GenerateQRCode(_totalAmountDue, _storeId);
            }

            // Có thể hiển thị thông tin tiền mặt chi tiết nếu chọn Cash
            lblCashTitle.Visible = (_selectedPaymentMethod == "Cash");
            lblCashAmount1.Visible = (_selectedPaymentMethod == "Cash");
            lblCashAmount2.Visible = (_selectedPaymentMethod == "Cash");
            if (_selectedPaymentMethod == "Cash")
            {
                lblCashAmount1.Text = _totalAmountDue.ToString("C0", _viVNCulture);
                lblCashAmount2.Text = _totalAmountDue.ToString("C0", _viVNCulture);
            }
        }

        // --- Event Handlers ---

        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BtnGoToMainMenu_Click(object sender, EventArgs e)
        {
            // Có thể có logic khác hoặc giống nút Back tùy yêu cầu
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void PaymentMethodButton_Click(object sender, EventArgs e)
        {
            SelectPaymentMethod(sender as Guna2Button);
        }

        private void NumpadButton_Click(object sender, EventArgs e)
        {
            var button = sender as Guna2Button;
            if (button == null) return;

            string digit = button.Text;
            string currentAmountStr = _amountEntered.ToString("F0"); // Lấy chuỗi không có dấu phẩy

            // Ngăn nhập số 0 nếu đang là 0
            if (currentAmountStr == "0" && digit == "0") return;
            // Nếu đang là 0, thay thế bằng số mới (trừ khi số mới cũng là 0)
            if (currentAmountStr == "0") currentAmountStr = "";

            // Giới hạn độ dài để tránh tràn số (ví dụ: 15 chữ số)
            if (currentAmountStr.Length >= 15) return;

            string newAmountStr = currentAmountStr + digit;

            if (decimal.TryParse(newAmountStr, NumberStyles.Any, _viVNCulture, out decimal newAmount))
            {
                _amountEntered = newAmount;
                UpdatePaymentDisplay();
            }
            // Có thể thêm thông báo lỗi nếu nhập không hợp lệ
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string currentAmountStr = _amountEntered.ToString("F0");
            if (currentAmountStr.Length > 0)
            {
                currentAmountStr = currentAmountStr.Substring(0, currentAmountStr.Length - 1); // Xóa ký tự cuối
                if (string.IsNullOrEmpty(currentAmountStr))
                {
                    _amountEntered = 0;
                }
                // Thử parse lại chuỗi sau khi xóa
                else if (decimal.TryParse(currentAmountStr, NumberStyles.Any, _viVNCulture, out decimal newAmount))
                {
                    _amountEntered = newAmount;
                }
                else // Nếu sau khi xóa chuỗi không hợp lệ thì về 0
                {
                    _amountEntered = 0;
                }
                UpdatePaymentDisplay();
            }
            else // Nếu đang là 0 thì không làm gì
            {
                _amountEntered = 0;
                UpdatePaymentDisplay();
            }
        }

        private void QuickAmountButton_Click(object sender, EventArgs e)
        {
            var button = sender as Guna2Button;
            if (button == null) return;

            string amountStr = button.Text.Replace(".", "").Replace(",", ""); // Xóa các dấu phân cách
            if (decimal.TryParse(amountStr, NumberStyles.Any, _viVNCulture, out decimal quickAmount))
            {
                _amountEntered = quickAmount;
                UpdatePaymentDisplay();
            }
        }

        private void CurrencyButton_Click(object sender, EventArgs e)
        {
            // Hiện tại chưa xử lý chuyển đổi tiền tệ
            MessageBox.Show("Chức năng chọn/chuyển đổi tiền tệ chưa được hỗ trợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Nếu cần, đây là nơi để cập nhật UI các nút tiền tệ và gọi logic tính toán lại tỷ giá
        }

        private void BtnThanhToanFinal_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu cơ bản
            if (_orderItemsToPay == null || !_orderItemsToPay.Any())
            {
                MessageBox.Show("Không có sản phẩm nào để thanh toán.", "Lỗi Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Chỉ kiểm tra tiền khách đưa với tiền mặt
            if (_selectedPaymentMethod == "Cash" && _amountEntered < _totalAmountDue)
            {
                MessageBox.Show("Số tiền khách đưa không đủ.", "Lỗi Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Chuẩn bị DTO với dữ liệu đầy đủ nhất có thể
            decimal changeDue = (_selectedPaymentMethod == "Cash") ? Math.Max(0, _amountEntered - _totalAmountDue) : 0m; // Chỉ tính tiền thối cho tiền mặt
            decimal subTotal = _orderItemsToPay.Sum(i => i.DonGia * i.SoLuong);

            // !!! BỔ SUNG LOGIC TÍNH TOÁN THỰC TẾ CHO CÁC MỤC DƯỚI ĐÂY !!!
            decimal discountTotal = 0m; // Lấy từ voucher, khuyến mãi, điểm thành viên...
            decimal feeTotal = 0m;      // Lấy từ cài đặt phụ phí...
            decimal vatAmount = 0m;     // Tính VAT nếu có...
            int pointsEarned = (int)(subTotal / 1000); // Ví dụ điểm tích lũy
            int pointsSpent = 0;        // Nếu thanh toán bằng điểm
            decimal amountReducedByPoints = 0m; // Số tiền giảm từ điểm

            var orderInfo = new OrderPaymentInfo
            {
                Items = _orderItemsToPay,
                TotalAmountDue = _totalAmountDue, // Tổng cuối cùng cần thu
                AmountPaidByCustomer = _amountEntered, // Số tiền nhập trên form
                ChangeDue = changeDue,             // Tiền thối (nếu có)
                PaymentMethod = _selectedPaymentMethod, // Phương thức đã chọn
                StoreId = _storeId,
                EmployeeId = _currentEmployeeId,      // Cần lấy ID nhân viên đúng
                OrderType = _orderType,           // Cần lấy loại đơn hàng đúng
                MemberId = _memberId,             // Cần lấy ID thành viên đúng (nếu có)
                TableCode = _tableCode,           // Cần lấy mã bàn/đơn đúng (nếu có)
                SubTotal = subTotal,              // Tổng tiền hàng gốc
                DiscountTotal = discountTotal,    // Tổng giảm giá thực tế
                FeeTotal = feeTotal,              // Tổng phụ phí thực tế
                VatAmount = vatAmount,            // Thuế VAT thực tế
                PointsEarned = pointsEarned,      // Điểm tích lũy thực tế
                PointsSpent = pointsSpent,        // Điểm đã dùng thực tế
                AmountReducedByPoints = amountReducedByPoints, // Tiền giảm từ điểm thực tế
                CustomerNote = "",                // Lấy từ control ghi chú nếu có
                InternalNote = ""                 // Lấy từ control ghi chú nội bộ nếu có
            };

            // 3. Gọi Service để xử lý nghiệp vụ và lưu CSDL
            try
            {
                // Vô hiệu hóa UI và hiển thị trạng thái chờ
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor; // Đổi con trỏ chuột
                Application.DoEvents();           // Cập nhật UI

                // Gọi service xử lý
                bool paymentSuccess = _paymentProcessingService.ProcessOrderAndPayment(orderInfo);

                // Bật lại UI
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                // 4. Xử lý kết quả
                if (paymentSuccess)
                {
                    string successMessage = "Thanh toán thành công!";
                    if (changeDue > 0)
                    {
                        successMessage += $"\nTiền thối: {changeDue.ToString("C0", _viVNCulture)}";
                    }
                    MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- Cân nhắc: In hóa đơn ở đây ---

                    // Kích hoạt sự kiện báo thành công để Form cha xử lý (quay lại FormHienThi và xóa đơn hàng tạm)
                    PaymentCompleted?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Xử lý thanh toán thất bại. Dữ liệu chưa được lưu. Vui lòng kiểm tra và thử lại.", "Lỗi Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) // Bắt các lỗi không mong muốn từ BLL hoặc DAL
            {
                // Bật lại UI nếu có lỗi
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                MessageBox.Show($"Đã xảy ra lỗi nghiêm trọng trong quá trình thanh toán:\n{ex.Message}\n\nVui lòng liên hệ bộ phận kỹ thuật.", "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Ghi log chi tiết lỗi (bao gồm cả StackTrace: ex.ToString()) để debug
                Console.WriteLine($"Payment Processing Error: {ex.ToString()}");
            }
        }
    }
}