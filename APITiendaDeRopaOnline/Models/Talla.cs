using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APITiendaDeRopaOnline.Models;

public partial class Talla
{
    public int IdTalla { get; set; }

    public string? Description { get; set; }

    [JsonIgnore]
    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
 