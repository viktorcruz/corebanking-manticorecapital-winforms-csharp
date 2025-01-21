using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IEmployeeRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateEmployeeAsync(EmployeeEntity employee);
        Task<IDatabaseActionResponse> UpdateEmployeeAsync(EmployeeEntity employee);
        Task<IDatabaseActionResponse> DeleteEmployeeAsync(string employeeId);

        // Queries
        Task<IDatabaseOperationResult<EmployeeEntity>> GetEmployeeByIdAsync(string employeeId);
        Task<IDatabaseOperationResult<List<EmployeeEntity>>> GetEmployeePaginatedAsync(int pageNumber, int pageSize, string? search);
    }
}
