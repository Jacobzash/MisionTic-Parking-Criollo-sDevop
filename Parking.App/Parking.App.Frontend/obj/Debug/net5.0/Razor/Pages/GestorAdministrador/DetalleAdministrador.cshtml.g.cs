#pragma checksum "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2037c9b0797a2e817c8fb4f07007bdbb4d36110e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Parking.App.Frontend.Pages.GestorAdministrador.Pages_GestorAdministrador_DetalleAdministrador), @"mvc.1.0.razor-page", @"/Pages/GestorAdministrador/DetalleAdministrador.cshtml")]
namespace Parking.App.Frontend.Pages.GestorAdministrador
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
#line 1 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\_ViewImports.cshtml"
using Parking.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2037c9b0797a2e817c8fb4f07007bdbb4d36110e", @"/Pages/GestorAdministrador/DetalleAdministrador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc5182fab9718811fb5f0fab9a2a7b9acebe20c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestorAdministrador_DetalleAdministrador : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("h1>Detalle del Administrador ");
#nullable restore
#line 5 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml"
                        Write(Model.administrador.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<ul>\r\n       \r\n        <li>");
#nullable restore
#line 8 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml"
       Write(Model.administrador.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 9 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml"
       Write(Model.administrador.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 10 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml"
       Write(Model.administrador.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 11 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml"
       Write(Model.administrador.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 12 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml"
       Write(Model.administrador.Contrasena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 13 "C:\ciclo3\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorAdministrador\DetalleAdministrador.cshtml"
       Write(Model.administrador.Fecha_nacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    \r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parking.App.Frontend.DetalleAdministradorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Parking.App.Frontend.DetalleAdministradorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Parking.App.Frontend.DetalleAdministradorModel>)PageContext?.ViewData;
        public Parking.App.Frontend.DetalleAdministradorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591