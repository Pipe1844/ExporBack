using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ScizerMasRangosLvTemporadaTotalVw
{
    public string Temporada { get; set; } = null!;

    public double? AreaTemporada { get; set; }

    public double? DestandarTemporada { get; set; }

    public int? FrutosTemporada { get; set; }

    public double? KilosTemporada { get; set; }

    public double? PesoFrutoTemporada { get; set; }

    public double? KgHaTemporada { get; set; }
}
