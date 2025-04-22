using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface INhanVienService
    {
        List<NhanVienViewModel> GetNhanVienList(int? storeId = null, string region = null);
        NhanVienViewModel GetNhanVienDetails(int employeeId); // Lấy chi tiết NV để sửa
        NhanVienViewModel AddNhanVien(NhanVienViewModel nvInfo, string plainPassword);
        /// <summary>Cập nhật thông tin nhân viên (không bao gồm mật khẩu).</summary>
        bool UpdateNhanVien(NhanVienViewModel nvInfo);
        bool ChangeNhanVienStatus(int employeeId, string newStatus);
    }
}
