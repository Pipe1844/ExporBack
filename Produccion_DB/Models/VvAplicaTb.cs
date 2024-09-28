using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvAplicaTb
{
    public int IdAplicacion { get; set; }

    public int DiaSiembra { get; set; }

    public string LoteSemilla { get; set; } = null!;

    public virtual VvAplicacionTb IdAplicacionNavigation { get; set; } = null!;
}
