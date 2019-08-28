using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio_Rastreador
{
    /// <summary>
    /// Descripción breve de Servicio_Rastreador
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicio_Rastreador : System.Web.Services.WebService
    {

        [WebMethod]
        public string SolicitarUbicacionPiloto(String nombre)
        {
            return "Ubicacion Piloto";
        }
    }
}
