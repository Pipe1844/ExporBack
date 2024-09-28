using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class NavegadorVw
{
    public string Temporada { get; set; } = null!;

    public double? AreaFisica { get; set; }

    public double? AreaTotal { get; set; }

    public string Labor { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int Personas { get; set; }

    public string Descripcion { get; set; } = null!;
}
