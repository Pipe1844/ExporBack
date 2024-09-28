﻿using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtSumaxDiaVw
{
    public DateOnly FechaHora { get; set; }

    public int IdPlubiometro { get; set; }

    public bool Activo { get; set; }

    public string Ubicacion { get; set; } = null!;

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public double? CantidadMm { get; set; }
}
