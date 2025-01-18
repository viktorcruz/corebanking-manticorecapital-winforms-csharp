using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Queries
{
    public class GetUserPaginatedQuery : IRequest<(IDatabaseOperationResult<List<UserResponseDTO>>, int)>
    {
        public required RepositoryType DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
