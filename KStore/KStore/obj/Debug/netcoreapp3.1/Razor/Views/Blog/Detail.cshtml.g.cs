#pragma checksum "D:\maineu\doan\KStore\KStore\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b75efb6baf083ed32510de92b261e772ac05f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b75efb6baf083ed32510de92b261e772ac05f0", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49e28129b4513cdcc38777b325c30f50c06f13b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KStore.Application.ViewModels.Blog.BlogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12 col-sm-9\">\r\n            <div class=\"entry-detail\">\r\n                <div class=\"page-title\">\r\n                </div>\r\n                <div class=\"entry-photo\">\r\n");
            WriteLiteral("                </div>\r\n                <div class=\"entry-meta-data\">\r\n\r\n                    <div class=\"blog-top-desc\">\r\n                        <div class=\"blog-date\"> 28 Jan 2017 </div>\r\n                        <h1><a href=\"blog_single_post.html\">");
#nullable restore
#line 16 "D:\maineu\doan\KStore\KStore\Views\Blog\Detail.cshtml"
                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h1>
                        <div class=""jtv-entry-meta""> <i class=""fa fa-user-o""></i> <strong>Admin</strong> <a href=""#""><i class=""fa fa-commenting-o""></i> <strong>15 Comments</strong></a> <div class=""rating""> <i class=""fa fa-star""></i> <i class=""fa fa-star""></i> <i class=""fa fa-star""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i>&nbsp; <span>(5 votes)</span></div></div>
                    </div>
                </div>
                <div class=""content-text clearfix"">
                    ");
#nullable restore
#line 21 "D:\maineu\doan\KStore\KStore\Views\Blog\Detail.cshtml"
               Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"entry-tags\"> <span>Tags:</span> <a href=\"#\">beauty,</a> <a href=\"#\">medicine,</a> <a href=\"#\">health</a> </div>\r\n            </div>\r\n            <!-- Related Posts -->\r\n");
            WriteLiteral(@"            <!-- ./Related Posts -->
            <!-- Comment -->
            <div class=""single-box"">
                <div class=""best-title text-left"">
                    <h2>Comments</h2>
                </div>
                <div class=""comment-list"">
                    <ul>
                        <li>
                            <div class=""avartar""> <img src=""images/avatar.png"" alt=""Avatar""> </div>
                            <div class=""comment-body"">
                                <div class=""comment-meta""> <span class=""author""><a href=""#"">Admin</a></span> <span class=""date"">2017-04-01</span> </div>
                                <div class=""comment""> Aenean auctor wisi et urna. Aliquam erat volutpat. Duis ac turpis. Integer rutrum ante eu lacus. Vestibulum libero nisl, porta vel, scelerisque eget, malesuada at, neque. </div>
                            </div>
                        </li>
                        <li>
                            <ul>
                            ");
            WriteLiteral(@"    <li>
                                    <div class=""avartar""> <img src=""images/avatar.png"" alt=""Avatar""> </div>
                                    <div class=""comment-body"">
                                        <div class=""comment-meta""> <span class=""author""><a href=""#"">Admin</a></span> <span class=""date"">2017-04-01</span> </div>
                                        <div class=""comment""> Aenean auctor wisi et urna. Aliquam erat volutpat. Duis ac turpis. Integer rutrum ante eu lacus. Vestibulum libero nisl, porta vel, scelerisque eget, malesuada at, neque. </div>
                                    </div>
                                </li>
                                <li>
                                    <div class=""avartar""> <img src=""images/avatar.png"" alt=""Avatar""> </div>
                                    <div class=""comment-body"">
                                        <div class=""comment-meta""> <span class=""author""><a href=""#"">Admin</a></span> <span class=""date"">2017-04-");
            WriteLiteral(@"01</span> </div>
                                        <div class=""comment""> Aenean auctor wisi et urna. Aliquam erat volutpat. Duis ac turpis. Integer rutrum ante eu lacus. Vestibulum libero nisl, porta vel, scelerisque eget, malesuada at, neque. </div>
                                    </div>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class=""avartar""> <img src=""images/avatar.png"" alt=""Avatar""> </div>
                            <div class=""comment-body"">
                                <div class=""comment-meta""> <span class=""author""><a href=""#"">Admin</a></span> <span class=""date"">2017-04-01</span> </div>
                                <div class=""comment""> Aenean auctor wisi et urna. Aliquam erat volutpat. Duis ac turpis. Integer rutrum ante eu lacus. Vestibulum libero nisl, porta vel, scelerisque eget, malesuada at, neque. </div>
                            </div>
      ");
            WriteLiteral(@"                  </li>
                        <li>
                            <div class=""avartar""> <img src=""images/avatar.png"" alt=""Avatar""> </div>
                            <div class=""comment-body"">
                                <div class=""comment-meta""> <span class=""author""><a href=""#"">Admin</a></span> <span class=""date"">2017-04-01</span> </div>
                                <div class=""comment""> Aenean auctor wisi et urna. Aliquam erat volutpat. Duis ac turpis. Integer rutrum ante eu lacus. Vestibulum libero nisl, porta vel, scelerisque eget, malesuada at, neque. </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""single-box comment-box"">
                <div class=""best-title text-left"">
                    <h2>Leave a Comment</h2>
                </div>
                <div class=""coment-form"">
                    <p>Make sure you enter the () required information w");
            WriteLiteral(@"here indicated. HTML code is not allowed.</p>
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <label for=""name"">Name</label>
                            <input id=""name"" type=""text"" class=""form-control"">
                        </div>
                        <div class=""col-sm-6"">
                            <label for=""email"">Email</label>
                            <input id=""email"" type=""text"" class=""form-control"">
                        </div>
                        <div class=""col-sm-12"">
                            <label for=""website"">Website URL</label>
                            <input id=""website"" type=""text"" class=""form-control"">
                        </div>
                        <div class=""col-sm-12"">
                            <label for=""message"">Message</label>
                            <textarea name=""message"" id=""message"" rows=""8"" class=""form-control""></textarea>
                        </div>
     ");
            WriteLiteral(@"               </div>
                    <button class=""button""><span>Post Comment</span></button>
                </div>
            </div>
            <!-- ./Comment -->
        </div>
        <!-- right colunm -->
        <aside class=""sidebar col-xs-12 col-sm-3"">
            <!-- Blog category -->
            <div class=""block blog-module"">
                <div class=""sidebar-bar-title"">
                    <h3>Blog Categories</h3>
                </div>
                <div class=""block_content"">
                    <!-- layered -->
                    <div class=""layered layered-category"">
                        <div class=""layered-content"">
                            <ul class=""tree-menu"">
                                <li><a href=""#""><i class=""fa fa-angle-right""></i>&nbsp; Images</a></li>
                                <li><i class=""fa fa-angle-right""></i>&nbsp; <a href=""#"">Audio</a></li>
                                <li><i class=""fa fa-angle-right""></i>&nbsp; <a href=""#"">");
            WriteLiteral(@"Photos</a></li>
                                <li><i class=""fa fa-angle-right""></i>&nbsp; <a href=""#"">Diet &amp; Fitness</a></li>
                                <li><i class=""fa fa-angle-right""></i>&nbsp; <a href=""#"">Slider</a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- ./layered -->
                </div>
            </div>
            <!-- ./blog category  -->
            <!-- Popular Posts -->
            <div class=""block blog-module"">
                <div class=""sidebar-bar-title"">
                    <h3>Popular Posts</h3>
                </div>
                <div class=""block_content"">
                    <!-- layered -->
                    <div class=""layered"">
                        <div class=""layered-content"">
                            <ul class=""blog-list-sidebar"">
                                <li>
                                    <div class=""post-thumb""> <a href=""#""><img src=""images/");
            WriteLiteral(@"blog-img1.jpg"" alt=""Blog""></a> </div>
                                    <div class=""post-info"">
                                        <h5 class=""entry_title""><a href=""#"">Lorem ipsum dolor</a></h5>
                                        <div class=""post-meta""> <span class=""date""><i class=""pe-7s-date""></i> 2014-08-05</span> <span class=""comment-count""> <i class=""pe-7s-comment""></i> 3 </span> </div>
                                    </div>
                                </li>
                                <li>
                                    <div class=""post-thumb""> <a href=""#""><img src=""images/blog-img1.jpg"" alt=""Blog""></a> </div>
                                    <div class=""post-info"">
                                        <h5 class=""entry_title""><a href=""#"">Lorem ipsum dolor</a></h5>
                                        <div class=""post-meta""> <span class=""date""><i class=""pe-7s-date""></i> 2014-08-05</span> <span class=""comment-count""> <i class=""pe-7s-comment""></i> 3 </span> </d");
            WriteLiteral(@"iv>
                                    </div>
                                </li>
                                <li>
                                    <div class=""post-thumb""> <a href=""#""><img src=""images/blog-img1.jpg"" alt=""Blog""></a> </div>
                                    <div class=""post-info"">
                                        <h5 class=""entry_title""><a href=""#"">Lorem ipsum dolor</a></h5>
                                        <div class=""post-meta""> <span class=""date""><i class=""pe-7s-date""></i> 2014-08-05</span> <span class=""comment-count""> <i class=""pe-7s-comment""></i> 3 </span> </div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <!-- ./layered -->
                </div>
            </div>
            <!-- ./Popular Posts -->
            <!-- Recent Comments -->
            <div class=""block blog-module"">
                ");
            WriteLiteral(@"<div class=""sidebar-bar-title"">
                    <h3>Recent Comments</h3>
                </div>
                <div class=""block_content"">
                    <!-- layered -->
                    <div class=""layered"">
                        <div class=""layered-content"">
                            <ul class=""recent-comment-list"">
                                <li>
                                    <h5><a href=""#"">Lorem ipsum dolor sit amet</a></h5>
                                    <div class=""comment""> ""Consectetuer adipis. Mauris accumsan nulla vel diam. Sed in..."" </div>
                                    <div class=""author"">Posted by <a href=""#"">Admin</a></div>
                                </li>
                                <li>
                                    <h5><a href=""#"">Lorem ipsum dolor sit amet</a></h5>
                                    <div class=""comment""> ""Consectetuer adipis. Mauris accumsan nulla vel diam. Sed in..."" </div>
                            ");
            WriteLiteral(@"        <div class=""author"">Posted by <a href=""#"">Admin</a></div>
                                </li>
                                <li>
                                    <h5><a href=""#"">Lorem ipsum dolor sit amet</a></h5>
                                    <div class=""comment""> ""Consectetuer adipis. Mauris accumsan nulla vel diam. Sed in..."" </div>
                                    <div class=""author"">Posted by <a href=""#"">Admin</a></div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <!-- ./layered -->
                </div>
            </div>
            <!-- ./Recent Comments -->
            <!-- tags -->
            <div class=""popular-tags-area block"">
                <div class=""sidebar-bar-title"">
                    <h3>Popular Tags</h3>
                </div>
                <div class=""tag"">
                    <ul>
                        <li><a href=""#"">Boys</a></li");
            WriteLiteral(@">
                        <li><a href=""#"">Camera</a></li>
                        <li><a href=""#"">good</a></li>
                        <li><a href=""#"">Computers</a></li>
                        <li><a href=""#"">Phone</a></li>
                        <li><a href=""#"">clothes</a></li>
                        <li><a href=""#"">girl</a></li>
                        <li><a href=""#"">shoes</a></li>
                        <li><a href=""#"">women</a></li>
                        <li><a href=""#"">accessoties</a></li>
                        <li><a href=""#"">View All Tags</a></li>
                    </ul>
                </div>
            </div>

            <!-- ./tags -->
            <!-- Banner -->
            <div class=""single-img-add sidebar-add-slider"">
                <div id=""carousel-example-generic"" class=""carousel slide"" data-ride=""carousel"">
                    <!-- Indicators -->
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carousel-example");
            WriteLiteral("-generic\" data-slide-to=\"0\" class=\"active\"></li>\r\n                        <li data-target=\"#carousel-example-generic\" data-slide-to=\"1\"");
            BeginWriteAttribute("class", " class=\"", 22523, "\"", 22531, 0);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n                        <li data-target=\"#carousel-example-generic\" data-slide-to=\"2\"");
            BeginWriteAttribute("class", " class=\"", 22625, "\"", 22633, 0);
            EndWriteAttribute();
            WriteLiteral(@"></li>
                    </ol>

                    <!-- Wrapper for slides -->
                    <div class=""carousel-inner"" role=""listbox"">
                        <div class=""item active"">
                            <img src=""images/add-slide1.jpg"" alt=""slide1"">
                            <div class=""carousel-caption"">
                                <h3><a href=""single_product.html"" title="" Sample Product"">Sale Up to 50% off</a></h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                <a href=""#"" class=""info"">shopping Now</a>
                            </div>
                        </div>
                        <div class=""item"">
                            <img src=""images/add-slide2.jpg"" alt=""slide2"">
                            <div class=""carousel-caption"">
                                <h3><a href=""single_product.html"" title="" Sample Product"">Smartwatch Collection</a></h3>
                         ");
            WriteLiteral(@"       <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                <a href=""#"" class=""info"">All Collection</a>
                            </div>
                        </div>
                        <div class=""item"">
                            <img src=""images/add-slide3.jpg"" alt=""slide3"">
                            <div class=""carousel-caption"">
                                <h3><a href=""single_product.html"" title="" Sample Product"">Summer Sale</a></h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                        </div>
                    </div>

                    <!-- Controls -->
                    <a class=""left carousel-control"" href=""#carousel-example-generic"" role=""button"" data-slide=""prev""> <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span> <span class=""sr-only"">Previous</span> </a> <a class=""right carousel-control"" href=""#caro");
            WriteLiteral(@"usel-example-generic"" role=""button"" data-slide=""next""> <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span> <span class=""sr-only"">Next</span> </a>
                </div>
            </div>
            <!-- ./Banner -->
        </aside>
        <!-- ./right colunm -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KStore.Application.ViewModels.Blog.BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
