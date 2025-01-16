using ManticoreCapital.Application.Main.CustomerUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Queries.Handler
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQUery, IDatabaseOperationResult<CustomerResponseDTO>>
    {
        public GetCustomerByIdQueryHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<CustomerResponseDTO>> Handle(GetCustomerByIdQUery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
