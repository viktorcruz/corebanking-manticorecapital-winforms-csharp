using ManticoreCapital.Application.Main.AccountUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Queries.Handler
{
    public class GetAccountPaginatedQueryHandler : IRequestHandler<GetAccountPaginatedQuery, IDatabaseOperationResult<List<AccountResponseDTO>>>
    {
        public GetAccountPaginatedQueryHandler()
        {

        }

        public Task<IDatabaseOperationResult<List<AccountResponseDTO>>> Handle(GetAccountPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
