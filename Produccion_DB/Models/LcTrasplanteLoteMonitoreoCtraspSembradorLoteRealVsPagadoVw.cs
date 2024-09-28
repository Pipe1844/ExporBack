using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaTrasplante { get; set; }

    public double? AreaSegunProgOperativo { get; set; }

    public double? AreaPagada { get; set; }

    public double? DifHa { get; set; }

    public double? DifPago { get; set; }
}
