using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.EmployeeUseCase.Commands
{
    public class UpdateEmployeeCommand : IRequest<IDatabaseActionResponse>
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string BranchId { get; set; }
        public string Position { get; set; }
        public decimal Salaray { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
    }
}
