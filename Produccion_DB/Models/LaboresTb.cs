using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LaboresTb
{
    public string Labor { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual DepartamentoTb DepartamentoNavigation { get; set; } = null!;

    public virtual ICollection<KnLaboresLotesTb> KnLaboresLotesTbs { get; set; } = new List<KnLaboresLotesTb>();

    public virtual ICollection<LaborTTb> LaborTTbs { get; set; } = new List<LaborTTb>();

    public virtual ICollection<NavegadorTb> NavegadorTbs { get; set; } = new List<NavegadorTb>();
}
