using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLaboresLotesTb
{
    public string Departamento { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public bool? AplicarATodo { get; set; }

    public string? AplicarA { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public virtual DepartamentoTb DepartamentoNavigation { get; set; } = null!;

    public virtual ICollection<KnDdtLaborTb> KnDdtLaborTbs { get; set; } = new List<KnDdtLaborTb>();

    public virtual LaboresTb LaboresTb { get; set; } = null!;
}
