// --- BusinessLogicLayer/Interfaces/IDiscountService.cs ---
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IDiscountService
    {
        /// <summary>
        /// Lấy danh sách các giảm giá/voucher có thể áp dụng cho đơn hàng hiện tại.
        /// </summary>
        List<DiscountInfo> GetApplicableDiscounts(decimal subTotal, int? memberId, int storeId, List<OrderItemViewModel> items);

        /// <summary>
        /// Kiểm tra và lấy thông tin chi tiết của một mã voucher nhập tay.
        /// </summary>
        /// <returns>DiscountInfo nếu mã hợp lệ và áp dụng được, null nếu không.</returns>
        DiscountInfo ValidateAndGetVoucher(string voucherCode, decimal subTotal, int? memberId, int storeId, List<OrderItemViewModel> items);
    }
}