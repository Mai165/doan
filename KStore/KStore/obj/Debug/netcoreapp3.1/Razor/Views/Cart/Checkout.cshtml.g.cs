#pragma checksum "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0bed6dc9a740097e4acef477244cda2361c20fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0bed6dc9a740097e4acef477244cda2361c20fe", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49e28129b4513cdcc38777b325c30f50c06f13b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("validation-message-element-id", "recaptchaErrorMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "paymentMethod", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/checkout.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaScriptTagHelper __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaTagHelper __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha-script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0bed6dc9a740097e4acef477244cda2361c20fe7272", async() => {
                }
                );
                __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper = CreateTagHelper<global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaScriptTagHelper>();
                __tagHelperExecutionContext.Add(__PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper);
                __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper.ValidationMessageElementId = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 8 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<!-- Breadcrumbs -->

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>Checkout</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<section class=""main-container col2-right-layout"">
    <div class=""main container"">
        <div class=""row"">
            <div class=""col-main col-sm-12 col-xs-12"">
                <div class=""page-title"">
                    <h2>Checkout</h2>
                </div>
                <div class=""page-content checkout-page"">
");
#nullable restore
#line 34 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                     if (ViewData["Success"] != null)
                    {
                        if ((bool)ViewData["Success"] == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-success\">\r\n                                Thank you for your order. We are going to confirm your order soon.\r\n                            </div>\r\n");
#nullable restore
#line 41 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">\r\n                                Have an error in order progress. Please contact to administrator.\r\n                            </div>\r\n");
#nullable restore
#line 48 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"

                        }


                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0bed6dc9a740097e4acef477244cda2361c20fe10976", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <h4 class=""checkout-sep"">1. Checkout Method</h4>
                            <div class=""box-border"">
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <h5>Checkout as a Guest or Register</h5>
                                        <p>Register with us for future convenience:</p>
                                        <br>
                                        <h4>Register and save time!</h4>
                                        <p>Register with us for future convenience:</p>
                                        <p><i class=""fa fa-check-circle text-primary""></i> Fast and easy check out</p>
                                        <p><i class=""fa fa-check-circle text-primary""></i> Easy access to your order history and status</p>
                                        <button class=""button"" onclick=""window.location.href='/register.html'""><i class=""fa fa-angle-doubl");
                WriteLiteral(@"e-right""></i>&nbsp; <span>Continue</span></button>
                                    </div>
                                    <div class=""col-sm-6"">
                                        <h5>Login</h5>
                                        <p>Already registered? Please log in below:</p>
                                        <button class=""button"" onclick=""window.location.href='/login.html'""><i class=""icon-login""></i>&nbsp; <span>Login</span></button>
                                    </div>
                                </div>
                            </div>

                            <h4 class=""checkout-sep"">2. Shipping Information</h4>
                            <div class=""box-border"">
                                <ul>
                                    <li class=""row"">
                                        <div class=""col-sm-6"">
                                            <label class=""required"">Full name</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0bed6dc9a740097e4acef477244cda2361c20fe13605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 85 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <!--/ [col] -->
                                        <div class=""col-sm-6"">
                                            <label class=""required"">Phone</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0bed6dc9a740097e4acef477244cda2361c20fe15676", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 90 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerMobile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </li>
                                    <!--/ .row -->
                                    <!--/ .row -->

                                    <li class=""row"">
                                        <div class=""col-xs-12"">
                                            <label class=""required"">Address</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0bed6dc9a740097e4acef477244cda2361c20fe17900", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 99 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerAddress);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <!--/ [col] -->

                                    </li>
                                    <!--/ .row -->


                                    <li class=""row"">
                                        <div class=""col-sm-12"">
                                            <label class=""required"">Message</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0bed6dc9a740097e4acef477244cda2361c20fe20134", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 110 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerMessage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <!--/ [col] -->

                                    </li>
                                    <!--/ .row -->


                                </ul>
                            </div>
                            <h4 class=""checkout-sep"">3. Payment Information</h4>
                            <div class=""box-border"">
                                <ul>
");
#nullable restore
#line 123 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                     for (int i = 0; i < Model.PaymentMethods.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0bed6dc9a740097e4acef477244cda2361c20fe22763", async() => {
                    WriteLiteral("\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0bed6dc9a740097e4acef477244cda2361c20fe23079", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 127 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PaymentMethod);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                                                                            WriteLiteral(Model.PaymentMethods[i].Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 128 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                           Write(Model.PaymentMethods[i].Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 126 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PaymentMethods[i].Value);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 131 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </ul>
                                <button class=""button""><i class=""fa fa-angle-double-right""></i>&nbsp; <span>Continue</span></button>
                            </div>
                            <h4 class=""checkout-sep last"">4. Order Review</h4>
                            <div class=""box-border"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered cart_summary"">
                                        <thead>
                                            <tr>
                                                <th class=""cart_product"">Product</th>
                                                <th>Description</th>
                                                <th>Unit price</th>
                                                <th>Qty</th>
                                                <th>Total</th>
                                            </tr>
                            ");
                WriteLiteral("            </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 149 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                             foreach (var item in Model.Carts)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td class=\"cart_product\"><a");
                BeginWriteAttribute("href", " href=\"", 7888, "\"", 7944, 5);
                WriteAttributeValue("", 7895, "/", 7895, 1, true);
#nullable restore
#line 152 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 7896, item.Product.SeoAlias, 7896, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7918, "-p.", 7918, 3, true);
#nullable restore
#line 152 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 7921, item.Product.Id, 7921, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7939, ".html", 7939, 5, true);
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 7950, "\"", 7975, 1);
#nullable restore
#line 152 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 7956, item.Product.Image, 7956, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 7976, "\"", 8000, 1);
#nullable restore
#line 152 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 7982, item.Product.Name, 7982, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></a></td>\r\n                                                    <td class=\"cart_description\">\r\n                                                        <p class=\"product-name\"><a");
                BeginWriteAttribute("href", " href=\"", 8178, "\"", 8234, 5);
                WriteAttributeValue("", 8185, "/", 8185, 1, true);
#nullable restore
#line 154 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8186, item.Product.SeoAlias, 8186, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8208, "-p.", 8208, 3, true);
#nullable restore
#line 154 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8211, item.Product.Id, 8211, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8229, ".html", 8229, 5, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 154 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                                                                                                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a></p>\r\n                                                        <small><a>Color : ");
#nullable restore
#line 155 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                                     Write(item.Color.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></small><br>\r\n                                                        <small><a>Size : ");
#nullable restore
#line 156 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                                    Write(item.Size.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></small>\r\n                                                    </td>\r\n                                                    <td class=\"price\"><span>");
#nullable restore
#line 158 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                                       Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></td>\r\n                                                    <td class=\"qty\">");
#nullable restore
#line 159 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td class=\"price\"><span>");
#nullable restore
#line 160 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                                        Write((item.Price * item.Quantity).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 162 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                        </tbody>
                                        <tfoot>
                                            <tr>
                                                <td colspan=""3""><strong>Total</strong></td>
                                                <td colspan=""2""><strong>");
#nullable restore
#line 170 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                                                                   Write(Model.Carts.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong></td>\r\n                                            </tr>\r\n                                        </tfoot>\r\n                                    </table>\r\n                                </div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0bed6dc9a740097e4acef477244cda2361c20fe35074", async() => {
                }
                );
                __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper = CreateTagHelper<global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaTagHelper>();
                __tagHelperExecutionContext.Add(__PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"<span class=""text-danger"" id=""recaptchaErrorMessage""></span>
                                <button type=""button"" class=""button"" onclick=""window.location.href='/cart.html'""><span>Back to cart</span></button>

                                <button type=""submit"" class=""button pull-right""><span>Place Order</span></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 181 "D:\maineu\doan\KStore\KStore\Views\Cart\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Main Container End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
