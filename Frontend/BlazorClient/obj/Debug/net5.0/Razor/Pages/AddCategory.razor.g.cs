#pragma checksum "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23322bc10c6655fe5bdc35072568a916bb4b78ae"
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
#line 2 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcategory")]
    public partial class AddCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
#nullable restore
#line 18 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
         if (authContext.User.IsInRole(Admin))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(2, "<hr>\r\n            ");
                __builder2.AddMarkupContent(3, "<p><a href=\"/managecategories\">Back</a></p>\r\n            ");
                __builder2.OpenElement(4, "card");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
                __builder2.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
                                 cat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 26 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
                                                     FormSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((formContext) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n                    ");
                    __builder3.AddMarkupContent(11, "<h2>Create FAQ</h2>\r\n                    <hr>\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n\r\n                    ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "row");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "col-md-8");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "form-group");
                    __builder3.AddMarkupContent(20, "<label for=\"Name\" class=\"control-label\">Category</label>\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                    __builder3.AddAttribute(22, "id", "Name");
                    __builder3.AddAttribute(23, "class", "form-control");
                    __builder3.AddAttribute(24, "placeholder", "Category");
                    __builder3.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
                                                        cat.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cat.Name = __value, cat.Name))));
                    __builder3.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cat.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n                                \r\n                                ");
                    __Blazor.BlazorClient.Pages.AddCategory.TypeInference.CreateValidationMessage_0(__builder3, 29, 30, 
#nullable restore
#line 39 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
                                                          () => cat.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Save\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 46 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"

        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "p");
                __builder2.AddContent(33, "You\'re not signed in as a user in ");
                __builder2.AddContent(34, 
#nullable restore
#line 51 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
                                                  Admin

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(35, ".");
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(36, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.AddMarkupContent(37, "<p>Please log in.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\AddCategory.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string Admin = "Administrators";
    System.Security.Claims.ClaimsPrincipal CurrentUser;
    Category cat = new Category();

    private async Task FormSubmit()
    {
        cat.CategoryId = Guid.NewGuid();


        await Http.PostJsonAsync("https://localhost:5008/api/categorylist", cat);

        NavigationManager.NavigateTo("managecategories");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorClient.Services.IFaqService FaqService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorClient.Pages.AddCategory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
