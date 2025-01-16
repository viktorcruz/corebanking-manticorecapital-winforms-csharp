using ManticoreCapital.Application.Main.EmployeeUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Queries.Handler
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, IDatabaseOperationResult<EmployeeResponseDTO>>
    {
        public GetEmployeeByIdQueryHandler()
        {
            
        }
        public Task<IDatabaseOperationResult<EmployeeResponseDTO>> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
