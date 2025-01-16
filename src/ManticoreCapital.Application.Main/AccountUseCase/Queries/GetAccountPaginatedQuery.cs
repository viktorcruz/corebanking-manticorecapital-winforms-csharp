using ManticoreCapital.Application.Main.AccountUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Queries
{
    public class GetAccountPaginatedQuery : IRequest<IDatabaseOperationResult<List<AccountResponseDTO>>>
    {
        public string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
