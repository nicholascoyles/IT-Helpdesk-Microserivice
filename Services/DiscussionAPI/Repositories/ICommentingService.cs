using DiscussionAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionAPI.Repositories
{
    public interface ICommentingService
    {
        Task<IEnumerable<TicketComments>> GetCommentOnTicketAsync(Guid ticketId);

        Task<TicketComments> AddComment(TicketComments ticketComments);
    }
}
