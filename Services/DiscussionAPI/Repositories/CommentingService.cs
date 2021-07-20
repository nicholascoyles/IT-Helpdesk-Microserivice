using DiscussionAPI.Database;
using DiscussionAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionAPI.Repositories
{
    public class CommentingService : ICommentingService
    {

        private readonly DiscussionDbContext _discussionDbContext;

        public CommentingService(DiscussionDbContext discussionDbContext)
        {
            _discussionDbContext = discussionDbContext;
        }

        //Gets all comments on ticket id
        public async Task<IEnumerable<TicketComments>> GetCommentOnTicketAsync(Guid ticketId)
        {
 
            return await _discussionDbContext.TicketComments.Where(r => r.TicketId == ticketId)
                .OrderBy(x => x.PostTime)
                .ToListAsync();
        }
        //Adds comment to ticket Id
        public async Task<TicketComments> AddComment(TicketComments ticketComments)
        {
            _discussionDbContext.Add(ticketComments);
            await _discussionDbContext.SaveChangesAsync();
            return ticketComments;
        }



    }
}
