using ManticoreCapital.Application.Main.AutidLogUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Queries
{
    public class GetAuditLogPaingatedQuery : IRequest<IDatabaseOperationResult<List<AuditLogResponseDTO>>>
    {
        public required string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
