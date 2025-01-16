namespace ManticoreCapital.Application.Main.Transaction.Dtos
{
    public class TransactionRequestDTO
    {
        public string? Id { get; set; }
        public string AccountId { get; set; }
        public string BranchId { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateAt { get; set; }
        public string Description { get; set; }
    }
}
