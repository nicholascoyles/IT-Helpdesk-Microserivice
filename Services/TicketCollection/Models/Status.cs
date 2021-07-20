using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketCollection.Models
{
    public class Status
    {
        public Guid StatusId { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
