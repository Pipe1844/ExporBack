using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoPedidoProductosVwMaestroErdrequizaVw
{
    public int NumBoleta { get; set; }

    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public double AreaSiembra { get; set; }

    public DateOnly FechaBase { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaPedido { get; set; }

    public bool Requisado { get; set; }

    public string? Aprueba { get; set; }

    public string? Recive { get; set; }

    public string? Rdistribuye { get; set; }

    public string? Rcabezalero { get; set; }
}
