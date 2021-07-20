using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Database;
using TicketCollection.Models;

namespace TicketCollection.Repositories
{
    //All controller functions connected to the database
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketCollectionDbContext _ticketCollectionDbContext;

        public TicketRepository(TicketCollectionDbContext ticketCollectionDbContext)
        {
            _ticketCollectionDbContext = ticketCollectionDbContext;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByCategory(Guid categoryId)
        {
            return await _ticketCollectionDbContext.Tickets
                .Include(x => x.Category)
                .Include(y => y.Priority)
                .Include(z => z.Status)
                .Where(x => (x.CategoryId == categoryId || categoryId == Guid.Empty)).ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByStatus(Guid statusId)
        {
            return await _ticketCollectionDbContext.Tickets
                .Include(x => x.Status)
                .Include(y => y.Category)
                .Include(z => z.Priority)
                .Where(x => (x.StatusId == statusId || statusId == Guid.Empty)).ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByPriority(Guid priorityId)
        {
            return await _ticketCollectionDbContext.Tickets
                .Include(x => x.Priority)
                .Include(y => y.Status)
                .Include(y => y.Category)
                .Where(x => (x.PriorityId == priorityId || priorityId == Guid.Empty)).ToListAsync();
        }


        public async Task<Ticket> GetTicketById(Guid ticketId)
        {
            return await _ticketCollectionDbContext.Tickets.Include(x => x.Category)
                .Include(y => y.Status)
                .Include(z => z.Priority)
                .Where(x => x.TicketId == ticketId).FirstOrDefaultAsync();
        }

        public async Task<List<Ticket>> GetTicketsByUsername(string username)
        {
            return await _ticketCollectionDbContext.Tickets
                            .Include(x => x.Category)
                            .Include(y => y.Priority)
                            .Include(z => z.Status)
                            .Where(x => (x.Username == username)).ToListAsync();

        }
        public async Task<List<Ticket>> GetAllTickets()
        {
            return await _ticketCollectionDbContext.Tickets.
                Include(x => x.Priority)
                .Include(y => y.Status)
                .Include(y => y.Category)
                .Where(x => (x.StatusId != Guid.Parse("9853a3dc-6c18-4215-81ee-cdfff42a62e1"))).ToListAsync();
        }

        public async Task<Ticket> AddTicket(Ticket ticket)
        {
            _ticketCollectionDbContext.Add(ticket);
            await _ticketCollectionDbContext.SaveChangesAsync();
            return ticket;

        }

        public async Task<Ticket> UpdateTicket(Ticket ticket)
        {
            var result = await _ticketCollectionDbContext.Tickets
                   .FirstOrDefaultAsync(e => e.TicketId == ticket.TicketId);
            if (result != null)
            {
                result.Title = ticket.Title;
                result.Description = ticket.Description;
                result.CategoryId = ticket.CategoryId;
                result.StatusId = ticket.StatusId;
                result.PriorityId = ticket.PriorityId;

                await _ticketCollectionDbContext.SaveChangesAsync();

                return ticket;
            }
            return null;
        }

        public async Task<IActionResult> DeleteTicket(Guid ticketId)
        {

            var result = await _ticketCollectionDbContext.Tickets
                .FindAsync(ticketId);

            if (result != null)
            {
                _ticketCollectionDbContext.Remove(result);
                await _ticketCollectionDbContext.SaveChangesAsync();
                return null;


            }
            else
            {
                return null;
            }
        }
    

    }


   }

