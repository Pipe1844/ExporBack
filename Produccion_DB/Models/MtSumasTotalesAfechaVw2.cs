using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumasTotalesAfechaVw2
{
    public int IdPlubiometro { get; set; }

    public bool Activo { get; set; }

    public string Ubicacion { get; set; } = null!;

    public DateOnly FechaHora0 { get; set; }

    public double? Cantidad0 { get; set; }

    public DateOnly? FechaHora1 { get; set; }

    public double? Cantidad1 { get; set; }

    public DateOnly? FechaHora2 { get; set; }

    public double? Cantidad2 { get; set; }

    public int? Año0 { get; set; }

    public double? SumaAño0 { get; set; }

    public double? SumaAñoAfecha0 { get; set; }

    public int? Año1 { get; set; }

    public double? SumaAño1 { get; set; }

    public double? SumaAñoAfecha1 { get; set; }

    public int? Año2 { get; set; }

    public double? SumaAño2 { get; set; }

    public double? SumaAñoAfecha2 { get; set; }

    public int? Mes0 { get; set; }

    public double? SumaMes0 { get; set; }

    public double? SumaMesAfecha0 { get; set; }

    public int? Mes1 { get; set; }

    public double? SumaMes1 { get; set; }

    public double? SumaMesAfecha1 { get; set; }

    public int? Mes2 { get; set; }

    public double? SumaMes2 { get; set; }

    public double? SumaMesAfecha2 { get; set; }
}
