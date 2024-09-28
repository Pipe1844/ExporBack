using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtPlubiometrosMasFechasVwd
{
    public int IdPlubiometro { get; set; }

    public bool Activo { get; set; }

    public string Ubicacion { get; set; } = null!;

    public DateOnly Fecha { get; set; }
}
