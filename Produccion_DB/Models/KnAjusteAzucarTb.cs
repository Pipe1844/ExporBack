using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnAjusteAzucarTb
{
    public string Safra { get; set; } = null!;

    public double AjusteAzucar { get; set; }

    public DateTime FechaAjuste { get; set; }
}
