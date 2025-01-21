using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Infrastructure.Repositories;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Commands.Handler
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, IDatabaseActionResponse>
    {
        private readonly RepositoryFactory<IUserRepository> _repositoryFactory;

        public DeleteUserCommandHandler(RepositoryFactory<IUserRepository> repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<IDatabaseActionResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if(!Enum.IsDefined(typeof(RepositoryType), request.DatabaseAdapter)){
                    throw new ArgumentException($"The database adapter is invalid: '{request.DatabaseAdapter}'");
                }

                var repository = _repositoryFactory.GetRepository(request.DatabaseAdapter);
                var resopnse = await repository.DeleteUserAsync(request.UserId);

                return await Task.FromResult(resopnse);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
