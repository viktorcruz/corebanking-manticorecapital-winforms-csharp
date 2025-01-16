using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.LoanUseCase.Commands
{
    public  class CreateLoanCommand : IRequest<IDatabaseActionResponse>
    {
        public string AccountId { get; set; }
        public string LoanType { get; set; }
        public decimal Principal { get; set; }
        public decimal InterestRate { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
    }
}
