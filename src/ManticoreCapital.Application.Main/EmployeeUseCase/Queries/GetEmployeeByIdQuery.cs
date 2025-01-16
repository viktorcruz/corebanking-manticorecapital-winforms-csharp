using ManticoreCapital.Application.Main.EmployeeUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Queries
{
    public class GetEmployeeByIdQuery : IRequest<IDatabaseOperationResult<EmployeeResponseDTO>>
    {
        public string Id { get; set; }
    }
}
