#pragma checksum "C:\GodswillEduRecord\client\Pages\AddState.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98883d05d27cc43342ca17c48c5fb00cf19be1de"
// <auto-generated/>
#pragma warning disable 1591
namespace GodswillEduRecord.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GodswillEduRecord\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GodswillEduRecord\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GodswillEduRecord\client\_Imports.razor"
using GodswillEduRecord.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GodswillEduRecord\client\_Imports.razor"
using GodswillEduRecord.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GodswillEduRecord\client\Pages\AddState.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\Pages\AddState.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\Pages\AddState.razor"
using GodswillEduRecord.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GodswillEduRecord\client\Pages\AddState.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GodswillEduRecord\client\Pages\AddState.razor"
using GodswillEduRecord.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GodswillEduRecord\client\Pages\AddState.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GodswillEduRecord\client\Pages\AddState.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-state")]
    public partial class AddState : GodswillEduRecord.Pages.AddStateComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<GodswillEduRecord.Models.ConData.State>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GodswillEduRecord.Models.ConData.State>(
#nullable restore
#line 18 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                   state

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                                     state != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GodswillEduRecord.Models.ConData.State>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GodswillEduRecord.Models.ConData.State>(this, 
#nullable restore
#line 18 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                                                                                                             Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "State Name");
                    __builder3.AddAttribute(19, "Component", "StateName");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                          50

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(27, "Name", "StateName");
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                                                                                 state.StateName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => state.StateName = __value, state.StateName))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => state.StateName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(32);
                    __builder3.AddAttribute(33, "Component", "StateName");
                    __builder3.AddAttribute(34, "Text", "StateName is required");
                    __builder3.AddAttribute(35, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "class", "row");
                    __builder3.OpenElement(39, "div");
                    __builder3.AddAttribute(40, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(41);
                    __builder3.AddAttribute(42, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 34 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Icon", "save");
                    __builder3.AddAttribute(44, "Text", "Save");
                    __builder3.AddAttribute(45, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 34 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(47);
                    __builder3.AddAttribute(48, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 36 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(50, "Text", "Cancel");
                    __builder3.AddAttribute(51, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\GodswillEduRecord\client\Pages\AddState.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
