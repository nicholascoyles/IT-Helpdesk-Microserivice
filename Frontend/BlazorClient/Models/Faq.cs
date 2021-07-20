using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorClient.Models
{
    public class Faq
    {
        public string FaqId { get; set; }

        [Required(ErrorMessage = "Please Enter a Question")]
        [StringLength(50, ErrorMessage = "Question is too long.(50 character limit)")]

        public string Question { get; set; }

        [Required(ErrorMessage = "Please Enter an Answer")]
        [StringLength(50, ErrorMessage = "Answer is too long.(50 character limit)")]

        public string Answer { get; set; }


    }
}
