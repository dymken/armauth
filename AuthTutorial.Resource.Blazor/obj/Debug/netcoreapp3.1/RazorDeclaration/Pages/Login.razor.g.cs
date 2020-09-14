#pragma checksum "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d246f3b913b17600d2cd56ed31e1bbe8c5d5f734"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AuthTutorial.Resource.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using AuthTutorial.Resource.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\_Imports.razor"
using AuthTutorial.Resource.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\Pages\Login.razor"
using AuthTutorial.Blazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\Pages\Login.razor"
using AuthTutorial.Resource.Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\Pages\Login.razor"
       
    private UserLogin login = new UserLogin();
    private string LoginErrorMessage = "";
    private CustomAuthenticationStateProvider AuthProvider { get { return (CustomAuthenticationStateProvider)authProvider; } }

    protected override void OnInitialized()
    {

    }

    private async void HandleValidSubmit()
    {
        var loginResult = await AuthProvider.Login(login);

        if (loginResult.Success)
        {
            navigationManager.NavigateTo("/");
        } else
        {
            LoginErrorMessage = loginResult.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
