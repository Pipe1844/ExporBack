using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ScizerDatosCosechaTemporadaVw
{
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

    public DateOnly? Fecha { get; set; }

    public double? Destandar { get; set; }

    public int? FrutosScizers { get; set; }

    public double? KilosScizers { get; set; }

    public double? PesoFrutoScizers { get; set; }

    public double? KgHaScizers { get; set; }

    public double KilosBrutoPila { get; set; }

    public double? KgHaPila { get; set; }

    public double? KilosScizerAhibridoLote { get; set; }

    public double? KgExportableScizerAhibridoLote { get; set; }

    public double? RechazoScizerAhibridoLote { get; set; }

    public int? FrutosScizersAliasHibridoLote { get; set; }

    public double? KilosScizersAliasHibridoLote { get; set; }

    public double? KgHaScizersAliasHibridoLote { get; set; }

    public int? FrutosScizersAliasHibrido { get; set; }

    public double? KilosScizersAliasHibrido { get; set; }

    public double? PesoFrutoScizersAliasHibrido { get; set; }

    public double? KgHaScizersAliasHibrido { get; set; }

    public int? FrutosTemporada { get; set; }

    public double? KilosTemporada { get; set; }

    public double? PesoFrutoTemporada { get; set; }

    public double? KgHaTemporada { get; set; }
}
