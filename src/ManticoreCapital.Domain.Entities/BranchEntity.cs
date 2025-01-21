namespace ManticoreCapital.Domain.Entities
{
    public class BranchEntity
    {
        // informacion de sucursales bancarias
        public string Id { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
