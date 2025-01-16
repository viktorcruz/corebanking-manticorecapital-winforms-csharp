using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.Transaction.Commands.Handler
{
    public class DeleteTransactionCommandHandler : IRequestHandler<DeleteTransactionCommand, IDatabaseActionResponse>
    {
        public DeleteTransactionCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
