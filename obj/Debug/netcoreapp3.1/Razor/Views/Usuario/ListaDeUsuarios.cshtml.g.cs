#pragma checksum "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51aa8edd054c7142640bc67ea886e689f2eee9ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
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
#line 1 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51aa8edd054c7142640bc67ea886e689f2eee9ce", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuario cadastraods no sistema</h1>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 5 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
                 if (u.Tipo==Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 25 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padr??o</td>\r\n");
#nullable restore
#line 29 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 717, "\"", 746, 2);
            WriteAttributeValue("", 724, "editarUsuario?id=", 724, 17, true);
#nullable restore
#line 31 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 741, u.Id, 741, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a> </td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 789, "\"", 819, 2);
            WriteAttributeValue("", 796, "ExcluirUsuario?id=", 796, 18, true);
#nullable restore
#line 32 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 814, u.Id, 814, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a> </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\crist\Desktop\Pc gamer\Curso\atividade 2 uc07\Biblioteca - Copia\Views\Usuario\ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n<a href=\"RegistrarUsuarios\">Registar novo usuario</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
