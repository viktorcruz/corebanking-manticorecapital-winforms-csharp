namespace ManticoreCapital.Application.Main.ReportUseCase.Dtos
{
    public class ReportRequestDTO
    {
        public string? Id { get; set; }
        public string GeneratedBy { get; set; }
        public string ReportType { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
