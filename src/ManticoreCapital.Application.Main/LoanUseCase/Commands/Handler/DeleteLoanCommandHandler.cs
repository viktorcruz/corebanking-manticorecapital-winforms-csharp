using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.LoanUseCase.Commands.Handler
{
    public class DeleteLoanCommandHandler : IRequestHandler<DeleteLoanCommand, IDatabaseActionResponse>
    {
        public DeleteLoanCommandHandler()
        {
            
        }
        public Task<IDatabaseActionResponse> Handle(DeleteLoanCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
