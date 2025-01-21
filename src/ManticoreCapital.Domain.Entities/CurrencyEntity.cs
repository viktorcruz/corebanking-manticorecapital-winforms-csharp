namespace ManticoreCapital.Domain.Entities
{
    public class CurrencyEntity
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } = 0;
    }
}
