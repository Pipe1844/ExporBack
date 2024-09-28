using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLotesCortaCarretas1Vw
{
    public string Safra { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaSiembra { get; set; }

    public double? AreaSiembra { get; set; }

    public double? DistanciaSiembra { get; set; }

    public bool? Renovado { get; set; }

    public int NumCorta { get; set; }

    public DateOnly? FechaFinal { get; set; }

    public double? AreaCorta { get; set; }

    public bool? Quemado { get; set; }

    public bool CortaMecanica { get; set; }

    public string? Maquina { get; set; }

    public double? BrutoExpL { get; set; }

    public double? TaraExpL { get; set; }

    public double? NetoExpL { get; set; }

    public double? PesoBIngenioL { get; set; }

    public double? PesoNIngenioL { get; set; }

    public double? BrixL { get; set; }

    public double? PolL { get; set; }

    public double? PurezaL { get; set; }

    public double? AzucarKgTonL { get; set; }

    public double? MielKgTonL { get; set; }

    public double? AzucarL { get; set; }

    public double? AzucarMasAjusteL { get; set; }

    public double? MielL { get; set; }

    public double? MielMasAjusteL { get; set; }
}
