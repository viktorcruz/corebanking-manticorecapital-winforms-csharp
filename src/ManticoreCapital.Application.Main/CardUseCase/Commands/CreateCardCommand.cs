using ManticoreCapital.Transversal.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Application.Main.CardUseCase.Commands
{
    public class CreateCardCommand : IRequest<IDatabaseActionResponse>
    {
        public string AccountId { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string CVV { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}
