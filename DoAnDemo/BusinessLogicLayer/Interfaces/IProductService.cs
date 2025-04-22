using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IProductService
    {
        // Lấy sản phẩm theo cửa hàng hiện tại (cần id_cua_hang)
        List<ProductViewModel> GetAvailableProductsByStore(int storeId);
        List<ProductViewModel> GetAvailableProductsByStoreAndCategory(int storeId, int categoryId);
        ProductViewModel GetProductById(int productId, int storeId); // Lấy thông tin chi tiết, bao gồm giá đúng tại cửa hàng
        List<ProductViewModel> SearchAvailableProducts(int storeId, int categoryId, string searchTerm);
        List<ProductViewModel> GetProductByConditon(string condition); // Lấy sản phẩm theo điều kiện (có thể dùng cho tìm kiếm nâng cao)
        List<ProductViewModel> GetVoucherProductByConditon(string condition);
    }

    public interface ICategoryService
    {
        List<CategoryViewModel> GetAllCategories();
        // Có thể thêm các phương thức khác nếu cần lọc category phức tạp hơn
        List<CategoryViewModel> GetCategoriesByCondition(string condition);
        string GetNameById(int categoryId);
    }

    // Interface này có thể chưa cần ngay cho việc hiển thị ban đầu,
    // nhưng sẽ cần khi xử lý thêm/xóa/tính toán đơn hàng
    public interface IOrderService
    {
        // Methods related to order processing (Calculate total, apply discount, save order etc.)
        // void AddItemToCurrentOrder(OrderItemViewModel item);
        // void RemoveItemFromCurrentOrder(int productId); // Hoặc dùng ID duy nhất của order item
        // List<OrderItemViewModel> GetCurrentOrderItems();
        // decimal CalculateSubTotal();
        // decimal CalculateTotalDiscount();
        // decimal CalculateTotalPayment();
        // void ClearCurrentOrder();
    }
}