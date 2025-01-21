using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.Informix
{
    public class AuditLogRepositoryInformix : IAuditLogRepository
    {
        public Task<IDatabaseActionResponse> CreateAuditLogAsync(AuditLogEntity audit)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeleteAuditLogAsync(string auditId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<AuditLogEntity>> GetAuditLogByIdAsycn(AuditLogEntity audit)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<AuditLogEntity>>> GetAuditLogPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdateAuditLogAsync(AuditLogEntity audit)
        {
            throw new NotImplementedException();
        }
    }
}
