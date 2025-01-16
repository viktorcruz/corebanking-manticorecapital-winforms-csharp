using ManticoreCapital.Application.Main.LoanUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.LoanUseCase.Queries
{
    public class GetLoanByIdQuery : IRequest<IDatabaseOperationResult<LoanResponseDTO>>
    {
        public required string Id { get; set; }
    }
}
