using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VersionPoTb
{
    public double Version { get; set; }

    public string Temporada { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<LvTermporadaVersionPoTb> LvTermporadaVersionPoTbs { get; set; } = new List<LvTermporadaVersionPoTb>();

    public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;
}
