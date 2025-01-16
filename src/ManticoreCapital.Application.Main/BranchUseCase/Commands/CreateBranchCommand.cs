using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.BranchUseCase.Commands
{
    public class CreateBranchCommand : IRequest<IDatabaseActionResponse>
    {
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
