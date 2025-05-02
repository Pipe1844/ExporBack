using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class DdtLaborTb
{
    public string Temporada { get; set; } = null!;

    public int SiembraNumero { get; set; }

    public string Departamento { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public int Ddt { get; set; }

    //public virtual LaborTTb LaborTTb { get; set; } = null!;

    //public virtual ICollection<PoProductosALaborTb> PoProductosALaborTbs { get; set; } = new List<PoProductosALaborTb>();

    //public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;
    
    //public virtual LaborTTb? LaborTTb { get; set; }

    //public virtual TemporadaTb? TemporadaNavigation { get; set; }

}
