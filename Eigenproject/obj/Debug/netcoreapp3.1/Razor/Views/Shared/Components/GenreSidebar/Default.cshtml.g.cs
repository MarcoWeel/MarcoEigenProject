#pragma checksum "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Shared\Components\GenreSidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24dd4844c5b983f7908f3916dedeac83c4c409fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GenreSidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GenreSidebar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dd4844c5b983f7908f3916dedeac83c4c409fc", @"/Views/Shared/Components/GenreSidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a173edcae77b6bf7fc0389806834da0dc0ce595a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GenreSidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eigenproject.Models.GenreModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h4 style=\"padding-right: 48px; margin-left: 10px; margin-bottom: -8px\">Popular Genres</h4>\r\n<div style=\"padding-right: 48px; margin-left: 10px\">\r\n");
#nullable restore
#line 6 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Shared\Components\GenreSidebar\Default.cshtml"
     for (int i = 0; i < Model.Count(); i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Shared\Components\GenreSidebar\Default.cshtml"
   Write(Html.ActionLink(@Model.ElementAt(i).Name, "GetPostsByGenre", "Post", new { genre = Model.ElementAt(i).Name }, new { @style = "padding-left: 0px; padding-right: 8px" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\eigenproject git\MarcoEigenProject\Eigenproject\Views\Shared\Components\GenreSidebar\Default.cshtml"
                                                                                                                                                                                
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eigenproject.Models.GenreModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
