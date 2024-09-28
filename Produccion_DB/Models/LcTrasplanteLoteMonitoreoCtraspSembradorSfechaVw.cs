using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteLoteMonitoreoCtraspSembradorSfechaVw
{
    public string Temporada { get; set; } = null!;

    public DateOnly FechaTrasplante { get; set; }

    public string? Observaciones { get; set; }

    public string IdSembrador { get; set; } = null!;

    public string NombreSembrador { get; set; } = null!;

    public int Numero { get; set; }

    public bool Activo { get; set; }

    public double MetrosXFallas { get; set; }

    public double PrecioMetro { get; set; }

    public int FallasTotalFecha { get; set; }

    public double? MetrosTotalFecha { get; set; }

    public double? DineroTotalFecha { get; set; }

    public double? DineroTotalRealFecha { get; set; }
}
