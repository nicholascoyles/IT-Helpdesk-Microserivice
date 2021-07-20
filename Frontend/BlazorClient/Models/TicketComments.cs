using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Models
{
    public class TicketComments
    {
        public string TicketId { get; set; }

        public string CommentId { get; set; }

        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a Comment")]
        public string CommentContent { get; set; }

        public string User { get; set; }

        public DateTime PostTime { get; set; }
    }
}
