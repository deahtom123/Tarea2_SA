#Se realizan las importaciones de el webserver a usar
#En este caso se utilizara flask
from flask import Flask, request, Response
#Se importa requests para poder hacer peticiones a otras rutas desde el webserver
import requests
#Se importa random para dar respuestas
from random import randint
#Se crea una nueva aplicacion y se le coloco el nombre
app = Flask("Servicio_Piloto")

#Esta es una peticion get y sera para devolver un estado dependiendo si el piloto esta disponible o no
@app.route("/RealizarSolicitud")
def hello():
	"""Esto es para simular una respuesta de parte de los pilotos
	0 -> no hay piloto disponible
	1 -> si hay piloto disponible
	"""
	return str(randint(0,1));

#Este comando es para que este webserver corra en localhost en el puerto 5002
if __name__ == "__main__":
  app.run(debug=True, host='0.0.0.0', port=5002)