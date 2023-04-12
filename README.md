<h1>REST API APITiendaDeRopaOnline</h1>

El entorno utilizado ha sido Visual Studio 17.5.3, para la base de datos SQL Management Studio 19.0.2 y para probar los endpoints Postman 10.12

`ProductoController.cs` es el controlador que contiene los endpoints para crear, editar, eliminar y obtener productos.

`Program.cs`contiene el programa principal.

## EndPoints

### Obtener listado de productos

#### Peticion

`GET api/Producto/List`

http://localhost:5024/api/Producto/List

#### Respuesta

![image](https://user-images.githubusercontent.com/108033668/231489847-6a55fa2a-ee6b-4c46-940d-dd3c359381dd.png)

![image](https://user-images.githubusercontent.com/108033668/231490286-3d3b870b-f6b5-45a4-ad9f-fd0cef4129fe.png)


### Obtener producto por id

#### Peticion
`GET api/Producto/get/{idProducto}`

http://localhost:5024/api/Producto/get/2
http://localhost:5024/api/Producto/get/9

#### Respuesta
![image](https://user-images.githubusercontent.com/108033668/231491207-ecd4a0ed-205d-4505-9ded-ffaa34a77f1b.png)

![image](https://user-images.githubusercontent.com/108033668/231491111-59cc3f0f-7d20-40da-bc73-7cc603a63ad6.png)


### Guardar producto

#### Peticion
api/Producto/List


#### Respuesta

api/Producto/Guardar

### Editar producto

#### Peticion
api/Producto/List


#### Respuesta

api/Producto/Editar

### Eliminar producto

#### Peticion
api/Producto/List


#### Respuesta

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
