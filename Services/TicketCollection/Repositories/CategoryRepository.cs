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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TicketCollectionDbContext _ticketCollectionDbContext;

        public CategoryRepository(TicketCollectionDbContext ticketCollectionDbContext)
        {
            _ticketCollectionDbContext = ticketCollectionDbContext;
        }


        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _ticketCollectionDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(Guid categoryId)
        {
            return await _ticketCollectionDbContext.Categories.Where(x => x.CategoryId.ToString() == categoryId.ToString()).FirstOrDefaultAsync();
        }

        public async Task<Category> AddCategory(Category category)
        {
            _ticketCollectionDbContext.Add(category);
            await _ticketCollectionDbContext.SaveChangesAsync();
            return category;

        }

        public async Task<IActionResult> DeleteCategory(Guid categoryId)
        {

            var result = await _ticketCollectionDbContext.Categories
                .FindAsync(categoryId);

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

        public async Task<Category> UpdateCategory(Category category)
        {
            var result = await _ticketCollectionDbContext.Categories
                   .FirstOrDefaultAsync(e => e.CategoryId == category.CategoryId);
            if (result != null)
            {
                result.Name = category.Name;


                await _ticketCollectionDbContext.SaveChangesAsync();

                return category;
            }
            return null;
        }



    }
}
