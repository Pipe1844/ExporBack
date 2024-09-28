using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtMonitoreoFrutoTbDdtVw
{
    public int IdMfruto { get; set; }

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public DateTime FechaHoraMonitoreo { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public int PuntosMonitoreo { get; set; }

    public double MetrosMonitoreo { get; set; }

    public int FrutosMonitoreo { get; set; }

    public int FrutosConLarva { get; set; }

    public int DanosLeves { get; set; }

    public int DanosSeveros { get; set; }

    public int DanosNuevos { get; set; }

    public int DanosViejos { get; set; }

    public string? Obsrvaciones { get; set; }

    public string? IdPlaguero { get; set; }

    public string? Plaguero { get; set; }

    public int? Ddt { get; set; }
}
