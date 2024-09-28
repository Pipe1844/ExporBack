﻿using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnLaboresDdtProductosVw
{
    public string Departamento { get; set; } = null!;

    public string Labor { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public bool? AplicarATodo { get; set; }

    public string? AplicarA { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public int Ddt { get; set; }

    public double? DosisHa { get; set; }

    public double HorasAgua { get; set; }

    public double HorasInyeccion { get; set; }

    public double HorasLavado { get; set; }

    public string IdProducto { get; set; } = null!;

    public string NombreDescriptivo { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;
}