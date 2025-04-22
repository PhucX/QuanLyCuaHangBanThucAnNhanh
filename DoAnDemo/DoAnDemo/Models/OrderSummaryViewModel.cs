// --- Models/ViewModels ---
using System.Collections.Generic;
using System;

namespace DoAnDemo.Models
{
    // ViewModel tóm tắt đơn hàng để hiển thị trên card
    public class OrderSummaryViewModel
    {
        public int IdDonHang { get; set; }
        public string MaDonHang { get; set; }
        public DateTime ThoiGianDat { get; set; }
        public decimal ThanhTien { get; set; } // Tổng tiền cuối cùng
        public string HinhThucThanhToan { get; set; }
        public string TrangThaiDonHang { get; set; }
        public string TenNhanVien { get; set; } // Tên nhân viên tạo
        public string TenThanhVien { get; set; } // Tên thành viên (hoặc "Khách lẻ")
        public List<OrderItemSnippetViewModel> ItemsSnippet { get; set; } // Danh sách rút gọn các món
    }

    // ViewModel rút gọn cho món hàng trong card tóm tắt
    public class OrderItemSnippetViewModel
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
    }
}