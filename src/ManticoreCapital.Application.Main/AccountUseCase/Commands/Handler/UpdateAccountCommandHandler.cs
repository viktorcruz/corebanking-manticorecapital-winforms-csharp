using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Commands.Handler
{
    public class UpdateAccountCommandHandler : IRequestHandler<UpdateAccountCommand, IDatabaseActionResponse>
    {
        public UpdateAccountCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
