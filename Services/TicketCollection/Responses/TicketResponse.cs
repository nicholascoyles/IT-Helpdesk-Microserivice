using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Models;

namespace TicketCollection.Responses
{
    public class TicketResponse
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string CommentContent { get; set; }
        public string User { get; set; }

        public DateTime PostTime { get; set; }


    }
}
