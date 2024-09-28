using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ScizerTb
{
    public string NombreScizer { get; set; } = null!;

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public DateTime FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public double? Destandar { get; set; }

    public virtual LvTermporadaTb LvTermporadaTb { get; set; } = null!;

    public virtual ICollection<RangosScizerTb> RangosScizerTbs { get; set; } = new List<RangosScizerTb>();
}
