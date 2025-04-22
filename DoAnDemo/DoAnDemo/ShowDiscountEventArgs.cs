// --- Models/EventArgs/ShowDiscountEventArgs.cs ---
using DoAnDemo.Models;
using System;
using System.Collections.Generic;

namespace DoAnDemo.Models // Hoặc DoAnDemo
{
    public class ShowDiscountEventArgs : EventArgs
    {
        public List<OrderItemViewModel> Items { get; }
        public decimal SubTotal { get; }
        public int? MemberId { get; }
        public int StoreId { get; }

        public ShowDiscountEventArgs(List<OrderItemViewModel> items, decimal subTotal, int? memberId, int storeId)
        {
            Items = items ?? new List<OrderItemViewModel>();
            SubTotal = subTotal;
            MemberId = memberId;
            StoreId = storeId;
        }
    }
}