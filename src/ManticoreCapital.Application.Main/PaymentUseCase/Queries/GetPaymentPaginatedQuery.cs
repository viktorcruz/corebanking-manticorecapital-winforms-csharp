using ManticoreCapital.Application.Main.PaymentUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Queries
{
    public class GetPaymentPaginatedQuery : IRequest<IDatabaseOperationResult<List<PaymentResponseDTO>>>
    {
        public required string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Seacr { get; set; }
    }
}
