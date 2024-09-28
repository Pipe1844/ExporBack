using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLotesCortaCarretas0Vw
{
    public DateOnly FechaSiembra { get; set; }

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public double? AreaSiembra { get; set; }

    public double? DistanciaSiembra { get; set; }

    public string? Orientacion { get; set; }

    public bool? Renovado { get; set; }

    public int NumCorta { get; set; }

    public DateOnly FechaInicial { get; set; }

    public DateOnly? FechaFinal { get; set; }

    public double? AreaCorta { get; set; }

    public bool? Quemado { get; set; }

    public bool CortaMecanica { get; set; }

    public string? Maquina { get; set; }

    public string Safra { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public string Trasportista { get; set; } = null!;

    public DateTime? FeFinca { get; set; }

    public DateTime? FsFinca { get; set; }

    public double? BrutoExp { get; set; }

    public double? TaraExp { get; set; }

    public double? NetoExp { get; set; }

    public double? NumBoletaExp { get; set; }

    public string? IngenioDescarga { get; set; }

    public double? NumRIngenio { get; set; }

    public DateTime? FechaEIngenio { get; set; }

    public DateTime? FechaSIngenio { get; set; }

    public double? PesoBIngenio { get; set; }

    public double? PesoNIngenio { get; set; }

    public double? Brix { get; set; }

    public double? Pol { get; set; }

    public double? Pureza { get; set; }

    public double? Azucar { get; set; }

    public double? Miel { get; set; }

    public double? AzucarC { get; set; }

    public double? MielC { get; set; }

    public double? DiferenciaC { get; set; }

    public double? CastigoC { get; set; }

    public string? NRomanero { get; set; }
}
