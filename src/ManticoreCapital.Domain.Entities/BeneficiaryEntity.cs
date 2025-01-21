using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Domain.Entities
{
    public class BeneficiaryEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BankName { get; set; }
        public ICollection<PaymentEntity> Payments { get; set; }
    }
}
