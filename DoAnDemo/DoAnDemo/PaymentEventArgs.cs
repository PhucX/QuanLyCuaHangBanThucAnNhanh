// PaymentEventArgs.cs (Cập nhật)
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoAnDemo // Hoặc namespace phù hợp
{
    public class PaymentEventArgs : EventArgs
    {
        public List<OrderItemViewModel> OrderItems { get; }
        public decimal TotalAmount { get; } // Tổng tiền cuối cùng phải thanh toán
        public int StoreId { get; }
        public int? MemberId { get; } // *** THÊM: ID Thành viên (nullable) ***
        // public string TableCode { get; } // Có thể thêm sau nếu cần
        // public DiscountInfo AppliedDiscount { get; } // Có thể thêm sau nếu cần

        // *** CẬP NHẬT CONSTRUCTOR ĐỂ NHẬN 4 THAM SỐ ***
        public PaymentEventArgs(List<OrderItemViewModel> items, decimal totalAmount, int storeId, int? memberId /*, string tableCode, DiscountInfo discount*/)
        {
            // Tạo bản sao list item để tránh lỗi tham chiếu
            OrderItems = items?.Select(i => new OrderItemViewModel
            {
                IdSanPham = i.IdSanPham,
                TenSanPham = i.TenSanPham,
                DonGia = i.DonGia,
                SoLuong = i.SoLuong,
                HinhAnhUrl = i.HinhAnhUrl,
                GhiChuMuc = i.GhiChuMuc
            }).ToList() ?? new List<OrderItemViewModel>();

            TotalAmount = totalAmount;
            StoreId = storeId;
            MemberId = memberId; // *** GÁN GIÁ TRỊ CHO MEMBER ID ***
            // TableCode = tableCode;
            // AppliedDiscount = discount;
        }
    }
}