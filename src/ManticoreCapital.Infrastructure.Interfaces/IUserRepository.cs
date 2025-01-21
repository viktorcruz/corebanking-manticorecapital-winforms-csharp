using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Transversal.Common.Response;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateUserAsync(UserEntity user);
        Task<IDatabaseActionResponse> UpdateUserAsync(UserEntity user);
        Task<IDatabaseActionResponse> DeleteUserAsync(string userId);


        // Queries
        Task<IDatabaseOperationResult<UserEntity>> GetUserByIdAsync(string userId);
        Task<PaginatedResponse<UserEntity>> GetUserPaginatedAsync(int pageNumber, int pageSize, string? search);
    }
}
