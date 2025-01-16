using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Commands
{
    public class CreateEmployeeCommand : IRequest<IDatabaseActionResponse>
    {
        public string UserId { get; set; }
        public string BranchId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
