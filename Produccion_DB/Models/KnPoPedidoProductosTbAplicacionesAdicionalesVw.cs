using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoPedidoProductosTbAplicacionesAdicionalesVw
{
    public int IdPedido { get; set; }

    public string IdProducto { get; set; } = null!;

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaBase { get; set; }

    public int Ddt { get; set; }

    public double AreaSiembra { get; set; }

    public double UnidadesPorLote { get; set; }

    public string NombreDescriptivo { get; set; } = null!;

    public DateOnly? FechaPedido { get; set; }

    public bool Requisado { get; set; }
}
