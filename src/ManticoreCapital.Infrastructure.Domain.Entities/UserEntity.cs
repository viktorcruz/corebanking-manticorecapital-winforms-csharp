namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class UserEntity
    {
        // Informacion basica de los usuarios que acceden al sistema
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

    }
}
