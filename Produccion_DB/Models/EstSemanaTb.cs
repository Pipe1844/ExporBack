using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class EstSemanaTb
{
    public int NumeroSemana { get; set; }

    public string Temporada { get; set; } = null!;

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;
}
