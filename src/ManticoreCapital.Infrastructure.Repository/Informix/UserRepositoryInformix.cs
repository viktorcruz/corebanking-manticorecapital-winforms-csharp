using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Common.Response;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.Informix
{
    public class UserRepositoryInformix : IUserRepository
    {
        public Task<IDatabaseActionResponse> CreateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<UserEntity>> GetUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedResponse<UserEntity>> GetUserPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
