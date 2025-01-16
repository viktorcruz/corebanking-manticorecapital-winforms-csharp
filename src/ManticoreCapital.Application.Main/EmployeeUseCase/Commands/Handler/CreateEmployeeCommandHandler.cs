using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Commands.Handler
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, IDatabaseActionResponse>
    {
        public CreateEmployeeCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
