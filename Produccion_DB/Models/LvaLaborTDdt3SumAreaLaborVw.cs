using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LvaLaborTDdt3SumAreaLaborVw
{
    public string Temporada { get; set; } = null!;

    public DateOnly? FechaLabor { get; set; }

    public string Labor { get; set; } = null!;

    public double? AreaLabor { get; set; }
}
