#pragma checksum "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82260eaa4e80a15916ddc5a81c4052212eb1f3ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/_ViewImports.cshtml"
using quoting_dojo;

#line default
#line hidden
#line 2 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/_ViewImports.cshtml"
using quoting_dojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82260eaa4e80a15916ddc5a81c4052212eb1f3ec", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8befaa81ee46489c12f9a4c1c5bac316dfc787f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 39, true);
            WriteLiteral("\n\n<h1>Here are the awesome Quotes</h1>\n");
            EndContext();
#line 4 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/Home/Result.cshtml"
 foreach(var quotes in ViewBag.Quotes)
{

#line default
#line hidden
            BeginContext(80, 8, true);
            WriteLiteral("    <p>\"");
            EndContext();
            BeginContext(89, 15, false);
#line 6 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/Home/Result.cshtml"
   Write(quotes["quote"]);

#line default
#line hidden
            EndContext();
            BeginContext(104, 13, true);
            WriteLiteral("\"</p>\n    <p>");
            EndContext();
            BeginContext(118, 14, false);
#line 7 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/Home/Result.cshtml"
  Write(quotes["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(132, 14, true);
            WriteLiteral(" - Created at ");
            EndContext();
            BeginContext(147, 20, false);
#line 7 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/Home/Result.cshtml"
                               Write(quotes["created_at"]);

#line default
#line hidden
            EndContext();
            BeginContext(167, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 8 "/Users/stevenchung/Documents/coding_dojo/c#_stack/II_asp_mvc/quoting_dojo/Views/Home/Result.cshtml"
}

#line default
#line hidden
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
