using System;
using System.Collections.Generic;

namespace APITiendaDeRopaOnline.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public int? IdTalla { get; set; }

    public string? Color { get; set; }

    public decimal? Precio { get; set; }

    public string? Descripcion { get; set; }

    public virtual Talla? objectTalla { get; set; }
}
