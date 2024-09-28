using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoLotesLaboresDdtProductosHorasCabezalVw
{
    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string? Cabezal { get; set; }

    public DateOnly? FechaLabor { get; set; }

    public int? DiaSemanaDomSab { get; set; }

    public double? HorasTotal { get; set; }
}
