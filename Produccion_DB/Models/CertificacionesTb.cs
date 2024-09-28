using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class CertificacionesTb
{
    public string IdProducto { get; set; } = null!;

    public string NombreCertificacion { get; set; } = null!;

    public int DdtPrecosecha { get; set; }

    public string? Comentarios { get; set; }

    public virtual ProductosTb IdProductoNavigation { get; set; } = null!;
}
