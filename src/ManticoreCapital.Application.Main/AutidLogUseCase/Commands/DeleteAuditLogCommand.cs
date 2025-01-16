using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Commands
{
    public class DeleteAuditLogCommand : IRequest<IDatabaseActionResponse>
    {
        public required string Id { get; set; }
    }
}
