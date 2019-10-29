#pragma checksum "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07e6d382def480c40d9091d9e25c004adf2de8fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_All), @"mvc.1.0.view", @"/Views/Cars/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/All.cshtml", typeof(AspNetCore.Views_Cars_All))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07e6d382def480c40d9091d9e25c004adf2de8fc", @"/Views/Cars/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4b272ffea321a5311abc20a70bf92d4ec9be04", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsPageListingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
  
    ViewData["Title"] = "All Cars";

#line default
#line hidden
            BeginContext(75, 12, true);
            WriteLiteral("\r\n<h1>\r\n    ");
            EndContext();
            BeginContext(88, 17, false);
#line 8 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 78, true);
            WriteLiteral("\r\n    <a href=\"/cars/create/\" class=\"btn btn-primary\">Add Car</a>\r\n</h1>\r\n\r\n\r\n");
            EndContext();
#line 13 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
  
    var previousDisabled = Model.CurrentPage == 1 ? "dislabled" : String.Empty;
    var nextDisabled = Model.CurrentPage == Model.TotalPages ? "dislabled" : String.Empty;

#line default
#line hidden
            BeginContext(363, 32, true);
            WriteLiteral("<ul class=\"pagination\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 395, "\"", 430, 2);
            WriteAttributeValue("", 403, "page-item", 403, 9, true);
#line 18 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue(" ", 412, previousDisabled, 413, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(431, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 462, "\"", 503, 2);
            WriteAttributeValue("", 469, "/cars/all?page=", 469, 15, true);
#line 19 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 484, Model.PreviousPage, 484, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(504, 154, true);
            WriteLiteral(" aria-label=\"Previous\">\r\n            <span aria-hidden=\"true\">&laquo;</span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n    </li>\r\n");
            EndContext();
#line 24 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
     for (int i = 1; i <= Model.TotalPages; i++)
    {

#line default
#line hidden
            BeginContext(715, 50, true);
            WriteLiteral("        <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 765, "\"", 789, 2);
            WriteAttributeValue("", 772, "/cars/all?page=", 772, 15, true);
#line 26 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 787, i, 787, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(790, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(792, 1, false);
#line 26 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(793, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 27 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
    }

#line default
#line hidden
            BeginContext(811, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 818, "\"", 849, 2);
            WriteAttributeValue("", 826, "page-item", 826, 9, true);
#line 28 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue(" ", 835, nextDisabled, 836, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(850, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 881, "\"", 918, 2);
            WriteAttributeValue("", 888, "/cars/all?page=", 888, 15, true);
#line 29 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 903, Model.NextPage, 903, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(919, 466, true);
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
                Make
            </th>
            <th>
                Model
            </th>
            <th>
                Travelled Distance
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 51 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
         foreach (var car in Model.Cars)
        {

#line default
#line hidden
            BeginContext(1438, 60, true);
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1499, 8, false);
#line 55 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
               Write(car.Make);

#line default
#line hidden
            EndContext();
            BeginContext(1507, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1575, 9, false);
#line 58 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
               Write(car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1653, 28, false);
#line 61 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
                Write(car.TravelledDistance / 1000);

#line default
#line hidden
            EndContext();
            BeginContext(1682, 72, true);
            WriteLiteral(" KM\r\n                </th>\r\n                <th>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1754, "\"", 1779, 2);
            WriteAttributeValue("", 1761, "/cars/edit/", 1761, 11, true);
#line 64 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 1772, car.Id, 1772, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1780, 64, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Edit</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1871, 2);
            WriteAttributeValue("", 1851, "/cars/delete/", 1851, 13, true);
#line 65 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 1864, car.Id, 1864, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1872, 69, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Delete Car</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1941, "\"", 1969, 2);
            WriteAttributeValue("", 1948, "/cars/details/", 1948, 14, true);
#line 66 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 1962, car.Id, 1962, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1970, 84, true);
            WriteLiteral(" class=\"btn btn-info btn-sm\">Details</a>\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 69 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
        }

#line default
#line hidden
            BeginContext(2065, 58, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<ul class=\"pagination\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2123, "\"", 2158, 2);
            WriteAttributeValue("", 2131, "page-item", 2131, 9, true);
#line 74 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue(" ", 2140, previousDisabled, 2141, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2159, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2190, "\"", 2231, 2);
            WriteAttributeValue("", 2197, "/cars/all?page=", 2197, 15, true);
#line 75 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 2212, Model.PreviousPage, 2212, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2232, 154, true);
            WriteLiteral(" aria-label=\"Previous\">\r\n            <span aria-hidden=\"true\">&laquo;</span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n    </li>\r\n");
            EndContext();
#line 80 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
     for (int i = 1; i <= Model.TotalPages; i++)
    {

#line default
#line hidden
            BeginContext(2443, 50, true);
            WriteLiteral("        <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2493, "\"", 2517, 2);
            WriteAttributeValue("", 2500, "/cars/all?page=", 2500, 15, true);
#line 82 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 2515, i, 2515, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2518, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2520, 1, false);
#line 82 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2521, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 83 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
    }

#line default
#line hidden
            BeginContext(2539, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2546, "\"", 2577, 2);
            WriteAttributeValue("", 2554, "page-item", 2554, 9, true);
#line 84 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue(" ", 2563, nextDisabled, 2564, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2578, 31, true);
            WriteLiteral(">\r\n        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2609, "\"", 2646, 2);
            WriteAttributeValue("", 2616, "/cars/all?page=", 2616, 15, true);
#line 85 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Cars\All.cshtml"
WriteAttributeValue("", 2631, Model.NextPage, 2631, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2647, 151, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsPageListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
