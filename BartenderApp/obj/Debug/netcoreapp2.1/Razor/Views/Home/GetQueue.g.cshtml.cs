#pragma checksum "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd2f4aea6ff93739dfecfa6cbe5aa5fa25c91077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetQueue), @"mvc.1.0.view", @"/Views/Home/GetQueue.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetQueue.cshtml", typeof(AspNetCore.Views_Home_GetQueue))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2f4aea6ff93739dfecfa6cbe5aa5fa25c91077", @"/Views/Home/GetQueue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8a9299c52128077241df8014c4e820aa2ac15c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetQueue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
 if (Model.Count() == 0)
{


#line default
#line hidden
            BeginContext(68, 30, true);
            WriteLiteral("    <h1> Nothing exists</h1>\r\n");
            EndContext();
#line 11 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
}

else
{
    

#line default
#line hidden
#line 15 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
     foreach (var localName in Model)
    {

#line default
#line hidden
            BeginContext(158, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(166, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8130efbb3fa74213a41a907af9ae84ba", async() => {
                BeginContext(206, 18, true);
                WriteLiteral("\r\n            <h1>");
                EndContext();
                BeginContext(225, 19, false);
#line 18 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
           Write(localName.DrinkName);

#line default
#line hidden
                EndContext();
                BeginContext(244, 23, true);
                WriteLiteral("</h1>\r\n            <h3>");
                EndContext();
                BeginContext(268, 19, false);
#line 19 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
           Write(localName.orderTime);

#line default
#line hidden
                EndContext();
                BeginContext(287, 32, true);
                WriteLiteral("</h3>\r\n            <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=", 319, "", 344, 1);
#line 20 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
WriteAttributeValue("", 326, localName.OrderId, 326, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(344, 74, true);
                WriteLiteral(" name=\"Id\" />\r\n            <button type=\"submit\">Delete</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(425, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
    }

#line default
#line hidden
#line 23 "C:\Users\Syed Wasim Ali\source\repos\BartenderApp\BartenderApp\Views\Home\GetQueue.cshtml"
     



}

#line default
#line hidden
            BeginContext(443, 16, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
