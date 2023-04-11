using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using APITiendaDeRopaOnline.Models;

namespace APITiendaDeRopaOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public readonly TiendaonlineContext dataBaseContext;

        public ProductoController(TiendaonlineContext context)
        {
            dataBaseContext = context;
        }

        [HttpGet]
        [Route("List")]

        public IActionResult Lista()
        {   
            List<Producto> lista = new List<Producto>();

            try
            {
                lista = dataBaseContext.Productos.Include(c => c.objectTalla).ToList();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });

            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }

        [HttpGet]
        [Route("get/{idProducto:int}")]

        public IActionResult getProducto(int idProducto)
        {
            Producto objectoProducto = dataBaseContext.Productos.Find(idProducto);

            if (objectoProducto == null)
            {
                return BadRequest("Producto no encontrado");
            }

            try
            {
                
                objectoProducto = dataBaseContext.Productos.Include(c => c.objectTalla).Where(p => p.IdProducto == idProducto).FirstOrDefault();    

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = objectoProducto });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = objectoProducto });
            }
        }

        [HttpPost]
        [Route("Guardar")]

        public IActionResult Guardar([FromBody] Producto objeto)
        {
            try
            {
                dataBaseContext.Productos.Add(objeto);
                dataBaseContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message});
            }
        }

        [HttpPut]
        [Route("Editar")]

        public IActionResult Editar([FromBody] Producto objeto)

        {
            Producto objetoProducto = dataBaseContext.Productos.Find(objeto.IdProducto);

            if (objetoProducto == null)
            {
                return BadRequest("Producto no encontrado");
            }

            try
            {
                objetoProducto.IdTalla = objeto.IdTalla is null ? objetoProducto.IdTalla : objeto.IdTalla;
                objetoProducto.Color = objeto.Color is null ? objetoProducto.Color : objeto.Color;
                objetoProducto.Precio = objeto.Precio is null ? objetoProducto.Precio : objeto.Precio;
                objetoProducto.Descripcion = objeto.Descripcion is null ? objetoProducto.Descripcion : objeto.Descripcion;

                dataBaseContext.Productos.Update(objetoProducto);
                dataBaseContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar/{idProducto:int}")]
        public IActionResult Eliminar(int idProducto)

            {
                Producto objetoProducto = dataBaseContext.Productos.Find(idProducto);

                if (objetoProducto == null)
                {
                    return BadRequest("Producto no encontrado");
                }

                try
                {
              
                    dataBaseContext.Productos.Remove(objetoProducto);
                    dataBaseContext.SaveChanges();

                    return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
                }
            }

        }
    }
