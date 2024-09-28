using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnCortaCanaTb
{
    public int NumCorta { get; set; }

    public DateOnly FechaSiembra { get; set; }

    public string NombreLote { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaInicial { get; set; }

    public DateOnly? FechaFinal { get; set; }

    public double? AreaCorta { get; set; }

    public bool? Quemado { get; set; }

    public bool CortaMecanica { get; set; }

    public string? Maquina { get; set; }

    public string Safra { get; set; } = null!;

    public virtual KnLotesCanaTb KnLotesCanaTb { get; set; } = null!;

    public virtual ICollection<KnPesoCarretasTb> KnPesoCarretasTbs { get; set; } = new List<KnPesoCarretasTb>();
}
