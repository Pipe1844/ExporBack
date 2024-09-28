using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtRegistroLluviasTb
{
    public int IdRlluvia { get; set; }

    public int IdPlubiometro { get; set; }

    public DateTime FechaHoraLectura { get; set; }

    public double CantidadMm { get; set; }

    public virtual MtPlubiometroTb IdPlubiometroNavigation { get; set; } = null!;
}
