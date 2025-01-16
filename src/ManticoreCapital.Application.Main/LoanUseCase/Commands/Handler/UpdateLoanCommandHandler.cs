using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.LoanUseCase.Commands.Handler
{
    public class UpdateLoanCommandHandler : IRequestHandler<UpdateLoanCommand, IDatabaseActionResponse>
    {
        public UpdateLoanCommandHandler()
        {
            
        }
        public Task<IDatabaseActionResponse> Handle(UpdateLoanCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
