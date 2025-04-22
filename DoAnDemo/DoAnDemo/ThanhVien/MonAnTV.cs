using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.Net;      // Cần cho WebClient nếu tải ảnh từ URL
using System.IO;       // Cần cho MemoryStream
using System.Threading.Tasks; // Cần cho Task (async/await)
using DoAnDemo.Models; // Namespace chứa FavoriteFoodViewModel

namespace DoAnDemo
{
    public partial class MonAnTV : UserControl
    {
        private FavoriteFoodViewModel _currentFood;
        public event EventHandler<int> AddItemRequested; // Gửi kèm ProductId
        public event EventHandler<int> DecreaseItemRequested; // Gửi kèm ProductId

        public MonAnTV()
        {
            InitializeComponent();
            // Gán sự kiện Click cho các thành phần để có thể chọn món
            btnIncrease.Click += BtnIncrease_Click;
            btnDecrease.Click += BtnDecrease_Click;
        }

        /// <summary>
        /// Gán dữ liệu từ ViewModel vào các control.
        /// </summary>
        public void SetData(FavoriteFoodViewModel food)
        {
            if (food == null) return;
            _currentFood = food;

            lblFoodName.Text = food.TenSanPham;
            lblPrice.Text = food.GiaBan.ToString("C0", new CultureInfo("vi-VN"));
            LoadImageAsync(food.ImageUrl);
        }

        // Xử lý nút Cộng (+)
        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            if (_currentFood != null)
            {
                AddItemRequested?.Invoke(this, _currentFood.IdSanPham);
            }
        }

        // Xử lý nút Trừ (-)
        private void BtnDecrease_Click(object sender, EventArgs e)
        {
            if (_currentFood != null)
            {
                DecreaseItemRequested?.Invoke(this, _currentFood.IdSanPham);
            }
        }

        /// <summary>
        /// Tải ảnh bất đồng bộ từ URL hoặc Path.
        /// </summary>
        private async void LoadImageAsync(string urlOrPath)
        {
            if (string.IsNullOrWhiteSpace(urlOrPath))
            {
                picFoodImage.Image = picFoodImage.InitialImage ?? picFoodImage.ErrorImage;
                return;
            }
            try
            {
                Image image = null;
                if (Uri.IsWellFormedUriString(urlOrPath, UriKind.Absolute))
                {
                    using (WebClient client = new WebClient())
                    {
                        byte[] data = await client.DownloadDataTaskAsync(new Uri(urlOrPath));
                        using (MemoryStream mem = new MemoryStream(data)) { image = Image.FromStream(mem); }
                    }
                }
                else if (File.Exists(urlOrPath))
                {
                    await Task.Run(() => {
                        using (var bmpTemp = new Bitmap(urlOrPath)) { image = new Bitmap(bmpTemp); }
                    });
                }
                picFoodImage.Image = image ?? picFoodImage.ErrorImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image '{urlOrPath}': {ex.Message}");
                picFoodImage.Image = picFoodImage.ErrorImage;
            }
        }

        // Hàm để lấy ID sản phẩm (nếu cần từ bên ngoài)
        public int GetFoodId()
        {
            return _currentFood?.IdSanPham ?? -1;
        }
    }
}