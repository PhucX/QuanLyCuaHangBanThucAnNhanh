// --- Đặt trong thư mục Models hoặc DTOs ---
using System;
using System.Collections.Generic;

namespace DoAnDemo.Models
{
    public class OrderPaymentInfo
    {
        // Thông tin cơ bản từ FormThanhToan
        public List<OrderItemViewModel> Items { get; set; }
        public decimal TotalAmountDue { get; set; } // Tổng tiền phải trả (Thành tiền)
        public decimal AmountPaidByCustomer { get; set; } // Tiền khách đưa
        public decimal ChangeDue { get; set; } // Tiền thối
        public string PaymentMethod { get; set; } // Phương thức thanh toán ("Cash", "Bank Transfer", ...)

        // Thông tin ngữ cảnh cần lấy/truyền vào
        public int StoreId { get; set; }
        public int EmployeeId { get; set; } // ID nhân viên thực hiện
        public string OrderType { get; set; } // "tai_cho", "mang_di", "giao_hang"
        public int? MemberId { get; set; } // ID thành viên (có thể null)
        public string TableCode { get; set; } // Số bàn hoặc mã đơn mang đi/giao hàng (có thể null)

        // Thông tin tính toán khác (cần bổ sung logic tính toán thực tế)
        public decimal SubTotal { get; set; } // Tổng tiền hàng (trước giảm giá, phí)
        public decimal DiscountTotal { get; set; } // Tổng giảm giá
        public decimal FeeTotal { get; set; } // Tổng phụ phí
        public decimal VatAmount { get; set; } // Thuế VAT (nếu có)
        public int PointsEarned { get; set; } // Điểm tích lũy được
        public int PointsSpent { get; set; } // Điểm đã sử dụng để thanh toán
        public decimal AmountReducedByPoints { get; set; } // Số tiền được giảm từ điểm

        public string CustomerNote { get; set; } // Ghi chú khách hàng (nếu có)
        public string InternalNote { get; set; } // Ghi chú nội bộ (nếu có)
    }
}