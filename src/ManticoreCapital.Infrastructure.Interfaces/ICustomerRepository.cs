using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface ICustomerRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateCustomerAsync(CustomerEntity customer);
        Task<IDatabaseActionResponse> UpdateCustomerAsync(CustomerEntity customer);
        Task<IDatabaseActionResponse> DeleteCustomerAsync(string customerId);

        // Queries
        Task<IDatabaseOperationResult<CustomerEntity>> GetCustomerByIdAsync(string customerId);
        Task<IDatabaseOperationResult<List<CustomerEntity>>> GetCustomerPaginatedAsync(int pageNumber, int pageSize, string? search);
    }
}
