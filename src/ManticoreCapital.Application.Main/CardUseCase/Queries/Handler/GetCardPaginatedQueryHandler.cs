using ManticoreCapital.Application.Main.CardUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Queries.Handler
{
    public class GetCardPaginatedQueryHandler : IRequestHandler<GetCardPaginatedQuery, IDatabaseOperationResult<List<CardResponseDTO>>>
    {
        public GetCardPaginatedQueryHandler()
        {
            
        }

        Task<IDatabaseOperationResult<List<CardResponseDTO>>> IRequestHandler<GetCardPaginatedQuery, IDatabaseOperationResult<List<CardResponseDTO>>>.Handle(GetCardPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
