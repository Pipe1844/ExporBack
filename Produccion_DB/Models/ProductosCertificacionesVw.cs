using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ProductosCertificacionesVw
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

    public string NombreCertificacion { get; set; } = null!;

    public int DdtPrecosecha { get; set; }

    public string? Comentarios { get; set; }
}
