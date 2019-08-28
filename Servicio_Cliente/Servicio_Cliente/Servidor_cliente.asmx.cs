using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio_Cliente
{
    /// <summary>
    /// Descripción breve de Servidor_cliente
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servidor_cliente : System.Web.Services.WebService
    {

        [WebMethod]
        public string Solicitar_Piloto()
        {
            return "Solicitu de piloto realizada con exito";
        }
        [WebMethod]
        public string Solicitar_Ubicacion()
        {
            return "Solicitud Ubicacion realizada con exito";
        }
    }
}