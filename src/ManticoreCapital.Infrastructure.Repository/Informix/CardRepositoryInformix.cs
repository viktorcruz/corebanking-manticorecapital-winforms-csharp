using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.Informix
{
    public class CardRepositoryInformix : ICardRepository
    {
        public Task<IDatabaseActionResponse> CreateCardAsync(CardEntity card)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteCardAsync(string cardId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<CardEntity>> GetCardByIdAsync(string cardId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<CardEntity>>> GetCardPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateCardAsync(CardEntity card)
        {
            throw new NotImplementedException();
        }
    }
}
