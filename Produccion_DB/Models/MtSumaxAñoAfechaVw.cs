using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumaxAñoAfechaVw
{
    public int IdPlubiometro { get; set; }

    public DateOnly? FechaHoraLectura { get; set; }

    public int? Año { get; set; }

    public double? SumaAnioAfecha { get; set; }
}
