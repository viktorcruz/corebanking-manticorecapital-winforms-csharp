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
    public class CustomerRepositoryDapper : ICustomerRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";
        public CustomerRepositoryDapper(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public Task<IDatabaseActionResponse> CreateCustomerAsync(CustomerEntity customer)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteCustomerAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<CustomerEntity>> GetCustomerByIdAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<CustomerEntity>>> GetCustomerPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateCustomerAsync(CustomerEntity customer)
        {
            throw new NotImplementedException();
        }
    }
}
