#pragma checksum "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c40928f1e5ac7ed8f54c5e4d515b3304f206503d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_Layout.cshtml", typeof(AspNetCore.Views__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c40928f1e5ac7ed8f54c5e4d515b3304f206503d", @"/Views/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44ae01019361e377f0244715cd5b6d7561d01a3", @"/Views/_ViewImports.cshtml")]
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(8, 363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c40928f1e5ac7ed8f54c5e4d515b3304f206503d4993", async() => {
                BeginContext(14, 100, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <meta charset=\"utf-8\">\r\n    <title>");
                EndContext();
                BeginContext(115, 13, false);
#line 5 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(128, 14, true);
                WriteLiteral("</title>\r\n    ");
                EndContext();
                BeginContext(142, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c40928f1e5ac7ed8f54c5e4d515b3304f206503d5842", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(233, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(239, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c40928f1e5ac7ed8f54c5e4d515b3304f206503d7261", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(290, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(296, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c40928f1e5ac7ed8f54c5e4d515b3304f206503d8514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(360, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(371, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(373, 2416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c40928f1e5ac7ed8f54c5e4d515b3304f206503d10568", async() => {
                BeginContext(379, 756, true);
                WriteLiteral(@"
    <div class=""col-md-12"">
        <nav class=""navbar navbar-expand-lg navbar-dark bg-dark my-2"">
            <a class=""navbar-brand"" href=""#"">My Project</a>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto""></ul>
                <ul class=""nav navbar-nav navbar-right"">
                    <li class=""nav-item dropdown myDropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""myDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <span class=""fas fa-shopping-cart"" style=""padding-right: inherit;""></span>
                            Sepet
                        </a>
                        ");
                EndContext();
                BeginContext(1136, 42, false);
#line 23 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"
                   Write(await Component.InvokeAsync("CartSummary"));

#line default
#line hidden
                EndContext();
                BeginContext(1178, 170, true);
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n\r\n            </div>\r\n        </nav>\r\n    </div>\r\n    <div class=\"container col-md-11\">\r\n        <div class=\"row\">\r\n\r\n");
                EndContext();
#line 33 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"
             if (TempData["message"] != null)
            {
                string classType = (TempData["danger"] != null && TempData["danger"].ToString() == "true") ? "alert-danger" : "alert-success";

#line default
#line hidden
                BeginContext(1554, 31, true);
                WriteLiteral("                <div id=\"alert\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1585, "\"", 1656, 7);
                WriteAttributeValue("", 1593, "alert", 1593, 5, true);
#line 36 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"
WriteAttributeValue(" ", 1598, classType, 1599, 10, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1609, "alert-dismissible", 1610, 18, true);
                WriteAttributeValue(" ", 1627, "fade", 1628, 5, true);
                WriteAttributeValue(" ", 1632, "show", 1633, 5, true);
                WriteAttributeValue(" ", 1637, "position-absolute", 1638, 18, true);
                WriteAttributeValue(" ", 1655, "", 1656, 1, true);
                EndWriteAttribute();
                BeginContext(1657, 36, true);
                WriteLiteral(" role=\"alert\">\r\n                    ");
                EndContext();
                BeginContext(1694, 30, false);
#line 37 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"
               Write(TempData["message"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1724, 220, true);
                WriteLiteral("\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n");
                EndContext();
#line 42 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"

                string message = TempData["message"].ToString();

#line default
#line hidden
                BeginContext(2012, 176, true);
                WriteLiteral("                <script type=\"text/javascript\">\r\n                    $(function () {\r\n                        $(\"#alert\");\r\n                    });\r\n                </script>\r\n");
                EndContext();
#line 49 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(2203, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(2216, 12, false);
#line 50 "D:\Documents\GitHub\LiteDbProject\MyProject\MyProject.WebApi\Views\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2228, 554, true);
                WriteLiteral(@"
        </div>
    </div>
    <div class=""col-md-12"">
        <h3 align=""center"">Footer</h3>
    </div>
    <script type=""text/javascript"">
        $('#myDropdown').on('click', function (event) {
            $('.myDropdown').toggleClass('show');
        });

        $('body').on('click', function (e) {
            if (!$('.myDropdown').is(e.target) && $('.myDropdown').has(e.target).length === 0 && $('.show').has(e.target).length === 0) {
                $('.myDropdown').removeClass('show');
            }
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2789, 9, true);
            WriteLiteral("\r\n</html>");
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
