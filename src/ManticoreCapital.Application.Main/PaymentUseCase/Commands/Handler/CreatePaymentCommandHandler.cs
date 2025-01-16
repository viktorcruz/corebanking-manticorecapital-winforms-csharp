using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Commands.Handler
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, IDatabaseActionResponse>
    {
        public CreatePaymentCommandHandler()
        {
            
        }

        Task<IDatabaseActionResponse> IRequestHandler<CreatePaymentCommand, IDatabaseActionResponse>.Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
