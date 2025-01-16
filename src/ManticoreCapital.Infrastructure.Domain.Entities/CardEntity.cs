namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class CardEntity
    {
        // informacion de tarjetas bancarias
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string CVV { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
