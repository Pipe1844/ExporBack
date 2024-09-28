using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoLotesLaborDdtHorasTotalVw
{
    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly? FechaBase { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaLabor { get; set; }

    public double? HorasTotal { get; set; }
}
