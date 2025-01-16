using ManticoreCapital.Application.Main.PaymentUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Queries
{
    public class GetPaymentByIdQuery : IRequest<IDatabaseOperationResult<PaymentResponseDTO>>
    {
        public required string Id { get; set; }
    }
}
