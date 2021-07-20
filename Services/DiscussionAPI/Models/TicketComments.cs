using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionAPI.Models
{
    public class TicketComments
    {
        [Key]
        public Guid CommentId { get; set; }
        [Required]
        public Guid TicketId { get; set; }
        public string CommentContent { get; set; }
        public DateTime PostTime { get; set; }
        public string User { get; set; }

    }
}
