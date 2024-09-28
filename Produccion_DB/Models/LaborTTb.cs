using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LaborTTb
{
    public string Temporada { get; set; } = null!;

    public int SiembraNumero { get; set; }

    public string Departamento { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public bool? AplicarATodo { get; set; }

    public string? AplicarA { get; set; }

    public virtual ICollection<DdtLaborTb> DdtLaborTbs { get; set; } = new List<DdtLaborTb>();

    public virtual DepartamentoTb DepartamentoNavigation { get; set; } = null!;

    public virtual LaboresTb LaboresTb { get; set; } = null!;

    public virtual TemporadaTb TemporadaNavigation { get; set; } = null!;
}
