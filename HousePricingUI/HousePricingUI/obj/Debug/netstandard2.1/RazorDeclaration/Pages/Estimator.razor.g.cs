#pragma checksum "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13831e0339ce5fc3aef37f6a75992bd5986ab88e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HousePricingUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using HousePricingUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using HousePricingUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimator.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/estimator")]
    public partial class Estimator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimator.razor"

    public string Prediction{get; set; }

    private HouseModel house = new HouseModel();

    private async Task Submit() {

        var response = await Http.PostAsJsonAsync("https://localhost:4300/HouseEstimator/estimate", house);
        String responsestring;
        responsestring = await response.Content.ReadAsStringAsync();
        Prediction = "The estimated value of your property is " + responsestring;

    }

    public void Change()
    {
        Prediction = "Something";
    }



    public void HandleValidSubmit()
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
