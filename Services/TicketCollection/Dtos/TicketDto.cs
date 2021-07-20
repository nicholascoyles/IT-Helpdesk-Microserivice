using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketCollection.Dtos
{
    public class TicketDto
    {
        public Guid TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid StatusId { get; set; }
        public string StatusName { get; set; }
        public Guid PriorityId { get; set; }
        public string PriorityName { get; set; }
        public string Username { get; set; }


    }
}
