using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcCtraspSembradorVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string IdSembrador { get; set; } = null!;

    public int NumeroCama { get; set; }

    public double? Longitud { get; set; }
}
