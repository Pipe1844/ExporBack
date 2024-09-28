using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtTurnoMasAplicacionesDdtVw
{
    public int IdTaplicacion { get; set; }

    public string Turno { get; set; } = null!;

    public DateTime TurnoFechaHoraEntrada { get; set; }

    public DateTime TurnoFechaHoraSalida { get; set; }

    public string IdSupervisor { get; set; } = null!;

    public string NombreSupervisor { get; set; } = null!;

    public string? IdRevisadoPor { get; set; }

    public string? NombreRevisadoPor { get; set; }

    public string? Observaciones { get; set; }

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly? FechaTrasplante { get; set; }

    public int? Ddt { get; set; }

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

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public string? IdOperador { get; set; }

    public string? IdAyudante { get; set; }

    public string? NombreOperador { get; set; }

    public string? NombreAyudante { get; set; }
}
