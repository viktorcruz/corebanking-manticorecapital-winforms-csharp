namespace ManticoreCapital.Application.Main.CustomerUseCase.Dtos
{
    public class CustomerRequestDTO
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
