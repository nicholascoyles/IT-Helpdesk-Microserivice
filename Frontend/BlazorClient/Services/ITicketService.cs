using BlazorClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetTickets();
        Task<List<Ticket>> GetTicketsByUser(string UserName);

        Task<Ticket> GetTicketById(string ticketId);

        Task<IEnumerable<Ticket>> GetTicketsByStatus(Guid statusId);


        Task<List<Category>> GetCategory();
        Task<Category> GetCategoryById(Guid categoryId);


        Task<List<Status>> GetStatus();

        Task<List<Priority>> GetPriority();


    }
}
