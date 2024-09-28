using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class RgMotor
{
    public string IdMotor { get; set; } = null!;

    public string IdCabezal { get; set; } = null!;

    public string? NombreMotor { get; set; }

    public string? Descripcion { get; set; }

    public virtual RgCabezalTb IdCabezalNavigation { get; set; } = null!;
}
