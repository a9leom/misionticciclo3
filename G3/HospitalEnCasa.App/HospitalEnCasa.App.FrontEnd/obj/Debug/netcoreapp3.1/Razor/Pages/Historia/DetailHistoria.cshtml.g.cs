#pragma checksum "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6106a8be19f8fa9c9e12b2ab8d19a5586f8ef52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospitalEnCasa.App.FrontEnd.Pages.Historia.Pages_Historia_DetailHistoria), @"mvc.1.0.razor-page", @"/Pages/Historia/DetailHistoria.cshtml")]
namespace HospitalEnCasa.App.FrontEnd.Pages.Historia
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
#line 1 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospitalEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6106a8be19f8fa9c9e12b2ab8d19a5586f8ef52", @"/Pages/Historia/DetailHistoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25a7f304fab7aebbaeb1984a1516c1f0bdafad1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Historia_DetailHistoria : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle historia</h1>\r\n<h2>Paciente: ");
#nullable restore
#line 6 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
         Write(Model.historia.anotaciones[0].paciente.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<p>A continuación podrá ver las anotaciones del paciente</p>
<table class=""table"">
    <tr>
        <th>Fecha</th>
        <th>Médico</th>
        <th>Enfermera</th>
        <th>Nivel de azucar</th>
        <th>Presión</th>
        <th>Pulso cardiaco</th>
        <th>Observacion</th>
    </tr>
");
#nullable restore
#line 18 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
     foreach(var anotacion in @Model.historia.anotaciones){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
           Write(anotacion.fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
           Write(anotacion.medico.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
           Write(anotacion.enfermera.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
           Write(anotacion.signoVital.nivel_azucar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
           Write(anotacion.signoVital.presion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
           Write(anotacion.signoVital.pulso_cardiaco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
           Write(anotacion.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "D:\Mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Historia\DetailHistoria.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalEnCasa.App.FrontEnd.Pages.DetailHistoriaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.Pages.DetailHistoriaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.Pages.DetailHistoriaModel>)PageContext?.ViewData;
        public HospitalEnCasa.App.FrontEnd.Pages.DetailHistoriaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
