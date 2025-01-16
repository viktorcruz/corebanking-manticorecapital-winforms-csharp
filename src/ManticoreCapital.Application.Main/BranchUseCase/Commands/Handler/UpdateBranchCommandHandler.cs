using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Commands.Handler
{
    public class UpdateBranchCommandHandler : IRequestHandler<UpdateBranchCommand, IDatabaseActionResponse>
    {
        public UpdateBranchCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
