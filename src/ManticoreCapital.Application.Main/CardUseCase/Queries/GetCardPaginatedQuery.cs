using ManticoreCapital.Application.Main.CardUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Queries
{
    public class GetCardPaginatedQuery : IRequest<IDatabaseOperationResult<List<CardResponseDTO>>>
    {
        public required string DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
