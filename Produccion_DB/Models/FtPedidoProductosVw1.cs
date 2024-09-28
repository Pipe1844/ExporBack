using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtPedidoProductosVw1
{
    public double? UnidadesPor1Cargas { get; set; }

    public double? UnidadesPorCargasDesimales { get; set; }

    public string UnidadMedida { get; set; } = null!;

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

    public string? Entrega { get; set; }

    public string? Rdistribuidor { get; set; }

    public string IdProducto { get; set; } = null!;

    public string? NombreDescriptivo { get; set; }

    public double? UnidadesPorLote { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaHoraEjecuta { get; set; }
}
