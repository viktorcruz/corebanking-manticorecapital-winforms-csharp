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
    public class AccountRepositoryAdoNet : IAccountRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";

        public AccountRepositoryAdoNet(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public Task<IDatabaseActionResponse> CreateAccountAsync(AccountEntity account)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteAccountAsync(string accountId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<AccountEntity>> GetAccountByIdAsync(string accountId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<AccountEntity>>> GetAccountPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateAccountAsync(AccountEntity account)
        {
            throw new NotImplementedException();
        }
    }
}
