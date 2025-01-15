using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.UserUseCsae.Commands.Handler
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, IDatabaseActionResponse>
    {
        public CreateUserCommandHandler()
        {
            
        }

        public Task<IDatabaseActionResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
