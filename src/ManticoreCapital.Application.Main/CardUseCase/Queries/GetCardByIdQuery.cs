using ManticoreCapital.Application.Main.CardUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Queries
{
    public class GetCardByIdQuery : IRequest<IDatabaseOperationResult<CardResponseDTO>>
    {
        public int Id { get; set; }
    }
}
