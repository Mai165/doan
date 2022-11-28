#pragma checksum "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b703fc5c57ef997669b27cf5f662d27e2c4b0fc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderWish_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderWish/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b703fc5c57ef997669b27cf5f662d27e2c4b0fc3", @"/Views/Shared/Components/HeaderWish/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012fe05fba6c858948ce5db3ee66febe32b692f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderWish_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShoppingCartViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .remove-wish {
        display: block;
        width: 15px;
        height: 13px;
        position: absolute;
        right: 1px;
        top: 0;
        color: #666;
    }
</style>
<div class=""mini-cart"" id=""headerWish"">
    <div data-toggle=""dropdown"" data-hover=""dropdown"" class=""basket dropdown-toggle"">
        <a href=""#"">
            <div class=""cart-icon""><i class=""icon-heart icons""></i>
");
#nullable restore
#line 18 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"cart-total\">");
#nullable restore
#line 20 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
                                    Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 21 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <div class=\"shoppingcart-inner hidden-xs\"><span class=\"cart-title\">Wishlist</span> </div>\n        </a>\n    </div>\n    <div>\n        <div class=\"top-cart-content\">\n");
#nullable restore
#line 28 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"block-subtitle hidden\">Recently added items</div>\n                <ul id=\"cart-sidebar\" class=\"mini-products-list\">\n");
#nullable restore
#line 32 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
                     foreach (var item in Model)
                {
                    var url = "/" + item.Product.SeoAlias + "-p." + item.Product.Id + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"item last odd\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1207, "\"", 1218, 1);
#nullable restore
#line 37 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
WriteAttributeValue("", 1214, url, 1214, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1219, "\"", 1245, 1);
#nullable restore
#line 37 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
WriteAttributeValue("", 1227, item.Product.Name, 1227, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1306, "\"", 1331, 1);
#nullable restore
#line 38 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
WriteAttributeValue("", 1312, item.Product.Image, 1312, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1332, "\"", 1356, 1);
#nullable restore
#line 38 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
WriteAttributeValue("", 1338, item.Product.Name, 1338, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"65\">\n                            </a>\n                            <div class=\"product-details\">\n                                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 1504, "\"", 1530, 1);
#nullable restore
#line 41 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
WriteAttributeValue("", 1512, item.Product.Name, 1512, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 41 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
                                                                           Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"remove-wish\"><i style=\"font-size:16px\" class=\"pe-7s-trash\"></i></a>\n                                <p class=\"product-name\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1729, "\"", 1740, 1);
#nullable restore
#line 43 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
WriteAttributeValue("", 1736, url, 1736, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
                                              Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                </p>\n");
            WriteLiteral("                            </div>\n                        </li>\n");
#nullable restore
#line 48 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n");
#nullable restore
#line 50 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"
                                                                                                                                             
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>You have no product</p>\n");
#nullable restore
#line 55 "D:\KStore\KStore\KStore\Views\Shared\Components\HeaderWish\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShoppingCartViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591