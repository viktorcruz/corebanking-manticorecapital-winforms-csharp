using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Transversal.Common.Response;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Queries
{
    public class GetUserPaginatedQuery : IRequest<(List<UserResponseDTO>, int)>
    {
        public required RepositoryType DatabaseAdapter { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
