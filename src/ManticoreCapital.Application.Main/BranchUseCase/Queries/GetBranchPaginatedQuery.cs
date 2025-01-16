using ManticoreCapital.Application.Main.BranchUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Queries
{
    public class GetBranchPaginatedQuery : IRequest<IDatabaseOperationResult<List<BranchResponseDTO>>>
    {
        public string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
