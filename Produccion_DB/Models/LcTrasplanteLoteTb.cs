using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteLoteTb
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaTrasplante { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<LcMonitoreoTrasplanteTb> LcMonitoreoTrasplanteTbs { get; set; } = new List<LcMonitoreoTrasplanteTb>();

    public virtual ICollection<LcTrasplanteHibridosTb> LcTrasplanteHibridosTbs { get; set; } = new List<LcTrasplanteHibridosTb>();

    public virtual ICollection<LcVvTrasplanteSalidaViveroTb> LcVvTrasplanteSalidaViveroTbs { get; set; } = new List<LcVvTrasplanteSalidaViveroTb>();

    public virtual LotesPoTb LotesPoTb { get; set; } = null!;
}
