#Se realizan las importaciones de el webserver a usar
#En este caso se utilizara flask
from flask import Flask, request, Response
#Se importa requets para poder hacer peticiones a otras rutas desde el webserver
import requests
#Se importa random para dar respuestas
from random import randint
#Se crea una nueva aplicacion y se le coloco el nombre
app = Flask("Servicio_Rastreador")

#Esta es una peticion get y sera para devolver una coordenada y servira para la ubicacion del piloto
@app.route("/SolicitarUbicacionPiloto")
def hello():
	"""Esto es para simular una respuesta de parte del rastreador
	se devolver una coordenada longitud, latitud
	y como ejemplo se tomara longitud y latitud como un numero de 0 a 100
	"""
	longitud = randint(0,100)
	latitud = randint(0,100)
	return str(longitud)+","+str(latitud);

#Este comando es para que este webserver corra en localhost en el puerto 5003
if __name__ == "__main__":
  app.run(debug=True, host='0.0.0.0', port=5003)