using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.UserUseCsae.Queries.Handler
{
    public class GetUserPaginatedQueryHandler : IRequestHandler<GetUserPaginatedQuery, IDatabaseOperationResult<UserResponseDTO>>
    {

        public GetUserPaginatedQueryHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<UserResponseDTO>> Handle(GetUserPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
