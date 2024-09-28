using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LaborTDdtVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNumero { get; set; }

    public string Departamento { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public bool? AplicarATodo { get; set; }

    public string? AplicarA { get; set; }

    public int Ddt { get; set; }
}
