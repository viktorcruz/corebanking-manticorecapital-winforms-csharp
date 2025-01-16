using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Commands
{
    public class CreateCustomerCommand : IRequest<IDatabaseActionResponse>
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Phoen { get; set; }
        public string Address { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
