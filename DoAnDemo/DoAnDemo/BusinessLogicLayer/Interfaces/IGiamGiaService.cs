using DoAnDemo.Models;
using System;
using System.Threading.Tasks;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IGiamGiaService
    {
        Task<bool> UpdateVoucherAsync(VoucherEditViewModel voucher);
    }
}