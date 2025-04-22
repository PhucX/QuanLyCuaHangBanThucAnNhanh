using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;                      
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemo.HienThiGoc
{
    // --- LỚP USERCONTROL PHẢI ĐỨNG ĐẦU TIÊN TRONG FILE ---
    public partial class FormHienThi : UserControl
    {
        // --- Services ---
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        // private readonly IOrderService _orderService;

        // --- Configuration / State ---
        private readonly int _currentStoreId = 1; // !!! THAY BẰNG ID CỬA HÀNG THỰC TẾ
        private List<OrderItemViewModel> _currentOrderItems;
        private DiscountInfo _appliedDiscountInfo = null;
        private string _selectedOrderType = "tai_cho";
        private int _selectedCategoryId = 0; // *** THÊM: Lưu trữ danh mục đang chọn ***

        // --- Timer cho Debouncing Search ---
        private Timer _searchDebounceTimer; // *** THÊM TIMER ***

        // --- Events ---
        public event EventHandler<PaymentEventArgs> NavigateToPaymentRequested;
        public event EventHandler NavigateToMemberViewRequested;
        public event EventHandler ShowDailyOrdersRequested;
        public event EventHandler<ShowDiscountEventArgs> ShowDiscountFormRequested;

        // --- Constructor ---
        public FormHienThi()
        {
            InitializeComponent();

            _productService = new ProductService();
            _categoryService = new CategoryService();
            _currentOrderItems = new List<OrderItemViewModel>();

            InitializeSearchTimer(); // *** KHỞI TẠO TIMER ***
            AssignEventHandlers();
            this.Load += FormHienThi_Load;
        }

        // --- Khởi tạo Timer ---
        private void InitializeSearchTimer()
        {
            _searchDebounceTimer = new Timer();
            _searchDebounceTimer.Interval = 400; // Thời gian chờ sau khi người dùng ngừng gõ (ms)
            _searchDebounceTimer.Tick += SearchDebounceTimer_Tick; // Gán sự kiện Tick
        }

        // --- Event Assignment ---
        private void AssignEventHandlers()
        {
            // Nút chính
            btnDatMon.Click += BtnDatMon_Click;
            btnMainMenu.Click += BtnMainMenu_Click; // Cần thêm xử lý cho nút này

            // Các nút chức năng top panel
            //btnDonOnline.Click += BtnDonOnline_Click;
            btnDonDaBan.Click += BtnDonDaBan_Click;
            //btnBan.Click += BtnBan_Click;
            //btnPhuPhi.Click += BtnPhuPhi_Click;
            btnThanhVien.Click += BtnThanhVien_Click; // Nút thành viên (guna2Button1)
            btnUserInfo.Click += BtnUserInfo_Click;
            //btnNoteOrder.Click += BtnNoteOrder_Click;
            //btnDiscountOrder.Click += BtnDiscountOrder_Click;
            btnDeleteOrder.Click += BtnDeleteOrder_Click;


            // Các nút loại đơn hàng sub-top panel
            btnAnTaiBan.Click += BtnOrderType_Click;
            //btnMangDi.Click += BtnOrderType_Click;
            //btnGiaoHang.Click += BtnOrderType_Click;
            // Đặt Tag cho các nút này trong Designer hoặc ở đây để xác định loại đơn
            btnAnTaiBan.Tag = "tai_cho";
            //btnMangDi.Tag = "mang_di";
            //btnGiaoHang.Tag = "giao_hang";


            // Tìm kiếm và lọc
            txtSearchBox.TextChanged += TxtSearchBox_TextChanged;
            btnFilter.Click += BtnFilter_Click;
            //btnTaoMonNhanh.Click += BtnTaoMonNhanh_Click; // Nút tạo món nhanh

        }


        // --- Form Load ---
        private void FormHienThi_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMenuItems(_selectedCategoryId); // Load tất cả sản phẩm ban đầu
            UpdateOrderSummary(); // Cập nhật tổng tiền ban đầu (0)
            SelectDefaultOrderType(); // Chọn loại đơn hàng mặc định
        }

        // --- Category Loading and Handling ---
        private void LoadCategories()
        {
            flowLayoutPanelCategories.SuspendLayout(); // Tạm dừng layout
            flowLayoutPanelCategories.Controls.Clear(); // Xóa các nút cũ

            try
            {
                var categories = _categoryService.GetAllCategories();

                // Thêm nút "Tất cả"
                AddCategoryButton(0, true); // true = checked ban đầu

                // Thêm các nút cho từng danh mục
                foreach (var category in categories)
                {
                    if (!string.IsNullOrWhiteSpace(category.TenDanhMuc))
                    {
                        AddCategoryButton(category.CategoryId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Ghi log lỗi ở đây
            }
            finally
            {
                flowLayoutPanelCategories.ResumeLayout(); // Tiếp tục layout
            }
        }

        private void AddCategoryButton(int categoryId, bool isChecked = false)
        {
            string categoryName = _categoryService.GetNameById(categoryId);
            var button = new Guna2Button
            {
                Text = categoryName,
                Tag = categoryId.ToString(), // Lưu tên danh mục vào Tag để sử dụng lại
                AutoSize = true,
                //AutoEllipsis = true, // Hiển thị ... nếu text quá dài
                MinimumSize = new Size(80, 60),
                Margin = new Padding(4),
                BorderRadius = 5,
                BorderThickness = 1,
                BorderColor = Color.Gainsboro,
                FillColor = isChecked ? Color.FromArgb(200, 54, 96) : Color.White,
                ForeColor = isChecked ? Color.White : Color.FromArgb(64, 64, 64),
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
                Checked = isChecked,
                ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton, // Hoạt động như RadioButton
                ImageAlign = HorizontalAlignment.Center,
                TextAlign = HorizontalAlignment.Center,
                CheckedState = // Định nghĩa trạng thái khi được chọn
                {
                     FillColor = Color.FromArgb(200, 54, 96),
                     ForeColor = Color.White
                },
                HoverState = // Định nghĩa trạng thái khi hover (nếu chưa check)
                {
                     FillColor = Color.FromArgb(245, 245, 245) // Màu nền nhạt khi hover
                }
            };
            button.Click += CategoryButton_Click;
            flowLayoutPanelCategories.Controls.Add(button);
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Guna2Button;
            if (clickedButton?.Tag != null)
            {
                _selectedCategoryId = Int32.Parse(clickedButton.Tag.ToString()); // *** LƯU CATEGORY ĐANG CHỌN ***
                PerformSearch(); // *** GỌI HÀM TÌM KIẾM/LOAD LẠI ***
                // Guna tự xử lý checked state khi ButtonMode là RadioButton
            }
        }

        // --- Menu Item Loading and Handling ---
        // *** ĐỔI TÊN: LoadMenuItems thành PerformSearch để thể hiện đúng chức năng ***
        // Hàm này giờ sẽ được gọi bởi Timer hoặc khi đổi Category
        private void PerformSearch()
        {
            string searchTerm = txtSearchBox.Text; // Lấy từ khóa từ TextBox
            LoadMenuItems(_selectedCategoryId, searchTerm); // Gọi hàm load với category và từ khóa
        }

        // --- Menu Item Loading and Handling ---
        private void LoadMenuItems(int categoryId, string searchTerm = null)
        {
            this.Cursor = Cursors.WaitCursor; // Hiển thị con trỏ chờ
            flowLayoutPanelMenuItems.SuspendLayout(); // Tạm dừng layout

            try
            {
                List<ProductViewModel> products = new List<ProductViewModel>();
                if (categoryId == 0)
                {
                    products = _productService.GetAvailableProductsByStore(_currentStoreId); // Lấy tất cả sản phẩm
                }
                else
                {
                    // Gọi service mới để tìm kiếm (bao gồm cả lọc theo category và search term)
                    products = _productService.SearchAvailableProducts(
                        _currentStoreId,
                        categoryId, // categoryName có thể là "Tất cả" hoặc tên cụ thể
                        searchTerm
                    );
                }

                // Cập nhật tiêu đề dựa trên category (tiêu đề tìm kiếm có thể thêm sau)
                string categoryName = _categoryService.GetNameById(categoryId);
                lblCategoryTitle.Text = (string.IsNullOrEmpty(categoryName) || categoryName.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
                                        ? "Tất cả Món ăn" : $"Danh mục: {categoryId}";

                DisplayMenuItems(products); // Gọi hàm hiển thị kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flowLayoutPanelMenuItems.ResumeLayout(); // Tiếp tục layout
                this.Cursor = Cursors.Default; // Trả lại con trỏ mặc định
            }
        }

        private void DisplayMenuItems(List<ProductViewModel> products)
        {
            flowLayoutPanelMenuItems.SuspendLayout(); // Tạm dừng layout
            flowLayoutPanelMenuItems.Controls.Clear(); // Xóa các item cũ

            if (products != null)
            {
                foreach (var product in products)
                {
                    // Chỉ hiển thị những sản phẩm còn hàng (CoSan = true)
                    if (product.CoSan)
                    {
                        // *** QUAN TRỌNG: Đảm bảo tên UserControl khớp với file bạn đã tạo ***
                        // Nếu file là MenuItemCard.cs thì dùng new MenuItemCard()
                        // Nếu file là MenuItems.cs thì dùng new MenuItems()
                        var menuItemCard = new MenuItemCard // Hoặc new MenuItems()
                        {
                            ProductId = product.Id,
                            ItemName = product.TenSanPham,
                            Price = product.GiaBan,
                            ImageUrl = product.HinhAnhUrl
                        };

                        // Gán sự kiện khi nút Add trên card được nhấn
                        menuItemCard.ItemAdded += MenuItemCard_ItemAdded;

                        flowLayoutPanelMenuItems.Controls.Add(menuItemCard);
                    }
                }
            }
            flowLayoutPanelMenuItems.ResumeLayout(); // Tiếp tục layout
        }


        // --- Current Order Handling ---
        private void MenuItemCard_ItemAdded(object sender, EventArgs e)
        {
            // *** QUAN TRỌNG: Đảm bảo kiểu sender khớp với UserControl bạn dùng ***
            var card = sender as MenuItemCard; // Hoặc sender as MenuItems
            if (card != null)
            {
                try
                {
                    var productToAdd = _productService.GetProductById(card.ProductId, _currentStoreId);

                    if (productToAdd != null && productToAdd.CoSan)
                    {
                        var existingItem = _currentOrderItems.FirstOrDefault(item => item.IdSanPham == productToAdd.Id /* && So sánh thêm các tùy chọn nếu có */);

                        if (existingItem != null)
                        {
                            existingItem.SoLuong++;
                        }
                        else
                        {
                            var newItem = new OrderItemViewModel
                            {
                                IdSanPham = productToAdd.Id,
                                TenSanPham = productToAdd.TenSanPham,
                                DonGia = productToAdd.GiaBan,
                                SoLuong = 1,
                                HinhAnhUrl = productToAdd.HinhAnhUrl,
                                GhiChuMuc = "" // Khởi tạo ghi chú rỗng
                            };
                            _currentOrderItems.Add(newItem);
                        }
                        DisplayOrderItems(); // Cập nhật lại danh sách hiển thị bên phải
                    }
                    else
                    {
                        MessageBox.Show($"Sản phẩm '{card.ItemName}' không có sẵn hoặc không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Cân nhắc load lại menu nếu cần
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi cụ thể hơn nếu là lỗi resource
                    if (ex is System.Resources.MissingManifestResourceException || ex.InnerException is System.Resources.MissingManifestResourceException)
                    {
                        MessageBox.Show($"Lỗi tải tài nguyên cho OrderItemCard. Vui lòng kiểm tra file OrderItemCard.resx và Build Action.\nChi tiết: {ex.Message}", "Lỗi Resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi khi thêm sản phẩm vào đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Ghi log lỗi chi tiết
                }
            }
        }

        private void DisplayOrderItems()
        {
            flowLayoutPanelOrderItems.SuspendLayout();
            flowLayoutPanelOrderItems.Controls.Clear();

            foreach (var orderItem in _currentOrderItems)
            {
                // *** QUAN TRỌNG: Đảm bảo tên UserControl khớp với file bạn đã tạo ***
                // Nếu file là OrderItemCard.cs thì dùng new OrderItemCard()
                // Nếu file là OrderItems.cs thì dùng new OrderItems()
                var orderItemCard = new OrderItemCard // Hoặc new OrderItems()
                {
                    OrderItemId = orderItem.IdSanPham, // Dùng ID Sản phẩm làm định danh tạm thời
                    ItemName = orderItem.TenSanPham,
                    Price = orderItem.DonGia,
                    Quantity = orderItem.SoLuong,
                    ImageUrl = orderItem.HinhAnhUrl,
                };

                // Gán sự kiện
                orderItemCard.ItemRemoved += OrderItemCard_ItemRemoved;
                orderItemCard.QuantityChanged += OrderItemCard_QuantityChanged;

                flowLayoutPanelOrderItems.Controls.Add(orderItemCard);
            }

            flowLayoutPanelOrderItems.ResumeLayout();
            UpdateOrderSummary(); // Cập nhật tổng tiền sau khi hiển thị lại
        }

        private void OrderItemCard_ItemRemoved(object sender, EventArgs e)
        {
            // *** QUAN TRỌNG: Đảm bảo kiểu sender khớp với UserControl bạn dùng ***
            var card = sender as OrderItemCard; // Hoặc sender as OrderItems
            if (card != null)
            {
                try
                {
                    var itemToRemove = _currentOrderItems.FirstOrDefault(item => item.IdSanPham == card.OrderItemId);
                    if (itemToRemove != null)
                    {
                        _currentOrderItems.Remove(itemToRemove);
                        DisplayOrderItems(); // Cập nhật lại
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa sản phẩm khỏi đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Ghi log lỗi
                }
            }
        }

        // Xử lý sự kiện thay đổi số lượng từ OrderItemCard (nếu có nút +/-)
        private void OrderItemCard_QuantityChanged(object sender, QuantityChangedEventArgs e)
        {
            // *** QUAN TRỌNG: Đảm bảo kiểu sender khớp với UserControl bạn dùng ***
            var card = sender as OrderItemCard; // Hoặc sender as OrderItems
            if (card != null)
            {
                var itemToUpdate = _currentOrderItems.FirstOrDefault(item => item.IdSanPham == card.OrderItemId);
                if (itemToUpdate != null)
                {
                    if (e.NewQuantity <= 0) // Số lượng về 0 hoặc âm thì xóa
                    {
                        _currentOrderItems.Remove(itemToUpdate);
                    }
                    else
                    {
                        itemToUpdate.SoLuong = e.NewQuantity;
                    }
                    DisplayOrderItems(); // Cập nhật lại
                }
            }
        }

        // --- Order Summary Update ---
        private decimal CalculateTotalAmount()
        {
            decimal subTotal = _currentOrderItems.Sum(item => item.ThanhTien);
            decimal discount = 0m;
            decimal fees = 0; // Logic phụ phí

            // Tính toán giảm giá nếu có voucher/discount được áp dụng
            if (_appliedDiscountInfo != null)
            {
                discount = _appliedDiscountInfo.CalculateDiscountAmount(subTotal);
                // TODO: Xử lý logic cho free_item nếu có (ví dụ: tìm item trong giỏ hàng và set giá về 0?)
            }

            return subTotal - discount + fees;
        }

        private void UpdateOrderSummary()
        {
            decimal subTotal = _currentOrderItems.Sum(item => item.ThanhTien);
            decimal discount = 0m; // Tính lại dựa trên _appliedDiscountInfo
            if (_appliedDiscountInfo != null)
            {
                discount = _appliedDiscountInfo.CalculateDiscountAmount(subTotal);
            }
            decimal totalPayment = CalculateTotalAmount(); // Gọi hàm đã cập nhật
            int totalItems = _currentOrderItems.Sum(item => item.SoLuong);
            CultureInfo viVNCulture = new CultureInfo("vi-VN");

            lblItemsCountValue.Text = totalItems.ToString();
            lblTotalAmountValue.Text = subTotal.ToString("C0", viVNCulture);
            lblDiscountValue.Text = discount.ToString("C0", viVNCulture); // Hiển thị số tiền giảm thực tế
            lblTotalPaymentValue.Text = totalPayment.ToString("C0", viVNCulture);

            // Cập nhật hiển thị mô tả giảm giá (đã làm trong ApplyDiscount)
            if (_appliedDiscountInfo != null)
                lblDiscountLabel.Text = $"Giảm giá ({_appliedDiscountInfo.MoTa})";
            else
                lblDiscountLabel.Text = "Giảm giá";
        }


        // --- Button Click Handlers ---

        private void BtnDatMon_Click(object sender, EventArgs e)
        {
            if (!_currentOrderItems.Any())
            {
                MessageBox.Show("Vui lòng chọn món trước khi đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal finalAmount = CalculateTotalAmount();
            decimal subTotal = _currentOrderItems.Sum(item => item.ThanhTien);
            decimal discountAmount = (_appliedDiscountInfo != null) ? _appliedDiscountInfo.CalculateDiscountAmount(subTotal) : 0m;

            // *** Cập nhật PaymentEventArgs để truyền thêm thông tin giảm giá nếu cần ***
            // Hoặc FormThanhToan sẽ tự tính lại dựa trên thông tin đơn hàng và thành viên
            var eventArgs = new PaymentEventArgs(
                _currentOrderItems,
                finalAmount, // Truyền tổng tiền cuối cùng
                _currentStoreId,
                null
            //, _selectedTableId
            //, _currentSelectedMember?.Id
            //, _appliedDiscountInfo // Có thể truyền cả object discount nếu FormThanhToan cần
            //, discountAmount      // Hoặc chỉ truyền số tiền đã giảm
            );
            NavigateToPaymentRequested?.Invoke(this, eventArgs);
        }

        // --- Các nút chức năng khác (Cần thêm logic cụ thể) ---

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            // Logic mở menu chính hoặc quay lại màn hình dashboard
            // Có thể cần raise một event khác cho Form cha
            MessageBox.Show("Chức năng Menu chính chưa được cài đặt.");
        }

        private void BtnDonOnline_Click(object sender, EventArgs e)
        {
            // Logic xử lý hiển thị/quản lý các đơn hàng online
            MessageBox.Show("Chức năng Đơn Online chưa được cài đặt.");
        }

        private void BtnDonDaBan_Click(object sender, EventArgs e)
        {
            // Logic hiển thị danh sách các đơn đã bán/lịch sử
            ShowDailyOrdersRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            // Logic mở form/control quản lý bàn, chọn bàn cho đơn hàng hiện tại
            MessageBox.Show("Chức năng quản lý Bàn chưa được cài đặt.");
            // Ví dụ: ManageTablesRequested?.Invoke(this, EventArgs.Empty);
            // Sau khi chọn bàn thì cập nhật _selectedTableId và lblTableValue
        }

        private void BtnPhuPhi_Click(object sender, EventArgs e)
        {
            // Logic mở form/dialog để thêm/sửa phụ phí cho đơn hàng
            MessageBox.Show("Chức năng Phụ phí chưa được cài đặt.");
            // Sau khi cập nhật thì gọi UpdateOrderSummary();
        }

        private void BtnThanhVien_Click(object sender, EventArgs e)
        {
            // Logic mở form/control quản lý thành viên, tìm và áp dụng thành viên cho đơn
            NavigateToMemberViewRequested?.Invoke(this, EventArgs.Empty);
            // Ví dụ: ManageMembersRequested?.Invoke(this, EventArgs.Empty);
            // Sau khi chọn thành viên thì cập nhật _selectedMemberId và có thể tính lại giảm giá
        }

        private void BtnUserInfo_Click(object sender, EventArgs e)
        {
            // Hiển thị thông tin chi tiết của nhân viên đang đăng nhập
            // Hoặc mở form quản lý tài khoản
            MessageBox.Show("Chức năng Thông tin User chưa được cài đặt.");
        }

        private void BtnNoteOrder_Click(object sender, EventArgs e)
        {
            // Logic mở dialog/form để nhập ghi chú chung cho toàn bộ đơn hàng
            MessageBox.Show("Chức năng Ghi chú đơn hàng chưa được cài đặt.");
        }

        private void BtnDiscountOrder_Click(object sender, EventArgs e)
        {
            if (!_currentOrderItems.Any())
            {
                MessageBox.Show("Vui lòng chọn món trước khi áp dụng giảm giá.", "Thông báo");
                return;
            }

            decimal subTotal = _currentOrderItems.Sum(item => item.ThanhTien);
            var args = new ShowDiscountEventArgs(_currentOrderItems, subTotal, null, _currentStoreId);
            ShowDiscountFormRequested?.Invoke(this, args);
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Logic xóa toàn bộ các món trong đơn hàng tạm hiện tại
            if (_currentOrderItems.Any())
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ đơn hàng này?",
                                         "Xác nhận xóa",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    ClearCurrentOrder();
                }
            }
        }

        // --- Order Type Selection ---
        private void SelectDefaultOrderType()
        {
            // Mặc định chọn nút "Ăn tại bàn" khi form load
            UpdateOrderTypeSelection(btnAnTaiBan);
        }

        private void BtnOrderType_Click(object sender, EventArgs e)
        {
            UpdateOrderTypeSelection(sender as Guna2Button);
        }

        private void UpdateOrderTypeSelection(Guna2Button selectedButton)
        {
            if (selectedButton == null || selectedButton.Tag == null) return;

            _selectedOrderType = selectedButton.Tag.ToString(); // Lưu lại loại đơn hàng được chọn

            // Cập nhật giao diện các nút loại đơn hàng
            foreach (Control c in guna2PanelSubTop.Controls)
            {
                if (c is Guna2Button btn && (btn == btnAnTaiBan))
                {
                    // Không dùng Checked vì ButtonMode là RadioButton sẽ tự xử lý
                    // Chỉ cần cập nhật FillColor và ForeColor dựa trên trạng thái Checked
                    btn.FillColor = btn.Checked ? Color.FromArgb(200, 54, 96) : Color.White;
                    btn.ForeColor = btn.Checked ? Color.White : Color.FromArgb(200, 54, 96); // Màu hồng/đỏ cho chữ khi không check
                    btn.BorderColor = Color.FromArgb(200, 54, 96); // Giữ màu viền
                }
            }
            // Có thể thêm logic khác tùy theo loại đơn hàng được chọn (ví dụ: ẩn/hiện nút chọn bàn)
        }


        // --- Search and Filter ---
        private void TxtSearchBox_TextChanged(object sender, EventArgs e)
        {
            // Lọc danh sách sản phẩm dựa trên text trong search box
            // Cần tối ưu hóa để không gọi database liên tục khi gõ từng chữ
            // Có thể dùng Timer để đợi người dùng gõ xong, hoặc lọc trên danh sách đã tải
            // Ví dụ đơn giản (lọc trên list đã tải - không hiệu quả nếu list lớn):
            // FilterDisplayedMenuItems(txtSearchBox.Text);
            _searchDebounceTimer.Stop();  // Dừng timer hiện tại (nếu đang chạy)
            _searchDebounceTimer.Start(); // Khởi động lại timer (đếm lùi 400ms)
        }

        // Hàm xử lý khi Timer tick (sau khi người dùng ngừng gõ)
        private void SearchDebounceTimer_Tick(object sender, EventArgs e)
        {
            _searchDebounceTimer.Stop(); // Dừng timer lại
            PerformSearch();             // Thực hiện tìm kiếm/load lại danh sách sản phẩm
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            // Mở bộ lọc nâng cao (nếu có)
            MessageBox.Show("Chức năng Lọc nâng cao chưa được cài đặt.");
        }

        private void BtnTaoMonNhanh_Click(object sender, EventArgs e)
        {
            // Mở form/dialog để tạo nhanh món ăn không có trong menu chính
            MessageBox.Show("Chức năng Tạo món nhanh chưa được cài đặt.");
        }


        // --- Public Method for Clearing Order ---
        // Có thể được gọi từ Form cha sau khi thanh toán thành công
        public void ClearCurrentOrder()
        {
            _currentOrderItems.Clear();
            _appliedDiscountInfo = null; // *** Xóa giảm giá đã áp dụng ***
            DisplayOrderItems();
            UpdateOrderSummary(); // Gọi UpdateOrderSummary để reset cả label giảm giá
        }

        // --- Thêm phương thức này để nhận kết quả từ FormGiamGia ---
        public void ApplyDiscount(DiscountInfo discount)
        {
            _appliedDiscountInfo = discount; // Lưu lại thông tin giảm giá được chọn
            UpdateOrderSummary();          // Cập nhật lại tổng tiền
                                           // Có thể thêm hiển thị tên/mô tả giảm giá đã áp dụng lên UI
            if (discount != null)
                lblDiscountLabel.Text = $"Giảm giá ({discount.MoTa})"; // Hiển thị mô tả lên label
            else
                lblDiscountLabel.Text = "Giảm giá"; // Reset text
        }
    }
}