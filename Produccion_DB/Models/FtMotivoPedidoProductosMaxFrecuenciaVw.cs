using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtMotivoPedidoProductosMaxFrecuenciaVw
{
    public string IdProducto { get; set; } = null!;

    public string? NombreDescriptivo { get; set; }

    public int? FrecuenciaUsoMax { get; set; }
}
