using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ApruebaProductoTbMaxFechaApruevaVw
{
    public int NumBoleta { get; set; }

    public DateTime? FechaHoraAprueba { get; set; }

    public string UsuarioSystema { get; set; } = null!;

    public string UsuarioWindows { get; set; } = null!;

    public string IdEmpleadoAprueva { get; set; } = null!;
}
