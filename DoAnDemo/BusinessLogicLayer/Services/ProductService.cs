using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer; // Namespace chứa FastFoodDataContext và các lớp LINQ to SQL
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Windows; // Cần cho LoadWith

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class ProductService : IProductService
    {
        // Inject hoặc tạo instance của DataContext
        // Lưu ý quản lý lifetime của DataContext (ví dụ: dùng using trong mỗi method)

        public List<ProductViewModel> GetAvailableProductsByStore(int storeId)
        {
            using (var db = new FastFoodDataContext()) // Quản lý lifetime
            {
                // Lấy các sản phẩm còn 'active' và có giá/trạng thái tại cửa hàng này
                var products = from sp in db.SanPhams
                               join g in db.GiaVaTrangThaiSanPhamTaiCuaHangs on sp.id_san_pham equals g.id_san_pham
                               where sp.trang_thai_chung == "active" && g.id_cua_hang == storeId //&& g.trang_thai_co_san == true // Có thể thêm điều kiện có sẵn nếu cần lọc ngay
                               select new ProductViewModel
                               {
                                   Id = sp.id_san_pham,
                                   MaSanPham = sp.ma_san_pham,
                                   TenSanPham = sp.ten_san_pham,
                                   GiaBan = g.gia_ban,
                                   HinhAnhUrl = sp.hinh_anh_url, // Cần xử lý nếu null
                                   MaDanhMuc = sp.id_danh_muc,
                                   CoSan = g.trang_thai_co_san
                               };
                return products.ToList();
            }
        }

        public List<ProductViewModel> GetAvailableProductsByStoreAndCategory(int storeId, int categoryId)
        {
            if (categoryId == 0)
            {
                return GetAvailableProductsByStore(storeId);
            }

            using (var db = new FastFoodDataContext())
            {
                var products = from sp in db.SanPhams
                               join g in db.GiaVaTrangThaiSanPhamTaiCuaHangs on sp.id_san_pham equals g.id_san_pham
                               where sp.trang_thai_chung == "active"
                                     && g.id_cua_hang == storeId
                                     && sp.id_danh_muc == categoryId // Lọc theo danh mục
                                                                     //&& g.trang_thai_co_san == true
                               select new ProductViewModel
                               {
                                   Id = sp.id_san_pham,
                                   MaSanPham = sp.ma_san_pham,
                                   TenSanPham = sp.ten_san_pham,
                                   GiaBan = g.gia_ban,
                                   HinhAnhUrl = sp.hinh_anh_url,
                                   MaDanhMuc = sp.id_danh_muc,
                                   CoSan = g.trang_thai_co_san
                               };
                return products.ToList();
            }
        }

        public ProductViewModel GetProductById(int productId, int storeId)
        {
            using (var db = new FastFoodDataContext())
            {
                var product = (from sp in db.SanPhams
                               join g in db.GiaVaTrangThaiSanPhamTaiCuaHangs on sp.id_san_pham equals g.id_san_pham
                               where sp.id_san_pham == productId && g.id_cua_hang == storeId
                               select new ProductViewModel
                               {
                                   Id = sp.id_san_pham,
                                   MaSanPham = sp.ma_san_pham,
                                   TenSanPham = sp.ten_san_pham,
                                   GiaBan = g.gia_ban, // Giá tại cửa hàng cụ thể
                                   HinhAnhUrl = sp.hinh_anh_url,
                                   MaDanhMuc = sp.id_danh_muc,
                                   CoSan = g.trang_thai_co_san
                               }).FirstOrDefault();
                return product;
                // Thêm xử lý nếu không tìm thấy sản phẩm (return null hoặc throw exception)
            }
        }

        public List<ProductViewModel> SearchAvailableProducts(int storeId, int categoryId, string searchTerm)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    // Bắt đầu với query cơ bản lấy sản phẩm active và có giá/trạng thái tại cửa hàng
                    var query = from sp in db.SanPhams
                                join g in db.GiaVaTrangThaiSanPhamTaiCuaHangs on sp.id_san_pham equals g.id_san_pham
                                where sp.trang_thai_chung == "active" &&
                                      g.id_cua_hang == storeId &&
                                      g.trang_thai_co_san == true // Chỉ tìm món đang có sẵn
                                select new // Chọn tạm các trường cần thiết
                                {
                                    sp.id_san_pham,
                                    sp.ma_san_pham,
                                    sp.ten_san_pham,
                                    g.gia_ban,
                                    sp.hinh_anh_url,
                                    sp.id_danh_muc,
                                    g.trang_thai_co_san
                                };

                    // Lọc theo Danh mục (nếu có và khác "Tất cả")
                    if (categoryId == 0)
                    {
                        query = query.Where(p => p.id_danh_muc == categoryId);
                    }

                    // Lọc theo Từ khóa tìm kiếm (nếu có)
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        string lowerSearchTerm = searchTerm.Trim().ToLower();
                        query = query.Where(p => p.ten_san_pham.ToLower().Contains(lowerSearchTerm) ||
                                                 p.ma_san_pham.ToLower().Contains(lowerSearchTerm));
                    }

                    // Map kết quả cuối cùng sang ViewModel
                    var results = query.Select(p => new ProductViewModel
                    {
                        Id = p.id_san_pham,
                        MaSanPham = p.ma_san_pham,
                        TenSanPham = p.ten_san_pham,
                        GiaBan = p.gia_ban,
                        HinhAnhUrl = p.hinh_anh_url,
                        MaDanhMuc = p.id_danh_muc,
                        CoSan = p.trang_thai_co_san
                    });

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in SearchAvailableProducts: {ex.ToString()}");
                    return new List<ProductViewModel>(); // Trả về rỗng nếu lỗi
                }
            }
        }

        public List<ProductViewModel> GetProductByConditon(string condition)
        {
            using (var db = new FastFoodDataContext())
            {
                // Giả sử có điều kiện nào đó để lọc sản phẩm
                var products = from sp in db.SanPhams
                               join g in db.GiaVaTrangThaiSanPhamTaiCuaHangs on sp.id_san_pham equals g.id_san_pham
                               where sp.trang_thai_chung == "active" && condition.Contains(sp.ten_san_pham)
                               select new ProductViewModel
                               {
                                   Id = sp.id_san_pham,
                                   MaSanPham = sp.ma_san_pham,
                                   TenSanPham = sp.ten_san_pham,
                                   GiaBan = g.gia_ban,
                                   HinhAnhUrl = sp.hinh_anh_url,
                                   MaDanhMuc = sp.id_danh_muc,
                                   CoSan = g.trang_thai_co_san
                               };
                return products.ToList();
            }
        }

        public List<ProductViewModel> GetVoucherProductByConditon(string condition)
        {
            if (condition == null)
                return null;

            condition = condition.Split(':')[1];
            List<int> numbers = condition.Contains(",")
                                    ? condition.Split(',').Select(int.Parse).ToList()
                                    : new List<int> { int.Parse(condition) };

            using (var db = new FastFoodDataContext())
            {
                // Giả sử có điều kiện nào đó để lọc danh mục
                var products = db.SanPhams
                                   .Where(dm => dm.trang_thai_chung == "active" && numbers.Contains(dm.id_san_pham))
                                   .Select(dm => new ProductViewModel { Id = dm.id_san_pham, TenSanPham = dm.ten_san_pham })
                                   .ToList();
                return products;
            }
        }
    }

    public class CategoryService : ICategoryService
    {
        public List<CategoryViewModel> GetAllCategories()
        {
            using (var db = new FastFoodDataContext())
            {
                // Lấy danh sách các danh mục duy nhất từ bảng SanPham
                var categories = db.DanhMucs
                                   .Where(dm => dm.trang_thai == "active") // Chỉ lấy từ SP active
                                   .Select(dm => new CategoryViewModel { CategoryId = dm.id_danh_muc, TenDanhMuc = dm.ten_danh_muc})
                                   .ToList();
                return categories;
            }
        }

        // Có thể thêm các phương thức khác nếu cần lọc category phức tạp hơn
        // Ví dụ: Lấy danh sách danh mục theo điều kiện nào đó
        // Hoặc thêm các thuộc tính khác cho CategoryViewModel nếu cần
        public List<CategoryViewModel> GetCategoriesByCondition(string condition)
        {
            MessageBox.Show(condition);
            if (condition == null)
                return null;

            condition = condition.Split(':')[1];
            List<int> numbers = condition.Contains(",")
                                    ? condition.Split(',').Select(int.Parse).ToList()
                                    : new List<int> { int.Parse(condition) };

            using (var db = new FastFoodDataContext())
            {
                // Giả sử có điều kiện nào đó để lọc danh mục
                var categories = db.DanhMucs
                                   .Where(dm => dm.trang_thai == "active" && numbers.Contains(dm.id_danh_muc))
                                   .Select(dm => new CategoryViewModel { CategoryId = dm.id_danh_muc, TenDanhMuc = dm.ten_danh_muc })
                                   .ToList();
                return categories;
            }
        }

        public string GetNameById(int categoryId)
        {
            using (var db = new FastFoodDataContext())
            {
                // Lấy tên danh mục theo ID
                var category = db.DanhMucs
                                 .Where(sp => sp.id_danh_muc == categoryId)
                                 .Select(sp => sp.ten_danh_muc)
                                 .FirstOrDefault();
                return category ?? "tất cả";
            }
        }
    }

    // Implement IOrderService khi cần xử lý logic đơn hàng phức tạp hơn
}