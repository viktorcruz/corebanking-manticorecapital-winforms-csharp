namespace ManticoreCapital.Application.Main.CardUseCase.Dtos
{
    public class CardResponseDTO
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CVV { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
