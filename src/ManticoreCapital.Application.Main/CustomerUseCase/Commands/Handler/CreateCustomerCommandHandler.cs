using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Commands.Handler
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, IDatabaseActionResponse>
    {
        public CreateCustomerCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
