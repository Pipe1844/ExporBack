using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtEstadoLarvaTb
{
    public int IdLarva { get; set; }

    public int IdMfruto { get; set; }

    public string EstadoLarva { get; set; } = null!;

    public int Cantidad { get; set; }
}
