using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtAplicacionesTb
{
    public int IdAplicacion { get; set; }

    public int IdTaplicacion { get; set; }

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string IdTractor { get; set; } = null!;

    public string IdSpray { get; set; } = null!;

    public string CentroLlenado { get; set; } = null!;

    public double Cargas { get; set; }

    public string NombreTractor { get; set; } = null!;

    public int Rpm { get; set; }

    public string Marcha { get; set; } = null!;

    public string? NombreSpray { get; set; }

    public int PresionSpray { get; set; }

    public double? PhLimpio { get; set; }

    public double? PhMezcla { get; set; }

    public DateTime? FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public string? IdOperador { get; set; }

    public string? IdHayudante { get; set; }

    public string? NombreOperador { get; set; }

    public string? NombreHayudante { get; set; }

    public virtual ArticulosTb IdSprayNavigation { get; set; } = null!;

    public virtual FtTurnoAplicacionTb IdTaplicacionNavigation { get; set; } = null!;

    public virtual ArticulosTb IdTractorNavigation { get; set; } = null!;

    public virtual LotesPoTb LotesPoTb { get; set; } = null!;
}
