namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class TransactionEntity
    {
        // registro de transacciones
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string BranchId { get; set; }
        public string TransactionId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Description { get; set; }
    }
}
