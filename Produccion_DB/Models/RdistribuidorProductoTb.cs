using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class RdistribuidorProductoTb
{
    public int IdRdistribuidos { get; set; }

    public int IdPedido { get; set; }

    public string IdProducto { get; set; } = null!;

    public int NumBoleta { get; set; }

    public string IdEmpleadoRdistribuidor { get; set; } = null!;

    public string UsuarioWindows { get; set; } = null!;

    public string UsuarioSystema { get; set; } = null!;

    public DateTime FechaHoraRdistribuidor { get; set; }

    public virtual KnPoPedidoProductosTb KnPoPedidoProductosTb { get; set; } = null!;
}
