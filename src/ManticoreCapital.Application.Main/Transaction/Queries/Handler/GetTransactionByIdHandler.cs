using ManticoreCapital.Application.Main.Transaction.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.Transaction.Queries.Handler
{
    public class GetTransactionByIdHandler : IRequestHandler<GetTransactionByIdQuery, IDatabaseOperationResult<TransactionResponseDTO>>
    {
        public GetTransactionByIdHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<TransactionResponseDTO>> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
