using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ApruebaProductoTb
{
    public int IdAprueba { get; set; }

    public int IdPedido { get; set; }

    public string IdProducto { get; set; } = null!;

    public int NumBoleta { get; set; }

    public string IdEmpleadoAprueva { get; set; } = null!;

    public string UsuarioWindows { get; set; } = null!;

    public string UsuarioSystema { get; set; } = null!;

    public DateTime FechaHoraAprueba { get; set; }

    public virtual KnPoPedidoProductosTb KnPoPedidoProductosTb { get; set; } = null!;
}
