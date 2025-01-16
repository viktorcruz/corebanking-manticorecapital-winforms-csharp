using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IAccountRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateAccountAsync(AccountEntity account);
        Task<IDatabaseActionResponse> UpdateAccountAsync(AccountEntity account);
        Task<IDatabaseActionResponse> DeleteAccountAsync(string accountId);

        // Queries
        Task<IDatabaseOperationResult<AccountEntity>> GetAccountByIdAsync(string accountId);
        Task<IDatabaseOperationResult<List<AccountEntity>>> GetAccountPaginatedAsync(int pageNumber, int pageSize, string? search);
    }
}
