using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtMonitoreoFrutoNombreEstadoDlarvaVw
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

    public DateTime Fecha { get; set; }

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

    public string? Genero { get; set; }

    public string? Especie { get; set; }

    public string? NombreDlarva { get; set; }

    public int? CantidadDlarva { get; set; }

    public string? EstadoLarva { get; set; }

    public int? CantidadElarva { get; set; }
}
