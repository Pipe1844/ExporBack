using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumasTotalesAfechaVw1
{
    public int IdPlubiometro { get; set; }

    public bool Activo { get; set; }

    public string Ubicacion { get; set; } = null!;

    public DateOnly FechaHora0 { get; set; }

    public double? CantidadMm0 { get; set; }

    public DateOnly? FechaHora1 { get; set; }

    public double? CantidadMm1 { get; set; }

    public int? Año0 { get; set; }

    public int? Año1 { get; set; }

    public int? Mes0 { get; set; }

    public int? Mes1 { get; set; }

    public double? SumaMes0 { get; set; }

    public double? SumaMes1 { get; set; }

    public double? SumaAño0 { get; set; }

    public double? SumaAño1 { get; set; }

    public double? SumaMesAfecha1 { get; set; }

    public double? SumaMesAfecha0 { get; set; }

    public double? SumaAnioAfecha0 { get; set; }

    public double? SumaAnioAfecha1 { get; set; }
}
