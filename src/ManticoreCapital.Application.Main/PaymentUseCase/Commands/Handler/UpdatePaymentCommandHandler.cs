using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.PaymentUseCase.Commands.Handler
{
    public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, IDatabaseActionResponse>
    {
        public UpdatePaymentCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
