namespace ManticoreCapital.Application.Main.BranchUseCase.Dtos
{
    public class BranchRequestDTO
    {
        public string? Id { get; set; }
         public string BranchName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set;}
    }
}
