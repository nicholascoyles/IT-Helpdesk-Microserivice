using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Dtos;
using TicketCollection.Models;
using TicketCollection.Repositories;
using TicketCollection.Responses;

namespace TicketCollection.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ICommentingService _commentingService;
        private readonly IMapper _mapper;
        private readonly IHttpContextFactory httpContextFactory;
        public TicketController(ITicketRepository ticketRepository, IMapper mapper, ICommentingService commentingService)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
            _commentingService = commentingService;
        }

        //Gets all tickets on a category
        [HttpGet("Category")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetCategory(
            [FromQuery] Guid categoryId)
        {
            try
            {
                var tickets = await _ticketRepository.GetTicketsByCategory(categoryId);

                //Error if tickets can't be found
                if (tickets == null)
                {
                    return NotFound();
                }
                //Return tickets
                return Ok(_mapper.Map<List<TicketDto>>(tickets));
            }
            //Exception error
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
        //Get all tickets by a status
        [HttpGet("Status/{statusId}")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetStatus(Guid statusId)
        {
            try
            {                
                //Gets tickets
                var tickets = await _ticketRepository.GetTicketsByStatus(statusId);
                //Error if tickets can't be found
                if (tickets == null)
                {
                    return NotFound();
                }
                //Returns tickets
                return Ok(_mapper.Map<List<TicketDto>>(tickets));
            }
            //Exception error
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
        //Gets all tickets by a priority
        [HttpGet("Priority")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetPriority(
            [FromQuery] Guid priorityId)
        {
            try
            {               
                //Gets all tickets
                var tickets = await _ticketRepository.GetTicketsByPriority(priorityId);
                //Error if tickets can't be found
                if (tickets == null)
                {
                    return NotFound();
                }
                //Returns tickets
                return Ok(_mapper.Map<List<TicketDto>>(tickets));
            }
            catch (Exception)
            {
                //Exception error
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
        //Gets ticket by Id
        [HttpGet("{ticketId}")]
        public async Task<ActionResult<TicketDto>> GetTicketById(Guid ticketId)
        {
            try
            {
                var result = await _ticketRepository.GetTicketById(ticketId);

                //Error if ticket can't be found
                if (result == null)
                {
                    return NotFound($"Ticket with Id = {ticketId} not found");
                }

                //Return ticket
                return Ok(_mapper.Map<TicketDto>(result));
            }
            catch (Exception)
            {
                //Exeption error
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        //Gets tickets by username
        [HttpGet("user/{username}")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTicketsByUser(string username)
        {
            try
            {
                var result = await _ticketRepository.GetTicketsByUsername(username);

                //Error if username cannot be found
                if (result == null)
                {
                    return NotFound($"Ticket created by user = {username} not found");
                }

                //Return tickets
                return Ok(_mapper.Map<List<TicketDto>>(result));
            }
            catch (Exception)
            {
                //Exception error
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        //Gets commetns on a ticket Id
        [HttpGet("{ticketId}/comments/")]
        public async Task<IActionResult> GetTicketComments([FromRoute] Guid ticketId)
        {
            var ticket = await _ticketRepository.GetTicketById(ticketId);

            //Error if ticket can't be found
            if (ticket is null)
            {
                return NotFound();
            }

             var commenting = await _commentingService.GetCommentOnTicketAsync(ticketId);
            //Returns comments
            return Ok(commenting);
        }

        //Returns all tickets
        [HttpGet]
        [Route("ticketList")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> Get()
        {
            try
            {
                //Returns all tickets
                var result = await _ticketRepository.GetAllTickets();
                return Ok(_mapper.Map<List<TicketDto>>(result));
            }
            //Exception error
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        //Create ticket
        [HttpPost]
        [Route("createTicket")]
        public async Task<IActionResult> CreateTicket(Ticket ticket)
        {
            try
            {
                //If inputs are invalid
                if (ticket == null)
                {
                    return BadRequest();
                }
                //Add ticket
                return Ok(await _ticketRepository.AddTicket(ticket));

            }
            //Exception error
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new ticket");
            }
        }
        //Update ticket
        [HttpPut("{ticketId}")]
        public async Task<ActionResult<Ticket>> UpdateTicket(Guid ticketId, [FromBody] Ticket ticket)
        {
            try
            {
                //If ticket cannot be found
                if (ticketId != ticket.TicketId)
                {
                    return BadRequest("Ticket not found");
                }
                //Get ticket
                var ticketToUpdate = await _ticketRepository.GetTicketById(ticketId);
                //Error if tickets can't be found
                if (ticketToUpdate == null)
                {
                    return NotFound($"Ticket with Id = {ticketId} not found");
                }
                //Update ticket
                return await _ticketRepository.UpdateTicket(ticket);
            }
            //Exception error
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        //Delete Ticket
        [HttpDelete("{ticketId}")]
        public async Task<IActionResult> DeleteTicket(Guid ticketId)
        {
            try
            {

                //Get ticket
                var ticket = await _ticketRepository.GetTicketById(ticketId);
                //Error if tickets can't be found
                if (ticket == null)
                {
                    return NotFound($"Ticket with Id = {ticketId} not found");
                }
                //Delete ticket
                return Ok(await _ticketRepository.DeleteTicket(ticketId));

            }
            //Exception error
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

    }
    }
