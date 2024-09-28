using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class EntregaProductoTb
{
    public int IdEntrega { get; set; }

    public int IdPedido { get; set; }

    public string IdProducto { get; set; } = null!;

    public int NumBoleta { get; set; }

    public string IdEmpleadoEntraga { get; set; } = null!;

    public string UsuarioWindows { get; set; } = null!;

    public string UsuarioSystema { get; set; } = null!;

    public DateTime FechaHoraEntraga { get; set; }

    public virtual KnPoPedidoProductosTb KnPoPedidoProductosTb { get; set; } = null!;
}
