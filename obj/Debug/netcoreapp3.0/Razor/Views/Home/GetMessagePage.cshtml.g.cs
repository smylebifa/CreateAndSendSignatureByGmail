#pragma checksum "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3527619ca92638d5579a626bad959ad6dd2ce26d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetMessagePage), @"mvc.1.0.view", @"/Views/Home/GetMessagePage.cshtml")]
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
#line 1 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\_ViewImports.cshtml"
using CryptLab1WebAppMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\_ViewImports.cshtml"
using CryptLab1WebAppMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3527619ca92638d5579a626bad959ad6dd2ce26d", @"/Views/Home/GetMessagePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccca4d3e1ec9d5d61b9d51bda401e124b9b59d36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetMessagePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAccessToEmailForReceive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("getMailFormAccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMessagePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-statusOfChangingMessage", "prev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-statusOfChangingMessage", "next", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckSignature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("checkSignature"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
  
    ViewData["Title"] = "Проверка подписи";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    input:-webkit-autofill,
    input:-webkit-autofill:hover,
    input:-webkit-autofill:focus,
    select:-webkit-autofill,
    select:-webkit-autofill:hover,
    select:-webkit-autofill:focus {
        -webkit-text-fill-color: white;
        -webkit-box-shadow: 0 0 0px 1000px #13141438 inset;
        transition: background-color 5000s ease-in-out 0s;
    }

    /*a.action-link {
        color: #419936;
    }

    .action-link {
        color: #419936;
    }

    input.btn.hack:hover {
        opacity: 0.8;
    }*/

    a.nav-link.checkSignature {
        color: #63e853;
    }

    h5 {
        color: #419936;
    }

    .isDisabled {
        opacity: 0.5;
        text-decoration: none;
        pointer-events: none;
    }
</style>


<div id=""modDialog"" class=""modal fade"">
    <div id=""dialogContent"" class=""modal-dialog""></div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3527619ca92638d5579a626bad959ad6dd2ce26d8081", async() => {
                WriteLiteral(@"

    <br />

    <div class=""row"">
        <div class=""col-sm-1""></div>
        <div class=""col-sm-10"">
            <h5 сlass=""action-link"" id=""getAccess"">1. Получить доступ к почтовому ящику</h5>
        </div>
        <div class=""col-sm-1""></div>
    </div>

    <br />


    <div class=""row"">
        <div class=""col-sm-1""></div>
        <label class=""col-sm-3 col-form-label"" style=""color: #ffffffbf;"">Адрес gmail: </label>
        <div class=""col-sm-7"">
            <input name=""receiverEmail"" rows=""6"" cols=""33"" type=""email"" class=""form-control"" style=""color: white; background: #45a23a85;""");
                BeginWriteAttribute("value", " value=\"", 1683, "\"", 1713, 1);
#nullable restore
#line 71 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
WriteAttributeValue("", 1691, ViewBag.ReceiverEmail, 1691, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        </div>
        <div class=""col-sm-1""></div>
    </div>

    <br />


    <div class=""row"">
        <div class=""col-sm-1""></div>
        <label class=""col-sm-3 col-form-label"" style=""color: #ffffffbf;"">Пароль приложения для доступа к почте: </label>
        <div class=""col-sm-7"">
            <input name=""applicationPassword"" rows=""6"" cols=""33"" type=""text"" class=""form-control"" style=""color: white; background: #45a23a85;""");
                BeginWriteAttribute("value", " value=\"", 2160, "\"", 2196, 1);
#nullable restore
#line 83 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
WriteAttributeValue("", 2168, ViewBag.ApplicationPassword, 2168, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        </div>
        <div class=""col-sm-1""></div>
    </div>

    <br />
    <br />

    <div class=""row"">
        <div class=""col-sm-6""></div>
        <div class=""col-sm-2"">
            <button type=""submit"" class=""btn btn-outline-success checkAccess"">Проверить</button>
        </div>
        <div class=""col-sm-4""></div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-1\"></div>\r\n    <div class=\"col-sm-10\">\r\n        <h5 class=\"isDisabled\" id=\"getMessage\">2. Прочитать сообщение</h5>\r\n    </div>\r\n    <div class=\"col-sm-1\"></div>\r\n</div>\r\n\r\n<br />\r\n\r\n\r\n\r\n");
#nullable restore
#line 117 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
  
    if (@ViewBag.StatusAccess == "accessAllowed")
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3527619ca92638d5579a626bad959ad6dd2ce26d12828", async() => {
                WriteLiteral(@"
            <p>

                <br />

                <div class=""form-group row"">
                    <div class=""col-sm-1""></div>
                    <label class=""col-sm-3 col-form-label"" style=""color: #ffffffbf;"">Тема сообщения</label>
                    <div class=""col-sm-7"">
                        <input class=""form-control"" style=""color: white; background: #45a23a57;"" type=""text"" name=""subject""");
                BeginWriteAttribute("value", " value=\"", 3375, "\"", 3399, 1);
#nullable restore
#line 130 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
WriteAttributeValue("", 3383, ViewBag.Subject, 3383, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <div class=""col-sm-1""></div>
                </div>

                <div class=""form-group row"">
                    <div class=""col-sm-1""></div>
                    <label class=""col-sm-3 col-form-label"" style=""color: #ffffffbf;"">Отправитель</label>
                    <div class=""col-sm-7"">
                        <input class=""form-control"" style=""color: white; background: #45a23a57;"" type=""email"" name=""email""");
                BeginWriteAttribute("value", " value=\"", 3877, "\"", 3899, 1);
#nullable restore
#line 139 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
WriteAttributeValue("", 3885, ViewBag.Email, 3885, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <div class=""col-sm-1""></div>
                </div>

                <div class=""form-group row"">
                    <div class=""col-sm-1""></div>
                    <label class=""col-sm-3 col-form-label"" style=""color: #ffffffbf;"">Дата</label>
                    <div class=""col-sm-7"">
                        <input class=""form-control"" style=""color: white; background: #45a23a57;"" type=""date"" name=""date""");
                BeginWriteAttribute("value", " value=\"", 4368, "\"", 4389, 1);
#nullable restore
#line 148 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
WriteAttributeValue("", 4376, ViewBag.Date, 4376, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <div class=""col-sm-1""></div>
                </div>

                <br />

                <div class=""form-group row"">
                    <div class=""col-sm-1""></div>
                    <label class=""col-sm-3 col-form-label"" style=""color: #ffffffbf;"">Текст сообщения</label>
                    <div class=""col-sm-7"">
                        <textarea name=""textMessage"" style=""color: white; background: #45a23a57;"" rows=""6"" cols=""33"" type=""text"" class=""form-control"">");
#nullable restore
#line 159 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
                                                                                                                                                 Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                    </div>\r\n                    <div class=\"col-sm-1\"></div>\r\n                </div>\r\n\r\n                <br />\r\n\r\n                <input name=\"applicationPassword\" hidden");
                BeginWriteAttribute("value", " value=\"", 5140, "\"", 5176, 1);
#nullable restore
#line 166 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
WriteAttributeValue("", 5148, ViewBag.ApplicationPassword, 5148, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input name=\"receiverEmail\" hidden");
                BeginWriteAttribute("value", " value=\"", 5232, "\"", 5262, 1);
#nullable restore
#line 167 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
WriteAttributeValue("", 5240, ViewBag.ReceiverEmail, 5240, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                <div class=""row"">
                    <div class=""col-sm-6""></div>
                    <div class=""col-sm-2"">
                        <button type=""submit"" class=""btn btn-outline-success"">Проверить ЭЦП</button>
                    </div>
                    <div class=""col-sm-4""></div>
                </div>

                <br />
                <br />

                <div class=""row"">

                    <div class=""col-sm-6""></div>

                    <div class=""col-sm-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3527619ca92638d5579a626bad959ad6dd2ce26d18196", async() => {
                    WriteLiteral("&lArr;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-receiverEmail", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
                                        WriteLiteral(ViewBag.ReceiverEmail);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["receiverEmail"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-receiverEmail", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["receiverEmail"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
                                                                                               WriteLiteral(ViewBag.ApplicationPassword);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["applicationPassword"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-applicationPassword", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["applicationPassword"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-statusOfChangingMessage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["statusOfChangingMessage"] = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-1\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3527619ca92638d5579a626bad959ad6dd2ce26d22532", async() => {
                    WriteLiteral("&rArr;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-receiverEmail", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 191 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
                                        WriteLiteral(ViewBag.ReceiverEmail);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["receiverEmail"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-receiverEmail", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["receiverEmail"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 191 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
                                                                                               WriteLiteral(ViewBag.ApplicationPassword);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["applicationPassword"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-applicationPassword", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["applicationPassword"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-statusOfChangingMessage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["statusOfChangingMessage"] = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-4\"></div>\r\n\r\n                </div>\r\n\r\n\r\n");
#nullable restore
#line 199 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
                 if (ViewBag.StatusOfCheckSignature != "success" && ViewBag.StatusOfChangingMessage != "prev" && ViewBag.StatusOfChangingMessage != "next")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <script type=""text/javascript"">
                        $.get(this.href, function () {
                            $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Сообщение</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Статус:</dt> <dd>Доступ разрешен</dd> </dl> </div> </div>');
                            $('#modDialog').modal('show');
                        });

                    </script>
");
#nullable restore
#line 208 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 210 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
           Write(ViewBag.StatusOfChangingMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" = """";

                <script type=""text/javascript"">
                    getAccess = document.getElementById(""getAccess"");
                    getAccess.classList.add('isDisabled');

                    getMessage = document.getElementById(""getMessage"");
                    getMessage.classList.remove('isDisabled');

                </script>

            </p>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 224 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"

    }


    else if (@ViewBag.StatusAccess == "accessDenied")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"">
            $.get(this.href, function () {
                $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Сообщение</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Результат:</dt> <dd>Сооединение с почтовым сервером не установлено. Проверьте правильность введенных данных.</dd> </dl> </div> </div>');
                $('#modDialog').modal('show');
            });
        </script>
");
#nullable restore
#line 236 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
    }

    if (@ViewBag.StatusOfCheckSignature == "success")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"">
            $.get(this.href, function () {
                $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Сообщение</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Статус:</dt> <dd>ЭЦП отправителя верная</dd> </dl> </div> </div>');
                $('#modDialog').modal('show');
            });
        </script>
");
#nullable restore
#line 246 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
    }

    else if (@ViewBag.StatusOfCheckSignature == "error")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"">
            $.get(this.href, function () {
                $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Сообщение</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Статус:</dt> <dd>ЭЦП отправителя не верная</dd> </dl> </div> </div>');
                $('#modDialog').modal('show');
            });
        </script>
");
#nullable restore
#line 256 "C:\Users\Oleg\source\repos\CryptLab1WebAppMVC\Views\Home\GetMessagePage.cshtml"
    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $.ajaxSetup({ cache: false });
            $("".checkAccess"").click(function (e) {
                let getMailFormAccess = document.forms.getMailFormAccess;

                let receiverEmail = getMailFormAccess.elements.receiverEmail.value;
                let applicationPassword = getMailFormAccess.elements.applicationPassword.value;

                if (receiverEmail == """") {
                    e.preventDefault();
                    $.get(this.href, function () {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Почтовый адрес не указан</dd> </dl> </div> </div>');
                        $('#modDialog').modal('show');
                    });
                }
                else if (applicationPasswo");
                WriteLiteral(@"rd == """") {
                    e.preventDefault();
                    $.get(this.href, function () {
                        $('#dialogContent').html('<div class=""modal-content""> <div class=""modal-header""><h4>Ошибка</h4><button class=""close"" data-dismiss=""modal"" area-hidden=""true"">x</button></div><div class=""modal-body""> <dl class=""dl-horizontal""> <dt>Ошибка:</dt> <dd>Пароль приложения пустой</dd> </dl> </div> </div>');
                        $('#modDialog').modal('show');
                    });
                }
            });
        })
    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
