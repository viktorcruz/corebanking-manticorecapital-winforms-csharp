using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Queries.Handler
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserResponseDTO>
    {
        public GetUserByIdQueryHandler()
        {
            
        }

        public Task<UserResponseDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
