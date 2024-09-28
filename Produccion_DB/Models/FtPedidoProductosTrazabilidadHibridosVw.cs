﻿using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtPedidoProductosTrazabilidadHibridosVw
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

    public string IdProducto { get; set; } = null!;

    public string? NombreDescriptivo { get; set; }

    public string? Observaciones { get; set; }

    public double? UnidadesPorLote { get; set; }

    public string? MotivoPaplicacion { get; set; }

    public string NombreCertificacion { get; set; } = null!;

    public int DdtPrecosecha { get; set; }

    public string? CodigosTrazabilidad { get; set; }

    public DateTime? FechaCosecha { get; set; }

    public string TodosLosHibridos { get; set; } = null!;

    public string NombreComercial { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public string? IngredienteActivo { get; set; }

    public string? ConcentracionIactivo { get; set; }

    public double? RestriccionIngreso { get; set; }

    public string? Descripcion { get; set; }
}