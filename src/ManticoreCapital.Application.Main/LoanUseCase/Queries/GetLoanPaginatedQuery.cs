using ManticoreCapital.Application.Main.LoanUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.LoanUseCase.Queries
{
    public class GetLoanPaginatedQuery : IRequest<IDatabaseOperationResult<List<LoanResponseDTO>>>
    {
        public required string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
