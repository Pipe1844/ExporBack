using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvSalidaViveroTb
{
    public int DiaSiembra { get; set; }

    public string TemporadaD { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public int SiembraNumD { get; set; }

    public string NombreLoteD { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasLoteD { get; set; } = null!;

    public DateTime FechaHoraSvv { get; set; }

    public string LoteSemilla { get; set; } = null!;

    public double NumBandejasSvv { get; set; }

    public string Observaciones { get; set; } = null!;

    public virtual ICollection<LcVvTrasplanteSalidaViveroTb> LcVvTrasplanteSalidaViveroTbs { get; set; } = new List<LcVvTrasplanteSalidaViveroTb>();

    public virtual VvSiembraViveroTb VvSiembraViveroTb { get; set; } = null!;
}
