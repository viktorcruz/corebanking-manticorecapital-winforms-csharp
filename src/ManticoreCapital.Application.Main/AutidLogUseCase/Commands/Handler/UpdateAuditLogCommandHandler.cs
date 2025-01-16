using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Commands.Handler
{
    public class UpdateAuditLogCommandHandler : IRequestHandler<UpdateAuditLogCommand, IDatabaseActionResponse>
    {
        public UpdateAuditLogCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(UpdateAuditLogCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
