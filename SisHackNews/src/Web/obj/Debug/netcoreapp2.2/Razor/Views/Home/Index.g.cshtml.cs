#pragma checksum "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a0347c00f035de69b9fbf0ce4dfe9f7e915a96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\GENTIL\SisHackNews\src\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\GENTIL\SisHackNews\src\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a0347c00f035de69b9fbf0ce4dfe9f7e915a96", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Application.ViewModel.NoticiaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(105, 31, true);
            WriteLiteral("\r\n<h2>Últimas Notícias</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(169, 142, true);
            WriteLiteral("    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 col-md-12 mx-auto\">\r\n            <div class=\"post-preview\">\r\n                ");
            EndContext();
            BeginContext(311, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45a0347c00f035de69b9fbf0ce4dfe9f7e915a963987", async() => {
                BeginContext(366, 71, true);
                WriteLiteral("\r\n                    <h2 class=\"post-title\">\r\n                        ");
                EndContext();
                BeginContext(438, 41, false);
#line 16 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
                EndContext();
                BeginContext(479, 45, true);
                WriteLiteral("\r\n                    </h2>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"
                                          WriteLiteral(item.NoticiaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(528, 66, true);
            WriteLiteral("\r\n                <h4 class=\"post-subtitle\">\r\n                    ");
            EndContext();
            BeginContext(595, 44, false);
#line 20 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SubTitulo));

#line default
#line hidden
            EndContext();
            BeginContext(639, 131, true);
            WriteLiteral("\r\n                </h4>\r\n\r\n                <p class=\"post-meta\">\r\n                    Postado por\r\n                    <a href=\"#\">");
            EndContext();
            BeginContext(771, 40, false);
#line 25 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Autor));

#line default
#line hidden
            EndContext();
            BeginContext(811, 45, true);
            WriteLiteral("</a><br />\r\n                    Publicado em ");
            EndContext();
            BeginContext(857, 49, false);
#line 26 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.DataPublicacao));

#line default
#line hidden
            EndContext();
            BeginContext(906, 74, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\GENTIL\SisHackNews\src\Web\Views\Home\Index.cshtml"

}

#line default
#line hidden
            BeginContext(985, 6, true);
            WriteLiteral("    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Application.ViewModel.NoticiaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
