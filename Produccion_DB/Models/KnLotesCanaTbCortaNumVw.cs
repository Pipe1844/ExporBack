using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLotesCanaTbCortaNumVw
{
    public DateOnly FechaSiembra { get; set; }

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public double? AreaSiembra { get; set; }

    public double? DistanciaSiembra { get; set; }

    public string? Orientacion { get; set; }

    public bool? Renovado { get; set; }

    public DateOnly? FechaInicial { get; set; }

    public DateOnly? FechaFinal { get; set; }

    public double? AreaCorta { get; set; }

    public bool? Quemado { get; set; }

    public bool? CortaMecanica { get; set; }

    public string? Maquina { get; set; }

    public string? Safra { get; set; }

    public int? UltimaCorta { get; set; }
}
