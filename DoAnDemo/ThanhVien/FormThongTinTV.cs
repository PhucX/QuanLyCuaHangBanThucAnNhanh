using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;      // Namespace chứa các ViewModel, DiscountInfo, EventArgs
using DoAnDemo.GiamGia;   // Namespace chứa DiscountButtonCard (Đảm bảo namespace đúng)
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
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using DoAnDemo.HienThiGoc;

namespace DoAnDemo // Hoặc namespace phù hợp
{
    public partial class FormThongTinTV : UserControl
    {
        // --- Services ---
        private readonly IMemberService _memberService;
        private readonly IGiftService _giftService;
        private readonly IProductService _productService;
        private readonly IDiscountService _discountService;
        // private readonly ICuaHangService _cuaHangService;

        // --- Configuration / State ---
        private int _currentStoreId = 1; // !!! LẤY ID CỬA HÀNG ĐÚNG !!!
        private MemberViewModel _currentSelectedMember = null;
        private List<OrderItemViewModel> _orderItemsRightPanel;
        private DiscountInfo _appliedDiscountInfoRightPanel = null;
        private string _selectedOrderTypeRightPanel = "tai_cho";

        // --- Events ---
        public event EventHandler NavigateBackRequested;
        public event EventHandler<ShowDiscountEventArgs> ShowDiscountFormRequested;
        public event EventHandler ShowRegisterMemberRequested;
        public event EventHandler<PaymentEventArgs> NavigateToPaymentRequestedRight;

        // --- Constructor ---
        public FormThongTinTV()
        {
            InitializeComponent();

            _memberService = new MemberService();
            _giftService = new GiftService();
            _productService = new ProductService();
            _discountService = new DiscountService();

            _orderItemsRightPanel = new List<OrderItemViewModel>();

            AssignEventHandlers();
            ClearMemberInfo();
            // ClearOrderSummaryRight(); // Đã gọi trong ClearMemberInfo
            // SelectDefaultOrderTypeRight(); // Đã gọi trong ClearMemberInfo
        }

        /// <summary>
        /// Gán các phương thức xử lý sự kiện cho các control trên Form.
        /// </summary>
        private void AssignEventHandlers()
        {
            // Nút điều hướng Top Bar
            btnBack.Click += (s, e) => NavigateBackRequested?.Invoke(this, EventArgs.Empty);
            btnCloseMemberInfo.Click += (s, e) => ClearMemberInfo(); // Nút 'X' ở panel giữa

            // Tìm kiếm & Chức năng Top Bar
            txtSearchMember.KeyDown += TxtSearchMember_KeyDown;
            btnQuickSearch.Click += BtnQuickSearch_Click;
            btnScanQR.Click += BtnScanQR_Click;
            btnFilter.Click += BtnFilter_Click;
            btnRegister.Click += (s, e) => ShowRegisterMemberRequested?.Invoke(this, EventArgs.Empty);

            // Nút chức năng cho thành viên đang chọn (Top Bar phải)
            btnNoteMember.Click += BtnNoteMember_Click;
            btnDiscountMember.Click += BtnDiscountMember_Click;
            btnDeleteMember.Click += BtnDeleteMember_Click;
            guna2ButtonMemberInfo.Click += BtnEditMember_Click; // Nút tên/sdt (Sửa TV)

            // Tab panel trái
            btnTongHop.Click += BtnTab_Click;
            btnNapTien.Click += BtnNapTien_Click;
            btnTongHop.Tag = "TongHop";
            btnNapTien.Tag = "NapTien";
            btnTongHop.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnNapTien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;


            // Panel Phải (Đơn hàng)
            btnAnTaiBan.Click += BtnOrderTypeRight_Click;
            btnMangDi.Click += BtnOrderTypeRight_Click;
            btnAnTaiBan.Tag = "tai_cho";
            btnMangDi.Tag = "mang_di";
            btnAnTaiBan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnMangDi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnDatMon.Click += BtnDatMonRight_Click;

            // Lưu ghi chú khi rời ô nhập
            txtMemberNote.Leave += TxtMemberNote_Leave;
        }

        // --- Tìm kiếm và Hiển thị Thông tin Thành viên ---
        private void TxtSearchMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSearchMember.Text))
            {
                SearchAndDisplayMember(txtSearchMember.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnQuickSearch_Click(object sender, EventArgs e)
        {
            SearchAndDisplayMember(txtSearchMember.Text);
        }

        private void SearchAndDisplayMember(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var members = _memberService.SearchMembers(keyword.Trim());
                if (members != null && members.Any()) { LoadMemberDetails(members.First()); }
                else { MessageBox.Show("Không tìm thấy thành viên.", "Thông báo"); ClearMemberInfo(); }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi"); ClearMemberInfo(); Console.WriteLine($"Search Member Error: {ex.ToString()}"); }
            finally { this.Cursor = Cursors.Default; }
        }

        private void ClearMemberInfo()
        {
            _currentSelectedMember = null;
            picProfile.Image = null; lblMemberNameLeft.Text = "Chưa chọn TV"; lblWalletValue.Text = "-";
            lblPointsValue.Text = "-"; lblLevelValue.Text = "-"; txtMemberNote.Text = ""; txtMemberNote.ReadOnly = true;
            picProfileMiddle.Image = null; lblMemberNameMiddle.Text = ""; btnCloseMemberInfo.Visible = false;
            ClearPanelContent(guna2PanelFavFood, lblFavFoodTitle, lblNoFavFood);
            ClearPanelContent(guna2PanelVouchers, lblVoucherTitle, null);
            ClearPanelContent(guna2PanelGifts, lblGiftsTitle, null);
            ClearOrderSummaryRight();
            SetMemberActionButtonsEnabled(false);
            btnTongHop.Checked = false; btnNapTien.Checked = false; // Reset tab selection
            txtSearchMember.Select();
        }

        private void LoadMemberDetails(MemberViewModel member)
        {
            if (member == null) { ClearMemberInfo(); return; }
            _currentSelectedMember = member;
            CultureInfo viVNCulture = new CultureInfo("vi-VN");
            lblMemberNameLeft.Text = member.TenThanhVien; lblWalletValue.Text = member.ViTien.ToString("C0", viVNCulture);
            lblPointsValue.Text = member.DiemTichLuy.ToString("N0"); lblLevelValue.Text = member.CapDo;
            txtMemberNote.Text = member.GhiChu; txtMemberNote.ReadOnly = false;
            LoadProfileImageAsync(picProfile, member.AvatarUrl);
            lblMemberNameMiddle.Text = member.TenThanhVien; LoadProfileImageAsync(picProfileMiddle, member.AvatarUrl);
            btnCloseMemberInfo.Visible = true;
            DisplayFavoriteFoods(member.Id); DisplayVouchers(member.Id); DisplayGifts(member.DiemTichLuy);
            ClearOrderSummaryRight(); // Xóa đơn hàng cũ khi chọn TV mới
            SetMemberActionButtonsEnabled(true);
            BtnTab_Click(btnTongHop, EventArgs.Empty); // Tự động chọn tab Tổng hợp
        }

        // --- Hiển thị Danh sách con ---
        private void ClearPanelContent(Panel panel, Control titleLabel, Control noDataLabel)
        {
            panel.SuspendLayout();
            FlowLayoutPanel flp = panel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            var controlsToRemove = panel.Controls.Cast<Control>().Where(c => c != titleLabel && c != noDataLabel && c != flp).ToList();
            foreach (var ctrl in controlsToRemove) panel.Controls.Remove(ctrl);
            if (flp != null) flp.Controls.Clear();
            if (noDataLabel != null) noDataLabel.Visible = true;
            panel.ResumeLayout();
        }

        private FlowLayoutPanel GetOrCreateFlowPanel(Panel parentPanel, Control titleLabel, Control noDataLabel)
        {
            FlowLayoutPanel flp = parentPanel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (flp == null)
            {
                flp = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, FlowDirection = FlowDirection.LeftToRight, WrapContents = true, Padding = new Padding(5), BackColor = Color.Transparent };
                parentPanel.Controls.Add(flp);
            }
            flp.SendToBack();
            if (titleLabel != null) titleLabel.BringToFront();
            if (noDataLabel != null) noDataLabel.Visible = false;
            flp.Controls.Clear();
            return flp;
        }

        private void DisplayFavoriteFoods(int memberId)
        {
            FlowLayoutPanel flpFavor = GetOrCreateFlowPanel(guna2PanelFavFood, lblFavFoodTitle, lblNoFavFood);
            try
            {
                var favFoods = _memberService.GetMemberFavoriteFoods(memberId, _currentStoreId);
                if (favFoods != null && favFoods.Any())
                {
                    foreach (var food in favFoods)
                    {
                        var foodControl = new MonAnTV(); foodControl.SetData(food);
                        foodControl.AddItemRequested += MonAnTV_AddItemRequested;
                        foodControl.DecreaseItemRequested += MonAnTV_DecreaseItemRequested;
                        flpFavor.Controls.Add(foodControl);
                    }
                }
                else { if (lblNoFavFood != null) lblNoFavFood.Visible = true; }
            }
            catch (Exception ex) { if (lblNoFavFood != null) { lblNoFavFood.Text = "Lỗi tải món ăn"; lblNoFavFood.Visible = true; } Console.WriteLine($"FavFood Error: {ex.ToString()}"); }
        }

        private void DisplayVouchers(int memberId)
        {
            FlowLayoutPanel flpVoucher = GetOrCreateFlowPanel(guna2PanelVouchers, lblVoucherTitle, null);
            btnNextVoucher.BringToFront();
            try
            {
                var vouchers = _memberService.GetMemberAvailableVouchers(memberId);
                if (vouchers != null && vouchers.Any())
                {
                    foreach (var voucher in vouchers)
                    {
                        var voucherControl = new Voucher(); voucherControl.SetData(voucher);
                        voucherControl.VoucherSelected += VoucherCard_VoucherSelected;
                        flpVoucher.Controls.Add(voucherControl);
                    }
                }
                else { /* Thêm Label "Không có voucher" */ }
            }
            catch (Exception ex) { Console.WriteLine($"Voucher Error: {ex.ToString()}"); /* Hiển thị lỗi */ }
        }

        private void DisplayGifts(int memberPoints)
        {
            FlowLayoutPanel flpGift = GetOrCreateFlowPanel(guna2PanelGifts, lblGiftsTitle, null);
            try
            {
                var gifts = _giftService.GetAvailableGiftsForMember(memberPoints);
                if (gifts != null && gifts.Any())
                {
                    foreach (var gift in gifts)
                    {
                        var giftControl = new Gift(); giftControl.SetData(gift);
                        // giftControl.RedeemRequested += (s,e) => HandleRedeemGiftRequest(gift);
                        flpGift.Controls.Add(giftControl);
                    }
                }
                else { /* Thêm Label "Không có quà tặng" */ }
            }
            catch (Exception ex) { Console.WriteLine($"Gift Error: {ex.ToString()}"); /* Hiển thị lỗi */ }
        }

        // --- Tải ảnh ---
        private async void LoadProfileImageAsync(Guna2CirclePictureBox pictureBox, string urlOrPath)
        {
            pictureBox.Image = null; pictureBox.FillColor = Color.DarkGray;
            if (string.IsNullOrWhiteSpace(urlOrPath)) return;
            try
            {
                Image image = null;
                if (Uri.IsWellFormedUriString(urlOrPath, UriKind.Absolute)) { using (WebClient client = new WebClient()) { byte[] data = await client.DownloadDataTaskAsync(new Uri(urlOrPath)); using (MemoryStream mem = new MemoryStream(data)) image = Image.FromStream(mem); } }
                else if (File.Exists(urlOrPath)) { await Task.Run(() => { using (var bmpTemp = new Bitmap(urlOrPath)) image = new Bitmap(bmpTemp); }); }
                if (image != null) { pictureBox.Image = image; pictureBox.FillColor = Color.Transparent; }
            }
            catch (Exception ex) { Console.WriteLine($"Image Load Error: {ex.Message}"); pictureBox.FillColor = Color.LightCoral; }
        }

        // --- Xử lý nút chức năng ---
        private void SetMemberActionButtonsEnabled(bool enabled)
        {
            btnNoteMember.Enabled = enabled; btnDiscountMember.Enabled = enabled;
            btnDeleteMember.Enabled = enabled; guna2ButtonMemberInfo.Enabled = enabled;
            btnNapTien.Enabled = enabled; txtMemberNote.ReadOnly = !enabled;
            if (!enabled) { btnTongHop.Checked = false; btnNapTien.Checked = false; }
            else { BtnTab_Click(btnTongHop, EventArgs.Empty); }
        }

        private void BtnScanQR_Click(object sender, EventArgs e) { MessageBox.Show("Chức năng Quét QR chưa cài đặt."); }
        private void BtnFilter_Click(object sender, EventArgs e) { MessageBox.Show("Chức năng Lọc TV chưa cài đặt."); }
        private void BtnNoteMember_Click(object sender, EventArgs e) { if (_currentSelectedMember != null) txtMemberNote.Focus(); }
        private void BtnDiscountMember_Click(object sender, EventArgs e) // Nút Giảm Giá TV
        {
            if (_currentSelectedMember == null) { MessageBox.Show("Vui lòng chọn thành viên."); return; }
            if (!_orderItemsRightPanel.Any()) { MessageBox.Show("Vui lòng thêm món vào đơn hàng bên phải."); return; }
            decimal subTotalRight = _orderItemsRightPanel.Sum(item => item.DonGia * item.SoLuong);
            var args = new ShowDiscountEventArgs(_orderItemsRightPanel, subTotalRight, _currentSelectedMember.Id, _currentStoreId);
            ShowDiscountFormRequested?.Invoke(this, args);
        }
        private void BtnDeleteMember_Click(object sender, EventArgs e) { if (_currentSelectedMember == null) return; var confirm = MessageBox.Show($"Xóa TV '{_currentSelectedMember.TenThanhVien}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); if (confirm == DialogResult.Yes) { MessageBox.Show("Chức năng Xóa TV chưa cài đặt."); ClearMemberInfo(); } }
        private void BtnEditMember_Click(object sender, EventArgs e) { if (_currentSelectedMember == null) return; MessageBox.Show("Chức năng Sửa TV chưa cài đặt."); }
        private void BtnTab_Click(object sender, EventArgs e) { var button = sender as Guna2Button; if (button?.Tag == null) return; bool isTongHop = button.Tag.ToString() == "TongHop"; guna2PanelMiddle.Visible = isTongHop; btnTongHop.Checked = isTongHop; btnNapTien.Checked = !isTongHop; if (!isTongHop) BtnNapTien_Click(sender, e); }
        private void BtnNapTien_Click(object sender, EventArgs e) { if (_currentSelectedMember == null) { MessageBox.Show("Vui lòng chọn thành viên."); return; } MessageBox.Show("Chức năng Nạp tiền chưa cài đặt."); }
        private void TxtMemberNote_Leave(object sender, EventArgs e) { if (_currentSelectedMember != null && txtMemberNote.Modified) { try { if (_memberService.UpdateMemberNote(_currentSelectedMember.Id, txtMemberNote.Text)) { _currentSelectedMember.GhiChu = txtMemberNote.Text; txtMemberNote.Modified = false; } } catch (Exception ex) { MessageBox.Show($"Lỗi lưu ghi chú: {ex.Message}"); } } }

        // --- Handlers cho sự kiện từ Control con ---
        private void MonAnTV_AddItemRequested(object sender, int productId) { AddItemToRightOrder(productId); }
        private void MonAnTV_DecreaseItemRequested(object sender, int productId) { DecreaseItemInRightOrder(productId); }
        private void VoucherCard_VoucherSelected(object sender, VoucherViewModel selectedVoucher)
        {
            if (selectedVoucher == null || _currentSelectedMember == null || !_orderItemsRightPanel.Any()) return;
            try
            {
                decimal subTotal = _orderItemsRightPanel.Sum(i => i.DonGia * i.SoLuong);
                var discountInfo = _discountService.ValidateAndGetVoucher(selectedVoucher.MaVoucher, subTotal, _currentSelectedMember.Id, _currentStoreId, _orderItemsRightPanel);
                ApplyDiscountRightPanel(discountInfo); // Apply null nếu không hợp lệ
                if (discountInfo == null) MessageBox.Show($"Voucher '{selectedVoucher.TenVoucher}' không hợp lệ/áp dụng được.");
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi áp dụng voucher: {ex.Message}"); ApplyDiscountRightPanel(null); }
        }

        // --- HÀM NHẬN KẾT QUẢ TỪ FORM GIẢM GIÁ (Cho Panel Phải) ---
        public void ApplyDiscountRightPanel(DiscountInfo discount)
        {
            _appliedDiscountInfoRightPanel = discount;
            UpdateOrderSummaryRight();
        }

        // --- XỬ LÝ PANEL PHẢI (ĐƠN HÀNG TẠM CHO TV) ---

        /// <summary>
        /// Thêm sản phẩm vào danh sách đơn hàng tạm bên phải.
        /// </summary>
        private void AddItemToRightOrder(int productId)
        {
            if (_currentSelectedMember == null) return; // Không cần thêm nếu chưa chọn TV
            try
            {
                var productToAdd = _productService.GetProductById(productId, _currentStoreId);
                if (productToAdd != null && productToAdd.CoSan)
                {
                    var existingItem = _orderItemsRightPanel.FirstOrDefault(i => i.IdSanPham == productId);
                    if (existingItem != null) existingItem.SoLuong++;
                    else _orderItemsRightPanel.Add(new OrderItemViewModel
                    {
                        IdSanPham = productToAdd.Id,
                        TenSanPham = productToAdd.TenSanPham,
                        DonGia = productToAdd.GiaBan,
                        SoLuong = 1,
                        HinhAnhUrl = productToAdd.HinhAnhUrl
                    });
                    DisplayRightOrderItems();
                    UpdateOrderSummaryRight();
                }
                else { MessageBox.Show("Sản phẩm không có sẵn."); }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi thêm món: {ex.Message}"); }
        }

        /// <summary>
        /// Giảm số lượng hoặc xóa sản phẩm khỏi danh sách đơn hàng tạm bên phải.
        /// </summary>
        private void DecreaseItemInRightOrder(int productId)
        {
            if (_currentSelectedMember == null) return;
            var existingItem = _orderItemsRightPanel.FirstOrDefault(i => i.IdSanPham == productId);
            if (existingItem != null)
            {
                existingItem.SoLuong--;
                if (existingItem.SoLuong <= 0) _orderItemsRightPanel.Remove(existingItem);
                DisplayRightOrderItems();
                UpdateOrderSummaryRight();
            }
        }

        /// <summary>
        /// Cập nhật hiển thị các món ăn trong đơn hàng tạm bên phải.
        /// Yêu cầu FlowLayoutPanel tên 'flowLayoutPanelRightOrderItems' trong Designer.
        /// </summary>
        private void DisplayRightOrderItems()
        {
            Control[] foundControls = guna2PanelOrderSummary.Controls.Find("flowLayoutPanelRightOrderItems", true);
            if (foundControls.Length > 0 && foundControls[0] is FlowLayoutPanel panel)
            {
                panel.SuspendLayout();
                panel.Controls.Clear();

                foreach (var orderItem in _orderItemsRightPanel)
                {
                    // Tạo instance của OrderItemCard (đảm bảo tên lớp đúng)
                    var orderItemCard = new OrderItemCard();

                    // *** SỬA LỖI: Gán dữ liệu qua Properties ***
                    orderItemCard.OrderItemId = orderItem.IdSanPham; // Dùng IdSanPham làm ID tạm thời
                    orderItemCard.ItemName = orderItem.TenSanPham;
                    orderItemCard.Price = orderItem.DonGia; // Gán đơn giá
                    orderItemCard.Quantity = orderItem.SoLuong; // Gán số lượng
                    orderItemCard.ImageUrl = orderItem.HinhAnhUrl;
                    // Gán thêm chi tiết nếu OrderItemViewModel và OrderItemCard có hỗ trợ
                    // orderItemCard.Detail1 = "...";
                    // orderItemCard.Detail2 = "...";
                    // ******************************************

                    // Gắn sự kiện cho các nút trên card nếu cần
                    orderItemCard.ItemRemoved += (s, e) => {
                        var card = s as OrderItemCard;
                        if (card != null)
                        {
                            // Xóa item tương ứng khỏi list và cập nhật lại UI
                            _orderItemsRightPanel.RemoveAll(item => item.IdSanPham == card.OrderItemId);
                            DisplayRightOrderItems(); // Tải lại danh sách card
                            UpdateOrderSummaryRight(); // Cập nhật tổng tiền
                        }
                    };
                    // orderItemCard.QuantityChanged += ... ; // Gắn sự kiện thay đổi số lượng nếu có

                    panel.Controls.Add(orderItemCard); // Thêm card vào panel
                }
                panel.ResumeLayout();
            }
            else
            {
                Console.WriteLine("WARN: Control 'flowLayoutPanelRightOrderItems' not found.");
            }
        }

        /// <summary>
        /// Tính toán và cập nhật các label tóm tắt trong guna2PanelOrderSummary (panel phải).
        /// </summary>
        private void UpdateOrderSummaryRight()
        {
            decimal subTotal = _orderItemsRightPanel.Sum(item => item.DonGia * item.SoLuong);
            decimal discount = _appliedDiscountInfoRightPanel?.CalculateDiscountAmount(subTotal) ?? 0m;
            decimal totalPayment = subTotal - discount;
            int totalItems = _orderItemsRightPanel.Sum(i => i.SoLuong);
            CultureInfo viVNCulture = new CultureInfo("vi-VN");

            // Cập nhật các Label (Đảm bảo tên control trong Designer là đúng)
            lblItemsLabel.Text = $"{totalItems} món";
            lblTableValue.Text = (_selectedOrderTypeRightPanel == "tai_cho") ? "Bàn ?" : "Mang đi";
            lblTotalAmountValue.Text = subTotal.ToString("C0", viVNCulture);
            lblDiscountValue.Text = discount.ToString("C0", viVNCulture);
            lblTotalPaymentValue.Text = totalPayment.ToString("C0", viVNCulture);
            lblDiscountLabel.Text = _appliedDiscountInfoRightPanel != null ? $"Giảm giá ({_appliedDiscountInfoRightPanel.MoTa})" : "Giảm giá";
        }

        /// <summary>
        /// Xóa đơn hàng tạm bên phải và reset thông tin giảm giá.
        /// </summary>
        private void ClearOrderSummaryRight()
        {
            _orderItemsRightPanel.Clear();
            _appliedDiscountInfoRightPanel = null;
            DisplayRightOrderItems(); // Xóa hiển thị món ăn
            UpdateOrderSummaryRight(); // Cập nhật lại tổng tiền về 0
        }

        /// <summary>
        /// Chọn loại đơn hàng mặc định cho panel bên phải.
        /// </summary>
        private void SelectDefaultOrderTypeRight()
        {
            // Đặt nút "Ăn tại bàn" là checked mặc định
            btnAnTaiBan.Checked = true;
            // Gọi Update để cập nhật trạng thái và _selectedOrderTypeRightPanel
            UpdateOrderTypeSelectionRight(btnAnTaiBan);
        }

        /// <summary>
        /// Xử lý sự kiện khi chọn loại đơn hàng (Ăn tại bàn/Mang đi) ở panel phải.
        /// </summary>
        private void BtnOrderTypeRight_Click(object sender, EventArgs e)
        {
            UpdateOrderTypeSelectionRight(sender as Guna2Button);
        }

        /// <summary>
        /// Cập nhật giao diện và trạng thái loại đơn hàng cho panel phải.
        /// </summary>
        private void UpdateOrderTypeSelectionRight(Guna2Button selectedButton)
        {
            if (selectedButton == null || selectedButton.Tag == null) return;
            _selectedOrderTypeRightPanel = selectedButton.Tag.ToString();

            // Logic highlight nút (Giả định ButtonMode=RadioButton)
            btnAnTaiBan.Checked = (selectedButton == btnAnTaiBan);
            btnMangDi.Checked = (selectedButton == btnMangDi);

            // Cập nhật label bàn
            lblTableValue.Text = (_selectedOrderTypeRightPanel == "tai_cho") ? "Bàn ?" : "Mang đi";
            // TODO: Nếu là "tai_cho", cần logic để chọn số bàn cụ thể (có thể mở dialog hoặc list bàn)
            // và cập nhật lblTableValue với số bàn đã chọn.
        }

        /// <summary>
        /// Xử lý sự kiện nhấn nút "Đặt Món" ở panel bên phải.
        /// </summary>
        private void BtnDatMonRight_Click(object sender, EventArgs e)
        {
            if (_currentSelectedMember == null) { MessageBox.Show("Chưa chọn thành viên."); return; }
            if (!_orderItemsRightPanel.Any()) { MessageBox.Show("Chưa có món nào trong đơn hàng."); return; }
            // TODO: Nếu là đơn "tai_cho", kiểm tra xem đã chọn bàn cụ thể chưa (lblTableValue != "Bàn ?")

            decimal subTotal = _orderItemsRightPanel.Sum(item => item.DonGia * item.SoLuong);
            decimal discountAmount = _appliedDiscountInfoRightPanel?.CalculateDiscountAmount(subTotal) ?? 0m;
            decimal totalPayment = subTotal - discountAmount;
            string tableCodeRight = (_selectedOrderTypeRightPanel == "tai_cho") ? lblTableValue.Text : null; // Lấy số bàn (cần đảm bảo khác "Bàn ?")

            var eventArgs = new PaymentEventArgs(
                _orderItemsRightPanel, totalPayment, _currentStoreId, _currentSelectedMember.Id
            //, tableCodeRight // Thêm bàn nếu PaymentEventArgs hỗ trợ
            //, _selectedOrderTypeRightPanel // Thêm loại đơn nếu cần
            //, discountAmount
            //, _appliedDiscountInfoRightPanel
            );
            NavigateToPaymentRequestedRight?.Invoke(this, eventArgs);
        }

    } // End Class

    // --- Các lớp EventArgs (Đã định nghĩa ở các bước trước, đảm bảo nằm trong namespace DoAnDemo.Models) ---
    // public class PaymentEventArgs : EventArgs { ... }
    // public class ShowDiscountEventArgs : EventArgs { ... }
    // public class QuantityChangedEventArgs : EventArgs { ... } // Cần cho MonAnTV

} // End Namespace