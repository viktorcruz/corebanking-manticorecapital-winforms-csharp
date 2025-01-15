namespace ManticoreCapital.Transversal.Interfaces
{
    public interface IServiceResponse<T>
    {
        T Result { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
    }
}
