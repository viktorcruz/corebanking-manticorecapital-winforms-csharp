using ManticoreCapital.Application.Main.CustomerUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Queries
{
    public class GetCustomerPaginatedQuery : IRequest<IDatabaseOperationResult<List<CustomerResponseDTO>>>
    {
        public required string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
