using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnCamionesDiaTurnoVw
{
    public string Safra { get; set; } = null!;

    public int? DiaDeCorta { get; set; }

    public string? Turno { get; set; }

    public int? Camiones { get; set; }
}
