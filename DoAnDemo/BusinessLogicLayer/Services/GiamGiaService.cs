using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class GiamGiaService : IGiamGiaService
    {
        public async Task<bool> UpdateVoucherAsync(VoucherEditViewModel voucher)
        {
            try
            {
                using (var db = new FastFoodDataContext())
                {
                    var entity = db.Vouchers.FirstOrDefault(v => v.id_voucher == voucher.Id);
                    if (entity == null) return false;

                    entity.ten_voucher = voucher.TenVoucher;
                    entity.ma_voucher = voucher.MaVoucher;
                    entity.loai_giam_gia = voucher.LoaiGiamGia;
                    entity.gia_tri_giam = voucher.GiaTriGiam;
                    entity.ngay_bat_dau = voucher.NgayBatDau;
                    entity.ngay_ket_thuc = voucher.NgayKetThuc;
                    entity.trang_thai = voucher.TrangThai;

                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[GiamGiaService ERROR] UpdateVoucherAsync: {ex}");
                return false;
            }
        }
    }
}