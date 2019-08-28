using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio_Piloto
{
    /// <summary>
    /// Descripción breve de Servicio_Piloto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicio_Piloto : System.Web.Services.WebService
    {

        [WebMethod]
        public string RealizarSolicitud()
        {
            return "Respuesta exitosa";
        }
    }
}
