#pragma checksum "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da28e432f6cd39ffd35b4e13ae206a9f953cb1bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EagleFlight.Pages.Admin.Pages_Admin_TicketList), @"mvc.1.0.razor-page", @"/Pages/Admin/TicketList.cshtml")]
namespace EagleFlight.Pages.Admin
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{FlightId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da28e432f6cd39ffd35b4e13ae206a9f953cb1bb", @"/Pages/Admin/TicketList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c38c513a9589e8b8f48a13832c740e34c5acc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_TicketList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control border-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <tbody id=\"ticket_list\">\r\n");
#nullable restore
#line 10 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
         foreach(var ticket in Model.Tickets)
        {
            var user = await userManager.FindByIdAsync(ticket.PassengerId); 
            var flight = Model.Flights.Where(f=>f.Id==ticket.BookedFlightId).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 16 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
               Write(flight.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 16 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
                              Write(flight.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 16 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
                                                  Write(flight.DepartureTime.ToString("yyyyMMddHHmm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
               Write(user.IDName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
               Write(user.IDNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da28e432f6cd39ffd35b4e13ae206a9f953cb1bb5835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 791, "boarding_seat_", 791, 14, true);
#nullable restore
#line 25 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
AddHtmlAttributeValue("", 805, ticket.Id, 805, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 25 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ticket.Seat);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 28 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
                     if (ticket.Seat == null || ticket.Seat =="" )
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button");
            BeginWriteAttribute("id", " id=\"", 1050, "\"", 1078, 2);
            WriteAttributeValue("", 1055, "boarding_btn_", 1055, 13, true);
#nullable restore
#line 30 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
WriteAttributeValue("", 1068, ticket.Id, 1068, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1079, "\"", 1109, 3);
            WriteAttributeValue("", 1089, "boarding(", 1089, 9, true);
#nullable restore
#line 30 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
WriteAttributeValue("", 1098, ticket.Id, 1098, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1108, ")", 1108, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Boarding</button>\r\n");
#nullable restore
#line 31 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-primary\" disabled>Boarded</button>\r\n");
#nullable restore
#line 35 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Admin\TicketList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function boarding(tid)
        {
            $.get('/Admin/BoardingJSON/'+tid).done(function (seat){
                console.log(""boarding seat: ""+seat);
                if(seat!="""")
                {
                    $('#boarding_seat_'+tid).val(seat);
                    $('#boarding_btn_'+tid).html(""Boarded"");
                    $('#boarding_btn_'+tid).prop( ""disabled"", true );
                }
            })
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<EagleFlightUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EagleFlight.Pages.TicketListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EagleFlight.Pages.TicketListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EagleFlight.Pages.TicketListModel>)PageContext?.ViewData;
        public EagleFlight.Pages.TicketListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
