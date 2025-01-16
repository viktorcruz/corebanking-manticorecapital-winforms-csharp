using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.Transaction.Commands
{
    public class UpdateTransactionCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string BranchId { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
    }
}
