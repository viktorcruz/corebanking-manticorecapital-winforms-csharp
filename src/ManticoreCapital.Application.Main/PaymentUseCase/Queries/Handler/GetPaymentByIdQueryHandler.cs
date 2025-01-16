using ManticoreCapital.Application.Main.PaymentUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Queries.Handler
{
    public class GetPaymentByIdQueryHandler : IRequestHandler<GetPaymentByIdQuery, IDatabaseOperationResult<PaymentResponseDTO>>
    {
        public GetPaymentByIdQueryHandler()
        {

        }
        public Task<IDatabaseOperationResult<PaymentResponseDTO>> Handle(GetPaymentByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
