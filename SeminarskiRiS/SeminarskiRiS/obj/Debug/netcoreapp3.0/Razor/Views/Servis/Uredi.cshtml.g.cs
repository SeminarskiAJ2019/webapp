#pragma checksum "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3b50a9f7d870b7b5c375c43c2f222b7bf53af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servis_Uredi), @"mvc.1.0.view", @"/Views/Servis/Uredi.cshtml")]
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
#line 1 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
using SeminarskiRS1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3b50a9f7d870b7b5c375c43c2f222b7bf53af1", @"/Views/Servis/Uredi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082ec30d1e17a3aa5abc3d4e5f3ede043c9de0f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Servis_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeminarskiRS1.ViewModels.Servisi.ServisUrediVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Servis/Snimi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
  
    ViewData["Title"] = "Uredi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Uredi</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea3b50a9f7d870b7b5c375c43c2f222b7bf53af14123", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
Write(Html.HiddenFor(s => s.ServisID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <label>Lokacija Map</label>\r\n    ");
#nullable restore
#line 13 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
Write(Html.TextBoxFor(s => s.LokacijaMap));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Opis</label>\r\n    ");
#nullable restore
#line 16 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
Write(Html.TextBoxFor(s => s.Opis));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Radno Vrijeme</label>\r\n    ");
#nullable restore
#line 19 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
Write(Html.TextBoxFor(s => s.RadnoVrijeme));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Usluge</label>\r\n    ");
#nullable restore
#line 22 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
Write(Html.TextBoxFor(s => s.Usluge));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Grad</label>\r\n    ");
#nullable restore
#line 25 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Servis\Uredi.cshtml"
Write(Html.DropDownListFor(s => s.GradID, Model.gradovi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <input type=\"submit\" value=\"Snimi\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeminarskiRS1.ViewModels.Servisi.ServisUrediVM> Html { get; private set; }
    }
}
#pragma warning restore 1591