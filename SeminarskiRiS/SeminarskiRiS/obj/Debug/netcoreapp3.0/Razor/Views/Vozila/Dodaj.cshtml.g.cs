#pragma checksum "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2948777064c7a47647d9cef9156ec093f9ffafc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vozila_Dodaj), @"mvc.1.0.view", @"/Views/Vozila/Dodaj.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2948777064c7a47647d9cef9156ec093f9ffafc", @"/Views/Vozila/Dodaj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082ec30d1e17a3aa5abc3d4e5f3ede043c9de0f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Vozila_Dodaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeminarskiRS1.ViewModels.VoziloUrediVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Vozila/Dodaj"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
  
    ViewData["Title"] = "Dodaj";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dodaj</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2948777064c7a47647d9cef9156ec093f9ffafc3816", async() => {
                WriteLiteral("\r\n    <label>Unesite tip vozila:</label>\r\n    ");
#nullable restore
#line 9 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.Tip));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite marku vozila:</label>\r\n    ");
#nullable restore
#line 12 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.Marka));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite model vozila:</label>\r\n    ");
#nullable restore
#line 15 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite KS vozila:</label>\r\n    ");
#nullable restore
#line 18 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.KS));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite potrosnju vozila:</label>\r\n    ");
#nullable restore
#line 21 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.Potrosnja));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite registraciju vozila:</label>\r\n    ");
#nullable restore
#line 24 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.Registracija));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite datum vazenja registracije vozila:</label>\r\n    ");
#nullable restore
#line 27 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.VazenjeRegistracije));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite masu vozila:</label>\r\n    ");
#nullable restore
#line 30 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.Masa));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite zapreminu motora vozila:</label>\r\n    ");
#nullable restore
#line 33 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.ZapreminaMotora));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <label>Unesite godinu proizvodnje vozila:</label>\r\n    ");
#nullable restore
#line 36 "C:\Users\Josip\Desktop\SeminarskiRiS\SeminarskiRiS\Views\Vozila\Dodaj.cshtml"
Write(Html.TextBoxFor(s => s.GodinaProizvodnje));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeminarskiRS1.ViewModels.VoziloUrediVM> Html { get; private set; }
    }
}
#pragma warning restore 1591