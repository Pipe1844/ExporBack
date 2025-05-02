using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LotesFisicosTb
{
    public string NombreLote { get; set; } = null!;

    public bool? Activo { get; set; }

    public double? Area { get; set; }

    public string? Descripcion { get; set; }

    //public virtual ICollection<CamasLotesFisicosTb> CamasLotesFisicosTbs { get; set; } = new List<CamasLotesFisicosTb>();

    //public virtual ICollection<CentroCostoTb> CentroCostoTbs { get; set; } = new List<CentroCostoTb>();

    //public virtual ICollection<KnLotesCanaTb> KnLotesCanaTbs { get; set; } = new List<KnLotesCanaTb>();

    //public virtual ICollection<LotesPoTb> LotesPoTbs { get; set; } = new List<LotesPoTb>();

    //public virtual ICollection<ValvulasTb> ValvulasTbs { get; set; } = new List<ValvulasTb>();
}
