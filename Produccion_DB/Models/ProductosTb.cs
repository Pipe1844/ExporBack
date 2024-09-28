using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ProductosTb
{
    public string IdProducto { get; set; } = null!;

    public string NombreDescriptivo { get; set; } = null!;

    public string? TipoUso { get; set; }

    public string NombreComercial { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public string? IngredienteActivo { get; set; }

    public string? ConcentracionIactivo { get; set; }

    public double? RestriccionIngreso { get; set; }

    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<CertificacionesTb> CertificacionesTbs { get; set; } = new List<CertificacionesTb>();

    public virtual ICollection<FtPedidoProductosTb> FtPedidoProductosTbs { get; set; } = new List<FtPedidoProductosTb>();

    public virtual ICollection<KnPoPedidoProductosTb> KnPoPedidoProductosTbs { get; set; } = new List<KnPoPedidoProductosTb>();

    public virtual ICollection<KnProductosALaborTb> KnProductosALaborTbs { get; set; } = new List<KnProductosALaborTb>();

    public virtual ICollection<PoProductosALaborTb> PoProductosALaborTbs { get; set; } = new List<PoProductosALaborTb>();
}
