#pragma checksum "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f69b09243b5b3925593ac9d31d7f64bf19bf59d0"
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
#line 1 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/_ViewImports.cshtml"
using MVC_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/_ViewImports.cshtml"
using MVC_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f69b09243b5b3925593ac9d31d7f64bf19bf59d0", @"/Views/Acceso/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0376ac7c0a4dcdad7f1752c4de57466186a6cb4b", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
Write(Html.Raw(TempData["Notificacion"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f69b09243b5b3925593ac9d31d7f64bf19bf59d05582", async() => {
                WriteLiteral("\n    <title>Registro</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f69b09243b5b3925593ac9d31d7f64bf19bf59d05869", async() => {
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
                WriteLiteral("\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f69b09243b5b3925593ac9d31d7f64bf19bf59d07807", async() => {
                WriteLiteral("\n\n    <div class=\"container\">\n\n        <main>\n\n            <section class=\"img-side\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f69b09243b5b3925593ac9d31d7f64bf19bf59d08172", async() => {
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
#line 38 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                     using (Html.BeginForm("Register", "Acceso", FormMethod.Post))
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-text-piece\">\n                            <div>\n                                <label>Nombre</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n                                ");
#nullable restore
#line 44 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Nombre, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            ");
#nullable restore
#line 46 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Nombre, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\n                            <div>\n                                <label>Apellido</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n                                ");
#nullable restore
#line 52 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Apellido, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            ");
#nullable restore
#line 54 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Apellido, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\n                            <div>\n                                <label>Email personal</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n                                ");
#nullable restore
#line 60 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Email, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            ");
#nullable restore
#line 62 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Email, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\n                            <div>\n                                <label>Email de empresa</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n                                ");
#nullable restore
#line 68 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Email_emp, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            ");
#nullable restore
#line 70 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Email_emp, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\n                            <label>URL empresa <span class=\"sugerencia\">&nbsp;&nbsp;&nbsp;(opcional)</span></label>\n                            <div>\n                                ");
#nullable restore
#line 76 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.TextBoxFor(u => u.Url, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\n                            </div>\n                        </div>\n");
                WriteLiteral("                        <div class=\"form-text-piece\">\n                            <div>\n                                <label>Telefono</label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n                                ");
#nullable restore
#line 83 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Telefono, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            ");
#nullable restore
#line 85 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Telefono, string.Empty, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\n                        </div>\n");
                WriteLiteral(@"                        <div class=""form-text-piece"">
                            <div>
                                <label>Nombre de Usuario <span class=""sugerencia"">&nbsp;&nbsp;(recordar)</label> &nbsp;&nbsp;&nbsp;&nbsp;
                                ");
#nullable restore
#line 91 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Username, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            ");
#nullable restore
#line 93 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Username, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\n                        </div>\n");
                WriteLiteral(@"                        <div class=""form-text-piece"">
                            <div>
                                <label>Contraseña <span class=""sugerencia"">&nbsp;&nbsp;&nbsp;(recordar)</label> &nbsp;&nbsp;&nbsp;&nbsp;
                                ");
#nullable restore
#line 99 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                           Write(Html.ValidationMessageFor(n => n.Contraseña, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            ");
#nullable restore
#line 101 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                       Write(Html.TextBoxFor(u => u.Contraseña, null, new { Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\n                        </div>\n                        <input type=\"text\" name=\"Rol\" value=\"Poster\" hidden=\"hidden\"> ");
#nullable restore
#line 103 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                                                                                      //Rol por defecto del usuario que se registra (no cambiar) !

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\n                            <button type=\"submit\" id=\"registrarse-btn\">Listo</button>\n                        </div>\n");
#nullable restore
#line 107 "/home/carlossantos/Descargas/Primer-proyecto-5/MVC_Proyect/Views/Acceso/Register.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n\n            </section>\n\n        </main>\n\n    </div>\n\n");
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
            WriteLiteral("\n");
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
