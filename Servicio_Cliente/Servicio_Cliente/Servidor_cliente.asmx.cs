using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Xml;
using System.Web.Services;

namespace Servicio_Cliente
{
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Servidor_cliente : System.Web.Services.WebService
    {
        //Ruta para solicitar un piloto
        [WebMethod]
        public string Solicitar_Piloto(String nombre)
        {
            String mensaje = InvokeService(
                   @"http://localhost:8080/ode/processes/Cliente_Piloto"
                , @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:q0=""http://ClientePiloto.localhost"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" >
              <soapenv:Header>   
            </soapenv:Header>  
              <soapenv:Body>  
                <q0:Cliente_PilotoRequest>
                            <q0:input>" + "juan" + @"</q0:input>
                </q0:Cliente_PilotoRequest>
               </soapenv:Body>  
            </soapenv:Envelope>");
            return "Respuesta Mensaje: "+ mensaje;
        }
        //ruta para solicitar Ubicacion
        [WebMethod]
        public string Solicitar_Ubicacion(String ubicacon)
        {
            String mensaje = InvokeService(
                   @"http://localhost:8080/ode/processes/Cliente_Rastreador"
                , @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:q0=""http://clienterastreador.localhost"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" >
              <soapenv:Header>   
            </soapenv:Header>  
              <soapenv:Body>  
                <q0:Cliente_RastreadorRequest>
                            <q0:input>" + "juan" + @"</q0:input>
                </q0:Cliente_RastreadorRequest>
               </soapenv:Body>  
            </soapenv:Envelope>");
            return "Respuesta Mensaje: " + mensaje;
        }

        public static String InvokeService(String Endpoint,String xmlContent)
        {
            //Calling CreateSOAPWebRequest method    
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Endpoint);
            request.Method = "POST";
            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request    
            SOAPReqBody.LoadXml(xmlContent);
            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }
            //Geting response from request    
            System.Diagnostics.Debug.WriteLine(request.ToString());
            try
            {
                using (WebResponse Serviceres = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                    {
                        //reading stream    
                        var ServiceResult = rd.ReadToEnd();
                        //writting stream result on console    
                        System.Diagnostics.Debug.WriteLine(ServiceResult);
                        System.Diagnostics.Debug.WriteLine("--------------------");
                        return ServiceResult;
                    }
                }
            }
            catch (WebException wex)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("ERROR:" + wex.Message + ". STATUS: " + wex.Status.ToString());

                if (wex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ((HttpWebResponse)wex.Response);
                    sb.AppendLine(string.Format("Status Code : {0}", response.StatusCode));
                    sb.AppendLine(string.Format("Status Description : {0}", response.StatusDescription));

                    try
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        sb.AppendLine(reader.ReadToEnd());
                    }
                    catch (WebException ex) { throw; }
                }

                throw new Exception(sb.ToString(), wex);
            }
            catch (Exception ex) { throw; }
        }
    }
}