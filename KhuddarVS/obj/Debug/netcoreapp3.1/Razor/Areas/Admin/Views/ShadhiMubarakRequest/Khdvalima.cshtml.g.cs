#pragma checksum "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c7d8f3bdbee1ee3b3929f97f128409d71f1c427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KhuddarVS.Pages.ShadhiMubarakRequest.Areas_Admin_Views_ShadhiMubarakRequest_Khdvalima), @"mvc.1.0.view", @"/Areas/Admin/Views/ShadhiMubarakRequest/Khdvalima.cshtml")]
namespace KhuddarVS.Pages.ShadhiMubarakRequest
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
#line 1 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\_ViewImports.cshtml"
using KhuddarVS;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7d8f3bdbee1ee3b3929f97f128409d71f1c427", @"/Areas/Admin/Views/ShadhiMubarakRequest/Khdvalima.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b1d5780737e53b22de2dc10686c9e6cf491f371", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ShadhiMubarakRequest_Khdvalima : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KhuddarVsModals.Models.Shadi_Mubarak.KhuddarValima>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
  
    ViewBag.title = "Valima";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
Write(await Html.PartialAsync("_titleBreadView", new string[] { "Valima Details", "Home", "Valima Details" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <img src=\"https://png.pngtree.com/png-vector/20190710/ourmid/pngtree-user-vector-avatar-png-image_1541962.jpg\" class=\"userImg-200\" />\r\n            <h2>");
#nullable restore
#line 11 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
           Write(Model.KhuddarUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h2>");
#nullable restore
#line 12 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
           Write(Model.KhuddarUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"container mt-3\">\r\n            <div class=\"table-responsive\">\r\n                <table class=\"table table-striped\">\r\n                    <tbody>\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 19 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
                           Write(Html.DisplayNameFor(x => Model.BrideName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 20 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
                           Write(Model.BrideName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 23 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
                           Write(Html.DisplayNameFor(x => Model.GroomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 24 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
                           Write(Model.GroomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                       \r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 28 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
                           Write(Html.DisplayNameFor(x => Model.valimaDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 29 "F:\Office Projects\KhuddarVS\KhuddarVS\Areas\Admin\Views\ShadhiMubarakRequest\Khdvalima.cshtml"
                           Write(Model.valimaDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n\r\n                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KhuddarVsModals.Models.Shadi_Mubarak.KhuddarValima> Html { get; private set; }
    }
}
#pragma warning restore 1591