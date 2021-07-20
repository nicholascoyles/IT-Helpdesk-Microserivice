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
    public class StatusRepository : IStatusRepository
    {
        private readonly TicketCollectionDbContext _ticketCollectionDbContext;

        public StatusRepository(TicketCollectionDbContext ticketCollectionDbContext)
        {
            _ticketCollectionDbContext = ticketCollectionDbContext;
        }


        public async Task<IEnumerable<Status>> GetAllStatuses()
        {
            return await _ticketCollectionDbContext.Statuses.ToListAsync();
        }

        public async Task<Status> GetStatusById(string statusId)
        {
            return await _ticketCollectionDbContext.Statuses.Where(x => x.StatusId.ToString() == statusId).FirstOrDefaultAsync();
        }
    }
}
