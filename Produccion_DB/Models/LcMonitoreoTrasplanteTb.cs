using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcMonitoreoTrasplanteTb
{
    public string IdSembrador { get; set; } = null!;

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string NombreSembrador { get; set; } = null!;

    public int FallasDeTrasplante { get; set; }

    public double MetrosXFallas { get; set; }

    public double PrecioMetro { get; set; }

    public virtual ICollection<LcCtraspSembradorTb> LcCtraspSembradorTbs { get; set; } = new List<LcCtraspSembradorTb>();

    public virtual LcSembradorTb LcSembradorTb { get; set; } = null!;

    public virtual LcTrasplanteLoteTb LcTrasplanteLoteTb { get; set; } = null!;
}
