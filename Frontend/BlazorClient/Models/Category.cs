using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "Please Enter a Category")]
        [StringLength(30, ErrorMessage = "Name is too long.(30 character limit)")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
