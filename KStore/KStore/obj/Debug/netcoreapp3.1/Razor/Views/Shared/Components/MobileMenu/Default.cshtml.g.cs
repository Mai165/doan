#pragma checksum "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1602fdf6dd62df469ef9f9f5b04f561895f7179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MobileMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MobileMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1602fdf6dd62df469ef9f9f5b04f561895f7179", @"/Views/Shared/Components/MobileMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012fe05fba6c858948ce5db3ee66febe32b692f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MobileMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"mobile-menu\">\n    <ul>\n        <li>\n            <a href=\"/\" class=\"home1\">Home</a>\n        </li>\n        <li>\n            <a href=\"/products.html\">Products</a>\n            <ul>\n");
#nullable restore
#line 10 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                 foreach (var item in Model.Where(x => x.ParentId == null))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 369, "\"", 409, 5);
            WriteAttributeValue("", 376, "/", 376, 1, true);
#nullable restore
#line 13 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 377, item.SeoAlias, 377, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 391, "-c.", 391, 3, true);
#nullable restore
#line 13 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 394, item.Id, 394, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 404, ".html", 404, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n");
#nullable restore
#line 14 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                         if (Model.Any(x => x.ParentId == item.Id))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul>\n");
#nullable restore
#line 17 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                                 foreach (var subItem in Model.Where(x => x.ParentId == item.Id))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 728, "\"", 774, 5);
            WriteAttributeValue("", 735, "/", 735, 1, true);
#nullable restore
#line 19 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 736, subItem.SeoAlias, 736, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 753, "-c.", 753, 3, true);
#nullable restore
#line 19 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
WriteAttributeValue("", 756, subItem.Id, 756, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 769, ".html", 769, 5, true);
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 19 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                                                                                           Write(subItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\n");
#nullable restore
#line 20 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n");
#nullable restore
#line 22 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </li>\n");
#nullable restore
#line 25 "D:\KStore\KStore\KStore\Views\Shared\Components\MobileMenu\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </li>\n       \n    </ul>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
