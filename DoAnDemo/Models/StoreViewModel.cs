// --- Models/StoreViewModel.cs ---
namespace DoAnDemo.Models
{
    // ViewModel để hiển thị và truyền dữ liệu Cửa hàng
    public class StoreViewModel
    {
        public int Id { get; set; } // id_cua_hang
        public string MaCuaHang { get; set; }
        public string TenCuaHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string KhuVuc { get; set; }
        public string TrangThai { get; set; } // Giữ nguyên mã 'dang_hoat_dong', 'tam_ngung', ...
        public bool IsSelected { get; set; } // Để đánh dấu cửa hàng đã chọn hay chưa
    }
}