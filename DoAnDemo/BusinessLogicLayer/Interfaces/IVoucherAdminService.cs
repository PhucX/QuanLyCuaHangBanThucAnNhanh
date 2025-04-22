// --- BusinessLogicLayer/Interfaces/IVoucherAdminService.cs (Thêm phương thức) ---
using DoAnDemo.Models;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IVoucherAdminService // Hoặc tên interface phù hợp
    {
        List<VoucherEditViewModel> GetAllVoucherPrograms();
        List<int> GetAppliedStoreIdsForVoucher(int voucherId);
        VoucherEditViewModel GetVoucherDetailsForEdit(int voucherId);
        VoucherEditViewModel AddVoucher(VoucherEditViewModel newVoucherData);
        bool UpdateVoucher(VoucherEditViewModel voucherData);
        bool ChangeVoucherStatus(int voucherId, string newStatus);

        /// <summary>Lấy danh sách voucher đang hoạt động có thể gửi cho TV.</summary>
        List<VoucherEditViewModel> GetActiveVouchersForSending(); // Sử dụng EditViewModel để có đủ thông tin

        /// <summary>Gán danh sách voucher cho một nhóm thành viên.</summary>
        /// <returns>True nếu thành công.</returns>
        bool AssignVouchersToGroup(List<int> voucherIds, string memberGroup);

        /// <summary>Gán danh sách voucher cho danh sách thành viên cụ thể.</summary>
        /// <returns>True nếu thành công.</returns>
        bool AssignVouchersToMembers(List<int> voucherIds, List<int> memberIds);
    }
}