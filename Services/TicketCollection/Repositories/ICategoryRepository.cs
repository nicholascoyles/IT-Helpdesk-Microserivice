using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Models;

namespace TicketCollection.Repositories
{
    //Links controller and repository
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(Guid categoryId);
        Task<Category> AddCategory(Category category);

        Task<IActionResult> DeleteCategory(Guid categoryId);

        Task<Category> UpdateCategory(Category category);

    }
}
