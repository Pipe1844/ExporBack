using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class UnionLaboresDdtProductosKnPoDepSumDosisLotesVw
{
    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public DateOnly? FechaLabor { get; set; }

    public string IdProducto { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public double? SumasDosis { get; set; }
}
