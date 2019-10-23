#pragma checksum "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78284be9ba9944f69f152ac159b3f8431a406b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parts_All), @"mvc.1.0.view", @"/Views/Parts/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parts/All.cshtml", typeof(AspNetCore.Views_Parts_All))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78284be9ba9944f69f152ac159b3f8431a406b61", @"/Views/Parts/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4b272ffea321a5311abc20a70bf92d4ec9be04", @"/Views/_ViewImports.cshtml")]
    public class Views_Parts_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartPageListingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
  
    ViewData["Title"] = "All Parts";

#line default
#line hidden
            BeginContext(76, 20, true);
            WriteLiteral("\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(97, 17, false);
#line 8 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 85, true);
            WriteLiteral("\r\n        <a class=\"btn btn-primary\" href=\"/parts/create\">Add Part</a>\r\n    </h1>\r\n\r\n");
            EndContext();
#line 12 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
  
    var previousDisabled = Model.CurrentPage == 1 ? "dislabled" : String.Empty;
    var nextDisabled = Model.CurrentPage == Model.TotalPages ? "dislabled" : String.Empty;

#line default
#line hidden
            BeginContext(379, 32, true);
            WriteLiteral("<ul class=\"pagination\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 411, "\"", 446, 2);
            WriteAttributeValue("", 419, "page-item", 419, 9, true);
#line 17 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue(" ", 428, previousDisabled, 429, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 478, "\"", 520, 2);
            WriteAttributeValue("", 485, "/parts/all?page=", 485, 16, true);
#line 18 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue("", 501, Model.PreviousPage, 501, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(521, 154, true);
            WriteLiteral(" aria-label=\"Previous\">\r\n            <span aria-hidden=\"true\">&laquo;</span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n    </li>\r\n");
            EndContext();
#line 23 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
     for (int i = 1; i <= Model.TotalPages; i++)
    {

#line default
#line hidden
            BeginContext(732, 50, true);
            WriteLiteral("        <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 782, "\"", 807, 2);
            WriteAttributeValue("", 789, "/parts/all?page=", 789, 16, true);
#line 25 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue("", 805, i, 805, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(808, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(810, 1, false);
#line 25 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
                                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(811, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 26 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
    }

#line default
#line hidden
            BeginContext(829, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 836, "\"", 867, 2);
            WriteAttributeValue("", 844, "page-item", 844, 9, true);
#line 27 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue(" ", 853, nextDisabled, 854, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(868, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 899, "\"", 937, 2);
            WriteAttributeValue("", 906, "/parts/all?page=", 906, 16, true);
#line 28 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue("", 922, Model.NextPage, 922, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(938, 522, true);
            WriteLiteral(@" aria-label=""Next"">
            <span aria-hidden=""true"">&raquo;</span>
            <span class=""sr-only"">Next</span>
        </a>
    </li>
</ul>
<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Price
            </th>
            <th>
                Quantity
            </th>
            <th>
                Supplier Name
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 52 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
         foreach (var part in Model.Parts)
        {

#line default
#line hidden
            BeginContext(1515, 60, true);
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1576, 9, false);
#line 56 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
               Write(part.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1585, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1653, 10, false);
#line 59 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
               Write(part.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1731, 13, false);
#line 62 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
               Write(part.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1812, 17, false);
#line 65 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
               Write(part.SupplierName);

#line default
#line hidden
            EndContext();
            BeginContext(1829, 44, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 68 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
        }

#line default
#line hidden
            BeginContext(1884, 62, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n<ul class=\"pagination\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1946, "\"", 1981, 2);
            WriteAttributeValue("", 1954, "page-item", 1954, 9, true);
#line 75 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue(" ", 1963, previousDisabled, 1964, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1982, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2013, "\"", 2055, 2);
            WriteAttributeValue("", 2020, "/parts/all?page=", 2020, 16, true);
#line 76 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue("", 2036, Model.PreviousPage, 2036, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2056, 154, true);
            WriteLiteral(" aria-label=\"Previous\">\r\n            <span aria-hidden=\"true\">&laquo;</span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n    </li>\r\n");
            EndContext();
#line 81 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
     for (int i = 1; i <= Model.TotalPages; i++)
    {

#line default
#line hidden
            BeginContext(2267, 50, true);
            WriteLiteral("        <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2317, "\"", 2342, 2);
            WriteAttributeValue("", 2324, "/parts/all?page=", 2324, 16, true);
#line 83 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue("", 2340, i, 2340, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2343, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2345, 1, false);
#line 83 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
                                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2346, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 84 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
    }

#line default
#line hidden
            BeginContext(2364, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2371, "\"", 2402, 2);
            WriteAttributeValue("", 2379, "page-item", 2379, 9, true);
#line 85 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue(" ", 2388, nextDisabled, 2389, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2403, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2434, "\"", 2472, 2);
            WriteAttributeValue("", 2441, "/parts/all?page=", 2441, 16, true);
#line 86 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Parts\All.cshtml"
WriteAttributeValue("", 2457, Model.NextPage, 2457, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2473, 151, true);
            WriteLiteral(" aria-label=\"Next\">\r\n            <span aria-hidden=\"true\">&raquo;</span>\r\n            <span class=\"sr-only\">Next</span>\r\n        </a>\r\n    </li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartPageListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
