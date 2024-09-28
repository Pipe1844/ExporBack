﻿using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class PoLotesLaborDdtProductosVwFt2
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public int AplicarATodo { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public int? Tipo { get; set; }

    public double? AreaSiembra { get; set; }

    public string ProgFitoProteccion { get; set; } = null!;

    public DateOnly? FechaBase { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaLabor { get; set; }

    public int? DiaSemanaDomSab { get; set; }

    public string IdProducto { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public int DosisHa { get; set; }

    public decimal? DosisLote { get; set; }

    public int HorasAgua { get; set; }

    public int HorasInyeccion { get; set; }

    public int HorasLavado { get; set; }

    public int HorasTotal { get; set; }
}