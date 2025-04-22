// MenuItemCard.cs
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net; // Cần cho WebClient nếu tải ảnh từ URL
using System.IO; // Cần cho MemoryStream
using System.Globalization;
using System.Threading.Tasks;

namespace DoAnDemo.HienThiGoc
{
    public partial class MenuItemCard : UserControl
    {
        public event EventHandler ItemAdded; // Sự kiện khi nhấn nút Add

        // Properties để nhận dữ liệu từ FormHienThi
        private int _productId;
        private string _itemName;
        private decimal _price;
        private string _imageUrl;

        public int ProductId
        {
            get => _productId;
            set => _productId = value;
        }

        public string ItemName
        {
            get => _itemName;
            set
            {
                _itemName = value;
                lblItemName.Text = value; // Cập nhật Label khi set
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                // Format tiền tệ vi-VN và cập nhật Label
                CultureInfo viVNCulture = new CultureInfo("vi-VN");
                lblPrice.Text = value.ToString("C0", viVNCulture);
            }
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                LoadImageAsync(value); // Gọi hàm tải ảnh
            }
        }

        public MenuItemCard()
        {
            InitializeComponent();
            // Gán sự kiện Click cho nút Add
            btnAddItem.Click += BtnAddItem_Click;
            // Thêm sự kiện hover để đổi màu border (ví dụ)
            this.guna2PanelCard.MouseEnter += (s, e) => { this.guna2PanelCard.BorderThickness = 2; };
            this.guna2PanelCard.MouseLeave += (s, e) => { this.guna2PanelCard.BorderThickness = 1; };
            // Có thể thêm sự kiện Click cho cả panel nếu muốn chọn cả card
            this.Click += (s, e) => OnAddItemClick();
            lblItemName.Click += (s, e) => OnAddItemClick(); // Cho phép click vào text
            lblPrice.Click += (s, e) => OnAddItemClick(); // Cho phép click vào text
            picItemImage.Click += (s, e) => OnAddItemClick(); // Cho phép click vào ảnh
            guna2PanelCard.Click += (s, e) => OnAddItemClick(); // Cho phép click vào panel
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            OnAddItemClick();
        }

        // Hàm trung gian để gọi sự kiện ItemAdded
        private void OnAddItemClick()
        {
            ItemAdded?.Invoke(this, EventArgs.Empty); // Kích hoạt sự kiện ItemAdded
        }

        // Hàm tải ảnh bất đồng bộ từ URL hoặc Path
        private async void LoadImageAsync(string urlOrPath)
        {
            if (string.IsNullOrWhiteSpace(urlOrPath))
            {
                picItemImage.Image = picItemImage.InitialImage ?? picItemImage.ErrorImage; // Ảnh mặc định hoặc lỗi
                return;
            }

            try
            {
                Image image = null;
                // Kiểm tra xem là URL hay đường dẫn file
                if (Uri.IsWellFormedUriString(urlOrPath, UriKind.Absolute))
                {
                    // Tải từ URL
                    using (WebClient client = new WebClient())
                    {
                        byte[] data = await client.DownloadDataTaskAsync(new Uri(urlOrPath));
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            image = Image.FromStream(mem);
                        }
                    }
                }
                else if (File.Exists(urlOrPath))
                {
                    // Tải từ đường dẫn file (cần xử lý bất đồng bộ nếu file lớn)
                    // Đọc đồng bộ cho đơn giản, nhưng nên dùng async/await với FileStream nếu cần
                    await Task.Run(() => { // Chạy trên thread khác để tránh block UI
                        using (var bmpTemp = new Bitmap(urlOrPath))
                        {
                            image = new Bitmap(bmpTemp);
                        }
                    });

                }

                if (image != null)
                {
                    picItemImage.Image = image;
                }
                else
                {
                    picItemImage.Image = picItemImage.ErrorImage; // Ảnh lỗi nếu không tải được
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image '{urlOrPath}': {ex.Message}"); // Log lỗi
                picItemImage.Image = picItemImage.ErrorImage; // Hiển thị ảnh lỗi
            }
        }
    }
}