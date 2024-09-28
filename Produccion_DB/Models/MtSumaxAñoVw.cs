using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumaxAñoVw
{
    public int IdPlubiometro { get; set; }

    public int? Año { get; set; }

    public double? SumaAño { get; set; }
}
