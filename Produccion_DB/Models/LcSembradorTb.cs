using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcSembradorTb
{
    public string IdSembrador { get; set; } = null!;

    public string Temporada { get; set; } = null!;

    public string NombreSembrador { get; set; } = null!;

    public int Numero { get; set; }

    public bool Activo { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<LcMonitoreoTrasplanteTb> LcMonitoreoTrasplanteTbs { get; set; } = new List<LcMonitoreoTrasplanteTb>();
}
