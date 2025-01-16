using ManticoreCapital.Application.Main.BranchUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Queries.Handler
{
    public class GetBranchPaginatedQueryHandler : IRequestHandler<GetBranchPaginatedQuery, IDatabaseOperationResult<List<BranchResponseDTO>>
    {
        public GetBranchPaginatedQueryHandler()
        {
            
        }


        public Task<IDatabaseOperationResult<List<BranchResponseDTO>>> Handle(GetBranchPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
