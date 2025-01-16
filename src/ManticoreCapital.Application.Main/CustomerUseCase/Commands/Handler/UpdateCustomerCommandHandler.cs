using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Commands.Handler
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, IDatabaseActionResponse>
    {
        public UpdateCustomerCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
