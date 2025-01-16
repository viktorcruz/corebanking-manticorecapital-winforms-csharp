using ManticoreCapital.Application.Main.BranchUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Queries.Handler
{
    public class GetBranchByIdQueryHandler : IRequestHandler<GetBranchByIdQuery, IDatabaseOperationResult<BranchResponseDTO>>
    {
        public GetBranchByIdQueryHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<BranchResponseDTO>> Handle(GetBranchByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
