﻿using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPoLotesLaboresDdtProductosVw
{
    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public double? AreaSiembra { get; set; }

    public DateOnly? FechaBase { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaLabor { get; set; }

    public int? DiaSemanaDomSab { get; set; }

    public string IdProducto { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public int DosisHa { get; set; }

    public double? DosisLote { get; set; }

    public double? HorasAgua { get; set; }

    public double? HorasInyeccion { get; set; }

    public double? HorasLavado { get; set; }

    public double? HorasTotal { get; set; }
}
