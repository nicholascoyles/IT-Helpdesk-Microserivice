using BlazorClient.Models;
using BlazorClient.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Pages
{
    public class FaqListBase : ComponentBase
    {
        [Inject]
        public IFaqService FaqService { get; set; }
        public IEnumerable<Faq> Faqs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Faqs = (await FaqService.GetFaqs()).ToList();
        }
    }
}
