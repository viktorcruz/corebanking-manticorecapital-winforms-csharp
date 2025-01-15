using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Transversal.Common.Response
{
    public class DatabaseOperationResult<T> : IDatabaseOperationResult<T>
    {
        public T Data { get; set; }
    }
}
