using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Models
{
    public class Ticket
    {
        public string TicketId { get; set; }

        [Required(ErrorMessage = "Please enter a Ticket Title")]
        [StringLength(50, ErrorMessage = "Title is too long.(50 character limit)")]

        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a Description")]
        [StringLength(200, ErrorMessage = "Description is too long.(200 character limit)")]


        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid StatusId { get; set; }
        public Status Status { get; set; }

        public Guid PriorityId { get; set; }
        public Priority Priority { get; set; }
        public string Username { get; set; }

    }

}
