using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class UnionLaboresKnPoDepRealVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaBase { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaPedido { get; set; }

    public string? Aprueba { get; set; }

    public string IdProducto { get; set; } = null!;

    public string? NombreDescriptivo { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public double? UnidadesPorLote { get; set; }

    public DateTime? FechaHoraAprueba { get; set; }
}
