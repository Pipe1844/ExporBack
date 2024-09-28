using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvGerminacionTb
{
    public int DiaSiembra { get; set; }

    public string LoteSemilla { get; set; } = null!;

    public DateOnly FechaMonitoreo { get; set; }

    public int PlantasTeoricas { get; set; }

    public int PlantasReales { get; set; }

    public int? Pgerminacion { get; set; }

    public bool BandejaNueva { get; set; }
}
