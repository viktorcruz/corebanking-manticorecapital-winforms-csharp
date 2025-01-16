using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.LoanUseCase.Commands
{
    public class DeleteLoanCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
    }
}
