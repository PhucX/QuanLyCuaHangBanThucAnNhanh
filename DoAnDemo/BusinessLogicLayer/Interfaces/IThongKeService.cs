// --- BusinessLogicLayer/Interfaces/IThongKeService.cs ---
using System;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    // ViewModel chứa dữ liệu thống kê tổng hợp (ví dụ)
    public class ThongKeTongHopViewModel
    {
        public string TiLeDoiDiemFormatted { get; set; } // Format sẵn dạng text
        public int SoChiNhanh { get; set; }
        public int SoNhanVien { get; set; }
        // Thêm các số liệu khác nếu cần
    }

    public interface IThongKeService
    {
        /// <summary>
        /// Lấy dữ liệu thống kê tổng hợp cho dashboard Quản lý.
        /// </summary>
        ThongKeTongHopViewModel GetThongKeTongHop();
    }
}