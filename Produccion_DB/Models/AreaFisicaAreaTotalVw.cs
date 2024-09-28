using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class AreaFisicaAreaTotalVw
{
    public string Temporada { get; set; } = null!;

    public double? AreaFisica { get; set; }

    public double? AreaTotal { get; set; }
}
