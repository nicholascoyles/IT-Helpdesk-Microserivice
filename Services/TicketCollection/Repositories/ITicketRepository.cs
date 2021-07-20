using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Models;

namespace TicketCollection.Repositories
{
    //Links controller and repository

    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetTicketsByCategory(Guid categoryId);
        Task<IEnumerable<Ticket>> GetTicketsByStatus(Guid statusId);
        Task<IEnumerable<Ticket>> GetTicketsByPriority(Guid priorityId);
        Task<List<Ticket>> GetTicketsByUsername(string username);


        Task<Ticket> GetTicketById(Guid ticketId);

        Task<List<Ticket>> GetAllTickets();

        Task<Ticket> AddTicket(Ticket ticket);

        Task<Ticket> UpdateTicket(Ticket ticket);

        Task<IActionResult> DeleteTicket(Guid ticketId);

    }
}
