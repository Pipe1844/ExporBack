using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLotesCanaPlantaSocaVw
{
    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public double? AreaSiembra { get; set; }

    public DateOnly FechaSiembra { get; set; }

    public DateOnly? FechaBase { get; set; }

    public string Tipo { get; set; } = null!;
}
