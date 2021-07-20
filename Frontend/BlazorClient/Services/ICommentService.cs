using BlazorClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public interface ICommentService
    {
        Task<IEnumerable<TicketComments>> GetCommentById(string TicketId);

    }
}
