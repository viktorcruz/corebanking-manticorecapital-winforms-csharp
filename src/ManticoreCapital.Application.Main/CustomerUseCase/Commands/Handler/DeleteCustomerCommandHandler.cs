using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Commands.Handler
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, IDatabaseActionResponse>
    {
        public DeleteCustomerCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
