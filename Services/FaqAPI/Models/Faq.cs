using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaqAPI.Models
{
    public class Faq
    {
        [Key]
        public Guid FaqId { get; set; }

        [Required(ErrorMessage = "Please Enter a Question")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Please Enter an Answer")]
        public string Answer { get; set; }


    }
}
