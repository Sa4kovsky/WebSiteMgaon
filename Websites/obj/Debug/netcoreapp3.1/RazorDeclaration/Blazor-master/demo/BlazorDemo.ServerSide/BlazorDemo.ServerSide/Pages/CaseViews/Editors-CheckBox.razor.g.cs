#pragma checksum "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\CaseViews\Editors-CheckBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4df3593465f40efde548359a2c4a7f0cb647c2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Websites.Blazor_master.demo.BlazorDemo_ServerSide.BlazorDemo_ServerSide.Pages.CaseViews
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using Demo.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using BlazorDemo.ServerSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using BlazorDemo.ServerSide.Pages.CodeSnippets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using BlazorDemo.ServerSide.Pages.CodeSnippets.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using BlazorDemo.ServerSide.Pages.CaseViews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\CaseViews\Editors-CheckBox.razor"
using Demo.Blazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\CaseViews\Editors-CheckBox.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class Editors_CheckBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\CaseViews\Editors-CheckBox.razor"
      
    bool AirConditioning { get; set; } = true;
    bool Multimedia { get; set; } = false;
    bool ParkingSensors { get; set; } = false;
    bool HeatedSeats { get; set; } = true;

    public Action<bool> Update(Action<bool> set) {
        return (v) => { set(v); InvokeAsync(StateHasChanged); };
    }
    decimal GetTotalPrice() {
        decimal price = 0;
        price += Multimedia ? 130 : 0;
        price += AirConditioning ? 800 : 0;
        price += ParkingSensors ? 400 : 0;
        price += HeatedSeats ? 230 : 0;
        return price;
    }
    string GetStyle(bool selected) {
        return "text-align:center;" + (selected ? "" : "text-decoration:line-through;");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591