using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Commands
{
    public class DeleteAccountCommand : IRequest<IDatabaseActionResponse>
    {
        public string AccountId;
    }
}
