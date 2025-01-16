using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Commands
{
    public class CreateAuditLogCommand : IRequest<IDatabaseActionResponse>
    {
        public string UserId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
        public string IpAddess { get; set; }
    }
}
