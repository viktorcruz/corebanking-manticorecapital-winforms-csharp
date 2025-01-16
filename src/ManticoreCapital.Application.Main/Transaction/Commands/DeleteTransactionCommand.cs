using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.Transaction.Commands
{
    public class DeleteTransactionCommand :IRequest<IDatabaseActionResponse>
    {
        public string TransactionId { get; set; }
    }
}
