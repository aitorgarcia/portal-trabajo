﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Demandante;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Demandante/PrimerAccesoDemandante.cshtml")]
    public partial class _Views_Demandante_PrimerAccesoDemandante_cshtml : System.Web.Mvc.WebViewPage<Core.Demandante.Demandante>
    {
        public _Views_Demandante_PrimerAccesoDemandante_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!-- Scripts-->\r\n<script");

WriteLiteral(" src=\"http://ajax.googleapis.com/ajax/libs/angularjs/1.3.10/angular.min.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"http://angular-ui.github.io/bootstrap/ui-bootstrap-tpls-0.13.0.min.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"https://cdnjs.cloudflare.com/ajax/libs/angular-i18n/1.5.0/angular-locale_es" +
"-es.min.js\"");

WriteLiteral("></script>\r\n\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 363), Tuple.Create("\"", 410)
, Tuple.Create(Tuple.Create("", 369), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts")
, 369), false)
, Tuple.Create(Tuple.Create(" ", 378), Tuple.Create("propios/demandanteController.js", 379), true)
);

WriteLiteral("></script>\r\n\r\n<div");

WriteLiteral(" ng-app=\"app\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" ng-controller=\"DemandanteController\"");

WriteLiteral(" data-ng-init=\"ObtenerEstudios()\"");

WriteLiteral(" class=\"demo\"");

WriteLiteral(" style=\"width:auto\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral("></div>\r\n                <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\" titulo\"");

WriteLiteral(@">
                    <br><br>
                    <h4>Esta es la <b>primera vez que accedes</b>, por favor rellena los datos siguientes para registrarte como nuevo demandante.</h4><br><br>
                </div>
                </div>
                <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral("></div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral("></div>\r\n\r\n                <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <b>Foto de perfil:</b><br />\r\n                        " +
"<input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" fileread=\"dem.ImagenB64\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"fotoPerfil\"");

WriteLiteral(" id=\"fotoPerfil\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <b>Edad:</b><br />\r\n                        <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" ng-model=\"dem.Edad\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"edad\"");

WriteLiteral(" id=\"edad\"");

WriteLiteral(" ng-model=\"edad\"");

WriteLiteral(" required>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <b>Teléfono</b> <i><small>(opcional):</small></i><br /" +
">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"dem.Telefono\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"telefono\"");

WriteLiteral(" id=\"telefono\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <b>Email</b> <i><small>(opcional):</small></i><br />\r\n" +
"                        <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" ng-model=\"dem.Email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"email\"");

WriteLiteral(" id=\"email\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <b>Perfil de Linkedin</b> <i><small>(opcional):</small" +
"></i><br />\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"dem.PerfilLinkedin\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"perfilLinkedin\"");

WriteLiteral(" id=\"perfilLinkedin\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <b>Nivel de estudios:</b><br />\r\n                     " +
"   <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" ng-model=\"dem.NivelEstudios\"");

WriteLiteral(" ng-options=\"estudio.NivelEstudios as estudio.Nombre for estudio in estudios\"");

WriteLiteral(" required>\r\n                            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(" selected disabled hidden>Selecciona uno de la lista</option>\r\n                  " +
"      </select>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <b>Experiencia laboral:</b><br />\r\n                   " +
"     <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"dem.ExperienciaLaboral\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"experienciaLaboral\"");

WriteLiteral(" id=\"experienciaLaboral\"");

WriteLiteral(" required />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <br /><br /><br />\r\n                        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-block btn-danger\"");

WriteLiteral(" value=\" Registrar demandante\"");

WriteLiteral(" id=\"btn-submit\"");

WriteLiteral(" ng-click=\"GuardarDatosDemandante()\"");

WriteLiteral(">\r\n                        <br /><br /><br />\r\n                    </div>\r\n\r\n    " +
"            </div>\r\n\r\n                <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral("></div>\r\n\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
