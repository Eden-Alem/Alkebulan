#pragma checksum "/home/edenalem/Documents/Es Sachen/C#/Datien/Views/Home/HealthIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b3ed84f27854a9e7a660b74cba51de247349e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HealthIndex), @"mvc.1.0.view", @"/Views/Home/HealthIndex.cshtml")]
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
#line 1 "/home/edenalem/Documents/Es Sachen/C#/Datien/Views/_ViewImports.cshtml"
using Datien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/edenalem/Documents/Es Sachen/C#/Datien/Views/_ViewImports.cshtml"
using Datien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b3ed84f27854a9e7a660b74cba51de247349e7c", @"/Views/Home/HealthIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5144f4f7ab1e61a129132e5ca992dc4672f02024", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HealthIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Datien.Models.HealthInstitution>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/edenalem/Documents/Es Sachen/C#/Datien/Views/Home/HealthIndex.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "/home/edenalem/Documents/Es Sachen/C#/Datien/Views/Home/HealthIndex.cshtml"
  Layout="../Shared/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Main -->
<div id=""main"" class=""wrapper style1"">
    <div class=""container"">
        <header class=""major"">
            <h2>Health Institute</h2>
            <p>Good Health and Well being in Africa</p>
        </header>

        <!-- Text -->
            <section>

                <blockquote>Please situate your sit at the place of your institution while filling in these data. Thank you for taking an initiative as an institution to help contribute on reliable data availability. Become a change-maker and help represent your country. It starts with you!</blockquote>
                
            </section>

        <!-- Form -->
            <section>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3ed84f27854a9e7a660b74cba51de247349e7c4963", async() => {
                WriteLiteral("\r\n                    <div class=\"row gtr-uniform gtr-50\">\r\n                        <div class=\"col-6 col-12-xsmall\">\r\n                            <input type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1052, "\"", 1060, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Institution Name\" />\r\n                        </div>\r\n                        <div class=\"col-6 col-12-xsmall\">\r\n                            <input type=\"email\" name=\"email\" id=\"email\"");
                BeginWriteAttribute("value", " value=\"", 1259, "\"", 1267, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Full Name\" />\r\n                        </div>\r\n                        <div class=\"col-6 col-12\">\r\n                            <input type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1449, "\"", 1457, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Type of the healthcare facility (Eg - Clinic and medical office, Hospital, Birth Center"" />
                        </div>
                        <div class=""col-6 col-12"">
                            <label>Legal Certificate</label>
                            <input type=""file"" name=""name"" id=""name""");
                BeginWriteAttribute("value", " value=\"", 1779, "\"", 1787, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Legal Certificate\" />\r\n                        </div>\r\n                        <div class=\"col-6 col-12\">\r\n                            <input type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1977, "\"", 1985, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Country\" />\r\n                        </div>\r\n                        <div class=\"col-6 col-12-xsmall\">\r\n                            <input type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2172, "\"", 2180, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Number of Healthcare Specialists\" />\r\n                        </div>\r\n                        <div class=\"col-6 col-12-xsmall\">\r\n                            <input type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2392, "\"", 2400, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Number of Health Equipments\" />\r\n                        </div>\r\n                         <div class=\"col-6 col-12\">\r\n                            <input type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2601, "\"", 2609, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Daily Average Patients (In Numbers)"" />
                        </div>

                        <div class=""col-6 col-12"">
                            <input style=""width: 100%;"" type=""submit"" value=""Submit Response"" class=""primary"" /></li>                           
                        </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </section>\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Datien.Models.HealthInstitution>> Html { get; private set; }
    }
}
#pragma warning restore 1591
