using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Models
{
    public class Priority
    {
        public Guid PriorityId { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
