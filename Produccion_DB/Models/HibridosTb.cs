using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class HibridosTb
{
    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string? Identificador { get; set; }

    public string? Abreviatura { get; set; }

    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<HibridosPoTb> HibridosPoTbs { get; set; } = new List<HibridosPoTb>();

    public virtual ICollection<KnLotesCanaTb> KnLotesCanaTbs { get; set; } = new List<KnLotesCanaTb>();

   // public virtual VariedadTb VariedadTb { get; set; } = null!;

    public virtual ICollection<VvLotesSemillaTb> VvLotesSemillaTbs { get; set; } = new List<VvLotesSemillaTb>();
}
