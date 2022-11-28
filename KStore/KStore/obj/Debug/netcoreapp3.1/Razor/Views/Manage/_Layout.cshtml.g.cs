#pragma checksum "D:\KStore\KStore\KStore\Views\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d861392cf97c8681e9fca78dcddef1bbdb9e77b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
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
#nullable restore
#line 1 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Application.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\KStore\KStore\KStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\KStore\KStore\KStore\Views\Manage\_ViewImports.cshtml"
using KStore.Views.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d861392cf97c8681e9fca78dcddef1bbdb9e77b2", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012fe05fba6c858948ce5db3ee66febe32b692f5", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad208fe5f764febe85c6359c52cfac5dd082637", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\KStore\KStore\KStore\Views\Manage\_Layout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>Manage your account</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3"">
                ");
#nullable restore
#line 23 "D:\KStore\KStore\KStore\Views\Manage\_Layout.cshtml"
           Write(await Html.PartialAsync("_ManageNav"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-9\">\n                ");
#nullable restore
#line 26 "D:\KStore\KStore\KStore\Views\Manage\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 33 "D:\KStore\KStore\KStore\Views\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral("        \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
