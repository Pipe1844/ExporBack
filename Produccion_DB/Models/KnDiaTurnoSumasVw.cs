using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnDiaTurnoSumasVw
{
    public string Safra { get; set; } = null!;

    public int? DiaDeCorta { get; set; }

    public string? Turno { get; set; }

    public double? SumNetoExp { get; set; }

    public double? SumPesoNIngenio { get; set; }

    public double? SumPesoNApagarIngenio { get; set; }

    public double? SumCastigoC { get; set; }

    public double? SumDiferenciaC { get; set; }

    public double? SumBrix { get; set; }

    public double? SumPol { get; set; }

    public double? SumPureza { get; set; }

    public double? SumAzucar { get; set; }

    public double? SumMiel { get; set; }

    public double? SumAzucarC { get; set; }

    public double? SumMielC { get; set; }
}
