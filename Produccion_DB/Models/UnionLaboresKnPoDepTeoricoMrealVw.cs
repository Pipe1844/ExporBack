using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class UnionLaboresKnPoDepTeoricoMrealVw
{
    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly? FechaBase { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaLabor { get; set; }

    public double? AreaSiembra { get; set; }
}
