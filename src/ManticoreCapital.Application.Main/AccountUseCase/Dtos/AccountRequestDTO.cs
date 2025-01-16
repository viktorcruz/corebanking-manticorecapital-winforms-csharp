namespace ManticoreCapital.Application.Main.AccountUseCase.Dtos
{
    public class AccountRequestDTO
    {
        public string? Id { get; set; }
        public string CustomerId { get; set; }
        public string AccountType { get; set; }
        public string BranchId { get; set; }
        public decimal? Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
