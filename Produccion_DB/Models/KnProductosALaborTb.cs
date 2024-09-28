using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnProductosALaborTb
{
    public string Departamento { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public int Ddt { get; set; }

    public string IdProducto { get; set; } = null!;

    public string NombreDescriptivo { get; set; } = null!;

    public double? DosisHa { get; set; }

    public double HorasAgua { get; set; }

    public double HorasInyeccion { get; set; }

    public double HorasLavado { get; set; }

    public virtual ProductosTb IdProductoNavigation { get; set; } = null!;

    public virtual KnDdtLaborTb KnDdtLaborTb { get; set; } = null!;
}
