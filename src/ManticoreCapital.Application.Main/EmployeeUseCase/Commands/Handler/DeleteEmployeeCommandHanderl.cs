using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Commands.Handler
{
    public class DeleteEmployeeCommandHanderl : IRequestHandler<DeleteEmployeeCommand, IDatabaseActionResponse>
    {
        public DeleteEmployeeCommandHanderl()
        {
            
        }
        public Task<IDatabaseActionResponse> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
