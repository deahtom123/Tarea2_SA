# Tarea2_SA
Esta tarea tendra como puntos aprender a Choreography / Orchestration | ESB con el uso de BPEL

En el siguiente proyecto se utilizaron 3 webserver simulando microservicios y un BPEL para hacer uso del ESB. Los 4 webserver seran cliente/servidor y estan implementados en asp.net.

Los webserver utilizan SOAP. Los WSDL se incluyen en la carpeta WSDL.

Los siguientes puertos seran utilizados:
BPEL 8080
Cliente 5001
Piloto 5002
Rastreador 5003

El flujo de la aplicacion para solicitar piloto:

-El usuario ingresa a la url en el puerto 5001 y a la ruta /Solicitar piloto

-Esta peticion es enviada al ESB que se enuentra en el 8080

-El ESB envia una peticion al servidor de pilotos

-El servidor de pilotos le responde al ESB

-El ESB le responde al usuario


El flujo de la aplicacion para solicitar Ubicacion del piloto:

-El usuario ingresa a la url en el puerto 5001 y a la ruta /SolicitarUbicacion

-Esta peticion es enviada al ESB que se enuentra en el 8080

-El ESB envia una peticion al servidor de rastreo

-El servidor de rastreo le responde al ESB

-El ESB le responde al usuario