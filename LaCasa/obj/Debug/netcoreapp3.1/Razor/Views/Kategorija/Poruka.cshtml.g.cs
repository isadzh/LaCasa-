#pragma checksum "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Kategorija\Poruka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5f4e9c5924309aced18067f992367c59515f708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategorija_Poruka), @"mvc.1.0.view", @"/Views/Kategorija/Poruka.cshtml")]
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
#line 1 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\_ViewImports.cshtml"
using LaCasa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\_ViewImports.cshtml"
using LaCasa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f4e9c5924309aced18067f992367c59515f708", @"/Views/Kategorija/Poruka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf0cb7e49e0da3ab7136b6758cf2d5f1880888a", @"/Views/_ViewImports.cshtml")]
    public class Views_Kategorija_Poruka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Kategorija\Poruka.cshtml"
Write(TempData["PorukaInfo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Kategorija/Prikaz\"> Idi nazad</a>");
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
