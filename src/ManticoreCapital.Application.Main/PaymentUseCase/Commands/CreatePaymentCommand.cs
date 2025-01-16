using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Commands
{
    public class CreatePaymentCommand : IRequest<IDatabaseActionResponse>
    {
        public string CustomerId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string TransactionId { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
