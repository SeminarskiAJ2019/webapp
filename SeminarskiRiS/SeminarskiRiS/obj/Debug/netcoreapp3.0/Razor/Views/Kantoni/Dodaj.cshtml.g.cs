#pragma checksum "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Kantoni\Dodaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0b3f1bdae0b3dcb824d86f0b16a800ea0e13a5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kantoni_Dodaj), @"mvc.1.0.view", @"/Views/Kantoni/Dodaj.cshtml")]
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
#line 1 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\_ViewImports.cshtml"
using SeminarskiRS1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\_ViewImports.cshtml"
using SeminarskiRS1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0b3f1bdae0b3dcb824d86f0b16a800ea0e13a5d", @"/Views/Kantoni/Dodaj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082ec30d1e17a3aa5abc3d4e5f3ede043c9de0f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Kantoni_Dodaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeminarskiRS1.ViewModels.Kantoni.KantonUrediVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Kantoni/Dodaj"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Kantoni\Dodaj.cshtml"
  

    ViewData["Title"] = "Dodaj";
    var kantoni = (List<Kanton>)ViewData["kantoni-kljuc"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Dodaj</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0b3f1bdae0b3dcb824d86f0b16a800ea0e13a5d3893", async() => {
                WriteLiteral("\r\n    <label>Unesite ime kantona:</label>\r\n    ");
#nullable restore
#line 11 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Kantoni\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.NazivKantonta, new { autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    <label>Unesite skracenicu za kanton</label>\r\n    ");
#nullable restore
#line 13 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Kantoni\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.Skracenica, new { autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n    <label>Odaberite drzavu</label>\r\n    ");
#nullable restore
#line 16 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Kantoni\Dodaj.cshtml"
Write(Html.DropDownListFor(s => s.DrzavaID, Model.drzave));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    \r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeminarskiRS1.ViewModels.Kantoni.KantonUrediVM> Html { get; private set; }
    }
}
#pragma warning restore 1591