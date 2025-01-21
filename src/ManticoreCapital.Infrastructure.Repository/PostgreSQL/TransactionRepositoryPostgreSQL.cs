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
    public class TransactionRepositoryPostgreSQL : ITransactionRepository
    {
        public Task<IDatabaseActionResponse> CreateTransactionAsync(TransactionEntity transaction)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteTransactionAsync(string transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<TransactionEntity>> GetTransactionByIdAsync(string transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<TransactionEntity>>> GetTransactionPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateTransacitonAsync(TransactionEntity transaciton)
        {
            throw new NotImplementedException();
        }
    }
}
