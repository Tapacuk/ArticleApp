#pragma checksum "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8cbbe8623cbbb8fbc329aa8bee95ad5228648f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_Index), @"mvc.1.0.view", @"/Views/Tag/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tag/Index.cshtml", typeof(AspNetCore.Views_Tag_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8cbbe8623cbbb8fbc329aa8bee95ad5228648f", @"/Views/Tag/Index.cshtml")]
    public class Views_Tag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ArticleApp.Models.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 74, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n");
            EndContext();
#line 13 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(235, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(340, 40, false);
#line 19 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(380, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 25 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(543, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(616, 39, false);
#line 29 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(655, 99, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 754, "\"", 777, 1);
#line 32 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
WriteAttributeValue("", 769, item.Id, 769, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(778, 60, true);
            WriteLiteral(">Edit</a> |\r\n                        <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 838, "\"", 861, 1);
#line 33 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
WriteAttributeValue("", 853, item.Id, 853, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(862, 62, true);
            WriteLiteral(">Details</a> |\r\n                        <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 924, "\"", 947, 1);
#line 34 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
WriteAttributeValue("", 939, item.Id, 939, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(948, 63, true);
            WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1026, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 40 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
} else {

#line default
#line hidden
            BeginContext(1066, 16, true);
            WriteLiteral(" <h3>Empty</h3> ");
            EndContext();
#line 40 "D:\Asp.Net projects\ArticleApp\ArticleApp\Views\Tag\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1085, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ArticleApp.Models.Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
