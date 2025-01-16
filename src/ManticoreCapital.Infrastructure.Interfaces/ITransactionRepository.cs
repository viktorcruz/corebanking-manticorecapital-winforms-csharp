using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface ITransactionRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateTransactionAsync(TransactionEntity transaction);
        Task<IDatabaseActionResponse> UpdateTransacitonAsync(TransactionEntity transaciton);
        Task<IDatabaseActionResponse> DeleteTransactionAsync(string transactionId);

        // Queries
        Task<IDatabaseOperationResult<TransactionEntity>> GetTransactionByIdAsync(string transactionId);
        Task<IDatabaseOperationResult<List<TransactionEntity>>> GetTransactionPaginatedAsync(int pageNumber, int pageSize, string? search);

    }
}
