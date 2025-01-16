using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Commands
{
    public class DeletePaymentCommand : IRequest<IDatabaseActionResponse>
    {
        public required string Id { get; set; }
    }
}
