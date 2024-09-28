using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class UnionLaboresKnPoDepSumProductosRealVw
{
    public string Temporada { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string IdProducto { get; set; } = null!;

    public string? NombreDescriptivo { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public double? UnidadesTotales { get; set; }
}
