using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.PostgreSQL
{
    public class BranchRepositoryPostgreSQL : IBranchRepository
    {
        public Task<IDatabaseActionResponse> CreateBranchAsync(BranchEntity branch)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteBranchAsync(string branchId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<BranchEntity>> GetBranchByIdAsync(BranchEntity branch)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<BranchEntity>>> GetBranchPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateBranchAsync(BranchEntity branch)
        {
            throw new NotImplementedException();
        }
    }
}
