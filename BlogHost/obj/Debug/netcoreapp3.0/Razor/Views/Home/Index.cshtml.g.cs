#pragma checksum "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "608ba8c0395975fb0d8e0bab43b5adf71d0dae08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\_ViewImports.cshtml"
using BlogHost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\_ViewImports.cshtml"
using BlogHost.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608ba8c0395975fb0d8e0bab43b5adf71d0dae08", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1884497f905e6a58884689e89cce44b23084a689", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Publication>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Publication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "608ba8c0395975fb0d8e0bab43b5adf71d0dae084668", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Spacein - Development Agency</title>
    <link rel=""stylesheet"" href=""css/normalize.css"">
    <link rel=""stylesheet"" href=""css/style1.css"">
    <link rel=""stylesheet"" href=""css/media.css"">
    <link rel=""stylesheet"" href=""css/slick/slick.css"">
    <link rel=""stylesheet"" href=""css/slick/slick-theme.css"">
    <link rel=""stylesheet"" href=""css/vegas.min.css"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.1/css/all.css"" integrity=""sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf"" crossorigin=""anonymous"">
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "608ba8c0395975fb0d8e0bab43b5adf71d0dae086400", async() => {
                WriteLiteral(@"
    <div class=""preloader complete"">
        <div class=""loader""></div>
    </div>
    <div class=""background"">
        <ul class=""bg-bubbles""><li></li><li></li><li></li><li></li><li></li><li></li><li></li><li></li><li></li><li></li></ul>
    </div>

    <div class=""container"">
        <section class=""second transform"" id=""about"">
            <div class=""second-content"">
                <div class=""second-cards"">
                    <div class=""second-card"">
                        <div class=""second-card-text"">
                            <h2>01</h2>
                            <h3>");
#nullable restore
#line 32 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                           Write(Model.ToList()[0].PublicationName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 33 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                          Write(Model.ToList()[0].Discription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 34 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "608ba8c0395975fb0d8e0bab43b5adf71d0dae088124", async() => {
                    WriteLiteral("Read more");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("font-weight-bold\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                                                                                                     WriteLiteral(Model.ToList()[0].Id);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 36 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                                                                                                                                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\n                    </div>\n                    <div class=\"second-card\">\n                        <div class=\"second-card-text\">\n                            <h2>02</h2>\n                            <h3>");
#nullable restore
#line 42 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                           Write(Model.ToList()[1].PublicationName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 43 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                          Write(Model.ToList()[1].Discription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 44 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "608ba8c0395975fb0d8e0bab43b5adf71d0dae0812471", async() => {
                    WriteLiteral("Read more");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("font-weight-bold\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                                                                                                     WriteLiteral(Model.ToList()[1].Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral(" ");
#nullable restore
#line 46 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                                                                                                                                                      } 

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\n                    </div>\n                    <div class=\"second-card\">\n                        <div class=\"second-card-text\">\n                            <h2>03</h2>\n                            <h3>");
#nullable restore
#line 52 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                           Write(Model.ToList()[2].PublicationName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 53 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                          Write(Model.ToList()[2].Discription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 54 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "608ba8c0395975fb0d8e0bab43b5adf71d0dae0816858", async() => {
                    WriteLiteral("Read more");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("font-weight-bold\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                                                                                                     WriteLiteral(Model.ToList()[2].Id);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 56 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Home\Index.cshtml"
                                                                                                                                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\n                    </div>\n                </div>\n            </div>\n        </section>\n\n    </div>\n");
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
            WriteLiteral(@"
<script src=""js/jquery.min.js""></script>
<script src=""js/slick.min.js""></script>
<script src=""js/isotope.pkgd.min.js""></script>
<script src=""js/imagesloaded.pkgd.min.js""></script>
<script src=""js/vegas.min.js""></script>
<script src=""js/skrollr.js""></script>
<script src=""js/main.js""></script>
<script>$('.switcher-open').click(function () {
        $('.styles-switcher').toggleClass('active');
    });
    function light() {
        $(""head"").html($(""head"").html().replace('css/style.css', 'css/style1.css'));
    }
    function dark() {
        $(""head"").html($(""head"").html().replace('css/style1.css', 'css/style.css'));
    }</script>
<script>$(window).scroll(function () {
        let second = $('.second').offset();
        let three = $('.three').offset();
        let fourth = $('.fourth').offset();
        let six = $('.six').offset();
        if ($(window).scrollTop() > second.top - 100) {
            $('.second').addClass('transform');
        }
        if ($(window).scrollTop() > three.top - 200) {
         ");
            WriteLiteral(@"   $('.three').addClass('transform');
        }
        if ($(window).scrollTop() > fourth.top - 300) {
            $('.fourth').addClass('transform');
        }
        if ($(window).scrollTop() > six.top - 300) {
            $('.six').addClass('transform');
        }
    });
}</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Publication>> Html { get; private set; }
    }
}
#pragma warning restore 1591
