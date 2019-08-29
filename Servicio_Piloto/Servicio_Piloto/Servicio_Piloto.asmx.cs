using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio_Piloto
{
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Servicio_Piloto : System.Web.Services.WebService
    {
        //Esta ruta es cuando se quiera Solicitar un Piloto
        [WebMethod]
        public string RealizarSolicitud(String nombre)
        {
            return "Respuesta exitosa";
        }
    }
}
