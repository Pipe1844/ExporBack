using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class RgRiegoTb
{
    public int IdRiego { get; set; }

    public string IdCabezal { get; set; } = null!;

    public string TemporadaSafra { get; set; } = null!;

    public DateTime FechaRinyeccion { get; set; }

    public string? NumBoleta { get; set; }

    public string Cultivo { get; set; } = null!;

    public double? HorasRiego { get; set; }

    public double? PsiEntrada { get; set; }

    public double? PsiSalida { get; set; }

    public double? CaudalimetroInicial { get; set; }

    public double? CaudalimetroFinal { get; set; }

    public string? Observaciones { get; set; }

    public virtual RgCabezalTb IdCabezalNavigation { get; set; } = null!;

    public virtual ICollection<KnPoInyeccionProductosTb> KnPoInyeccionProductosTbs { get; set; } = new List<KnPoInyeccionProductosTb>();

    public virtual ICollection<RgEncargadoRinyeccionTb> RgEncargadoRinyeccionTbs { get; set; } = new List<RgEncargadoRinyeccionTb>();
}
