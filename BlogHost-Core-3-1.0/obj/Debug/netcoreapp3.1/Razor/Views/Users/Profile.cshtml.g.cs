#pragma checksum "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7209f3416229197d91b72ccea5ef8c8e420bc08d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Profile), @"mvc.1.0.view", @"/Views/Users/Profile.cshtml")]
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
using ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7209f3416229197d91b72ccea5ef8c8e420bc08d", @"/Views/Users/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ee8235fb1839bf583ac9ebd9cb17c556ff282a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
   ViewData["Title"] = "Profile"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .container .img {
        text-align: center;
    }

    .container .details {
        border-left: 3px solid #ded4da;
    }

        .container .details p {
            font-size: 15px;
            font-weight: bold;
        }
    /* The Modal (background) */
    .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 100px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.9); /* Black w/ opacity */
    }

    /* Modal Content (image) */
    .modal-content {
        margin: auto;
        display: block;
        width: 80%;
        max-width: 700px;
    }

    /* Caption of Modal Image */
    #caption {
        margin: auto;
        display: block;
        wid");
            WriteLiteral(@"th: 80%;
        max-width: 700px;
        text-align: center;
        color: #ccc;
        padding: 10px 0;
        height: 150px;
    }

    /* Add Animation */
    .modal-content, #caption {
        -webkit-animation-name: zoom;
        -webkit-animation-duration: 0.6s;
        animation-name: zoom;
        animation-duration: 0.6s;
    }

    .webkit-keyframes zoom {
        from

    {
        -webkit-transform: scale(0)
    }

    to {
        -webkit-transform: scale(1)
    }

    }

    .keyframes zoom {
        from

    {
        transform: scale(0)
    }

    to {
        transform: scale(1)
    }

    }

    /* The Close Button */
    .close {
        position: absolute;
        top: 15px;
        right: 35px;
        color: #f1f1f1;
        font-size: 40px;
        font-weight: bold;
        transition: 0.3s;
    }

        .close:hover,
        .close:focus {
            color: #bbb;
            text-decoration: none;
            cursor: pointer;
        }

    /* 100% Image Width on Smaller Scr");
            WriteLiteral("eens */\n    .media only screen and (max-width: 700px) {\n        .modal-content\n\n    {\n        width: 100%;\n    }\n</style>\n\n<h3 class=\"text-center\">Profile</h3>\n\n\n<div class=\"container\">\n    <div class=\"row\">\n");
#nullable restore
#line 119 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
         if (Model.Avatar != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 img\">\n\n");
#nullable restore
#line 123 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
     if ((User.IsInRole("admin") == false) && (User.IsInRole("moder") == false))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<img id=\"myImg\" style=\'width:300px; height:300px;\'");
            BeginWriteAttribute("src", " src=\"", 2515, "\"", 2584, 2);
            WriteAttributeValue("", 2521, "data:image/jpeg;base64,", 2521, 23, true);
#nullable restore
#line 125 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
WriteAttributeValue("", 2544, Convert.ToBase64String(@Model.Avatar), 2544, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2585, "\"", 2591, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-rounded\" />");
#nullable restore
#line 125 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                                                                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
            WriteLiteral("                <div id=\"myModal\" class=\"modal\">\n                    <span class=\"close\">×</span>\n                    <img class=\"modal-content\" id=\"img01\">\n\n                </div>\n");
            WriteLiteral(@"                                <script>
                                    // Get the modal
                                    var modal = document.getElementById('myModal');

                                    // Get the image and insert it inside the modal - use its ""alt"" text as a caption
                                    var img = document.getElementById('myImg');
                                    var modalImg = document.getElementById(""img01"");

                                    img.onclick = function () {
                                        modal.style.display = ""block"";
                                        modalImg.src = this.src;

                                    }

                                    // Get the <span> element that closes the modal
                                    var span = document.getElementsByClassName(""close"")[0];

                                    // When the user clicks on <span> (x), close the modal
                                    span.onclick = fu");
            WriteLiteral("nction () {\n                                        modal.style.display = \"none\";\n                                    }\n                                </script>");
#nullable restore
#line 155 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 details\">\n            <blockquote>\n                <h5>\n                    ");
#nullable restore
#line 159 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 160 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
               Write(Model.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h5>\n                <small><cite title=\"Source Title\">");
#nullable restore
#line 162 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"icon-map-marker\"></i></cite></small>\n            </blockquote>\n            <table>\n                <tr>\n                    <td>Год рождения:</td>\n\n                    <td>");
#nullable restore
#line 168 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                   Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Пол:</td>\n\n                    <td>");
#nullable restore
#line 173 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                   Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Дата регистрации:</td>\n\n                    <td>");
#nullable restore
#line 178 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                   Write(Model.DateRegistration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Род деятельности:</td>\n                    <td>");
#nullable restore
#line 182 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                </tr>\n                <tr>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7209f3416229197d91b72ccea5ef8c8e420bc08d13449", async() => {
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7209f3416229197d91b72ccea5ef8c8e420bc08d13734", async() => {
                    WriteLiteral("Редактировать профиль");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 189 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                                                                                  WriteLiteral(Model.Id);

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
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7209f3416229197d91b72ccea5ef8c8e420bc08d16149", async() => {
                    WriteLiteral("Сменить пароль");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 190 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                                                                                            WriteLiteral(Model.Id);

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
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 188 "D:\BlogHost-Core-3-1.0\qwert\BlogHost-Core-3-1.0\Views\Users\Profile.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n                </tr>\n            </table>\n        </div>\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
