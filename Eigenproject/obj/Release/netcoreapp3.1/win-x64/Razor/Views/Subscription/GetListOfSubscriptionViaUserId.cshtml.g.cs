#pragma checksum "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e852446080c4dce3ad48652066c005e3175aeca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_GetListOfSubscriptionViaUserId), @"mvc.1.0.view", @"/Views/Subscription/GetListOfSubscriptionViaUserId.cshtml")]
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
#line 1 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\_ViewImports.cshtml"
using Eigenproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\_ViewImports.cshtml"
using Eigenproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e852446080c4dce3ad48652066c005e3175aeca", @"/Views/Subscription/GetListOfSubscriptionViaUserId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a173edcae77b6bf7fc0389806834da0dc0ce595a", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscription_GetListOfSubscriptionViaUserId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eigenproject.Models.SubscriptionModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Subscription.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
  
    ViewData["Title"] = "GetListOfSubscriptionViaUserId";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"postBox\" style=\"margin-top: 80px; text-align: center\">\r\n    <h3 style=\"color:  #fff\"> Subscriptions</h3>\r\n");
#nullable restore
#line 11 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"color: #fff\">\r\n            You are not subscribed to any genre\r\n        </div>\r\n");
#nullable restore
#line 16 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <input style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 564, "\"", 582, 1);
#nullable restore
#line 22 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
WriteAttributeValue("", 572, item.Name, 572, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"GenreInput\" />\r\n                <div style=\"color: #fff; display: inline-block\" id=\"Name\">");
#nullable restore
#line 23 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 24 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
                 if (item.type == "Genre")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn-UnfollowSub btn btn-primary center\" style=\"display: inline-block; width: auto; padding-bottom: 5px\" id=\"Unfollow\">Unfollow Genre</button>\r\n");
#nullable restore
#line 27 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn-UnfollowSub btn btn-primary center\" style=\"display: inline-block; width: auto; padding-bottom: 5px\" id=\"Unfollow\">Unfollow Tag</button>\r\n");
#nullable restore
#line 31 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 33 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e852446080c4dce3ad48652066c005e3175aeca7590", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eigenproject.Models.SubscriptionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
