using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class RgRiegoLotesAreaRiegoVw
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

    public double? ConstanteCaudal { get; set; }

    public double? VolumenRiegoM3 { get; set; }

    public double? AreaRiego { get; set; }

    public double? VolumenM3HoraHa { get; set; }
}
