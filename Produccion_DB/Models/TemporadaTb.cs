using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class TemporadaTb
{
    public string Temporada { get; set; } = null!;

    public bool? Actual { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<DdtLaborTb> DdtLaborTbs { get; set; } = new List<DdtLaborTb>();

    public virtual ICollection<EstRangosPesosTb> EstRangosPesosTbs { get; set; } = new List<EstRangosPesosTb>();

    public virtual ICollection<EstSemanaTb> EstSemanaTbs { get; set; } = new List<EstSemanaTb>();

    public virtual ICollection<HibridosPoTb> HibridosPoTbs { get; set; } = new List<HibridosPoTb>();

    public virtual ICollection<LaborTTb> LaborTTbs { get; set; } = new List<LaborTTb>();

    public virtual ICollection<LotesPoTb> LotesPoTbs { get; set; } = new List<LotesPoTb>();

    public virtual ICollection<LvTermporadaTb> LvTermporadaTbs { get; set; } = new List<LvTermporadaTb>();

    public virtual ICollection<VersionPoTb> VersionPoTbs { get; set; } = new List<VersionPoTb>();
}
