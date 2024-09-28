using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumaxMesAfechaVw
{
    public int IdPlubiometro { get; set; }

    public DateOnly? FechaHoraLectura { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public double? SumaMesAfecha { get; set; }
}
