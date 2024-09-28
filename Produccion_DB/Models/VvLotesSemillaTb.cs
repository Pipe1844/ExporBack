using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvLotesSemillaTb
{
    public string LoteSemilla { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public virtual HibridosTb HibridosTb { get; set; } = null!;

    public virtual ICollection<VvSemillasTb> VvSemillasTbs { get; set; } = new List<VvSemillasTb>();

    public virtual ICollection<VvSiembraViveroTb> VvSiembraViveroTbs { get; set; } = new List<VvSiembraViveroTb>();
}
