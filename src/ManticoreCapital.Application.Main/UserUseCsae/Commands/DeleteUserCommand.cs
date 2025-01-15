using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Commands
{
    public class DeleteUserCommand : IRequest<IDatabaseActionResponse>
    {
        public string UserId { get; set; }
    }
}
