using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Commands
{
    public class UpdateAuditLogCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
        public string IpAddress { get; set; }
    }
}
