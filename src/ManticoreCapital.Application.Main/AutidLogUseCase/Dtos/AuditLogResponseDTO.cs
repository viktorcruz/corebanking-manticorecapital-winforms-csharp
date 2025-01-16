namespace ManticoreCapital.Application.Main.AutidLogUseCase.Dtos
{
    public class AuditLogResponseDTO
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
        public string IpAddress { get; set; }
    }
}
