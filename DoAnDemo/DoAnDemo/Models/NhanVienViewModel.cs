using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDemo.Models
{
    public class NhanVienViewModel
    {
        public int Id { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string TaiKhoan { get; set; }
        public string TenChiNhanh { get; set; } // Vẫn giữ để hiển thị trên grid list
        public int IdCuaHangLamViec { get; set; } // *** Thuộc tính lưu ID Chi nhánh ***
        public string QuyenHan { get; set; }
        public string TrangThai { get; set; }
        public DateTime? NgayVaoLam { get; set; }
    }
}
