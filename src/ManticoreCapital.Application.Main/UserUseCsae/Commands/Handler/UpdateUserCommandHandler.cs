using AutoMapper;
using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Infrastructure.Repositories;
using ManticoreCapital.Transversal.Common.Response;
using ManticoreCapital.Transversal.Interfaces;
using MediatR;

namespace ManticoreCapital.Application.Main.UserUseCsae.Commands.Handler
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, IDatabaseActionResponse>
    {
        private readonly RepositoryFactory<IUserRepository> _repositoryFactory;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IMapper mapper, RepositoryFactory<IUserRepository> repositoryFactory)
        {
            _mapper = mapper;
            _repositoryFactory = repositoryFactory;
        }


        public async Task<IDatabaseActionResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (!Enum.IsDefined(typeof(RepositoryType), request.DatabaseAdapter))
                {
                    throw new ArgumentException($"The database adapter is invalid: '{request.DatabaseAdapter}'");
                }

                var repository = _repositoryFactory.GetRepository(request.DatabaseAdapter);
                var updateUser = new UserRequestDTO
                {
                    Id = request.Id,
                    Name = request.Name,
                    LastName = request.LastName,
                    Email = request.Email,
                    RFC = request.RFC,
                    PasswordHash = request.PasswordHash,
                    Role = request.Role,
                    IsActive = request.IsActive,
                    //CreatedAt = request,
                    //LastUpdatedAt = request.LastUpdatedAt,
                };
                var entity = _mapper.Map<UserEntity>(updateUser);
                var response = repository.UpdateUserAsync(entity);
                return new DatabaseActionResponse
                {
                    IsSuccessful = true,
                    Message = "OK",
                    AffectedRecordId = 0,
                    ErrorMessage = "NONE",
                    Operation = "UPDATE",
                    Timestamp = DateTime.UtcNow,
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
