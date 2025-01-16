using ManticoreCapital.Application.Main.BranchUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Queries
{
    public class GetBranchByIdQuery : IRequest<IDatabaseOperationResult<BranchResponseDTO>>
    {
        public string Id { get; set; }
    }
}
