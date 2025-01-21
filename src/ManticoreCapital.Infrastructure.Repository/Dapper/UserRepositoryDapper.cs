using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Common.Response;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Repositories.Dapper
{
    public class UserRepositoryDapper : IUserRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";

        public UserRepositoryDapper(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
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
