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

namespace TicketCollection.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository _categoryRepository;
        private IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> Get()
        {
            try
            {
                var result = await _categoryRepository.GetAllCategories();
            return Ok(_mapper.Map<List<CategoryDto>>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<CategoryDto>> GetCategoryById(Guid categoryId)
        {
            try
            {
                var result = await _categoryRepository.GetCategoryById(categoryId);

                if (result == null)
                {
                    return NotFound($"Category with Id = {categoryId} not found");
                }

                return Ok(_mapper.Map<CategoryDto>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(Category category)
        {
            try
            {
                if (category == null)
                {
                    return BadRequest();
                }

                return Ok(await _categoryRepository.AddCategory(category));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new ticket");
            }
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteTicket(Guid categoryId)
        {
            try
            {
                var ticket = await _categoryRepository.GetCategoryById(categoryId);

                if (ticket == null)
                {
                    return NotFound($"Category with Id = {categoryId} not found");
                }
                return Ok(await _categoryRepository.DeleteCategory(categoryId));

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }


        [HttpPut("{categoryId}")]
        public async Task<ActionResult<Category>> UpdateTicket(Guid categoryId, [FromBody] Category category)
        {
            try
            {
                if (categoryId != category.CategoryId)
                {
                    return BadRequest("Category not found");
                }
                var ticketToUpdate = await _categoryRepository.GetCategoryById(categoryId);

                if (ticketToUpdate == null)
                {
                    return NotFound($"Ticket with Id = {categoryId} not found");
                }
                return await _categoryRepository.UpdateCategory(category);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }






    }
}
