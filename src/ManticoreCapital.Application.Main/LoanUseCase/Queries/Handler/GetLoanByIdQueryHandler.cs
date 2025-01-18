using ManticoreCapital.Application.Main.LoanUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.LoanUseCase.Queries.Handler
{
    public class GetLoanByIdQueryHandler : IRequestHandler<GetLoanByIdQuery, IDatabaseOperationResult<LoanResponseDTO>>
    {
        public GetLoanByIdQueryHandler()
        {
            
        }
        public Task<IDatabaseOperationResult<LoanResponseDTO>> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
