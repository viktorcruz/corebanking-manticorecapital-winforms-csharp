namespace ManticoreCapital.Application.Main.PaymentUseCase.Dtos
{
    public class PaymentResponseDTO
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string TransactionId { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
