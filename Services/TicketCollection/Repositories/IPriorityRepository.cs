using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Models;

namespace TicketCollection.Repositories
{
    //Links controller and repository

    public interface IPriorityRepository
    {
        Task<IEnumerable<Priority>> GetAllPriorities();
        Task<Priority> GetPriorityById(string priorityId);
    }
}
