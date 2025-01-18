﻿using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.AdoNet
{
    public class UserRepositoryAdoNet : IUserRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";

        public UserRepositoryAdoNet(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public Task<IDatabaseActionResponse> CreateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<UserEntity>> GetUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<UserEntity>>> GetUserPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
