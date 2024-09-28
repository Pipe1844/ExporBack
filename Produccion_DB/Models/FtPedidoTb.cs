using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtPedidoTb
{
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

    public DateOnly? FechaPedido { get; set; }

    public double? NumCargas { get; set; }

    public bool Requisado { get; set; }

    public string? Aprueba { get; set; }

    public string? Recive { get; set; }

    public string? Rmezclero { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<FtApruebaProductoTb> FtApruebaProductoTbs { get; set; } = new List<FtApruebaProductoTb>();

    public virtual ICollection<FtEntregaProductoTb> FtEntregaProductoTbs { get; set; } = new List<FtEntregaProductoTb>();

    public virtual ICollection<FtPedidoProductosTb> FtPedidoProductosTbs { get; set; } = new List<FtPedidoProductosTb>();

    public virtual ICollection<FtRdistribuidorProductoTb> FtRdistribuidorProductoTbs { get; set; } = new List<FtRdistribuidorProductoTb>();
}
