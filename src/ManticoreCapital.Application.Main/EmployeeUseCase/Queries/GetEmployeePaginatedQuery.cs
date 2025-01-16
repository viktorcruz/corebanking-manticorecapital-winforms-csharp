using ManticoreCapital.Application.Main.EmployeeUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Queries
{
    public class GetEmployeePaginatedQuery : IRequest<IDatabaseOperationResult<EmployeeResponseDTO>>
    {
        public required string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Seacrh { get; set; }
    }
}
