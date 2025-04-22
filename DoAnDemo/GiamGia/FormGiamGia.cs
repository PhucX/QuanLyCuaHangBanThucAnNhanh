using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;      // Namespace chứa DiscountInfo, ShowDiscountEventArgs, OrderItemViewModel
using DoAnDemo.GiamGia;   // Namespace chứa DiscountButtonCard
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

namespace DoAnDemo // Hoặc namespace phù hợp
{
    public partial class FormGiamGia : UserControl
    {
        private readonly IDiscountService _discountService;
        private ShowDiscountEventArgs _currentOrderContext;
        private DiscountInfo _selectedDiscount = null;

        /// <summary>
        /// Kích hoạt khi người dùng xác nhận áp dụng một giảm giá. Gửi kèm DiscountInfo (hoặc null nếu không chọn/hủy).
        /// </summary>
        public event EventHandler<DiscountInfo> DiscountApplied;
        /// <summary>
        /// Kích hoạt khi người dùng nhấn nút Thoát.
        /// </summary>
        public event EventHandler DiscountCancelled;
        public event EventHandler NavigateBackRequested;
        public event EventHandler<DiscountInfo> DiscountSelected;

        public FormGiamGia()
        {
            InitializeComponent();
            _discountService = new DiscountService(); // Nên dùng DI
            AssignEventHandlers();
        }

        private void AssignEventHandlers()
        {
            btnThoat.Click += (s, e) => DiscountCancelled?.Invoke(this, EventArgs.Empty);
            btnXacNhan.Click += BtnXacNhan_Click;
            txtMaVoucher.KeyDown += TxtMaVoucher_KeyDown;
            // Khi người dùng bắt đầu nhập mã, bỏ chọn card
            txtMaVoucher.TextChanged += (s, e) => ClearCardSelection();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void DiscountButton_Click(object sender, DiscountInfo discountInfo)
        {
            DiscountSelected?.Invoke(this, discountInfo);
        }

        /// <summary>
        /// Tải các giảm giá/voucher có thể áp dụng dựa trên thông tin đơn hàng.
        /// </summary>
        public void LoadApplicableDiscounts(ShowDiscountEventArgs args)
        {
            _currentOrderContext = args;
            _selectedDiscount = null;
            txtMaVoucher.Clear();
            flowLayoutPanelDiscounts.SuspendLayout();
            flowLayoutPanelDiscounts.Controls.Clear();

            if (_currentOrderContext == null)
            {
                flowLayoutPanelDiscounts.ResumeLayout();
                MessageBox.Show("Thiếu thông tin đơn hàng để tải giảm giá.");
                DiscountCancelled?.Invoke(this, EventArgs.Empty); // Tự động đóng nếu lỗi
                return;
            }

            try
            {
                // Gọi service lấy danh sách giảm giá phù hợp
                var discounts = _discountService.GetApplicableDiscounts(
                    _currentOrderContext.SubTotal,
                    _currentOrderContext.MemberId,
                    _currentOrderContext.StoreId,
                    _currentOrderContext.Items);

                if (discounts != null && discounts.Any())
                {
                    foreach (var discount in discounts)
                    {
                        var card = new DiscountButtonCard();
                        card.SetData(discount);
                        card.Selected += DiscountCard_Selected; // Gắn sự kiện
                        flowLayoutPanelDiscounts.Controls.Add(card);
                    }
                }
                else
                {
                    Label lblNoDiscounts = new Label { Text = "Không có giảm giá nào phù hợp.", AutoSize = true, ForeColor = Color.Gray, Margin = new Padding(10) };
                    flowLayoutPanelDiscounts.Controls.Add(lblNoDiscounts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách giảm giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Load Discounts Error: {ex.ToString()}");
            }
            finally
            {
                flowLayoutPanelDiscounts.ResumeLayout();
            }
        }

        /// <summary>
        /// Xử lý khi một DiscountButtonCard được chọn.
        /// </summary>
        private void DiscountCard_Selected(object sender, DiscountInfo selectedDiscountInfo)
        {
            _selectedDiscount = selectedDiscountInfo;
            txtMaVoucher.Clear(); // Xóa mã nhập tay nếu chọn card

            // Bỏ chọn các card khác và highlight card được chọn
            foreach (Control ctrl in flowLayoutPanelDiscounts.Controls)
            {
                if (ctrl is DiscountButtonCard card)
                {
                    card.IsSelected = (card == sender);
                }
            }
        }

        /// <summary>
        /// Bỏ trạng thái chọn của tất cả các card.
        /// </summary>
        private void ClearCardSelection()
        {
            if (_selectedDiscount != null) // Chỉ thực hiện nếu đang có card được chọn
            {
                _selectedDiscount = null;
                foreach (Control ctrl in flowLayoutPanelDiscounts.Controls)
                {
                    if (ctrl is DiscountButtonCard card) card.IsSelected = false;
                }
            }
        }

        /// <summary>
        /// Xử lý khi nhấn Enter trong ô nhập mã voucher.
        /// </summary>
        private void TxtMaVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnXacNhan_Click(sender, e);
                e.SuppressKeyPress = true; // Ngăn tiếng beep
            }
            // Event TextChanged đã xử lý việc bỏ chọn card
        }

        /// <summary>
        /// Xử lý khi nhấn nút Xác nhận.
        /// </summary>
        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            DiscountInfo discountToApply = _selectedDiscount;

            // Nếu không chọn card, kiểm tra mã nhập tay
            if (discountToApply == null && !string.IsNullOrWhiteSpace(txtMaVoucher.Text))
            {
                if (_currentOrderContext == null)
                {
                    MessageBox.Show("Lỗi: Thiếu thông tin đơn hàng để kiểm tra mã voucher."); return;
                }
                try
                {
                    this.Cursor = Cursors.WaitCursor; // Hiển thị chờ
                    discountToApply = _discountService.ValidateAndGetVoucher(
                        txtMaVoucher.Text.Trim(), _currentOrderContext.SubTotal,
                        _currentOrderContext.MemberId, _currentOrderContext.StoreId,
                        _currentOrderContext.Items);
                    this.Cursor = Cursors.Default;

                    if (discountToApply == null)
                    {
                        MessageBox.Show($"Mã voucher '{txtMaVoucher.Text.Trim()}' không hợp lệ hoặc không áp dụng được.", "Voucher không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Nếu mã hợp lệ, tự động chọn card tương ứng nếu có (tùy chọn)
                    foreach (Control ctrl in flowLayoutPanelDiscounts.Controls)
                    {
                        if (ctrl is DiscountButtonCard card && card.GetDiscountInfo()?.Id == discountToApply.Id) // So sánh theo ID hoặc Mã
                        {
                            card.IsSelected = true;
                            _selectedDiscount = discountToApply; // Cập nhật lại _selectedDiscount
                        }
                        else if (ctrl is DiscountButtonCard cardVisual)
                        {
                            cardVisual.IsSelected = false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show($"Lỗi kiểm tra mã voucher: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"Voucher Validation Error: {ex.ToString()}");
                    return;
                }
            }

            // Kích hoạt sự kiện DiscountApplied, gửi kèm discount đã chọn (hoặc null nếu không chọn gì)
            DiscountApplied?.Invoke(this, discountToApply);
        }
    }
}