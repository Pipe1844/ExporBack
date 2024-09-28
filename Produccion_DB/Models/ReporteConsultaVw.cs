using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ReporteConsultaVw
{
    public string Cultivo { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string AliasLabor { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public DateOnly? FechaTrasplante { get; set; }

    public int Ddt { get; set; }

    public DateOnly? FechaLabor { get; set; }

    public int? DiaSemana { get; set; }
}
