using ManticoreCapital.Transversal.Interfaces;

namespace ManticoreCapital.Transversal.Common.Response
{
    public class DatabaseActionResponse : IDatabaseActionResponse
    {
        public bool IsSuccessful { get; set; } // se renombra ResultStatus a IsSuccessful
        public string Message { get; set; } // se renombra ResultMessage a Message
        public string Operation { get; set; } // se renombra OperationType a Operation
        public int AffectedRecordId { get; set; }
        public DateTime Timestamp { get; set; } // se renombra OperationDateTime a Timestamp
        public string ErrorMessage { get; set; } // se renombra ExceptionMessage a ErrorMessage
    }
}
