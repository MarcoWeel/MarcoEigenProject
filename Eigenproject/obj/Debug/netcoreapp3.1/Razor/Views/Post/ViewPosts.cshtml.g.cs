#pragma checksum "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbe13adf09cad98e0d0e21af5757e1db20d60166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_ViewPosts), @"mvc.1.0.view", @"/Views/Post/ViewPosts.cshtml")]
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
#nullable restore
#line 1 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
using DataLayerLibrary.DataLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
using LogicLayerLibrary.ExtensionMethods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe13adf09cad98e0d0e21af5757e1db20d60166", @"/Views/Post/ViewPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a173edcae77b6bf7fc0389806834da0dc0ce595a", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_ViewPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eigenproject.Models.ViewModels.PostFileViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Like.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Subscription.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "ViewPosts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"padding-top: 50px\">ViewPosts</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe13adf09cad98e0d0e21af5757e1db20d601665419", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 18 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
 foreach (var item in Model)
{
    var oldLikeAmount = item.Likes;
    string path = item.File;
    var extension = System.IO.Path.GetExtension(path);
    string type = "Genre";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"postBox\">\r\n");
#nullable restore
#line 25 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     if (SubscriptionProcessor.GetSubscriptionStatus(Context.GetCurrentUserModel().User_Id, item.Genre))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 760, "\"", 773, 1);
#nullable restore
#line 27 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 768, type, 768, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"TypeInput\" id=\"TypeInput\" />\r\n        <input style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 848, "\"", 867, 1);
#nullable restore
#line 28 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 856, item.Genre, 856, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"GenreInput\" />\r\n        <h5 class=\"center\">");
#nullable restore
#line 29 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<button style=\"display: inline-block; float: right\" class=\"btn-Follow\" id=\"Follow\">Follow Genre</button><button class=\"btn-Unfollow\" style=\"display: none; float: right\" id=\"Unfollow\">Unfollow Genre</button></h5>\r\n");
#nullable restore
#line 30 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 1200, "\"", 1219, 1);
#nullable restore
#line 33 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 1208, item.Genre, 1208, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"GenreInput\" />\r\n        <h5 class=\"center\">");
#nullable restore
#line 34 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<button style=\"display: none; float: right\" class=\"btn-Follow\" id=\"Follow\">Follow Genre</button><button class=\"btn-Unfollow\" style=\"display: inline-block; float: right\" id=\"Unfollow\">Unfollow Genre</button></h5>\r\n");
#nullable restore
#line 35 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 1596, "\"", 1607, 1);
#nullable restore
#line 38 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 1602, path, 1602, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"centerImage\" />\r\n");
#nullable restore
#line 39 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <video");
            BeginWriteAttribute("src", " src=\"", 1671, "\"", 1682, 1);
#nullable restore
#line 42 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 1677, path, 1677, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"centerImage\"></video>\r\n");
#nullable restore
#line 43 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 46 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
Write(Context.GetCurrentUserModel().UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     if (LikesProcessor.CheckIfLikedOrDisliked(Context.GetCurrentUserModel().User_Id, item.ID) == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-Like\" id=\"Like\"");
            BeginWriteAttribute("value", " value=\"", 2007, "\"", 2023, 1);
#nullable restore
#line 49 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 2015, item.ID, 2015, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/8e934930-d2bc-4575-a8ad-03ba4f7f0ebf_achtergrond.png\" class=\"btn-DisLike\" id=\"Dislike\"");
            BeginWriteAttribute("value", " value=\"", 2155, "\"", 2171, 1);
#nullable restore
#line 50 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 2163, item.ID, 2163, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-ReturnLike\" id=\"LikeReturn\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 2336, "\"", 2352, 1);
#nullable restore
#line 51 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 2344, item.ID, 2344, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-ReturnLike\" id=\"DislikeReturn\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 2520, "\"", 2536, 1);
#nullable restore
#line 52 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 2528, item.ID, 2528, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 53 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }
    else if (LikesProcessor.CheckIfLikedOrDisliked(Context.GetCurrentUserModel().User_Id, item.ID) == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-Like\" id=\"Like\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 2812, "\"", 2828, 1);
#nullable restore
#line 56 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 2820, item.ID, 2820, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/8e934930-d2bc-4575-a8ad-03ba4f7f0ebf_achtergrond.png\" class=\"btn-DisLike\" id=\"Dislike\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 2982, "\"", 2998, 1);
#nullable restore
#line 57 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 2990, item.ID, 2990, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-ReturnLike\" id=\"LikeReturn\" style=\"display: inline-block\"");
            BeginWriteAttribute("value", " value=\"", 3171, "\"", 3187, 1);
#nullable restore
#line 58 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3179, item.ID, 3179, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-ReturnLike\" id=\"DislikeReturn\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 3355, "\"", 3371, 1);
#nullable restore
#line 59 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3363, item.ID, 3363, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 60 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-Like\" id=\"Like\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 3548, "\"", 3564, 1);
#nullable restore
#line 63 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3556, item.ID, 3556, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/8e934930-d2bc-4575-a8ad-03ba4f7f0ebf_achtergrond.png\" class=\"btn-DisLike\" id=\"Dislike\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 3718, "\"", 3734, 1);
#nullable restore
#line 64 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3726, item.ID, 3726, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-ReturnLike\" id=\"LikeReturn\" style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 3899, "\"", 3915, 1);
#nullable restore
#line 65 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3907, item.ID, 3907, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"image\" src=\"Images/07b18101-b620-4815-8b46-0a63abee3403_tribal bitch (1).png\" class=\"btn-ReturnLike\" id=\"DislikeReturn\" style=\"display: inline-block\"");
            BeginWriteAttribute("value", " value=\"", 4091, "\"", 4107, 1);
#nullable restore
#line 66 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 4099, item.ID, 4099, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 67 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"Aantal-Likes\">");
#nullable restore
#line 68 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                          Write(item.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n</div>\r\n");
#nullable restore
#line 70 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe13adf09cad98e0d0e21af5757e1db20d6016619583", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe13adf09cad98e0d0e21af5757e1db20d6016620683", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eigenproject.Models.ViewModels.PostFileViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
