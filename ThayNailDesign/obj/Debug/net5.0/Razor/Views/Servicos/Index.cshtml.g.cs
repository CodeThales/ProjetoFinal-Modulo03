#pragma checksum "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0080d18375fc54dd570c6e9e73f1d84540122ca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicos_Index), @"mvc.1.0.view", @"/Views/Servicos/Index.cshtml")]
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
#line 1 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\_ViewImports.cshtml"
using ThayNailDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\_ViewImports.cshtml"
using ThayNailDesign.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0080d18375fc54dd570c6e9e73f1d84540122ca0", @"/Views/Servicos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4432c0f54daeb70b9307644c734ecfc7b9dd3651", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Servico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mr-1 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Servicos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<h2>Lista de Serviços</h2>\r\n\r\n");
#nullable restore
#line 8 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0080d18375fc54dd570c6e9e73f1d84540122ca05658", async() => {
                WriteLiteral("Adicionar Serviço");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 14 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
 if (TempData["Adicionado"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        <p>");
#nullable restore
#line 17 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
      Write(TempData["Adicionado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 19 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
 if (TempData["Excluido"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <p>");
#nullable restore
#line 24 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
      Write(TempData["Excluido"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
 if (TempData["Atualizado"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\" role=\"alert\">\r\n        <p>");
#nullable restore
#line 31 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
      Write(TempData["Atualizado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 33 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 39 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.First().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 40 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.First().Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 41 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.First().Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 42 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.First().Duracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 48 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
         foreach (Servico servico in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 51 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
               Write(Html.DisplayFor(Model => servico.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
               Write(Html.DisplayFor(Model => servico.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
               Write(Html.DisplayFor(Model => servico.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
               Write(Html.DisplayFor(Model => servico.Duracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 56 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0080d18375fc54dd570c6e9e73f1d84540122ca014656", async() => {
                WriteLiteral("Atualizar |");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
                                                 WriteLiteral(servico.Id);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0080d18375fc54dd570c6e9e73f1d84540122ca016951", async() => {
                WriteLiteral(" Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
                                                  WriteLiteral(servico.Id);

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
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 62 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span>É necessário estar logado para executar ações.</span></td>\r\n");
#nullable restore
#line 66 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 68 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr />\r\n\r\n");
#nullable restore
#line 73 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
 if (ViewBag.totServicos != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><strong>Total de Serviços cadastrados:</strong> ");
#nullable restore
#line 75 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
                                                  Write(ViewBag.TotServicos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 76 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\Projeto Final - NailDesign\ProjetoFinal-Modulo03\ThayNailDesign\Views\Servicos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Servico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
