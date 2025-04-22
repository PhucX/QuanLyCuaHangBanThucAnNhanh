// --- Models/DiscountInfo.cs ---
using System;

namespace DoAnDemo.Models
{
    public class DiscountInfo
    {
        public int Id { get; set; } // ID của Voucher hoặc loại giảm giá
        public string MaGiamGia { get; set; }
        public string MoTa { get; set; }
        public string LoaiGiamGia { get; set; } // 'percentage', 'fixed_amount', 'free_item'
        public decimal GiaTriGiam { get; set; }
        public decimal? GiamGiaToiDa { get; set; }
        public decimal GiaTriDonHangToiThieu { get; set; }
        public int? IdSanPhamMienPhi { get; set; }
        // Thêm các thuộc tính khác nếu cần (vd: ngày hết hạn...)

        public decimal CalculateDiscountAmount(decimal subTotal)
        {
            if (subTotal < GiaTriDonHangToiThieu) return 0m;
            decimal discountAmount = 0m;
            if (LoaiGiamGia == "percentage") { discountAmount = subTotal * (GiaTriGiam / 100m); if (GiamGiaToiDa.HasValue && discountAmount > GiamGiaToiDa.Value) discountAmount = GiamGiaToiDa.Value; }
            else if (LoaiGiamGia == "fixed_amount") { discountAmount = GiaTriGiam; }
            return Math.Max(0, Math.Min(discountAmount, subTotal)); // Đảm bảo giảm giá không âm và không lớn hơn subTotal
        }
    }
}