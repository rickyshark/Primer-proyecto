#pragma checksum "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c066fb77817eb3e932a7ff2253a4a49b874c07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acceso_Register), @"mvc.1.0.view", @"/Views/Acceso/Register.cshtml")]
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
#line 1 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\_ViewImports.cshtml"
using MVC_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\_ViewImports.cshtml"
using MVC_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c066fb77817eb3e932a7ff2253a4a49b874c07", @"/Views/Acceso/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e391b5865f36769b656a0e83eeaa776aeaa943", @"/Views/_ViewImports.cshtml")]
    public class Views_Acceso_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario1>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Register_login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/munequita.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("second-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
Write(Html.Raw(TempData["Notificacion"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c066fb77817eb3e932a7ff2253a4a49b874c075661", async() => {
                WriteLiteral("\r\n    <title>Registro</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2c066fb77817eb3e932a7ff2253a4a49b874c075954", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c066fb77817eb3e932a7ff2253a4a49b874c077924", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n\r\n        <main>\r\n\r\n            <section class=\"img-side\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2c066fb77817eb3e932a7ff2253a4a49b874c078305", async() => {
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
                WriteLiteral(@"
            </section>

            <section class=""form-side"">

                <div class=""form-container"">

                    <header>
                        <div>
                            <h1>Regístrate</h1>
                            <p>Hazlo para ofrecer ofertas y <br /> nuevas oportunidades de empleo</p>
                        </div>

                        <div>
                            <img src=""https://image.flaticon.com/icons/png/128/3534/3534139.png"">
                        </div>
                    </header>

");
#nullable restore
#line 38 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                     using (Html.BeginForm("Register", "Acceso", FormMethod.Post))
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-text-piece\">\r\n                            <div>\r\n                                <label>Nombre</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                ");
#nullable restore
#line 44 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Nombre, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            ");
#nullable restore
#line 46 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Nombre, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\r\n                            <div>\r\n                                <label>Apellido</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                ");
#nullable restore
#line 52 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Apellido, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            ");
#nullable restore
#line 54 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Apellido, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\r\n                            <div>\r\n                                <label>Email personal</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                ");
#nullable restore
#line 60 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Email, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            ");
#nullable restore
#line 62 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Email, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\r\n                            <div>\r\n                                <label>Email de empresa</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                ");
#nullable restore
#line 68 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Email_emp, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            ");
#nullable restore
#line 70 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Email_emp, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\r\n                            <label>URL empresa <span class=\"sugerencia\">&nbsp;&nbsp;&nbsp;(opcional)</span></label>\r\n                            <div>\r\n                                ");
#nullable restore
#line 76 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.TextBoxFor(u => u.Url, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\r\n                            </div>\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\r\n                            <div>\r\n                                <label>Telefono</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                ");
#nullable restore
#line 83 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Telefono, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            ");
#nullable restore
#line 85 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Telefono, string.Empty, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\r\n                        </div>\r\n");
                WriteLiteral(@"                        <div class=""form-text-piece"">
                            <div>
                                <label>Nombre de Usuario <span class=""sugerencia"">&nbsp;&nbsp;(recordar)</label> &nbsp;&nbsp;&nbsp;&nbsp;
                                ");
#nullable restore
#line 91 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Username, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            ");
#nullable restore
#line 93 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Username, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\r\n                        </div>\r\n");
                WriteLiteral(@"                        <div class=""form-text-piece"">
                            <div>
                                <label>Contraseña <span class=""sugerencia"">&nbsp;&nbsp;&nbsp;(recordar)</label> &nbsp;&nbsp;&nbsp;&nbsp;
                                ");
#nullable restore
#line 99 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Contraseña, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            ");
#nullable restore
#line 101 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Contraseña, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\r\n                        </div>\r\n                        <input type=\"text\" name=\"Rol\" value=\"Poster\" hidden=\"hidden\"> ");
#nullable restore
#line 103 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                                                                                      //Rol por defecto del usuario que se registra (no cambiar) !

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\r\n                            <button type=\"submit\" id=\"registrarse-btn\">Listo</button>\r\n                        </div>\r\n");
#nullable restore
#line 107 "C:\Users\justi\OneDrive\Escritorio\Proyecto3\MVC_Proyect\Views\Acceso\Register.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n            </section>\r\n\r\n        </main>\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario1> Html { get; private set; }
    }
}
#pragma warning restore 1591
