#pragma checksum "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a60b7024e3a5a5b17bbda1e58d0fc3430885ff07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60b7024e3a5a5b17bbda1e58d0fc3430885ff07", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff808fb5eb1f2bf21bc9e88acb9a6a0c43af345", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 46, true);
            WriteLiteral("\r\n<!--Strona z informacjami o grze.-->\r\n\r\n<h2>");
            EndContext();
            BeginContext(88, 17, false);
#line 7 "C:\Users\Milosz\Desktop\Projekty\C#\Medieval Students Server Site\zadanie\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 822, true);
            WriteLiteral(@"</h2>
<div id=""about-text"">
    <p class=""info"">
        This is a simple server site created as an enlargement
        to my game: ""Medieval Students"" created in C #. The server is
        connected with the game so you could check your game statistic
        with the same nickname, you use in the game (projects share files by Azure, 
        server site data is always one start up behind the game).
        You could also create an account with new nick, the statistic will not
        show anything then, but later every game with this nickname would be
        assigned to that account. You could send 3 other POST requests.
        First is for registration, second for logging in.
        The third one allows for removing logs history.
    </p>
    <br />
    <p class=""info"">Have fun!</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
