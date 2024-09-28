using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LotesPoTrazabilidadFechaCosechaVw
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

    public string CodigosTrazabilidad { get; set; } = null!;

    public DateTime? FechaCosecha { get; set; }
}
