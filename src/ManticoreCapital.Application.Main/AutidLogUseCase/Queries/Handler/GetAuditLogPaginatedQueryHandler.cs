using ManticoreCapital.Application.Main.AutidLogUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AutidLogUseCase.Queries.Handler
{
    public class GetAuditLogPaginatedQueryHandler : IRequestHandler<GetAuditLogPaingatedQuery, IDatabaseOperationResult<List<AuditLogResponseDTO>>>
    {
        public GetAuditLogPaginatedQueryHandler()
        {
            
        }


        public Task<IDatabaseOperationResult<List<AuditLogResponseDTO>>> Handle(GetAuditLogPaingatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
