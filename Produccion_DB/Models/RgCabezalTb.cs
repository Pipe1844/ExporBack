using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class RgCabezalTb
{
    public string IdCabezal { get; set; } = null!;

    public double? ConstanteCaudal { get; set; }

    public string? TipoCaudalimetro { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<RgMotor> RgMotors { get; set; } = new List<RgMotor>();

    public virtual ICollection<RgRiegoTb> RgRiegoTbs { get; set; } = new List<RgRiegoTb>();
}
