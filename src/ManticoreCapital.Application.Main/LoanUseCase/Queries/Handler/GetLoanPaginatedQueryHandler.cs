using ManticoreCapital.Application.Main.LoanUseCase.Dtos;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.LoanUseCase.Queries.Handler
{
    public class GetLoanPaginatedQueryHandler : IRequestHandler<GetLoanPaginatedQuery, IDatabaseOperationResult<List<LoanResponseDTO>>>
    {
        public GetLoanPaginatedQueryHandler()
        {

        }
        public Task<IDatabaseOperationResult<List<LoanResponseDTO>>> Handle(GetLoanPaginatedQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
