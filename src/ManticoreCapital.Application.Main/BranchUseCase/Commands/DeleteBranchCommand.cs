using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Commands
{
    public class DeleteBranchCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
    }
}
