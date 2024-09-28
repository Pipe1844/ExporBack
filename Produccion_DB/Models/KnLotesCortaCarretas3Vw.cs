using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLotesCortaCarretas3Vw
{
    public string Safra { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public double? DistanciaSiembra { get; set; }

    public int NumCorta { get; set; }

    public bool? Quemado { get; set; }

    public bool CortaMecanica { get; set; }

    public string? Maquina { get; set; }

    public double? TonNetoExpL { get; set; }

    public double? TonPesoNIngenioL { get; set; }

    public double? TonDirefenciaL { get; set; }

    public double? TonHaL { get; set; }

    public double? KgAzucarTonL { get; set; }

    public double? KgAzucarHaL { get; set; }

    public double? KgAzucarMasAjusteTonL { get; set; }

    public double? KgAzucarMasAjusteHaL { get; set; }

    public double? KgMielTonL { get; set; }

    public double? KgMielHaL { get; set; }

    public double? KgMielMasAjusteTonL { get; set; }

    public double? KgMielMasAjusteHaL { get; set; }
}
