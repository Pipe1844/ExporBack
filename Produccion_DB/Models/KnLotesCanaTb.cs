using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLotesCanaTb
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

    public virtual HibridosTb HibridosTb { get; set; } = null!;

    public virtual ICollection<KnCortaCanaTb> KnCortaCanaTbs { get; set; } = new List<KnCortaCanaTb>();

    public virtual LotesFisicosTb NombreLoteNavigation { get; set; } = null!;
}
