using ManticoreCapital.Application.Main.CustomerUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.CustomerUseCase.Queries.Handler
{
    public class GetCustomerPaginatedQueryHandler : IRequestHandler<GetCustomerPaginatedQuery, IDatabaseOperationResult<List<CustomerResponseDTO>>>
    {
        public GetCustomerPaginatedQueryHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<List<CustomerResponseDTO>>> Handle(GetCustomerPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
