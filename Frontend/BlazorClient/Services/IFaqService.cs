using BlazorClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public interface IFaqService
    {
        Task<List<Faq>> GetFaqs();

        Task<Faq> GetFaqById(string faqId);




    }
}
