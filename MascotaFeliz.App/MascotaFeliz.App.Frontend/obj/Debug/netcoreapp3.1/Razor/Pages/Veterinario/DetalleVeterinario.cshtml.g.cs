#pragma checksum "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinario\DetalleVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d184eaa8f8fcccb405029f9587aca526f0d0aebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinario.Pages_Veterinario_DetalleVeterinario), @"mvc.1.0.razor-page", @"/Pages/Veterinario/DetalleVeterinario.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinario
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
#line 1 "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d184eaa8f8fcccb405029f9587aca526f0d0aebf", @"/Pages/Veterinario/DetalleVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinario_DetalleVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-new"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Veterinario/listaVeterinario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-duenoId", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container1\">\r\n    <div class=\"card\">\r\n        <div class=\"titlecard\">\r\n            <h1>Detalle ");
#nullable restore
#line 34 "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinario\DetalleVeterinario.cshtml"
                   Write(Model.veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"content\">\r\n            <div class=\"details\">\r\n                <i class=\"fa-solid fa-user-nurse\"></i>\r\n                Nombre: ");
#nullable restore
#line 40 "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinario\DetalleVeterinario.cshtml"
                   Write(Model.veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"details\">\r\n                <i class=\"fa-solid fa-user-nurse\"></i>\r\n                Apellidos: ");
#nullable restore
#line 45 "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinario\DetalleVeterinario.cshtml"
                      Write(Model.veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"details\">\r\n                <i class=\"fa-solid fa-user-nurse\"></i>\r\n                Direccion: ");
#nullable restore
#line 50 "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinario\DetalleVeterinario.cshtml"
                      Write(Model.veterinario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"details\">\r\n                <i class=\"fa-solid fa-user-nurse\"></i>\r\n                Telefono: ");
#nullable restore
#line 55 "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinario\DetalleVeterinario.cshtml"
                     Write(Model.veterinario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"details\">\r\n                <i class=\"fa-solid fa-user-nurse\"></i>\r\n                Tarjeta Profesional: ");
#nullable restore
#line 60 "C:\Users\Usuario\Documents\GitHub\G-32-E7\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinario\DetalleVeterinario.cshtml"
                                Write(Model.veterinario.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"volverbtn\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d184eaa8f8fcccb405029f9587aca526f0d0aebf6948", async() => {
                WriteLiteral("volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-duenoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["duenoId"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetalleVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetalleVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetalleVeterinarioModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetalleVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
