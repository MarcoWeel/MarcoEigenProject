#pragma checksum "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a37f612cc50861bd4bcd7eae22865ec913c5b8f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a37f612cc50861bd4bcd7eae22865ec913c5b8f", @"/Views/Post/ViewPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a173edcae77b6bf7fc0389806834da0dc0ce595a", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_ViewPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eigenproject.Models.ViewModels.PostFileViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Like.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Subscription.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "ViewPosts";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n");
            WriteLiteral("\r\n\r\n<h1 style=\"padding-top: 50px\"></h1>\r\n\r\n\r\n");
#nullable restore
#line 17 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
 if (Context.GetCurrentUserModel() != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     foreach (var item in Model)
    {
        var oldLikeAmount = item.Likes;
        string path = item.File;
        var extension = System.IO.Path.GetExtension(path);
        string type = "Genre";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"postBox\">\r\n    <input style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 762, "\"", 780, 1);
#nullable restore
#line 26 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 770, item.Tags, 770, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"TypeInput\" id=\"TagInput\" />\r\n    <input style=\"display: none\"");
            BeginWriteAttribute("value", " value=\"", 850, "\"", 869, 1);
#nullable restore
#line 27 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 858, item.Genre, 858, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"GenreInput\" />\r\n    <h5 class=\"center\" style=\"color: #fff; padding-bottom: 0; margin-left: 30px; width: inherit\">\r\n");
#nullable restore
#line 29 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
         if (Context.GetCurrentUserModel().User_Id == item.User_Id)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
       Write(Html.ActionLink(@item.Title, "UpdatePost", "Post", new {post_Id = item.ID}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                                                        
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                       
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
         if (SubscriptionProcessor.GetSubscriptionStatus(Context.GetCurrentUserModel().User_Id, item.Genre))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <button style=""display: inline-block; float: right; margin-right: 100px"" class=""btn-Follow btn btn-primary"" id=""Follow"">Follow Genre</button>
            <button class=""btn-Unfollow btn btn-primary"" style=""display: none; float: right; margin-right: 100px"" id=""Unfollow"">Unfollow Genre</button>
");
#nullable restore
#line 41 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <button style=""display: none; float: right; margin-right: 100px"" class=""btn-Follow btn btn-primary"" id=""Follow"">Follow Genre</button>
            <button class=""btn-Unfollow btn btn-primary"" style=""display: inline-block; float: right; margin-right: 100px;"" id=""Unfollow"">Unfollow Genre</button>
");
#nullable restore
#line 46 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
         if (SubscriptionProcessor.GetSubscriptionStatus(Context.GetCurrentUserModel().User_Id, item.Tags))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <button style=""display: inline-block; float: right; margin-right: 10px;"" class=""btn-FollowTag btn btn-primary"" id=""FollowTag"">Follow Tag</button>
            <button class=""btn-UnfollowTag btn btn-primary"" style=""display: none; float: right; margin-right: 10px;"" id=""UnfollowTag"">Unfollow Tag</button>
");
#nullable restore
#line 51 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <button class=""btn-UnfollowTag btn btn-primary"" style=""display: inline-block; float: right; margin-right: 10px;"" id=""UnfollowTag"">Unfollow Tag</button>
            <button style=""display: none; float: right; margin-right: 10px;"" class=""btn-FollowTag btn btn-primary"" id=""FollowTag"">Follow Tag</button>
");
#nullable restore
#line 56 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h5>\r\n    <h6 class=\"center\" style=\"color: #fff; padding-top: 0; margin-left: 30px; margin-bottom: -10px; width: inherit\">Genre: ");
#nullable restore
#line 58 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                                                                                      Write(Html.ActionLink(@item.Genre, "GetPostsByGenre", "Post", new { genre = item.Genre }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <h6 class=\"center\" style=\"color: #fff; padding-top: 0; margin-left: 30px; margin-bottom: 10px; width: inherit\">Tag: ");
#nullable restore
#line 59 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                                                                                   Write(Html.ActionLink(@item.Tags, "GetPostsByTag", "Post", new { tag = item.Tags }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n");
#nullable restore
#line 61 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 3345, "\"", 3356, 1);
#nullable restore
#line 63 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3351, path, 3351, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"centerImage\" />\r\n");
#nullable restore
#line 64 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <video");
            BeginWriteAttribute("src", " src=\"", 3420, "\"", 3431, 1);
#nullable restore
#line 67 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3426, path, 3426, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"centerImage\"></video>\r\n");
#nullable restore
#line 68 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 71 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     if (LikesProcessor.CheckIfLikedOrDisliked(Context.GetCurrentUserModel().User_Id, item.ID) == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"btn-Like btn-primary btn\" id=\"Like\"");
            BeginWriteAttribute("value", " value=\"", 3644, "\"", 3660, 1);
#nullable restore
#line 73 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3652, item.ID, 3652, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-up\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block\"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-DisLike btn-primary btn\" id=\"Dislike\"");
            BeginWriteAttribute("value", " value=\"", 3919, "\"", 3935, 1);
#nullable restore
#line 77 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 3927, item.ID, 3927, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left: 10px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-down\" aria-hidden=\"true\" style=\"        margin: 0 auto;\r\n        display: block\"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-ReturnLike btn-primary btn\" id=\"LikeReturn\"");
            BeginWriteAttribute("value", " value=\"", 4219, "\"", 4235, 1);
#nullable restore
#line 82 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 4227, item.ID, 4227, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none; margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-up\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block; color: goldenrod \"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-ReturnLike btn-primary btn\" id=\"DislikeReturn\"");
            BeginWriteAttribute("value", " value=\"", 4537, "\"", 4553, 1);
#nullable restore
#line 86 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 4545, item.ID, 4545, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none; margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-down\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block; color: dodgerblue\"></i>\r\n        </button>\r\n");
#nullable restore
#line 89 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }
    else if (LikesProcessor.CheckIfLikedOrDisliked(Context.GetCurrentUserModel().User_Id, item.ID) == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"btn-Like btn-primary btn\" id=\"Like\"");
            BeginWriteAttribute("value", " value=\"", 4963, "\"", 4979, 1);
#nullable restore
#line 92 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 4971, item.ID, 4971, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"        display: none;\r\n        margin-left: 30px;\r\n        margin-bottom: 10px;\r\n        height: 35px\r\n\">\r\n            <i class=\"fa fa-arrow-circle-up\" aria-hidden=\"true\" style=\"margin: 0 auto;display: block\"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-DisLike btn-primary btn\" id=\"Dislike\"");
            BeginWriteAttribute("value", " value=\"", 5289, "\"", 5305, 1);
#nullable restore
#line 100 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 5297, item.ID, 5297, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none; margin-left: 10px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-down\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block\"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-ReturnLike btn-primary btn\" id=\"LikeReturn\"");
            BeginWriteAttribute("value", " value=\"", 5587, "\"", 5603, 1);
#nullable restore
#line 104 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 5595, item.ID, 5595, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: inline-block; margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-up\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block; color: goldenrod \"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-ReturnLike btn-primary btn\" id=\"DislikeReturn\"");
            BeginWriteAttribute("value", " value=\"", 5913, "\"", 5929, 1);
#nullable restore
#line 108 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 5921, item.ID, 5921, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none; margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-down\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block; color: dodgerblue\"></i>\r\n        </button>\r\n");
#nullable restore
#line 111 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"btn-Like btn-primary btn\" id=\"Like\"");
            BeginWriteAttribute("value", " value=\"", 6240, "\"", 6256, 1);
#nullable restore
#line 114 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 6248, item.ID, 6248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none; margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-up\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block\"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-DisLike btn-primary btn\" id=\"Dislike\"");
            BeginWriteAttribute("value", " value=\"", 6530, "\"", 6546, 1);
#nullable restore
#line 118 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 6538, item.ID, 6538, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none; margin-left: 10px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-down\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block\"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-ReturnLike btn-primary btn\" id=\"LikeReturn\"");
            BeginWriteAttribute("value", " value=\"", 6828, "\"", 6844, 1);
#nullable restore
#line 122 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 6836, item.ID, 6836, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none; margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-up\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block; color: goldenrod \"></i>\r\n        </button>\r\n");
            WriteLiteral("        <button class=\"btn-ReturnLike btn-primary btn\" id=\"DislikeReturn\"");
            BeginWriteAttribute("value", " value=\"", 7146, "\"", 7162, 1);
#nullable restore
#line 126 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 7154, item.ID, 7154, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: inline-block; margin-left: 30px; margin-bottom: 10px; height: 35px\">\r\n            <i class=\"fa fa-arrow-circle-down\" aria-hidden=\"true\" style=\"margin: 0 auto; display: block; color: dodgerblue\"></i>\r\n        </button>\r\n");
#nullable restore
#line 129 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"Aantal-Likes\" style=\"color: #fff\">Likes: ");
#nullable restore
#line 130 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                     Write(item.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n</div>\r\n");
#nullable restore
#line 132 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     foreach (var item in Model)
    {
        var oldLikeAmount = item.Likes;
        string path = item.File;
        var extension = System.IO.Path.GetExtension(path);
        string type = "Genre";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"postBox\">\r\n            <h5 class=\"center\" style=\"color: #fff; padding-bottom: 0; margin-left: 30px; width: inherit\">");
#nullable restore
#line 143 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n            <h6 class=\"center\" style=\"color: #fff; padding-top: 0; margin-left: 30px; margin-bottom: -10px; width: inherit\">Genre: ");
#nullable restore
#line 144 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                                                                                              Write(Html.ActionLink(@item.Genre, "GetPostsByGenre", "Post", new { genre = item.Genre }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6 class=\"center\" style=\"color: #fff; padding-top: 0; margin-left: 30px; margin-bottom: 10px; width: inherit\">Tag: ");
#nullable restore
#line 145 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                                                                                           Write(Html.ActionLink(@item.Tags, "GetPostsByTag", "Post", new { tag = item.Tags }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 146 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
             if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 8431, "\"", 8442, 1);
#nullable restore
#line 148 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 8437, path, 8437, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"centerImage\" />\r\n");
#nullable restore
#line 149 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <video");
            BeginWriteAttribute("src", " src=\"", 8538, "\"", 8549, 1);
#nullable restore
#line 152 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
WriteAttributeValue("", 8544, path, 8544, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"centerImage\"></video>\r\n");
#nullable restore
#line 153 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <button id=""NotLogged"" class=""btnNotlogged btn-primary btn"" style=""margin-left: 30px; margin-bottom: 10px; height: 35px"">
                <i class=""fa fa-arrow-circle-up"" aria-hidden=""true"" style=""margin: 0 auto; display: block""></i>
            </button>
            <button id=""NotLogged"" class=""btnNotlogged btn-primary btn"" style=""margin-left: 10px; margin-bottom: 10px; height: 35px"">
                <i class=""fa fa-arrow-circle-down"" aria-hidden=""true"" style=""margin: 0 auto; display: block""></i>
            </button>
            <span class=""Aantal-Likes"" style=""color: #fff"">Likes: ");
#nullable restore
#line 160 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
                                                             Write(item.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n        </div>\r\n");
#nullable restore
#line 162 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Post\ViewPosts.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\".btnNotlogged\").click(function () {\r\n            alert(\"Can\'t do this while not logged in\");\r\n        })\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a37f612cc50861bd4bcd7eae22865ec913c5b8f28315", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a37f612cc50861bd4bcd7eae22865ec913c5b8f29415", async() => {
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
