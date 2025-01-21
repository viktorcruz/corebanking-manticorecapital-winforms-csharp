using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.PostgreSQL
{
    public class ReportRepositoryPostgreSQL : IReportRepository
    {
        public Task<IDatabaseActionResponse> CreateReportAsync(ReportEntity report)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteReportAsync(string reportId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<ReportEntity>> GetReportByIdAsync(string reportId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<ReportEntity>>> GetReportPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateReportAsync(ReportEntity report)
        {
            throw new NotImplementedException();
        }
    }
}
