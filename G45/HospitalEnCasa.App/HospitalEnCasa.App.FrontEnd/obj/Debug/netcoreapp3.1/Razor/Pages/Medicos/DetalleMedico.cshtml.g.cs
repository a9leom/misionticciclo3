#pragma checksum "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Medicos\DetalleMedico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d31f8d1d86abdd5d17b08a430a3227bb53421c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospitalEnCasa.App.FrontEnd.Pages.Medicos.Pages_Medicos_DetalleMedico), @"mvc.1.0.razor-page", @"/Pages/Medicos/DetalleMedico.cshtml")]
namespace HospitalEnCasa.App.FrontEnd.Pages.Medicos
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
#line 1 "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospitalEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d31f8d1d86abdd5d17b08a430a3227bb53421c9d", @"/Pages/Medicos/DetalleMedico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25a7f304fab7aebbaeb1984a1516c1f0bdafad1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medicos_DetalleMedico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle médico</h1>\r\n<ul>\r\n    <li>Cedula: ");
#nullable restore
#line 7 "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Medicos\DetalleMedico.cshtml"
           Write(Model.medico.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Nombre: ");
#nullable restore
#line 8 "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Medicos\DetalleMedico.cshtml"
           Write(Model.medico.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Genero: ");
#nullable restore
#line 9 "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Medicos\DetalleMedico.cshtml"
           Write(Model.medico.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Edad: ");
#nullable restore
#line 10 "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Medicos\DetalleMedico.cshtml"
         Write(Model.medico.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Hospital: ");
#nullable restore
#line 11 "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Medicos\DetalleMedico.cshtml"
             Write(Model.medico.nombre_hospital);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Tarjeta profesional: ");
#nullable restore
#line 12 "D:\mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Medicos\DetalleMedico.cshtml"
                        Write(Model.medico.tarjeta_profesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetalleMedicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleMedicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleMedicoModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetalleMedicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
