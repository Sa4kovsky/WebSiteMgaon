#pragma checksum "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\CaseViews\Editors-ComboBox-Cascading.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83dad1d346211633374863784a27be5017b83226"
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
#line 18 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\CaseViews\Editors-ComboBox-Cascading.razor"
using Demo.Blazor.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class Editors_ComboBox_Cascading : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\sachkovski.ev\source\repos\Websites\Websites\Blazor-master\demo\BlazorDemo.ServerSide\BlazorDemo.ServerSide\Pages\CaseViews\Editors-ComboBox-Cascading.razor"
       
    List<Country> Countries = CountryCity.Countries;
    List<City> CurrentCountryCities = new List<City>();
    Country CurrentCountry = CountryCity.Countries[1];
    City CurrentCity = CountryCity.Cities[4];

    bool dropDownVisible1 = true;
    bool DropDownVisible1 { get => dropDownVisible1; set { dropDownVisible1 = value; InvokeAsync(StateHasChanged); }  }

    bool dropDownVisible2 = true;
    bool DropDownVisible2 { get => dropDownVisible2; set { dropDownVisible2 = value; InvokeAsync(StateHasChanged); }  }


    protected override void OnInitialized()
    {
        SelectedCountryChanged(CurrentCountry);
    }

    void SelectedCountryChanged(Country country)
    {
        CurrentCountry = country;
        CurrentCountryCities = CountryCity.Cities.FindAll(city => city.CountryId == CurrentCountry.Id);
        CurrentCity = CurrentCountryCities[0];
        InvokeAsync(StateHasChanged);
    }
    void SelectedCityChanged(City city)
    {
        CurrentCity = city;
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
