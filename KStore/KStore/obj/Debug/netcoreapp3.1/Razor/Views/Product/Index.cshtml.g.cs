#pragma checksum "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "650ce9b8ec5444f8fb857af35d10311100242de6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using KStore.Application.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\maineu\doan\KStore\KStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"650ce9b8ec5444f8fb857af35d10311100242de6", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49e28129b4513cdcc38777b325c30f50c06f13b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KStore.Application.ViewModels.Product.ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "All product  categories";
    ViewData["MetaDescription"] = "All our products";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumbs -->

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>Product categories</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<div class=""main-container col1-layout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-main col-sm-12 col-xs-12"">
                <div class=""shop-inner"">
                    <div class=""page-title"">
                        <h2>Product categories</h2>
                    </div>

                    <div class=""product-grid-area"">
                        <ul class=""products-grid"">
");
#nullable restore
#line 33 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
                             foreach (var item in Model)
                            {
                                var url = "/" + item.SeoAlias + "-c." + item.Id + ".html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""item col-lg-3 col-md-4 col-sm-6 col-xs-6 "">
                                    <div class=""product-item"">
                                        <div class=""item-inner"">
                                            <div class=""product-thumbnail"">
                                                <div class=""icon-sale-label sale-left"">Sale</div>
                                                <div class=""icon-new-label new-right"">New</div>
                                                <div class=""pr-img-area"">
                                                    <a");
            BeginWriteAttribute("title", " title=\"", 1893, "\"", 1911, 1);
#nullable restore
#line 43 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 1901, item.Name, 1901, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1912, "\"", 1923, 1);
#nullable restore
#line 43 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 1919, url, 1919, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\"");
            BeginWriteAttribute("src", " src=\"", 2014, "\"", 2031, 1);
#nullable restore
#line 44 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2020, item.Image, 2020, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2032, "\"", 2048, 1);
#nullable restore
#line 44 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2038, item.Name, 2038, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=\"", 2073, "\"", 2090, 1);
#nullable restore
#line 44 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2079, item.Image, 2079, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2091, "\"", 2107, 1);
#nullable restore
#line 44 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2097, item.Name, 2097, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></figure>
                                                    </a>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </li>
");
#nullable restore
#line 52 "D:\maineu\doan\KStore\KStore\Views\Product\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Main Container End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KStore.Application.ViewModels.Product.ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
