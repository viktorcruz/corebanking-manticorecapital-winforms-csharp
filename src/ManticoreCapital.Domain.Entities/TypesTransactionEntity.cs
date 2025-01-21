namespace ManticoreCapital.Domain.Entities
{
    public class TypesTransactionEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
