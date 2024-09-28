using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ValvulasTb
{
    public string NombreLote { get; set; } = null!;

    public string NombreValvula { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual LotesFisicosTb NombreLoteNavigation { get; set; } = null!;
}
