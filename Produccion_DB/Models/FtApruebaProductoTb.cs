using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtApruebaProductoTb
{
    public int FtIdAprueba { get; set; }

    public int NumBoleta { get; set; }

    public string? IdEmpleadoEjecuta { get; set; }

    public string? UsuarioWindows { get; set; }

    public string? UsuarioSystema { get; set; }

    public DateTime? FechaHoraEjecuta { get; set; }

    public virtual FtPedidoTb NumBoletaNavigation { get; set; } = null!;
}
