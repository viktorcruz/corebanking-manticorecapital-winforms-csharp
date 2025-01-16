using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.Transaction.Commands.Handler
{
    public class UpdateTransactionCommandHandler : IRequestHandler<UpdateTransactionCommand, IDatabaseActionResponse>
    {
        public UpdateTransactionCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(UpdateTransactionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
