#pragma checksum "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7383f46394c14d8057023cae7ddeddfc716640d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EagleFlight.Pages.Pages_Payment), @"mvc.1.0.razor-page", @"/Pages/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7383f46394c14d8057023cae7ddeddfc716640d5", @"/Pages/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c38c513a9589e8b8f48a13832c740e34c5acc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Payment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row mt-4\">\r\n    <div class=\"col-md-3\"></div>\r\n    <div class=\"col-md-5\">\r\n\r\n");
#nullable restore
#line 10 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Payment.cshtml"
           double totalA = Model.xtt.Price+Model.xtt2.Price;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Total Amount is : $ ");
#nullable restore
#line 11 "E:\Ying\JohnAbbott\IPD-24\ASP.NET\Eagle\Pages\Payment.cshtml"
                           Write(totalA.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3><br>
        <h2>Payment method: </h2><br>
        <div id=""paybt"" ></div>
    </div>
</div>

<script src=""https://www.paypal.com/sdk/js?client-id=AXhVH5rwOb9b4UKP98Y3ekIisCcZtCDSfpb_Z5Dxh4v6aUsmzunShTExTsqPNSPolqwlf92bXwMbt-dJ&disable-funding=credit,card""></script>

  <script>
");
            WriteLiteral(@"  var checkoutAmount = 1 ;

paypal.Buttons({
        createOrder: function(data, actions) {

          return actions.order.create({
            purchase_units: [{
              amount: {
                value: checkoutAmount
              }
            }]
          });
        },
        onApprove: function(data, actions) {
          return actions.order.capture().then(function(details) {
            location.href = ""/BookTicketSuccess""
          });
        }
      }).render('#paybt');

    </script>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EagleFlight.Pages.PaymentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EagleFlight.Pages.PaymentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EagleFlight.Pages.PaymentModel>)PageContext?.ViewData;
        public EagleFlight.Pages.PaymentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
