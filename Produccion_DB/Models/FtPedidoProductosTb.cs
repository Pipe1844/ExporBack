using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtPedidoProductosTb
{
    public int NumBoleta { get; set; }

    public string IdProducto { get; set; } = null!;

    public string? NombreDescriptivo { get; set; }

    public double? UnidadesPorLote { get; set; }

    public string? MotivoPaplicacion { get; set; }

    public virtual ProductosTb IdProductoNavigation { get; set; } = null!;

    public virtual FtPedidoTb NumBoletaNavigation { get; set; } = null!;
}
