using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class View2
{
    public int IdPedido { get; set; }

    public string IdProducto { get; set; } = null!;

    public int NumBoleta { get; set; }

    public string IdEmpleadoAprueva { get; set; } = null!;

    public string UsuarioWindows { get; set; } = null!;

    public string UsuarioSystema { get; set; } = null!;

    public DateTime FechaHoraAprueba { get; set; }
}
