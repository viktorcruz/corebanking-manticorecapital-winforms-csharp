namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class CustomerEntity
    {
        // informacion basico sobre los clientes
        public string Id { get; set; }
        public string Userid { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateOnly DateBirth { get; set; } 
        public DateTime CreatedAd { get; set; }
        public DateTime UpdatedAd { get; set;}
    }
}
