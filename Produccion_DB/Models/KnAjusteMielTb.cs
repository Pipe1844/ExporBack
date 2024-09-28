using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnAjusteMielTb
{
    public string Safra { get; set; } = null!;

    public double AjusteMiel { get; set; }

    public DateTime FechaAjuste { get; set; }
}
