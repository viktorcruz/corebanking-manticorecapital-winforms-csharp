using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.Dapper
{
    public class BranchRepositoryDapper : IBranchRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";

        public BranchRepositoryDapper(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
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
