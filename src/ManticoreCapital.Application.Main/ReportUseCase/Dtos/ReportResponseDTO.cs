namespace ManticoreCapital.Application.Main.ReportUseCase.Dtos
{
    public class ReportResponseDTO
    {
        public string Id { get; set; }
        public string GenerateBy { get; set; }
        public string ReportType { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
