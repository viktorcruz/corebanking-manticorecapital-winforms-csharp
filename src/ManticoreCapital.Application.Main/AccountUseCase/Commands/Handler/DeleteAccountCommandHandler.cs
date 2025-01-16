using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Commands.Handler
{
    public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand, IDatabaseActionResponse>
    {
        public DeleteAccountCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
