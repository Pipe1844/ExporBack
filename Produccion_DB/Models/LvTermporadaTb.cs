using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LvTermporadaTb
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public double? AreaVariedad { get; set; }

    public virtual ICollection<FtMonitoreoFrutoTb> FtMonitoreoFrutoTbs { get; set; } = new List<FtMonitoreoFrutoTb>();

    public virtual ICollection<FtMonitoreoPlagasTb> FtMonitoreoPlagasTbs { get; set; } = new List<FtMonitoreoPlagasTb>();

    public virtual HibridosPoTb HibridosPoTb { get; set; } = null!;

    public virtual LotesPoTb LotesPoTb { get; set; } = null!;

    public virtual ICollection<PilaTb> PilaTbs { get; set; } = new List<PilaTb>();

    public virtual ICollection<ScizerTb> ScizerTbs { get; set; } = new List<ScizerTb>();

    public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;
}
