using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Queries
{
    public class GetUserByIdQuery : IRequest<UserResponseDTO>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
