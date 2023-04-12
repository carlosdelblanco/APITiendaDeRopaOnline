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
`
{
    "mensaje": "ok",
    "response": [
        {
            "idProducto": 1,
            "idTalla": 1,
            "color": "Blue",
            "precio": 100.00,
            "descripcion": "t-shirt",
            "objectTalla": {
                "idTalla": 1,
                "description": "S"
            }
        },
        {
            "idProducto": 2,
            "idTalla": 2,
            "color": "Red",
            "precio": 80.00,
            "descripcion": "jeans",
            "objectTalla": {
                "idTalla": 2,
                "description": "M"
            }
        },
        {
            "idProducto": 3,
            "idTalla": 3,
            "color": "Yellow",
            "precio": 110.00,
            "descripcion": "jacket",
            "objectTalla": {
                "idTalla": 3,
                "description": "L"
            }
        },
        {
            "idProducto": 4,
            "idTalla": 4,
            "color": "White",
            "precio": 60.00,
            "descripcion": "skirt",
            "objectTalla": {
                "idTalla": 4,
                "description": "XL"
            }
        },
        {
            "idProducto": 5,
            "idTalla": 5,
            "color": "Maroon",
            "precio": 140.00,
            "descripcion": "t-shirt",
            "objectTalla": {
                "idTalla": 5,
                "description": "XXL"
            }
        },
        {
            "idProducto": 10,
            "idTalla": 2,
            "color": "maroon",
            "precio": 105.00,
            "descripcion": "camisa a rayas",
            "objectTalla": {
                "idTalla": 2,
                "description": "M"
            }
        }
    ]
}
`

### Obtener producto por id

#### Peticion
api/Producto/List


#### Respuesta

api/Producto/get/{idProducto}

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
