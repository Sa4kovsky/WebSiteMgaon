#pragma checksum "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\Pages\CaseViews\FormLayout-Vertical.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b294061f53c2330afae1dae6fcdde69313201d73"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Websites.Blazor_master.demo.BlazorDemo_ClientSide.BlazorDemo_ClientSide.Pages.CaseViews
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using Demo.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Pages.CodeSnippets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Pages.CodeSnippets.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Pages.CaseViews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\Pages\CaseViews\FormLayout-Vertical.razor"
using Demo.Blazor.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class FormLayout_Vertical : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSide\BlazorDemo.ClientSide\Pages\CaseViews\FormLayout-Vertical.razor"
       
    string location = "London";
    string Location { get => location; set { location = value; OnChanged(); } }

    DateTime checkIn = DateTime.Now;
    DateTime CheckIn { get => checkIn; set { checkIn = value; OnChanged(); } }

    DateTime checkOut = DateTime.Now;
    DateTime CheckOut { get => checkOut; set { checkOut = value; OnChanged(); } }


    void OnChanged() { InvokeAsync(StateHasChanged); }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
