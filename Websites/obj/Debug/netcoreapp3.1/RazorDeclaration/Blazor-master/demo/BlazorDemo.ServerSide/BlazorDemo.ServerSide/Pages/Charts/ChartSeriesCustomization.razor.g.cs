#pragma checksum "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\Charts\ChartSeriesCustomization.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73a416238ddbb6950c28a489c4fa40312dcb50fa"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Websites.Blazor_master.demo.BlazorDemo_ServerSide.BlazorDemo_ServerSide.Pages.Charts
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\Charts\ChartSeriesCustomization.razor"
using Demo.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\Charts\ChartSeriesCustomization.razor"
using Demo.Blazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\Charts\ChartSeriesCustomization.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\Charts\ChartSeriesCustomization.razor"
using Demo.Blazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\Charts\ChartSeriesCustomization.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChartSeriesCustomization")]
    public partial class ChartSeriesCustomization : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\Charts\ChartSeriesCustomization.razor"
       
    WeatherForecast[] WeatherForecasts;

    protected override async Task OnInitializedAsync()
    {
        WeatherForecasts = await ForecastService.GetDetailedForecastAsync();
    }

    protected void PreparePointColor(ChartSeriesPointCustomizationSettings pointSettings)
    {
        double value = (double)pointSettings.Point.Value;
        if(value > 75)
            pointSettings.PointAppearance.Color = System.Drawing.Color.Red;
        else if(value < 25)
            pointSettings.PointAppearance.Color = System.Drawing.Color.Blue;
    }
    protected void PreparePointLabel(ChartSeriesPointCustomizationSettings pointSettings)
    {
        double value = (double)pointSettings.Point.Value;
        if(value > 25 && value < 75)
            pointSettings.PointLabel.Visible = true;
    }
    protected void PreparePointImage(ChartSeriesPointCustomizationSettings pointSettings)
    {
        IEnumerable<WeatherForecast> dataItems = pointSettings.Point.DataItems.Cast<WeatherForecast>();
        var weatherType = dataItems.GroupBy(x => x.WeatherType).OrderByDescending(x => x.Count()).First().Key;
        pointSettings.PointAppearance.Image.Url = $"images/{weatherType}.png";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
