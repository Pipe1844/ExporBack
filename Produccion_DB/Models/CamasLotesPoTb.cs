using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class CamasLotesPoTb
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public int NumeroCama { get; set; }

    public double? Longitud { get; set; }

    public virtual ICollection<LcCtraspSembradorTb> LcCtraspSembradorTbs { get; set; } = new List<LcCtraspSembradorTb>();

    public virtual LotesPoTb LotesPoTb { get; set; } = null!;
}
