using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Commands.Handler
{
    public class DeleteCardCommandHandler : IRequestHandler<DeleteCardCommand, IDatabaseActionResponse>
    {
        public DeleteCardCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(DeleteCardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
