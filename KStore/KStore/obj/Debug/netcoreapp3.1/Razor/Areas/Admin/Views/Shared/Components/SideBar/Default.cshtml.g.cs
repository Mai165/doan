#pragma checksum "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f26065348648696f2096617cc110d3707cda41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
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
#line 1 "D:\KStore\KStore\KStore\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KStore\KStore\KStore\Areas\Admin\Views\_ViewImports.cshtml"
using KStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KStore\KStore\KStore\Areas\Admin\Views\_ViewImports.cshtml"
using KStore.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KStore\KStore\KStore\Areas\Admin\Views\_ViewImports.cshtml"
using KStore.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KStore\KStore\KStore\Areas\Admin\Views\_ViewImports.cshtml"
using KStore.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KStore\KStore\KStore\Areas\Admin\Views\_ViewImports.cshtml"
using KStore.Application.ViewModels.System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f26065348648696f2096617cc110d3707cda41", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"085cdf94c20ff1953cd0270fcc02df8516db83b5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FunctionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"sidebar-menu\" class=\"main_menu_side hidden-print main_menu\">\n    <div class=\"menu_section\">\n        <h3>Functions</h3>\n        <ul class=\"nav side-menu\">\n");
#nullable restore
#line 6 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
             foreach (var item in Model.Where(x=>string.IsNullOrEmpty(x.ParentId)))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\n                    <a><i");
            BeginWriteAttribute("class", " class=\"", 338, "\"", 362, 2);
            WriteAttributeValue("", 346, "fa", 346, 2, true);
#nullable restore
#line 9 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue(" ", 348, item.IconCss, 349, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 9 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"fa fa-chevron-down\"></span></a>\n");
#nullable restore
#line 10 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                     if (Model.Any(x => x.ParentId == item.Id))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"nav child_menu\">\n");
#nullable restore
#line 13 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                             foreach (var jitem in Model.Where(x => x.ParentId == item.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 723, "\"", 740, 1);
#nullable restore
#line 15 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 730, jitem.URL, 730, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                    Write(jitem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 16 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n");
#nullable restore
#line 19 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \n                </li>\n");
#nullable restore
#line 22 "D:\KStore\KStore\KStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \n        </ul>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FunctionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591