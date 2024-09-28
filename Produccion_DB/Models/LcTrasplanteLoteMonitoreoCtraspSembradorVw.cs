using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteLoteMonitoreoCtraspSembradorVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaTrasplante { get; set; }

    public string? Observaciones { get; set; }

    public string IdSembrador { get; set; } = null!;

    public string NombreSembrador { get; set; } = null!;

    public int Numero { get; set; }

    public bool Activo { get; set; }

    public int FallasDeTrasplante { get; set; }

    public double MetrosXFallas { get; set; }

    public double PrecioMetro { get; set; }

    public int NumeroCama { get; set; }

    public double? Longitud { get; set; }
}
