using ManticoreCapital.Application.Main.AutidLogUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Queries.Handler
{
    public class GetAuditLogByIdQueryHandler : IRequestHandler<GetAuditLogByIdQuery, IDatabaseOperationResult<AuditLogResponseDTO>>
    {
        public GetAuditLogByIdQueryHandler()
        {
            
        }

        Task<IDatabaseOperationResult<AuditLogResponseDTO>> IRequestHandler<GetAuditLogByIdQuery, IDatabaseOperationResult<AuditLogResponseDTO>>.Handle(GetAuditLogByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
