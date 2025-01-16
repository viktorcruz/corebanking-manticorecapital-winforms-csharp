using ManticoreCapital.Application.Main.Transaction.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.Transaction.Queries
{
    public class GetTransactionByIdQuery : IRequest<IDatabaseOperationResult<TransactionResponseDTO>>
    {
        public string Id { get; set; }
    }
}
