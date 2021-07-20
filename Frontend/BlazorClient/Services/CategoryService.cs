using BlazorClient.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<List<Category>> GetCategories()
        {
            return await _httpClient.GetJsonAsync<List<Category>>("/api/categorylist");
        }

        public async Task<Category> GetCategoryById(string categoryId)
        {
            var response = await _httpClient.GetJsonAsync<Category>($"/api/categorylist/{categoryId}");
            return response;
        }






    }
}
