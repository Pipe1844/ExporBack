using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteLoteMonitoreoCtraspSembradorRfmSsemanaVw
{
    public string Temporada { get; set; } = null!;

    public int? Semana { get; set; }

    public string IdSembrador { get; set; } = null!;

    public string NombreSembrador { get; set; } = null!;

    public int NumeroSembrador { get; set; }

    public bool Activo { get; set; }

    public int? InsidenciasDeFallas { get; set; }
}
