#pragma checksum "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\tools\DevExpress.Blazor.AnchorUtils\AnchorLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb673b0acef6d06cf34895416a4342dbe1e3874"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DevExpress.Blazor.AnchorUtils
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
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\tools\DevExpress.Blazor.AnchorUtils\AnchorLink.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    public partial class AnchorLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\tools\DevExpress.Blazor.AnchorUtils\AnchorLink.razor"
       
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
