using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net;      // Cần cho WebClient nếu tải ảnh từ URL
using System.IO;       // Cần cho MemoryStream
using System.Threading.Tasks; // Cần cho Task (async/await)
using DoAnDemo.Models; // Namespace chứa GiftViewModel

namespace DoAnDemo
{
    public partial class Gift : UserControl
    {
        public event EventHandler RedeemRequested; // Sự kiện khi nhấn nút Đổi quà
        private GiftViewModel _currentGift;

        public Gift()
        {
            InitializeComponent();
            btnRedeem.Click += BtnRedeem_Click; // Gán sự kiện cho nút đổi quà
        }

        /// <summary>
        /// Gán dữ liệu từ ViewModel vào các control.
        /// </summary>
        public void SetData(GiftViewModel gift)
        {
            if (gift == null) return;
            _currentGift = gift; // Lưu lại thông tin quà

            lblGiftName.Text = gift.TenQuaTang;
            lblPointsRequired.Text = $"{gift.DiemCanDoi} Điểm";
            LoadImageAsync(gift.ImageUrl); // Tải ảnh
        }

        /// <summary>
        /// Xử lý khi nhấn nút Đổi quà.
        /// </summary>
        private void BtnRedeem_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện, truyền thông tin quà tặng đi nếu cần
            RedeemRequested?.Invoke(this, EventArgs.Empty); // Có thể tạo EventArgs riêng để truyền _currentGift
        }

        /// <summary>
        /// Tải ảnh bất đồng bộ từ URL hoặc Path.
        /// </summary>
        private async void LoadImageAsync(string urlOrPath)
        {
            if (string.IsNullOrWhiteSpace(urlOrPath))
            {
                picGiftImage.Image = picGiftImage.InitialImage ?? picGiftImage.ErrorImage;
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
                picGiftImage.Image = image ?? picGiftImage.ErrorImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image '{urlOrPath}': {ex.Message}");
                picGiftImage.Image = picGiftImage.ErrorImage;
            }
        }
    }
}