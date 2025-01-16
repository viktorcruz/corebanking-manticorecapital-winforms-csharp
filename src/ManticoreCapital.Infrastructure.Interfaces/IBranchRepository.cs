using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IBranchRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateBranchAsync(BranchEntity branch);
        Task<IDatabaseActionResponse> UpdateBranchAsync(BranchEntity branch);
        Task<IDatabaseActionResponse> DeleteBranchAsync(string branchId);

        // Queries
        Task<IDatabaseOperationResult<BranchEntity>> GetBranchByIdAsync(BranchEntity branch);
        Task<IDatabaseOperationResult<List<BranchEntity>>> GetBranchPaginatedAsync(int pageNumber, int pageSize, string? search);
    }
}
