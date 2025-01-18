using ManticoreCapital.Application.Main.CardUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Queries.Handler
{
    public class GetCardByIdQueryHandler : IRequestHandler<GetCardByIdQuery, IDatabaseOperationResult<CardResponseDTO>>
    {
        public GetCardByIdQueryHandler()
        {
            
        }

        Task<IDatabaseOperationResult<CardResponseDTO>> IRequestHandler<GetCardByIdQuery, IDatabaseOperationResult<CardResponseDTO>>.Handle(GetCardByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
