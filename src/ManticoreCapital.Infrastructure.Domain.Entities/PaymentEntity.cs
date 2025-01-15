namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class PaymentEntity
    {
        // pagos
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string TransactionId { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
