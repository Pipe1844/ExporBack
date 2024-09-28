using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ConsultasTb
{
    public string Departamento { get; set; } = null!;

    public string NombreConsulta { get; set; } = null!;

    public string Comando { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual DepartamentoTb DepartamentoNavigation { get; set; } = null!;
}
