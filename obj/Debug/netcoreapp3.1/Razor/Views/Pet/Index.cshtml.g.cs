#pragma checksum "E:\Csharp\MvcPet\Views\Pet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59bb355730a17fc7bf8a04b635368cd68a79b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pet_Index), @"mvc.1.0.view", @"/Views/Pet/Index.cshtml")]
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
#line 1 "E:\Csharp\MvcPet\Views\_ViewImports.cshtml"
using MvcPet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Csharp\MvcPet\Views\_ViewImports.cshtml"
using MvcPet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59bb355730a17fc7bf8a04b635368cd68a79b6a", @"/Views/Pet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9323bf682061d2109cd6ac8641ba4541887dc16", @"/Views/_ViewImports.cshtml")]
    public class Views_Pet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MvcPet.Models.Pet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("animal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
  
  ViewData["Title"] = "Doações (" + Model.Count() + ")";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
	function showCreatedInput(){
		var input = document.getElementById('created-input');
		var useCreated = document.getElementById('useCreated');

		if (useCreated.value == ""0"") {
			input.style.visibility = 'visible';
			useCreated.value = ""1"";
		}
		else {
			input.style.visibility = ""hidden"";
			useCreated.value = ""0"";
		}
	}
</script>

");
#nullable restore
#line 23 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
  
	string text = "Animais";
	if (!String.IsNullOrEmpty(ViewBag.animal)) {
		text += ": " + ViewBag.animal + " ";
	}
	if (!String.IsNullOrEmpty(ViewBag.uf)) {
		text += "- UF: " + ViewBag.uf + " ";
	} 
	if (!String.IsNullOrEmpty(ViewBag.created)) {
		text += "- Cadastrado em: " + ViewBag.created;
	}
	text += " para doação";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<h2>");
#nullable restore
#line 35 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
   Write(text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral(@"
<hr>

<p>
  <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapse-filter"" role=""button"" aria-expanded=""false"" aria-controls=""collapse-filter"">Filtros</a>
</p>
<div class=""row"">
  <div class=""col"">
    <div class=""collapse multi-collapse"" id=""collapse-filter"">
      <div class=""card"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59bb355730a17fc7bf8a04b635368cd68a79b6a8550", async() => {
                WriteLiteral(@"
					<div style=""display:flex; flex-direction: row; justify-content: space-between;"">

						<div class=""card-body"">
							<h5>Filtrar por classe Animal</h5>
							<div style=""display:flex; flex-direction: row;"">
								<select name=""animal"" class=""form-control"" style=""max-width: max-content; margin-right: 10px;"">
									");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59bb355730a17fc7bf8a04b635368cd68a79b6a9153", async() => {
                    WriteLiteral("Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                     foreach (Animalclass an in ViewBag.Animals)
									{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59bb355730a17fc7bf8a04b635368cd68a79b6a10645", async() => {
#nullable restore
#line 57 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                                          Write(an.name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                           WriteLiteral(an.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\t\t\r\n");
#nullable restore
#line 58 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"								</select>
							</div>
						</div>

						<div class=""card-body"">
							<h5>Filtrar por Estado de Cadastro</h5>
							<div style=""display:flex; flex-direction: row;"">
								<select name=""uf"" class=""form-control"" style=""max-width: max-content; margin-right: 10px;"">
									");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59bb355730a17fc7bf8a04b635368cd68a79b6a12934", async() => {
                    WriteLiteral("Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 68 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                     foreach (UF uf in ViewBag.Ufs)
									{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59bb355730a17fc7bf8a04b635368cd68a79b6a14414", async() => {
#nullable restore
#line 70 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                                             Write(uf.sigla);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 70 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                                                         Write(uf.nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                           WriteLiteral(uf.sigla);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\t\t\r\n");
#nullable restore
#line 71 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"								</select>
							</div>
						</div>

						<div class=""card-body"">
							<a onclick=""showCreatedInput();"" href=""#"">Filtrar por data de Cadastro</a>
							<input type=""hidden"" name=""useCreated"" id=""useCreated"" value=""0"">
							<div id=""created-input"" style=""visibility: hidden; margin-top: 3px;"">
");
#nullable restore
#line 80 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                  
									string date = DateTime.Today.ToString().Split(' ')[0];

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t<input name=\"created\" type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 2597, "\"", 2610, 1);
#nullable restore
#line 82 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
WriteAttributeValue("", 2605, date, 2605, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral(@"							</div>
						</div>

					</div>
					<div style=""margin-bottom: 10px; display:flex; align-items: center; justify-content: center;"">
						<button type=""submit"" class=""btn btn-outline-primary"" style=""width: 200px;"">Filtrar</button>
					</div>
				");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n<hr>\r\n\r\n<div class=\"grid-container\">\r\n");
#nullable restore
#line 101 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
     if (@Model.Count() < 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"card card-body\">\r\n\t\t\t<h4>Nenhum Pet encontrado</h4>\r\n\t\t</div>\r\n");
#nullable restore
#line 105 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
	}else
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"grid-item\">\r\n\t\t\t<div class=\"card\">\r\n\t\t\t\t<h5 class=\"card-header\">");
#nullable restore
#line 109 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                   Write(item.species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t<h4 style=\"font-weight:bold;\">");
#nullable restore
#line 112 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                             Write(item.breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t<p class=\"card-text\" style=\"color: #7f7f7f; max-lines:1;\"> ");
#nullable restore
#line 113 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                                                          Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@". </p>

					<p>
						<a class=""btn btn-outline-primary"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
							Preview do Pet - Imagem
						</a>
					</p>
					<div class=""collapse"" id=""collapseExample"">
						<div class=""card card-body"">
							<img");
            BeginWriteAttribute("src", " src=\"", 3722, "\"", 3739, 1);
#nullable restore
#line 122 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
WriteAttributeValue("", 3728, item.image, 3728, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3740, "\"", 3746, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" height=\"100px\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3788, "\"", 3806, 1);
#nullable restore
#line 123 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
WriteAttributeValue("", 3795, item.image, 3795, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Visualizar em tamanho real</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<p class=\"card-text\" style=\"color: #7f7f7f;\">\r\n\t\t\t\t\t\tCadastrado em ");
#nullable restore
#line 128 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                 Write(item.created.ToString().Split(" ")[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t");
#nullable restore
#line 130 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                   Write(item.uf);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 130 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                              Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59bb355730a17fc7bf8a04b635368cd68a79b6a23111", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f59bb355730a17fc7bf8a04b635368cd68a79b6a23382", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 134 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.donor.userId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\t\t\t\t\t\t<button type=\"submit\" style=\"background-color: #FFF; border-width: 0px; color:#4f7fbb;\">");
#nullable restore
#line 136 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                                                                                           Write(item.donor.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t<p style=\"color: #7f7f7f;\">\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t</p>\r\n\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59bb355730a17fc7bf8a04b635368cd68a79b6a27462", async() => {
                WriteLiteral("Mais informações");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
                                              WriteLiteral(item.petId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t<br>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 148 "E:\Csharp\MvcPet\Views\Pet\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MvcPet.Models.Pet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
