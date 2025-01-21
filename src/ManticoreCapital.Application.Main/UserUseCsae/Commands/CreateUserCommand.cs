using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Commands
{
    public class CreateUserCommand : IRequest<IDatabaseActionResponse>
    {
        public required RepositoryType DatabaseAdapter { get; set; }
        public string? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string RFC { get; set; }
        public string? PasswordHash { get; set; }
        public RoleType Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; } 
        public DateTime? LastUpdatedAt { get; set; }
    }
}
