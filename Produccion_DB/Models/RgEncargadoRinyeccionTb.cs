using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class RgEncargadoRinyeccionTb
{
    public string IdEncargado { get; set; } = null!;

    public int IdRiego { get; set; }

    public string IdCabezal { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? FugueroCabezalero { get; set; }

    public virtual RgRiegoTb RgRiegoTb { get; set; } = null!;
}
