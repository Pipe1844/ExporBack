using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcVvTrasplanteSalidaViveroTb
{
    public int DiaSiembra { get; set; }

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string TemporadaD { get; set; } = null!;

    public int SiembraNumD { get; set; }

    public string NombreLoteD { get; set; } = null!;

    public string AliasLoteD { get; set; } = null!;

    public DateTime FechaHoraSvv { get; set; }

    public string TemporadaR { get; set; } = null!;

    public int SiembraNumR { get; set; }

    public string NombreLoteR { get; set; } = null!;

    public string AliasLoteR { get; set; } = null!;

    public string LoteSemilla { get; set; } = null!;

    public double NumBandejasTLc { get; set; }

    public virtual LcTrasplanteLoteTb LcTrasplanteLoteTb { get; set; } = null!;

    public virtual VvSalidaViveroTb VvSalidaViveroTb { get; set; } = null!;
}
