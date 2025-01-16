using ManticoreCapital.Application.Main.AutidLogUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Queries
{
    public class GetAuditLogByIdQuery : IRequest<IDatabaseOperationResult<AuditLogResponseDTO>>
    {
        public required string Id { get; set; }
    }
}
