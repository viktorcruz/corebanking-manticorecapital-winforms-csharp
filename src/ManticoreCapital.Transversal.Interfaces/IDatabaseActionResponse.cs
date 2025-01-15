namespace ManticoreCapital.Transversal.Interfaces
{
    public interface IDatabaseActionResponse
    {
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string Operation { get; set; }
        int AffectedRecordId { get; set; }
        DateTime Timestamp { get; set; }
        string ErrorMessage { get; set; }
    }
}
