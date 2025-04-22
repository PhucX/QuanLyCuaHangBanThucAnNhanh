// --- BusinessLogicLayer/Interfaces ---
using DoAnDemo.Models;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IMemberService
    {
        List<MemberViewModel> SearchMembers(string keyword);
        List<FavoriteFoodViewModel> GetMemberFavoriteFoods(int memberId, int storeId, int topN = 5);
        List<VoucherViewModel> GetMemberAvailableVouchers(int memberId);
        bool UpdateMemberNote(int memberId, string note);
        bool AddFundsToWallet(int memberId, int storeId, decimal amount, int employeeId);
        MemberViewModel RegisterMember(MemberViewModel newMemberInfo);
        List<MemberViewModel> GetAllMembers();
        /// <summary>Lấy thông tin chi tiết của thành viên để chỉnh sửa.</summary>
        MemberViewModel GetMemberDetails(int memberId);

        /// <summary>Cập nhật thông tin thành viên.</summary>
        /// <returns>True nếu cập nhật thành công.</returns>
        bool UpdateMember(MemberViewModel memberInfo);
        // *** Lấy thống kê chi tiết ***
        MemberStatsViewModel GetMemberStatistics(int memberId);

        // *** THÊM PHƯƠNG THỨC CHO SEND VOUCHER ***
        /// <summary>Lấy danh sách ID thành viên theo nhóm/hạng.</summary>
        List<int> GetMemberIdsByGroup(string memberGroup);

        /// <summary>Xác thực danh sách Mã TV hoặc SĐT, trả về danh sách ID hợp lệ.</summary>
        List<int> ValidateMemberIdentifiers(List<string> identifiers);
    }

    public interface IGiftService
    {
        List<GiftViewModel> GetAvailableGiftsForMember(int memberPoints);
        // Thêm phương thức đổi quà...
    }
}