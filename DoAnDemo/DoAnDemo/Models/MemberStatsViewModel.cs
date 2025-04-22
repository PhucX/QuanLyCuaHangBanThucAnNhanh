// --- Models/MemberStatsViewModel.cs ---
using System;
using System.Collections.Generic;

namespace DoAnDemo.Models
{
    /// <summary>
    /// Chứa thông tin thống kê chi tiết của thành viên.
    /// </summary>
    public class MemberStatsViewModel
    {
        public DateTime JoinDate { get; set; }
        public decimal TotalSpent { get; set; }
        public Dictionary<string, int> OrderTypeCounts { get; set; } // Key: loai_don_hang, Value: count
        public Dictionary<string, int> StoreVisitCounts { get; set; } = new Dictionary<string, int>();
        // Thêm các thống kê khác nếu cần
    }
}