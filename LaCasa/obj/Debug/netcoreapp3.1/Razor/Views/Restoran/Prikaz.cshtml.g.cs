#pragma checksum "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73d776ebbbc065d877d51786f00d834aa0d56229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restoran_Prikaz), @"mvc.1.0.view", @"/Views/Restoran/Prikaz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73d776ebbbc065d877d51786f00d834aa0d56229", @"/Views/Restoran/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf0cb7e49e0da3ab7136b6758cf2d5f1880888a", @"/Views/_ViewImports.cshtml")]
    public class Views_Restoran_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestoranPrikazVM>
    {
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
#line 3 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
   
    ViewData["Title"] = "Prikaz";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Prikaz</h1>\r\n<a href=\"/Restoran/Dodaj\" class=\"btn btn-primary\">Dodaj Restoran</a>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73d776ebbbc065d877d51786f00d834aa0d562293572", async() => {
                WriteLiteral("\r\n    <input name=\"q\"");
                BeginWriteAttribute("value", " value=\"", 190, "\"", 206, 1);
#nullable restore
#line 12 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
WriteAttributeValue("", 198, Model.q, 198, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"submit\" value=\"Trazi\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>Naziv</th>
            <th>Adresa</th>
            <th>Broj telefona</th>
            <th>Radno vrijeme</th>
            <th>Tip kuhinje</th>
            <th>Akcija</th>
            <th>Recenzije</th>
            
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
         foreach (RestoranPrikazVM.Row r in Model.restorani)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
               Write(r.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 34 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
               Write(r.Adresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
               Write(r.Brojtelefona);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
               Write(r.RadnoVrijeme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
               Write(r.TipKuhinje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 954, "\"", 1002, 2);
            WriteAttributeValue("", 961, "/Restoran/Obrisi?RestoranID=", 961, 28, true);
#nullable restore
#line 39 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
WriteAttributeValue("", 989, r.RestoranID, 989, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> Obrisi </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1063, "\"", 1110, 2);
            WriteAttributeValue("", 1070, "/Restoran/Dodaj?RestoranID=", 1070, 27, true);
#nullable restore
#line 40 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
WriteAttributeValue("", 1097, r.RestoranID, 1097, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"> Uredi </a>\r\n\r\n                </td>\r\n                <td>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1223, "\"", 1264, 3);
            WriteAttributeValue("", 1233, "PrikaziRecenzije(", 1233, 17, true);
#nullable restore
#line 44 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
WriteAttributeValue("", 1250, r.RestoranID, 1250, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1263, ")", 1263, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"> Prikazi </button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\isadz\OneDrive\Desktop\LaCasa - Copy\LaCasa\Views\Restoran\Prikaz.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""ajaxPrikaz"" style=""border:1px solid black""></div>

<script>
    function PrikaziRecenzije(RestoranID) {
        var url = ""/Recenzija/Prikaz?RestoranID="" + RestoranID;
        $.get(url, function (d) {
            $(""#ajaxPrikaz"").html(d);
        });
    }

    function ObrisiRecenziju(RecenzijaID) {
        var url = ""/Recenzija/Obrisi?RecenzijaID="" + RecenzijaID;
        $.get(url, function (d) {
            alert(""Uspjesno obrisana recenzija"");
            $(""#ajaxPrikaz"").html(d);
        });
    }
    function DodajRecenziju(RestoranID) {
        var url = ""/Recenzija/Dodaj?RestoranID="" + RestoranID;
        $.get(url, function (d) {
            $(""#ajaxPrikaz"").html(d);
        });
    }
    function RecenzijaSnimi() {
        var form = $(""#RecenzijaForma"");
        var url = ""/Recenzija/Snimi"";
        $.ajax({
            type: ""POST"",
            url: url,
            data: form.serialize(),
            success: function (data) {
   ");
            WriteLiteral("             $(\"#ajaxPrikaz\").html(data);\r\n            }\r\n        });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestoranPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
