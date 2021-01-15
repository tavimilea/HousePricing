#pragma checksum "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5926d89df4532fde04d0a3e39300a32b3255d91e"
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
#line 1 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 106 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
using HOUSE_ESTIMATORML.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/estimation")]
    public partial class Estimation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                   

    public string Prediction { get; set; }

    private House house = new House();

    private void Submit()
    {

        var input = new ModelInput()
        {
            Bedrooms = house.Bedrooms,
            Ba0hrooms = house.Bathrooms,
            Sqf0_living = house.Sqft_living,
            Sqf0_lo0 = house.Sqft_lot,
            Floors = house.Floors,
            Wa0erfron0 = house.Waterfront,
            View = house.View,
            Condi0ion = house.Condition,
            Grade = house.Grade,
            Sqf0_above = house.Sqft_above,
            Sqf0_basemen0 = house.Sqft_basement,
            Yr_buil0 = house.Year_built,
            Yr_renova0ed = house.Year_renovated,

        };

        ModelOutput result = ConsumeModel.Predict(input);
        Prediction = "The estimated value of your property is " + result.Score.ToString() + "$";

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
    }
}
#pragma warning restore 1591