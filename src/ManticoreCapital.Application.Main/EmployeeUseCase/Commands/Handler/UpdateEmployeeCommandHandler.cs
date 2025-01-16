using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Commands.Handler
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, IDatabaseActionResponse>
    {
        public UpdateEmployeeCommandHandler()
        {
            
        }
        public Task<IDatabaseActionResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
