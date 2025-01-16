using ManticoreCapital.Application.Main.PaymentUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Queries.Handler
{
    public class GetPaymentPaginatedQueryHandler : IRequestHandler<GetPaymentPaginatedQuery, IDatabaseOperationResult<List<PaymentResponseDTO>>>
    {
        public GetPaymentPaginatedQueryHandler()
        {

        }
        public Task<IDatabaseOperationResult<List<PaymentResponseDTO>>> Handle(GetPaymentPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
