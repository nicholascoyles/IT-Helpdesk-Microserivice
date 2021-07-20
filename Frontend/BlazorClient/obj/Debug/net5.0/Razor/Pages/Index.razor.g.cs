#pragma checksum "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "699c58de22251d58d6b57500f7503fcc96c9ce04"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Index.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Index.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, welcome to Nicholas\' Help Desk!</h1>\r\n");
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, "Hello: ");
            __builder.AddContent(3, 
#nullable restore
#line 11 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Index.razor"
            UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(5, "<h3>Features:</h3>\r\n\r\n");
            __builder.AddMarkupContent(6, @"<ul><li>Create first user using: nicholasadmin@email.com</li>

    <li>Create Ticket</li>
    <li>Create FAQ</li>
    <li>Create Comment</li>
    <li>Comment on Ticket</li>
    <li>Edit Ticket</li>
    <li>Edit FAQ</li>
    <li>Edit Category</li>
    <li>Edit User</li></ul>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Index.razor"
       
    public string UserName;

    protected override async Task OnInitializedAsync()
    {
        UserName = httpContextAccessor.HttpContext.User.Identity.Name;
    }

    Ticket TicketDetail = new Ticket();
    List<Ticket> TicketDetails = new List<Ticket>();

    private async Task GenerateChart()
    {
        TicketDetails = await TicketService.GetTickets();
        await jsRunTime.InvokeVoidAsync("GenerateChart", TicketDetails);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorClient.Services.ITicketService TicketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591