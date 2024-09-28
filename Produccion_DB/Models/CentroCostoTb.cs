using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class CentroCostoTb
{
    public string NombreLote { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string CentroCosto { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual LotesFisicosTb NombreLoteNavigation { get; set; } = null!;
}
