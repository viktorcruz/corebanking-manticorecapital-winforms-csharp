using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.AccountUseCase.Dtos
{
    public class AccountResponseDTO
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string AccountType { get; set; }
        public string BranchId { get; set; }
        public decimal? Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
