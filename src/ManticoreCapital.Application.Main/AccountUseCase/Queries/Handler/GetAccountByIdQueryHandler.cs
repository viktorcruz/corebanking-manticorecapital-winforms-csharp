using ManticoreCapital.Application.Main.AccountUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Queries.Handler
{
    public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountByIdQuery, IDatabaseOperationResult<AccountResponseDTO>>
    {
        public GetAccountByIdQueryHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<AccountResponseDTO>> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
