using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class RgRiegoLotesVw
{
    public int IdRiego { get; set; }

    public string IdCabezal { get; set; } = null!;

    public string TemporadaSafra { get; set; } = null!;

    public DateTime FechaRinyeccion { get; set; }

    public string? NumBoleta { get; set; }

    public double? HorasRiego { get; set; }

    public double? PsiEntrada { get; set; }

    public double? PsiSalida { get; set; }

    public double? CaudalimetroInicial { get; set; }

    public double? CaudalimetroFinal { get; set; }

    public string? Observaciones { get; set; }

    public double? ConstanteCaudal { get; set; }

    public string Cultivo { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string AliasLote { get; set; } = null!;

    public double AreaSiembra { get; set; }
}
