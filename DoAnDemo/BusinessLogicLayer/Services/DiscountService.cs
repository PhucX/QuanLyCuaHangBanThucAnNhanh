// --- BusinessLogicLayer/Services/DiscountService.cs ---
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class DiscountService : IDiscountService
    {
        // --- Hàm cho phần Bán hàng (đã có placeholder) ---
        public List<DiscountInfo> GetApplicableDiscounts(decimal subTotal, int? memberId, int storeId, List<OrderItemViewModel> items)
        {
            // --- TODO: Implement Real Logic ---
            Log($"Getting applicable discounts for SubTotal={subTotal}, MemberId={memberId}, StoreId={storeId}");
            // --- Placeholder Data ---
            var list = new List<DiscountInfo>();
            if (subTotal >= 50000) list.Add(new DiscountInfo { Id = 2, MaGiamGia = "GIAM10PT", MoTa = "Giảm 10% (Tối đa 15k)", LoaiGiamGia = "percentage", GiaTriGiam = 10, GiamGiaToiDa = 15000, GiaTriDonHangToiThieu = 50000 });
            if (subTotal >= 100000) list.Add(new DiscountInfo { Id = 1, MaGiamGia = "GIAM10K", MoTa = "Giảm 10.000đ", LoaiGiamGia = "fixed_amount", GiaTriGiam = 10000, GiamGiaToiDa = null, GiaTriDonHangToiThieu = 100000 });
            if (memberId.HasValue) list.Add(new DiscountInfo { Id = 1000 + memberId.Value, MaGiamGia = $"TV{memberId.Value}SPECIAL", MoTa = $"Ưu đãi TV {memberId.Value}", LoaiGiamGia = "fixed_amount", GiaTriGiam = 5000, GiaTriDonHangToiThieu = 0 });
            return list;
        }

        public DiscountInfo ValidateAndGetVoucher(string voucherCode, decimal subTotal, int? memberId, int storeId, List<OrderItemViewModel> items)
        {
            if (string.IsNullOrWhiteSpace(voucherCode)) return null;
            Log($"Validating voucher code: {voucherCode}");
            // --- TODO: Implement Real Logic ---
            // --- Placeholder Data ---
            if (voucherCode.Equals("GIAM10K", StringComparison.OrdinalIgnoreCase) && subTotal >= 100000) return new DiscountInfo { Id = 1, MaGiamGia = "GIAM10K", MoTa = "Giảm 10.000đ", LoaiGiamGia = "fixed_amount", GiaTriGiam = 10000, GiamGiaToiDa = null, GiaTriDonHangToiThieu = 100000 };
            if (voucherCode.Equals("TEST5K", StringComparison.OrdinalIgnoreCase)) return new DiscountInfo { Id = 999, MaGiamGia = "TEST5K", MoTa = "Giảm test 5.000đ", LoaiGiamGia = "fixed_amount", GiaTriGiam = 5000, GiaTriDonHangToiThieu = 0 };
            return null; // Không hợp lệ
        }

        // --- TODO: Implement các phương thức quản lý cho Admin ---
        /*
        public List<VoucherViewModel> GetAllVouchers() { ... }
        public VoucherViewModel GetVoucherDetails(int voucherId) { ... }
        public bool AddVoucher(VoucherViewModel newVoucher) { ... }
        public bool UpdateVoucher(VoucherViewModel voucher) { ... }
        public bool ChangeVoucherStatus(int voucherId, string newStatus) { ... }
        */

        private void Log(string message) { Debug.WriteLine($"[DiscountService] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[DiscountService ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    }
}