#pragma checksum "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8d0f0193d47de5d1568b0d63e867b752b3d544d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8d0f0193d47de5d1568b0d63e867b752b3d544d", @"/Views/Subscription/GetListOfSubscriptionViaUserId.cshtml")]
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
            WriteLiteral("\r\n<h1>GetListOfSubscriptionViaUserId</h1>\r\n\r\n<h3> Subscriptions</h3>\r\n");
#nullable restore
#line 11 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        You are not subscribed to any genre\r\n    </div>\r\n");
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
            WriteLiteral("        <div>\r\n            <div id=\"Name\">");
#nullable restore
#line 22 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <input style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 489, "\"", 507, 1);
#nullable restore
#line 23 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
WriteAttributeValue("", 497, item.Name, 497, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"GenreInput\" />\r\n            <button class=\"btn-UnfollowSub\" style=\"display: inline-block;\" id=\"Unfollow\">Unfollow Genre</button>\r\n        </div>\r\n");
#nullable restore
#line 26 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Subscription\GetListOfSubscriptionViaUserId.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8d0f0193d47de5d1568b0d63e867b752b3d544d6290", async() => {
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
