#pragma checksum "/home/carlossantos/Descargas/Primer-proyecto-4/MVC_Proyect/Views/Job/ScreenPrincipalView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64597dbd6728b424b0b8de46cbf9951339690584"
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
#line 1 "/home/carlossantos/Descargas/Primer-proyecto-4/MVC_Proyect/Views/_ViewImports.cshtml"
using MVC_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/carlossantos/Descargas/Primer-proyecto-4/MVC_Proyect/Views/_ViewImports.cshtml"
using MVC_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64597dbd6728b424b0b8de46cbf9951339690584", @"/Views/Job/ScreenPrincipalView.cshtml")]
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
#line 1 "/home/carlossantos/Descargas/Primer-proyecto-4/MVC_Proyect/Views/Job/ScreenPrincipalView.cshtml"
  
    ViewData["Title"] = "ScreenPrincipalView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64597dbd6728b424b0b8de46cbf99513396905845073", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64597dbd6728b424b0b8de46cbf99513396905846558", async() => {
                WriteLiteral("\n                <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 532, "\"", 539, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 540, "\"", 545, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nombre del Empleo\" >\n\n                <select");
                BeginWriteAttribute("name", " name=\"", 605, "\"", 612, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 613, "\"", 618, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64597dbd6728b424b0b8de46cbf99513396905847446", async() => {
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
            BeginWriteAttribute("alt", " alt=\"", 1154, "\"", 1160, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1329, "\"", 1335, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1438, "\"", 1444, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 1801, "\"", 1808, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <!--Solo de ejemplo, borrar cuando haya datos reales-->\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2061, "\"", 2067, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 2236, "\"", 2242, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 2345, "\"", 2351, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 2708, "\"", 2715, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2909, "\"", 2915, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3084, "\"", 3090, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3193, "\"", 3199, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 3556, "\"", 3563, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3757, "\"", 3763, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3932, "\"", 3938, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4041, "\"", 4047, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 4404, "\"", 4411, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4605, "\"", 4611, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4780, "\"", 4786, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4889, "\"", 4895, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 5252, "\"", 5259, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n   <div class=\"job\">\n    <div class=\"job-header\">\n        <img src=\"https://rotulosmatesanz.com/wp-content/uploads/2017/09/2000px-Google_G_Logo.svg_.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5453, "\"", 5459, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"90px\">\n        \n        <div>\n           <br>\n            <h2>Programador Web Experto en Angular</h2>\n            <br> <br>\n            <img src=\"img/place.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 5628, "\"", 5634, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"18px\"><p>&nbsp;Santo Domingo&nbsp;&nbsp;&nbsp;&nbsp;</p>\n            <img src=\"img/dollar.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 5737, "\"", 5743, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""18px""> <p>60,000</p>
        </div>
    </div>

    <div class=""job-body"">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ad rem ab exercitationem? Maxime molestias dicta accusantium libero inventore ab fugfffffffffffffffffffa quasi, laborum, amet harum voluptatum fugiat ducimus nihil aperiam corporis!</p>
    </div>

    <a");
            BeginWriteAttribute("href", " href=\"", 6100, "\"", 6107, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"job-end\">Aplicar</a>\n\n   </div>\n<!--Hasta aca-->\n</div>\n</div>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 6182, "\"", 6189, 0);
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
