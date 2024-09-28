using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtLarvasMonitoreoTbDdtVw
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

    public DateTime FechaFechaHoraMonitoreo { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public int PuntosMonitoreo { get; set; }

    public double MetrosMonitoreo { get; set; }

    public int FrutosMonitoreo { get; set; }

    public string? Genero { get; set; }

    public string? Especie { get; set; }

    public string NombreDlarva { get; set; } = null!;

    public int Cantidad { get; set; }

    public decimal? CantidadPorPunto { get; set; }

    public DateOnly? FechaTrasplante { get; set; }

    public int? Ddt { get; set; }
}
