using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumaxMesVw
{
    public int IdPlubiometro { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public double? SumaMes { get; set; }
}
