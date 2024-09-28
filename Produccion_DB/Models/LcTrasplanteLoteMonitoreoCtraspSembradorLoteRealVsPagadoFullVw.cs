using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LcTrasplanteLoteMonitoreoCtraspSembradorLoteRealVsPagadoFullVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaTrasplante { get; set; }

    public double? AreaSegunProgOperativo { get; set; }

    public double? AreaSegunLongitudCamas { get; set; }

    public double? AreaPagada { get; set; }

    public double? DifAreaPoMLogCamas { get; set; }

    public double? DifAreaPoMPagada { get; set; }

    public double? DifAreaLogCamasMPagada { get; set; }

    public double? DifPagoPoMPagada { get; set; }

    public double? DifPagoLogCamasMPagada { get; set; }
}
