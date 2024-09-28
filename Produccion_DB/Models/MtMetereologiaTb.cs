using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtMetereologiaTb
{
    public DateTime Fecha { get; set; }

    public TimeOnly Hora { get; set; }

    public double VelocidadViento { get; set; }

    public double Precipitacion { get; set; }

    public double Piranometro { get; set; }

    public double HumedadRelativa { get; set; }

    public double Temperatura { get; set; }

    public double DireccionViento { get; set; }
}
