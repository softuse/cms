#pragma checksum "F:\Projects\mvc_cms_first\mvc_cms_first\Views\HelloWorld\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22b5e25d6c0fe3cf4caceb2174852f4413f4f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Welcome), @"mvc.1.0.view", @"/Views/HelloWorld/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Welcome.cshtml", typeof(AspNetCore.Views_HelloWorld_Welcome))]
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
#line 1 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\_ViewImports.cshtml"
using mvc_cms_first;

#line default
#line hidden
#line 2 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\_ViewImports.cshtml"
using mvc_cms_first.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22b5e25d6c0fe3cf4caceb2174852f4413f4f64", @"/Views/HelloWorld/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ec7d4835c8624fdbbf2a85446d85cf87520b4b", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\HelloWorld\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 26, true);
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n<ul>\r\n");
            EndContext();
#line 9 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\HelloWorld\Welcome.cshtml"
     for (int i = 0; i < ViewBag.NumTimes; i++)
    {

#line default
#line hidden
            BeginContext(174, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(187, 15, false);
#line 11 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\HelloWorld\Welcome.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(202, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\HelloWorld\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(216, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
            EndContext();
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
