#pragma checksum "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6f17020cc45450a7fb7160590e5346e1857cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parts_Create), @"mvc.1.0.view", @"/Views/Parts/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parts/Create.cshtml", typeof(AspNetCore.Views_Parts_Create))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web;

#line default
#line hidden
#line 2 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models;

#line default
#line hidden
#line 3 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Data.Models;

#line default
#line hidden
#line 4 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Cars;

#line default
#line hidden
#line 5 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Sales;

#line default
#line hidden
#line 6 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models;

#line default
#line hidden
#line 7 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Parts;

#line default
#line hidden
#line 8 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Sales;

#line default
#line hidden
#line 9 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Customers;

#line default
#line hidden
#line 10 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Suppliers;

#line default
#line hidden
#line 11 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Cars;

#line default
#line hidden
#line 12 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Parts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6f17020cc45450a7fb7160590e5346e1857cbb", @"/Views/Parts/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4b272ffea321a5311abc20a70bf92d4ec9be04", @"/Views/_ViewImports.cshtml")]
    public class Views_Parts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartFormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\Create.cshtml"
  
    ViewData["Title"] = "Add Part";

#line default
#line hidden
            BeginContext(68, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(75, 17, false);
#line 7 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(92, 64, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n        ");
            EndContext();
            BeginContext(157, 32, false);
#line 11 "E:\Todor\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\Create.cshtml"
   Write(Html.Partial("_PartForm", Model));

#line default
#line hidden
            EndContext();
            BeginContext(189, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartFormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
