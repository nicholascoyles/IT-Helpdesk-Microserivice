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
    public class CommentService : ICommentService
    {
        private readonly HttpClient _httpClient;
        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<TicketComments>> GetCommentById(string TicketId)
        {
            var response = await _httpClient.GetJsonAsync <List<TicketComments>>($"/api/tickets/{TicketId}/comments/");
            return response;
        }
    }
    }
