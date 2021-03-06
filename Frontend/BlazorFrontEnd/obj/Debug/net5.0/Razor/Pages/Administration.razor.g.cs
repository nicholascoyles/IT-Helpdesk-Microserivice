#pragma checksum "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab8c653a87937dfa604f341fbe0b08ab28cfc313"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using BlazorFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\_Imports.razor"
using BlazorFrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administration</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 10 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "p");
                __builder2.AddContent(4, "You are in ");
                __builder2.AddContent(5, 
#nullable restore
#line 12 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
                           ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 13 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(6, "p");
                __builder2.AddContent(7, "You\'re not signed in as a user in ");
                __builder2.AddContent(8, 
#nullable restore
#line 16 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
                                                  ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(9, ".");
                __builder2.CloseElement();
#nullable restore
#line 17 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "<p>You\'re not loggged in.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorFrontEnd\Pages\Administration.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Administrators";
    System.Security.Claims.ClaimsPrincipal CurrentUser;
    protected override async Task OnInitializedAsync()
    {
        // ensure there is a ADMINISTRATION_ROLE
        var RoleResult = await _RoleManager.FindByNameAsync(ADMINISTRATION_ROLE);
        if (RoleResult == null)
        {
            // Create ADMINISTRATION_ROLE Role
            await _RoleManager.CreateAsync(new IdentityRole(ADMINISTRATION_ROLE));
        }
        // Ensure a user named Admin@BlazorHelpWebsite.com is an Administrator
        var user = await _UserManager.FindByNameAsync("Admin@BlazorHelpWebsite.com");
        if (user != null)
        {
            // Is Admin@BlazorHelpWebsite.com in administrator role?
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!UserResult)
            {
                // Put admin in Administrator role
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }
        // Get the current logged in user
        CurrentUser = (await authenticationStateTask).User;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
