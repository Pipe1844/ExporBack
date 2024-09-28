using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoPedidoProductosTb
{
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

    public double AreaSiembra { get; set; }

    public double UnidadesPorLote { get; set; }

    public string NombreDescriptivo { get; set; } = null!;

    public DateOnly? FechaPedido { get; set; }

    public bool Requisado { get; set; }

    public string? Aprueba { get; set; }

    public string? Recive { get; set; }

    public string? Rdistribuye { get; set; }

    public string? Rcabezalero { get; set; }

    public virtual ICollection<ApruebaProductoTb> ApruebaProductoTbs { get; set; } = new List<ApruebaProductoTb>();

    public virtual ICollection<EntregaProductoTb> EntregaProductoTbs { get; set; } = new List<EntregaProductoTb>();

    public virtual ProductosTb IdProductoNavigation { get; set; } = null!;

    public virtual ICollection<KnPoInyeccionProductosTb> KnPoInyeccionProductosTbs { get; set; } = new List<KnPoInyeccionProductosTb>();

    public virtual ICollection<RcabezaleroProductoTb> RcabezaleroProductoTbs { get; set; } = new List<RcabezaleroProductoTb>();

    public virtual ICollection<RdistribuidorProductoTb> RdistribuidorProductoTbs { get; set; } = new List<RdistribuidorProductoTb>();
}
