using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class CamasLotesFisicosTb
{
    public string NombreLote { get; set; } = null!;

    public int NumeroCama { get; set; }

    public double? Longitud { get; set; }

    public virtual LotesFisicosTb NombreLoteNavigation { get; set; } = null!;
}
