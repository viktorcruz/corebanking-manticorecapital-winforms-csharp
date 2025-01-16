using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Commands.Handler
{
    public class CreateAuditLogCommandHandler : IRequestHandler<CreateAuditLogCommand, IDatabaseActionResponse>
    {
        public CreateAuditLogCommandHandler()
        {
            
        }

        Task<IDatabaseActionResponse> IRequestHandler<CreateAuditLogCommand, IDatabaseActionResponse>.Handle(CreateAuditLogCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
