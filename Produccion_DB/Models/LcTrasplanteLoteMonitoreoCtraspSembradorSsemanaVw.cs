using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteLoteMonitoreoCtraspSembradorSsemanaVw
{
    public string Temporada { get; set; } = null!;

    public int? Semana { get; set; }

    public string IdSembrador { get; set; } = null!;

    public string NombreSembrador { get; set; } = null!;

    public int NumeroSembrador { get; set; }

    public bool Activo { get; set; }

    public double MetrosXFallas { get; set; }

    public double PrecioMetro { get; set; }

    public int? FallasTotalLoteSemana { get; set; }

    public double? MetrosTotalLoteSemana { get; set; }

    public double? DineroTotalLoteSemana { get; set; }

    public double? DineroTotalRealLoteSemana { get; set; }
}
