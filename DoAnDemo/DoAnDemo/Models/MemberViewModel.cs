// --- Models/ViewModels ---
using System;
using System.Collections.Generic;

namespace DoAnDemo.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        public string MaThanhVien { get; set; }
        public string TenThanhVien { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public decimal ViTien { get; set; }
        public int DiemTichLuy { get; set; }
        public string CapDo { get; set; }
        public string GhiChu { get; set; }
        public string AvatarUrl { get; set; } // Đường dẫn ảnh đại diện
        public string TrangThai { get; set; }
        // Thêm các thuộc tính khác nếu cần
        public int? IdCuaHangDangKy { get; set; } // Kiểu int? (nullable int) vì nó có thể null trong DB
    }

    /// <summary>
    /// ViewModel dùng cho việc tạo hoặc sửa chương trình giảm giá/voucher.
    /// </summary>
    public class VoucherEditViewModel
    {
        public int Id { get; set; }
        public string MaVoucher { get; set; }
        public string TenVoucher { get; set; }
        public string MoTa { get; set; }
        public string LoaiGiamGia { get; set; }
        public decimal GiaTriGiam { get; set; }
        public decimal? GiamGiaToiDa { get; set; }
        public int? IdSanPhamMienPhi { get; set; }
        public decimal GiaTriDonHangToiThieu { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int? SoLuongPhatHanh { get; set; }
        public int? SoLuotSuDungToiDaMoiThanhVien { get; set; }
        public string PhamViApDung { get; set; }
        public List<int> SelectedStoreIds { get; set; }
        public List<int> SelectedCategoryIds { get; set; }
        public List<int> SelectedProductIds { get; set; }
        public string DieuKienSanPham { get; set; }
        public string DoiTuongApDung { get; set; }
        public string TrangThai { get; set; }
    }

    /// <summary>
    /// ViewModel đại diện cho một voucher mà thành viên đang sở hữu,
    /// dùng để hiển thị trên giao diện lựa chọn hoặc danh sách.
    /// </summary>
    public class VoucherViewModel
    {
        public int ThanhVienVoucherId { get; set; }
        public int VoucherId { get; set; }
        public string MaVoucher { get; set; }
        public string TenVoucher { get; set; }
        public string MoTa { get; set; }
        public string ImageUrl { get; set; }
        public int SoLuong { get; set; } = 1;
        public DateTime NgayHetHan { get; set; }
    }

    public class GiftViewModel // ViewModel cho Quà tặng có thể đổi
    {
        public int Id { get; set; }
        public string TenQuaTang { get; set; }
        public string MoTa { get; set; }
        public string ImageUrl { get; set; }
        public int DiemCanDoi { get; set; }
        // Thêm các thuộc tính khác nếu cần hiển thị
    }

    public class FavoriteFoodViewModel // ViewModel cho món ăn hay dùng
    {
        public int IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaBan { get; set; } // Giá hiện tại
        public string ImageUrl { get; set; }
        public int SoLanGoi { get; set; } // Số lần đã gọi (để sắp xếp)
    }
}