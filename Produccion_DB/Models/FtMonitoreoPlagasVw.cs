using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtMonitoreoPlagasVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public DateTime FechaHoraMuestreo { get; set; }

    public int MetrosMontoreos { get; set; }

    public int PuntosMonitoreos { get; set; }

    public int MinadorAdulto { get; set; }

    public int MinadorEdlL1 { get; set; }

    public int MinadorEdlL2 { get; set; }

    public int MinadorEdlL3 { get; set; }

    public int Pupa { get; set; }

    public int AfidosAlados { get; set; }

    public int AfidosCol { get; set; }

    public int DiafaniaLarva { get; set; }

    public int DiafaniaHuevo { get; set; }

    public int SpodopteraLarva { get; set; }

    public int SpodopteraHuevo { get; set; }

    public int LfrutoDiafania { get; set; }

    public int LfrutoSpodoptera { get; set; }

    public int Trips { get; set; }

    public int MoscaBlancaTtales { get; set; }

    public string? Observaciones { get; set; }

    public string? IdPlaguero { get; set; }

    public string? Plaguero { get; set; }
}
