using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Commands.Handler
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, IDatabaseActionResponse>
    {
        public DeleteUserCommandHandler()
        {

        }

        public Task<IDatabaseActionResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
