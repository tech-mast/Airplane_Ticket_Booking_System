#pragma checksum "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e105547efcd91f1663a528514f09e395bdacb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EagleFlight.Pages.Pages_AjaxsearchResultTwo), @"mvc.1.0.razor-page", @"/Pages/AjaxsearchResultTwo.cshtml")]
namespace EagleFlight.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\_ViewImports.cshtml"
using EagleFlight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\_ViewImports.cshtml"
using EagleFlight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{DepartureDate}/{OriginLocation}/{ArriveLocation}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e105547efcd91f1663a528514f09e395bdacb6", @"/Pages/AjaxsearchResultTwo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c38c513a9589e8b8f48a13832c740e34c5acc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AjaxsearchResultTwo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "E", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "B", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <tbody>\r\n");
#nullable restore
#line 8 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
     foreach (var f in Model.FlightSearchList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n    <td>");
#nullable restore
#line 11 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
   Write(f.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 12 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
   Write(f.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 13 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
   Write(f.DepartureTime.ToString("yyyy/MM/dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 14 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
   Write(f.ArriveTime.ToString("yyyy/MM/dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 15 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
   Write(f.FlightType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 16 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
       string mystringE = "a"+@f.Id.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>  <a class=\"btn btn-primary\" data-bs-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 532, "\"", 550, 2);
            WriteAttributeValue("", 539, "#", 539, 1, true);
#nullable restore
#line 17 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue("", 540, mystringE, 540, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\" style=\"margin-bottom:20px\">\r\n        $ ");
#nullable restore
#line 18 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
     Write(f.TicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td> \r\n\r\n");
#nullable restore
#line 20 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
       string mystringB = "b"+@f.Id.ToString();

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
      double business = @f.TicketPrice * 1.5;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>  <a class=\"btn btn-danger\" data-bs-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 846, "\"", 864, 2);
            WriteAttributeValue("", 853, "#", 853, 1, true);
#nullable restore
#line 22 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue("", 854, mystringB, 854, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\" style=\"margin-bottom:20px; background-color:red\">\r\n    $ ");
#nullable restore
#line 23 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
 Write(business);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>  \r\n        \r\n    </tr>\r\n    <br>\r\n    <tr>\r\n    <td colspan=\"7\">\r\n");
            WriteLiteral("    <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1336, "\"", 1351, 1);
#nullable restore
#line 32 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue("", 1341, mystringE, 1341, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card card-body\">\r\n            <div class=\"row\">\r\n                <div class =\"col-md-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1489, "\"", 1519, 1);
#nullable restore
#line 36 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue("", 1495, f.FlightPlane.ImageFile, 1495, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250\">\r\n                </div>\r\n                <div class =\"col-md-6\">\r\n                    <P><span style=\"font-weight: bold\"> Flight Description: </span>");
#nullable restore
#line 39 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
                                                                              Write(f.FlightPlane.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P> \r\n                    <P><span style=\"font-weight: bold\">Max Passengers: </span> ");
#nullable restore
#line 40 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
                                                                          Write(f.FlightPlane.MaxPassenger);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P> \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e105547efcd91f1663a528514f09e395bdacb611586", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e105547efcd91f1663a528514f09e395bdacb611873", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 42 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Economy:</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2136, "\"", 2160, 2);
                WriteAttributeValue("", 2144, "$", 2144, 1, true);
#nullable restore
#line 45 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue(" ", 2145, f.TicketPrice, 2146, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly/>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29e105547efcd91f1663a528514f09e395bdacb614194", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 46 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlightClassTwo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29e105547efcd91f1663a528514f09e395bdacb616222", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 47 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlightIdTwo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
                                                                                                  WriteLiteral(f.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <button  class=\"btn btn-primary mt-2\">Select</button>\r\n");
                WriteLiteral("                            </div>                   \r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 2834, "\"", 2849, 1);
#nullable restore
#line 56 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue("", 2839, mystringB, 2839, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card card-body\">\r\n            <div class=\"row\">\r\n                <div class =\"col-md-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2987, "\"", 3017, 1);
#nullable restore
#line 60 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue("", 2993, f.FlightPlane.ImageFile, 2993, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250\">\r\n                </div>\r\n                <div class =\"col-md-6\">\r\n                    <P><span style=\"font-weight: bold\"> Flight Description: </span>");
#nullable restore
#line 63 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
                                                                              Write(f.FlightPlane.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P> \r\n                    <P><span style=\"font-weight: bold\">Max Passengers: </span> ");
#nullable restore
#line 64 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
                                                                          Write(f.FlightPlane.MaxPassenger);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P> \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e105547efcd91f1663a528514f09e395bdacb621978", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label>Business:</label>\r\n                            <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3529, "\"", 3548, 2);
                WriteAttributeValue("", 3537, "$", 3537, 1, true);
#nullable restore
#line 68 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
WriteAttributeValue(" ", 3538, business, 3539, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly/>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29e105547efcd91f1663a528514f09e395bdacb622882", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 69 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlightClassTwo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29e105547efcd91f1663a528514f09e395bdacb624906", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 70 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlightIdTwo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
                                                                                              WriteLiteral(f.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <button  class=\"btn btn-danger mt-2\">Select</button>\r\n                        </div>                   \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    </td>\r\n    </tr>\r\n");
#nullable restore
#line 80 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\AjaxsearchResultTwo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody> \r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EagleFlight.Pages.AjaxsearchResultTwoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EagleFlight.Pages.AjaxsearchResultTwoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EagleFlight.Pages.AjaxsearchResultTwoModel>)PageContext?.ViewData;
        public EagleFlight.Pages.AjaxsearchResultTwoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591