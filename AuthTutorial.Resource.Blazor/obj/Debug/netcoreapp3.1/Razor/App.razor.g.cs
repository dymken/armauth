#pragma checksum "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecc7bc3c80a2ae64231bc83be0de4a69c676efb"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthTutorial.Resource.Blazor
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(3);
                __builder2.AddAttribute(4, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 14 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 16 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 16 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(11, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(13);
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(16);
                        __builder4.AddAttribute(17, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 20 "D:\Users\Dmitry\Projects\Study\AuthTutorial\AuthTutorial.Resource.Blazor\App.razor"
                                     typeof(MainLayout)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(19, "\r\n                    ");
                            __builder5.AddMarkupContent(20, "<h1>404 Error</h1>\r\n                    ");
                            __builder5.AddMarkupContent(21, "<p>Sorry, there\'s nothing at this address.</p>\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
