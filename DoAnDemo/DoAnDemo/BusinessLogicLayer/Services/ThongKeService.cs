// --- BusinessLogicLayer/Services/ThongKeService.cs (Placeholder) ---
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer; // Cần để truy vấn DB
using System;
using System.Linq;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class ThongKeService : IThongKeService
    {
        public ThongKeTongHopViewModel GetThongKeTongHop()
        {
            // --- TODO: Implement logic truy vấn CSDL thực tế ---
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    // Lấy số chi nhánh đang hoạt động
                    int soChiNhanh = db.CuaHangs.Count(ch => ch.trang_thai == "dang_hoat_dong");

                    // Lấy số nhân viên đang làm việc
                    int soNhanVien = db.NhanViens.Count(nv => nv.trang_thai == "dang_lam_viec");

                    // Lấy tỷ lệ đổi điểm (Ví dụ: lấy từ cài đặt hoặc tính toán phức tạp hơn)
                    string tiLeDoiDiem = "1000đ = 1 điểm"; // Placeholder

                    return new ThongKeTongHopViewModel
                    {
                        TiLeDoiDiemFormatted = tiLeDoiDiem,
                        SoChiNhanh = soChiNhanh,
                        SoNhanVien = soNhanVien
                    };
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting ThongKeTongHop: {ex.ToString()}");
                    // Trả về giá trị mặc định hoặc ném lỗi
                    return new ThongKeTongHopViewModel { TiLeDoiDiemFormatted = "Lỗi", SoChiNhanh = 0, SoNhanVien = 0 };
                }
            }
        }
    }
}