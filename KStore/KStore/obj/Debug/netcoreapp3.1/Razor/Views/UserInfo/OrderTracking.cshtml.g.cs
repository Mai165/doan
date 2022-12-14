#pragma checksum "D:\maineu\doan\KStore\KStore\Views\UserInfo\OrderTracking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e5a8c825a1bacbc73e2c9d0b6cb0083a8851254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInfo_OrderTracking), @"mvc.1.0.view", @"/Views/UserInfo/OrderTracking.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5a8c825a1bacbc73e2c9d0b6cb0083a8851254", @"/Views/UserInfo/OrderTracking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49e28129b4513cdcc38777b325c30f50c06f13b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInfo_OrderTracking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KStore.Application.ViewModels.Product.BillViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>Orders List</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<div class=""main container"">
    <div class=""row"">
        <div class=""col-main col-sm-9 col-xs-12"">
            <div class=""my-account"">
                <div class=""page-title"">
                    <h2>Orders List</h2>
                </div>
                <div class=""orders-list table-responsive"">
                    <!--orders list table-->
                    <table class=""table table-bordered cart_summary table-striped"">
                        <thead>
                            <tr>
                                <!--titles for td-->
                                <th>Order Number</th>
                ");
            WriteLiteral("                <th>Order Date</th>\r\n                                <th>Order Status</th>\r\n                                <th>Total</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 35 "D:\maineu\doan\KStore\KStore\Views\UserInfo\OrderTracking.cshtml"
                             foreach (var item in Model)
                            {
                                var total = 0;
                                foreach (var row in item.BillDetails)
                                {
                                    total += (int)row.Price * row.Quantity;
                                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <!--order number-->\r\n                                    <td data-title=\"Order Number\"><a href=\"order_details.html\" class=\"order-number\">");
#nullable restore
#line 45 "D:\maineu\doan\KStore\KStore\Views\UserInfo\OrderTracking.cshtml"
                                                                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                    <!--order date-->\r\n                                    <td data-title=\"Order Date\">");
#nullable restore
#line 47 "D:\maineu\doan\KStore\KStore\Views\UserInfo\OrderTracking.cshtml"
                                                           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <!--order status-->\r\n                                    <td data-title=\"Order Status\">");
#nullable restore
#line 49 "D:\maineu\doan\KStore\KStore\Views\UserInfo\OrderTracking.cshtml"
                                                             Write(item.BillStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <!--quanity-->\r\n                                    <td data-title=\"Total\"><span class=\"order-total\">");
#nullable restore
#line 51 "D:\maineu\doan\KStore\KStore\Views\UserInfo\OrderTracking.cshtml"
                                                                                Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "D:\maineu\doan\KStore\KStore\Views\UserInfo\OrderTracking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <aside class=""right sidebar col-sm-3 col-xs-12"">
            <div class=""sidebar-account block"">
                <div class=""sidebar-bar-title"">
                    <h3>My Account</h3>
                </div>
                <div class=""block-content"">
                    <ul>
                        <li><a href=""/Manage/ChangePassword"">Account</a></li>
                        <li><a href=""/UserInfo/Wish"">Wishlist</a></li>
                        <li><a href=""/UserInfo/OrderTracking"">Order Tracking</a></li>
                    </ul>
                </div>
            </div>
            <div class=""compare block"">
                <div class=""sidebar-bar-title"">
                    <h3>Compare Products (2)</h3>
                </div>
                <div class=""block-content"">
                    <ol id=""compare-items"">
                        <li class=""item""> <a");
            WriteLiteral(@" href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name"">Vestibulum porta tristique porttitor.</a> </li>
                        <li class=""item""> <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name"">Lorem ipsum dolor sit amet</a> </li>
                    </ol>
                    <div class=""ajax-checkout"">
                        <button type=""submit"" title=""Submit"" class=""button button-compare""> <span> Compare</span></button>
                        <button type=""submit"" title=""Submit"" class=""button button-clear""> <span> Clear All</span></button>
                    </div>
                </div>
            </div>
        </aside>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KStore.Application.ViewModels.Product.BillViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
