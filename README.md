# Tarea2_SA
Esta tarea tendra como puntos aprender a Choreography / Orchestration | ESB

En el siguiente proyecto se utilizaron 4 webserver, 3 de ellos simulando microservicios y uno simulando un ESB. Los 4 webserver seran cliente/servidor y estan implementados en python utilizando flask.

Los siguientes puertos seran utilizados:
ESB 5000
Cliente 5001
Piloto 5002
Rastreador 5003

El flujo de la aplicacion para solicitar piloto:

-El usuario ingresa a la url en el puerto 5001 y a la ruta /Solicitar piloto

-Esta peticion es enviada al ESB que se enuentra en el 5000 

-El ESB envia una peticion al servidor de pilotos

-El servidor de pilotos le responde al ESB

-El ESB le responde al usuario


El flujo de la aplicacion para solicitar Ubicacion del piloto:

-El usuario ingresa a la url en el puerto 5001 y a la ruta /SolicitarUbicacion

-Esta peticion es enviada al ESB que se enuentra en el 5000 

-El ESB envia una peticion al servidor de rastreo

-El servidor de rastreo le responde al ESB

-El ESB le responde al usuario