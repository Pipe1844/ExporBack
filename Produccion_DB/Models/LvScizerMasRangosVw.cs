using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LvScizerMasRangosVw
{
    public string NombreScizer { get; set; } = null!;

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public double? AreaVariedad { get; set; }

    public DateTime FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public double? Destandar { get; set; }

    public string NombreRango { get; set; } = null!;

    public double MayorIgualQue { get; set; }

    public double MenorQue { get; set; }

    public int FrutosRango { get; set; }

    public double KilosRango { get; set; }

    public double PesoFrutoRango { get; set; }
}
