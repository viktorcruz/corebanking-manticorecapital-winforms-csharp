﻿namespace ManticoreCapital.Application.Main.LoanUseCase.Dtos
{
    public class LoanResponseDTO
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string LoanType { get; set; }
        public decimal Principal { get; set; }
        public decimal InterestRate { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
