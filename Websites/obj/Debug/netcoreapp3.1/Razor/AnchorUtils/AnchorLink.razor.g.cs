#pragma checksum "C:\Users\sachkovski.ev\source\repos\Websites\Websites\AnchorUtils\AnchorLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca30cf9d13c192c1d987e9cb8aeee063e92ffc3"
// <auto-generated/>
#pragma warning disable 1591
namespace Websites.AnchorUtils
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Websites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Websites.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\_Imports.razor"
using Websites.AnchorUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\AnchorUtils\AnchorLink.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    public partial class AnchorLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddMultipleAttributes(1, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\AnchorUtils\AnchorLink.razor"
                       Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "href", 
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\AnchorUtils\AnchorLink.razor"
                                          GetHref()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, 
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\AnchorUtils\AnchorLink.razor"
                                                      ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\AnchorUtils\AnchorLink.razor"
       
    [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> Attributes { get; set; }

    [Parameter] public RenderFragment ChildContent { get; set; }

    string GetHref()
    {
        var hrefValue = Attributes["href"].ToString();
        if (hrefValue.StartsWith("#"))
        {
            hrefValue = NavigationManager.ToAbsoluteUri(NavigationManager.Uri).GetLeftPart(UriPartial.Path) + hrefValue;
        }
        return hrefValue;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
