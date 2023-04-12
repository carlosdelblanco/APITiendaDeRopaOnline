# APITiendaDeRopaOnline

## Pasos para la creacion de la API REST:

Añado entity famework (he de instalar nuget etc)
Creo carpeta models 

Obtengo todas las clases de entity framework segun una base de datos

Creo base de datos TIENDAONLINE en sql
	Creo TALLA
	Creo PRODUCTO


## Visual studio

ejecutar comando: Scaffold-DbContext "Server=(local);Database=TIENDAONLINE;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models encrypt=false

Creo controlador donde van a estar todas las API

api/Producto/List
api/Producto/get/{idProducto}
api/Producto/Guardar
api/Producto/Editar
api/Producto/Eliminar/{idProducto}


## Como he aplicado SOLID?

## Tests unitarios
