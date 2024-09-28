using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteHibridosTb
{
    public string Temporada { get; set; } = null!;

    public string Tratamiento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public int? CamaInicial { get; set; }

    public int? CamaFinal { get; set; }

    public virtual HibridosPoTb HibridosPoTb { get; set; } = null!;

    public virtual LcTrasplanteLoteTb LcTrasplanteLoteTb { get; set; } = null!;
}
