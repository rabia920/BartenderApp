#pragma checksum "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\Desserts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7848f96cf5576c16a681cb5ceb555c5cfd98e444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Desserts), @"mvc.1.0.view", @"/Views/Home/Desserts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Desserts.cshtml", typeof(AspNetCore.Views_Home_Desserts))]
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
#line 1 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\_ViewImports.cshtml"
using BartenderApp;

#line default
#line hidden
#line 2 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\_ViewImports.cshtml"
using BartenderApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7848f96cf5576c16a681cb5ceb555c5cfd98e444", @"/Views/Home/Desserts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8a9299c52128077241df8014c4e820aa2ac15c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Desserts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\Desserts.cshtml"
 foreach (var localDessertName in Model)
{

#line default
#line hidden
            BeginContext(66, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(75, 16, false);
#line 6 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\Desserts.cshtml"
   Write(localDessertName);

#line default
#line hidden
            EndContext();
            BeginContext(91, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 7 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\Desserts.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591