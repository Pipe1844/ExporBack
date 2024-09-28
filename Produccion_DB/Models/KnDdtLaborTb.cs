using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnDdtLaborTb
{
    public string Departamento { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public int Ddt { get; set; }

    public virtual KnLaboresLotesTb KnLaboresLotesTb { get; set; } = null!;

    public virtual ICollection<KnProductosALaborTb> KnProductosALaborTbs { get; set; } = new List<KnProductosALaborTb>();
}
