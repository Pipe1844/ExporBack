using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvAplicacionTb
{
    public int IdAplicacion { get; set; }

    public DateTime FechaAplicacion { get; set; }

    public string? IdAplicadoPor { get; set; }

    public string? AplicadoPor { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<VvAplicaTb> VvAplicaTbs { get; set; } = new List<VvAplicaTb>();

    public virtual ICollection<VvProductosAplicadosTb> VvProductosAplicadosTbs { get; set; } = new List<VvProductosAplicadosTb>();
}
