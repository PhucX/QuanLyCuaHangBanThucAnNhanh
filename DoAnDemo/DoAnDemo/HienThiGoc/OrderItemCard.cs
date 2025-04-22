// OrderItems.cs
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net; // Cần cho WebClient nếu tải ảnh từ URL
using System.IO; // Cần cho MemoryStream
using System.Globalization; // Cần cho CultureInfo để format tiền tệ
using System.Threading.Tasks; // Cần cho Task (async/await)

namespace DoAnDemo.HienThiGoc
{
    // Đảm bảo tên lớp khớp với tên file và lớp partial trong Designer.cs
    public partial class OrderItemCard : UserControl
    {
        public event EventHandler ItemRemoved; // Sự kiện khi nhấn nút Delete
        public event EventHandler<QuantityChangedEventArgs> QuantityChanged; // Sự kiện khi số lượng thay đổi (nếu có nút +/-)

        // --- Private fields ---
        private int _orderItemId; // ID của sản phẩm hoặc ID duy nhất của dòng này trong đơn hàng tạm
        private string _itemName;
        private decimal _price; // Lưu đơn giá gốc
        private int _quantity;
        private string _imageUrl;
        private string _detail1;
        private string _detail2;

        // --- Public Properties ---
        public int OrderItemId
        {
            get => _orderItemId;
            set => _orderItemId = value;
        }

        public string ItemName
        {
            get => _itemName;
            set
            {
                _itemName = value;
                lblItemName.Text = value; // Cập nhật Label tên
            }
        }

        public decimal Price // Property này nên là Đơn giá (Price per unit)
        {
            get => _price;
            set
            {
                _price = value;
                UpdatePriceLabel(); // Gọi hàm cập nhật Label giá tiền
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                lblQuantity.Text = value.ToString(); // Cập nhật Label số lượng
                UpdatePriceLabel(); // Cập nhật lại giá tiền (thành tiền) sau khi đổi số lượng
            }
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                LoadImageAsync(value); // Tải ảnh khi set URL
            }
        }
        public string Detail1
        {
            get => _detail1;
            set
            {
                _detail1 = value;
                lblDetail1.Text = value;
                // Ẩn/hiện label tùy thuộc có nội dung hay không
                lblDetail1.Visible = !string.IsNullOrEmpty(value);
            }
        }

        public string Detail2
        {
            get => _detail2;
            set
            {
                _detail2 = value;
                lblDetail2.Text = value;
                // Ẩn/hiện label tùy thuộc có nội dung hay không
                lblDetail2.Visible = !string.IsNullOrEmpty(value);
            }
        }

        // --- Constructor ---
        public OrderItemCard()
        {
            InitializeComponent();
            // Gán sự kiện Click cho nút Delete
            btnDeleteItem.Click += BtnDeleteItem_Click;

            // Gán sự kiện cho nút tăng/giảm số lượng nếu bạn thêm chúng vào Designer sau này
            // ví dụ: btnIncreaseQty.Click += BtnIncreaseQty_Click;
            // ví dụ: btnDecreaseQty.Click += BtnDecreaseQty_Click;
        }

        // --- Private Methods ---

        // Cập nhật Label giá tiền (hiển thị Thành tiền = Đơn giá * Số lượng)
        private void UpdatePriceLabel()
        {
            CultureInfo viVNCulture = new CultureInfo("vi-VN");
            decimal lineTotal = _price * _quantity; // Tính thành tiền
            lblPrice.Text = lineTotal.ToString("C0", viVNCulture); // Format và hiển thị
        }

        // Hàm tải ảnh bất đồng bộ (giống hệt trong MenuItemCard.cs)
        private async void LoadImageAsync(string urlOrPath)
        {
            if (string.IsNullOrWhiteSpace(urlOrPath))
            {
                // Nếu không có URL/Path, sử dụng ảnh mặc định hoặc ảnh lỗi từ PictureBox
                picItemImage.Image = picItemImage.InitialImage ?? picItemImage.ErrorImage;
                return;
            }

            try
            {
                Image image = null;
                // Kiểm tra xem là URL hợp lệ hay đường dẫn file
                if (Uri.IsWellFormedUriString(urlOrPath, UriKind.Absolute))
                {
                    // Tải từ URL
                    using (WebClient client = new WebClient())
                    {
                        // Đặt timeout để tránh chờ quá lâu (ví dụ: 10 giây)
                        // client.Timeout = 10000; // Timeout không có sẵn trực tiếp, cần xử lý phức tạp hơn hoặc dùng HttpClient

                        byte[] data = await client.DownloadDataTaskAsync(new Uri(urlOrPath));
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            image = Image.FromStream(mem);
                        }
                    }
                }
                else if (File.Exists(urlOrPath))
                {
                    // Tải từ đường dẫn file cục bộ
                    // Chạy trên thread khác để không block UI thread khi đọc file
                    await Task.Run(() => {
                        // Tạo Bitmap mới từ file để tránh giữ khóa file
                        using (var bmpTemp = new Bitmap(urlOrPath))
                        {
                            image = new Bitmap(bmpTemp);
                        }
                    });
                }

                // Gán ảnh đã tải vào PictureBox (nếu tải thành công)
                if (image != null)
                {
                    picItemImage.Image = image;
                }
                else
                {
                    // Nếu không tải được hoặc path/url không đúng, dùng ảnh lỗi
                    picItemImage.Image = picItemImage.ErrorImage;
                }
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi (ví dụ: vào Console hoặc file log)
                Console.WriteLine($"Lỗi tải ảnh '{urlOrPath}': {ex.Message}");
                // Hiển thị ảnh lỗi trong PictureBox
                picItemImage.Image = picItemImage.ErrorImage;
            }
        }

        // --- Event Handlers ---

        // Xử lý sự kiện click nút Delete
        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện ItemRemoved để báo cho Form cha (FormHienThi)
            ItemRemoved?.Invoke(this, EventArgs.Empty);
        }

        // Ví dụ hàm xử lý nút tăng số lượng (nếu có)
        // private void BtnIncreaseQty_Click(object sender, EventArgs e)
        // {
        //     int newQuantity = Quantity + 1;
        //     // Kích hoạt sự kiện QuantityChanged với số lượng mới
        //     QuantityChanged?.Invoke(this, new QuantityChangedEventArgs(newQuantity));
        // }

        // Ví dụ hàm xử lý nút giảm số lượng (nếu có)
        // private void BtnDecreaseQty_Click(object sender, EventArgs e)
        // {
        //     int newQuantity = Quantity - 1;
        //     // Chỉ kích hoạt sự kiện nếu số lượng mới >= 0 (hoặc >= 1 tùy logic)
        //     if (newQuantity >= 0)
        //     {
        //          QuantityChanged?.Invoke(this, new QuantityChangedEventArgs(newQuantity));
        //     }
        // }

        // EventArgs để truyền số lượng mới khi thay đổi (nếu có nút +/-)
        // Mặc dù Designer hiện tại không có nút +/-, vẫn giữ lại EventArgs này phòng khi cần mở rộng
    }
    public class QuantityChangedEventArgs : EventArgs
    {
        public int NewQuantity { get; }
        public QuantityChangedEventArgs(int newQuantity)
        {
            NewQuantity = newQuantity;
        }
    }
}