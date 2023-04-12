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

- http://localhost:5024/api/Producto/get/2

- http://localhost:5024/api/Producto/get/9

#### Respuesta
![image](https://user-images.githubusercontent.com/108033668/231491207-ecd4a0ed-205d-4505-9ded-ffaa34a77f1b.png)

![image](https://user-images.githubusercontent.com/108033668/231491111-59cc3f0f-7d20-40da-bc73-7cc603a63ad6.png)


### Guardar producto

#### Peticion
`GET api/Producto/Guardar`

- http://localhost:5024/api/Producto/Guardar

#### Respuesta



### Editar producto

#### Peticion
`PUT api/Producto/Editar`

Solo cambia los campos indicados

#### Respuesta
![image](https://user-images.githubusercontent.com/108033668/231593721-e70c14a4-b9bf-4130-9624-2e55d13b50ef.png)

![image](https://user-images.githubusercontent.com/108033668/231593478-aa1dc6d8-5aae-4ed2-8d31-14d23afcd600.png)




### Eliminar producto

#### Peticion
`DELETE api/Producto/Eliminar/{idProducto}`

- http://localhost:5024/api/Producto/Eliminar/10

- http://localhost:5024/api/Producto/Eliminar/11

#### Respuesta
![image](https://user-images.githubusercontent.com/108033668/231594412-675c16a2-6e2c-43ca-9fef-ab5e7080d48e.png)

![image](https://user-images.githubusercontent.com/108033668/231594237-46daf2e2-2592-4a56-9468-7945b1701459.png)




## Pasos para la creacion de la API REST:

Añado entity famework (he de instalar nuget etc)
Creo carpeta models 

Obtengo todas las clases de entity framework segun una base de datos

Creo base de datos TIENDAONLINE en sql
	Creo TALLA
	Creo PRODUCTO


## Visual studio

ejecutar comando: Scaffold-DbContext "Server=(local);Database=TIENDAONLINE;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models encrypt=false

## SQL Server
He creado una base de datos TIENDAONLINE compuesta de dos tablas, por un lado la tabla PRODUCTO y por otro lado la tabla TALLA las cuales se relacionan a traves de la clave foranea IdTalla.


CREATE DATABASE TIENDAONLINE

USE TIENDAONLINE

CREATE TABLE TALLA(
IdTalla int primary key identity(1,1),
Description varchar(50)
)

CREATE TABLE PRODUCTO(
IdProducto int primary key identity(1,1),
IdTalla int,
Color varchar(50),
Precio decimal (10,2),
Descripcion varchar (50)
CONSTRAINT FK_IDTALLA FOREIGN KEY (IdTalla) REFERENCES TALLA(IdTalla))

INSERT INTO TALLA(Description) values
('S'),
('M'),
('L'),
('XL'),
('XXL')

insert into PRODUCTO(IdTalla, Color, Precio, Descripcion) values
(1,'Blue',100,'t-shirt'),
(2,'Red',80,'jeans'),
(3,'Yellow',110,'jacket'),
(4,'White',60,'skirt'),
(5,'Maroon',140,'t-shirt')

SELECT * FROM TALLA

SELECT * FROM PRODUCTO 


## Como he aplicado SOLID?

## Tests unitarios
