namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class ReportEntity
    {
        // almacenamiento de reportes generados
        public string ReportId { get; set; }
        public string GeneratedBy { get; set; }
        public string ReportType { get; set; }
        public string FilePath { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
