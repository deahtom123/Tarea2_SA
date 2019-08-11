
#Se realizan las importaciones de el webserver a usar
#En este caso se utilizara flask
from flask import Flask, request, Response
#Se importa requets para poder hacer peticiones a otras rutas desde el webserver
import requests
#Se crea una nueva aplicacion y se le coloco el nombre
app = Flask("Servicio_Cliente")


@app.route("/")
def hello():
	return requests.get('http://127.0.0.1:5001/a').text+"Se pudo"
@app.route("/a")
def hellf():
	return "1"

#Este comando es para que este webserver corra en localhost en el puerto 5001
if __name__ == "__main__":
  app.run(debug=True, host='0.0.0.0', port=5001)