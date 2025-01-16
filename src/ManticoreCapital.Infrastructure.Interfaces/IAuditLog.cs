using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IAuditLog
    {
        // Commands
        Task<IDatabaseActionResponse> CreateAuditLogAsync(AuditLogEntity audit);
        Task<IDatabaseActionResponse> UpdateAuditLogAsync(AuditLogEntity audit);
        Task<IDatabaseActionResponse> DeleteAuditLogAsync(string auditId);

        // Queries
        Task<IDatabaseOperationResult<AuditLogEntity>> GetAuditLogByIdAsycn(AuditLogEntity audit);
        Task<IDatabaseOperationResult<List<AuditLogEntity>>> GetAuditLogPaginatedAsync(int pageNumber, int pageSize, string? search);
    }
}
