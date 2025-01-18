using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Infrastructure.IoC;
using ManticoreCapital.Infrastructure.Repositories;
using ManticoreCapital.Infrastructure.Repositories.AdoNet;
using ManticoreCapital.Infrastructure.Repositories.Dapper;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.UserUseCsae.Queries.Handler
{
    public class GetUserPaginatedQueryHandler : IRequestHandler<GetUserPaginatedQuery, (IDatabaseOperationResult<List<UserResponseDTO>>, int)>
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly RepositoryFactory<IUserRepository> _repositoryFactory;

        public GetUserPaginatedQueryHandler(IServiceProvider serviceProvider, RepositoryFactory<IUserRepository> repositoryFactory)
        {
            _serviceProvider = serviceProvider;
            _repositoryFactory = repositoryFactory;
        }

        public Task<(IDatabaseOperationResult<List<UserResponseDTO>>, int)> Handle(GetUserPaginatedQuery request, CancellationToken cancellationToken)
        {
            if(!Enum.IsDefined(typeof(RepositoryType), request.DatabaseAdapter))
            {
                throw new ArgumentException($"El adaptador de base de datos '{request.DatabaseAdapter}' no es valido");
            }

            var repository = _repositoryFactory.GetRepository(request.DatabaseAdapter);
            var list = repository.GetUserPaginatedAsync(request.PageNumber, request.PageSize, request.Search);

            return null;
        }
    }
}
