using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.Dapper
{
    public class EmployeeRepositoryDapper : IEmployeeRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";

        public EmployeeRepositoryDapper(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public Task<IDatabaseActionResponse> CreateEmployeeAsync(EmployeeEntity employee)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteEmployeeAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<EmployeeEntity>> GetEmployeeByIdAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<EmployeeEntity>>> GetEmployeePaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateEmployeeAsync(EmployeeEntity employee)
        {
            throw new NotImplementedException();
        }
    }
}
