using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio_Rastreador
{
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Servicio_Rastreador : System.Web.Services.WebService
    {
        //En esta ruta se obtiene la ubicacion del piloto
        [WebMethod]
        public string SolicitarUbicacionPiloto(String nombre)
        {
            return "Ubicacion Piloto: 300,200";
        }
    }
}
