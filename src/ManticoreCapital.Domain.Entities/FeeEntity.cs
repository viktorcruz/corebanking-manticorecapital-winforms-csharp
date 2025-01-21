namespace ManticoreCapital.Domain.Entities
{
    public class FeeEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string ApplicableTo { get; set; }
    }
}
