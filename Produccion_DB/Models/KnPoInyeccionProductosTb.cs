using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoInyeccionProductosTb
{
    public int IdInyeccion { get; set; }

    public int IdRiego { get; set; }

    public string IdCabezal { get; set; } = null!;

    public int IdPedido { get; set; }

    public string IdProducto { get; set; } = null!;

    public int NumBoleta { get; set; }

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly FechaBase { get; set; }

    public int Ddt { get; set; }

    public double UnidadesPorLote { get; set; }

    public double AreaSiembra { get; set; }

    public string NombreDescriptivo { get; set; } = null!;

    public virtual KnPoPedidoProductosTb KnPoPedidoProductosTb { get; set; } = null!;

    public virtual RgRiegoTb RgRiegoTb { get; set; } = null!;
}
