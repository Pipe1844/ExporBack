using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class EstRangosPesosTb
{
    public string NombreRango { get; set; } = null!;

    public string Temporada { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public double? MayorIgualQue { get; set; }

    public double? MenorQue { get; set; }

    public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;
}
