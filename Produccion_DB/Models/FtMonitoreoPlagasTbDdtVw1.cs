using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtMonitoreoPlagasTbDdtVw1
{
    public int IdMplagas { get; set; }

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly? FechaTrasplante { get; set; }

    public int? Ddt { get; set; }

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public double? AreaHibrido { get; set; }

    public DateTime FechaHoraMuestreo { get; set; }

    public int MetrosMontoreos { get; set; }

    public int PuntosMonitoreos { get; set; }

    public decimal? MinadorAdultoPunto { get; set; }

    public decimal? MinadorEdlL1Punto { get; set; }

    public decimal? MinadorEdlL2Punto { get; set; }

    public decimal? MinadorEdlL3Punto { get; set; }

    public decimal? PupaPunto { get; set; }

    public decimal? AfidosAladosPunto { get; set; }

    public decimal? AfidosColPunto { get; set; }

    public decimal? DiafaniaLarvaPunto { get; set; }

    public decimal? DiafaniaHuevoPunto { get; set; }

    public decimal? SpodopteraLarvaPunto { get; set; }

    public decimal? SpodopteraHuevoPunto { get; set; }

    public decimal? LfrutoDiafaniaPunto { get; set; }

    public decimal? LfrutoSpodopteraPunto { get; set; }

    public decimal? TripsPunto { get; set; }

    public decimal? MoscaBlancaTotalPunto { get; set; }

    public decimal? MinadorTotalPunto { get; set; }

    public decimal? AfidosTotalPunto { get; set; }

    public decimal? DiafaniaTotalPunto { get; set; }

    public decimal? SpodopteraTotalPunto { get; set; }

    public decimal? LfrutoTotalPunto { get; set; }

    public decimal? PlagasTotalPunto { get; set; }

    public string? Observaciones { get; set; }
}
