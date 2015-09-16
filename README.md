Angular-WebApi
=========
Concepto de usabilidad de WebApi .net con AngularJS

Principalmente se encuentra centrado en el POST hacia la WebApi, ya que sin las modificaciones necesarias en el global.asax y en el web.config, posiblemente nos de un error 405

global.asax
-----------
protected void Application_BeginRequest(object sender, EventArgs e)

web.config
----------
<add name="Access-Control-Allow-Origin" value="*" />
<add name="Access-Control-Allow-Headers" value="Content-Type, Origin, Accept, token, Authorization" />
<add name="Access-Control-Allow-Methods" value="GET, POST, PUT, DELETE, OPTIONS" />

angular.js
----------
$http.post(myUrl, JSON.stringify(usuario))

Contribucion
----

Primordialmente a [Heber Lopez] (http://@HeberLZ) y a [Javier Alessandrello] (alessaj@gmail.com) que contribuyeron en la solución de los errores de comunicacion CORS


