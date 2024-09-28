using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class UnionLaboresKnPoDepVwCruzadoVw
{
    public string Departamento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public int? Domingo { get; set; }

    public int? Lunes { get; set; }

    public int? Martes { get; set; }

    public int? Miercoles { get; set; }

    public int? Jueves { get; set; }

    public int? Viernes { get; set; }

    public int? Sabado { get; set; }
}
