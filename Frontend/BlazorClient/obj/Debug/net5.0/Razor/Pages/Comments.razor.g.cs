#pragma checksum "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0852f62909f90303e2d0f583d8f01a23a69b2314"
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
#line 4 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/comments/{TicketId}")]
    public partial class Comments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
#nullable restore
#line 13 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
         if (ticketComments == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(2, "<span>Loading Comments....</span>");
#nullable restore
#line 16 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
        }
        else
        {


#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(3, "<h2>Tickets Discussion</h2>\r\n            <hr>\r\n            ");
                __builder2.AddMarkupContent(4, "<p><a href=\"/ticketlist\">Back</a></p>");
#nullable restore
#line 28 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
             foreach (var comments in ticketComments)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                 if (comments.User != "nicholasadmin@email.com")
                {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(5, "p");
                __builder2.AddAttribute(6, "class", " message sent");
                __builder2.AddContent(7, 
#nullable restore
#line 33 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                              comments.CommentContent

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n                    ");
                __builder2.OpenElement(9, "p");
                __builder2.AddAttribute(10, "class", " sent-info user");
                __builder2.AddContent(11, 
#nullable restore
#line 34 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                comments.User

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(12, ": ");
                __builder2.AddContent(13, 
#nullable restore
#line 34 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                                comments.PostTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"


                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(14, "p");
                __builder2.AddAttribute(15, "class", " message received");
                __builder2.AddContent(16, 
#nullable restore
#line 40 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                  comments.CommentContent

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "p");
                __builder2.AddAttribute(19, "class", " received-info user");
                __builder2.AddContent(20, 
#nullable restore
#line 41 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                    comments.User

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(21, ": ");
                __builder2.AddContent(22, 
#nullable restore
#line 41 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                                    comments.PostTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 42 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                 

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
             

        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "card");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
                __builder2.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                             _newComment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 52 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                         FormSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(28);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n                ");
                    __builder3.AddMarkupContent(30, "<h2>Post Comment:</h2>\r\n                <hr>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(31);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n\r\n                ");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "row");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "col-md-8");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "class", "form-group");
                    __builder3.AddMarkupContent(39, "<label for=\"Comment\" class=\"control-label\">Comment</label>\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                    __builder3.AddAttribute(41, "id", "Comment");
                    __builder3.AddAttribute(42, "class", "form-control");
                    __builder3.AddAttribute(43, "placeholder", "Add Comment...");
                    __builder3.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                    _newComment.CommentContent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _newComment.CommentContent = __value, _newComment.CommentContent))));
                    __builder3.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _newComment.CommentContent));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n                            \r\n                            ");
                    __Blazor.BlazorClient.Pages.Comments.TypeInference.CreateValidationMessage_0(__builder3, 48, 49, 
#nullable restore
#line 65 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
                                                      () => _newComment.CommentContent

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Save\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(51, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.AddMarkupContent(52, "<p>You\'re not logged in.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\User\Desktop\Code submission\NicholasHelpDesk\Frontend\BlazorClient\Pages\Comments.razor"
      
    private BlazorClient.Models.TicketComments CurrentComment;
    public string UserName;
    TicketComments _newComment = new TicketComments();
    private List<TicketComments> ticketComments = new List<TicketComments>();

    [Parameter]
    public string TicketId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        UserName = httpContextAccessor.HttpContext.User.Identity.Name;
        ticketComments = await Http.GetJsonAsync<List<TicketComments>>($"https://localhost:5008/api/tickets/{TicketId}/comments/");
    }

    private async Task FormSubmit()
    {
        _newComment.CommentId = Guid.NewGuid().ToString();
        _newComment.TicketId = TicketId;
        _newComment.PostTime = DateTime.Now;
        _newComment.User = UserName;

        await Http.PostJsonAsync($"https://localhost:5008/api/commenting/tickets/comment/{TicketId}", _newComment);

    }








#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorClient.Pages.Comments
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