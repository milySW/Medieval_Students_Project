#pragma checksum "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2dde724901f74c3a257d7fc338366777be4db2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCharacterByClass), @"mvc.1.0.view", @"/Views/Home/GetCharacterByClass.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetCharacterByClass.cshtml", typeof(AspNetCore.Views_Home_GetCharacterByClass))]
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
#line 1 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\_ViewImports.cshtml"
using zadanie;

#line default
#line hidden
#line 2 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\_ViewImports.cshtml"
using zadanie.Models;

#line default
#line hidden
#line 3 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\_ViewImports.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2dde724901f74c3a257d7fc338366777be4db2", @"/Views/Home/GetCharacterByClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff808fb5eb1f2bf21bc9e88acb9a6a0c43af345", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCharacterByClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CharacterViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("charactersBody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
  
    ViewData["Title"] = "GetCharacterByClass";

#line default
#line hidden
            BeginContext(95, 44, true);
            WriteLiteral("\r\n<!--Strona z postaciami danej klasy-->\r\n\r\n");
            EndContext();
            BeginContext(139, 1940, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbff8f71627e4c7bb77ad5d4a9937309", async() => {
                BeginContext(165, 25, true);
                WriteLiteral("\r\n    <h1 id=\"titleText\">");
                EndContext();
                BeginContext(191, 40, false);
#line 9 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
                  Write(Model.FirstOrDefault().CharacterRawClass);

#line default
#line hidden
                EndContext();
                BeginContext(231, 7, true);
                WriteLiteral("</h1>\r\n");
                EndContext();
#line 10 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
       if (Model.FirstOrDefault().CharacterRawClass == "Professor of algebra")
        {

#line default
#line hidden
                BeginContext(329, 218, true);
                WriteLiteral("            <p id=\"story\">\r\n                Ancient magicians, who know how to change the behavior of the environment.\r\n                They could easily change space and avoid flood or earthquakes.\r\n            </p>\r\n");
                EndContext();
#line 16 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
        }
        else if (Model.FirstOrDefault().CharacterRawClass == "Professor of analysis")
        {

#line default
#line hidden
                BeginContext(656, 268, true);
                WriteLiteral(@"            <p id=""story"">
                Powerful magician, the terror for humanist students. Every student has to pass his
                exams to become a true craftsman. He can use his incomprehensible magic to decrease the death indicator.
            </p>
");
                EndContext();
#line 23 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(960, 421, true);
                WriteLiteral(@"            <p id=""story"">
                There were no computers in ancient times. Despite it, there were people who could
                reach or secure every place in the kingdom using magic. Every information was passed
                through them. Those cunning and bright people were known as spies or programmers.
                Very useful when you want to avoid fights or feel safety.
            </p>
");
                EndContext();
#line 32 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
        }
    

#line default
#line hidden
                BeginContext(1399, 119, true);
                WriteLiteral("    <section class=\"charactersSection\">\r\n        <!--Kontener na zdjęcia postaci.-->\r\n        <div class=\"container\">\r\n");
                EndContext();
#line 37 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
             foreach (var character in Model)
            {

#line default
#line hidden
                BeginContext(1580, 117, true);
                WriteLiteral("                <div class=\"col-sm-6 col-md-3\">\r\n                    <!--Zdjęcia postaci-->\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1697, "\"", 1732, 1);
#line 41 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
WriteAttributeValue("", 1703, Url.Content(character.Photo), 1703, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1733, "\"", 1767, 1);
#line 41 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
WriteAttributeValue("", 1739, character.CharacterRawClass, 1739, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1768, 85, true);
                WriteLiteral(" />\r\n\r\n                    <!--Wiedza postaci-->\r\n                    <h3>Knowledge: ");
                EndContext();
                BeginContext(1854, 19, false);
#line 44 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
                              Write(character.Knowledge);

#line default
#line hidden
                EndContext();
                BeginContext(1873, 98, true);
                WriteLiteral("</h3>\r\n\r\n                    <!--Energia życiowa postaci-->\r\n                    <h3>Life energy: ");
                EndContext();
                BeginContext(1972, 20, false);
#line 47 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
                                Write(character.LifeEnergy);

#line default
#line hidden
                EndContext();
                BeginContext(1992, 31, true);
                WriteLiteral("</h3>\r\n                </div>\r\n");
                EndContext();
#line 49 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\GetCharacterByClass.cshtml"
            }

#line default
#line hidden
                BeginContext(2038, 34, true);
                WriteLiteral("        </div>\r\n    </section>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CharacterViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
