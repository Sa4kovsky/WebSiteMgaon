#pragma checksum "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\Shared\ThemeSwitcher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eb8f92eded0c312595206a95508f01446bb2753"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Websites.Blazor_master.demo.BlazorDemo_ClientSideWithPrerendering.BlazorDemo_ClientSide.Shared
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
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using Demo.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Pages.CodeSnippets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Pages.CodeSnippets.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using BlazorDemo.ClientSide.Pages.CaseViews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\Shared\ThemeSwitcher.razor"
using DevExpress.Blazor.DocumentMetadata;

#line default
#line hidden
#nullable disable
    public partial class ThemeSwitcher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ClientSideWithPrerendering\BlazorDemo.ClientSide\Shared\ThemeSwitcher.razor"
       
    [Parameter] public bool Shown { get; set; }
    [Parameter] public Action<bool> ShownChanged { get; set; }
    [Inject] IDocumentMetadataService DocumentMetadataService { get; set; }

    string currentTheme = "pulse";

    public class ThemeSetModel {
        public string Title { get; }
        public string[] Themes { get; }
        public ThemeSetModel(string title, params string[] themes) {
            Title = title;
            Themes = themes;
        }
    }

    List<ThemeSetModel> themeData = new List<ThemeSetModel>() {
        new ThemeSetModel("Color Themes",  "default"),
        new ThemeSetModel("DevExpress Themes", "purple", "office white"),
        new ThemeSetModel("Bootswatch Themes", "cerulean", "cosmo", "cyborg", "darkly", "flatly", "journal", "litera", "lumen", "lux", "materia", "minty", "pulse",
            "sandstone", "simplex", "sketchy", "slate", "solar", "spacelab", "superhero", "united", "yeti")
    };


    void OnItemClick(string theme) {
        currentTheme = theme;
        DocumentMetadataService.Update((m) => {
            m.StyleSheet("currentTheme", $"css/switcher-resources/themes/{currentTheme}/bootstrap.min.css");
        });
        Shown = !Shown;
        ShownChanged?.Invoke(Shown);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
