#pragma checksum "/home/carlossantos/Descargas/Primer-proyecto-2/MVC_Proyect/Views/Job/ScreenPrincipalView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d7c2e0edaca332bbdd3f3f14293c9a951b020d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_ScreenPrincipalView), @"mvc.1.0.view", @"/Views/Job/ScreenPrincipalView.cshtml")]
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
#line 1 "/home/carlossantos/Descargas/Primer-proyecto-2/MVC_Proyect/Views/_ViewImports.cshtml"
using MVC_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/carlossantos/Descargas/Primer-proyecto-2/MVC_Proyect/Views/_ViewImports.cshtml"
using MVC_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d7c2e0edaca332bbdd3f3f14293c9a951b020d", @"/Views/Job/ScreenPrincipalView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0376ac7c0a4dcdad7f1752c4de57466186a6cb4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_ScreenPrincipalView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CSStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/carlossantos/Descargas/Primer-proyecto-2/MVC_Proyect/Views/Job/ScreenPrincipalView.cshtml"
  
    ViewData["Title"] = "ScreenPrincipalView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49d7c2e0edaca332bbdd3f3f14293c9a951b020d5073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

 <main>
        <section class=""landing"">
            <h1>
                <b>Encuentra el empleo</b> 
                <br> &nbsp&nbspque siempres has estado <br> 
                <span class=""landing-buscando"">   Buscando </span></h1>

            <img src=""img/landing.svg"" alt=""landing"" width=""400px"">
        </section>

        <section class=""search-job"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d7c2e0edaca332bbdd3f3f14293c9a951b020d6557", async() => {
                WriteLiteral("\n                <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 531, "\"", 538, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 539, "\"", 544, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nombre del Empleo\" >\n\n                <select");
                BeginWriteAttribute("name", " name=\"", 604, "\"", 611, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 612, "\"", 617, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d7c2e0edaca332bbdd3f3f14293c9a951b020d7445", async() => {
                    WriteLiteral("Ubicacion del Empleo ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                   <input type=\"submit\" value=\"Buscar empleo\" class=\"btn-search\">\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        
        <section class=""recent-job"">
            <h2 class=""recent-job-title"">Ofertas de empleos recientes:</h2>
            <div class=""container"">
            <div class=""job-list"">
<div class=""job"">
    <div class=""job-header"">
        <img src=""https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png""");
            BeginWriteAttribute("alt", " alt=\"", 1153, "\"", 1159, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1328, "\"", 1334, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1437, "\"", 1443, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 1800, "\"", 1807, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <!--Solo de ejemplo, borrar cuando haya datos reales-->\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2060, "\"", 2066, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 2235, "\"", 2241, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 2344, "\"", 2350, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 2707, "\"", 2714, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2908, "\"", 2914, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3083, "\"", 3089, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3192, "\"", 3198, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 3555, "\"", 3562, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3756, "\"", 3762, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3931, "\"", 3937, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4040, "\"", 4046, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 4403, "\"", 4410, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4604, "\"", 4610, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4779, "\"", 4785, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4888, "\"", 4894, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 5251, "\"", 5258, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5452, "\"", 5458, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 5627, "\"", 5633, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 5736, "\"", 5742, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 6099, "\"", 6106, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n<!--Hasta aca-->\n</div>\n</div>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 6181, "\"", 6188, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-job-more\">Ver mas ofertas de empleos</a>\n        </section>\n    </main>");
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
