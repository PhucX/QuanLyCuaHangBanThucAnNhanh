using DoAnDemo.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDemo // Hoặc namespace phù hợp
{
    public partial class DonHangCard : UserControl
    {
        private OrderSummaryViewModel _currentOrder; // Lưu trữ thông tin đơn hàng hiện tại của card này

        // --- Định nghĩa các sự kiện để giao tiếp với Form cha ---
        /// <summary>
        /// Sự kiện được kích hoạt khi người dùng click vào card (truyền ID đơn hàng).
        /// </summary>
        public event EventHandler<int> CardClicked;
        /// <summary>
        /// Sự kiện được kích hoạt khi nhấn nút "ĐÁNH LỖI" (truyền ID đơn hàng).
        /// </summary>
        public event EventHandler<int> PrintErrorRequested;
        /// <summary>
        /// Sự kiện được kích hoạt khi nhấn nút "IN" (truyền ID đơn hàng).
        /// </summary>
        public event EventHandler<int> PrintRequested;

        public DonHangCard()
        {
            InitializeComponent();
            AssignEventHandlers();
        }

        /// <summary>
        /// Gán các phương thức xử lý sự kiện cho control.
        /// </summary>
        private void AssignEventHandlers()
        {
            btnAction1.Click += BtnAction1_Click; // Nút ĐÁNH LỖI
            btnAction2.Click += BtnAction2_Click; // Nút IN

            // Gán sự kiện Click cho cả card và các thành phần bên trong nó
            // để khi người dùng click vào đâu trên card cũng kích hoạt sự kiện CardClicked
            this.Click += Card_Click;
            guna2PanelCard.Click += Card_Click;
            panelItems.Click += Card_Click;
            lblDateTime.Click += Card_Click;
            lblOrderID.Click += Card_Click;
            lblPaymentMethod.Click += Card_Click;
            lblTotalAmount.Click += Card_Click;
            lblItemName1.Click += Card_Click; // Gán cho các label item nếu có
            lblItemQty1.Click += Card_Click;
            lblItemName2.Click += Card_Click;
            lblItemQty2.Click += Card_Click;

        }

        /// <summary>
        /// Gán dữ liệu từ OrderSummaryViewModel vào các control trên card.
        /// </summary>
        /// <param name="order">ViewModel chứa dữ liệu đơn hàng.</param>
        public void SetData(OrderSummaryViewModel order)
        {
            if (order == null) return;
            _currentOrder = order; // Lưu lại để dùng khi xử lý sự kiện

            CultureInfo viVNCulture = new CultureInfo("vi-VN");

            // Hiển thị thông tin cơ bản
            lblOrderID.Text = $"# {order.MaDonHang}";
            lblDateTime.Text = order.ThoiGianDat.ToString("dd/MM - HH:mm");
            lblPaymentMethod.Text = FormatPaymentMethod(order.HinhThucThanhToan);
            lblTotalAmount.Text = order.ThanhTien.ToString("C0", viVNCulture);

            // Hiển thị danh sách món ăn rút gọn (dùng các label cố định)
            DisplayItemSnippet(order.ItemsSnippet);

            // Cập nhật trạng thái nút bấm
            UpdateActionButtons(order.TrangThaiDonHang);
        }

        /// <summary>
        /// Hiển thị tối đa 2 món ăn đầu tiên vào các label cố định.
        /// </summary>
        private void DisplayItemSnippet(List<OrderItemSnippetViewModel> items)
        {
            // Xóa text cũ
            lblItemName1.Text = ""; lblItemQty1.Text = "";
            lblItemName2.Text = ""; lblItemQty2.Text = "";
            lblItemName1.Visible = false; lblItemQty1.Visible = false;
            lblItemName2.Visible = false; lblItemQty2.Visible = false;
            // Có thể thêm một label "..." và ẩn nó đi ban đầu
            // lblMoreItems.Visible = false;

            if (items != null)
            {
                if (items.Count > 0)
                {
                    lblItemName1.Text = items[0].TenSanPham;
                    lblItemQty1.Text = items[0].SoLuong.ToString();
                    lblItemName1.Visible = true; lblItemQty1.Visible = true;
                }
                if (items.Count > 1)
                {
                    lblItemName2.Text = items[1].TenSanPham;
                    lblItemQty2.Text = items[1].SoLuong.ToString();
                    lblItemName2.Visible = true; lblItemQty2.Visible = true;
                }
                if (items.Count > 2)
                {
                    // Hiển thị dấu "..." nếu có nhiều hơn 2 món
                    // lblMoreItems.Visible = true;
                    // Hoặc sửa text của món thứ 2 thành "..."
                    lblItemName2.Text += "...";
                }
            }
            else // Trường hợp list item là null hoặc rỗng
            {
                lblItemName1.Text = "(Lỗi tải chi tiết)";
                lblItemName1.Visible = true;
            }
        }

        /// <summary>
        /// Chuyển đổi mã hình thức thanh toán từ DB thành dạng text dễ đọc.
        /// </summary>
        private string FormatPaymentMethod(string dbValue)
        {
            if (string.IsNullOrEmpty(dbValue))
                return "Chưa TT";
            else if (dbValue == "tien_mat")
                return "Tiền mặt";
            else if (dbValue == "the")
                return "Thẻ";
            else if (dbValue == "vi_dien_tu")
                return "Ví ĐT";
            else if (dbValue == "chuyen_khoan")
                return "Chuyển khoản";
            else if (dbValue == "vi_thanh_vien")
                return "Ví TV";
            else if (dbValue == "khac")
                return "Khác";
            else
                return dbValue; // Trả về giá trị gốc nếu không khớp

        }

        /// <summary>
        /// Cập nhật trạng thái (Enabled/Visible) và Text của các nút Action.
        /// </summary>
        private void UpdateActionButtons(string orderStatus)
        {
            // Ví dụ: Chỉ cho phép thao tác với đơn 'hoan_thanh' hoặc 'dang_chuan_bi'...
            bool canPrintError = (orderStatus == "hoan_thanh"); // Chỉ đánh lỗi đơn hoàn thành?
            bool canPrint = (orderStatus == "hoan_thanh" || orderStatus == "dang_chuan_bi"); // Có thể in nhiều trạng thái?

            btnAction1.Enabled = canPrintError; // Nút ĐÁNH LỖI
            btnAction2.Enabled = canPrint;    // Nút IN

            // Bạn có thể thay đổi Text của nút nếu muốn, ví dụ:
            // if (orderStatus == "da_huy") { btnAction1.Text = "Đã Hủy"; btnAction1.Enabled = false; btnAction2.Enabled = false; }
            // else { btnAction1.Text = "ĐÁNH LỖI"; btnAction2.Text = "IN"; }
        }

        // --- Event Handlers ---

        /// <summary>
        /// Xử lý khi click vào bất kỳ đâu trên card.
        /// </summary>
        private void Card_Click(object sender, EventArgs e)
        {
            if (_currentOrder != null)
            {
                // Kích hoạt sự kiện CardClicked và truyền ID đơn hàng
                CardClicked?.Invoke(this, _currentOrder.IdDonHang);
            }
        }

        /// <summary>
        /// Xử lý khi nhấn nút "ĐÁNH LỖI".
        /// </summary>
        private void BtnAction1_Click(object sender, EventArgs e)
        {
            if (_currentOrder != null)
            {
                // Kích hoạt sự kiện PrintErrorRequested và truyền ID đơn hàng
                PrintErrorRequested?.Invoke(this, _currentOrder.IdDonHang);
                // Logic xử lý cụ thể (hiện dialog xác nhận, gọi service...) sẽ nằm ở Form cha (FormGiaoDichNgay)
            }
        }

        /// <summary>
        /// Xử lý khi nhấn nút "IN".
        /// </summary>
        private void BtnAction2_Click(object sender, EventArgs e)
        {
            if (_currentOrder != null)
            {
                // Kích hoạt sự kiện PrintRequested và truyền ID đơn hàng
                PrintRequested?.Invoke(this, _currentOrder.IdDonHang);
                // Logic xử lý cụ thể (lấy chi tiết đơn hàng, tạo file in...) sẽ nằm ở Form cha (FormGiaoDichNgay)
            }
        }
    }
}