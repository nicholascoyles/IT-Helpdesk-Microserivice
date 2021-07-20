#pragma checksum "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb127c7123e9f5f235011a5ee73ec73cb06932c"
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
#line 2 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/managecategories")]
    public partial class ManageCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 15 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
         if (@context.User.IsInRole(Admin))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(2, "<h3>Manage Categories</h3>");
                __builder2.AddMarkupContent(3, "<hr>\r\n            ");
                __builder2.AddMarkupContent(4, "<p><a href=\"/addcategory\">Create New Category</a></p>");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "<thead><tr><th>Category</th>\r\n                        <th>Action</th></tr></thead>\r\n                ");
                __builder2.OpenElement(8, "tbody");
#nullable restore
#line 33 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
                     foreach (var cat in Categories)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "tr");
                __builder2.OpenElement(10, "td");
                __builder2.AddContent(11, 
#nullable restore
#line 36 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
                                 cat.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n\r\n                            ");
                __builder2.OpenElement(13, "td");
                __builder2.OpenElement(14, "a");
                __builder2.AddAttribute(15, "href", "/editcategory/" + (
#nullable restore
#line 39 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
                                                        cat.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(16, "Edit");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 42 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"

                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 46 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"




        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(17, "<p>No access.</p>");
#nullable restore
#line 54 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(18, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "<p>No access</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\ManageCategory.razor"
      

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string Admin = "Administrators";
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    private List<Category> Categories = new List<Category>();

    protected override async Task OnInitializedAsync()
    {
        Categories = await CategoryService.GetCategories();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorClient.Services.ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
