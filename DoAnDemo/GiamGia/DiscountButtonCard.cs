using DoAnDemo.Models; // Namespace chứa DiscountInfo
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

namespace DoAnDemo.GiamGia // Namespace như trong Designer
{
    public partial class DiscountButtonCard : UserControl
    {
        private DiscountInfo _currentDiscount;
        public event EventHandler<DiscountInfo> Selected;

        private bool _isSelected = false;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                UpdateSelectionVisual();
            }
        }

        public DiscountButtonCard()
        {
            InitializeComponent();
            btnDiscount.Click += BtnDiscount_Click;
            UpdateSelectionVisual();
        }

        public void SetData(DiscountInfo discount)
        {
            if (discount == null) return;
            _currentDiscount = discount;
            btnDiscount.Text = discount.MoTa ?? discount.MaGiamGia ?? $"Giảm giá ID: {discount.Id}";
        }

        public DiscountInfo GetDiscountInfo()
        {
            return _currentDiscount;
        }

        private void BtnDiscount_Click(object sender, EventArgs e)
        {
            if (_currentDiscount != null)
            {
                Selected?.Invoke(this, _currentDiscount);
            }
        }

        private void UpdateSelectionVisual()
        {
            if (_isSelected)
            {
                btnDiscount.FillColor = Color.FromArgb(200, 220, 255); // Màu xanh nhạt hơn khi chọn
                btnDiscount.BorderThickness = 1;
                btnDiscount.BorderColor = Color.DodgerBlue;
            }
            else
            {
                btnDiscount.FillColor = Color.WhiteSmoke;
                btnDiscount.BorderThickness = 0; // Hoặc 1 với màu Gainsboro nếu muốn có viền mờ
                                                 // btnDiscount.BorderColor = Color.Gainsboro;
            }
        }
    }
}