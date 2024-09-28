using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtMotivoPedidoProductosVw
{
    public string IdProducto { get; set; } = null!;

    public string? NombreDescriptivo { get; set; }

    public string? MotivoPaplicacion { get; set; }

    public int? FrecuenciaUso { get; set; }
}
