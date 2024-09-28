using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class HibridosPoTb
{
    public string Temporada { get; set; } = null!;

    public string Tratamiento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public virtual HibridosTb HibridosTb { get; set; } = null!;

    public virtual ICollection<LcTrasplanteHibridosTb> LcTrasplanteHibridosTbs { get; set; } = new List<LcTrasplanteHibridosTb>();

    public virtual ICollection<LvTermporadaTb> LvTermporadaTbs { get; set; } = new List<LvTermporadaTb>();

    public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;

    public virtual VariedadTb VariedadTb { get; set; } = null!;
}
