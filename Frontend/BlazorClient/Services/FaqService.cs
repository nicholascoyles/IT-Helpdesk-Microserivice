using BlazorClient.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public class FaqService : IFaqService
    {
        private readonly HttpClient _httpClient;
        public FaqService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Faq>> GetFaqs()
        {
            return await _httpClient.GetJsonAsync<List<Faq>>("/api/Faqlist");
        }

        public async Task<Faq> GetFaqById(string ticketId)
        {
            var response = await _httpClient.GetJsonAsync<Faq>($"/api/Faqlist/{ticketId}");
               return response;
        }






    }
}
