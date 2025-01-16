using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Commands
{
    public class UpdateAccountCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
        public string CustomId { get; set; }
        public string AccountType { get; set; }
        public string BranchId { get; set; }
        public decimal? Balance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set;}
    }
}
