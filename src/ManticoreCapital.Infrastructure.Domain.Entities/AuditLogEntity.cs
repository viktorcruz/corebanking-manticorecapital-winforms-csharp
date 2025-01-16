namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class AuditLogEntity
    {
        // registro de auditoria
        public string LogId { get; set; }
        public string UserId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
        public string IpAddress { get; set; }
    }
}
