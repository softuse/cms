#pragma checksum "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72883c1b72f582fb8b07d94e9a35f6f02e308b0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
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
#line 2 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72883c1b72f582fb8b07d94e9a35f6f02e308b0d", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ec7d4835c8624fdbbf2a85446d85cf87520b4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "内容列表";

#line default
#line hidden
            BeginContext(84, 78, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\" >\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(163, 17, false);
#line 7 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(180, 314, true);
            WriteLiteral(@"</div>

    <table class=""table table-hover"">
        <thead>
            <tr>
                <td><input type=""checkbox"" class=""done-checkbox""/></td>
                <td>序号</td>
                <td>标题</td>
                <td>内容</td>
                <td>添加时间</td>
            </tr>
        </thead>

");
            EndContext();
#line 20 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
         foreach(var item in Model.Contents)
        {

#line default
#line hidden
            BeginContext(551, 152, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"done-checkbox\" />\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(704, 7, false);
#line 26 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
               Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(711, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(739, 10, false);
#line 27 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(749, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(777, 13, false);
#line 28 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
               Write(item.Contents);

#line default
#line hidden
            EndContext();
            BeginContext(790, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(818, 24, false);
#line 29 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
               Write(item.Add_time.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(842, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "F:\Projects\mvc_cms_first\mvc_cms_first\Views\Content\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(879, 40, true);
            WriteLiteral("    </table>\r\n</div>\r\n<h2>Index</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
