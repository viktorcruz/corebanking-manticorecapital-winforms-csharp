using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Commands.Handler
{
    public class DeleteAuditLogCommandHandler : IRequestHandler<DeleteAuditLogCommand, IDatabaseActionResponse>
    {
        public DeleteAuditLogCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(DeleteAuditLogCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
