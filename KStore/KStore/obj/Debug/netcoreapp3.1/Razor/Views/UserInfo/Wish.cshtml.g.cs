#pragma checksum "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1caf60ed4cbcfa326d8756f826c6d7e45dcf65c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInfo_Wish), @"mvc.1.0.view", @"/Views/UserInfo/Wish.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1caf60ed4cbcfa326d8756f826c6d7e45dcf65c6", @"/Views/UserInfo/Wish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49e28129b4513cdcc38777b325c30f50c06f13b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInfo_Wish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShoppingCartViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/controllers/userInfo/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1caf60ed4cbcfa326d8756f826c6d7e45dcf65c64569", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        var productObj = new userInfoController();\r\n        productObj.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"main container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-main col-xs-12\">\r\n            <div class=\"my-account\">\r\n                <div class=\"page-title\">\r\n                    <h2>My Wishlist</h2>\r\n                </div>\r\n");
#nullable restore
#line 18 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                 if (Model?.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""wishlist-item table-responsive"">
                        <table class=""col-md-12"">
                            <thead>
                                <tr>
                                    <th class=""th-delate"">Remove</th>
                                    <th class=""th-product"">Images</th>
                                    <th class=""th-details"">Product Name</th>
                                    <th class=""th-price"">Unit Price</th>
                                    <th class=""th-total th-add-to-cart"">Add to Cart </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 32 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"th-delate\"><a href=\"#\">X</a></td>\r\n                                        <td class=\"th-product\"><a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 1538, "\"", 1563, 1);
#nullable restore
#line 36 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
WriteAttributeValue("", 1544, item.Product.Image, 1544, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"cart\"></a></td>\r\n                                        <td class=\"th-details\"><h2><a href=\"#\">");
#nullable restore
#line 37 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                                                                          Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2></td>\r\n                                        <td class=\"th-price\">");
#nullable restore
#line 38 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                                                        Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <th class=\"td-add-to-cart\"><a href=\"#\" data-id=\"");
#nullable restore
#line 39 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                                                                                   Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"add-to-cart\"> Add to Cart</a></th>\r\n                                    </tr>\r\n");
#nullable restore
#line 41 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <a href=\"#\" class=\"all-cart\">Add all to cart</a>\r\n                    </div>\r\n");
#nullable restore
#line 46 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 style=\"text-align: center;\">\r\n                        No Data\r\n                    </h4>\r\n");
#nullable restore
#line 52 "D:\maineu\doan\KStore\KStore\Views\UserInfo\Wish.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
