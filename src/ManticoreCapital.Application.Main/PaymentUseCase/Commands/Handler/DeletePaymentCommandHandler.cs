using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Commands.Handler
{
    public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, IDatabaseActionResponse>
    {
        public DeletePaymentCommandHandler()
        {
            

        }

        public Task<IDatabaseActionResponse> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
