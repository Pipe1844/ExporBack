using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvSemillasTb
{
    public string LoteSemilla { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public DateOnly FechaEntrada { get; set; }

    public double NumSemillas { get; set; }

    public virtual VvLotesSemillaTb VvLotesSemillaTb { get; set; } = null!;
}
