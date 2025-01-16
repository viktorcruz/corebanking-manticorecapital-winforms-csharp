using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Commands.Handler
{
    public class UpdateCardCommandHandler : IRequestHandler<UpdateCardCommand, IDatabaseActionResponse>
    {
        public UpdateCardCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(UpdateCardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
