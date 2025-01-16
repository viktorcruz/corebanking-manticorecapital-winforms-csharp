using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Commands.Handler
{
    public class CreateCardCommandHandler : IRequestHandler<CreateCardCommand, IDatabaseActionResponse>
    {
        public CreateCardCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(CreateCardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
