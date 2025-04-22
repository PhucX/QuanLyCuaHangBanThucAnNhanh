namespace DoAnDemo.Models
{
    // ViewModel cho sản phẩm hiển thị trên menu
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaBan { get; set; }
        public string HinhAnhUrl { get; set; }
        public int MaDanhMuc { get; set; }
        public bool CoSan { get; set; } // Trạng thái còn hàng tại cửa hàng cụ thể
    }

    // ViewModel cho một mục trong đơn hàng hiện tại
    public class OrderItemViewModel
    {
        public int IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien => DonGia * SoLuong;
        public string HinhAnhUrl { get; set; }
        public string GhiChuMuc { get; set; }
    }

    // ViewModel cho Danh mục sản phẩm
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string TenDanhMuc { get; set; }
    }
}