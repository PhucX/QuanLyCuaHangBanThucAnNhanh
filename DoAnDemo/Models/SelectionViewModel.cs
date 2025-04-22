using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDemo.Models
{
    // Models tạm dùng cho Grid Selection
    public interface ISelectable
    {
        bool IsSelected { get; set; }
    }
    public class CategorySelectionViewModel : ISelectable 
    {
        public int CategoryId { get; set; } 
        public string TenDanhMuc { get; set; }
        public bool IsSelected { get; set; }
    }
    public class ProductSelectionViewModel : ISelectable 
    {
        public int IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public bool IsSelected { get; set; }
    }
    public class StoreSelectionViewModel : ISelectable
    {
        public int Id { get; set; } 
        public string TenCuaHang { get; set; } 
        public bool IsSelected { get; set; }
    }
}
