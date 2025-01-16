using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Commands.Handler
{
    public class DeleteBranchCommandHandler : IRequestHandler<DeleteBranchCommand, IDatabaseActionResponse>
    {
        public DeleteBranchCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
