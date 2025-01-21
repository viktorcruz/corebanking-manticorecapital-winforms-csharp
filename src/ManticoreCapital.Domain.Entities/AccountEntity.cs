namespace ManticoreCapital.Domain.Entities
{
    public class AccountEntity
    {
        // detalles de cuentas bancarias
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public AccountType AccountType { get; set; }
        public string BranchId { get; set; }
        public decimal? Balance { get; set; }
        public bool IsActived { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
