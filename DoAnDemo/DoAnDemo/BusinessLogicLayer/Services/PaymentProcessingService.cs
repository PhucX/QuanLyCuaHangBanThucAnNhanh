// --- Đặt trong thư mục BusinessLogicLayer/Services ---
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.Models;
using DoAnDemo.DataLayer; // Namespace chứa DataContext
using System;
using System.Linq;
using System.Transactions;
using System.Windows.Forms; // Cần cho TransactionScope

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class PaymentProcessingService : IPaymentProcessingService
    {
        public bool ProcessOrderAndPayment(OrderPaymentInfo orderInfo)
        {
            // ----- LOGIC THỰC TẾ SẼ ĐƯỢC IMPLEMENT Ở ĐÂY -----
            // Sử dụng TransactionScope để đảm bảo toàn vẹn dữ liệu
            using (var scope = new TransactionScope())
            {
                try
                {
                    using (var db = new FastFoodDataContext()) // Khởi tạo DataContext
                    {
                        // 1. Tạo mã đơn hàng duy nhất (Ví dụ)
                        string maDonHang = $"HD{orderInfo.StoreId}-{DateTime.Now:yyyyMMddHHmmss}";

                        // 2. Tạo và Lưu đối tượng DonHang
                        var donHang = new DonHang
                        {
                            ma_don_hang = maDonHang,
                            id_cua_hang = orderInfo.StoreId,
                            id_thanh_vien = orderInfo.MemberId,
                            id_nhan_vien_tao_don = orderInfo.EmployeeId,
                            loai_don_hang = orderInfo.OrderType,
                            so_ban = orderInfo.TableCode,
                            thoi_gian_dat = DateTime.Now,
                            tong_tien_hang = orderInfo.SubTotal, // Tổng tiền hàng gốc
                            id_thanhvien_voucher_apdung = null, // Cần logic voucher
                            tien_giam_voucher = 0, // Cần logic voucher
                            diem_tich_luy_duoc = orderInfo.PointsEarned,
                            diem_su_dung_thanh_toan = orderInfo.PointsSpent,
                            tien_giam_tu_diem = orderInfo.AmountReducedByPoints,
                            tong_giam_gia = orderInfo.DiscountTotal, // Tổng tất cả giảm giá
                            phu_phi = orderInfo.FeeTotal,
                            thue_vat = orderInfo.VatAmount,
                            thanh_tien = orderInfo.TotalAmountDue, // Số tiền cuối cùng phải trả
                            hinh_thuc_thanh_toan = orderInfo.PaymentMethod,
                            trang_thai_thanh_toan = "da_thanh_toan", // Đã thanh toán
                            trang_thai_don_hang = "hoan_thanh", // Hoàn thành (hoặc trạng thái phù hợp khác)
                            ghi_chu_khach_hang = orderInfo.CustomerNote,
                            ghi_chu_noi_bo = orderInfo.InternalNote
                        };
                        db.DonHangs.InsertOnSubmit(donHang);
                        db.SubmitChanges(); // Submit để lấy ID đơn hàng mới

                        // 3. Lưu các đối tượng ChiTietDonHang
                        foreach (var item in orderInfo.Items)
                        {
                            var chiTiet = new ChiTietDonHang
                            {
                                id_don_hang = donHang.id_don_hang, // Lấy ID từ đơn hàng vừa lưu
                                id_san_pham = item.IdSanPham,
                                ten_san_pham_luc_dat = item.TenSanPham,
                                so_luong = item.SoLuong,
                                don_gia_luc_dat = item.DonGia,
                                thanh_tien_muc = item.ThanhTien, // = DonGia * SoLuong
                                ghi_chu_muc = item.GhiChuMuc
                            };
                            db.ChiTietDonHangs.InsertOnSubmit(chiTiet);
                        }

                        // 4. Cập nhật thông tin Thành viên (Điểm, Ví) - Nếu có MemberId
                        if (orderInfo.MemberId.HasValue)
                        {
                            var thanhVien = db.ThanhViens.FirstOrDefault(tv => tv.id_thanh_vien == orderInfo.MemberId.Value);
                            if (thanhVien != null)
                            {
                                // Cộng điểm tích lũy
                                thanhVien.diem_tich_luy += orderInfo.PointsEarned;
                                // Trừ điểm đã dùng (nếu có)
                                thanhVien.diem_tich_luy -= orderInfo.PointsSpent;
                                // Cập nhật ví tiền nếu thanh toán bằng ví hoặc có hoàn tiền vào ví
                                // thanhVien.vi_tien -= ...
                                // thanhVien.vi_tien += ...
                            }
                        }

                        // 5. Ghi Lịch sử giao dịch (Điểm, Ví) - Nếu có MemberId
                        if (orderInfo.MemberId.HasValue)
                        {
                            // Ghi log tích điểm
                            if (orderInfo.PointsEarned > 0)
                            {
                                var gdTichDiem = new LichSuGiaoDich { /* ... điền thông tin ... */ };
                                // db.LichSuGiaoDichs.InsertOnSubmit(gdTichDiem);
                            }
                            // Ghi log dùng điểm
                            if (orderInfo.PointsSpent > 0)
                            {
                                var gdDungDiem = new LichSuGiaoDich { /* ... điền thông tin ... */ };
                                // db.LichSuGiaoDichs.InsertOnSubmit(gdDungDiem);
                            }
                            // Ghi log các giao dịch ví tiền khác nếu có
                        }

                        // 6. Submit tất cả các thay đổi còn lại
                        db.SubmitChanges();

                        // Nếu mọi thứ thành công, hoàn tất transaction
                        scope.Complete();
                        Console.WriteLine($"Đơn hàng {maDonHang} đã được xử lý thành công."); // Ghi log thành công
                        return true; // Trả về thành công
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi chi tiết
                    Console.WriteLine($"Lỗi nghiêm trọng khi xử lý thanh toán: {ex.ToString()}");
                    // Transaction sẽ tự động rollback khi ra khỏi using scope mà không gọi Complete()
                    // Hoặc có thể throw lại lỗi để lớp gọi xử lý
                    // throw;
                    return false; // Trả về thất bại
                }
            } // Kết thúc TransactionScope
        }
    }
}