using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Commands.Handler
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, IDatabaseActionResponse>
    {
        public UpdateUserCommandHandler()
        {
            
        }


        public Task<IDatabaseActionResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
