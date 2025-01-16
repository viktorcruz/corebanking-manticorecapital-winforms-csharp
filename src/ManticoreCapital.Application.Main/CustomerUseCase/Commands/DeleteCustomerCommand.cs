using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Commands
{
    public class DeleteCustomerCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
    }
}
