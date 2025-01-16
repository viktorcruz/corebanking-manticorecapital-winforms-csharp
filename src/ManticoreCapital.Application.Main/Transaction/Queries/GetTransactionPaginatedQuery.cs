using ManticoreCapital.Application.Main.Transaction.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.Transaction.Queries
{
    public class GetTransactionPaginatedQuery : IRequest<IDatabaseOperationResult<List<TransactionResponseDTO>>>
    {
        public string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
