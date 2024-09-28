using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class CentroCostoVw1
{
    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string CentroCosto { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string? Descripcion { get; set; }
}
