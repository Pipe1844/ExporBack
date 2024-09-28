using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumasTotalesAfechaVw
{
    public int IdPlubiometro { get; set; }

    public bool Activo { get; set; }

    public string Ubicacion { get; set; } = null!;

    public DateOnly FechaHora { get; set; }

    public double? CantidadMm { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public double? SumaMes { get; set; }

    public double? SumaAño { get; set; }

    public double? SumaMesAfecha { get; set; }

    public double? SumaAnioAfecha { get; set; }
}
