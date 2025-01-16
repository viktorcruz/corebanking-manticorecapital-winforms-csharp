using ManticoreCapital.Application.Main.CustomerUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Queries
{
    public class GetCustomerByIdQUery : IRequest<IDatabaseOperationResult<CustomerResponseDTO>>
    {
        public string Id { get; set; }
    }
}
