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
    public class PriorityRepository : IPriorityRepository
    {
        private readonly TicketCollectionDbContext _ticketCollectionDbContext;

        public PriorityRepository(TicketCollectionDbContext ticketCollectionDbContext)
        {
            _ticketCollectionDbContext = ticketCollectionDbContext;
        }


        public async Task<IEnumerable<Priority>> GetAllPriorities()
        {
            return await _ticketCollectionDbContext.Priorities.ToListAsync();
        }

        public async Task<Priority> GetPriorityById(string priorityId)
        {
            return await _ticketCollectionDbContext.Priorities.Where(x => x.PriorityId.ToString() == priorityId).FirstOrDefaultAsync();
        }
    }
}
