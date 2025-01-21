﻿using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.Dapper
{
    public class LoanRepositoryDapper : ILoanRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";

        public LoanRepositoryDapper(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public Task<IDatabaseActionResponse> CreateLoanAsync(LoanEntity loan)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteLoanAsync(string loanId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<LoanEntity>> GetLoanByIdAsync(string loanId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<LoanEntity>>> GetLoanPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateLoanAsync(LoanEntity loan)
        {
            throw new NotImplementedException();
        }
    }
}
