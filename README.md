# REST API APITiendaDeRopaOnline

El entorno utilizado ha sido Visual Studio 17.5.3, para la base de datos SQL Management Studio 19.0.2 y para probar los endpoints Postman 10.12

`ProductoController.cs` es el controlador que contiene los endpoints para crear, editar, eliminar y obtener productos.

`Program.cs`contiene el programa principal.

## EndPoints

### Obtener listado de productos
api/Producto/List

### Obtener producto por id
api/Producto/get/{idProducto}

### Guardar producto
api/Producto/Guardar

### Editar producto
api/Producto/Editar

### Eliminar producto
api/Producto/Eliminar/{idProducto}


## Pasos para la creacion de la API REST:

Añado entity famework (he de instalar nuget etc)
Creo carpeta models 

Obtengo todas las clases de entity framework segun una base de datos

Creo base de datos TIENDAONLINE en sql
	Creo TALLA
	Creo PRODUCTO


## Visual studio

ejecutar comando: Scaffold-DbContext "Server=(local);Database=TIENDAONLINE;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models encrypt=false



## Como he aplicado SOLID?

## Tests unitarios
