using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface ILoanRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateLoanAsync(LoanEntity loan);
        Task<IDatabaseActionResponse> UpdateLoanAsync(LoanEntity loan);
        Task<IDatabaseActionResponse> DeleteLoanAsync(string loanId);

        // Queries
        Task<IDatabaseOperationResult<LoanEntity>> GetLoanByIdAsync(string loanId);
        Task<IDatabaseOperationResult<List<LoanEntity>>> GetLoanPaginatedAsync(int pageNumber, int pageSize, string? search);

    }
}
