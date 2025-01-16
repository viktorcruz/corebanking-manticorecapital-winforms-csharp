using ManticoreCapital.Application.Main.Transaction.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.Transaction.Queries.Handler
{
    public class GetTransactionPaginatedQueryHandler : IRequestHandler<GetTransactionPaginatedQuery, IDatabaseOperationResult<List<TransactionResponseDTO>>>
    {
        public GetTransactionPaginatedQueryHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<List<TransactionResponseDTO>>> Handle(GetTransactionPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
