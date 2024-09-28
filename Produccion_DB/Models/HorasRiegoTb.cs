using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class HorasRiegoTb
{
    public double Año { get; set; }

    public string Cultivo { get; set; } = null!;

    public DateTime FechaRiego { get; set; }

    public double HorasRiego { get; set; }

    public string Lote { get; set; } = null!;

    public string Cabezal { get; set; } = null!;

    public int? Mes { get; set; }
}
