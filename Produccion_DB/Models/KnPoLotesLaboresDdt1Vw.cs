using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoLotesLaboresDdt1Vw
{
    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public double? AreaSiembra { get; set; }

    public DateOnly? FechaBase { get; set; }

    public int Ddt { get; set; }

    public double? HorasAgua { get; set; }

    public double? HorasInyeccion { get; set; }

    public double? HorasLavado { get; set; }

    public double? HorasTotal { get; set; }
}
