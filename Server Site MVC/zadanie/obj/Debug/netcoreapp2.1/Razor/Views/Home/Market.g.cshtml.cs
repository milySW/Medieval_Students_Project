#pragma checksum "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a0461f587376b0e427c069ccd431fce6e3ba5a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Market), @"mvc.1.0.view", @"/Views/Home/Market.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Market.cshtml", typeof(AspNetCore.Views_Home_Market))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0461f587376b0e427c069ccd431fce6e3ba5a1", @"/Views/Home/Market.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff808fb5eb1f2bf21bc9e88acb9a6a0c43af345", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Market : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CharacterViewModel>>
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
#line 2 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
  
    ViewData["Title"] = "Market";

#line default
#line hidden
            BeginContext(75, 55, true);
            WriteLiteral("<!--Strona umożliwiająca zakup skina do postaci.-->\r\n\r\n");
            EndContext();
            BeginContext(130, 3938, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edada1944fe540fb884e13fff1f901b1", async() => {
                BeginContext(156, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
     using (Html.BeginForm("Market", "Home", FormMethod.Post))
    {
        

#line default
#line hidden
                BeginContext(238, 23, false);
#line 10 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(263, 171, true);
                WriteLiteral("        <h1 id=\"titleText\">Market</h1>\r\n        <section class=\"charactersSection\">\r\n            <!--Kontener na zdjęcia postaci.-->\r\n            <div class=\"container\">\r\n");
                EndContext();
#line 15 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                  
                    var loopCounter = 0;
                    var pass = 0;
                    List<int> listOfCosts = new List<int> { 2000, 2100, 1900, 2200, 2400, 1800 };
                    List<int> listOfSkins = new List<int> {0, 0, 0, 0, 0, 0};

                    

#line default
#line hidden
#line 21 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                     if (ViewBag.CurrentUser == true)
                    {
                        string query = @"SELECT * FROM CharacterSkins WHERE PlayerID = (SELECT ID FROM AvailablePoints WHERE AvailablePoints.Nick = '" + @ViewBag.UserName.ToLower() + "')";
                        using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HPD9G79T; database=MedievalStudents; Trusted_Connection=yes"))
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        listOfSkins[0] = Int32.Parse(reader[1].ToString());
                                        listOfSkins[1] = Int32.Parse(reader[2].ToString());
                                        listOfSkins[2] = Int32.Parse(reader[3].ToString());
                                        listOfSkins[3] = Int32.Parse(reader[4].ToString());
                                        listOfSkins[4] = Int32.Parse(reader[5].ToString());
                                        listOfSkins[5] = Int32.Parse(reader[6].ToString());
                                    }

                                    reader.Close();

                                }
                                connection.Close();
                            }
                        }
                    }

#line default
#line hidden
#line 47 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                     
                    
                    foreach (var character in Model)
                    {
                        

#line default
#line hidden
#line 51 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                         if (loopCounter % 2 == 1)
                        {

#line default
#line hidden
                BeginContext(2564, 146, true);
                WriteLiteral("                            <!--Kontener na postać zajmującą 1/3 strony przy max. rozmiarze.-->\r\n                <div class=\"col-sm-6 col-md-6\">\r\n");
                EndContext();
#line 55 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                     if (listOfSkins[pass] == 0)
                    {

#line default
#line hidden
                BeginContext(2783, 50, true);
                WriteLiteral("                        <img class=\"skin-for-sale\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2833, "\"", 2868, 1);
#line 57 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
WriteAttributeValue("", 2839, Url.Content(character.Photo), 2839, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2869, "\"", 2900, 1);
#line 57 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
WriteAttributeValue("", 2875, character.CharacterClass, 2875, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2901, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 58 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(2978, 28, true);
                WriteLiteral("                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3006, "\"", 3041, 1);
#line 61 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
WriteAttributeValue("", 3012, Url.Content(character.Photo), 3012, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3042, "\"", 3073, 1);
#line 61 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
WriteAttributeValue("", 3048, character.CharacterClass, 3048, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3074, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 62 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                    }

#line default
#line hidden
                BeginContext(3102, 50, true);
                WriteLiteral("                    <h3>\r\n                        ");
                EndContext();
                BeginContext(3153, 24, false);
#line 64 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                   Write(character.CharacterClass);

#line default
#line hidden
                EndContext();
                BeginContext(3177, 29, true);
                WriteLiteral("\r\n                    </h3>\r\n");
                EndContext();
#line 66 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                     if (ViewBag.CurrentUser == true && listOfSkins[pass] == 0)
                    {

#line default
#line hidden
                BeginContext(3310, 109, true);
                WriteLiteral("                        <div id=\"market-button\">\r\n                            <input type=\"submit\" name=\"com\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3419, "\"", 3465, 4);
                WriteAttributeValue("", 3427, "Purchase", 3427, 8, true);
                WriteAttributeValue(" ", 3435, "for", 3436, 4, true);
#line 69 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
WriteAttributeValue(" ", 3439, listOfCosts[pass], 3440, 18, false);

#line default
#line hidden
                WriteAttributeValue(" ", 3458, "points", 3459, 7, true);
                EndWriteAttribute();
                BeginContext(3466, 61, true);
                WriteLiteral(" class=\"btn btn-success\" />\r\n                        </div>\r\n");
                EndContext();
#line 71 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                    }
                    else if (ViewBag.CurrentUser == true)
                    {

#line default
#line hidden
                BeginContext(3632, 188, true);
                WriteLiteral("                        <div id=\"market-button\">\r\n                            <input type=\"submit\" name=\"com\" value=\"Purchased\" class=\"btn btn-success\" />\r\n                        </div>\r\n");
                EndContext();
#line 77 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                    }

#line default
#line hidden
                BeginContext(3843, 24, true);
                WriteLiteral("                </div>\r\n");
                EndContext();
#line 79 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                            pass++;
                        }

#line default
#line hidden
#line 80 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
                         
                        loopCounter++;
                    }
                

#line default
#line hidden
                BeginContext(4013, 40, true);
                WriteLiteral("            </div>\r\n        </section>\r\n");
                EndContext();
#line 86 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\Market.cshtml"
     }

#line default
#line hidden
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
            BeginContext(4068, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CharacterViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
