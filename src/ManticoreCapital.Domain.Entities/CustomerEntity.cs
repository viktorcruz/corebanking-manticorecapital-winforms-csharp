namespace ManticoreCapital.Domain.Entities
{
    public class CustomerEntity
    {
        // informacion basico sobre los clientes
        public string Id { get; set; }
        public string Userid { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsActived { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
