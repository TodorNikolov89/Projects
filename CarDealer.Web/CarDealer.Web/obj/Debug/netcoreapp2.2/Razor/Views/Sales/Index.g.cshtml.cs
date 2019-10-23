#pragma checksum "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0e9c10219caa20c60d4ed8869351bfdb7397cac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Index), @"mvc.1.0.view", @"/Views/Sales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sales/Index.cshtml", typeof(AspNetCore.Views_Sales_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0e9c10219caa20c60d4ed8869351bfdb7397cac", @"/Views/Sales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4b272ffea321a5311abc20a70bf92d4ec9be04", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesViewModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 452, true);
            WriteLiteral(@"
<h1>All Sales</h1>


<table class=""table"">
    <thead>
    <th>
        Make
    </th>
    <th>
        Model
    </th>
    <th>
        Travelled Distance
    </th>
    <th>
        Name
    </th>
    <th>
        BirthDay
    </th>
    <th>
        Is Young Driver
    </th>
    <th>
        Price
    </th>
    <th>
        Price With Dscount
    </th>
    <th>
        Discount Percent
    </th>
    </thead>
    ");
            EndContext();
            BeginContext(531, 935, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0e9c10219caa20c60d4ed8869351bfdb7397cac5357", async() => {
                BeginContext(537, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
         foreach (var sale in Model)
        {

#line default
#line hidden
                BeginContext(588, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(649, 13, false);
#line 45 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
               Write(sale.Car.Make);

#line default
#line hidden
                EndContext();
                BeginContext(662, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(730, 14, false);
#line 48 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
               Write(sale.Car.Model);

#line default
#line hidden
                EndContext();
                BeginContext(744, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(813, 33, false);
#line 51 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
                Write(sale.Car.TravelledDistance / 1000);

#line default
#line hidden
                EndContext();
                BeginContext(847, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(915, 18, false);
#line 54 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
               Write(sale.Customer.Name);

#line default
#line hidden
                EndContext();
                BeginContext(933, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1001, 22, false);
#line 57 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
               Write(sale.Customer.BirthDay);

#line default
#line hidden
                EndContext();
                BeginContext(1023, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1092, 42, false);
#line 60 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
                Write(sale.Customer.IsYoungDriver ? "YES" : "NO");

#line default
#line hidden
                EndContext();
                BeginContext(1135, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1203, 10, false);
#line 63 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
               Write(sale.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1213, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1281, 22, false);
#line 66 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
               Write(sale.PriceWithDiscount);

#line default
#line hidden
                EndContext();
                BeginContext(1303, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1372, 27, false);
#line 69 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
                Write(sale.DiscountPercent + " %");

#line default
#line hidden
                EndContext();
                BeginContext(1400, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 72 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Sales\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1455, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1466, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
