using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Commands.Handler
{
    public class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, IDatabaseActionResponse>
    {
        public CreateBranchCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
