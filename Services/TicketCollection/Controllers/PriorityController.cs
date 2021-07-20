using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Dtos;
using TicketCollection.Repositories;

namespace TicketCollection.Controllers
{
    [Route("api/priorities")]
    [ApiController]
    public class PriorityController : ControllerBase
    {
        private IPriorityRepository _priorityRepository;
        private IMapper _mapper;

        public PriorityController(IPriorityRepository priorityRepository, IMapper mapper)
        {
            _priorityRepository = priorityRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PriorityDto>>> Get()
        {
            var result = await _priorityRepository.GetAllPriorities();
            return Ok(_mapper.Map<List<PriorityDto>>(result));
        }
    }
}
