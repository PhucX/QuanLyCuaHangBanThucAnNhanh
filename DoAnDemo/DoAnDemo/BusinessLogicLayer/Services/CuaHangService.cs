// --- BusinessLogicLayer/Services/CuaHangService.cs ---
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.DataLayer;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows;

namespace DoAnDemo.BusinessLogicLayer.Services
{
    public class CuaHangService : ICuaHangService 
    {
        public List<StoreViewModel> GetActiveStores()
        {
            using (var db = new FastFoodDataContext())
            {
                try 
                {
                    return db.CuaHangs
                        .Where(ch => ch.trang_thai == "dang_hoat_dong")
                        .OrderBy(ch => ch.ten_cua_hang)
                        .Select(ch => MapToViewModel(ch))
                        .ToList();
                }
                catch (Exception ex)
                {
                    LogError("GetActiveStores", ex);
                    return new List<StoreViewModel>();
                }
            }
        }

        public List<StoreViewModel> GetActiveStoresByRegion(string region)
        {
            if (string.IsNullOrWhiteSpace(region))
                return new List<StoreViewModel>();
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    return db.CuaHangs
                        .Where(ch => ch.trang_thai == "dang_hoat_dong" && 
                               ch.khu_vuc.Equals(region))
                        .OrderBy(ch => ch.ten_cua_hang)
                        .Select(ch => MapToViewModel(ch))
                        .ToList();
                }
                catch (Exception ex)
                {
                    LogError($"GetActiveStoresByRegion: {region}", ex);
                    return new List<StoreViewModel>();
                }
            }
        }

        public List<StoreViewModel> GetAllStores()
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    return db.CuaHangs
                        .OrderBy(ch => ch.ten_cua_hang)
                        .Select(ch => MapToViewModel(ch))
                        .ToList();
                }
                catch (Exception ex)
                {
                    LogError("GetAllStores", ex);
                    return new List<StoreViewModel>();
                }
            }
        }

        public StoreViewModel GetStoreById(int storeId)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var store = db.CuaHangs.FirstOrDefault(ch => ch.id_cua_hang == storeId);
                    return MapToViewModel(store);
                }
                catch (Exception ex)
                {
                    LogError($"GetStoreById: {storeId}", ex);
                    return null;
                }
            }
        }

        private static StoreViewModel MapToViewModel(CuaHang entity)
        {
            if (entity == null)
                return null;

            return new StoreViewModel
            {
                Id = entity.id_cua_hang,
                MaCuaHang = entity.ma_cua_hang,
                TenCuaHang = entity.ten_cua_hang,
                DiaChi = entity.dia_chi,
                SoDienThoai = entity.so_dien_thoai,
                KhuVuc = entity.khu_vuc,
                TrangThai = entity.trang_thai
            };
        }

        public string GetStoreNameById(int storeId)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var store = db.CuaHangs.FirstOrDefault(ch => ch.id_cua_hang == storeId);
                    return store?.ten_cua_hang;
                }
                catch (Exception ex)
                {
                    LogError($"GetNameById: {storeId}", ex);
                    return null;
                }
            }
        }

        public List<StoreViewModel> SearchStores(string searchTerm)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    return db.CuaHangs
                        .Where(ch => ch.ten_cua_hang.Contains(searchTerm) ||
                                     ch.dia_chi.Contains(searchTerm))
                        .OrderBy(ch => ch.ten_cua_hang)
                        .Select(ch => MapToViewModel(ch))
                        .ToList();
                }
                catch (Exception ex)
                {
                    LogError($"SearchStores: {searchTerm}", ex);
                    return new List<StoreViewModel>();
                }
            }
        }

        public string GetRegionByStoreId(int storeId)
        {
            using (var db = new FastFoodDataContext())
            {
                try
                {
                    var store = db.CuaHangs.FirstOrDefault(ch => ch.id_cua_hang == storeId);
                    return store?.khu_vuc;
                }
                catch (Exception ex)
                {
                    LogError($"GetRegionByStoreId: {storeId}", ex);
                    return null;
                }
            }
        }

        public List<StoreViewModel> GetVoucherStore(int voucherId)
        {
            using (FastFoodDataContext db = new FastFoodDataContext())
            {
                var stores = db.Voucher_ApDung_CuaHangs
                                .Where(s => s.id_voucher ==  voucherId)
                                .Select(s => new StoreViewModel { Id = s.id_cua_hang })
                                .ToList();
                return stores;
            }
        }
        private void LogError(string context, Exception ex)
        {
            Debug.WriteLine($"[CuaHangService ERROR] {context}: {ex?.Message}");
        }

        // Implementation for other interface methods if needed
        public bool AddStore(StoreViewModel store) { throw new NotImplementedException(); }
        public bool UpdateStore(StoreViewModel store) { throw new NotImplementedException(); }
        public bool ChangeStoreStatus(int storeId, string newStatus) { throw new NotImplementedException(); }
    }
}