#pragma checksum "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b620e0e7af6de87f6b284dad6251b0661c03e37f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suppliers_Suppliers), @"mvc.1.0.view", @"/Views/Suppliers/Suppliers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Suppliers/Suppliers.cshtml", typeof(AspNetCore.Views_Suppliers_Suppliers))]
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
#line 1 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web;

#line default
#line hidden
#line 2 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models;

#line default
#line hidden
#line 3 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Data.Models;

#line default
#line hidden
#line 4 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Cars;

#line default
#line hidden
#line 5 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Sales;

#line default
#line hidden
#line 6 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models;

#line default
#line hidden
#line 7 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Parts;

#line default
#line hidden
#line 8 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Sales;

#line default
#line hidden
#line 9 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Customers;

#line default
#line hidden
#line 10 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Suppliers;

#line default
#line hidden
#line 11 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Cars;

#line default
#line hidden
#line 12 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Parts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b620e0e7af6de87f6b284dad6251b0661c03e37f", @"/Views/Suppliers/Suppliers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4b272ffea321a5311abc20a70bf92d4ec9be04", @"/Views/_ViewImports.cshtml")]
    public class Views_Suppliers_Suppliers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SuppliersModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml"
  
    ViewData["Title"] = $"{Model.Type} Suppliers";

#line default
#line hidden
            BeginContext(86, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(93, 10, false);
#line 8 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml"
Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(103, 316, true);
            WriteLiteral(@" Suppliers</h2>

<table class=""table table-hover table-bordered"">

    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Name
            </th>
            <th>
                Parts
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml"
         foreach (var supplier in Model.Suppliers)
        {

#line default
#line hidden
            BeginContext(482, 48, true);
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 11, false);
#line 30 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml"
           Write(supplier.Id);

#line default
#line hidden
            EndContext();
            BeginContext(542, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(598, 13, false);
#line 33 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml"
           Write(supplier.Name);

#line default
#line hidden
            EndContext();
            BeginContext(611, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(667, 19, false);
#line 36 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml"
           Write(supplier.TotalParts);

#line default
#line hidden
            EndContext();
            BeginContext(686, 36, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n");
            EndContext();
#line 39 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Suppliers\Suppliers.cshtml"
        }

#line default
#line hidden
            BeginContext(733, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SuppliersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591