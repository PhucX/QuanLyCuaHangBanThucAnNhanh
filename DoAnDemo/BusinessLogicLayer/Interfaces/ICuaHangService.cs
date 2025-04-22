using DoAnDemo.Models;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface ICuaHangService
    {
        List<StoreViewModel> GetAllStores();
        StoreViewModel GetStoreById(int storeId);
        bool AddStore(StoreViewModel storeInfo); // Sửa lại nếu trả về bool
        bool UpdateStore(StoreViewModel storeInfo);
        bool ChangeStoreStatus(int storeId, string newStatus);
        List<StoreViewModel> GetActiveStores();

        // *** THÊM: Lấy cửa hàng theo khu vực ***
        List<StoreViewModel> GetActiveStoresByRegion(string region);
        string GetStoreNameById(int storeId);
        string GetRegionByStoreId(int storeId);
        // *** THÊM: Lấy danh sách cửa hàng theo tìm kiếm ***
        List<StoreViewModel> SearchStores(string searchTerm);

        List<StoreViewModel> GetVoucherStore(int voucherId);
    }
}