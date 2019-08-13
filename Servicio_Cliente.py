
#Se realizan las importaciones de el webserver a usar
#En este caso se utilizara flask
from flask import Flask, request, Response
#Se importa requets para poder hacer peticiones a otras rutas desde el webserver
import requests
#Se crea una nueva aplicacion y se le coloco el nombre
app = Flask("Servicio_Cliente")

#Esta es una peticion get y sera para solicitar al ESB una respuesta si hay pilotos disponibles
@app.route("/SolicitarPiloto")
def hello():
	#Se realiza un try cada vez que se realiza una peticion por si el servidor tiene un problema
	try:
		respuesta=requests.get('http://127.0.0.1:5000/SolicitarPiloto').text
		if respuesta=="1": 
			return "Solicitud de piloto realizada con exito"
		elif respuesta=="0":
			return "No existen pilotos disponibles"
		else:
			return respuesta;
	except:
		return "No es posible conectarse al orquestador"

#Esta es una peticion get y sera para solicitar al ESB la ubicacion del piloto
@app.route("/SolicitarUbicacion")
def hellof():
	#Se realiza un try cada vez que se realiza una peticion por si el servidor tiene un problema
	try:
		return requests.get('http://127.0.0.1:5000/SolicitarUbicacionPiloto').text
	except:
		return "No es posible conectarse al orquestador"

#Este comando es para que este webserver corra en localhost en el puerto 5001
if __name__ == "__main__":
  app.run(debug=True, host='0.0.0.0', port=5001)