using BlazorClient.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public class TicketService : ITicketService
    {
        private readonly HttpClient _httpClient;
        public TicketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Ticket>> GetTickets()
        {
            return await _httpClient.GetJsonAsync<List<Ticket>>("/api/ticketlist");
        }

        public async Task<Ticket> GetTicketById(string ticketId)
        {
            /*            Guid ticket = new Guid(ticketId);
            */
            var response = await _httpClient.GetJsonAsync<Ticket>($"/api/ticketlist/{ticketId}");
            return response;
        }
        public async Task<List<Ticket>> GetTicketsByUser(string UserName)
        {
            var response = await _httpClient.GetJsonAsync<List<Ticket>>("/api/usertickets/"+ UserName);
            return response;

        }
        public async Task<List<Category>> GetCategory()
        {

            return await _httpClient.GetJsonAsync<List<Category>>($"/api/categories");
        }

        public async Task<Category> GetCategoryById(Guid categoryId)
        {
            return await _httpClient.GetJsonAsync<Category>($"/api/categories/{categoryId}");
        }


        public async Task<List<Status>> GetStatus()
        {

            return await _httpClient.GetJsonAsync<List<Status>>($"/api/statuses");
        }

        public async Task<List<Priority>> GetPriority()
        {

            return await _httpClient.GetJsonAsync<List<Priority>>($"/api/priorities");
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByStatus(Guid statusId)
        {
            return await _httpClient.GetJsonAsync<IEnumerable<Ticket>>($"/api/tickets/Status/{statusId}");

        }
    }
}
