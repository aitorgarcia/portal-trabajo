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
    using Empleador;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Empleador/IndexEmpleador.cshtml")]
    public partial class _Views_Empleador_IndexEmpleador_cshtml : System.Web.Mvc.WebViewPage<Core.Empleador.Empleador>
    {
        public _Views_Empleador_IndexEmpleador_cshtml()
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

WriteAttribute("src", Tuple.Create(" src=\"", 361), Tuple.Create("\"", 407)
, Tuple.Create(Tuple.Create("", 367), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts")
, 367), false)
, Tuple.Create(Tuple.Create(" ", 376), Tuple.Create("propios/empleadorController.js", 377), true)
);

WriteLiteral("></script>\r\n\r\n<div");

WriteLiteral(" ng-app=\"app\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" ng-controller=\"EmpleadorController\"");

WriteLiteral(" data-ng-init=\"ObtenerDatosEmpleadorModel()\"");

WriteLiteral(" class=\"demo\"");

WriteLiteral(" style=\"width:auto\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"titulo\"");

WriteLiteral(">\r\n                <br><br><br>\r\n                <h3>Hola <span");

WriteLiteral(" style=\"color:#428bca\"");

WriteLiteral("><b>{{dataEmpModel.Usuario}}</b></span> esta es tu página de <b>empleador</b>.</h" +
"3><br><br>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\r\n                <!-- TABS ################-->\r\n                <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" class=\"nav nav-pills nav-justified well well-sm\"");

WriteLiteral(">\r\n                        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(" style=\"\"");

WriteLiteral("><a");

WriteLiteral(" data-toggle=\"pill\"");

WriteLiteral(" href=\"#misdatos\"");

WriteLiteral(">Mis datos</a></li>\r\n                        <li><a");

WriteLiteral(" data-toggle=\"pill\"");

WriteLiteral(" href=\"#misOfertas\"");

WriteLiteral(">Mis ofertas</a></li>\r\n                    </ul>\r\n\r\n                    <div");

WriteLiteral(" class=\"tab-content well well-sm\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"misdatos\"");

WriteLiteral(" class=\"tab-pane fade in active\"");

WriteLiteral(">\r\n                            <br />\r\n                            <div");

WriteLiteral(" class=\"panel\"");

WriteLiteral(" style=\"border-color: #428bca;\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(" style=\"background-color:#428bca\"");

WriteLiteral("><b");

WriteLiteral(" style=\"color:white\"");

WriteLiteral(">Datos de usuario:</b></div>\r\n                                <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(" style=\"padding-top:0; padding-bottom:0\"");

WriteLiteral(">\r\n                                    <ul");

WriteLiteral(" class=\"list-group row\"");

WriteLiteral(" style=\"margin-bottom:0;\"");

WriteLiteral(">\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Usuario:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.Usuario}}</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Nombre:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.Nombre}}</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Primer apellido:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.Apellido1}}</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Segundo apellido:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.Apellido2}}</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Tipo de usuario:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" ng-if=\"dataEmpModel.TipoUsuario == 0\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Empleador</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" ng-if=\"dataEmpModel.TipoUsuario == 1\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Demandante</li>\r\n                                    </ul>\r\n                    " +
"            </div>\r\n                            </div>\r\n\r\n                      " +
"      <div");

WriteLiteral(" class=\"panel\"");

WriteLiteral(" style=\"border-color: #428bca;\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(" style=\"background-color:#428bca\"");

WriteLiteral("><b");

WriteLiteral(" style=\"color:white\"");

WriteLiteral(">Datos de empleador:</b></div>\r\n                                <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(" style=\"padding-top:0; padding-bottom:0\"");

WriteLiteral(">\r\n\r\n                                    <ul");

WriteLiteral(" class=\"list-group row\"");

WriteLiteral(" style=\"margin-bottom:0\"");

WriteLiteral(">\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Nombre empresa:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.NombreEmpresa}}</li>\r\n                                        <li" +
"");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Logo de la empresa:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"min-height:45px;\"");

WriteLiteral("><img");

WriteLiteral(" data-ng-src=\"data:image/jpg;base64,{{dataEmpModel.ImagenB64}}\"");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" /></li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Dirección:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.Direccion}}</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Teléfono:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.Telefono}}</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Email:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.Email}}</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Tipo de industria:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.TipoIndustriaNombre}}</li>\r\n                                     " +
"   <li");

WriteLiteral(" class=\"list-group-item col-xs-4\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">Número de empleados:</li>\r\n                                        <li");

WriteLiteral(" class=\"list-group-item col-xs-8\"");

WriteLiteral(" style=\"height:45px;\"");

WriteLiteral(">{{dataEmpModel.NumeroEmpleados}}</li>\r\n                                    </ul>" +
"\r\n                                </div>\r\n                            </div> <!-" +
"- cierre panel -->\r\n                        </div>\r\n\r\n\r\n\r\n                      " +
"  <div");

WriteLiteral(" id=\"misOfertas\"");

WriteLiteral(" class=\"tab-pane fade\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                <br />\r\n                                <h4");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Si desea crear una nueva oferta haga click en el siguiente botón: </h4>\r\n       " +
"                         <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-info btn-block\"");

WriteLiteral(" value=\"Crear nueva oferta\"");

WriteLiteral(" id=\"btn-submit\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#modalPage\"");

WriteLiteral(" style=\"margin:auto\"");

WriteLiteral(">\r\n                                <br /><br />\r\n                            </di" +
"v>\r\n\r\n                            <div");

WriteLiteral(" class=\"tab-content well well-sm\"");

WriteLiteral(" style=\"background-color:white; padding:0\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(" style=\"padding:0\"");

WriteLiteral(">\r\n                                    <table");

WriteLiteral(" class=\"table table-striped table-bordered\"");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">\r\n                                        <thead");

WriteLiteral(" style=\"background-color:#565656; overflow:hidden\"");

WriteLiteral(">\r\n                                            <tr");

WriteLiteral(" style=\"color:white\"");

WriteLiteral(">\r\n                                                <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Título</th>\r\n                                                <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Num. Vacantes</th>\r\n                                                <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Sueldo</th>\r\n                                                <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Fecha de creación</th>\r\n                                                <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Fecha de finalización</th>\r\n                                                <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">&equiv;</th>\r\n                                            </tr>\r\n               " +
"                         </thead>\r\n                                        <tbod" +
"y>\r\n                                            <tr");

WriteLiteral(" ng-repeat=\"x in listOfertas\"");

WriteLiteral(">\r\n                                                <td");

WriteLiteral(" style=\"vertical-align:middle; margin-left:10px !important\"");

WriteLiteral(">{{x.Titulo}}</td>\r\n                                                <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">{{x.NumeroVacantes}}</td>\r\n                                                <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">{{x.Sueldo}}</td>\r\n                                                <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">{{x.FechaLanzamientoString}}</td>\r\n                                             " +
"   <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">{{x.FechaFinString}}</td>\r\n                                                <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral("><button");

WriteLiteral(" class=\"btn btn-warning\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" ng-click=\"ModalVerOferta(x)\"");

WriteLiteral(@">Ver detalles</button></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div> <!-- cierre table -->
                            </div>
                        </div>
                    </div>
                </div>
                <!-- TABS ################-->

                <!--  MODAL CREAR OFERTA  ###############################  -->
                <div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"modalPage\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"modalPage\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(" role=\"document\"");

WriteLiteral(" style=\"overflow-y: initial !important; margin-top:160px\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(" style=\"overflow: hidden\"");

WriteLiteral(">\r\n\r\n                            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(" style=\"text-align:center; background-color: #5bc0de; padding-bottom:0\"");

WriteLiteral(">\r\n                                <h4");

WriteLiteral(" class=\" modal-title\"");

WriteLiteral(" id=\"modalTitle\"");

WriteLiteral(" style=\"color:white\"");

WriteLiteral("><p>Crear nueva oferta de empleo:</p></h4>\r\n                            </div>\r\n\r" +
"\n                            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-sm-7\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <b>Título:</b><br />\r\n            " +
"                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"oferta.Titulo\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"ofertaTitulo\"");

WriteLiteral(" id=\"ofertaTitulo\"");

WriteLiteral(" required>\r\n                                        </div>\r\n                     " +
"                   <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <b>Fecha de fin:</b><br />\r\n      " +
"                                      <input");

WriteLiteral(" type=\"date\"");

WriteLiteral(" ng-model=\"oferta.FechaFin\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"fechaFin\"");

WriteLiteral(" id=\"fechaFin\"");

WriteLiteral(">\r\n                                        </div>\r\n                              " +
"      </div>\r\n                                    <div");

WriteLiteral(" class=\"col-sm-5\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <b>Número de vacantes:</b><br />\r\n" +
"                                            <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" ng-model=\"oferta.NumeroVacantes\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"numeroVacantes\"");

WriteLiteral(" id=\"numeroVacantes\"");

WriteLiteral(" style=\"width:auto\"");

WriteLiteral(" required>\r\n                                        </div>\r\n                     " +
"                   <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <b>Sueldo:</b><br />\r\n            " +
"                                <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" ng-model=\"oferta.Sueldo\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"ofertaSueldo\"");

WriteLiteral(" id=\"ofertaSueldo\"");

WriteLiteral(" style=\"width:auto\"");

WriteLiteral(">\r\n                                        </div>\r\n                              " +
"      </div>\r\n                                </div>\r\n\r\n                        " +
"        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <b>Observaciones:</b><br />\r\n     " +
"                                       <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ng-model=\"oferta.Observaciones\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"observaciones\"");

WriteLiteral(" id=\"observaciones\"");

WriteLiteral(" style=\"max-width:500px;\"");

WriteLiteral(">\r\n                                        </div>\r\n                              " +
"          <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <b>Descripción:</b><br />\r\n       " +
"                                     <textarea");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" rows=\"5\"");

WriteLiteral(" id=\"ofertaDescripcion\"");

WriteLiteral(" ng-model=\"oferta.Descripcion\"");

WriteLiteral(" name=\"oferta.Descripcion\"");

WriteLiteral(" style=\"max-width:500px; margin:0 !important; margin-right:0 !important\"");

WriteLiteral(" required></textarea>\r\n                                        </div>\r\n          " +
"                          </div>\r\n                                </div>\r\n      " +
"                      </div>\r\n\r\n                            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Cancelar</button>\r\n                                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-info\"");

WriteLiteral(" ng-click=\"CrearOferta()\"");

WriteLiteral(@">Crear oferta</button>
                            </div>

                        </div>
                    </div>
                </div>
                <!-- ################################ -->

                
                <!--  MODAL VER DETALLE MI OFERTA  ###############################  -->
                <div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"modalVerOferta\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"modalTitle\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(" role=\"document\"");

WriteLiteral(" style=\"overflow-y: initial !important; width:1000px\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(" style=\"overflow: hidden\"");

WriteLiteral(">\r\n\r\n                            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(" style=\"text-align:center; background-color:#f0ad4e; padding-bottom:0\"");

WriteLiteral(">\r\n                                <h4");

WriteLiteral(" class=\" modal-title\"");

WriteLiteral(" id=\"modalTitle\"");

WriteLiteral(" style=\"color:white\"");

WriteLiteral(">Detalles de la oferta de empleo:</h4>\r\n                            </div>\r\n\r\n   " +
"                         <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(" style=\"max-height: calc(100vh - 200px) !important; overflow-y: auto !important;\"" +
"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <h3><b>{{ofertaDetalle.Titulo}}</b" +
"></h3>\r\n                                            <p");

WriteLiteral(" style=\"text-align:justify\"");

WriteLiteral(">{{ofertaDetalle.Descripcion}}</p>\r\n                                        </div" +
">\r\n                                    </div>\r\n                                <" +
"/div>\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                            <br />\r\n                          " +
"                  <b>Observaciones:</b><br />\r\n                                 " +
"           <p");

WriteLiteral(" style=\"text-align:justify\"");

WriteLiteral(">{{ofertaDetalle.Observaciones}}</p>\r\n                                        </d" +
"iv>\r\n                                    </div>\r\n                               " +
" </div>\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"margin:auto\"");

WriteLiteral(">\r\n                                    <hr />\r\n                                  " +
"  <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <p");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Disponibilidad:</p>\r\n                                        <p");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral("><span><b>{{ofertaDetalle.FechaLanzamientoString}}</b></span> - <span><b>{{oferta" +
"Detalle.FechaFinString}}</b></span></p><br />\r\n                                 " +
"   </div>\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">\r\n                                        <b");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">{{ofertaDetalle.NumeroVacantes}}   </b>   <i");

WriteLiteral(" class=\"glyphicon glyphicon-user\"");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral("></i><br />\r\n                                    </div>\r\n                        " +
"            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">\r\n                                        <b");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(@">  {{ofertaDetalle.Sueldo}} €</b><br />
                                    </div>
                                </div>
                                <hr /><br />

                                <b>Lista de demandantes de empleo inscritos en la oferta:</b><br /><br />
                                <div");

WriteLiteral(" class=\"tab-content well well-sm\"");

WriteLiteral(" style=\"padding:0\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(" style=\"padding:0\"");

WriteLiteral(">\r\n                                        <table");

WriteLiteral(" class=\"table table-striped table-bordered\"");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">\r\n                                            <thead");

WriteLiteral(" style=\"background-color:#565656; overflow:hidden\"");

WriteLiteral(">\r\n                                                <tr");

WriteLiteral(" style=\"color:white\"");

WriteLiteral(">\r\n                                                    <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Nombre completo</th>\r\n                                                    <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Teléfono</th>\r\n                                                    <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Estudios</th>\r\n                                                    <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Experiencia laboral</th>\r\n                                                    <t" +
"h");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">CV</th>\r\n                                                    <th");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">Acciones</th>\r\n                                                </tr>\r\n          " +
"                                  </thead>\r\n                                    " +
"        <tbody>\r\n                                                <tr");

WriteLiteral(" ng-repeat=\"x in listInscritos\"");

WriteLiteral(">\r\n                                                    <td");

WriteLiteral(" style=\"vertical-align:middle; margin-left:10px !important\"");

WriteLiteral(">{{x.NombreUsuario}} {{x.Apellido1}} {{x.Apellido2}}</td>\r\n                      " +
"                              <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">{{x.Telefono}}</td>\r\n                                                    <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">{{x.Nombre}}</td>\r\n                                                    <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">{{x.ExperienciaLaboral}}</td>\r\n                                                 " +
"   <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral("><button");

WriteLiteral(" class=\"btn btn-warning\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" ng-click=\"\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-download-alt\"");

WriteLiteral("></span></button></td>\r\n                                                    <td");

WriteLiteral(" style=\"vertical-align:middle\"");

WriteLiteral(">\r\n                                                        <button");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" ng-click=\"CambiarEstado(x,2)\"");

WriteLiteral(">Aceptar</button>\r\n                                                        <butto" +
"n");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" ng-click=\"CambiarEstado(x,1)\"");

WriteLiteral(@">Rechazar</button>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div> <!-- cierre table -->
                                </div>


                            </div>

                            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Atrás</button>\r\n                            </div>\r\n                        </di" +
"v>\r\n                    </div>\r\n                </div>\r\n                <!-- ###" +
"############################# -->\r\n\r\n\r\n            </div>\r\n        </form>\r\n    " +
"</div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
