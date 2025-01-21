using AutoMapper;
using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Infrastructure.Repositories;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Queries.Handler
{
    public class GetUserPaginatedQueryHandler : IRequestHandler<GetUserPaginatedQuery, (List<UserResponseDTO>, int)>
    {
        private readonly RepositoryFactory<IUserRepository> _repositoryFactory;
        private readonly IMapper _mapper;

        public GetUserPaginatedQueryHandler(IMapper mapper, RepositoryFactory<IUserRepository> repositoryFactory)
        {
            _mapper = mapper;
            _repositoryFactory = repositoryFactory;
        }

        public async Task<(List<UserResponseDTO>, int)> Handle(GetUserPaginatedQuery request, CancellationToken cancellationToken)
        {
            try
            {
                if (!Enum.IsDefined(typeof(RepositoryType), request.DatabaseAdapter))
                {
                    throw new ArgumentException($"The database adapter is invalid: '{request.DatabaseAdapter}'");
                }

                var repository = _repositoryFactory.GetRepository(request.DatabaseAdapter);
                var response = await repository.GetUserPaginatedAsync(request.PageNumber, request.PageSize, request.Search);

                var users = _mapper.Map<List<UserResponseDTO>>(response.Results);

                return await Task.FromResult((users, response.TotalItemCount));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
