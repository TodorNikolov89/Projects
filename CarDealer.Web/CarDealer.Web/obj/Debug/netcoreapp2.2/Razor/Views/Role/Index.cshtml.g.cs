#pragma checksum "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d948e28fb8e6d7e1a4616af1e2c6d75f1da43d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Index.cshtml", typeof(AspNetCore.Views_Role_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d948e28fb8e6d7e1a4616af1e2c6d75f1da43d", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4b272ffea321a5311abc20a70bf92d4ec9be04", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 26, true);
            WriteLiteral("\r\n<h1>List of Roles</h1>\r\n");
            EndContext();
            BeginContext(131, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53d948e28fb8e6d7e1a4616af1e2c6d75f1da43d5497", async() => {
                BeginContext(179, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(189, 223, true);
            WriteLiteral("\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-center\">Role Id</th>\r\n            <th class=\"text-center\">Role Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Role\Index.cshtml"
         foreach (var role in Model)
        {

#line default
#line hidden
            BeginContext(461, 38, true);
            WriteLiteral("            <tr>\r\n                <th>");
            EndContext();
            BeginContext(500, 7, false);
#line 19 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Role\Index.cshtml"
               Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(507, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(535, 9, false);
#line 20 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Role\Index.cshtml"
               Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(544, 26, true);
            WriteLiteral("</th>\r\n            </tr>\r\n");
            EndContext();
#line 22 "D:\C#\Projects\CarDealer.Web\CarDealer.Web\Views\Role\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(581, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
