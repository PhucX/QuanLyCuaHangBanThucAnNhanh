// --- BusinessLogicLayer/Services/OrderQueryService.cs (Placeholder Implementation) ---
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class OrderQueryService : IOrderQueryService
    {
        public List<OrderSummaryViewModel> GetTodayOrdersSummary(int storeId, string filterKeyword = null)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    DateTime todayStart = DateTime.Today; // Bắt đầu từ 00:00:00 hôm nay
                    DateTime tomorrowStart = todayStart.AddDays(1); // Bắt đầu ngày mai

                    var query = from dh in db.DonHangs
                                join nv in db.NhanViens on dh.id_nhan_vien_tao_don equals nv.id_nhan_vien
                                join tv in db.ThanhViens on dh.id_thanh_vien equals tv.id_thanh_vien into tvj // Left Join với Thành Viên
                                from thanhvien in tvj.DefaultIfEmpty() // Để xử lý đơn hàng không có thành viên
                                where dh.id_cua_hang == storeId &&
                                      dh.thoi_gian_dat >= todayStart &&
                                      dh.thoi_gian_dat < tomorrowStart
                                // Thêm điều kiện lọc nếu có filterKeyword
                                && (string.IsNullOrWhiteSpace(filterKeyword) ||
                                    dh.ma_don_hang.Contains(filterKeyword) ||
                                    nv.ten_nhan_vien.Contains(filterKeyword) ||
                                    (thanhvien != null && thanhvien.ten_thanh_vien.Contains(filterKeyword)) ||
                                    (thanhvien != null && thanhvien.so_dien_thoai.Contains(filterKeyword)))
                                orderby dh.thoi_gian_dat descending // Sắp xếp mới nhất lên đầu
                                select new OrderSummaryViewModel
                                {
                                    IdDonHang = dh.id_don_hang,
                                    MaDonHang = dh.ma_don_hang,
                                    ThoiGianDat = dh.thoi_gian_dat,
                                    ThanhTien = dh.thanh_tien,
                                    HinhThucThanhToan = dh.hinh_thuc_thanh_toan,
                                    TrangThaiDonHang = dh.trang_thai_don_hang,
                                    TenNhanVien = nv.ten_nhan_vien,
                                    TenThanhVien = (thanhvien != null) ? thanhvien.ten_thanh_vien : "Khách lẻ",
                                    // Lấy danh sách món ăn (rút gọn) - Cần tối ưu hóa query này
                                    ItemsSnippet = (from ctdh in db.ChiTietDonHangs
                                                    where ctdh.id_don_hang == dh.id_don_hang
                                                    select new OrderItemSnippetViewModel
                                                    {
                                                        TenSanPham = ctdh.ten_san_pham_luc_dat,
                                                        SoLuong = ctdh.so_luong
                                                    }).Take(3).ToList() // Chỉ lấy tối đa 3 món đầu tiên làm snippet
                                };

                    return query.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching today's orders for store {storeId}: {ex.ToString()}");
                    return new List<OrderSummaryViewModel>();
                }
            }
        }
        // Implement các phương thức khác (MarkOrderAsFaulty, GetOrderDetailsForPrinting...)
    }
}