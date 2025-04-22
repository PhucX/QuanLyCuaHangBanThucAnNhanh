// --- BusinessLogicLayer/Interfaces/IOrderQueryService.cs (hoặc thêm vào IOrderService) ---
using DoAnDemo.Models;
using System;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IOrderQueryService // Hoặc tên khác phù hợp
    {
        /// <summary>
        /// Lấy danh sách các đơn hàng tóm tắt trong ngày cho một cửa hàng.
        /// </summary>
        /// <param name="storeId">ID cửa hàng.</param>
        /// <param name="filterKeyword">Từ khóa tìm kiếm (mã đơn, tên NV, tên TV) - tùy chọn.</param>
        /// <returns>Danh sách OrderSummaryViewModel.</returns>
        List<OrderSummaryViewModel> GetTodayOrdersSummary(int storeId, string filterKeyword = null);

        // Thêm các phương thức khác nếu cần (đánh dấu lỗi, lấy chi tiết đơn để in...)
        // bool MarkOrderAsFaulty(int orderId, string reason, int employeeId);
        // OrderDetailViewModel GetOrderDetailsForPrinting(int orderId);
    }
}