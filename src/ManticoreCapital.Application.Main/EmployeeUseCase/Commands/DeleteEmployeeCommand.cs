using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Commands
{
    public class DeleteEmployeeCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
    }
}
