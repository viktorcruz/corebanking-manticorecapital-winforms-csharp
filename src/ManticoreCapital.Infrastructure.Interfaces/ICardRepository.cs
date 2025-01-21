using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface ICardRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateCardAsync(CardEntity card);
        Task<IDatabaseActionResponse> UpdateCardAsync(CardEntity card);
        Task<IDatabaseActionResponse> DeleteCardAsync(string cardId);

        // Queries
        Task<IDatabaseOperationResult<CardEntity>> GetCardByIdAsync(string cardId);
        Task<IDatabaseOperationResult<List<CardEntity>>> GetCardPaginatedAsync(int pageNumber, int pageSize, string? search); 
    }
}
