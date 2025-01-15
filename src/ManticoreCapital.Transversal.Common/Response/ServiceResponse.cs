using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Transversal.Common.Response
{
    public class ServiceResponse<T> : IServiceResponse<T>
    {
        public T Result { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
