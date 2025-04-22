using DoAnDemo.Models; // Namespace chứa OrderPaymentInfo
using System;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface IPaymentProcessingService
    {
        /// <summary>
        /// Xử lý lưu đơn hàng, chi tiết đơn hàng, lịch sử giao dịch vào CSDL.
        /// </summary>
        /// <param name="orderInfo">Thông tin đơn hàng và thanh toán.</param>
        /// <returns>True nếu xử lý thành công, False nếu thất bại.</returns>
        /// <exception cref="Exception">Ném ra lỗi nếu có vấn đề nghiêm trọng trong quá trình xử lý.</exception>
        bool ProcessOrderAndPayment(OrderPaymentInfo orderInfo);

        // Có thể thêm các phương thức khác liên quan đến thanh toán sau này
    }
}