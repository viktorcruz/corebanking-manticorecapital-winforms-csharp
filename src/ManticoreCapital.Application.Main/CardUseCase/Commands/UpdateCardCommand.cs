using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CardUseCase.Commands
{
    public class UpdateCardCommand : IRequest<IDatabaseActionResponse>
    {
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
