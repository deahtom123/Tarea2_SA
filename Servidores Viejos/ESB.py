
#Se realizan las importaciones de el webserver a usar
#En este caso se utilizara flask
from flask import Flask, request, Response
#Se importa requets para poder hacer peticiones a otras rutas desde el webserver
import requests
#Se crea una nueva aplicacion y se le coloco el nombre
app = Flask("ESB")

#Esta es una peticion get y sera para solicitar al microservicio de pilotos una respuesta si hay pilotos disponibles
@app.route("/SolicitarPiloto")
def hello():
	#Se realiza un try cada vez que se realiza una peticion por si el servidor tiene un problema
	try:
		return requests.get('http://127.0.0.1:5002/RealizarSolicitud').text
	except:
		return "No es posible conectarse con el servidor de pilotos"

#Esta es una peticion get y sera para solicitar al microservicio de rastreo una coordenada random en este ejemplo
@app.route("/SolicitarUbicacionPiloto")
def hellf():
	#Se realiza un try cada vez que se realiza una peticion por si el servidor tiene un problema
	try:
		return "El pilto se encuentra en las coordenadas " +requests.get('http://127.0.0.1:5003/SolicitarUbicacionPiloto').text
	except:
		return "No es posible conectarse con el servidor de rastreo"
#Este comando es para que este webserver corra en localhost en el puerto 5000
if __name__ == "__main__":
  app.run(debug=True, host='0.0.0.0', port=5000)