using ManticoreCapital.Application.Main.EmployeeUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Queries.Handler
{
    public class GetEmployeePaginatedQueryHandler : IRequestHandler<GetEmployeePaginatedQuery, IDatabaseOperationResult<EmployeeResponseDTO>>
    {
        public GetEmployeePaginatedQueryHandler()
        {
            
        }

        public Task<IDatabaseOperationResult<EmployeeResponseDTO>> Handle(GetEmployeePaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
