using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.Transaction.Commands.Handler
{
    public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, IDatabaseActionResponse>
    {
        public CreateTransactionCommandHandler()
        {

        }

        public Task<IDatabaseActionResponse> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
