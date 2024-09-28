﻿using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class PilaTb
{
    public DateOnly Fecha { get; set; }

    public string Temporada { get; set; } = null!;

    public int SiembraNum { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string NombreLote { get; set; } = null!;

    public string AliasLote { get; set; } = null!;

    public string Cultivo { get; set; } = null!;

    public string Variedad { get; set; } = null!;

    public string Hibrido { get; set; } = null!;

    public string AliasHibrido { get; set; } = null!;

    public double KilosBrutoPila { get; set; }

    public virtual LvTermporadaTb LvTermporadaTb { get; set; } = null!;
}