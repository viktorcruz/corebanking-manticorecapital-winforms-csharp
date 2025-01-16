using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IReportRepository
    {
        // Commands
        Task<IDatabaseActionResponse> CreateReportAsync(ReportEntity report);
        Task<IDatabaseActionResponse> UpdateReportAsync(ReportEntity report);
        Task<IDatabaseActionResponse> DeleteReportAsync(string reportId);

        // Queries
        Task<IDatabaseOperationResult<ReportEntity>> GetReportByIdAsync(string reportId);
        Task<IDatabaseOperationResult<List<ReportEntity>>> GetReportPaginatedAsync(int pageNumber, int pageSize, string? search);

    }
}
