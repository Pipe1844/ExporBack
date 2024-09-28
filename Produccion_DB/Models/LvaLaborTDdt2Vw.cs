using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LvaLaborTDdt2Vw
{
    public string Temporada { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly? FechaLabor { get; set; }
}
