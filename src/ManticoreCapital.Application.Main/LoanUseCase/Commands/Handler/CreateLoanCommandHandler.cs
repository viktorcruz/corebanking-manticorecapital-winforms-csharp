using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.LoanUseCase.Commands.Handler
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, IDatabaseActionResponse>
    {
        public CreateLoanCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
