using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LaborTVw
{
    public string Temporada { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string? Encargado { get; set; }

    public string AliasLabor { get; set; } = null!;
}
