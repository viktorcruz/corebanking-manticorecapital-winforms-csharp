using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Commands.Handler
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, IDatabaseActionResponse>
    {
        public CreateAccountCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
