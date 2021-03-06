#pragma checksum "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5926d89df4532fde04d0a3e39300a32b3255d91e"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Estimation</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h5>Please fill the from below:</h5>\r\n");
            __builder.AddMarkupContent(2, "<p>The form must be filled with the information about the house you want to evaluate.</p>\r\n\r\n");
#nullable restore
#line 7 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
 if (Prediction != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "h2");
            __builder.AddAttribute(5, "class", "bg-warning");
            __builder.AddContent(6, 
#nullable restore
#line 9 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                            Prediction

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    <hr>\r\n");
#nullable restore
#line 11 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                  house

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n    ");
                __builder2.OpenElement(18, "p");
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "label");
                __builder2.AddMarkupContent(21, "\r\n            No. of bedrooms:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_0(__builder2, 22, 23, 
#nullable restore
#line 20 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Bedrooms

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Bedrooms = __value, house.Bedrooms)), 25, () => house.Bedrooms);
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "p");
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "label");
                __builder2.AddMarkupContent(32, "\r\n            No. of bathrooms:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_1(__builder2, 33, 34, 
#nullable restore
#line 26 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Bathrooms

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Bathrooms = __value, house.Bathrooms)), 36, () => house.Bathrooms);
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "p");
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "label");
                __builder2.AddMarkupContent(43, "\r\n            Sqft of the living space:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_2(__builder2, 44, 45, 
#nullable restore
#line 32 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Sqft_living

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Sqft_living = __value, house.Sqft_living)), 47, () => house.Sqft_living);
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "p");
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "label");
                __builder2.AddMarkupContent(54, "\r\n            Sqft of the lot:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_3(__builder2, 55, 56, 
#nullable restore
#line 38 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Sqft_lot

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Sqft_lot = __value, house.Sqft_lot)), 58, () => house.Sqft_lot);
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.OpenElement(62, "p");
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "label");
                __builder2.AddMarkupContent(65, "\r\n            No. of floors:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_4(__builder2, 66, 67, 
#nullable restore
#line 44 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Floors

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Floors = __value, house.Floors)), 69, () => house.Floors);
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.OpenElement(73, "p");
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenElement(75, "label");
                __builder2.AddMarkupContent(76, "\r\n            Waterfront:\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(77);
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                        house.Waterfront

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Waterfront = __value, house.Waterfront))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => house.Waterfront));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n    ");
                __builder2.OpenElement(84, "p");
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.OpenElement(86, "label");
                __builder2.AddMarkupContent(87, "\r\n            View:\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(88);
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                        house.View

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.View = __value, house.View))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => house.View));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.OpenElement(95, "p");
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.OpenElement(97, "label");
                __builder2.AddMarkupContent(98, "\r\n            Condition:\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_5(__builder2, 99, 100, 
#nullable restore
#line 62 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Condition

#line default
#line hidden
#nullable disable
                , 101, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Condition = __value, house.Condition)), 102, () => house.Condition);
                __builder2.AddMarkupContent(103, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n    ");
                __builder2.OpenElement(106, "p");
                __builder2.AddMarkupContent(107, "\r\n        ");
                __builder2.OpenElement(108, "label");
                __builder2.AddMarkupContent(109, "\r\n            Grade:\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_6(__builder2, 110, 111, 
#nullable restore
#line 69 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Grade

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Grade = __value, house.Grade)), 113, () => house.Grade);
                __builder2.AddMarkupContent(114, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n    ");
                __builder2.OpenElement(117, "p");
                __builder2.AddMarkupContent(118, "\r\n        ");
                __builder2.OpenElement(119, "label");
                __builder2.AddMarkupContent(120, "\r\n            Sqft above ground level:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_7(__builder2, 121, 122, 
#nullable restore
#line 75 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Sqft_above

#line default
#line hidden
#nullable disable
                , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Sqft_above = __value, house.Sqft_above)), 124, () => house.Sqft_above);
                __builder2.AddMarkupContent(125, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n    ");
                __builder2.OpenElement(128, "p");
                __builder2.AddMarkupContent(129, "\r\n        ");
                __builder2.OpenElement(130, "label");
                __builder2.AddMarkupContent(131, "\r\n            Sqft basement:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputNumber_8(__builder2, 132, 133, 
#nullable restore
#line 81 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                      house.Sqft_basement

#line default
#line hidden
#nullable disable
                , 134, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Sqft_basement = __value, house.Sqft_basement)), 135, () => house.Sqft_basement);
                __builder2.AddMarkupContent(136, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n    ");
                __builder2.OpenElement(139, "p");
                __builder2.AddMarkupContent(140, "\r\n        ");
                __builder2.OpenElement(141, "label");
                __builder2.AddMarkupContent(142, "\r\n            Cunstruction date:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputDate_9(__builder2, 143, 144, 
#nullable restore
#line 87 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                    house.Year_built

#line default
#line hidden
#nullable disable
                , 145, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Year_built = __value, house.Year_built)), 146, () => house.Year_built);
                __builder2.AddMarkupContent(147, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n    ");
                __builder2.OpenElement(150, "p");
                __builder2.AddMarkupContent(151, "\r\n        ");
                __builder2.OpenElement(152, "label");
                __builder2.AddMarkupContent(153, "\r\n            Renovation date:<br>\r\n            ");
                __Blazor.HousePricingUI.Pages.Estimation.TypeInference.CreateInputDate_10(__builder2, 154, 155, 
#nullable restore
#line 93 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                                    house.Year_renovated

#line default
#line hidden
#nullable disable
                , 156, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => house.Year_renovated = __value, house.Year_renovated)), 157, () => house.Year_renovated);
                __builder2.AddMarkupContent(158, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n\r\n    ");
                __builder2.AddMarkupContent(161, "<p style=\"font-size:small\">Note that the price provided by us is just an estimation and the real value may varry in your location.</p>\r\n    ");
                __builder2.OpenElement(162, "button");
                __builder2.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "D:\dotNET\WeT\HousePricing\HousePricingUI\HousePricingUI\Pages\Estimation.razor"
                      Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "class", "btn btn-primary");
                __builder2.AddContent(165, "Submit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\r\n");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.HousePricingUI.Pages.Estimation
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
