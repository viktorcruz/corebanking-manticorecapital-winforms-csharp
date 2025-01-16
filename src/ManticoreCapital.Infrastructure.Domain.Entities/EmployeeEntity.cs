namespace ManticoreCapital.Infrastructure.Domain.Entities
{
    public class EmployeeEntity
    {
        // datos de empleados bancarios
        public string Id { get; set; }
        public string UserId { get; set; }
        public string BranchId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
