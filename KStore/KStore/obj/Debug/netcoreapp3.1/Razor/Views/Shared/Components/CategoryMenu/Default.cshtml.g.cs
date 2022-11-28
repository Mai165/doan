#pragma checksum "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daddabca2541d4a2ada61b527a5e972328940087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daddabca2541d4a2ada61b527a5e972328940087", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012fe05fba6c858948ce5db3ee66febe32b692f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<div class=\"navleft-container\">\n    <div class=\"mega-menu-title\">\n        <h3><span>");
#nullable restore
#line 6 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
             Write(Localizer["AllCategories"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\n    </div>\n\n    <!-- Shop by category -->\n    <div class=\"mega-menu-category\">\n        <ul class=\"nav\">\n");
#nullable restore
#line 12 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
             foreach (var item in Model.Where(x => x.ParentId == null))
            {
                if (Model.Any(x => x.ParentId == item.Id))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 514, "\"", 554, 5);
            WriteAttributeValue("", 521, "/", 521, 1, true);
#nullable restore
#line 17 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 522, item.SeoAlias, 522, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 536, "-c.", 536, 3, true);
#nullable restore
#line 17 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 539, item.Id, 539, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 549, ".html", 549, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                        <div class=\"wrap-popup column1\">\n                            <div class=\"popup\">\n                                <ul class=\"nav\">\n");
#nullable restore
#line 21 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                     foreach (var subItem in Model.Where(x => x.ParentId == item.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 911, "\"", 957, 5);
            WriteAttributeValue("", 918, "/", 918, 1, true);
#nullable restore
#line 23 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 919, subItem.SeoAlias, 919, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 936, "-c.", 936, 3, true);
#nullable restore
#line 23 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 939, subItem.Id, 939, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 952, ".html", 952, 5, true);
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 23 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                               Write(subItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\n");
#nullable restore
#line 24 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\n                            </div>\n                        </div>\n                    </li>\n");
#nullable restore
#line 29 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nosub\"><a");
            BeginWriteAttribute("href", " href=\"", 1261, "\"", 1301, 5);
            WriteAttributeValue("", 1268, "/", 1268, 1, true);
#nullable restore
#line 33 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 1269, item.SeoAlias, 1269, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1283, "-c.", 1283, 3, true);
#nullable restore
#line 33 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 1286, item.Id, 1286, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1296, ".html", 1296, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 34 "D:\KStore\KStore\KStore\Views\Shared\Components\CategoryMenu\Default.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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