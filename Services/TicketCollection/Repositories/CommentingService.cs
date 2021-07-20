using Nancy.Json;
using Newtonsoft.Json;
using Polly;
using Polly.CircuitBreaker;
using Polly.Retry;
using Polly.Wrap;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TicketCollection.Models;

namespace TicketCollection.Repositories
{
    //All controller functions connected to the database
    public class CommentingService : ICommentingService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CommentingService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<TicketComments>> GetCommentOnTicketAsync(Guid ticketId)
        {
            //Gets comments from discussion service and converts json into useable string repsonse

            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync($"https://localhost:5004/api/commenting/tickets/{ticketId}/comments/");

            var responseText = await response.Content.ReadAsStringAsync();

            return System.Text.Json.JsonSerializer.Deserialize<List<TicketComments>>(responseText);
        }

    }
}
