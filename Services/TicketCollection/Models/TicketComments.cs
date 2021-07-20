using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TicketCollection.Responses;

namespace TicketCollection.Models
{
    public class TicketComments
    {

        [JsonPropertyName("commentId")]
        public Guid CommentId { get; set; }

        [JsonPropertyName("ticketId")]
        public Guid TicketId { get; set; }

        [JsonPropertyName("commentContent")]
        public string CommentContent { get; set; }

        [JsonPropertyName("postTime")]
        public DateTime PostTime { get; set; }

        [JsonPropertyName("user")]
        public string User { get; set; }


    }
}
