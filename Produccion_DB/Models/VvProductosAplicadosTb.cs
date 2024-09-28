using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class VvProductosAplicadosTb
{
    public int IdAplicacion { get; set; }

    public string IdProducto { get; set; } = null!;

    public string NombreDescriptivo { get; set; } = null!;

    public double CantidadAplicada { get; set; }

    public string? MotivoAplicacion { get; set; }

    public virtual VvAplicacionTb IdAplicacionNavigation { get; set; } = null!;
}
