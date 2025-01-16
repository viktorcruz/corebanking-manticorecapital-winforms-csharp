using ManticoreCapital.Application.Main.AccountUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.AccountUseCase.Queries
{
    public class GetAccountByIdQuery : IRequest<IDatabaseOperationResult<AccountResponseDTO>>
    {
        public string Id { get; set; }
    }
}
