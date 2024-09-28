using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtTurnoAplicacionTb
{
    public int IdTaplicacion { get; set; }

    public string Turno { get; set; } = null!;

    public DateTime FechaHoraEntrada { get; set; }

    public DateTime FechaHoraSalida { get; set; }

    public string IdSupervisor { get; set; } = null!;

    public string NombreSupervisor { get; set; } = null!;

    public string? IdRevisadoPor { get; set; }

    public string? NombreRevisadoPor { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<FtAplicacionesTb> FtAplicacionesTbs { get; set; } = new List<FtAplicacionesTb>();
}
