using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvSiembraViveroTb
{
    public int DiaSiembra { get; set; }

    public string LoteSemilla { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public DateOnly? FechaSiembra { get; set; }

    public double? CantidadSemilla { get; set; }

    public double? NumBandejas { get; set; }

    public virtual VvLotesSemillaTb VvLotesSemillaTb { get; set; } = null!;

    public virtual ICollection<VvSalidaViveroTb> VvSalidaViveroTbs { get; set; } = new List<VvSalidaViveroTb>();
}
