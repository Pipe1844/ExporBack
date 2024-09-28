using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VariedadTb
{
    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string? NombreAbreviatura { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<HibridosPoTb> HibridosPoTbs { get; set; } = new List<HibridosPoTb>();

    public virtual ICollection<HibridosTb> HibridosTbs { get; set; } = new List<HibridosTb>();
}
