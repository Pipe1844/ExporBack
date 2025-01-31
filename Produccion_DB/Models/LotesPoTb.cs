using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LotesPoTb
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly? FechaTrasplante { get; set; }

    public double? Area { get; set; }

    public string? Orientacion { get; set; }

    public string? Fumig { get; set; }

    public string? TipoPlastico { get; set; }

    public double? Densidad { get; set; }

    public double? ColmenasPorHa { get; set; }

    public string? ProgFertilizacion { get; set; }

    public string? ProgFitoProteccion { get; set; }

    public virtual ICollection<CamasLotesPoTb> CamasLotesPoTbs { get; set; } = new List<CamasLotesPoTb>();

    public virtual ICollection<FtAplicacionesTb> FtAplicacionesTbs { get; set; } = new List<FtAplicacionesTb>();

    public virtual LcTrasplanteLoteTb? LcTrasplanteLoteTb { get; set; }

    public virtual ICollection<LvTermporadaTb> LvTermporadaTbs { get; set; } = new List<LvTermporadaTb>();
    /*

    public virtual LotesFisicosTb NombreLoteNavigation { get; set; } = null!;

    public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;
    */
}
