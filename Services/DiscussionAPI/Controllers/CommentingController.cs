using DiscussionAPI.Models;
using DiscussionAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionAPI.Controllers
{
    [Route("api/commenting")]
    [ApiController]
    public class CommentingController : ControllerBase
    {
        private readonly ICommentingService _commentingService;

        public CommentingController(ICommentingService commentingService)
        {
            _commentingService = commentingService;
        }
        //Gets comments on ticket Id
        [HttpGet("tickets/{ticketId}/comments/")]
        public async Task<IActionResult> GetCommentOnTicketAsync([FromRoute] Guid ticketId)
        {
            try
            {
                var commentingContenet = await _commentingService.GetCommentOnTicketAsync(ticketId);
                return Ok(commentingContenet);
            }
            catch
            {
                return StatusCode(503);
            }

        }
        //Adds comment to ticket Id
        [HttpPost("tickets/comment/{ticketId}")]
        public async Task<IActionResult> PostCommentAsync([FromBody]TicketComments ticketComments)
        {
            try
            {
                if (ticketComments == null)
                {
                    return BadRequest();
                }

                return Ok(await _commentingService.AddComment(ticketComments));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new ticket");
            }

        }


    }
}
