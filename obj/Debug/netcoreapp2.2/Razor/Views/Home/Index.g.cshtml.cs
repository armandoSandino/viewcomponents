#pragma checksum "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9db3326b4000c2021ed12d0e42a3f593acee377"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\_ViewImports.cshtml"
using ViewComponents;

#line default
#line hidden
#line 2 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\_ViewImports.cshtml"
using ViewComponents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9db3326b4000c2021ed12d0e42a3f593acee377", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c490ac13d1e8ceca3fa2c17b0705202a4dd8289d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ViewComponents.Models.Casa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(45, 76, true);
            WriteLiteral("<!--con esto le diremos a nuestra vista que reciba un modelo de datos-->\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Mira lo que la gente dice de nosotros";

#line default
#line hidden
            BeginContext(194, 98, true);
            WriteLiteral("<br/>\r\n<h1>Todas las casas disponibles para venta o alquiler</h1>\r\n<br/>\r\n<div class=\"row mt-2\">\r\n");
            EndContext();
#line 13 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml"
 for(int i=0; i < Model.Count; i++)
{

#line default
#line hidden
            BeginContext(333, 35, false);
#line 15 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml"
Write(Html.DisplayFor(model => model[i] ));

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml"
                                    
}

#line default
#line hidden
            BeginContext(373, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("LateralIzquierdo", async() => {
                BeginContext(409, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 21 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml"
 if(ViewBag.ID  != 0)
{
    

#line default
#line hidden
                BeginContext(444, 75, false);
#line 23 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("DetalleCasa", 
    new { id = @ViewBag.ID } ));

#line default
#line hidden
                EndContext();
#line 24 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\ViewComponents\Views\Home\Index.cshtml"
                              
}

#line default
#line hidden
                BeginContext(524, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(529, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("LateralDerecho", async() => {
                BeginContext(556, 225, true);
                WriteLiteral("\r\n\r\n    <h5>Sorftweb LABs y Sarah Solutions</h5>\r\n    <p>Empresas Nicaragüense que fortalecen lazos en la innovación y desarrollo tecnológico a gran escala,\r\n    para aportar al crecimiento del país y la región.\r\n    </p>\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ViewComponents.Models.Casa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
