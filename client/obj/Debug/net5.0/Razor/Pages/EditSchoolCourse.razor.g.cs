#pragma checksum "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a5b35e15a30aa442147d3f7277eebb536dcb513"
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
#line 5 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
using GodswillEduRecord.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
using GodswillEduRecord.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-school-course/{CourseOfStudyID}")]
    public partial class EditSchoolCourse : GodswillEduRecord.Pages.EditSchoolCourseComponent
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
                __builder2.AddAttribute(6, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "style", "font-weight: bold");
                __builder2.AddAttribute(9, "Text", "Item no longer available.");
                __builder2.AddAttribute(10, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                           !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n      ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 22 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(17, "Text", "Close");
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                              !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(25);
                __builder2.AddAttribute(26, "style", "font-weight: bold");
                __builder2.AddAttribute(27, "Text", "Another user has made conflicting changes to one or more of the fields you have modified. Please reload.");
                __builder2.AddAttribute(28, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                                                                                         hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n      ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                __builder2.AddAttribute(33, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", "autorenew");
                __builder2.AddAttribute(35, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(36, "Text", "Reload");
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                                               hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                                                                   Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<GodswillEduRecord.Models.ConData.SchoolCourse>>(44);
                __builder2.AddAttribute(45, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GodswillEduRecord.Models.ConData.SchoolCourse>(
#nullable restore
#line 38 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                         schoolcourse

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                                  schoolcourse != null && canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GodswillEduRecord.Models.ConData.SchoolCourse>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GodswillEduRecord.Models.ConData.SchoolCourse>(this, 
#nullable restore
#line 38 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                                                                             Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(51, "class", "row");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Course Of Study Name");
                    __builder3.AddAttribute(56, "Component", "CourseOfStudyName");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(61);
                    __builder3.AddAttribute(62, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 46 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                          300

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(64, "Name", "CourseOfStudyName");
                    __builder3.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                  schoolcourse.CourseOfStudyName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => schoolcourse.CourseOfStudyName = __value, schoolcourse.CourseOfStudyName))));
                    __builder3.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => schoolcourse.CourseOfStudyName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(69);
                    __builder3.AddAttribute(70, "Component", "CourseOfStudyName");
                    __builder3.AddAttribute(71, "Text", "CourseOfStudyName is required");
                    __builder3.AddAttribute(72, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(76, "class", "row");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(79);
                    __builder3.AddAttribute(80, "Text", "Course Fee");
                    __builder3.AddAttribute(81, "Component", "CourseFee");
                    __builder3.AddAttribute(82, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditSchoolCourse.TypeInference.CreateRadzenNumeric_0(__builder3, 86, 87, "width: 100%", 88, "CourseFee", 89, 
#nullable restore
#line 58 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                  schoolcourse.CourseFee

#line default
#line hidden
#nullable disable
                    , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => schoolcourse.CourseFee = __value, schoolcourse.CourseFee)), 91, () => schoolcourse.CourseFee);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(95, "class", "row");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(98);
                    __builder3.AddAttribute(99, "Text", "Duration In Months");
                    __builder3.AddAttribute(100, "Component", "DurationInMonths");
                    __builder3.AddAttribute(101, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n              ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditSchoolCourse.TypeInference.CreateRadzenNumeric_1(__builder3, 105, 106, "display: block; width: 100%", 107, "DurationInMonths", 108, 
#nullable restore
#line 68 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                  schoolcourse.DurationInMonths

#line default
#line hidden
#nullable disable
                    , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => schoolcourse.DurationInMonths = __value, schoolcourse.DurationInMonths)), 110, () => schoolcourse.DurationInMonths);
                    __builder3.AddMarkupContent(111, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(112);
                    __builder3.AddAttribute(113, "Component", "DurationInMonths");
                    __builder3.AddAttribute(114, "Text", "DurationInMonths is required");
                    __builder3.AddAttribute(115, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n            ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "row");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(121);
                    __builder3.AddAttribute(122, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 76 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(123, "Icon", "save");
                    __builder3.AddAttribute(124, "Text", "Save");
                    __builder3.AddAttribute(125, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 76 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(126, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(127);
                    __builder3.AddAttribute(128, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 78 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(129, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(130, "Text", "Cancel");
                    __builder3.AddAttribute(131, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\GodswillEduRecord\client\Pages\EditSchoolCourse.razor"
                                                                                                              Button4Click

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
namespace __Blazor.GodswillEduRecord.Client.Pages.EditSchoolCourse
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591