using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LvaLaborTDdtVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string AliasLote { get; set; } = null!;

    public string Tratamiento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public DateOnly? FechaTrasplante { get; set; }

    public string Departamento { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public bool? AplicarATodo { get; set; }

    public string? AplicarA { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaLabor { get; set; }

    public string? ProgFertilizacion { get; set; }

    public string? ProgFitoProteccion { get; set; }
}
