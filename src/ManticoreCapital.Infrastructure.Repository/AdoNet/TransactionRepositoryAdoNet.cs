using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.AdoNet
{
    public class TransactionRepositoryAdoNet : ITransactionRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";

        public TransactionRepositoryAdoNet(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
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
