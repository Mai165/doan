#pragma checksum "D:\maineu\doan\KStore\KStore\Views\Account\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b923fc6267659e431fe9e7f20bcacb736a50ac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Info), @"mvc.1.0.view", @"/Views/Account/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b923fc6267659e431fe9e7f20bcacb736a50ac8", @"/Views/Account/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49e28129b4513cdcc38777b325c30f50c06f13b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>");
#nullable restore
#line 12 "D:\maineu\doan\KStore\KStore\Views\Account\Info.cshtml"
                           Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></li>
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
                    <h2>My Wishlist</h2>
                </div>
                <div class=""wishlist-item table-responsive"">
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
                            <tr>
 ");
            WriteLiteral(@"                               <td class=""th-delate""><a href=""#"">X</a></td>
                                <td class=""th-product""><a href=""#""><img src=""images/products/product-1.jpg"" alt=""cart""></a></td>
                                <td class=""th-details""><h2><a href=""#"">Lorem Ipsum is simply</a></h2></td>
                                <td class=""th-price"">$125.00</td>
                                <th class=""td-add-to-cart""><a href=""#""> Add to Cart</a></th>
                            </tr>
                            <tr>
                                <td class=""th-delate""><a href=""#"">X</a></td>
                                <td class=""th-product""><a href=""#""><img src=""images/products/product-1.jpg"" alt=""cart""></a></td>
                                <td class=""th-details""><h2><a href=""#"">Leo quis molestie</a></h2></td>
                                <td class=""th-price"">$99.00</td>
                                <th class=""td-add-to-cart""><a href=""#""> Add to Cart</a></th>
       ");
            WriteLiteral(@"                     </tr>
                            <tr>
                                <td class=""th-delate""><a href=""#"">X</a></td>
                                <td class=""th-product""><a href=""#""><img src=""images/products/product-1.jpg"" alt=""cart""></a></td>
                                <td class=""th-details""><h2><a href=""#"">Lorem Ipsum is simply</a></h2></td>
                                <td class=""th-price"">$179.89</td>
                                <th class=""td-add-to-cart""><a href=""#""> Add to Cart</a></th>
                            </tr>
                            <tr>
                                <td class=""th-delate""><a href=""#"">X</a></td>
                                <td class=""th-product""><a href=""#""><img src=""images/products/product-1.jpg"" alt=""cart""></a></td>
                                <td class=""th-details""><h2><a href=""#"">Leo quis molestie</a></h2></td>
                                <td class=""th-price"">$199.00</td>
                                <th c");
            WriteLiteral(@"lass=""td-add-to-cart""><a href=""#""> Add to Cart</a></th>
                            </tr>
                        </tbody>
                    </table>
                    <a href=""/checkout.html"" class=""all-cart"">Add all to cart</a>
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
                        <li><a>Account Dashboard</a></li>
                        <li><a href=""#"">Account Information</a></li>
                        <li><a href=""#"">Address Book</a></li>
                        <li><a href=""#"">My Orders</a></li>
                        <li><a href=""#"">Billing Agreements</a></li>
                        <li><a href=""#"">Recurring Profiles</a></li>
                        <li><a href=""#"">My ");
            WriteLiteral(@"Product Reviews</a></li>
                        <li><a href=""#"">My Tags</a></li>
                        <li class=""current""><a href=""#"">My Wishlist</a></li>
                        <li><a href=""#"">My Downloadable</a></li>
                        <li class=""last""><a href=""#"">Newsletter Subscriptions</a></li>
                    </ul>
                </div>
            </div>
            <div class=""compare block"">
                <div class=""sidebar-bar-title"">
                    <h3>Compare Products (2)</h3>
                </div>
                <div class=""block-content"">
                    <ol id=""compare-items"">
                        <li class=""item""> <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name"">Vestibulum porta tristique porttitor.</a> </li>
                        <li class=""item""> <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name"">Lorem i");
            WriteLiteral(@"psum dolor sit amet</a> </li>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
