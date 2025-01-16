using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IPaymentRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreatePaymentAsync(PaymentEntity payment);
        Task<IDatabaseActionResponse> UpdatePaymentAsync(PaymentEntity payment);
        Task<IDatabaseActionResponse> DeletePaymentAsync(string paymentId);

        // Queries
        Task<IDatabaseOperationResult<PaymentEntity>> GetPyamentByIdAsync(PaymentEntity payment);
        Task<IDatabaseOperationResult<List<PaymentEntity>>> GetPaymentPaginatedAsync(int pageNumber, int pageSize, string? search);
    }
}
