using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net;      // Cần cho WebClient nếu tải ảnh từ URL
using System.IO;       // Cần cho MemoryStream
using System.Threading.Tasks; // Cần cho Task (async/await)
using DoAnDemo.Models; // Namespace chứa VoucherViewModel

namespace DoAnDemo
{
    public partial class Voucher : UserControl
    {
        public event EventHandler VoucherClicked; // Sự kiện khi click vào voucher
        public event EventHandler<VoucherViewModel> VoucherSelected; // Gửi VoucherViewModel
        private VoucherViewModel _currentVoucher;

        public Voucher()
        {
            InitializeComponent();
            // Gán sự kiện Click
            this.Click += OnVoucherClick;
            guna2PanelVoucherCard.Click += OnVoucherClick;
            picVoucherImage.Click += OnVoucherClick;
            lblVoucherName.Click += OnVoucherClick;
            lblVoucherCount.Click += OnVoucherClick;
            lblVoucherCountLabel.Click += OnVoucherClick;
        }

        /// <summary>
        /// Gán dữ liệu từ ViewModel vào các control.
        /// </summary>
        public void SetData(VoucherViewModel voucher)
        {
            if (voucher == null) return;
            _currentVoucher = voucher;

            lblVoucherName.Text = voucher.TenVoucher;
            lblVoucherCount.Text = voucher.SoLuong.ToString();
            // Thêm hiển thị ngày hết hạn, mô tả...
            LoadImageAsync(voucher.ImageUrl);
        }

        // *** XỬ LÝ KHI CLICK VOUCHER ***
        private void OnVoucherClick(object sender, EventArgs e)
        {
            if (_currentVoucher != null)
            {
                VoucherSelected?.Invoke(this, _currentVoucher);
            }
        }

        /// <summary>
        /// Tải ảnh bất đồng bộ từ URL hoặc Path.
        /// </summary>
        private async void LoadImageAsync(string urlOrPath)
        {
            if (string.IsNullOrWhiteSpace(urlOrPath))
            {
                picVoucherImage.Image = picVoucherImage.InitialImage ?? picVoucherImage.ErrorImage;
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
                picVoucherImage.Image = image ?? picVoucherImage.ErrorImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image '{urlOrPath}': {ex.Message}");
                picVoucherImage.Image = picVoucherImage.ErrorImage;
            }
        }

        // Lấy Mã Voucher
        public string GetVoucherCode()
        {
            return _currentVoucher?.MaVoucher;
        }
    }
}