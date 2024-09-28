using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class LotesVariedadAreaVw
{
    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string AliasLote { get; set; } = null!;

    public string Tratamiento { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public DateOnly? FechaTrasplante { get; set; }

    public string AliasHibrido { get; set; } = null!;

    public string? ProgFertilizacion { get; set; }

    public string? ProgFitoProteccion { get; set; }
}
